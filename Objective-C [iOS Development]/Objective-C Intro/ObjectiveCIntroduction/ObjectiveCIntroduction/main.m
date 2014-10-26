//
//  main.m
//  ObjectiveCIntroduction
//
//  Created by IV on 10/25/14.
//  Copyright (c) 2014 IV. All rights reserved.
//

#import <Foundation/Foundation.h>

NSArray* small()
{
    NSArray *matrix = @[
                       @[@1, @2, @3],
                       @[@8, @9, @4],
                       @[@7, @6, @5]
                       ];
    
    return matrix;
}

NSArray* big()
{
    
    NSArray *matrix = @[
                       @[@1, @2, @3, @4],
                       @[@12, @13, @14, @5],
                       @[@11, @2, @3, @6],
                       @[@10, @9, @8, @7]
                       ];
    return matrix;
}

NSArray* biggest()
{
    
    NSArray *matrix = @[
                       @[@1, @2, @3, @4, @5],
                       @[@16, @17, @18, @19, @6],
                       @[@15, @24, @25, @20, @7],
                       @[@14, @23, @22, @21, @8],
                       @[@13, @12, @11, @10, @9]
                       ];
    return matrix;
}

NSArray* createSpiralMatrix(int n) {
    
    // Initialize matrix
    NSMutableArray *matrix = [[NSMutableArray alloc] initWithCapacity:n];
    for (int i = 0; i < n; i++) {
        matrix[i] = [[NSMutableArray alloc] initWithCapacity:n];
        for (int j = 0; j < n; j++) {
            matrix[i][j] = [NSNull null];
        }
    }
    
    // Fill matrix
    int x = 0;
    int y = 0;
    int dx = 0;
    int dy = 1;
    
    for (int i = 0; i < n * n; i++) {
        matrix[x][y] = [NSNumber numberWithInt:i+1];
        int nx = x + dx;
        int ny = y + dy;
        // if (nx, ny) is inside matrix and is empty
        if (0 <= nx && nx < n && 0 <= ny && ny < n && [matrix[nx][ny] isEqual:[NSNull null]]) {
            x = nx;
            y = ny;
        } else {
            // change direction
            int temp = dx;
            dx = dy;
            dy = -temp;
            x = x + dx;
            y = y + dy;
        }
    }
    
    return matrix;
}

void printCurrentMatrix(NSArray *matrix){
    NSMutableString *buffer = [[NSMutableString alloc] init];
    
    for (NSArray *row in matrix) {
        
        [buffer appendString:@"\n"];
        
        for (NSNumber *number in row) {
           [buffer appendFormat:@"%-7d", [number intValue]];
        }
    }


    NSLog(@"%@", buffer);
    
}


int main(int argc, const char * argv[]) {
    @autoreleasepool {
        NSArray *arr = @[small(),
                         big(),
                         biggest()];
        
        for (NSArray *matrix in arr) {
            printCurrentMatrix(matrix);
        }
        
        NSArray *spiralMatrix = createSpiralMatrix(10);
        printCurrentMatrix(spiralMatrix);
        
    }
}
