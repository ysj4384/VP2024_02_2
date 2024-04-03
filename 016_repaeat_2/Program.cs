using System.Diagnostics.CodeAnalysis;

namespace _016_repaeat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(43장) x에서y까지의 합, 홀수 합, 역수 합\
            //(45장) 구구단
            //(47장) x의 y 승
            //(53장) 팩토리얼
            // double sum = 0;
            /*for(int i = i, i <= 100, i++)
             *{
             *sum += I;
             *}*/

            /* Console.Write("x : ");
             int x = int.Parse(Console.ReadLine());
             Console.Write("y : ");
             int y = int.Parse(Console.ReadLine());


             for(int i = x; i <= y; i++)
             {
                 sum += i;
             }
             Console.WriteLine(sum);*/

            /*Console.WriteLine("홀수의합");
             * for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);*/

            /*Console.WirteLine("역수의 합");
             * for(int i = 1; i < 10; i++)
             {
                 sum += 1.0 / i;
             }
             Console.WriteLine(sum);*/

            //Console.Write("구구단수 입력 : ");
            //int gugudan = int.Parse(Console.ReadLine());

            for(int i = 1; i <=9; i++) 
            {
                for(int j =2; j <= 9; j++)
                {
                        Console.Write("{0} X {1} = {2,2}\t", j, i, i * j);
                }
                Console.WriteLine();
            }
            /*Console.Write("X : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Y : ");
            int y = int.Parse(Console.ReadLine());
            int r = 1;

            for (int i = 1; i <= y; i++)
            {
                r *= x;
                Console.WriteLine("{0}의 {1}승 : {2}",x, i, r);
            }
            Console.WriteLine("구하고싶은 팩토리얼 값 : ");
            int i = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int j = 1; j<=i;j++)
            {
                int fact = 1;
                for(int n = 2; n<=j;n++)
                {
                    fact *= n;
                }
                sum += fact;
                Console.WriteLine("{0, 2}! = {1, 10:#,#}",j, fact);
            }
            Console.WriteLine("1! + 2! + ... + {0}! = {1:N0}\n", i, sum);*/
        }
    }
}