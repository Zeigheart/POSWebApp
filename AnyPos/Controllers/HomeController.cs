using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnyPos.Models;
using Microsoft.Extensions.Options;
using AnyPos.Utility;
using AnyPos.Factory;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace AnyPos.Controllers
{
    public class HomeController : Controller
    {

        private readonly IOptions<MySettingsModel> appSettings;

        public HomeController(IOptions<MySettingsModel> app)
        {
            appSettings = app;
            ApplicationSettings.ProductAPIBase = appSettings.Value.ProductAPIBase;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Shop()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public async Task<IActionResult> Cart()
        {
            // Initialization.  
            DropdownViewModel model = new DropdownViewModel();
            model.SelectedProductId = "";

            var p = await ApiClientFactory.Instance.GetProducts();

            var selItems= GetProductList(p);
            this.ViewBag.ProductList = selItems;
            ViewBag.MyProducts = JsonConvert.SerializeObject(p);
            ViewData["Message"] = "Your contact page.";

            return View(model);
        }

        private IEnumerable<SelectListItem> GetProductList(List<ProductModel> products)
        {
            // Initialization.  
            SelectList lstobj = null;

            try
            {
                // Loading.  
                var list = products.Select(p =>
                                            new SelectListItem
                                            {
                                                Value = p.productId.ToString(),
                                                Text = p.name
                                            });

                // Setting.  
                lstobj = new SelectList(list, "Value", "Text");
            }
            catch (Exception ex)
            {
                // Info  
                throw ex;
            }

            // info.  
            return lstobj;
        }
        public IActionResult ProductDetail()
        {
            

            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult CheckOut()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Promotion()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
