using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Выполнила Ярмолинская Анастасия
            1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            в) Добавить диалог с использованием switch демонстрирующий работу класса.

            //задание 1

            Console.WriteLine("Задание №1. Комплексные числа.\n");

            ComplexNumber z1 = new ComplexNumber(r: 1, i: 2);
            ComplexNumber z2 = new ComplexNumber(i: -5, r: 3);

            Console.WriteLine(z1.Print());
            Console.WriteLine(z2.Print());

            Console.WriteLine("Если вы хотите выполнить сложение, нажмите 1.\nЕсли вы хотите выполнить вычитание, нажмите 2.\n" +
                "Если вы хотите выполнить умножение, нажмите 3.");
            int action = int.Parse(Console.ReadLine());
            switch (action)//сравниваемое выражение action
            {
                case 1:
                    ComplexNumber result = ComplexNumber.Sum(z1, z2);//сумма 4-3i
                    Console.WriteLine(result.Print());
                    break;
                case 2:
                    ComplexNumber result2 = ComplexNumber.Subtraction(z1, z2);//разность -2+7i
                    Console.WriteLine(result2.Print());
                    break;
                case 3:
                    ComplexNumber result3 = ComplexNumber.Multiplication(z1, z2);//произведение 13 + 1i
                    Console.WriteLine(result3.Print());
                    break;
            }


            /*задание 2
            2.а)  С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).Требуется подсчитать сумму всех нечётных
            положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.*/

            int a, sum = 0;
            string s = "";
            Console.WriteLine("\nЗадание №2.\nВводите целые числа, каждое с новой строки. Чтобы закончить ввод, введите ноль.");
            a = Convert.ToInt32(Console.ReadLine());

            while (a != 0)
            {
                sum += tryParse(a);
                s += tryParse2(a);
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Сумма всех нечётных положительных чисел равна {sum}.\nСами числа: {s}");

        }

        private static int tryParse(int a)
        {
            return (a > 0) && (a % 2 != 0) ? a : 0;
        }
        private static string tryParse2(int a)
        {
            return (a > 0) && (a % 2 != 0) ? Convert.ToString(a) + ", " : "";
        }

        struct ComplexNumber
        {
            public double a;
            public double b;

            /// <summary>
            /// Конструктор
            /// </summary>
            /// <param name="r">действительная часть</param>
            /// <param name="i">мнимая часть</param>
            public ComplexNumber(double r, double i)
            {
                a = r;
                b = i;
            }

            public static ComplexNumber Sum(ComplexNumber z1, ComplexNumber z2)//метод сложения
            {
                ComplexNumber temp = new ComplexNumber(z1.a + z2.a, z1.b + z2.b);
                return temp;
            }

            public static ComplexNumber Subtraction(ComplexNumber z1, ComplexNumber z2)//метод вычитания
            {
                ComplexNumber temp = new ComplexNumber(z1.a - z2.a, z1.b - z2.b);
                return temp;
            }

            public static ComplexNumber Multiplication(ComplexNumber z1, ComplexNumber z2)//метод умножения
            {
                ComplexNumber temp = new ComplexNumber(z1.a * z2.a - z1.b * z2.b, z1.b * z2.a + z1.a * z2.b);
                return temp;
            }

            public string Print()//метод вывода результатов сложения, вычитания и произведения
            {
                return b < 0 ? $"{a} - {-b}i" : $"{a} + {b}i";
            }
        }

    }
}
