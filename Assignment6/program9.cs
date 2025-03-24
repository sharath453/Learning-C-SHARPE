using System;

class Queue
{
    private int[] elements;
    private int front;
    private int rear;
    private int maxSize;
    
    public Queue(int size)
    {
        maxSize = size;
        elements = new int[maxSize];
        front = -1;
        rear = -1;
    }

    public void Enqueue(int item)
    {
        if (rear == maxSize - 1)
        {
            Console.WriteLine("Queue is full!");
            return;
        }
        if (front == -1)
            front = 0;
        elements[++rear] = item;
        Console.WriteLine($"{item} added to the queue.");
    }

    public void Dequeue()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue is empty!");
            return;
        }
        Console.WriteLine($"{elements[front]} removed from the queue.");
        front++;
    }

    public void Display()
    {
        if (front == -1 || front > rear)
        {
            Console.WriteLine("Queue is empty!");
            return;
        }
        Console.Write("Queue elements: ");
        for (int i = front; i <= rear; i++)
        {
            Console.Write(elements[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter queue size: ");
        int size = int.Parse(Console.ReadLine());

        Queue queue = new Queue(size);

        while (true)
        {
            Console.WriteLine("\n1. Enqueue\n2. Dequeue\n3. Display\n4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter element to enqueue: ");
                    int element = int.Parse(Console.ReadLine());
                    queue.Enqueue(element);
                    break;
                case 2:
                    queue.Dequeue();
                    break;
                case 3:
                    queue.Display();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}
