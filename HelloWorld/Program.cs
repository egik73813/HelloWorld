using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myNewArray = new MyArray<char>(12);
            var j = 0;
            for (var i = 'a'; i < 'm'; i++,j++)
            {
                myNewArray.AddElement(i);
                Console.WriteLine(myNewArray.GetElement(j));
            }
            myNewArray.AddElementTo('z', 15);
            Console.WriteLine();
            foreach (var c in myNewArray)
                Console.WriteLine(c);
            Console.WriteLine();
            myNewArray.DeleteElement(11);
            foreach (var c in myNewArray)
                Console.WriteLine(c);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            var myStack = new MyStack<string>();
            myStack.push("rty");
            myStack.push("vbn");
            myStack.push("jkl");
            myStack.push("zxc");
            Console.WriteLine(myStack.isEmpty());
            Console.WriteLine(myStack.pop());
            Console.ReadLine();
        }
    }
}
