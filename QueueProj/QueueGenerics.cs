using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProj
{
    public class QueueGenerics<T>
    {
        private const int DEFAULTQUEUESIZE = 100;
        private T[] data;
        private int head = 0;
        private int tail = 0;
        private int numOfElements = 0;

        public QueueGenerics()
        {
            data = new T[DEFAULTQUEUESIZE];
        }

        public QueueGenerics(int size)
        {
            if (size > 0)
            {
                data = new T[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            }
        }

        public void Enqueue(T item)
        {
            if (numOfElements == data.Length)
            {
                throw new Exception("Queue is full");
            }
            else
            {
                data[head] = item;
                head++;
                head = head % data.Length;
                numOfElements++;
            }
        }

        public T Dequeue()
        {
            if (numOfElements == 0)
            {
                throw new Exception("Queue is empty.");
            }
            T queueItem = data[tail];
            tail++;
            tail = tail % data.Length;
            numOfElements--;
            return queueItem;
        }
    }
}

