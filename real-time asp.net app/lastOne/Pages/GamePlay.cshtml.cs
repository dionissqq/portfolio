using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lastOne.Models;
using lastOne.Controllers;
using SignalRChat.Hubs;

namespace lastOne.Pages
{
    public class GamePlayModel : PageModel
    {
        public string firstToken;
        public string secondToken;
        public int id;
        public void OnGet(int id)
        {
            this.id = id;
            firstToken = "player1" + id.ToString();
            secondToken = "player2" + id.ToString();
        }
    }
}
