using Microsoft.AspNetCore.Mvc;
using ViewCompanentsNETCORE.Models;

namespace ViewCompanentsNETCORE.ViewComponents
{
    //[ViewComponent]
    public class AdminMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menulistesi = new List<AdminMenu>
            {
                new AdminMenu
                {
                    Name="Anasayfa",
                    urlMenu="Home",
                },
                 new AdminMenu
                {
                    Name="Şifre değiştir",
                    urlMenu="degistir şifre",
                },
                   new AdminMenu
                {
                    Name="Abone ol",
                    urlMenu="Abone ol",
                },
            };
            return View(menulistesi);   
        }
    }
}
