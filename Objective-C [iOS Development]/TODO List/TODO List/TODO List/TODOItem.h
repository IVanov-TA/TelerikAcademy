//
//  TODOItem.h
//  TODO List
//
//  Created by IV on 10/26/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface TODOItem : NSObject

@property(strong, nonatomic) NSString *todoText;
@property(strong, nonatomic) NSDate *deadLine;

-(TODOItem *) initWithText: (NSString *) todoText
               andDeadLine: (NSDate *) deadLine;

-(NSString *) description;

@end
