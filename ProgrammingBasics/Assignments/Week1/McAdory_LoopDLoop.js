//We need a loop so that the candy will be handed out at certain intervals in a count from 0 to 6. 
//The loop starts at 0.
//The loop should stop at 6.
//The loop will know to stop based on the conditional of <=6.
//It has an increment of +1.
//We need variables for candy and miles.

var miles = 0
var candy = 1
var runnerSpeed = 6

for (var miles = 2; miles <= 6; miles+=2) {
    console.log("Candy Dispensed: " + candy ++)
    if (runnerSpeed > 5.5)
    console.log("Candy Dispensed: " + candy ++);
}