using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            */

            Person person1 = new Person("Felipe", 85);
            Person person2 = new Person("Juan", 62);
            Person person3 = new Person("Pedro", 16);
            Person person4 = new Person("Jose", 28);
            Person person5 = new Person("Federico", 5);
            Person person6 = new Person("Ines", 30);
            Person person7 = new Person("Gonzalo", 6);
            Person person8 = new Person("Bruno", 35);

            Node node1 = new Node(1, person1, new List<Node>());
            Node node2 = new Node(2, person2, new List<Node>());
            Node node3 = new Node(3, person3, new List<Node>());
            Node node4 = new Node(4, person4, new List<Node>());
            Node node5 = new Node(5, person5, new List<Node>());
            Node node6 = new Node(6, person6, new List<Node>());
            Node node7 = new Node(7, person7, new List<Node>());
            Node node8 = new Node(8, person8, new List<Node>());

            node1.AddChildren(node2);
            node1.AddChildren(node8);

            node2.AddChildren(node4);
            node2.AddChildren(node6);

            node8.AddChildren(node3);
            node8.AddChildren(node7);

            node6.AddChildren(node5);

            // --------------------------------------------------
            
            AgeFamily Age = new AgeFamily();
            Age.Visitor(node1);
            int familyage = Age.GetSumAges();
            Console.WriteLine("La suma de las edades de todos los integrantes de la familia es: " + familyage);

            MaxAgeVisitator visitator = new MaxAgeVisitator();
            visitator.Visitor(node1);
            int maxage = visitator.GetMaxAge();
            Console.WriteLine("La edad del mayor hijo es : " + maxage);

            LargestName LongName = new LargestName();
            LongName.Visitor(node1);
            string nombreLargo = LongName.Getlargestname();
            Console.WriteLine("El nombre más largo es: " + nombreLargo);

        }
    }
}
