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
        static int[,] Somma (int [,] m)
        {
            int[,] m2 = new int[3, 3];

            for (int i = 0; i < m2.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {

                    for (int k = 0; k < m.GetLength(0); k++)
                    {
                        for (int l = 0; l < m.GetLength(1); l++)
                        {
                            if (k != i && l != j)
                            {
                                m2[k, l] += m[i, j];
                            }

                        }
                                
                    }
                }
            }
            return m2;
                    
        }
        static void Main(string[] args)
        {
            int[,] m = { { 1, 2, 3 }, 
                         { 4, 5, 6 }, 
                         { 7, 8, 9 } };
            Stampa(Somma(m));
        } 
    }
}
