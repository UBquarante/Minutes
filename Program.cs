using System;

class Program
{
    static (int, int) ConvertirMinutes(int nbMin)
    {
        int heures = nbMin / 60;
        int minutes = nbMin % 60;
        return (heures, minutes);
    }

    static void Main()
    {
        Console.Write("Entrez un nombre de minutes : ");
        if (int.TryParse(Console.ReadLine(), out int nbMin))
        {
            var resultat = ConvertirMinutes(nbMin);
            Console.WriteLine($"{nbMin} minutes = {resultat.Item1} heures et {resultat.Item2} minutes");
        }
        else
        {
            Console.WriteLine("Entrée invalide. Veuillez entrer un entier valide.");
        }
    }
}