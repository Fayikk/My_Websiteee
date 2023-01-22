using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listesi";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Listesi";
            var portfolio = portfolioManager.TGetList();
            return View(portfolio);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proeje Listeleme";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Proje Listeleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            portfolioManager.TAdd(p);
            return RedirectToAction("Index");

        }


        public IActionResult Delete(int id)
        {
            var value = portfolioManager.TGetById(id);
            portfolioManager.TDelete(value);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            ViewBag.v1 = "Proje Güncelleme";
            ViewBag.v2 = "Projeler";
            ViewBag.v3 = "Proje Güncelleme";
            var value = portfolioManager.TGetById(id);
            return View(value);

        }


        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
           
            portfolioManager.TUpdate(portfolio);
            return RedirectToAction("Index");
        }



    }
}
