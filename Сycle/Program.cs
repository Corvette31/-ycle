using System;

namespace Сycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usetInput;

            Console.Write("Введите кол-во повторов сообщения: ");
            usetInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= usetInput; i++)
            {
                Console.WriteLine($"Это сообщение вывелось {i} раз");
            }
        }
    }
}
