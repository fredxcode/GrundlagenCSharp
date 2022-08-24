int auswahl;

Console.WriteLine("(1) Umrechung von Celsius nach Kelvin");
Console.WriteLine("(2) Umrechung von Celsius nach Fahrenheit");
Console.WriteLine("(3) Umrechung von Kelvin nach Celsius");
Console.WriteLine("(4) Umrechung von Kelvin nach Fahrenheit");

auswahl = Convert.ToInt16(Console.ReadLine());

switch (auswahl)
{
    case 1:
        Console.Write("Gib die Zahl in Celsius an: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double kelvin = (celsius + 273.15);
        Console.WriteLine("{0} C° sind {1} Kelvin", celsius, kelvin);
        break;
    case 2:
        Console.Write("Gib die Zahl in Celsius an: ");
        double celsius1 = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = ((celsius1 * 9 / 5) + 32);
        Console.WriteLine("{0} C° sind {1}° Fahrenheit", celsius1, fahrenheit);
        break;
    case 3:
        Console.Write("Gib die Zahl in Kelvin an: ");
        double kelvin1 = Convert.ToDouble(Console.ReadLine());
        double celsius2 = (kelvin1 - 273.15);
        Console.WriteLine("{0} Kelvin sind {1} C°", kelvin1, celsius2);
        break;
    case 4:
        Console.Write("Gib die Zahl in Celsius an: ");
        double kelvin2 = Convert.ToDouble(Console.ReadLine());
        double fahrenheit1 = ((kelvin2 - 273.15) * 9 / 5 + 32);
        Console.WriteLine("{0} Kelvin sind {1}° Fahrenheit", kelvin2, fahrenheit1);
        break;
    default:
        Console.WriteLine("Da ist etwas schief gelaufen :/");
        break;
}