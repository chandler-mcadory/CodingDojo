// 1. Print 1-255
// print1To255()
// Print all the integers from 1 to 255. 

// function print1To255(){
//     for(var i = 1; i <= 255; i++){
//         console.log(i)
//     }
// }

// print1To255()



// 2. Print Odds 1-255
// printOdds1To255()
// Print all odd integers from 1 to 255. 

// function printOdds1To255(){
//     for(var i = 1; i <= 255; i++){
//         if(i % 2){
//             console.log(i)
//         }
//     }
// }

// printOdds1To255()



// 3. Print Ints and Sum 0-255
// printIntsAndSum0To255()
// Print integers from 0 to 255, and with each integer print the sum so far. 

// function printIntsAndSum0To255(){
//     var sum = 0
//     for(var i = 0; i <= 255; i++){
//         sum = sum + i
//         console.log(i)
//         console.log(sum)
//     }
// }

// printIntsAndSum0To255()



// 4. Iterate and Print Array
// printArrayVals(arr)
// Iterate through a given array, printing each value. 

// function printArrayVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         console.log(arr[i])
//     }
// }

// printArrayVals([1,2,5,4,9,8,-9,-6,5,-7])



// 5. Find and Print Max
// printMaxOfArray(arr)
// Given an array, find and print its largest element. 

// function printMaxOfArray(arr){
//     var max = arr[0]
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] > max){
//             max = arr[i]
//         }
//     }
//     console.log(max)
// }

// printMaxOfArray([1,2,5,4,9,8,-9,-6,5,-7])



// 6. Get and Print Average
// printAverageOfArray(arr)
// Analyze an array’s values and print the average. 

// function printAverageOfArray(arr){
//     var sum = 0
//     for(var i = 0; i < arr.length; i++){
//         sum = sum + arr[i]
//     }
//     console.log(sum/arr.length)
// }

// printAverageOfArray([1,2,5,4,9,8,-9,-6,5,-7])



// 7. Array with Odds
// returnOddsArray1To255()
// Create an array with all the odd integers between 1 and 255 (inclusive).  

// function returnOddsArray1To255(){
//     var arr = []
//     for(var i = 1; i <= 255; i++){
//         if(i % 2){
//             arr.push(i)
//         }
//     }
//     console.log(arr)
// }

// returnOddsArray1To255()



// 8. Square the Values
// squareArrayVals(arr)
// Square each value in a given array, returning that same array with changed values. 

// function squareArrayVals(arr){
//     for(var i = 0; i < arr.length; i++){
//         arr[i] = arr[i] * arr[i]
//     }
//     console.log(arr)
// }

// squareArrayVals([1,2,5,4,9,8,-9,-6,5,-7])



// 9. Greater than Y
// printArrayCountGreaterThanY(arr, y)
// Given an array and a value Y, count and print the number of array values greater than Y. 

// function printArrayCountGreaterThanY(arr, y){
//     var sum = 0
//     for(var i = 0; i < arr.length; i++){
//         if(arr[i] > y){
//             sum = sum + 1
//         }
//     }
//     console.log(sum)
// }

// printArrayCountGreaterThanY([1,2,5,4,9,8,-9,-6,5,-7], 2)



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

// zeroOutArrayNegativeVals([1,2,5,4,9,8,-9,-6,5,-7])



// 11. Max, Min, Average
// printMaxMinAverageArrayVals(arr)
// Given an array, print the max, min and average values for that array.

// function printMaxMinAverageArrayVals(arr){
//     var sum = 0
//     for(var i = 0; i < arr.length; i++){
//         if(i < 1){
//             var max = arr[i]
//             var min = arr[i]
//         }
//         if(max < arr[i]){
//             max = arr[i]
//         }
//         if(min > arr[i]){
//             min = arr[i]
//         }
//         sum = sum + arr[i]
//     }
//     console.log(max, min, sum/arr.length)
// }

// printMaxMinAverageArrayVals([1,2,5,4,9,8,-9,-6,5,-7])



// 12. Shift Array Values
// shiftArrayValsLeft(arr)
// Given an array, move all values forward (to the left) by one index, dropping the first value and leaving a 0 (zero) value at the end of the array.

// function shiftArrayValsLeft(arr){
//     for(var i = 0; i < arr.length-1; i++){
//         arr[i] = arr[i+1]
//     }
//     arr.push(0)
//     console.log(arr)
// }

// shiftArrayValsLeft([1,2,5,4,9,8,-9,-6,5,-7])



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

// swapStringForArrayNegativeVals([1,2,5,4,9,8,-9,-6,5,-7])
