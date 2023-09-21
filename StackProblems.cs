using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack
{
    internal class StackProblems
    {
        public Node top;
        public StackProblems()
        {
            top = null;
        }

        public void pushData(int data)
        {
            Node node = new Node(data);
            node.Next = top;
            top = node;
            Console.WriteLine("{0} is inseretd into stack", data);
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);

        }

        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty deletion is not possible");
                return;
            }
            Console.WriteLine("value is popped is {0}", this.top.data);
            this.top = this.top.Next;
        }
        public void DisplayData()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");

            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.Next;
                }
            }
        }
    }
}
