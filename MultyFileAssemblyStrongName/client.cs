using System;
using Animal;

class AnimalUser
{
    static void Main()
    {
        Mammal obj1 = new Mammal();
        obj1.MammalInfo();

        Wolf obj2 = new Wolf();
        obj2.InfoWolf();

        Hare obj = new Hare();
        obj.InfoHare();

        Console.ReadKey();
        
    }
}

