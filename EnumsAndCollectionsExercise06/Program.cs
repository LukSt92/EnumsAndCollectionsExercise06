using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollectionsExercise06
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();
            while (true)
            {
                if (lumberjacks.Count == 0)
                    Console.Write("First lumberjack's name: ");
                else
                    Console.Write("Next lumberjack's name (blank to end): ");
                string line = Console.ReadLine();
                if (line != "")
                {
                    Lumberjack lumberjack = new Lumberjack(line);
                    Console.Write("Number of flapjacks: ");
                    if (int.TryParse(Console.ReadLine(), out int flapcjackNumber))
                        for (int i = 0; i < flapcjackNumber; i++)
                            lumberjack.TakeFlapjack((Flapjack)random.Next(4));
                    lumberjacks.Enqueue(lumberjack);
                }
                else
                    break;
            }
            while (lumberjacks.Count > 0)
            {
                lumberjacks.Dequeue().EatFlapjacks();
            }
        }
    }
}
