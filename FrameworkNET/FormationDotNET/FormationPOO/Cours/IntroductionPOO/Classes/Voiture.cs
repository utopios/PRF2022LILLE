using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionPOO.Classes
{
    internal class Voiture
    {
        #region Attibuts (Privé)
        private string modele;
        private string couleur;
        private int reservoir;
        private int autonomie;
        #endregion

        #region Constructeurs

        public Voiture()
        {

        }

        public Voiture(string modele, string couleur, int reservoir, int autonomie)
        {
            Modele = modele;
            Couleur = couleur;
            Reservoir = reservoir;
            Autonomie = autonomie;
        }

        #endregion

        #region Proprietes (Publiques)
        public string Modele { get => modele; set => modele = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Reservoir { get => reservoir; set => reservoir = value; }
        public int Autonomie { get => autonomie; set => autonomie = value; }
        #endregion

        #region Méthodes (Fonction appartenant à une classe)
        public override string ToString()
        {
            return $"La voiture est une {Modele} de couleur {Couleur}.\n" +
                     $"Elle a un réservoir de {Reservoir} litres pour une autonomie de {Autonomie} km.";
        }
        #endregion
    }
}
