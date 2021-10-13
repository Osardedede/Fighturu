using System;
using System.Collections.Generic;
using System.Threading;

Random generator = new Random();

List<string> bossNames = new List<string>();
bossNames.Add("Herbert");
bossNames.Add("Peter");
bossNames.Add("Pikachu");

int num = generator.Next(bossNames.Count);

Console.WriteLine(bossNames[num]);

string boss = bossNames[num];
int BH = 0;
string ForR = "hej";
int PH = 300;
string wep = "hdoe3";
string bodypart = "hjdew";
string super = "fe";


string name;
stuff.titleCard();
Console.WriteLine("Whats your name warior?");
name = Console.ReadLine();

Console.WriteLine($"Ok {name} your challanger today is {boss}");
if (boss == "Pikachu")
{
    stuff.PP();
    BH = 500;
}

if (boss == "Herbert")
{
    stuff.BB();
    BH = 700;
}

if (boss == "Peter")
{
    stuff.PB();
    BH = 1000;
}
while (BH != 0 && PH != 0)
{


    Console.WriteLine($"What will {name} do? I think he has like {BH} HP! You have only {PH} HP!");


    while (ForR != "fight" && ForR != "run")
    {
        Console.WriteLine("Will you Fight or run?");
        ForR = Console.ReadLine();

        if (ForR == "fight")
        {
            Console.WriteLine("Good I knew you weren't a coward!");
        }
        if (ForR == "run")
        {
            Console.WriteLine($"You are a god damn coward {name}!");
            Thread.Sleep(2000);
            System.Environment.Exit(0);
        }
    }
    int damage = generator.Next(30, 100);
    while (wep != "katana" && wep != "flamethrower" && wep != "plastic suit")
    {
        Console.WriteLine("Now what weapon do you choose? ");
        Console.WriteLine("Katana,Flamethrower or plastic suit");
        wep = Console.ReadLine();
        wep = wep.ToLower();

        if (wep == "katana")
        {
            BH -= 100;


            if (boss == "Herbert")
            {
                BH -= 300;
                Console.WriteLine("OH shit seems he was extra week to that weapon!");

            }
            Console.WriteLine($"Nice now he only has {BH} HP left!");

        }
        if (wep == "flamethrower")
        {
            BH -= damage;
            if (boss == "Peter")
            {
                BH -= 400;
                Console.WriteLine("OH shit seems he was extra week to that weapon!");

            }
            Console.WriteLine($"Nice now he only has {BH} HP left!");

        }
        if (wep == "plastic suit")
        {
            Console.WriteLine("You didn't do any damage but you are imune to electric attacks!");
        }
    }

    Console.WriteLine($"Whatch out here is his atack");
    if (wep == "plastic suit" && boss == "Pikachu")
    {
        Console.WriteLine($"Nice {boss} didn't do any damage. He will proberly start doing physical attacks doe");
        Console.ReadLine();
    }
    else
    {
        int damage2 = generator.Next(100, 200);
        PH -= damage2;
        Console.WriteLine($"Outch he did some damage. You still have {PH} HP left");
    }

    Console.WriteLine($"Your turn, time to kill him");
    Console.WriteLine("where do we hit him?");
    while (bodypart != "head" && bodypart != "stumach" && bodypart != "legs")
    {
        Console.WriteLine($"The head, Stumach or his legs");
        bodypart = Console.ReadLine();
        bodypart = bodypart.ToLower();
    }



    int damage3 = generator.Next(100, 300);
    BH -= damage3;

    Console.WriteLine($"Nice u did {damage3} damage so now he only has {BH} HP!");
    Console.WriteLine("GROUND SHAKING");
    Thread.Sleep(1000);
    Console.WriteLine("He is charging up for a SUPER!!!!!!!!!");

    int superdamage = generator.Next(100, 200);
    PH -= superdamage;
    Console.WriteLine($"BOOM");
    Thread.Sleep(1500);
    if (PH == 0)
    {
        Console.WriteLine($"YOU DIED. He did {superdamage} damage");
    }

    else
    {
        Console.WriteLine($"Holy shit you are alive. With {PH} HP left!");
    }
    Console.WriteLine($"Now Its time to do your SUPER!");
    Console.WriteLine("What element are your super?");
    Console.WriteLine("Fire, dark or ");
    super = Console.ReadLine();
    







    Console.ReadLine();

}







