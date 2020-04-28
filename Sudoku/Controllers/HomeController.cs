using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sudoku.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TicTacToe()
        {
            return View();
        }
        public ActionResult Connect4()
        {
            return View();
        }
        public ActionResult MineSweeper()
        {
            return View();
        }
    }
}