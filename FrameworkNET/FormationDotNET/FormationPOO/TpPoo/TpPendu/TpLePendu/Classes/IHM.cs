using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLePendu.Classes
{
    internal class IHM
    {
        LePendu lePendu;

        public void Start()
        {
           lePendu = new LePendu();
            Console.WriteLine("Debut de l'IHM");
        }

        private static void Menu()
        {

        }

        private static void PickChar()
        {

        }

        private static void OnRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnCyan(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void WaitUser()
        {

        }

        private static void Loose()
        {

        }

        private static void Win()
        {

        }

        private static void Exit()
        {

        }
    }
}
