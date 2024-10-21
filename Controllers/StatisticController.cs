﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2=context.Messages.Count();
            ViewBag.v3=context.Messages.Where(p=>p.IsRead==false).Count();
            ViewBag.v4=context.Messages.Where(p=>p.IsRead==true).Count();
            return View();
        }
    }
}
