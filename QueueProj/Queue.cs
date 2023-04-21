using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProj
{
    internal class Queue 
    {
        private const int DEFAULTQUEUESIZE = 100;
        private object[] data;
        private int head = 0;
        private int tail = 0;
        private int numOfElements = 0;

        public Queue()
        {
            data = new object[DEFAULTQUEUESIZE];
        }
         
        public Queue(int size)
        {
            if (size > 0)
            {
                data = new object[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            }
        }

        public void Enqueue(object item)
        {
            if (numOfElements == data.Length)
            {
                throw new Exception("Queue is full");
            } else
            {   
                data[head] = item;
                head++;
                head = head % data.Length;
                numOfElements++;
            }
        }
      
        public object Dequeue()
        {
            if (numOfElements == 0)
            {
                throw new Exception("Queue is empty.");
            } 
                object queueItem = data[tail];
                tail++;
                tail = tail % data.Length;
                numOfElements--;
                return queueItem;
        }
    }
}
