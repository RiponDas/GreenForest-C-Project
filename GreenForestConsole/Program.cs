using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        string[] input = { "Brach", 
                           "Amarg", 
                           "Mamen" };
        string[] next = {};
        int k = 0;

        List<string> dinosaurs = new List<string>(input);
        List<string> dinosau = new List<string>(next);

        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

        Console.WriteLine();
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 5; j++) {
                Console.Write(string.Format("{0} ", input[i, j]));
            }
        }

            /* foreach (string dinosaur in dinosaurs)
             {
                // Console.WriteLine(dinosaur);
                 for (int i = 0; i < 5; i++) {
                     next[i] = dinosaur[i].ToString();
                 }
                 k++;
             }
             foreach (string dinosaur in dinosau)
             {
                 Console.WriteLine(dinosaur);
            
             }*/
            /* Console.WriteLine("\nAddRange(dinosaurs)");
             dinosaurs.AddRange(dinosaurs);

             Console.WriteLine();
             foreach (string dinosaur in dinosaurs)
             {
                 Console.WriteLine(dinosaur);
             }

             Console.WriteLine("\nRemoveRange(2, 2)");
             dinosaurs.RemoveRange(2, 2);

             Console.WriteLine();
             foreach (string dinosaur in dinosaurs)
             {
                 Console.WriteLine(dinosaur);
             }*/

            Console.ReadKey();
    }
}