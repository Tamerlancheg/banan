﻿Console.WriteLine("выберите операцию: \n" + "1.сложить 2 числа\n" + "2.вычесть первое из второго\n" + "3.перемножить 2 числа\n" + "4.разделить первое на второе\n" + "5.возвести в степень n первое число\n" + "6.найти квадратный корень числа\n" + "7.найти 1% от числа\n" + "8.найти факториал числа\n" + "9.выйти из программы");

bool znach = true;

while (znach)
{

    string input = Console.ReadLine();
    switch (input)
    {

        case "1":
            {

                Console.WriteLine("введите первое число");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите второе число");
                int a2 = Convert.ToInt32(Console.ReadLine());
                int summa = a1 + a2;
                Console.WriteLine("результат: " + summa + "\nвведите операцию ещё раз");
                break;
            }

        case "2":
            {
                Console.WriteLine("введите первое число");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите второе число");
                int b2 = Convert.ToInt32(Console.ReadLine());
                int raznost = b2 - b1;
                Console.WriteLine("результат: " + raznost + "\nвведите операцию ещё раз");
                break;
            }
        case "3":
            {
                Console.WriteLine("введите первое число");
                int c1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите второе число");
                int c2 = Convert.ToInt32(Console.ReadLine());
                int pro = c1 * c2;
                Console.WriteLine("результат: " + pro + "\nвведите операцию ещё раз");
                break;
            }
        case "4":
            {
                Console.WriteLine("введите первое число");
                float f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите второе число");
                float h = Convert.ToInt32(Console.ReadLine());
                if (h == 0)
                {
                    Console.WriteLine("на ноль делить нельзя!Введите второе число ещё раз");
                    float h1 = Convert.ToInt32(Console.ReadLine());
                    float del = f / h1;
                    Console.WriteLine("результат: " + del + "\nвведите операцию ещё раз");
                }
                else if (h != 0)
                {
                    float del = f / h;
                    Console.WriteLine("результат: " + del + "\nвведите операцию ещё раз");
                }
                break;
            }


        case "5":
            {

                Console.WriteLine("введи число");
                double q1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введи cтепень");
                double q2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("результат: " + Math.Pow(q1, q2) + "\nвведите операцию ещё раз");
                break;
            }
        case "6":
            {
                Console.WriteLine("введи число");
                double kor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("квадратный корень равен: " + Math.Sqrt(kor) + "\nвведите операцию ещё раз");
                break;
            }

        case "7":
            {

                Console.WriteLine("введи число");
                double num = Convert.ToDouble(Console.ReadLine());
                double prozent = (num / 100);
                Console.WriteLine("1% - {0} :" + prozent + "\nвведите операцию ещё раз", num);
                break;
            }

        case "8":

            {
                Console.WriteLine("введи число");
                int n = Convert.ToInt32(Console.ReadLine());
                int fact = 1;
                for (int i = 2; i <= n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine("факториал {0} равен: " + fact + "\nвведите операцию ещё раз", n);
                break;
            }
        case "9":
            {
                znach = false;
                break;
            }
    }
}
