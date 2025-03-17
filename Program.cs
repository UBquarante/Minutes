using System;

class Program // transformation des minutes en heures
{
    static (int, int) ConvertirMinutes(int nbMin) // renvoie un tuple heures
// et minutes 
    {
        int heures = nbMin / 60;
        int minutes = nbMin % 60;
        return (heures, minutes);
    }

    static void Main() // demande a l'utilisateur un nombre de minutes
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
    }// renvoie un tuple heures et minutes
}
