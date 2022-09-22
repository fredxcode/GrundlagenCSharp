Console.ForegroundColor = ConsoleColor.Green;
Aufgabe1();
Console.WriteLine("\n");
Aufgabe2();
Console.WriteLine("\n");
Aufgabe3();
Console.WriteLine("\n");
Aufgabe5();


static void Aufgabe1() 
{ 
    string sHöhe = "Höhe", sBreite = "Breite";
    float fHöhe = 32.346F, fBreite = 15.193F;

    Console.WriteLine("{0,10}{1,10}\n", sHöhe, sBreite);
    Console.WriteLine("{0,10:F1}{1,10:F1}\n", fHöhe, fBreite);
}

static void Aufgabe2() 
{
    int x = 3, y = 6;
    bool flag = true;
    Console.WriteLine(x + y);                       //Ausgabe: 9
    Console.WriteLine(x / y);                       //Ausgabe: 0
    Console.WriteLine(3.0 / y);                     //Ausgabe: 0,5
    Console.WriteLine(x == y);                      //Ausgabe: False
    Console.WriteLine(x++ == y | true);             //Ausgabe: True
    Console.WriteLine(x > 3);                       //Ausgabe: True
    Console.WriteLine(--y == ++x & flag & true);    //Ausgabe: True
}

static void Aufgabe3()
{
    double gewicht, körpergröße, bmi;

    Console.Write("Gebe dein Gewicht in Kg an: ");
    gewicht = Convert.ToDouble(Console.ReadLine());
    Console.Write("Gebe deine Körpergröße in meter an: ");
    körpergröße = Convert.ToDouble(Console.ReadLine());

    bmi = gewicht / (körpergröße * körpergröße);
    bmi = Math.Round(bmi, 2);
    Console.WriteLine("Dein BMI-Wert ist " + bmi);
}

static void Aufgabe5()
{
    double umsatz, nachAbzug;
    Console.Write("Wie viel beträgt der Umsatz: ");
    umsatz = Convert.ToDouble(Console.ReadLine());

    if (umsatz > 100 & umsatz <= 500)
    {
        nachAbzug = umsatz - umsatz * 0.05;
        Console.WriteLine("Der reduzierte betrag ist {0:F2} Euro. 5% Rabatt", nachAbzug);
    }
    else if (umsatz >= 501)
    {
        nachAbzug = umsatz - umsatz * 0.10;
        Console.WriteLine("Der reduzierte betrag ist {0:F2} Euro 10% Rabatt", nachAbzug);
    } else
    {
        Console.WriteLine("Mit einem Betrag von {0:F2} gibt es leider kein Rabatt", umsatz);
    }
}
