// The variable "minimumHeightInches" must be set to at least 42 inches for the rider to ride.
const minimumHeightInches = 52


// The variable "minimumAge" must be set to at least 10 years old for the rider to ride.
const minimumAge = 10



//MVP
var riderHeight = 40

if(riderHeight > minimumHeightInches) {
    console.log("Get on that ride, kiddo!")
} else {
    console.log("Sorry kiddo. Maybe next year.")
}



//Stretch Feature 1
var riderHeight = 60
var riderAge = 1

if(riderHeight > minimumHeightInches && riderAge > minimumAge) {
    console.log("Get on that ride, kiddo!")
} else {
    console.log("Sorry kiddo. Maybe next year.")
}



//Stretch Feature 2
var riderHeight = 60
var riderAge = 1

if(riderHeight > minimumHeightInches || riderAge > minimumAge) {
    console.log("Get on that ride, kiddo!")
} else {
    console.log("Sorry kiddo. Maybe next year.")
}