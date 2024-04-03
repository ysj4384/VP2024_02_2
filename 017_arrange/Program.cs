namespace _017_arrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for(int i = 0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine("\n");
            }

            /* 원소를 모두 출력
            Console.WriteLine("\n a의 원소");
            // 1) 인덱스 사용
            for (int i = 0; i<10; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();

            // 2) foreach 사용
            foreach (var value in a)
            {
                Console.Write(value + " ");
                Console.WriteLine();
            }*/

            /* 원소의 합 출력
            int sum = 0;
            for(int i = 0;i<10; i++)
            {
                sum += a[i];
            }
            Console.Write("{0}", sum);
            */

            // 가장 큰 값을 출력
            int max = a[0];

            for(int i =0;i<10; i++)
            {
                if(max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("최댓값 {0}", max);
        }
    }
}