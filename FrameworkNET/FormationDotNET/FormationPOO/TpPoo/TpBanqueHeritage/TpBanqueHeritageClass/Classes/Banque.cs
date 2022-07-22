using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanqueHeritageClass.Classes
{
    public class Banque
    {
        private List<Compte> comptes = new();

        //public Banque()
        //{
        //    comptes = new List<Compte>();
        //}

        public List<Compte> Comptes { get => comptes; set => comptes = value; }

        public bool AjouterCompte(Compte c)
        {
            int nb1 = Comptes.Count;
            comptes.Add(c);
            int nb2 = Comptes.Count;
            return nb2 - nb1 == 1;
        }

        public Compte RechercherCompte(int id)
        {
            return comptes.Find(compte => compte.Id == id);
        }

    }
}
