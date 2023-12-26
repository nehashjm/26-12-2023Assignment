using Day14Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day14Assignment.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        static List<Team> teamList = new List<Team>()
        {
            new Team(){Id=1,Name="India",NOWC="2"},
            new Team(){Id=2,Name="Australia",NOWC="4"},
            new Team(){Id=3,Name="Westindies",NOWC="2"},
            new Team(){Id=4,Name="England",NOWC="1"}
        };
        public ActionResult Index()
        {
            return View(teamList);
        }
        public ActionResult Display()
        {
            return View(teamList);
        }
        public ActionResult Create() 
        {
            return View(teamList);
        }
       
    }
}