using System;

class Program 
{
    static (int heures, int minutes) ConvertirMinutes(int nbMin) // sous programme qui retourne un tuple
    {
        // Convertit un nombre de minutes en heures et minutes
        int heures = nbMin / 60;
        int minutes = nbMin % 60;
        return (heures, minutes); // retourne un tuple
    }

    static void Main() // programme principal
    {
        Console.Write("Entrez un nombre de minutes : "); // demande à l'utilisateur d'entrer un nombre
        if (int.TryParse(Console.ReadLine(), out int nbMin)) // vérifie si l'entrée est un entier
        {
            var (heures, minutes) = ConvertirMinutes(nbMin); // décompose le tuple retourné
            Console.WriteLine($"{nbMin} minutes = {heures} heures et {minutes} minutes"); // affiche le résultat
        }
        else
        {
            Console.WriteLine("Entrée invalide. Veuillez entrer un entier valide."); // affiche un message d'erreur
        }
    }
}
