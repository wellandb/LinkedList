using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    internal class LinkedList
    {
        private Node head = null;
        private int size = 0;
        // Other Methods.
        public int Size()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        // Other Methods.
        public int Peek()
        {
            if(IsEmpty())
            {
                throw new System.InvalidOperationException("EmptyListException");
            }
            return head.value;
        }
        public void AddHead(int value)
        {
            head = new Node(value, head);
            size++;
        }
        public void AddTail(int value)
        {
            Node newNode = new Node(value,null);
            Node curr = head;
            if(head == null)
            {
                head = newNode;
            }
            while(curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }
        public int RemoveHead()
        {
            if(IsEmpty())
            {
                throw new System.InvalidOperationException("EmptyListException");
            }
            int value = head.value;
            head = head.next;
            size--;
            return value;
        }
        public bool Search(int data)
        {
            Node temp = head;
            while(temp != null)
            {
                if(temp.value == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public bool DeleteNode(int delValue)
        {
            Node temp = head;
            if(IsEmpty())
            {
                return false;
            }
            if(delValue == head.value)
            {
                head = head.next;
                size--;
                return true;
            }
            while(temp.next != null)
            {
                if(temp.next.value == delValue)
                {
                    temp.next = temp.next.next;
                    size--;
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void Reverse()
        {
            Node curr = head;
            Node prev = null;
            Node next =null;
            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }
        public int FindLength()
        {
            Node curr = head;
            int count = 0;
            while(curr !=null)
            {
                count++;
                curr = curr.next;
            }
            return count;
        }
        public void Print()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.Write(temp.value +" ");
                temp = temp.next;
            }
            Console.WriteLine("");
        }

        public void RemoveDuplicate()
        {
            List<int> contained = new List<int>();
            Node temp = head;
            if (IsEmpty())
            {
                return;
            }
            while (temp != null)
            {
                if (contained.Contains(temp.value))
                {
                    DeleteNode(temp.value);
                }
                else
                    contained.Add(temp.value);
                temp = temp.next;

            }


        }

        public void BubbleSort()
        {
            Node temp = head;
            if (temp == null)
                return;
            if (temp.next == null)
                return;
            bool swapped = true;
            while(swapped)
            {
                swapped = false;
                for (temp = head; temp.next != null; temp = temp.next)
                {
                    if(temp.value >= temp.next.value)
                    {
                        int tempVal = temp.value;
                        temp.value = temp.next.value;
                        temp.next.value = tempVal;
                        swapped = true;
                    }
                }
            }

        }

        public int NthNodeFromBeginning(int index)
        {
            Node temp = head;
            int curIndex = 0;
            while (temp != null)
            {
                if(curIndex == index)
                {
                    return temp.value;
                }
                temp = temp.next;
                curIndex++;
            }
            return -1;
        }

        public int NthNodeFromEnd(int index)
        {
            Node temp = head;
            if(temp == null) return -1;
            int ind = (size) - index;
            for(int i = 0; i <= ind; i++)
            {
                temp = temp.next;
            }
            return temp.value;
        }
    }
}
