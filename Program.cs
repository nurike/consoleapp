using System;
using ConsoleApp.Service;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> nods = new LinkedList<string>(6);
            nods.AddRandom("New York", 0);
            nods.AddRandom("Paris", 1);
            nods.AddRandom("London", 2);
            nods.AddRandom("Sydney", 3);
            nods.AddRandom("Dubay", 4);
            nods.AddRandom("Tokyo", 5);
            

            nods.AddAfter("Dhaka", 4);
            nods.AddLast("Tokyo");
            nods.AddBefore("Delhi", 4);
            nods.Delete(4);
            
            
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(nods.Get(i));
            }
            
        }
    }
}
