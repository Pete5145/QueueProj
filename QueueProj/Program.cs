namespace QueueProj
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            QueueGenerics<decimal> queue = new QueueGenerics<decimal>();

            Horse horse = new Horse
            {
                HorseName = "Triea"
            };
            Horse horse2 = new Horse
            {
                HorseName = "Trolly"
            };
            
            QueueGenerics<Horse> queue2 = new QueueGenerics<Horse>();


            queue2.Enqueue(horse);
            queue2.Enqueue(horse2);

            Console.WriteLine($"Item dequeued: {queue2.Dequeue()}");
            Console.WriteLine($"Item dequeued: {queue2.Dequeue()}"); 

            queue.Enqueue(1.00M);
            queue.Enqueue(206.6M);
            queue.Enqueue(30.06M);

            Console.WriteLine($"Item dequeued: {queue.Dequeue()}");
            Console.WriteLine($"Item dequeued: {queue.Dequeue()}");  
        }
    }
}