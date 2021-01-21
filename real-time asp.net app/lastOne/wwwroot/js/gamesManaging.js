"use strict";

let connection = new signalR.HubConnectionBuilder().withUrl("/gamecreationhub").build();

let createButton = document.getElementById("createButton");
let joinButton = document.getElementById("joinButton");

//Disable send button until connection is established
createButton.disabled = true;
joinButton.disabled = true;

connection.start().then(function () {
    createButton.disabled = false;
    joinButton.disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

createButton.addEventListener("click", function (event) {
    let user = document.getElementById("firstPlayerName").value;
    connection.invoke("createGame", user)
        .then(id => {
            connection.on("joined" + id.toString(), function () {
                window.localStorage.setItem("game" + id+"p1", "player1" + id);
                window.location.href = "/play/" + id
            })
        })
        .catch(function (err) {
            return console.error(err.toString());
        });
    event.preventDefault();
});

joinButton.addEventListener("click", e => {
    let user = document.getElementById("secondPlayerName").value;
    let id = document.getElementById("join id").value;
    connection.invoke("joinGame", id, user)
        .then(() => {
            window.localStorage.setItem("game" + id + "p2", "player2" + id);
            window.location.href = "/play/" + id 
        })
        .catch(function (err) {
            return console.error(err.toString());
        });
    })