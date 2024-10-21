﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {

        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = portfolioContext.Features.ToList();
            return View(value);
        }
    }
}
