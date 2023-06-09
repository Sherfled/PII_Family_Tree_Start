
namespace Library
{
    public class MaxAgeVisitator : IVisitor
    {
        private int MaxAge;

        public void Visitor(Node node)
        {
            if (node.Children.Count == 0 && node.Persona.Age > MaxAge)
            {
                MaxAge = node.Persona.Age;
            }
            else
            {
                foreach (Node child in node.Children)
                {
                    Visitor(child);
                }
            }
        }
        public int GetMaxAge()
        {
            return MaxAge;
        }
    }
}