//
//  TODOItem.m
//  TODO List
//
//  Created by IV on 10/26/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import "TODOItem.h"

@implementation TODOItem

-(TODOItem *) initWithText: (NSString *) todoText
               andDeadLine: (NSDate *) deadLine {
    TODOItem *currentItem = [[TODOItem alloc] init];
    currentItem.todoText = todoText;
    
    currentItem.deadLine = deadLine;
    
    return currentItem;
}

-(NSString *) description{
    return [NSString stringWithFormat:@"Todo %@ till %@", [self todoText], [self deadLine]];
}

@end
