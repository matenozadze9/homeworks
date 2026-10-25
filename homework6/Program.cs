namespace homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //davaleba 1

            Console.WriteLine("sheiyvanet pirveli qula:");
            double score1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("sheiyvanet meore qula:");
            double score2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("sheiyvanet mesame qula:");
            double score3 = Convert.ToDouble(Console.ReadLine());

            double average = (score1 + score2 + score3) / 3;
            bool isPassed = average >= 51;

            Console.WriteLine("qulebis shedegebi");
            Console.WriteLine("sashualo qula " + average);

            if (isPassed)
            {
                Console.WriteLine("chaabare");
            }
            else
            {
                Console.WriteLine("ver chaabare");
            }
            
            
            //davaleba 2


            Console.WriteLine("sheiyvanet mteli ricxvi:");
            int number = Convert.ToInt32(Console.ReadLine());




            if (number % 2 == 0)
            {
                Console.WriteLine("luwia");
            }
            else
            {
                Console.WriteLine("kentia");
            }

            if (number > 0)
            {
                Console.WriteLine("dadebitia");
            }
            else if (number < 0)
            {
                Console.WriteLine("uaryofitia");
            }
            else
            {
                Console.WriteLine("nuliaa");
            }

        }
    }
}
