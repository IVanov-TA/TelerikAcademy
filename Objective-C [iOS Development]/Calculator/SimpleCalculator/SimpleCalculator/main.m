//
//  main.m
//  SimpleCalculator
//
//  Created by IV on 10/26/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Calculator.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        float initNumber = 4.13f;
        float operatingNumber = 10.0f;
        
        Calculator *calculator = [[Calculator alloc] initSelf:initNumber];
        NSLog(@"Initial value -> %@", calculator.value);
        
        NSLog(@"Add with %f", operatingNumber);
        float result = [calculator add: operatingNumber];
        NSLog(@"%f", result);
        
        
        NSLog(@"Substarct with %f", operatingNumber);
        result = [calculator substract: operatingNumber];
        NSLog(@"%f", result);
        
        NSLog(@"Multiply with %f", operatingNumber);
        result = [calculator multiply: operatingNumber];
        NSLog(@"%f", result);

        NSLog(@"Divide with %f", operatingNumber);
        result = [calculator divide: operatingNumber];
        NSLog(@"%f", result);
        
    }
    return 0;
}
