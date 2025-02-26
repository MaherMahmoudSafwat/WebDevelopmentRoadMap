namespace Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack is LIFO (Last In First Out).
            Stack<int>Stk = new Stack<int>();
            Stk.Push(10);
            Stk.Push(20);
            Stk.Push(30);
            Stk.Push(40);
            Stk.Push(50);
            Console.WriteLine("Stack count is " + Stk.Count);
            Console.WriteLine(Stk.Pop());
            Console.WriteLine("Stack count is " + Stk.Count);
            Console.WriteLine(Stk.Pop());
            Console.WriteLine("Stack count is " + Stk.Count);
            Console.WriteLine(Stk.Pop());
            Console.WriteLine("Stack count is " + Stk.Count);
            Console.WriteLine(Stk.Pop());
            Console.WriteLine("Stack count is " + Stk.Count);
            int Counter = Stk.Peek();
            Console.WriteLine("Stack peek is " + Counter);
            Console.WriteLine("Stack count is " + Stk.Count);
            Console.WriteLine(Stk.Pop());
            Console.WriteLine("Stack count is " + Stk.Count);
            if (Stk.Count > 0)
            {
                Console.WriteLine("Stack count is " + Stk.Count);
                Console.WriteLine(Stk.Pop());
            }

            Console.WriteLine("------------------------------------");
            //Queue is FIFO (First In First Out).
            Queue<int> Que = new Queue<int>();
            Que.Enqueue(10);
            Que.Enqueue(20);
            Que.Enqueue(30);
            Que.Enqueue(40);
            Que.Enqueue(50);
            Console.WriteLine("Queue Count is " + Que.Count());
            Console.WriteLine(Que.Dequeue());
            Console.WriteLine("Queue Count is " + Que.Count());
            Console.WriteLine(Que.Dequeue());
            Console.WriteLine("Queue Count is " + Que.Count());
            Console.WriteLine(Que.Dequeue());
            Console.WriteLine("Queue Count is " + Que.Count());
            Console.WriteLine(Que.Dequeue());
            Counter = Que.Peek();
            Console.WriteLine(Counter);
            Console.WriteLine("Queue Count is " + Que.Count());
            Console.WriteLine(Que.Dequeue());
            if(Que.Count > 0)
            {
                Console.WriteLine("Queue Count is " + Que.Count());
                Console.WriteLine(Que.Dequeue());
            }
        }
    }
}
