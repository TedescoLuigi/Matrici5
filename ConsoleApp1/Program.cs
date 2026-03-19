namespace Matrici5
{
    internal class Program
    {
        static void Stampa(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"[{m[i, j]}]");
                }
                Console.WriteLine();
            }
        }
        static int[] Riga(int[,] m)
        {
            int[] arrayR = new int[m.GetLength(0)];
           
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {

                    arrayR[i] += m[i, j];
                 
                    
                }
            }
            return arrayR;

        }
        static int[] Colonna(int[,] m)
        {
            int[] arrayC = new int[m.GetLength(0)];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {

                    arrayC[i] += m[i, j];


                }
            }
            return arrayC;

        }

        static int Somma(int[,] m, int[] arrayR, int[] arrayC)
        {
            int somma = 0;
            for (int i = 0;i < arrayR.GetLength(0); i++)
            {
                for(int j=0; j < arrayC.GetLength(1); j++)
                {
                    somma += m[i, j];
                }
            }

            return somma;
        }




        static void Main(string[] args)
        {
            int[,] m = { 
                    { 1, 2, 3 },
                    { 4, 5, 6 }, 
                    { 7, 8, 9 } 
            };
            int[] arrayR = new int[m.GetLength(0)];
            int[] arrayC = new int[m.GetLength(1)];
            Stampa(m);
            Console.WriteLine();
            Console.WriteLine("")
            Riga(m);
            Colonna(m);

           
            
        
        }
    }
}
