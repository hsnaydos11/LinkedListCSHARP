using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace LinkedListLibrary
{
    public class CircularLinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
        };
        public static Node CircularaddToEmpty(Node last, int data)
        {
            if (last != null)
                return last;
            Node temp = new Node();
            temp.data = data;
            last = temp;
            last.next = last;
            return last;
        }
        public static Node CircularInsertBegin(Node last, int data)
        {
            if (last == null)
                return CircularLinkedList.CircularaddToEmpty(last, data);
            Node temp = new Node();
            temp.data = data;
            temp.next = last.next;
            last.next = temp;
            return last;
        }
        public static Node CircularInsertEnd(Node last, int data)
        {
            if (last == null)
                return CircularLinkedList.CircularaddToEmpty(last, data);
            Node temp = new Node();
            temp.data = data;
            temp.next = last.next;
            last.next = temp;
            last = temp;
            return last;
        }
        static Node CircularInsertAfter(Node last, int data, int item)
        {
            if (last == null)
                return null;
            Node temp, p;
            p = last.next;
            do
            {
                if (p.data == item)
                {
                    temp = new Node();
                    temp.data = data;
                    temp.next = p.next;
                    p.next = temp;

                    if (p == last)
                        last = temp;
                    return last;
                }
                p = p.next;
            } while (p != last.next);

            Console.WriteLine(item + " not present in the list.");
            return last;
        }
        static void Circulartraverse(Node last)
        {
            Node p;
            if (last == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            p = last.next;
            do
            {
                Console.Write(p.data + " ");
                p = p.next;

            }
            while (p != last.next);
        }

        public static Node CirculardeleteNode(Node head, int key)
        {
            if (head == null)
                return null;

            Node curr = head, prev = new Node();
            while (curr.data != key)
            {
                if (curr.next == head)
                {
                    Console.Write("\nGiven node is not found"
                                  + " in the list!!!");
                    break;
                }
                prev = curr;
                curr = curr.next;
            }

            if (curr.next == head && curr == head)
            {
                head = null;
                return head;
            }

            if (curr == head)
            {
                prev = head;
                while (prev.next != head)
                    prev = prev.next;
                head = curr.next;
                prev.next = head;
            }

            else if (curr.next == head)
            {
                prev.next = head;
            }
            else
            {
                prev.next = curr.next;
            }
            return head;
        }
        public static void CircularprintList(Node head)
        {
            Node temp = head;
            if (head != null)
            {
                do
                {
                    Console.WriteLine("{0}", temp.data);
                    temp = temp.next;
                } while (temp != head);
            }
            Console.WriteLine("\n");
        }
        public static Node Circularpush(Node head_ref, int data)
        {
            Node ptr1 = new Node();
            ptr1.data = data;
            ptr1.next = head_ref;
            if (head_ref != null)
            {
                Node temp = head_ref;
                while (temp.next != head_ref)
                    temp = temp.next;
                temp.next = ptr1;
            }
            else
                ptr1.next = ptr1;
            head_ref = ptr1;
            return head_ref;
        }
        public static int CircularLength(Node head)
        {
            Node temp = head;
            int result = 0;
            if (head != null)
            {
                do
                {
                    temp = temp.next;
                    result++;
                } while (temp != head);
            }

            return result;

        }
        public static bool SearchCircular(Node head, int x)
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
        public static void INSERTCIRCULAR()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Node last = null;
            last = CircularLinkedList.CircularaddToEmpty(last, 7);
            last = CircularLinkedList.CircularInsertBegin(last, 1);
            last = CircularLinkedList.CircularInsertBegin(last, 3);
            last = CircularLinkedList.CircularInsertEnd(last, 2);
            last = CircularLinkedList.CircularInsertAfter(last, 8, 2);
            CircularLinkedList.Circulartraverse(last);
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void DELETECIRCULAR()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Node head = null;

            head = Circularpush(head, 7);
            head = Circularpush(head, 1);
            head = Circularpush(head, 3);
            head = Circularpush(head, 2);
            head = Circularpush(head, 8);

            Console.Write("List Before Deletion: ");
            CircularprintList(head);

            head = CirculardeleteNode(head, 3);

            Console.Write("List After Deletion: ");
            CircularprintList(head);
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void LISTCIRCULAR()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Node head = null;
            head = Circularpush(head, 7);
            head = Circularpush(head, 1);
            head = Circularpush(head, 3);
            head = Circularpush(head, 2);
            head = Circularpush(head, 8);
            Console.WriteLine("Circular List is ");
            CircularprintList(head);
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void LENGHTCIRCULAR()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Node head = null;
            head = Circularpush(head, 7);
            head = Circularpush(head, 1);
            head = Circularpush(head, 3);
            head = Circularpush(head, 2);
            head = Circularpush(head, 8);

            Console.WriteLine("\nCount of node is " + CircularLength(head));
            Thread.Sleep(100);
            stopwatch.Stop();

            Console.WriteLine("\nAverage Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
        public static void SEARCHCIRCULAR()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Node head = null;
            Node head1 = null;
            Node head2 = null;
            Node head3 = null;
            Node head4 = null;

            CircularLinkedList llist = new CircularLinkedList();
            head = Circularpush(head, 7);
            head1 = Circularpush(head, 1);
            head2 = Circularpush(head, 3);
            head3 = Circularpush(head, 2);
            head4 = Circularpush(head, 8);
            Console.WriteLine("Is the 3th item in the list 3?");
            if (SearchCircular(head3, 2))
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
        public static void CIRCULARMemory()
        {

        }
    }
}
