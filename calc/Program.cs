using System.Text.RegularExpressions;
namespace CalcWithBugs
{

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите прмеер с одним дейсвием: ");
                string primer = Console.ReadLine();
                var calc = new CalcWithBugs();
                calc.Calculator(primer);
            }
        }
    }

    public class CalcWithBugs
    {
        public void Calculator(string primer)
        {
            string[] elements = { };
            double answer = 0;
            foreach (char a in primer)
            {
                string currentChar = a.ToString();

                if (currentChar == "+")
                {
                    elements = primer.Split('+');
                    answer = Min(elements);
                    break;
                }
                else if (currentChar == "-")
                {
                    elements = primer.Split('-');
                    answer = Sum(elements);
                    break;
                }
                else if (currentChar == "/")
                {
                    elements = primer.Split('/');
                    answer = Div(elements);
                    break;
                }
                else if (currentChar == "*")
                {
                    elements = primer.Split('*');
                    answer = Mult(elements);
                    break;
                }
                else if (currentChar == "c")
                {
                    if (primer.Contains("cos"))
                    {
                        elements = primer.Split("cos");
                        answer = Cos(elements);
                        primer = "";
                    }
                    else if (primer.Contains("ctg"))
                    {
                        elements = primer.Split("ctg");
                        answer = Ctg(elements);
                    }
                    break;
                }
                else if (currentChar == "s")
                {
                    elements = primer.Split("sin");
                    answer = Sin(elements);
                    break;
                }
                else if (currentChar == "t")
                {
                    elements = primer.Split("tg");
                    for (int i = 0; i < elements.Length; i++)
                    {
                        Console.WriteLine(elements[i]);
                    }
                    answer = Tg(elements);
                    break;
                }
                else if (primer.Contains("ctg"))
                {
                    elements = primer.Split("ctg");
                    answer = Ctg(elements);
                    break;
                }
            }
            Console.WriteLine(answer);
                Console.WriteLine(answer);
            }
        public double Sum(string[] elements)
        {
            return Double.Parse(elements[0]) + Double.Parse(elements[1]);
        }
        public double Min(string[] elements)
        {
            return Double.Parse(elements[0]) - Double.Parse(elements[1]);
        }
        public double Mult(string[] elements)
        {
            return Double.Parse(elements[0]) * Double.Parse(elements[1]);
        }
        public double Div(string[] elements)
        {
            return Double.Parse(elements[0]) * Double.Parse(elements[1]);
        }
        public double Cos(string[] elements)
        {
            return Math.Cos(Double.Parse(elements[1]));
        }
        public double Sin(string[] elements)
        {
            return Math.Cos(Double.Parse(elements[1]));
        }
        public double Tg(string[] elements)
        {
            return Math.Tan(Double.Parse(elements[1]));
        }
        public double Ctg(string[] elements)
        {
            return 1 / Math.Tan(Double.Parse(elements[1]));
        }
    }
}