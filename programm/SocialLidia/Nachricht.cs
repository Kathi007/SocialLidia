using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLidia
{
    class Nachricht : IBeitrag
    {
        public string Inhalt { get; set; }
        public Nutzer Ersteller { get; set; }
    }
}
