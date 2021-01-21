
let connection = new signalR.HubConnectionBuilder().withUrl("/gamecreationhub").build();

let id = localStorage.getItem("game id")
let firstPlayerRights = (localStorage.getItem("game" + id + "p1") != null)
let secondPlayerRights = (localStorage.getItem("game" + id + "p2") != null)
let isMemberOfGame = firstPlayerRights || secondPlayerRights

let mainBoard = document.getElementById("main_table")
let leftBoard = document.getElementById("left_table")
let rightBoard = document.getElementById("right_table")

function getXForFirstPlayer(x) {
    return 8 - x
}
function getYForFirstPlayer(y) {
    return y
}
function getXForSecondPlayer(x) {
    return x
}
function getYForSecondPlayer(y) {
    return 8 - y
}

let getX = getXForFirstPlayer
let getY = getYForFirstPlayer
if (!firstPlayerRights && secondPlayerRights) {
    getX = getXForSecondPlayer
    getY = getYForSecondPlayer
}
    
let movePlayer = 0;
let possibleMoves = []
let moveStage = 0;

let Resourses = {
    King: "../images/King.jpg",
    Gold: "../images/Gold.jpg",
    Silver: "../images/Silver.jpg",
    Silver_p: "../images/Silver_p.jpg",
    Knight: "../images/Knight.jpg",
    Knight_p: "../images/Knight_p.jpg",
    Lance: "../images/Lance.jpg",
    Lance_p: "../images/Lance_p.jpg",
    Rook: "../images/Rook.jpg",
    Rook_p: "../images/Rook_p.jpg",
    Bishop: "../images/Bishop.jpg",
    Bishop_p: "../images/Bishop_p.jpg",
    Pawn: "../images/Pawn.jpg",
    Pawn_p: "../images/Pawn.jpg",
    Dot: "../images/dot.png"
}

if (isMemberOfGame) {
    let name1
    let name2
    connection.start().then(function () {
        connection.invoke("getGamePlayersName", id).then(names => {
            name1 = names[0]
            name2 = names[1]
            if (firstPlayerRights) {
                document.getElementById("my_name").innerText = name1
                document.getElementById("opponent_name").innerText = name2
            } else {
                document.getElementById("my_name").innerText = name2
                document.getElementById("opponent_name").innerText = name1
            }
        })
        connection.invoke("getGame", id).then(obj => initDefault(JSON.parse(obj)))
        
    })
}
function initDefault(obj) {
    console.log(obj)
    let cellClassName = "cell"
    for (let i = 0; i < 9; i++) {
        let row = mainBoard.insertRow()
        let rowL = leftBoard.insertRow()
        let rowR = rightBoard.insertRow()
        for (let j = 0; j < 9; j++) {
            let cell = row.insertCell()
            cell.className += cellClassName
            let piece = obj.mainBoard.matrix[getX(i)][getY(j)]._square._piece  
            if (piece != null) {
                let image = document.createElement('img')
                let imagesrc
                switch (piece._piece.pieceClass) {
                    case 1:
                        imagesrc = Resourses.King
                        break;
                    case 2:
                        if (piece.promotion == 1)
                            imagesrc = Resourses.Rook
                        else
                            imagesrc = Resourses.Rook_p
                        break;
                    case 3:
                        if (piece.promotion == 1)
                            imagesrc = Resourses.Bishop
                        else
                            imagesrc = Resourses.Bishop_p
                        break;
                    case 4:
                        imagesrc = Resourses.Gold
                        break;
                    case 5:
                        if (piece.promotion == 1)
                            imagesrc = Resourses.Silver
                        else
                            imagesrc = Resourses.Silver_p
                        break;
                    case 6:
                        if (piece.promotion == 1)
                            imagesrc = Resourses.Knight
                        else
                            imagesrc = Resourses.Knight_p
                        break;
                    case 7:
                        if (piece.promotion == 1)
                            imagesrc = Resourses.Lance
                        else
                            imagesrc = Resourses.Lance_p
                        break;
                    case 8:
                        if (piece.promotion == 1)
                            imagesrc = Resourses.Pawn
                        else
                            imagesrc = Resourses.Pawn_p
                        break;

                }
                image.src = imagesrc
                image.setAttribute("width", "49px")
                image.setAttribute("height", "49px")
                cell.appendChild(image)
            }
            cell.addEventListener('click', e => proceedMainBoardClick(getX(i),getY(j)))
        }
        for (let j = 0; j < 2; j++) {
            let cell1 = rowL.insertCell()
            cell1.className += cellClassName
            let cell2 = rowR.insertCell()
            cell2.className += cellClassName
        }
    }
    
}
function proceedMainBoard(board, side) {

}
function proceedLeftBoard(board, side) {

}
function proceedRightBoard(board, side) {

}
function proceedMainBoardClick(x, y) {
    console.log("click")
    if (moveStage == 0) {
        if ((movePlayer == 0 && firstPlayerRights) || (movePlayer == 1 && secondPlayerRights)) {
            connection.invoke("getpossibleMoves", id, x, y).then(res => {
                if (JSON.parse(res)) {
                    hidePossibleMoves()
                    showPossibleMoves(JSON.parse(res))
                    console.log(res)
                    moveStage = 1
                }

            })
        }
    } else {
        if ((movePlayer == 0 && firstPlayerRights) || (movePlayer == 1 && secondPlayerRights)) {
            let ist = false
            for (el of possibleMoves) {
                console.log(getX(el.y))
                console.log(getY(el.x))
                console.log(x)
                console.log(y)
                if (8-getX(el.y) == x && getY(el.x)== y) {
                    ist = true
                    break
                }
            }
            if (ist) {
                console.log("ASD")
                connection.invoke()
            } else {
                connection.invoke("getpossibleMoves", id, x, y).then(res => {
                    if (JSON.parse(res)) {
                        hidePossibleMoves()
                        showPossibleMoves(JSON.parse(res))
                        console.log(res)
                        moveStage = 1
                    }

                })
            }
        }
    }
    
}
function proceedLeftBoardClick(x,y) {

}
function proceedRightBoardClick(x, y) {

}
function showPossibleMoves(arr) {
    possibleMoves = arr;
    for (el of arr) {
        let image = document.createElement('img')
        image.setAttribute("width", "49px")
        image.setAttribute("width", "49px")
        image.src = Resourses.Dot
        image.className+="label"
        let cell = mainBoard.children[0].children[getX(el.y)].children[getY(el.x)]
        cell.appendChild(image)
    }
}
function makeMove(startingSq, sq) {

}
function hidePossibleMoves() {
    document.querySelectorAll(".label").forEach(e => e.parentNode.removeChild(e));
}