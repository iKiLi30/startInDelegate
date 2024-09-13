namespace startInDelegate
{
    internal class Program
    {
        delegate double ProcessDelegate(double param1, double param2); // определяем делегата типа double с двумя параметрами того же типа
        static double Multiply(double param1, double param2) => param1 * param2; // функция по типу и параметрам одинаковые с делегатом
        static double Divide(double param1, double param2) => param1 / param2;   // функция по типу и параметрам одинаковые с делегатом
        static void Main(string[] args)
        {
            ProcessDelegate process; //создание переменной по типу делегата

            Console.WriteLine("Enter 2 numbers separate with a comma: ");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            Console.WriteLine("Enter M to multiply or D to divide:");
            input = Console.ReadLine();
            if (input == "M") process = new ProcessDelegate(Multiply);   // переменная принимающая типы и параметры функции
            else process = new ProcessDelegate(Divide);                 // переменная принимающая типы и параметры функции
            Console.WriteLine($"Result:{process(param1,param2)}");
            Console.ReadKey();
        }
    }
}
