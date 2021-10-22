using System;
using LinkedListLibrary;

namespace LinkedListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();

            int choice, choice1, choice2, choice3, choice4, choice5;
            Console.WriteLine("\n\n*****MAINMENU*****\n1. Single Linked List\n2. Circular Linked List\n3. Double Linked List\n4. XOR Linked List\n5. Skip Linked List\n\n****************\n");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n\n*****SUBMENU*****\n1. Insert\n2. Delete\n3. List\n4. Search\n5. Length\n6. Allocate Memory\n");
                    choice1 = Convert.ToInt32(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            SingleLinkedList.INSERTSINGLE();
                            break;
                        case 2:
                            SingleLinkedList.DELETESINGLE();
                            break;
                        case 3:
                            SingleLinkedList.LISTSINGLE();
                            break;
                        case 4:
                            SingleLinkedList.SEARCHSINGLE();
                            break;
                        case 5:
                            SingleLinkedList.LENGTHSINGLE();
                            break;
                        case 6:
                            SingleLinkedList.SINGLEMemory();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("\n\n*****SUBMENU*****\n1. Insert\n2. Delete\n3. List\n4. Search\n5. Length\n6. Allocate Memory\n");
                    choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            CircularLinkedList.INSERTCIRCULAR();
                            break;
                        case 2:
                            CircularLinkedList.DELETECIRCULAR();
                            break;
                        case 3:
                            CircularLinkedList.LISTCIRCULAR();
                            break;
                        case 4:
                            CircularLinkedList.SEARCHCIRCULAR();
                            break;
                        case 5:
                            CircularLinkedList.LENGHTCIRCULAR();
                            break;
                        case 6:
                            CircularLinkedList.CIRCULARMemory();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("\n\n*****SUBMENU*****\n1. Insert\n2. Delete\n3. List\n4. Search\n5. Length\n6. Allocate Memory\n");
                    choice3 = Convert.ToInt32(Console.ReadLine());
                    switch (choice3)
                    {
                        case 1:
                            DoubleLinkedList.INSERTDOUBLE();
                            break;
                        case 2:
                            DoubleLinkedList.DELETEDOUBLE();
                            break;
                        case 3:
                            DoubleLinkedList.LISTDOUBLE();
                            break;
                        case 4:
                            DoubleLinkedList.SEARCHDOUBLE();
                            break;
                        case 5:
                            DoubleLinkedList.DOUBLELENGTH();
                            break;
                        case 6:
                            DoubleLinkedList.DOUBLEMemory();
                            break;
                    }
                    break;

                case 4:
                    Console.WriteLine("\n\n*****SUBMENU*****\n1. Insert\n2. Delete\n3. List\n4. Search\n5. Length\n6. Allocate Memory\n");
                    choice4 = Convert.ToInt32(Console.ReadLine());
                    switch (choice4)
                    {
                        case 1:
                            //INSERTXOR();z
                            break;
                        case 2:
                            //DELETEXOR();
                            break;
                        case 3:
                            //LISTXOR();
                            break;
                        case 4:
                            //SEARCHXOR();
                            break;
                        case 5:
                            //LENGTHXOR();
                            break;
                        case 6:
                            //XORMemory();
                            break;
                    }
                    break;

                case 5:
                    Console.WriteLine("\n\n*****SUBMENU*****\n1. Insert\n2. Delete\n3. List\n4. Search\n5. Length\n6. Allocate Memory\n");
                    choice5 = Convert.ToInt32(Console.ReadLine());
                    switch (choice5)
                    {
                        case 1:
                            //INSERTSKIP();
                            break;
                        case 2:
                            //DELETESKIP();
                            break;
                        case 3:
                            //LISTSKIP();
                            break;
                        case 4:
                            //SEARCHSKIP();
                            break;
                        case 5:
                            //LENGTHSKIP();
                            break;
                        case 6:
                            //SKIPMemory();
                            break;
                    }
                    break;
            }
        }
    }
}
