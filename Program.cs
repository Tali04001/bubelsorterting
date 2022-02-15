using System;

namespace Imorgon_bubelsort
{
    class Program
    {
        
     static void BubbleSort(int[] Imorgon)
        {
            bool needsSorting = true;
            for (int i = 0; i < Imorgon.Length - 1 && needsSorting; i++)
            {
                needsSorting = false;
                for (int j = 0; j < Imorgon.Length - 1 - i; j++)
                {
                    if (Imorgon[j] > Imorgon[j + 1])
                    {
                        needsSorting = true; //kollar om det är sorterat
                        int tmp = Imorgon[j +1];
                        Imorgon[j + 1] = Imorgon[j];
                        Imorgon[j] = tmp;
                    }
                }
 
            }
        }
 
        static int[] GenerateImorgon(int size) //refererar
        {
            Random rnd = new Random(); // skapar slumpad data idag tänk på det idag.
            int[] Imorgon = new int[size];
 
            for (int i = 0; i < Imorgon.Length; i++)
                Imorgon[i] = rnd.Next(Imorgon.Length);
 
            return Imorgon;
        }
 
        static void Main(string[] args)
        {
            int[] sizes = new int[] { 1000, 2000, 4000, 8000 };//data :))))
 
            for (int i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine("slumpar saker " + sizes[i]);
                int[] Imorgon  = GenerateImorgon(sizes[i]);
                
                Console.WriteLine("Sorterar slumpis");
                DateTime startkelb = DateTime.Now;
                BubbleSort(Imorgon);
                TimeSpan deltaTid = DateTime.Now - startkelb;
                Console.WriteLine("Det tog {0:0.00} millisekunder.\n", deltaTid.TotalMilliseconds);//berättar tid
 
            }
        }
    }
}
 
