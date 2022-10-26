// 7. Array with Odds
// returnOddsArray1To255()
// Create an array with all the odd integers between 1 and 255 (inclusive).  

// function returnOddsArray1To255(arr) {
//     for(var i=1; i<=255; i++) {
//         if(i % 2) {
//             arr.push(i)
//         }
//     }
//     console.log(arr)
// }

// returnOddsArray1To255([])


// 8. Square the Values
// squareArrayVals(arr)
// Square each value in a given array, returning that same array with changed values. 

// function squareArrayVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         arr[i] = arr[i] * arr[i];
//     }
//     console.log(arr)
// }

// squareArrayVals([1, 2, 3, 9])


// 9. Greater than Y
// printArrayCountGreaterThanY(arr, y)
// Given an array and a value Y, count and print the number of array values greater than Y. 

// function printArrayCountGreaterThanY(arr, y){
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] > y){
//             console.log(arr[i])
//         }
//     }
// }

// printArrayCountGreaterThanY([1, 2, 3, 6, 5, 4, 8, 7, 9], 5)


// 10. Zero Out Negative Numbers
// zeroOutArrayNegativeVals(arr)
// Return the given array, after setting any negative values to zero. 

// function zeroOutArrayNegativeVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] < 0){
//             arr[i] = 0
//         }
//     }
//     console.log(arr)
// }

// zeroOutArrayNegativeVals([-1, 9, -5, 6, -3, 2])


// 11. Max, Min, Average
// printMaxMinAverageArrayVals(arr)
// Given an array, print the max, min and average values for that array.

// function printMaxMinAverageArrayVals(arr){
//     var max = arr[0]
//     var min = arr[0]
//     var sum = 0
//     for(var i = 0; i < arr.length; i++){
//         if(max < arr[i]){
//             max = arr[i]
//         }
//         if(min > arr[i]){
//             min = arr[i]
//         }
//         sum = sum + arr[i]
//     }
//     console.log(max)
//     console.log(min)
//     console.log(sum/arr.length)
// }

// printMaxMinAverageArrayVals([0, 9, -6, 7, 4, 8, 2, 6])


// 12. Shift Array Values
// shiftArrayValsLeft(arr)
// Given an array, move all values forward (to the left) by one index, dropping the first value and leaving a 0 (zero) value at the end of the array.

// function shiftArrayValsLeft(arr){
//     for(var i = 0; i < arr.length; i++){
//         arr[i] = arr[i + 1]
//     }
//     arr[arr.length-1] = 0
//     console.log(arr)
// }

// shiftArrayValsLeft([5, 8, 6, -4, 7, -1])


// 13. Swap String For Array Negative Values
// swapStringForArrayNegativeVals(arr)
// Given an array of numbers, replace any negative values with the string 'Dojo'.

// function swapStringForArrayNegativeVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] < 0){
//             arr[i] = "Dojo"
//         }
//     }
//     console.log(arr)
// }

// swapStringForArrayNegativeVals([11, -19, 8, -2, 6, -7, 4])