using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int Random = new Random().Next(100);

            Console.WriteLine("请输入一个不超过100的自然数");

            for (int i = 0; i < 5; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                int reduceTimes = 4 - i;
                if (input == Random)
                {
                    Console.WriteLine($"恭喜你答对了，只用了{i + 1}次");
                }
                else if (input > Random)
                {
                    Console.WriteLine($"太大了，还剩{reduceTimes }次");

                } 
                //123
                else  
                {
                    Console.WriteLine($"太小了，还剩{reduceTimes }次");
                }
            }
                    
        }
        

    }
}
