namespace StackAndQueues
{
    public partial class Program
    {
        public class LinkedListQueue
        {

            Node head = null;
            internal void Enqueue(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} inserted into Queue", node.data);
            }
            internal void Dequeue()
            {
                if (this.head == null)
                {
                    Console.WriteLine("Stack is Empty, Deletion is not possible");
                    return;
                }
                Console.WriteLine("Value Dequeue is {0}", this.head.data);
                this.head = this.head.next;
            }
            internal void isEmpty()
            {
                while (this.head != null)
                {
                    Dequeue();
                }
            }
            internal void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Queue is Empty");
                    return;
                }
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
    }
}