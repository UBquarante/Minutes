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
        int[] valeursTest = { 90, 45, 120, 0, 200 };
        foreach (int minutes in valeursTest)
        {
            var resultat = ConvertirMinutes(minutes);
            Console.WriteLine($"{minutes} minutes = {resultat.Item1} heures et {resultat.Item2} minutes");
        }
    }
}
