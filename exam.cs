using System;
using System.Threading;

 class Program
 {
      static void WorkThreadFunction()
    {
      try
      {
        Console.Write("Matrix size:");
        
        int r = Convert.ToInt16(Console.Read());
        
        int[,] Matrix = new int[r, r];
        int amount = 0 ;

        
        Random random = new Random();
        int rand;
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < r; j++)
            {
                rand = random.Next(0, 100);
                Matrix[i, j] = rand;
            }
        }

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < r; j++)
            {
              amount+=j;

              Console.Write(Matrix[i, j] + "\t");
              
            }
            Console.WriteLine();
        }
        Console.WriteLine(amount);
      }
      catch (Exception ex)
      {
        Console.Write(ex);
      }
}
     static void Main(string[] args)
     {

        


        Thread threadOne = new Thread(new ThreadStart(WorkThreadFunction));
        threadOne.Start();
        // Thread threadTwo = new Thread(new ThreadStart(WorkThreadFunction));
        // threadTwo.Start();

        Console.ReadKey();
     }
 }
