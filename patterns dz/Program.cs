using System;

namespace patterns_dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, Вас приветствует математическая программа \n" + "пожалуйста введите число.");

            string userString = Console.ReadLine();

            
            
            while (!Equals(userString.ToLower(), "q"))
            {
                bool isNumber = Int32.TryParse(userString, out int userNumber);
               
                if (isNumber)
                {
                    int factorialResult = FactorialClass.Factorial(userNumber);
                    if (factorialResult == -1)
                        Console.WriteLine("Введенное число слишком велико для вычисления факториала");
                    else
                       
                        Console.WriteLine($"Факториал {userNumber} равен {factorialResult}");
                        Console.WriteLine($"Сумма от 1 до {userNumber} равна {SumClass.Sum(userNumber)}");
                        Console.WriteLine($"Максимальное четное число меньше {userNumber} равно {MaxClass.Max(userNumber)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Введенные Вами данные не является числом, повторите ввод или нажмите <Q>!");
                    userString = Console.ReadLine();
                }
            }

            Console.Write("Нажмите любую клавишу, чтобы закрыть это окно…");
            Console.ReadKey();
        }
    }

}