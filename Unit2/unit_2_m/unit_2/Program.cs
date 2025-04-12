using System;
using System.Collections.Generic;
using System.Linq;a
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        class House
        {
            public string street;
            public int number;

            public void Print()
            {
                Console.WriteLine($"{street}, {number}");
            }

            static void Main(string[] args)
            {
                /*
                int a = 7;
                int b = 5;
                int c = 4;
                if (a > b && c > b)
                {
                    Console.WriteLine($"Число {c} больше всех чисел");
                }
                else if (b < a)
                {
                    Console.WriteLine($"Число {b} меньше числа {a}");
                }
                else
                {
                    Console.WriteLine($"Число {b} равно числу {a}");
                }
                */

                /*
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
                */

                /*
                int i = 0;
                while (i <= 10)
                {
                    i++;
                    Console.WriteLine(i);
                    //i++;
                }
                */

                /*            
                int[] numbers = new int[5];
                int[] numbers2 = {5, 6, 7, 8, 9};
                numbers2[4] = 15;
                Console.WriteLine(numbers2[4]);
                */


                /*
                void Helloworld()
                {
                    Console.WriteLine("Hello World");
                }
                Helloworld();
                Helloworld();
                */

                /*
                void Sum(int a, int b)
                {
                    int sum = a + b;
                    Console.WriteLine(sum);
                }
                Sum(3, 8);
                */

                /*
                void Human(string name, int age)
                {   
                    Console.WriteLine($"{name}, {age}");
                }
                Human("Вячеслав", 39);
                */

                //



                House tower = new House();
                tower.street = "Годовикова";
                tower.number = 917;

                tower.Print();
            }
            
        }
    }
}
