using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SuperHero_API_Workshop141220.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SuperHero_API_Workshop141220.Controllers
{
    public class SuperHeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Hero()
        {
            List<SuperHero> resultat = new List<SuperHero>();
            
            WebClient hero1 = new WebClient();
            WebClient hero2 = new WebClient();
            WebClient hero3 = new WebClient();

            string hero1Address = "https://www.superheroapi.com/api.php/1375959772747471/56";
            string hero2Address = "https://www.superheroapi.com/api.php/1375959772747471/5";
            string hero3Address = "https://www.superheroapi.com/api.php/1375959772747471/32";
            
            // Possibilité de tout mettre dans le même client
            string json1 = hero1.DownloadString(hero1Address);
            string json2 = hero2.DownloadString(hero2Address);
            string json3 = hero3.DownloadString(hero3Address);

            SuperHero superHero1 = JsonConvert.DeserializeObject<SuperHero>(json1);
            SuperHero superHero2 = JsonConvert.DeserializeObject<SuperHero>(json2);
            SuperHero superHero3 = JsonConvert.DeserializeObject<SuperHero>(json3);

            resultat.Add(superHero1);
            resultat.Add(superHero2);
            resultat.Add(superHero3);
       

            return View("hero", resultat);
        }
    }
}
