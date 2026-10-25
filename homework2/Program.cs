namespace homework2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 

            Console.WriteLine("=== davaleba 1 ===");

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            int[] resultArray1 = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                resultArray1[i] = array1[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                resultArray1[array1.Length + i] = array2[i];
            }

            Console.Write("resultArray = [");
            for (int i = 0; i < resultArray1.Length; i++)
            {
                Console.Write(resultArray1[i]);
                if (i < resultArray1.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            #endregion


            #region 


            Console.WriteLine("=== davaleba 2 ===");

            int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };

            Console.Write("type targetSum: ");
            int targetSum = int.Parse(Console.ReadLine());

            Console.Write("resultArray = [ ");
            bool isFirstPair = true;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        if (!isFirstPair)
                        {
                            Console.Write(", ");
                        }

                        Console.Write($"[{array[i]}, {array[j]}]");
                        isFirstPair = false;
                    }
                }
            }

            Console.WriteLine(" ]");

            #endregion
        }
    }
}
    



