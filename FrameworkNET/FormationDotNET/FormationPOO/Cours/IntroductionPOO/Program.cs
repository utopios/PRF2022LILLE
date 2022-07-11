using IntroductionPOO.Classes;

// Création d'une instance de la classe Voiture
Voiture voitureDeNicolas = new Voiture();
// Ajout des propriétés de notre objet voiture
voitureDeNicolas.Modele = "Clio";
voitureDeNicolas.Couleur = "Blanche";
voitureDeNicolas.Reservoir = 45;
voitureDeNicolas.Autonomie = 850;
// Affchage de l'objet voitureDeNicolas dans la console
Console.WriteLine(voitureDeNicolas);
// Console.WriteLine(voitureDeNicolas.ToString());


Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();
