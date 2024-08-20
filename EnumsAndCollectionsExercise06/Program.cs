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
            Console.Write("First lumberjack's name: ");
            Lumberjack lumberjack = new Lumberjack(Console.ReadLine());
            Console.Write("Number of flapjacks: ");
            if (int.TryParse(Console.ReadLine(), out int flapcjackNumber))
                for (int i = 0; i < flapcjackNumber; i++)
                    lumberjack.TakeFlapjack((Flapjack)random.Next(4));
            lumberjack.EatFlapjacks();
        }
    }
}
