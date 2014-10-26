//
//  Calculator.h
//  SimpleCalculator
//
//  Created by IV on 10/26/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Calculator : NSObject

@property(strong, nonatomic) NSDecimalNumber *value;

-(Calculator *) initSelf:(float) number;

-(float) substract: (float) number;
-(float) add: (float) number;
-(float) multiply: (float) number;
-(float) divide: (float) number;

@end
