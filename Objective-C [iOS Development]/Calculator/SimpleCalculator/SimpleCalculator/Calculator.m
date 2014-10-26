//
//  Calculator.m
//  SimpleCalculator
//
//  Created by IV on 10/26/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import "Calculator.h"

@implementation Calculator

-(Calculator *) initSelf:(float) number{
    Calculator *calculator = [[Calculator alloc] init];
    calculator.value = [[NSDecimalNumber alloc] initWithDouble:number];
    return calculator;
}

-(float) substract: (float) number{
    self.value = [self.value decimalNumberBySubtracting:[[NSDecimalNumber alloc] initWithFloat: number]];
    return [self.value floatValue];
}

-(float) add: (float) number{
    self.value = [self.value decimalNumberByAdding:[[NSDecimalNumber alloc] initWithFloat:number]];
    return [self.value floatValue];
}

-(float) multiply: (float) number{
    self.value = [self.value decimalNumberByMultiplyingBy:[[NSDecimalNumber alloc] initWithFloat:number]];
    return [self.value floatValue];
}

-(float) divide: (float) number{
    self.value = [self.value decimalNumberByDividingBy:[[NSDecimalNumber alloc] initWithFloat:number]];
    return [self.value floatValue];
}


@end
