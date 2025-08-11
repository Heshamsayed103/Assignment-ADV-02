using System.Collections;

namespace Assignment_ADV_02
{
    internal class Program
    {

        public static void PrintArrayList(ArrayList arrayList)
        {
            Console.WriteLine();
            foreach (int item in arrayList)
            {
                Console.WriteLine($"item {item}");
            }
        }

        public static int SumArrayLst(ArrayList list)
        {
            int sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is int)
                        sum += (int)list[i]; // Unboxing  Referencece --> Value   

                }

            }
            return sum;
        }

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)

            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine();
        }

        public static int SumList<T>(List<int> list)
        {
            int sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];

                }

            }
            return sum;
        }

        public static void PrintLinkedList(LinkedList<int> linkedlist)
        {
            Console.WriteLine("null");
            foreach (int item in linkedlist)
            {
                Console.WriteLine($"<--{item}-->");
            }
            Console.WriteLine("null");
            Console.WriteLine();
        }

        public static void PrintStack(Stack<int> stack)
        {
            foreach (int item in stack)
            {
                Console.WriteLine(item);

            }

        }

        public static void PrintQueue(Queue<int> queue)
        {
            foreach (int item in queue)
            {
                Console.WriteLine(item);

            }
        }

        static void Main()
        {
            #region What is Collections ?

            //// Collaction : Bulite in DS in C#
            //// Array : Container

            //// Collactions in C#
            //// Lists
            //// Hashtables

            //// Generic - non-Generic
            ////Lists:
            //// Non-Generic Lists : ArrayList - Stak - Queue
            //// Generics Lists    :List - LinkedList - Stack - Queue 

            //// Hashtables
            ////Non - Generic Hashtables : Hashtables
            ////Generics Hashtables      : Dictionary - SortedDictionary 
            #endregion

            #region Non-Generic Lists : ArrayList

            // Lists
            // Non-Generic Lists : ArrayList

            // Araylist Like Arrat
            // Array Based
            // Index

            // Array     Indexed Collection : Fixed Size 
            // ArrayList Indexed Collection : Dynamic Size 


            // Index : 0 1 2 3 4 5
            // items : 4 5 6 7 8 1
            // Size  : 6

            // Arr[1] ----> 5


            //int[] Numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };
            ////Console.WriteLine(Numbers[1]);
            ////Numbers[1] = 12;
            ////Console.WriteLine(Numbers[1]);

            //ArrayList list = new ArrayList(6);
            //Console.WriteLine($"count: {list.Count} capacity:{list.Capacity}");

            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);

            //Console.WriteLine($"count: {list.Count} capacity:{list.Capacity}");


            //ArrayList list = new ArrayList();
            //list.Add(1);
            //Console.WriteLine($"count: {list.Count} capacity:{list.Capacity}");

            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //Console.WriteLine($"count: {list.Count} capacity:{list.Capacity}");
            //list.Add(1);
            //Console.WriteLine($"count: {list.Count} capacity:{list.Capacity}");
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //list.Add(1);
            //Console.WriteLine($"count: {list.Count} capacity:{list.Capacity}");


            //Console.WriteLine(list.IsFixedSize);
            //Console.WriteLine(list.IsReadOnly);
            //Console.WriteLine(list.IsSynchronized);

            //Console.WriteLine(list[1]);

            //list.AddRange(new[] {1,2,3,4,5});

            //PrintArrayList(list);
            //int index =list.BinarySearch(2);

            //Console.WriteLine(index);

            ////Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 29, Salary = 12000 };
            ////Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 30, Salary = 13000 };
            ////Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 35, Salary = 15000 };
            ////Employee E04 = new Employee() { Id = 4, Name = "Mariam", Age = 32, Salary = 14000 };

            //ArrayList list = new ArrayList();

            //list.AddRange(new Employee[] { E01, E02, E03,E04 });
            ////int index =list.BinarySearch(E01);
            ////Console.WriteLine($"index {index}");

            //int index= list.BinarySearch(0, 2, new Employee() { Name = "Ali" },null);
            //Console.WriteLine($"index {index}");

            //Console.WriteLine("====================");
            //foreach (Employee item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            //list.Add(8);

            //Console.WriteLine($"count: {list.Count} capacity:{list.Capacity}");

            //list.Clear();

            //Console.WriteLine($"count: {list.Count} capacity:{list.Capacity}");

            //bool Flag= list.Contains(2);

            //Console.WriteLine($"Flag{Flag}"); // True

            //int[] Arr = new int[10];

            //list.CopyTo(2,Arr,3,1);

            //foreach (int item in Arr)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList arrayList= list.GetRange(0, 2);


            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //int i = list.IndexOf(5);
            // Console.WriteLine(i);

            //list.Insert(0,5);

            //PrintArrayList(list); 

            //list.InsertRange(0, new int[] { 10,20,30});

            //list.LastIndexOf(5);
            //list.RemoveAt(0);
            //list.SetRange(0,new int[] { 10,20,30});
            //list.Sort();


            //list.TrimToSize(); // Delete | Release

            //PrintArrayList(list);

            #endregion

            #region Problem With Non Generic Lists [ArrayList]

            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //int sum = SumArrayLst(list);
            //Console.WriteLine(sum); 
            #endregion

            #region Generic Lists : List
            // Generic Lists : List
            // List : Version Generic Of ArrayList
            // List : Like ArrayList Like Array : Generic - Dynamic Size

            //List<int> list = new List<int>(new int[]{1, 2, 3, 4});
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);

            //PrintList(list);

            //int sum = SumList<int>(list);
            //Console.WriteLine(sum);

            //list.AddRange(new List<int>{10,20,30});

            //int index= list.BinarySearch(2);

            //Console.WriteLine(index);



            // Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 29, Salary = 12000 };
            // Employee E02 = new Employee() { Id = 2, Name = "Ali", Age = 30, Salary = 13000 };
            // Employee E03 = new Employee() { Id = 3, Name = "Omar", Age = 35, Salary = 15000 };
            // Employee E04 = new Employee() { Id = 4, Name = "Mariam", Age = 32, Salary = 14000 };

            // List <Employee> employeee = new List<Employee> { E01,E02,E03,E04};
            //int i = employeee.BinarySearch(E04,new EmployeeComparaName());

            // Console.WriteLine(i);

            #endregion

            #region Generic Lists :LinkedList
            //// Generic Lists :LinkedList

            //// LinkedList<>

            //LinkedList<int> list = new LinkedList<int>();

            ////list.AddFirst(1);
            ////list.AddFirst(2);
            ////list.AddLast(1);
            ////list.AddLast(2);


            ////LinkedListNode<int> node = new LinkedListNode<int>(3);
            ////list.AddLast(node);

            ////list.AddAfter(node,4);
            ////list.Clear();
            ////Console.WriteLine(list.First.Next.Value);

            ////list.Remove(1);
            ////list.RemoveLast();
            ////list.Remove(list.Last.Value);


            //PrintLinkedList(list); 
            #endregion

            #region Generic Lists :Stack
            ////Generic Lists :Stack

            //Stack<int> stack  = new Stack<int >();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);


            ////int top = stack.Peek();
            ////Console.WriteLine(top);

            ////stack.Pop();

            ////bool flag = stack.TryPeek(out int top );

            ////bool flag = stack.TryPop(out int top );

            //PrintStack(stack); 
            #endregion

            #region Generic Lists :Queue
            //// Generic Lists :Queue

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //queue.Dequeue();

            //queue.Peek();

            //PrintQueue(queue); 
            #endregion
        }


    }
}


    


        
    

