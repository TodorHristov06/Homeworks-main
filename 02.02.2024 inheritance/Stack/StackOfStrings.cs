using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            data = new List<string>();
        }

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стекът е празен.");
            }

            int lastIndex = data.Count - 1;
            string poppedItem = data[lastIndex];
            data.RemoveAt(lastIndex);

            return poppedItem;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стекът е празен.");
            }

            return data[data.Count - 1];
        }


        public bool IsEmpty()
        {
            return data.Count == 0;
        }
    }
}

