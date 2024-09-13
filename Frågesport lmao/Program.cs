
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.Xml.Schema;

System.Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();
System.Console.WriteLine("Hejsan svejsan " + name + "!");
int aura = 0;

System.Console.WriteLine("Välkommen till Sigma rizz party quiz!");
System.Console.WriteLine("Tryck på Enter för att börja :D");

string svar = Console.ReadLine().ToLower();
System.Console.WriteLine
("1. Vad är en Sigma?");
System.Console.WriteLine("a) Lone wolf          b) Flockleadaren");
System.Console.WriteLine("c) Surtant            d) Weeb");

svar = Console.ReadLine().ToLower();
if (svar == "a")
{
    System.Console.WriteLine("Korrekt!");
    aura ++;
    // Detta ger ger plus 1 poäng av aura nära du får rätt :D
}

    else if (svar == "b" || svar == "c" || svar == "d")
    {
        System.Console.WriteLine("Fel! Inte så sigma av dig");
        aura --;
        // Detta ger minus 1 poäng av aura när du får fel D:
    }
System.Console.WriteLine("2. Var I USA skedde 9/11?");
System.Console.WriteLine("a) Ohio           b) Chicago");
System.Console.WriteLine("c) New mexico     d) New York ");

svar = Console.ReadLine().ToLower();
if (svar == "d")
{
    System.Console.WriteLine("Korrekt!");
    aura ++;
}
    else if (svar == "a" || svar == "b" || svar == "c" )
    {
        System.Console.WriteLine("Fel.. D:");
        aura --;
    }
System.Console.WriteLine("3. You're so skibidi you're so _____ tax");
System.Console.WriteLine("Fyll i luckan");
System.Console.WriteLine("a) Alpha          b) Osama bin laden");
System.Console.WriteLine("c) Fanum          d) Phantom");


svar = Console.ReadLine().ToLower();
if (svar == "c" || svar == "Fanum")
{
    System.Console.WriteLine("Korrekt!");
    System.Console.ReadLine();
    System.Console.WriteLine("Double or nothing!!!");
    System.Console.WriteLine("Du kan få 2x poäng eller -2x poäng");
    System.Console.WriteLine("BONUS: I just wanna be your _____");
    System.Console.WriteLine("Fyll i luckan");
    svar = Console.ReadLine().ToLower();
    if (svar == "sigma")
    {
            System.Console.WriteLine("Snyggt jobbat!! Gambling always pays off!");
        aura *= 2;
    }
    else 
    {
        System.Console.WriteLine("You gyatt to be kidding me... du har fel! Du förlorade precis din gooning streak :c");
        aura = - aura;
    }
}

else if (svar == "a" || svar == "b" || svar == "d")
{
    System.Console.WriteLine("Erm what the sigma, du har fel...");
    aura --;
}


System.Console.WriteLine("4. Vem är Caseoh?");
System.Console.WriteLine("a) Gorlocks pojkvän           b) En STOR twitch streamer");
System.Console.WriteLine("c) Kevin Nyman                d) Kristian killingher");

svar = Console.ReadLine().ToLower();
if (svar == "b" || svar == "en twitch streamer")
{
    System.Console.WriteLine("Korrekt! Han är gigantisk ändå lol XD");
    aura ++;
}
    else if (svar == "a" || svar == "c" || svar == "d")
    {
        System.Console.WriteLine("FEL! Du missade ju min STORA ledtråd!!!!");
        aura --;
    }
System.Console.WriteLine("5 Vem är den ultimata Rizzlern?");
System.Console.WriteLine("a) Duke Dennis                b) Kai Cenat");
System.Console.WriteLine("c) Vincent (obviously)        d) Livvy Dune");

svar = Console.ReadLine().ToLower();
if (svar == "a" || svar == "Duke Dennis")
{
    System.Console.WriteLine("Korrekt!");
    aura ++;
}

else if (svar == "b" || svar == "c" || svar =="d")
{
    System.Console.WriteLine("tsk tsk tsk... Du har FEL!");
    aura --;
}

if (aura <= 0)
{
    System.Console.WriteLine("Oh, you're really not as sigma as a thought...");
    System.Console.WriteLine("you gyatt" + aura + "points");
}

if (aura >= 5)
{
   System.Console.WriteLine("tYou are da biggest sigma!!!! ");
   System.Console.WriteLine("You have " + aura + " points");
}

Console.ReadLine();