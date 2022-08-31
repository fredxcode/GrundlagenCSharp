Aufgabe1();
Aufgabe2();

static void Aufgabe1() { 
    string sHöhe = "Höhe", sBreite = "Breite";
    float fHöhe = 32.346F, fBreite = 15.193F;

    Console.WriteLine("  1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20");
    Console.WriteLine("1             H ö h e              B  r  e  i  t  e ");
    Console.WriteLine("2                                                   ");
    Console.WriteLine("3             3 2 , 3                    1  5  ,  2 ");
    Console.WriteLine("4                                                   ");}static void Aufgabe2() {    int x = 3, y = 6;    bool flag = true;    Console.WriteLine(x + y);                       //Ausgabe: 9
    Console.WriteLine(x / y);                       //Ausgabe: 0
    Console.WriteLine(3.0 / y);                     //Ausgabe: 0,5
    Console.WriteLine(x == y);                      //Ausgabe: False
    Console.WriteLine(x++ == y | true);             //Ausgabe: True
    Console.WriteLine(x > 3);                       //Ausgabe: True
    Console.WriteLine(--y == ++x & flag & true);    //Ausgabe: True
}