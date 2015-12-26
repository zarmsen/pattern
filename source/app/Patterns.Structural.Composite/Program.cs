using System;

namespace Patterns.Structural.Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var file = new TreeNode(1, "File");
            file.Add(new TreeNode(2, "Save"));
            file.Add(new TreeNode(3, "End"));
            var edit = new TreeNode(4, "Edit") { new TreeNode(5, "Paste"), new TreeNode(6, "Copy") };
            file.Add(edit);

            Output(file);
            Output(edit);

            Console.ReadKey();
        }

        private static void Output(TreeNode nodes)
        {
            nodes.Output();

            foreach (var node in nodes)
            {
               Console.WriteLine("\t{0}", node);
            }
        }
    }
}