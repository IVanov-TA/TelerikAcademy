//
//  main.m
//  TODO List
//
//  Created by IV on 10/26/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "TODOItem.h"
#import "TODOdb.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        TODOdb *todoListDb = [[TODOdb alloc] init];
        NSDateFormatter *dateFormat = [[NSDateFormatter alloc]
                                       initWithDateFormat:@"%b %d %Y"
                                       allowNaturalLanguage:NO];
        
        TODOItem *item1 = [[TODOItem alloc] initWithText:@"Buy some kind of BEER" andDeadLine: [dateFormat dateFromString:@"Oct 29 2014"]];
        
        TODOItem *item2 = [[TODOItem alloc] initWithText:@"Won't do this" andDeadLine: [dateFormat dateFromString:@"Oct 01 2014"]];
        
        [todoListDb.todos addObject:item1];
        [todoListDb.todos addObject:item2];
        
        NSLog(@"All TODO's");
        NSLog(@"%@", [todoListDb todosAll]);
        
        NSLog(@"Active TODO's");
        NSLog(@"%@", [todoListDb activeTodos]);

    }
    return 0;
}
