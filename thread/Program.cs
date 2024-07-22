
using System.Reflection.PortableExecutable;
using System.Threading;

namespace thread
{

   
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            stack.Peek();

            foreach (var item in stack) 
            {
                Console.WriteLine(item);
            
            }
            

        }

       
            
        



    }
}