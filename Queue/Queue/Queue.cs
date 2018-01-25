using System;

namespace Queue
{
    // First In First Out
    public class Queue
    {
        // could use List instead of Array


        private Array[] _queueMembers;

        public Queue()
        {
            
        }

        // define the size of the queue upon creation
        public Queue(int size)
        {
            _queueMembers = new Array[size];
        }

        // define the size of the queue and its initial members upon creation
        public Queue(int size, params string[] names)
        {
            _queueMembers = new Array[size];
            for (int i = 0; i < names.Length; i++)
            {
                // todo: hmm
                _queueMembers[i] = names[i];
            }
        }

        public string Name { get; set; }
        public Int16 Length { get; set; }

        public void Initialize()
        {
            // tail = 0
        }

        // Add items to end
        public void Add()
        {
            // check IsFull
            // if full, recopy array to new array + 1

            //items[tail] = items
            //tail++
        }

        // Remove items from beginning
        public void Remove()
        {
            // Must always remove from the beginning of the queue

            //itemtoreturn = items[0]
            //for (i = 0; i < tail - 1; i++)
            //    items[i] = items[i + 1]
            //tail--
            //return itemtoreturn;

        }

        public bool IsFull()
        {
            // if (tail < size of queue) return false, else return true
            return true;

        }

        public bool IsEmpty()
        {
            // if (tail <= 0) return true, else return false
            return true;
        }
    }
}