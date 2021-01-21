using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using lastOne.Controllers;
using System;
using lastOne.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SignalRChat.Hubs
{
    public class GameCreationHub : Hub
    {
        public async void makeMove(int id, Square stating_sq , Square target_sq)
        {
            string[] strs = { JsonSerializer.Serialize(stating_sq), JsonSerializer.Serialize(target_sq) };
            await Clients.All.SendAsync("move" + id.ToString(),strs);
        }
        public async void renewSideBoards(int id)
        {

        }
        public async void movingPiece(string id,int x,int y)
        {
            try
            {
                int result = Int32.Parse(id);
                Game game = GamesManager.getGame(result);
                Square sq = game.mainBoard.getAt(x, y);
                if (game.move.possibleSquares.Contains(sq))
                {
                    if (sq.getPieceState())
                    {
                        sq.changeOwner(game.move.player);
                        CertainPiece pc = sq.getPiece();
                        pc.depromote();
                        if (game.move.player == Players.Player1)
                            game.pl1SideBoard.AddItem(pc);
                        else
                            game.pl2SideBoard.AddItem(pc);
                        renewSideBoards(result);
                    }
                    if (game.move.startingSquare != null)
                    {
                        sq.setPiece(game.move.startingSquare.getPiece());
                        game.move.startingSquare.removePiece();
                        makeMove(result, game.move.startingSquare, sq);
                    }
                    else
                    {
                        sideBoard board;
                        if (game.move.player == Players.Player1)
                            board = game.pl1SideBoard;
                        else
                            board = game.pl2SideBoard;
                        board.removeItem(game.move.piece);
                        //Globals.move.piece.setPlayer(Globals.move.player);
                        sq.setPiece(game.move.piece);
                        renewSideBoards(result);
                        game.move.piece = null;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
            }
        }
        public async Task<int> createGame(string firstPlayerName)
        {
            int id = GamesManager.createNewGame(firstPlayerName);
            return id;
        }
        public async Task<string> getGame(string id)
        {
            try
            {
                int result = Int32.Parse(id);
                Game game = GamesManager.getGame(result);
                string res =JsonSerializer.Serialize(game);
                Console.WriteLine("asda");
                Console.WriteLine(res);
                return res;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
                string[] str = { "", "" };
                return "error";
            }
        }
        public async void sendGame(Game game) {
            await Clients.All.SendAsync("changes" + game.id.ToString());
        }
        public string[] getGamePlayersName(string id)
        {
            try
            {
                int result = Int32.Parse(id);
                Game game = GamesManager.getGame(result);
                string[] str = { game.firstPlayerName, game.secondPlayerName };
                Console.WriteLine("namw");
                Console.WriteLine(game.secondPlayerName);
                return str;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
                string[] str = { "", "" };
                return str;
            }
        }
        public async Task joinGame(string id, string secondPlayerName)
        {
            try
            {
                int result = Int32.Parse(id);
                if (GamesManager.waitsForSecondPlayer(result))
                {
                    GamesManager.setSecondName(secondPlayerName, result);
                    await sendRedirect(result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
            }
        }
        public async Task sendRedirect(int gameid)
        {
            await Clients.All.SendAsync("joined"+ gameid.ToString());
        }
        public async Task<string> getpossibleMoves(string id, int x,int y)
        {
            try
            {
                int result = Int32.Parse(id);
                Game game = GamesManager.getGame(result);
                Square sq = game.mainBoard.getAt(x, y);

                    if (sq.getPieceState() && sq.getOwner() == game.move.player)
                    {
                        game.move.startingSquare = sq;
                        var sqrs = sq.getPossibleMoves(game.mainBoard, false);
                        game.move.possibleSquares = sqrs;
                        game.move.nextState();
                        GamesManager.setGame(result, game);
                        return JsonSerializer.Serialize(sqrs);
                    }
                return null;    

            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
                return "error";
            }
        }
    }
}
