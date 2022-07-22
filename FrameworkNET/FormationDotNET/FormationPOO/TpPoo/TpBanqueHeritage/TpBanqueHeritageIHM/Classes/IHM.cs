using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpBanqueHeritageClass.Classes;
using TpBanqueHeritageIHM.Data;

namespace TpBanqueHeritageIHM.Classes
{
    internal class IHM
    {
        Banque bank;
        private void Init()
        {
            bank = new();
            bank.Comptes = AjoutCompteUtilisateur.Injecter();
        }
        
        public void Start()
        {
            Init();
        }


    }
}
