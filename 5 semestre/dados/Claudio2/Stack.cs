using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claudio2
{
    public class Stack
    {
        private Node top;
        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = top;
            top = newNode;
        }

        public int Pop() 
        {
            int data = top.Data;
            top = top.next;
            return data;
        }

    }
}
