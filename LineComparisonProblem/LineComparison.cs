namespace LineComparisonProblem
{
    class LineComparison
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Line Comparison Problem");
            //UC1
            double Length;
            Console.WriteLine("enter the co-ordinates");
            Console.Write(" First Co-Ordinate of Line x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Second Co-Ordinate of Line y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third Co-Ordinate of Line x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fourth Co-Ordinate of Line y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first line points= " + (x1, y1) + "," + (x2, y2));
            Length = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("Length of line is " + Length);
        }
    }
}
