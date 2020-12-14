using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero_API_Workshop141220.Models
{
    public class SuperHero
    {
        //Toker de Superhero.com
        //1375959772747471

        public string Id { get; set; }
        public Images Image { get; set; }
        public Biography Biography { get; set; }
        public string Name { get; set; }
        
        public Powerstats Powerstats { get; set; }
    }
}
