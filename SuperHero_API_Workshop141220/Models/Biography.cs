

namespace SuperHero_API_Workshop141220.Models
{
    public class Biography
    {
        [AcceptVerbs("place-of-birth")]
        public string Place_of_birth { get; set; }
        public string FirstAppearance { get; set; }
        public string Publisher { get; set; }
    }
    }