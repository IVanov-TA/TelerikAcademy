//
//  TODOdb.m
//  TODO List
//
//  Created by IV on 10/26/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import "TODOdb.h"
#import "TODOItem.h"

@implementation TODOdb

- (id)init {
    self = [super init];
    if (self) {
        _todos = [NSMutableArray array];
    }
    return self;
}

- (void)addTodo:(TODOItem *) todo{
    [self.todos addObject: todo];
}

- (NSArray *)todosAll{
    return  [NSArray arrayWithArray:self.todos];
}

-(NSArray *) activeTodos{
    NSMutableArray *arrayToReturn = [[NSMutableArray alloc] init];
    
    for (TODOItem *item in [self todos]) {
        if ([[item deadLine] timeIntervalSinceDate:[NSDate date]] > 0.0f) {
            [arrayToReturn addObject:item];
        }
    }
    
    return arrayToReturn;
}

@end
