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
            List<string> colors = new List<string> {"Red","Green","Blue"};
            List<string> types = new List<string> { "Stripes", "plain", "Checked" };

            //Way One 
            for (int i = 0; i < colors.Count; i++)
            {
                for (int j = 0; j < types.Count; j++)
                {
                    new ColorMatch(colors[i], types[j]);
                }
            }
            //Way Two
            new ColorMatch(colors, types);
        }
    }
    internal class ColorMatch
    {
        public string color { get; set; }
        public string type { get; set; }

        public ColorMatch(string color , string type)
        {
            this.color = color;
            this.type = type;
            Console.WriteLine($"{this.color}:{this.type}");
        }
        public ColorMatch(List<string> colors, List<string> types)
        {
            for (int i = 0; i < colors.Count; i++)
            {
                for (int j = 0; j < types.Count; j++)
                {
                    new ColorMatch(colors[i], types[j]);
                }
            }
        }

    }
}