using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int a = 10; // int -> алиас для структуры Int32
              Console.WriteLine(a);
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("Hello world");
              Console.ForegroundColor = ConsoleColor.Magenta;
              Console.Write("Привет мир!!!"); */


            //задание 1
            /* Выведите на экран цитату Бьярна Страуструпа: It's easy to win forgiveness for being wrong;
             being right is what gets you into real trouble.
             Пример вывода:
             It's easy to win forgiveness for being wrong; being right is what gets you into real trouble. Bjarne Stroustrup */


            /* string text = "It's easy to win forgiveness for being wrong;\n being right is what gets you into real trouble.\n Bjarne Stroustrup";
             Console.Write(text);
             Console.Write("\n");
            */


            //задание 2 
            /* Пользователь вводит с клавиатуры пять чисел. Не - обходимо найти сумму чисел,
             максимум и минимум из пяти чисел, произведение чисел.Результат вычислений вывести на экран.*/




            /* int sum = 0;
             int max = 0;
             int min = 1;
             int product = 1;
             for(int i = 0; i < 5; i++) {
                 Console.WriteLine("enter a number: ");
                 string number1 = Console.ReadLine();
                 int n1 = int.Parse(number1);
                 sum += n1;
                 product *= n1;
                 if(n1 > max)
                 {
                     max = n1;
                 }
                 if(n1 < min)
                 {
                     min = n1;
                 }

             }

             Console.WriteLine("sum: " + sum);
             Console.WriteLine("max: " + max);
             Console.WriteLine("min: " + min);
             Console.WriteLine("product: " + product);
               Console.Write("\n");*/




            // задание 3
            // Пользователь с клавиатуры вводит шестизначное число.
            // Необходимо перевернуть число и отобразить результат. Например, если введено 341256, результат 652143.


            /* Console.WriteLine("enter  six digit number: ");
             string sixDigitNum = Console.ReadLine();
             int number = int.Parse(sixDigitNum);
             int reversedNumber = 0;
             if(number >= 100000 && number <= 999999)
             {
               while(number > 0)
                 {
                     int digit = number % 10;
                     reversedNumber = reversedNumber * 10 + digit; 
                     number /= 10;
                 }

                 Console.Write(reversedNumber);
                 Console.Write("\n");
             }

             else
             {
                 Console.Write("you entered incorrect value");
                 Console.Write("\n");
             }
            */

            //задание 4
            /*  Пользователь вводит с клавиатуры границы числового диапазона.
                  Требуется показать все числа Фибоначчи из этого диапазона.
                  Числа Фибоначчи — элементы числовой последовательности, в которой
                  первые два числа равны 0 и 1, а каждое последующее число равно сумме
                  двух пре-дыдущих чисел.Например, если указан диапазон 0–20, результат
                  будет: 0, 1, 1, 2, 3, 5, 8, 13.
             */

            /* Console.WriteLine("enter start number: ");
             string startNum = Console.ReadLine();
             Console.WriteLine("enter end number: ");
             string endNum = Console.ReadLine();

             int start = int.Parse(startNum);
             int end = int.Parse(endNum);
             int a = 0;
             int b = 1;


             while (a <= end) // продолжаем, пока текущее число Фибоначчи не больше верхней границы
             {
                 if (a >= start) // Проверка, попадает ли число в диапазон
                 {
                     Console.Write(a + " "); // Вывод числа
                 }

                 // Генерация следующего числа Фибоначчи
                 int next = a + b; // Следующее число
                 a = b;            // Сдвиг для следующего числа
                 b = next;        // Обновление b
             }

             Console.WriteLine(); // Для новой строки после вывода чисел


             */


            //задание 5
            /*  Даны целые положительные числа A и B(A < B).Вы - вести все 
              целые числа от A до B включительно; каждое число должно
              выводиться на новой строке; при этом каждое число должно
              выводиться количество раз, равное его значению.Например:
              если А = 3, а В = 7, то программа должна сформировать в
              консоли следующий вывод:
              333
              4444
              55555
              666666
              777777. */

            /*   int a = 1;
               int b = 7;

               for(int i = a; i <= b; i++)
               {

                   for(int j = 1; j <= i; j++)
                   {
                       Console.Write(i);

                   }
                   Console.Write("\n");

               }
            */


            //задание 6
            /* Пользователь с клавиатуры вводит длину линии,
             символ заполнитель, направление линии(горизонтальная, вертикальная).
             Программа отображает линию по заданным параметрам. Например: +++++.
             Параметры линии: горизонтальная линия, длина равна пяти, символ заполнитель +. */


            Console.WriteLine("enter the length: ");
            string lengthStr = Console.ReadLine();

            Console.WriteLine("enter the symbol: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("enter direction: ");
            string direction = Console.ReadLine();

            int length = int.Parse(lengthStr);

            if (direction == "horisontal")
            {

                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                }
            }

            else
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                    Console.Write("\n");
                }
            }
                


        }
    }
    }


