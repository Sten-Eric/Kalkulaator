class Program
{
    static void Main()
    {
        Console.Write("Esimene arv: ");
        int esimene = int.Parse(Console.ReadLine());

        Console.Write("Teine arv: ");
        int teine = int.Parse(Console.ReadLine());

        Console.Write("Kas (Korruta,Jaga,Liida,Lahuta): ");
        string kolmas = (Console.ReadLine());

        if (kolmas == "Korruta")
        {
            Console.WriteLine(esimene * teine);
        }
        if (kolmas == "Jaga")
        {
            Console.WriteLine(esimene / teine);
        }
        if (kolmas == "Lahuta")
        {
            Console.WriteLine(esimene - teine);
        }
        if (kolmas == "Liida")
        {
            Console.WriteLine(esimene + teine);
        }
    }
}
