using System;
using System.Collections.Generic;

namespace Library
{
    public class LargestName : IVisitor
    {
        private string largestname = "";

        public void Visitor(Node node)
        {
            if (node.Persona.Name.Length > largestname.Length)
            {
                largestname = node.Persona.Name;
            }

            foreach (var child in node.Children)
            {
                Visitor(child);
            }
        }

        public string Getlargestname()
        {
            return largestname;
        }
    }
}