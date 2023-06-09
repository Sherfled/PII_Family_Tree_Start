
namespace Library
{
    public class AgeFamily : IVisitor
    {
        private int SumAges;
        public void Visitor(Node node)
        {
            SumAges += node.Persona.Age;
            foreach (var child in node.Children)
            {
                Visitor(child);
            }
        }
         public int GetSumAges()
        {
            return SumAges;
        }
    }
}