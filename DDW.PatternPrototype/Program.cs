using System;
using System.Collections;

namespace DDW.PatternPrototype
{
    class Program
    {
        static void Main(string[] args)
        {                     
            Transport truck = new Truck("Reno");
            Console.WriteLine(truck.ToString());

            Console.WriteLine($"{new string('-', 20)}\n");

            Transport truck2 = (Truck)truck.MyClone();           

            truck.Move();
            Transport truck3 = (Truck)truck.Clone();

            Console.WriteLine(truck.ToString());
            Console.WriteLine(truck2.ToString());
            Console.WriteLine(truck3.ToString());

            Console.WriteLine($"{new string('*', 50)}\n");



            Transport truckMini = new TruckMini("RenoMini");
            Console.WriteLine(truckMini.ToString());
            Console.WriteLine($"{new string('-', 20)}\n");

            Transport truckMini2 = (TruckMini)truckMini.MyClone();
            Transport truckMini3 = (TruckMini)truckMini.Clone();

            truckMini2.IsMove = false;
            Console.WriteLine(truckMini2.ToString());

            truckMini3.Move();
            Console.WriteLine(truckMini3.ToString());

            Console.WriteLine($"{new string('*', 50)}\n");



            Transport truckSuperMini = new TruckSuperMini("RenoSuperMini");
            Console.WriteLine(truckSuperMini.ToString());
            Console.WriteLine($"{new string('-', 20)}\n");

            truckSuperMini.IsMove = false;
            Transport truckSuperMini2 = (Transport)truckSuperMini.MyClone();
            Console.WriteLine(truckSuperMini2.ToString());

            truckSuperMini.Move();
            Transport truckSuperMini3 = (TruckMini)truckSuperMini.MyClone();
            Console.WriteLine(truckSuperMini3.ToString());

            Transport truckSuperMini4 = (Truck)truckSuperMini.Clone();
            Console.WriteLine(truckSuperMini4.ToString());

        }

        

       

    }

    

    

}
