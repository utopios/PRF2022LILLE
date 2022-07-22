using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBanqueHeritageClass.Classes
{
    internal class Compte
    {
        private static int instanceCounter=0;
        private int id;
        private decimal solde;
        private Client clienBanque;
        private List<Operation> operations;

        public Compte()
        {
            Id = ++instanceCounter;
            Operations = new();
        }

        public Compte( decimal solde, Client clienBanque ):this()
        {            
            Solde = solde;
            ClienBanque = clienBanque;
        }


        public int Id { get => id; init => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public Client ClienBanque { get => clienBanque; set => clienBanque = value; }
        public List<Operation> Operations { get => operations; set => operations = value; }

        public virtual bool Retrait()
        {
            return true;
        }

        public virtual bool Depot()
        {
            return true;
        }

        public virtual bool AjouterCompte() // Dans la liste de compte de la class banque
        {
            return true;
        }

        public virtual bool RechercherCompte() // Dans la liste de compte de la class banque
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
