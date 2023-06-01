using System.Linq;

namespace HW_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue" };
            List<string> types = new List<string> { "Stripes", "plain", "Checked" };
            List<Shirt> shirts = new List<Shirt>();


            for (int i = 0; i < colors.Count; i++)
            {
                for (int j = 0; j < types.Count; j++)
                {
                    shirts.Add(new Shirt(colors[i], types[j]));
                }
            }
            for (int i = 0; i < shirts.Count; i++)
            {
                Console.WriteLine(shirts[i]);
            }
        }

    }
}
    internal class Shirt
    {
        public string color { get; set; }
        public string type { get; set; }

        public Shirt(string color, string types)
        {
            this.color = color;
            this.type = types;
        }
    public override string ToString()
    {
        return $"{color}:{type}";
    }



}
