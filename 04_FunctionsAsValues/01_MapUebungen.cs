using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Übung 1
        List<int> zahlen = new List<int> { 1, 2, 3, 4, 5 };
        List<int> verdoppelt = zahlen.Select(x => x * 2).ToList();
        Console.WriteLine(string.Join(", ", verdoppelt)); // Ausgabe: 2, 4, 6, 8, 10

        // Übung 2
        List<string> namen = new List<string> { "Alice", "Bob", "Charlie" };
        List<string> grossbuchstaben = namen.Select(x => x.ToUpper()).ToList();
        Console.WriteLine(string.Join(", ", grossbuchstaben)); // Ausgabe: ALICE, BOB, CHARLIE

        // Übung 3
        List<int> zahlen2 = new List<int> { 12, 45, 68, 100 };
        List<double> haelften = zahlen2.Select(x => x / 2.0).ToList();
        Console.WriteLine(string.Join(", ", haelften)); // Ausgabe: 6, 22.5, 34, 50

        // Übung 4
        List<Adresse> adressen = new List<Adresse>
        {
            new Adresse("Hauptstrasse", 10, "12345", "Musterstadt"),
            new Adresse("Nebenstrasse", 5, "23456", "Beispielburg")
        };
        List<string> formatierteAdressen = adressen.Select(a => $"{a.Strasse} {a.Hausnummer}, {a.Postleitzahl} {a.Stadt}").ToList();
        Console.WriteLine(string.Join(", ", formatierteAdressen)); // Ausgabe: Hauptstrasse 10, 12345 Musterstadt, Nebenstrasse 5, 23456 Beispielburg

        // Übung 5
        List<string> namen2 = new List<string> { "Max Mustermann", "Erika Mustermann" };
        List<string> vornamenGroßbuchstaben = namen2.Select(x => x.Split(' ')[0].ToUpper()).ToList();
        Console.WriteLine(string.Join(", ", vornamenGroßbuchstaben)); // Ausgabe: MAX, ERIKA
    }
}

class Adresse
{
    public string Strasse { get; set; }
    public int Hausnummer { get; set; }
    public string Postleitzahl { get; set; }
    public string Stadt { get; set; }

    public Adresse(string strasse, int hausnummer, string postleitzahl, string stadt)
    {
        Strasse = strasse;
        Hausnummer = hausnummer;
        Postleitzahl = postleitzahl;
        Stadt = stadt;
    }
}
