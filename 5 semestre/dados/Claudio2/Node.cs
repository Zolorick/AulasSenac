using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claudio2
{
    public class Node
    {

        public int Data { get; set; }
        public Node next { get; set; }

        public Node(int data)
        {
            Data = data;
            next = null;
        }

    }

}
