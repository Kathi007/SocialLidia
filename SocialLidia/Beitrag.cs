using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLidia
{
    class Beitrag : IBeitrag
    {
        public string Inhalt { get; set; }
        public Nutzerdatei Ersteller { get; set; }
    }
}
