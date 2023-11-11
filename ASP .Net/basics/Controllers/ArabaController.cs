using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace basics.Controllers
{
        public class ArabaController : Controller
    {
        public IActionResult Index(){
            var audi = new Araba();
            audi.Id = 1;
            audi.Title = "Audi Marka Araba";
            audi.Description = "Kayseri'de gerceklesecek.";
            audi.Image = "logo.jpg";
            return View(audi);
        }

            
            public IActionResult Detay(){
            var audiler = new List<Araba>{
                new Araba(){
                    Id=1,Title="A6 Sedan Araç",
                    Description="2024 Model",Image="a6.jpg"},
                new Araba(){Id=2,Title="RS6 Araç",
                    Description="2024 Model",Image="rs6.jpg"},
                new Araba(){Id=3,Title="A7 Araç",Description="2024 Model",Image="a7.jpg"},
                new Araba(){Id=4,Title="RS7 Araç",Description="2024 Model",Image="rs7.jpg"}
                                    
                                    
                };
                return View(audiler);
            }
        }
    }
