using System;

namespace Patterns.Behavioral.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new StringExpression();


            var input = Console.ReadLine();
        
            var context = new Context(input);

            interpreter.Interpret(context);

            
            Console.WriteLine(context.Output);


            Console.ReadKey();
        }
    }
}
