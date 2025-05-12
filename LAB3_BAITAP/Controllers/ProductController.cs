using LAB3_BAITAP.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB3_BAITAP.Controllers
{
    public class ProductController : Controller
    {

        static List<Product> products = new List<Product>()
             {
             new Product() {Id=1,Name="Son",Price=200000},
             new Product() {Id=2,Name="Son",Price= 15000},
             new Product() {Id=3,Name="Sữa",Price=50000},
             new Product() {Id=4,Name="Kẹo",Price= 33000},
             new Product() {Id=5,Name="Bim Bim",Price= 5000}
             };
        public IActionResult Details()
        {
            return View(products);
        }
    }
}