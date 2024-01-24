namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            // adding elements
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);

            Console.WriteLine("numbers in the list: ");
            foreach (int i in list)
            {
                Console.Write(i + ", ");
               
            }
            Console.WriteLine();

            Console.WriteLine("Remove First");
            list.Remove(list.First);

            foreach (int i in list)
            {
                Console.Write(i + ", ");

            }
            Console.WriteLine();

            Console.WriteLine("Add 1 first");
            list.AddFirst(1);

            foreach (int i in list)
            {
                Console.Write(i + ", ");

            }
            Console.WriteLine();

            Console.WriteLine("Add 7 last");
            list.AddLast(7);

            foreach (int i in list)
            {
                Console.Write(i + ", ");

            }
            Console.WriteLine();
            Console.WriteLine("Does List contain 3: "+list.Contains(3));
            Console.Write("where in List is 3: ");
            int count = 1;
            LinkedListNode<int> search = list.Find(3);
            LinkedListNode<int> current = list.First;
            while (true)
            {
                if (current == search)
                {
                    Console.WriteLine(count);
                    break;
                }
                count++;
                current = current.Next;
                if (current == null)
                {
                    Console.WriteLine("No node in list");
                    break;
                }
            }
            Console.WriteLine();
            Console.Write("where is the last 3 in List: ");

            count = 1;
            search = list.FindLast(3);
            current = list.First;
            while (true)
            {
                if (current == search)
                {
                    Console.WriteLine(count);
                    break;
                }
                count++;
                current = current.Next;
                if (current == null)
                {
                    Console.WriteLine("No node in list");
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("what is the type of list: " + Convert.ToString(list.First.Value.GetType()));

            Console.WriteLine("Remove First");
            list.RemoveFirst();

            foreach (int i in list)
            {
                Console.Write(i + ", ");

            }
            Console.WriteLine();
            Console.WriteLine("Remove Last");
            list.RemoveLast();

            foreach (int i in list)
            {
                Console.Write(i + ", ");

            }
            Console.WriteLine();
            Console.WriteLine("Clear the list") ;
            list.Clear();
            if(list.Count == 0)
                Console.WriteLine("List is empty");
            else
                foreach (int i in list)
                {
                    Console.Write(i + ", ");

                }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
