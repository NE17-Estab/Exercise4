using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    public class Program
    {
        private static object items;
        private static object stack;
        private static IEnumerable<char> input;

        /// <summary>
        /// The main method, will handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            bool run = true;

            while (true)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }

            }
        }


        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        public static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            List<string> theList = new List<string>();

            bool move = true;

            while (true)
            //    Console.Clear();
            //Console.ReadLine();
            {
                Console.WriteLine("Give a word with + or - so that it adds or sub the word form the list:");

                string input = Console.ReadLine();
                char nav = input[0];
                string value;
                int sizeOflist = 0;


                switch (nav)
                {
                    case '+':
                        value = input.Substring(1);
                        theList.Add(value);
                        sizeOflist = theList.Count;
                        Console.WriteLine("Display the list added:" + value);
                        Console.WriteLine("List added:" + value);

                        break;
                    case '-':
                        value = input.Substring(1);
                        theList.Remove(value);
                        sizeOflist = theList.Count;
                        Console.WriteLine("Display the list sub:" + value);
                        Console.WriteLine("List sub:" + value);

                        break;
                    case '0':
                        return;
                    default:
                        break;


                }

                Console.WriteLine("Number of element:" + sizeOflist);


            }

        }
        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        public static void ExamineQueue()
        {
            Queue<string> Testqueue = new Queue<string>();
            int Qsize;

            List<string> theList = new List<string>();
            while (true)

            {
                Console.WriteLine("First In First Out Principle:");
                Console.WriteLine("Enter + to add name in queue and - to delete first name from queue:");
                Console.WriteLine("Enter '+' or '-'");
                string input = Console.ReadLine();
                char nav = input[0];
                switch (nav)
                {
                    case '+':
                        Console.WriteLine("Enter your name:");
                        string inputname = Console.ReadLine();
                        Testqueue.Enqueue(inputname);
                        Qsize = Testqueue.Count;
                        Console.WriteLine("The current Queue size is:" + Qsize);
                        break;

                    case '-':


                        Testqueue.Dequeue();
                        Qsize = Testqueue.Count;
                        Console.WriteLine("queue has " + Qsize + " people below");
                        foreach (var item in Testqueue)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case '0':
                        return;
                    default:
                        break;
                }


            }



        }


        /*
         * Loop this method untill the user inputs something to exit to main menue.
         * Create a switch with cases to enqueue items or dequeue items
         * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
        */


        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        public static void ExamineStack()
        {





            Stack<string> stack = new Stack<string>();
            int Qsize;


            while (true)

            {
                Console.WriteLine("Enter + to add the name to list or - to delete the last name: ");

                Console.WriteLine("Press + or - ");
                Console.WriteLine("Press * ");
                string input = Console.ReadLine();
                char nav = input[0];
                switch (nav)
                {
                    case '+':
                        Console.WriteLine("Name: ");
                        string inputname = Console.ReadLine();
                        stack.Push(inputname);
                        Qsize = stack.Count;
                        Console.WriteLine("The current Queue size is: " + Qsize);
                        break;

                    case '-':

                        stack.Pop();
                        Qsize = stack.Count;
                        Console.WriteLine("stack has" + Qsize + "people below");
                        foreach (var item in stack)
                        {
                            Console.WriteLine(item);
                        }
                        break;


                    case '*':
                        ReverseString();
                        break;

                    case '0':
                        return;
                    default:
                        break;
                }
            }

        }
        public static void ReverseString()
        {


            Console.WriteLine("Give a string input:");
            string inputString = Console.ReadLine();
            Stack<string> value = new Stack<string>();
            for (int i = 0; i < inputString.Length; i++)
            {
                value.Push(inputString.Substring(i, 1));
            }

            string resultstring = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                resultstring += value.Pop();
            }
            Console.WriteLine("Reverse string ------------- : " + resultstring);
        }








        /*
         * Loop this method until the user inputs something to exit to main menue.
         * Create a switch with cases to push or pop items
         * Make sure to look at the stack after pushing and and poping to see how it behaves
        */


        static void CheckParanthesis()
        {
            Console.WriteLine("Give Paranthesis: ");
            string input = Console.ReadLine();
            bool check = true;


            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {  { '(', ')' },{ '{', '}' },{ '[', ']' },{ '<', '>' }  };

            Stack<char> brackets = new Stack<char>();

            try
            {

                foreach (char c in input)
                {

                    if (bracketPairs.Keys.Contains(c))
                    {

                        brackets.Push(c);
                    }
                    else
                    {

                        if (bracketPairs.Values.Contains(c))
                        {

                            if (c == bracketPairs[brackets.First()])
                            {
                                brackets.Pop();
                            }
                            else
                            {
                                check = false;
                                brackets.Count();
                            }
                        }
                        else

                            continue;

                    }

                }
            }
            catch
            {

                check = false;
                brackets.Count();
            }
            if (brackets.Count() == 0 && check == true)
            {
                Console.WriteLine("Well Formed\n");
            }
            else
            {
                Console.WriteLine("Not Well Formed\n");
            }
        }
    }
}



            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})]
             * Example of incorrect: (()]), [), {[()}]
             */















