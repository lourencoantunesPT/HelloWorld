using System;

namespace Helloworld
{
    class Program
    {


        
        static Person[] peopleArray = new Person[3]
        {
            new Person("John", "Smith", 10),
            new Person("Jim", "Johnson", 20),
            new Person("Sue", "Rabon",30),
        };


        static void Main(string[] args)
        {
        /* EXAMPLE 1
        */
         
            Console.WriteLine("Hello World!");
            Console.WriteLine("Tudo bem");


        /* EXAMPLE 2: 
        * This code produces output similar to the following:
        *
        * John Smith
        * Jim Johnson
        * Sue Rabon
        *
        */


        People peopleList = new People(peopleArray);
        foreach (Person p in peopleList)
            Console.WriteLine(p.firstName + " " + p.lastName+ " " + p.idade);
        }




    }
}



