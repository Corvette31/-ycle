using System;

namespace Сycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usetInput;
            string repeatableMessage;

            Console.Write("Введите сообщение которое будет вывыдоться: ");
            repeatableMessage = Console.ReadLine();
            Console.Write("Введите кол-во повторов сообщения: ");
            usetInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= usetInput; i++)
            {
                Console.WriteLine(repeatableMessage);
            }
        }
    }
}
