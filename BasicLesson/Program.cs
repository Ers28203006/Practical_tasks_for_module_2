using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("На какую из задач в списке хотели бы получить ответ (от 1 до 8)?");
            int taskNumber = int.Parse(Console.ReadLine());
            switch (taskNumber)
            {

                case 1:

                    /*-------вычисления значения функции y=7x^2-3x+4  при любом значении x-------*/

                    int numberX;
                    double numberY;

                    Console.Write("Введите значение х: ");
                    numberX = int.Parse(Console.ReadLine());
                    numberY = 7 * Math.Pow(numberX, 2) - 3 * numberX + 4;


                    Console.Write("7x^2 - 3x + 4 = ");
                    Console.WriteLine(numberY);

                    break;

                case 2:

                    /*-------Дан радиус окружности. Найти длину окружности и площадь круга-------*/

                    double radius;
                    Console.Write("Введите радиус: ");
                    radius = double.Parse(Console.ReadLine());
                    const double PI = 3.14;

                    double circuit = 2 * PI * radius;
                    double square = PI * Math.Pow(radius, 2);

                    Console.Write("Длина окружности равена: ");
                    Console.WriteLine(circuit);

                    Console.Write("Площадь круга равна: ");
                    Console.WriteLine(square);

                    break;

                case 3:

                    /*-------Дано расстояние в сантиметрах. Найти число полных метров в нем.-------*/

                    double distance, distanceMetr;

                    Console.Write("Введите расстояние в сантиметрах: ");

                    distance = double.Parse(Console.ReadLine());
                    distanceMetr = distance / 100;

                    Console.Write("Число полных метров: ");
                    Console.WriteLine(distanceMetr);

                    break;

                case 4:

                    /*-------С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?-------*/

                    int day = 234;

                    Console.WriteLine("С некоторого момента прошло 234 дня.");
                    Console.Write("Полных недель за этот период прошло: ");
                    Console.WriteLine(day / 7);
                    
                    break;

                case 5:

                    /*-------Дано двузначное число. Найти:
	                            -   число десятков в нем;
	                            -   число единиц в нем;
	                            -   сумму его цифр;
	                            -   произведение его цифр-----------*/

                    int number;

                    Console.WriteLine("Введите двузначное число: ");
                    number = int.Parse(Console.ReadLine());

                    Console.Write("Дано число ");
                    Console.WriteLine(number);

                    Console.Write("Количeство десятков в числе: ");
                    Console.WriteLine(number / 10);

                    Console.Write("Количeство единиц в числе: ");
                    Console.WriteLine(number % 10);

                    break;

                case 6:

                    /*-------Дано четырехзначное число. Найти:
	                                                        -   сумму его цифр;
	                                                        -   произведение его цифр.-------*/

                    Console.WriteLine("Введите четырехзначное число:");
                    number = int.Parse(Console.ReadLine());

                    Console.Write("Сумма его цифр: ");
                    Console.WriteLine((number / 1000) + ((number / 100) % 10) + ((number/10) % 10)+ (number%10));

                    break;

                case 7:

                    /*-------В трехзначном числе x зачеркнули его вторую цифру.
                             Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x,
                             то получилось число 456. Найти число x.------------------------------------------------------------*/

                    int x, resultNumber = 456;
                    x = (((resultNumber / 100) * 100) + ((resultNumber % 10) * 10) + ((resultNumber / 10)%10));

                    Console.Write("Число полученное в результате приписки второй цифры: ");
                    Console.WriteLine(resultNumber);

                    Console.Write("Если приписать цифру 6 на свое бывшее место получится: ");
                    Console.WriteLine(x);

                    break;

                case 8:

                    /*-------Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
	                            -   не X и не Y;
	                            -   X или (не X и Y);
	                            -   (не X и Y) или Y.-----------------------------------------------------------------------------*/

                    bool X=true, Y=true, Z;

                    Console.WriteLine("Начальные значения логических величин x, y: true.");

                    Console.WriteLine("Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:");
                    Console.WriteLine("1. не X и не Y;");
                    Console.WriteLine("2. X или (не X и Y;");
                    Console.WriteLine("3. (не X и Y) или Y.");

                    Console.Write("Введите один из трех вариантов вычислений: ");
                    number = int.Parse(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            Z = !X && !Y;
                            Console.Write("Результирующее значение логического выражения: ");
                            Console.WriteLine(Z);

                            break;

                       case 2:

                            Z = X || (!X && Y);
                            Console.Write("Результирующее значение логического выражения: ");
                            Console.WriteLine(Z);

                            break;

                        case 3:

                            Z = (!X && Y)||Y;
                            Console.Write("Результирующее значение логического выражения: ");
                            Console.WriteLine(Z);

                            break;
                    }

                    break;
            }
            Console.ReadLine();
        }
    }
}

