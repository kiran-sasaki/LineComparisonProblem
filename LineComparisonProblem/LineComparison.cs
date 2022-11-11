namespace LineComparisonProblem
{
    class LineComparison
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To Line Comparison Problem");
            //UC1
            double Length1,Length2;
            Console.WriteLine("enter the co-ordinates");
            Console.Write(" First Co-Ordinate of FirstLine x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Second Co-Ordinate of FirstLine y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third Co-Ordinate of FirstLine x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fourth Co-Ordinate of FirstLine y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            //UC2 Added Second Line Co-ordinates
            Console.Write("First Co-Ordinate of SecondLine a1: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Co-Ordinate of SecondLine b1: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third Co-Ordinate of SecondLine a2: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fourth Co-Ordinate of SecondLine b2: ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first line points= " + (x1, y1) + "," + (x2, y2));
            Console.WriteLine("Second line points= " + (a1, b1) + "," + (a2, b2));
            //Formula For Finding Length Of a Line
            Length1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Length2 = Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));
            Console.WriteLine("Length of first line is " + Length1);
            Console.WriteLine("Length of second line is " + Length2);
            //Length Equality Of Two Lines
            if (Length1.Equals(Length2))
            {
                Console.WriteLine("Both Lines Are Equal");
            }
            else
            {
                Console.WriteLine("Both Lines Are Not Equal");
            }
            //UC3
            //Comapring Length Of Two Lines
            int LengthComparison = Length1.CompareTo(Length2);
            if (LengthComparison == 0)
            {
                Console.WriteLine("Length of the two lines are equal");
            }
            else if (LengthComparison > 0)
            {
                Console.WriteLine("Length of line1 = " + Length1 + " is greater than length of line2 ="+Length2);
            }
            else
            {
                Console.WriteLine("Length of line1 = " + Length1 + " is lesser than length of line2= "+Length2);
            }
        }
    }
}
