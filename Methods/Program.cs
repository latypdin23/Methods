using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        /// <summary>
        /// Считывает строку символов с консоли и преобразует ее к целому числу. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <returns>Число типа int</returns>
        static int EnterNumber()
        {
            bool flag = true;
            int number;
            do
            {
                Console.WriteLine("Введите целое число:");
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if(isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести целое число");
                }
            }
            while (flag);

            return number;
        }
        /// <summary>
        /// Считывает строку символов с консоли и преобразует ее к целому числу. Ввод продолжается до тех пор, 
        /// пока пользователь не введет число.
        /// </summary>
        /// <param name="number">Число типа int</param>
        static void EnterNumber(out int number)
        {
            bool flag = true;

            do
            {
                Console.WriteLine("Введите целое число:");
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести целое число");
                }
            }
            while (flag);
        }
        static void Main(string[] args)
        {
            int number = EnterNumber();
            EnterNumber(out int number2);

            Console.ReadKey(true);

        }
    }
}
