// 1. Print 1-255
// Print1To255()
// Print all the integers from 1 to 255.

// function Print1To255(){
//     for(var i = 1; i <= 255; i++){
//         console.log(i)
//     }
// }

// Print1To255()



// 2. Print Odds 1-255
// PrintOdds1To255()
// Print all odd integers from 1 to 255.

// function PrintOdds1To255(){
//     for(var i = 1; i <= 255; i++){
//         if(i % 2){
//             console.log(i)
//         }
//     }
// }

// PrintOdds1To255()



// 3. Print Ints and Sum 0-255
// PrintIntsAndSum0To255()
// Print integers from 0 to 255, and with each integer
// print the sum so far.

// function PrintIntsAndSum0To255(){
//     var sum = 0
//     for(var i = 0; i <= 255; i++){
//         sum = sum + i
//         console.log(i)
//         console.log(sum)
//     }
// }

// PrintIntsAndSum0To255()



// 4. Iterate and Print Array
// Iterate through a given array, printing each value.
// PrintArrayVals(arr)

// function PrintArrayVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         console.log(arr[i])
//     }
// }

// PrintArrayVals([1,2,5,4,9,8,-9,-6,5,-7])



// 5. Find and Print Max
// PrintMaxOfArray(arr)
// Given an array, find and print its largest element.

// function PrintMaxOfArray(arr){
//     var max = arr[0]
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] > max){
//             max = arr[i]
//         }
//     }
//     console.log(max)
// }

// PrintMaxOfArray([1,2,5,4,9,8,-9,-6,5,-7])



// 6. Get and Print Average
// PrintAverageOfArray(arr)
// Analyze an array’s values and print the average.

// function PrintAverageOfArray(arr){
//     var sum = 0
//     for(var i = 0; i < arr.length; i++){
//         sum = sum + arr[i]
//     }
//     console.log(sum/arr.length)
// }

// PrintAverageOfArray([1,2,5,4,9,8,-9,-6,5,-7])



// 7. Array with Odds
// ReturnOddsArray1To255()
// Create an array with all the odd integers between 1
// and 255 (inclusive).

// function ReturnOddsArray1To255(){
//     var arr = []
//     for(var i = 1; i <= 255; i++){
//         if(i % 2){
//             arr.push(i)
//         }
//     }
//     console.log(arr)
// }

// ReturnOddsArray1To255()



// 8. Square the Values
// SquareArrayVals(arr)
// Square each value in a given array, returning that
// same array with changed values.

// function SquareArrayVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         arr[i] = arr[i] * arr[i]
//     }
//     console.log(arr)
// }

// SquareArrayVals([1,2,5,4,9,8,-9,-6,5,-7])



// 9. Greater than Y
// ReturnArrayCountGreaterThanY(arr, y)
// Given an array and a value Y, count and print the
// number of array values greater than Y.

// function ReturnArrayCountGreaterThanY(arr, y){
//     var sum = 0
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] > y){
//             sum = sum + 1
//         }
//     }
//     console.log(sum)
// }

// ReturnArrayCountGreaterThanY([1,2,5,4,9,8,-9,-6,5,-7], 2)



// 10. Zero Out Negative Numbers
// ZeroOutArrayNegativeVals(arr)
// Return the given array, after setting any negative
// values to zero.

// function ZeroOutArrayNegativeVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] < 0){
//             arr[i] = 0
//         }
//     }
//     console.log(arr)
// }

// ZeroOutArrayNegativeVals([1,2,5,4,9,8,-9,-6,5,-7])



// 11. Max, Min, Average
// PrintMaxMinAverageArrayVals(arr)
// Given an array, print the max, min and average
// values for that array.

// function PrintMaxMinAverageArrayVals(arr){
//     var sum = 0
//     var max = arr[0]
//     var min = arr[0]
//     for(var i = 0; i < arr.length; i++){
//         if(max < arr[i]){
//             max = arr[i]
//         }
//         if(min > arr[i]){
//             min = arr[i]
//         }
//         sum += arr[i]
//     }
//     console.log(max, min, sum/arr.length)
// }

// PrintMaxMinAverageArrayVals([1,2,5,4,9,8,-9,-6,5,-7])



// 12. Shift Array Values
// ShiftArrayValsLeft(arr)
// Given an array, move all values forward (to the left)
// by one index, dropping the first value and leaving a 0
// (zero) value at the end of the array.

// function ShiftArrayValsLeft(arr){
//     for(var i = 0; i < arr.length-1; i++){
//         arr[i] = arr[i+1]
//     }
//     arr.push(0)
//     console.log(arr)
// }

// ShiftArrayValsLeft([1,2,5,4,9,8,-9,-6,5,-7])



// 13. Swap String For Array Negative Values
// SwapStringForArrayNegativeVals(arr)
// Given an array of numbers, replace any negative
// values with the string 'Dojo'.

// function SwapStringForArrayNegativeVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] < 0){
//             arr[i] = "Dojo"
//         }
//     }
//     console.log(arr)
// }

// SwapStringForArrayNegativeVals([1,2,5,4,9,8,-9,-6,5,-7])