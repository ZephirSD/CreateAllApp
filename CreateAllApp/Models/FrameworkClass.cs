using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAllApp.Models
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    public class FrameworkClass
    {
        public string Nom {  get; set; }
        public Uri Logo { get; set; }
        public string Commande { get; set; }

        public FrameworkClass(string nom,  Uri logo, string commande)
        {
            Nom = nom;
            Logo = logo;
            Commande = commande;
        }
    }
}
