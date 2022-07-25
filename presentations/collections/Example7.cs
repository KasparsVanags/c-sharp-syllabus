Queue queue = new Queue();
queue.Enqueue(3);
queue.Enqueue(2);
queue.Enqueue(1);
queue.Enqueue("Four");

Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

while (queue.Count > 0)
    Console.WriteLine(queue.Dequeue());

Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);