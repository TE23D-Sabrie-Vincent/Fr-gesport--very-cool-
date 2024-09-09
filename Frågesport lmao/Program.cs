// // See https://aka.ms/new-console-template for more information
// string name = "sigma";

// bool isBest = name == "sigma";

// int aura = 100;

// aura = aura - 40;

// aura -= 1;
// aura = aura - 1;
// aura -= 58;


// Console.WriteLine("Du har " + aura + "kvar ");

// Console.WriteLine(aura);
// if (aura >= 0)
// {
//     Console.WriteLine("Sigma still has the swag XD");
// }
// else
// {
//     Console.WriteLine("Nah you dead lol (no rizz)");
// }
using System.Diagnostics;
using System.Net;
using System.Xml.Schema;

System.Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
System.Console.WriteLine("Hejsan svejsan " + name + "!");
int aura = 0;

System.Console.WriteLine("Välkommen till Sigma frågesporten!");
System.Console.WriteLine("Tryck på Enter för att börja :D");

string svar = Console.ReadLine().ToLower();
System.Console.WriteLine
("1. Vad är en Sigma?");
System.Console.WriteLine("a) Lone wolf          b) flockleadaren");
System.Console.WriteLine("c) surtant            d) weeb");

svar = Console.ReadLine().ToLower();
if (svar == "a")
{
    System.Console.WriteLine("Korrekt!");
    aura ++;
}
else if (svar == "b" || svar == "c" || svar == "d")
{
    System.Console.WriteLine("Fel! Inte så sigma av dig");
    aura --;
}
System.Console.WriteLine();
Console.ReadLine();

