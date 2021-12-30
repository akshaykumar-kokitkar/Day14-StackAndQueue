namespace StackAndQueues
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            /*
            //UC1
            LinkedListStack Stack = new LinkedListStack();
            Stack.push(70);
            Stack.push(30);
            Stack.push(56);
            Stack.Display();
            Console.WriteLine("----------------------------------------------\n");

            //UC2
            //Stack.Peek();
            //Stack.Pop();
            Stack.isEmpty();
            //Stack.Display();
            Console.WriteLine("-------------------------------------------------\n");
           */

            
            //UC3
            LinkedListQueue Queue = new LinkedListQueue();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);
            Queue.Display();
            Console.WriteLine("-------------------------------------------------\n");

            //UC4
            Queue.Dequeue();
            Queue.isEmpty();
            Queue.Display();
           
        }
    }
}