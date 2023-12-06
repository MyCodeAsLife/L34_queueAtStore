using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L34_queueAtStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallet = 0;
            Queue<int> buyers = new Queue<int>();

            FillQueue(buyers);
            wallet += ServeClients(buyers);
            Console.WriteLine($"Все клиенты обслуженны.\nИтоговая сумма на счету: {wallet} деревянных.\n");
        }

        static void FillQueue(Queue<int> queue)
        {
            Random random = new Random();
            int minValue = 10;
            int maxValue = 30;

            for (int i = minValue; i <= maxValue; i++)
                queue.Enqueue(random.Next(minValue, maxValue + 1));
        }

        static int ServeClients(Queue<int> queue)
        {
            int tempWallet = 0;

            while (queue.Count > 0)
            {
                tempWallet += queue.Dequeue();
                Console.WriteLine($"Клиент обслужен, текущая сумма на счету: {tempWallet} деревянных.");
                Console.WriteLine($"Клиентов в очереди осталось: {queue.Count}.\n");

                Console.WriteLine("Для продолжения обслуживания клиентов, нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }

            return tempWallet;
        }
    }
}
