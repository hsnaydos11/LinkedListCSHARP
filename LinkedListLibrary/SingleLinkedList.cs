using System;
using System.Diagnostics;
using System.Threading;

namespace LinkedListLibrary
{
    public class SingleLinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; next = null; }
        }
        public void InsertSingleBegin(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;

            head = new_node;
        }
        public void InsertSingleSpecific(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous" +
                                  " node cannot be null");
                return;
            }
            Node new_node = new Node(new_data);

            new_node.next = prev_node.next;

            prev_node.next = new_node;
        }
        public void InsertSingleEnd(int new_data)
        {

            Node new_node = new Node(new_data);

            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            new_node.next = null;

            Node last = head;
            while (last.next != null)
                last = last.next;

            last.next = new_node;
            return;
        }
        public void SingleprintList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + " ");
                tnode = tnode.next;
            }
        }
        public void deleteSingle(int position)
        {
            if (head == null)
            {
                return;
            }
            Node temp = head;
            if (position == 0)
            {
                head = temp.next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
        }
        public int SingleLength()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        public bool SearchSingle(Node head, int x)
        {
            Node current = head;
            while (current != null)
            {
                if (current.data == x)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
        public static void INSERTSINGLE()
        {
            SingleLinkedList llist = new SingleLinkedList();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            llist.InsertSingleEnd(6);
            llist.InsertSingleBegin(7);
            llist.InsertSingleBegin(1);
            llist.InsertSingleEnd(4);
            llist.InsertSingleSpecific(llist.head.next, 8);
            Console.WriteLine("\nCreated Linked list is: ");
            llist.SingleprintList();
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void DELETESINGLE()
        {
            SingleLinkedList llist = new SingleLinkedList();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            llist.InsertSingleBegin(7);
            llist.InsertSingleBegin(1);
            llist.InsertSingleBegin(3);
            llist.InsertSingleBegin(2);
            llist.InsertSingleBegin(8);
            Console.WriteLine("\nCreated Linked List is ");
            llist.SingleprintList();

            llist.deleteSingle(4);
            Console.WriteLine("\nLinked List after" + "Deletion at position 4: ");
            llist.SingleprintList();
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void LENGTHSINGLE()
        {
            SingleLinkedList llist = new SingleLinkedList();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            llist.InsertSingleBegin(7);
            llist.InsertSingleBegin(1);
            llist.InsertSingleBegin(3);
            llist.InsertSingleBegin(2);
            llist.InsertSingleBegin(8);

            Console.WriteLine("Count of node is " + llist.SingleLength());
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void LISTSINGLE()
        {
            SingleLinkedList llist = new SingleLinkedList();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            llist.InsertSingleBegin(7);
            llist.InsertSingleBegin(1);
            llist.InsertSingleBegin(3);
            llist.InsertSingleBegin(2);
            llist.InsertSingleBegin(8);
            Console.WriteLine("Linked list is ");
            llist.SingleprintList();
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void SEARCHSINGLE()
        {
            SingleLinkedList llist = new SingleLinkedList();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            llist.InsertSingleBegin(7);
            llist.InsertSingleBegin(1);
            llist.InsertSingleBegin(3);
            llist.InsertSingleBegin(2);
            llist.InsertSingleBegin(8);
            Console.WriteLine("Is the 4th item in the list 2?");
            if (llist.SearchSingle(llist.head, 2)) {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void SINGLEMemory()
        {

        }

    }
}
