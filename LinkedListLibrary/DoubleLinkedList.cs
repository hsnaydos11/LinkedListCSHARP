using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace LinkedListLibrary
{
    public class DoubleLinkedList
    {
        public Node head; 

        public class Node
        {
            public int data;
            public Node prev;
            public Node next;
            public Node(int d) { data = d; next = null; prev = null; }
        }
        public void DoubleInsertBegin(int new_data)
        {

            Node new_node = new Node(new_data);

            new_node.next = head;

            head = new_node;
        }
        public void DoubleInsertSpecific(Node prev_node, int new_data)
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
        public void DoubleInsertEnd(int new_data)
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
        public void DoubleprintList()
        {
            Node tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + " ");
                tnode = tnode.next;
            }
        }
        public void Doubleprintlist1(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }

            Console.WriteLine();
        }
        public static void Doublepush(Node head, int new_data)
        {
            Node new_Node = new Node(new_data);
            new_Node.next = head;
            new_Node.prev = null;

            if(head != null)
            {
                head.prev = new_Node;
            }
            head = new_Node;
        }
        public void DOUBLEpush(int new_data)
        {
            Node new_Node = new Node(new_data); 
            new_Node.next = head;
            new_Node.prev = null;

            if (head != null)
                head.prev = new_Node;

            head = new_Node;
        }
        public static Node DoublePUSH(Node head, int data)
        {
            Node new_Node = new Node(data);
            new_Node.next = head;
            new_Node.prev = null;

            if (head != null)
            {
                head.prev = new_Node;
            }
            head = new_Node;
            return head;
        }
        public void DoubleDelete(Node del)
        {
            if(head == null || del == null)
            {
                return;
            }
            if(head == del)
            {
                head = del.next;
            }
            if(del.next != null)
            {
                del.next.prev = del.prev;
            }
            if(del.prev!= null)
            {
                del.prev.next = del.next;
            }
            return;
        }
        public static int DoubleLength(Node node)
        {
            int res = 0;
            while (node != null)
            {
                res++;
                node = node.next;
            }
            return res;
        }
        public static bool DoubleSearch(Node head, int x)
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
        public static void INSERTDOUBLE()
        {
            DoubleLinkedList llist = new DoubleLinkedList();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            llist.DoubleInsertEnd(7);
            llist.DoubleInsertBegin(1);
            llist.DoubleInsertBegin(3);
            llist.DoubleInsertEnd(2);
            llist.DoubleInsertSpecific(llist.head.next, 8);
            Console.WriteLine("Created Linked list is: ");
            llist.DoubleprintList();
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void DELETEDOUBLE()
        {
            DoubleLinkedList llist = new DoubleLinkedList();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            llist.DOUBLEpush(7);
            llist.DOUBLEpush(1);
            llist.DOUBLEpush(3);
            llist.DOUBLEpush(2);
            llist.DOUBLEpush(8);
            Console.WriteLine("\nList Before Deletion:");
            llist.Doubleprintlist1(llist.head);

            llist.DoubleDelete(llist.head.next);
            Console.WriteLine("\nList After Deletion: ");
            llist.Doubleprintlist1(llist.head);
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void DOUBLELENGTH()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Node head = null;
            head = DoublePUSH(head, 4);
            head = DoublePUSH(head, 3);
            head = DoublePUSH(head, 2);
            head = DoublePUSH(head, 1);
            Console.WriteLine("\nCount of node is " + DoubleLength(head));
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void LISTDOUBLE()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            DoubleLinkedList llist = new DoubleLinkedList();
            llist.DoubleInsertEnd(7);
            llist.DoubleInsertBegin(1);
            llist.DoubleInsertBegin(3);
            llist.DoubleInsertEnd(2);
            llist.DoubleInsertSpecific(llist.head.next, 8);
            Console.WriteLine("Linked list is ");
            llist.DoubleprintList();
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void SEARCHDOUBLE()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Node head = null;
            Node head1 = null;
            Node head2 = null;
            Node head3 = null;
            Node head4 = null;

            CircularLinkedList llist = new CircularLinkedList();
            head = DoublePUSH(head, 7);
            head1 = DoublePUSH(head, 1);
            head2 = DoublePUSH(head, 3);
            head3 = DoublePUSH(head, 2);
            head4 = DoublePUSH(head, 8);
            Console.WriteLine("Is the 3th item in the list 3?");
            if (DoubleSearch(head3, 2))
            {
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
        public static void DOUBLEMemory()
        {

        }
    }
}
