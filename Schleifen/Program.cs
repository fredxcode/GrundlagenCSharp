Kontostand();
Console.WriteLine("\n");
Namesprüfung();
Console.WriteLine("\n");
Temperatur();
Console.WriteLine("\n");
Radius();
static void Kontostand()
{
    int i = 1000;
    do
    {
        i -= 100;
        Console.WriteLine(i);
    } while (i >= 100) ;
}
static void Namesprüfung()
{
    Console.WriteLine("Geben Sie ihren Namen ein:");
    string name = Console.ReadLine();
    while(name == "")
    {
        Console.WriteLine("Feld Leer versuchen Sie es nochmal:");
        name = Console.ReadLine();
    }
}
static void Temperatur()
{
    int i_temp;
    string s_temp;
    bool tryparseout;
    do
    {
        Console.WriteLine("Geben Sie die Temperatur ein");
        s_temp = Console.ReadLine();
        tryparseout = int.TryParse(s_temp, out i_temp);
    } while (!tryparseout);
}
static void Radius()
{
    double d_radius;
    string s_radius;
    bool tryparseout;
    do
    {
        Console.WriteLine("Geben Sie die Temperatur ein");
        s_radius = Console.ReadLine();
        tryparseout = double.TryParse(s_radius, out d_radius);
    } while (!tryparseout);
}