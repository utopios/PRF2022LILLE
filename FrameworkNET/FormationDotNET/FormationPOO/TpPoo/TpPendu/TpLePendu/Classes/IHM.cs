using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLePendu.Classes
{
    internal class IHM
    {
        public void Start()
        {
            GenerateurMots g = new GenerateurMots();
            Console.WriteLine(g.Generer());
            Console.WriteLine("Debut de l'IHM");
        }
    }
}
