var arr = [314, 159]

function addPointsNinjas(){
    var likes1 = document.querySelector(".ninjas")
    arr[0]++
    likes1.innerText = arr[0]
}

function addPointsPirates(){
    var likes1 = document.querySelector(".pirates")
    arr[1]++
    likes1.innerText = arr[1]
}

function subscribe(){
    document.querySelector("#subbox").remove()
}

function gameAlert(){
    alert("The Ninjas have won!")
}

setTimeout(gameAlert, 13000)