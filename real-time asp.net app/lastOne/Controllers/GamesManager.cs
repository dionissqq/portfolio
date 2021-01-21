using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lastOne.Models;

namespace lastOne.Controllers
{
    static class GamesManager
    {
        private static Hashtable games = new Hashtable();
        private static int currentFreeId = 1;
        public static int createNewGame(string firstPlayerName)
        {
            games[currentFreeId] = new Game(firstPlayerName);
            currentFreeId++;
            return currentFreeId-1;
        }
        public static bool waitsForSecondPlayer(int id)
        {
            Game game = getGame(id);
            if (game.firstPlayerName != null && game.secondPlayerName == null)
                return true;
            else
                return false;
        }
        public static void setSecondName(string Name, int id)
        {
            Game game = getGame(id);
            game.secondPlayerName = Name;
            games[id] = game;
        }
        public static void  setGame(int id , Game game)
        {
            games[id] = game;
        }
        public static Game getGame(int id)
        {
            if (games[id]!= null)
                return (Game)games[id];
            return null;
        }
        public static void deleteGame(int id)
        {
            games.Remove(id);
        }
    }
}
