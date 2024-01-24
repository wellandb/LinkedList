using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    internal class Node
    {
        internal int value;
        internal Node next;
        internal Node(int v,Node n)
        {
            value = v;
            next = n;
        }
    }
}
