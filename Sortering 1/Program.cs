using System;
using System.Collections.Generic;
using System.Diagnostics;
 
namespace Sortering
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> array = new List<int>();
            
            Random ran = new Random();

            Stopwatch watch = new Stopwatch();

            for(int i = 0; i < 4000; i++){
                array.Add(ran.Next(1, 1001));
            }
            watch.Start();
            int temp;
         for (int j = 0; j <= array.Count - 2; j++) {
            for (int i = 0; i <= array.Count - 2; i++) {
               if (array[i] > array[i + 1]) {
                  temp= array[i + 1];
                  array[i + 1] = array[i];
                  array[i] = temp;
               }
            
        
            }
            
        }
        watch.Stop();
        foreach(int i in array)
            Console.WriteLine(i);

            Console.WriteLine(watch.ElapsedMilliseconds);
    }   
  }
}
 
 
