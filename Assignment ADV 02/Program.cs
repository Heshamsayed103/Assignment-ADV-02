using System.Collections;

namespace Assignment_ADV_02
{
    internal class Program
    {

        static void Main()
        {

            #region Question 1:Given an array  consists of  numbers with size N and number of queries

            //in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.


            //Console.WriteLine("Enter size of array and number of queries:");
            //string[] firstLine = Console.ReadLine().Split(' ');
            //int n = int.Parse(firstLine[0]);
            //int q = int.Parse(firstLine[1]);

            //int[] arr = new int[n];
            //Console.WriteLine("Enter array elements:");
            //for (int i = 0; i < n; i++)
            //    arr[i] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter queries:");
            //for (int i = 0; i < q; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int count = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (arr[j] > x)
            //            count++;
            //    }
            //    Console.WriteLine(count);
            //}

            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey(); 
            #endregion


            #region Question 2:Given a number N and an array of N numbers. Determine if it's palindrome or not. 
            //int n = int.Parse(Console.ReadLine());


            //ArrayList numbers = new ArrayList();
            //string[] arrInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < n; i++)
            //{
            //    numbers.Add(int.Parse(arrInput[i]));
            //}


            //bool isPalindrome = true;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    if ((int)numbers[i] != (int)numbers[n - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}


            //Console.WriteLine(isPalindrome ? "YES" : "NO"); 
            #endregion


            #region Question 3 :Given a Queue, implement a function to reverse the elements of a queue using a stack

            //Console.WriteLine("Enter the size of the queue:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the elements separated by spaces:");
            //Queue q = new Queue();
            //string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < n; i++)
            //{
            //    q.Enqueue(int.Parse(input[i]));
            //}


            //Stack s = new Stack();
            //while (q.Count > 0)
            //{
            //    s.Push(q.Dequeue());
            //}

            //while (s.Count > 0)
            //{
            //    q.Enqueue(s.Pop());
            //}

            //Console.WriteLine("Reversed queue:");
            //foreach (var item in q)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey(); 
            #endregion


            #region Question 4 :Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //    Console.WriteLine("Enter a string of parentheses:");
            //    string input = Console.ReadLine();

            //    if (IsBalanced(input))
            //        Console.WriteLine("Balanced");
            //    else
            //        Console.WriteLine("Not Balanced");

            //    Console.WriteLine("\nPress any key to exit...");
            //    Console.ReadKey();
            //}

            //static bool IsBalanced(string str)
            //{
            //    Stack stack = new Stack();

            //    foreach (char ch in str)
            //    {
            //        if (ch == '(' || ch == '{' || ch == '[')
            //        {
            //            stack.Push(ch);
            //        }
            //        else if (ch == ')' || ch == '}' || ch == ']')
            //        {
            //            if (stack.Count == 0)
            //                return false;

            //            char top = (char)stack.Pop();
            //            if (!IsMatchingPair(top, ch))
            //                return false;
            //        }
            //    }

            //    return stack.Count == 0;
            //}

            //static bool IsMatchingPair(char open, char close)
            //{
            //    return (open == '(' && close == ')') ||
            //           (open == '{' && close == '}') ||
            //           (open == '[' && close == ']');
            //} 
            #endregion


            #region Question 5 :Given an array, implement a function to remove duplicate elements from an array.

            //Console.WriteLine("Enter size of array:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter array elements separated by spaces:");
            //string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //ArrayList uniqueList = new ArrayList();

            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(input[i]);
            //    if (!uniqueList.Contains(num))
            //    {
            //        uniqueList.Add(num);
            //    }
            //}

            //Console.WriteLine("Array after removing duplicates:");
            //foreach (var item in uniqueList)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey(); 

            #endregion


            #region Question 6 :Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList numbers = new ArrayList();

            //Console.WriteLine("Enter number of elements:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    numbers.Add(int.Parse(Console.ReadLine()));
            //}

            //for (int i = numbers.Count - 1; i >= 0; i--)
            //{
            //    if ((int)numbers[i] % 2 != 0)
            //    {
            //        numbers.RemoveAt(i);
            //    }
            //}

            //Console.WriteLine("ArrayList after removing odd numbers:");
            //foreach (var num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey(); 
            #endregion


            #region Question 7:Implement a queue that can hold different data types. 

            //Queue myQueue = new Queue();

            //Console.WriteLine("Enter number of elements to insert:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    if (int.TryParse(input, out int intVal))
            //        myQueue.Enqueue(intVal);
            //    else if (double.TryParse(input, out double doubleVal))
            //        myQueue.Enqueue(doubleVal);
            //    else
            //        myQueue.Enqueue(input);
            //}

            //Console.WriteLine("\nQueue contents:");
            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey(); 
            #endregion


            #region Question 8:Create a function that pushes a series of integers onto a stack.
            //Then, search for a target integer in the stack.
            //If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”).
            //If the target is not found, print a message indicating that the target was not found(“Target was not found”).


            //Stack myStack = new Stack();

            //Console.WriteLine("Enter number of integers to push:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter integers:");
            //for (int i = 0; i < n; i++)
            //{
            //    myStack.Push(int.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("Enter target integer to search:");
            //int target = int.Parse(Console.ReadLine());

            //int count = 0;
            //bool found = false;

            //foreach (int num in myStack)
            //{
            //    count++;
            //    if (num == target)
            //    {
            //        found = true;
            //        Console.WriteLine($"Target was found successfully and the count = {count}");
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("Target was not found");
            //}

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey(); 
            #endregion


            #region Question 9:Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //Console.WriteLine("Enter size of first array:");
            //int n1 = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n1];
            //Console.WriteLine("Enter elements of first array:");
            //for (int i = 0; i < n1; i++)
            //    arr1[i] = int.Parse(Console.ReadLine());


            //Console.WriteLine("Enter size of second array:");
            //int n2 = int.Parse(Console.ReadLine());
            //int[] arr2 = new int[n2];
            //Console.WriteLine("Enter elements of second array:");
            //for (int i = 0; i < n2; i++)
            //    arr2[i] = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nIntersection elements:");
            //bool[] visited = new bool[n2];
            //for (int i = 0; i < n1; i++)
            //{
            //    for (int j = 0; j < n2; j++)
            //    {
            //        if (arr1[i] == arr2[j] && !visited[j])
            //        {
            //            Console.Write(arr1[i] + " ");
            //            visited[j] = true;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey();

            #endregion


            #region Question 10:Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //ArrayList numbers = new ArrayList();

            //Console.WriteLine("Enter size of ArrayList:");
            //int size = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter elements of ArrayList:");
            //for (int i = 0; i < size; i++)
            //    numbers.Add(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Enter target sum:");
            //int target = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int start = 0; start < numbers.Count; start++)
            //{
            //    int sum = 0;
            //    for (int end = start; end < numbers.Count; end++)
            //    {
            //        sum += (int)numbers[end];
            //        if (sum == target)
            //        {
            //            Console.Write("Sublist found: ");
            //            for (int k = start; k <= end; k++)
            //                Console.Write(numbers[k] + " ");
            //            found = true;
            //            break;
            //        }
            //    }
            //    if (found) break;
            //}

            //if (!found)
            //    Console.WriteLine("No sublist with given sum found.");

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey(); 
            #endregion


            #region Question 11:Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            //Queue<int> queue = new Queue<int>();

            //Console.WriteLine("Enter size of queue:");
            //int size = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter elements of queue:");
            //for (int i = 0; i < size; i++)
            //    queue.Enqueue(int.Parse(Console.ReadLine()));

            //Console.WriteLine("Enter K:");
            //int k = int.Parse(Console.ReadLine());

            //if (k > size || k <= 0)
            //{
            //    Console.WriteLine("Invalid value of K.");
            //    return;
            //}

            //Stack<int> stack = new Stack<int>();


            //for (int i = 0; i < k; i++)
            //    stack.Push(queue.Dequeue());


            //while (stack.Count > 0)
            //    queue.Enqueue(stack.Pop());


            //for (int i = 0; i < size - k; i++)
            //    queue.Enqueue(queue.Dequeue());

            //Console.WriteLine("Queue after reversing first K elements:");
            //foreach (var item in queue)
            //    Console.Write(item + " ");

            //Console.WriteLine("\nPress any key to exit...");
            //Console.ReadKey();

            #endregion



        }
    }


    }


    


        
    

