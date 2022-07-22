
using LesDelegues.Classes;

Calculatrice c = new();

// Utilisation du delegué avec la méthode Addition
c.Calculer(20.10, 30.45,Addition);
c.Calculer(20.10, 30.45, delegate (double a, double b) { return a - b; } );
c.Calculer(20.10, 30.45, (double a, double b) => { return a * b; } );
c.Calculer(20.10, 30.45, ( a,  b) =>  a / b );


// Utilisation d'un délégué pour l'affichage d'une chaine
c.HowToDiplay("Salut",Afficher);







// Création des fonctions à utiliser en parametre ...
double Addition(double a , double b){ return a + b;}
double Soustraction(double a , double b){ return a - b;}

void Afficher(string s) { Console.WriteLine(s); }
void AfficherPlus(string s) { Console.WriteLine(s+"... et j'en affiche plus!"); }


Console.WriteLine("Appuyez sur ENTER pour fermer...");
Console.Read();
