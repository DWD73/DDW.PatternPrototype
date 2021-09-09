using System;
using System.Collections;

namespace DDW.PatternPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTruck();

            SetNewLine();

            GetTruckMini();

            SetNewLine();

            GetTruckSuperMini();

        }

        private static void GetTruck()
        {
           
            Console.WriteLine("Объект\n");
            Transport truck = new Truck("Reno");          
            Console.WriteLine(truck.ToString());           

            Console.WriteLine("Прототипы\n");

            IMyCloneable<Truck> myCloneable = (Truck)truck;
            Transport truck2 = myCloneable.MyClone2();          

            Transport truck3 = (Truck)truck.MyClone();

            truck.Move();
            truck.Name = "Grigoriy";
            

            Truck truck4 = (Truck)truck.Clone();
            truck4.goods.Type = "Meat";

            Console.WriteLine(truck.ToString());
            Console.WriteLine(truck2.ToString());
            Console.WriteLine(truck3.ToString());
            Console.WriteLine(truck4.ToString());
        }

        private static void GetTruckMini()
        {
            Console.WriteLine("Объект\n");

            Transport truckMini = new TruckMini("RenoMini");
            Console.WriteLine(truckMini.ToString());

            Console.WriteLine("Прототипы\n");

            IMyCloneable<TruckMini> myCloneableMini = (TruckMini)truckMini;
            Transport truckMini2 = myCloneableMini.MyClone2();
            Console.WriteLine(truckMini2.ToString());
         
            Transport truckMini3 = (TruckMini)truckMini.MyClone();
            truckMini3.IsMove = false;
            Console.WriteLine(truckMini3.ToString());

            TruckMini truckMini4 = (TruckMini)truckMini.Clone();
            truckMini4.goods.Type = "Fruit";
            
            truckMini4.Move();
            Console.WriteLine(truckMini4.ToString());
        }

        private static void GetTruckSuperMini()
        {
            Console.WriteLine("Объект\n");

            Transport truckSuperMini = new TruckSuperMini("RenoSuperMini");
            Console.WriteLine(truckSuperMini.ToString());

            Console.WriteLine("Прототипы\n");

            IMyCloneable<TruckSuperMini> myCloneableSuperMini = (TruckSuperMini)truckSuperMini;
            Transport truckSuperMini2 = myCloneableSuperMini.MyClone2();
            Console.WriteLine(truckSuperMini2.ToString());

            truckSuperMini.IsMove = false;
            Transport truckSuperMini3 = (TruckMini)truckSuperMini.MyClone();
            Console.WriteLine(truckSuperMini3.ToString());

            TruckMini truckSuperMini4 = (TruckMini)truckSuperMini.Clone();
            truckSuperMini4.goods.Type = "Vegetables";
            Console.WriteLine(truckSuperMini4.ToString());
        }


        private static void SetNewLine()
        {
            Console.WriteLine($"{new string('*', 50)}\n");
        }


    }

    

    

}
