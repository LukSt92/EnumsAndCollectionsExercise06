using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollectionsExercise06
{
    class Lumberjack
    {
        public Lumberjack(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }
        public void EatFlapjacks()
        {
            foreach (Flapjack flapjack in flapjackStack)
            {
                Console.WriteLine($"{Name} ate a {flapjack} flapjack\n{flapjackStack.Pop()}");
            }
        }
    }
}
