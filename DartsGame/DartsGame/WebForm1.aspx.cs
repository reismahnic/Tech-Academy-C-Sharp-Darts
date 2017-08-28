﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DartsGame
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OKBtn_Click(object sender, EventArgs e)
        {
            Game game = new Game("Player1", "Player2");
            string result = game.Play();
            ResultsLbl.Text = result;
        }
    }
}