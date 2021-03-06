//
//  MainAdViewController.m
//  biTaKa
//
//  Created by Admin on 28/10/14.
//  Copyright (c) 2014 Admin. All rights reserved.
//

#import "MainAdViewController.h"
#import <Parse/Parse.h>
#import "Item.h"
#import "ItemTableViewCell.h"
#import "DetailViewController.h"
#import "MainScreenViewController.h"
#import "AlertUtility.h"
#import "CoreDataManager.h"
#import "CoreDataItem.h"
#import "ProfileViewController.h"

@interface MainAdViewController ()

@property(nonatomic, strong) CoreDataManager* coreManager;

@end

@implementation MainAdViewController{
    UIRefreshControl *refreshControl;
    Item *deletableItem;
}

-(instancetype)init{
    self = [super init];
    if(self){
        self.items = [NSMutableArray array];
        self.profileDate = [NSMutableArray array];
    }
    return self;
}

-(id)initWithCoder:(NSCoder *)aDecoder{
    if(self = [super initWithCoder:aDecoder]){
        self.items = [NSMutableArray array];
         self.profileDate = [NSMutableArray array];
    }
    return self;
}

-(instancetype)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil{
    
    if(self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil]){
        self.items = [NSMutableArray array];
         self.profileDate = [NSMutableArray array];
    }
    return self;
}

-(NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section{
    return self.items.count;
}

static NSString* cellIdentifier = @"itemCell";

-(UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath{
    ItemTableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:cellIdentifier];
    if(!cell){
        cell = [[ItemTableViewCell alloc] initWithStyle:UITableViewCellStyleDefault reuseIdentifier:cellIdentifier];
    }
    
    Item *it = [self.items objectAtIndex:indexPath.row];
    
    cell.cellItemDescription.text = it.itemDescription;
    NSNumberFormatter *fmt = [[NSNumberFormatter alloc] init];
    [fmt setPositiveFormat:@"0.##"];
    cell.cellItemPrice.text = [NSString stringWithFormat:@"Price: $%@",
                               [fmt stringFromNumber:[NSNumber numberWithFloat:[it.itemPrice floatValue]]]];
    PFFile *thumbnail = it.itemPicture;
    __weak UIImageView *cellImageView = cell.cellItemImage;
    [thumbnail getDataInBackgroundWithBlock:^(NSData *data, NSError *error) {
        UIImage *image = [UIImage imageWithData:data];
        [cell.cellItemImage.layer addAnimation:[self getImageTransition] forKey:nil];
        cellImageView.image = image;
    }];
    
    return cell;
}

-(void)getDataFromCoreData{
    __weak id weakSelf = self;
    
    PFQuery *query = [PFQuery queryWithClassName: [Item parseClassName]];
    [query orderByDescending:@"createdAt"];
    [query whereKey:@"state" equalTo:[NSNumber numberWithBool:YES]];
    [query findObjectsInBackgroundWithBlock:^(NSArray *objects, NSError *error) {
        if (!error) {
            [weakSelf setItems:[NSMutableArray arrayWithArray:objects]];
        } else {
            // Log details of the failure
            NSLog(@"Error: %@ %@", error, [error userInfo]);
        }
    }];
    
    [self.itemTableView reloadData];
    [refreshControl endRefreshing];
}

- (void)viewDidLoad {
    [super viewDidLoad];
    
    refreshControl = [[UIRefreshControl alloc] init];
    [refreshControl addTarget:self action:@selector(getDataFromCoreData) forControlEvents:UIControlEventValueChanged];
    [self.itemTableView addSubview:refreshControl];
    
    // check for authenticate user
    PFUser *user = [PFUser currentUser];
    
    if (user) {
        [self setLogoutButton];
        if ([user.username isEqualToString:@"admin"]) {
            [self addLongPressRecognizer];
        }
    }else{
        [self setLoginButton];
    }
}

// CORE DATA
-(void) initializeCoreData {
    self.coreManager = [[CoreDataManager alloc] init];
    [self.coreManager setupCoreData];
}

-(void) addDataToCoreData {
    CoreDataItem *item1 = [NSEntityDescription insertNewObjectForEntityForName:@"CoreDataItem" inManagedObjectContext:self.coreManager.context];
    item1.itemCategory = [self.items[0] objectForKey:@"itemCategory"];
    item1.itemName = [self.items[0] objectForKey:@"itemName"];
    item1.itemDescription = [self.items[0] objectForKey:@"itemDescription"];
    item1.itemPrice = [self.items[0] objectForKey:@"itemPrice"];
    
    CoreDataItem *item2 = [NSEntityDescription insertNewObjectForEntityForName:@"CoreDataItem" inManagedObjectContext:self.coreManager.context];
    item2.itemCategory = [self.items[1] objectForKey:@"itemCategory"];
    item2.itemName = [self.items[1] objectForKey:@"itemName"];
    item2.itemDescription = [self.items[1] objectForKey:@"itemDescription"];
    item2.itemPrice = [self.items[1] objectForKey:@"itemPrice"];
    
    [self.coreManager.context insertObject:item1];
    [self.coreManager.context insertObject:item1];
    
    [self.coreManager saveContext];
}

-(void) fetchRequest {
    NSFetchRequest *request = [NSFetchRequest fetchRequestWithEntityName:@"CoreDataItem"];
    NSSortDescriptor *sort = [NSSortDescriptor sortDescriptorWithKey:@"itemPrice" ascending:YES];
    [request setSortDescriptors:[NSArray arrayWithObject:sort]];
    NSArray *fetchedObjects = [self.coreManager.context executeFetchRequest:request error:nil];
    
    for (CoreDataItem *item in fetchedObjects) {
        NSLog(@"Item price = %@", item.itemPrice);
        NSLog(@"Item category is %@", item.itemCategory);
    }
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

// segue
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    if ([segue.identifier isEqualToString:@"toCreateItem"]) {
        if ([segue.destinationViewController isKindOfClass:[CreateAdViewController class]]) {
            CreateAdViewController *destVC = segue.destinationViewController;
            destVC.delegate = self;
        }
    }else if ([segue.identifier isEqualToString:@"toDetailView"]){
        DetailViewController *next = [segue destinationViewController];
        NSIndexPath *path = [self.itemTableView indexPathForSelectedRow];
        Item *c = self.items[path.row];
        [next setItemData: c];
    }
    
}

#pragma mark - CreateAddViewControllerDelegate

-(void)addItem:(Item *)item {
    // persist data in Parse
    PFObject *parseObject = [PFObject objectWithClassName:@"Item"];
    //parseObject[@"itemPicture"] = @"";
    parseObject[@"itemCategory"] = item.itemCategory;
    parseObject[@"itemDescription"] = item.itemDescription;
    parseObject[@"itemPrice"] = item.itemPrice;
    
    [parseObject saveInBackground];
    
    [AlertUtility alertWith:@"Message"
                    message:@"Item added"
                  andButton:@"OK"];
    //[[self itemTableView] reloadData];
    
    [self.navigationController popViewControllerAnimated:YES];
}

- (void) logoutEvent:(id)sender
{
    [PFUser logOut];
    [self.navigationController popToRootViewControllerAnimated:YES];
    
}

- (void) setLogoutButton {
    UIBarButtonItem *logOutButton = [[UIBarButtonItem alloc] initWithTitle:@"Logout"
                                                                     style:UIBarButtonItemStylePlain
                                                                    target:self
                                                                    action:@selector(logoutEvent:)];
    
    self.navigationItem.leftBarButtonItem = logOutButton;
    
    UIBarButtonItem *profileButton = [[UIBarButtonItem alloc] initWithTitle:@"Profile"
                                                                     style:UIBarButtonItemStylePlain
                                                                    target:self
                                                                    action:@selector(profileEvent:)];
    self.navigationItem.rightBarButtonItem = profileButton;

}

- (void) loginEvent:(id)sender
{
    MainScreenViewController *loginVC = [self.storyboard instantiateViewControllerWithIdentifier:@"login"];
    [self.navigationController pushViewController:loginVC animated:YES];
    
}

-(void) profileEvent:(id) sender{
    
    NSString *userName = [PFUser currentUser].username;
    PFQuery *query = [PFQuery queryWithClassName: [Item parseClassName]];
    [query orderByDescending:@"createdAt"];
    [query whereKey:@"user" equalTo:userName];
    [query findObjectsInBackgroundWithBlock:^(NSArray *objects, NSError *error) {
        if (!error) {
            // The find succeeded.
            NSLog(@"Successfully retrieved %ld items.", objects.count);
            // Do something with the found objects
            [self setProfileDate:[NSMutableArray arrayWithArray:objects]];
            ProfileViewController *profileVC = [self.storyboard instantiateViewControllerWithIdentifier:@"profileLoad"];
            profileVC.data = self.profileDate;
            [self.navigationController pushViewController:profileVC animated:YES];
        } else {
            // Log details of the failure
            NSLog(@"Error: %@ %@", error, [error userInfo]);
        }
    }];
}

- (void) setLoginButton {
    UIBarButtonItem *loginButton = [[UIBarButtonItem alloc] initWithTitle:@"Login"
                                                                    style:UIBarButtonItemStylePlain
                                                                   target:self
                                                                   action:@selector(loginEvent:)];
    
    self.navigationItem.leftBarButtonItem = loginButton;
}

-(void) makeQueryForTableView{
    __weak id weakSelf = self;
    PFUser *user = [PFUser currentUser];
    
    PFQuery *query = [PFQuery queryWithClassName: [Item parseClassName]];
    [query orderByDescending:@"createdAt"];
    NSLog(@"%@", user.username);
    [query whereKey:@"user" equalTo:user.username];
    [query findObjectsInBackgroundWithBlock:^(NSArray *objects, NSError *error) {
        if (!error) {
            // The find succeeded.
             NSLog(@"Successfully retrieved %ld items.", objects.count);
            // Do something with the found objects
            [weakSelf setProfileDate:[NSMutableArray arrayWithArray:objects]];
        } else {
            // Log details of the failure
            NSLog(@"Error: %@ %@", error, [error userInfo]);
        }
    }];
    
}

- (IBAction)btnNewAd:(id)sender {
    PFUser *user = [PFUser currentUser];
    if (!user) {
        [AlertUtility alertWith:@"Sorry :(" message:@"You must be logged to continue!" andButton:@"Got it!"];
    }else{
        CreateAdViewController *mainLoggedVC = [self.storyboard instantiateViewControllerWithIdentifier:@"createView"];
        [self.navigationController pushViewController:mainLoggedVC animated:YES];
    }
}

-(void)addLongPressRecognizer{
    UILongPressGestureRecognizer *lpgr = [[UILongPressGestureRecognizer alloc]
                                          initWithTarget:self action:@selector(handleLongPress:)];
    lpgr.minimumPressDuration = 0.7;
    lpgr.delegate = self;
    [self.itemTableView addGestureRecognizer:lpgr];
}

-(void)handleLongPress:(UILongPressGestureRecognizer *)gestureRecognizer
{
    CGPoint p = [gestureRecognizer locationInView:self.itemTableView];
    
    NSIndexPath *indexPath = [self.itemTableView indexPathForRowAtPoint:p];
    if (indexPath == nil) {
        NSLog(@"long press on table view but not on a row");
    } else if (gestureRecognizer.state == UIGestureRecognizerStateBegan) {
        deletableItem = [self.items objectAtIndex:indexPath.row];
        
        UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Admin"
                                                        message:@"Are you sure you want to delete it?"
                                                       delegate:self
                                              cancelButtonTitle:@"Cancel"
                                              otherButtonTitles:@"Ok", nil];
        [alert show];
    }
}

-(void)alertView:(UIAlertView *)alertView clickedButtonAtIndex:(NSInteger)buttonIndex{
    if (buttonIndex == 1) {
        PFQuery *query = [PFQuery queryWithClassName: [Item parseClassName]];
        [query whereKey:@"objectId" equalTo: deletableItem.objectId];
        [query getFirstObjectInBackgroundWithBlock:^(PFObject * userStats, NSError *error) {
            if (!error) {
                // Found UserStats
                [userStats setObject:[NSNumber numberWithBool:NO] forKey:@"state"];
                
                // Save
                [userStats saveInBackground];
            } else {
                // Did not find any UserStats for the current user
                NSLog(@"Error: %@", error);
            }
        }];
    }
    
}


-(CATransition*)getImageTransition{
    CATransition *trans = [CATransition animation];
    trans.duration = 0.5f;
    trans.timingFunction = [CAMediaTimingFunction functionWithName:kCAMediaTimingFunctionEaseIn];
    trans.type = kCATransitionFade;
    return trans;
}

@end