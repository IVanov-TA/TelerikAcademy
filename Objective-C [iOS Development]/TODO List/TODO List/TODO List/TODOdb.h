//
//  TODOdb.h
//  TODO List
//
//  Created by IV on 10/26/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "TODOItem.h"

@interface TODOdb : NSObject

@property (nonatomic, strong) NSMutableArray *todos;

- (void)addTodo:(TODOItem *) todo;
- (NSArray *)todosAll;
-(NSArray *) activeTodos;

@end
