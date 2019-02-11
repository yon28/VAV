using System;
using System.Collections.Generic;
using Entities;
using System.Web.Mvc;

namespace Web.Controllers

{
    public class CardsController : Controller
    {
        List<string> textBoxOnForm;
        List<string> listHand;
        string textProgress;
        string textBooks;
        int listHandSelectedIndex = 1;//
        private Game game;
        public CardsController()
        {
            textBoxOnForm = new List<string>();
            listHand = new List<string>();
            textProgress = "";
            textBooks = "";
            game = new Game("You", new List<string> { "Joe", "Bob" }, textBoxOnForm);
            //buttonAsk.Enabled = true;
            UpdateForm();
        }

        public ActionResult Index()
        {
            return View(listHand);
        }



        public ActionResult Ask()
        {
            textProgress = "";
            if (listHandSelectedIndex < 0)
            {
                // MessageBox.Show("Please select a card");
                return View(listHand);
            }
            if (game.PlayOneRound(listHandSelectedIndex))
            {
                textProgress += "The winner is..." + game.GetWinnerName();
                textBooks = game.DescribeBooks();
                //buttonAsk.Enabled = false;
            }
            else
                UpdateForm();
            return View(listHand);
        }

        private void UpdateForm()
        {
            listHand.Clear();
            foreach (string cardName in game.GetPlayerCardNames())
                listHand.Add(cardName);
            textBooks = game.DescribeBooks();
            foreach (string str in textBoxOnForm)
            {
                textProgress += str;//
            }
            textProgress += game.DescribePlayerHands();

            listHand.Add(textProgress);
            listHand.Add(textBooks);
            //textProgress.SelectionStart = textProgress.Length;
            //textProgress.ScrollToCaret();
        }
    }
}