using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        
        private int number;
        private List<Node> children = new List<Node>();
        public Person Persona;

        public int Number {
            get
            {
                return this.Number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, Person persona, List<Node> Children)
        {
            this.number = number;
            this.Persona = persona;
            this.children = Children;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
            
        }

        
    }
}
