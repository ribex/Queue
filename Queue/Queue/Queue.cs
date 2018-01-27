using System;
using System.Collections.Generic;

namespace Queue
{
    // First In First Out
    public class Queue
    {
        // could use List instead of Array


        private List<string> _queueMembers;

        public Queue()
        {
            
        }

        // define the size of the queue upon creation
        public Queue(int size)
        {
            _queueMembers = new List<string>(size);
        }

        // define the size of the queue and its initial members upon creation
        public Queue(int size, params string[] names)
        {
            _queueMembers = new List<string>(size);
            foreach (var name in names)
            {
                _queueMembers.Add(name);
            }
        }

        public string QueueName { get; set; }
        public Int16 MaxSize { get; set; }

        public int tail { get; set; }

        public void Initialize(int tail)
        {
            tail = 0;
        }

        // Add items to end
        public void Add(string item)
        {
            // check IsFull
            // if full, recopy array to new array + 1

            //items[tail] = items

            //tail++
        }

        // Remove items from beginning
        public string Remove()
        {
            // Must always remove from the beginning of the queue

            //itemtoreturn = items[0]
            //for (i = 0; i < tail - 1; i++)
            //    items[i] = items[i + 1]
            //tail--
            return item;

        }

        public bool IsFull()
        {
            // if (tail < size of queue) return false, else return true
            return true;

        }

        public bool IsEmpty()
        {
            // if (tail <= 0) return true, else return false
            return false;
        }
    }
}