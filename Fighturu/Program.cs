using System;
using System.Collections.Generic;

Random generator = new Random();
int damage = generator.Next();

List<string> bossNames = new List<string>();
bossNames.Add("Herbert");
bossNames.Add("Josefin");
bossNames.Add("Pikachu");

int num = generator.Next(bossNames.Count);

Console.WriteLine(bossNames[num]);

string boss = bossNames[num];


string name;
stuff.titleCard();
Console.WriteLine("Whats your name warior?");
name = Console.ReadLine();

Console.WriteLine($"Ok {name} your challanger today is {boss}");
if (boss == "Pikachu")
{
    stuff.PP();
}

if (boss == "Herbert")
{
    stuff.BB();
}
Console.ReadLine();






