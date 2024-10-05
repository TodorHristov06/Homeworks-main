using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class RandomList : ArrayList
    {
        private RandomList random;

        public RandomList()
        {
            random = new RandomList();
        }

        public object GetRandomElement()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Списъкът е празен.");
            }

            int randomIndex = random.Next(Count);
            object randomElement = this[randomIndex];
            RemoveAt(randomIndex);

            return randomElement;
        }

        public string RandomString()
        {
            object randomElement = GetRandomElement();
            return randomElement.ToString();
        }
    }
}
