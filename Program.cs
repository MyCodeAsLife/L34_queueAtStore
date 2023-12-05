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
            int minValue = 10;
            int maxValue = 30;
            int wallet = 0;

            Queue<int> buyers = GetQueueBuyers(minValue, maxValue);
            ServeClients(ref buyers, ref wallet);
        }

        static Queue<int> GetQueueBuyers(int minValue, int maxValue)
        {
            Random random = new Random();
            Queue<int> tempQueue = new Queue<int>();

            for (int i = minValue; i <= maxValue; i++)
                tempQueue.Enqueue(random.Next(minValue, maxValue + 1));

            return tempQueue;
        }

        static void ServeClients(ref Queue<int> queue, ref int wallet)
        {
            int queueLenght = queue.Count;

            for (int i = 0; i < queueLenght; i++)
            {
                wallet += queue.Dequeue();
                Console.WriteLine($"Клиент обслужен, текущая сумма на счету: {wallet} деревянных.");
                Console.WriteLine($"Клиентов в очереди осталось: {queue.Count}.\n");

                Console.WriteLine("Для продолжения обслуживания клиентов, нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Все клиенты обслуженны.\nИтоговая сумма на счету: {wallet} деревянных.\n");
        }
    }
}
