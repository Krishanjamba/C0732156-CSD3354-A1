using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732156_CSD3354_A1
{
    class UsingRecursion
    {
        // Create an application which 
        // calculates the sum of all the numbers from n to m recursively:
        static void Main(string[] args)
        {
            WorkBench2 wb2 = new WorkBench2();
            wb2.VariableA = 7;
            WorkBench2.VariableB = 8;
            wb2.Run();
            WorkBench wb2_b = new WorkBench2();
            Console.WriteLine(WorkBench2.variableB);
        }
        public static int CalculateRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateRecursively(n, m);
            }
            return sum;
        }


    }

    class CountrySide
    {
        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;


        class Village
        {
            public Village(string _villageName, bool _isAHere)
            {
                isAstrildgeHere = _isAHere;
                VillageName = _villageName;
            }

            public Village west;
            public Village east;
            public string VillageName;
            public int distanceToNextVillage;
            public int distanceToPreviousVillage;
            public bool isAstrildgeHere;
        }
    }
}

