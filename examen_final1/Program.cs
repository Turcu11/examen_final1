using System;

namespace examen_final1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the size of the array: ");
            int dim = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[dim];
            for(int i = 0; i < dim; i++)
            {
                Console.Write("Fill in the array: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Rec(array, dim);
        }

        public static int Rec(int[] array, int dim)
        {
            int sum = 0;
            if(dim <= 0)
            {
                return 0;
            }
            //sum = sum + array[dim];
            sum = sum + array[dim -1];
            int result = sum + Rec(array, dim -1);
            Console.WriteLine(result);
            return result;
        }
    }
}
