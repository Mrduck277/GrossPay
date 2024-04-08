namespace EmployeePay
{
    class GrossPayStub
    {
        private static double NormalPay(double hoursWorked, double hourlyWages)
        {
            double Regularpay = (hoursWorked * hourlyWages);
            return Regularpay;
        }

        private static double OverTimePay(double hoursWorked, double hourlyWages)
        {
            double PayWithOvertime = (hourlyWages * 40) + (hourlyWages * 1.5 * (hoursWorked - 40));
            return PayWithOvertime;
        }

        private static double Taxes(double GrossPay)
        {
            double sum = GrossPay - (GrossPay * 0.0865);
            return sum;
        }

        private static List<double> FullPay()
        {
            double Hours; 
            double Pay;
            double sum;
            List<double> Employee = new List<double>();
            while (true)
            {
                try 
                {
                    Console.WriteLine("<-------------------------------------------->");
                    Console.Write("Please write how many hours they worked: ");
                    Hours = double.Parse(Console.ReadLine());
                    Console.WriteLine("<-------------------------------------------->");
                }
                catch
                {
                    Console.WriteLine("Please write a valid number");
                    continue;
                }
                break;
            }
            Employee.Add(Hours);


            while (true)
            {
                try
                {
                    Console.Write("Please write how much you pay them: ");
                    Pay = double.Parse(Console.ReadLine());
                    Console.WriteLine("<-------------------------------------------->");
                }
                catch
                {
                    Console.WriteLine("Please write a valid number");
                    continue;
                }
                break;
            }
            Employee.Add(Pay);

            if (Hours > 40)
            {
                sum = OverTimePay(Hours, Pay);
                Employee.Add(sum);
            }
            else
            {
                sum = NormalPay(Hours, Pay);
                Employee.Add(sum);
            }

            double taxes = Taxes(Employee[2]);
            Employee.Add(taxes);
            return Employee;
        }

        private static void GrossPayMenu()
        {
            int Option;
            while (true) {
                try 
                { 
                    Console.WriteLine("<-------------------------------------------->");
                    Console.WriteLine("           Gross pay for employess            ");
                    Console.WriteLine("                                              ");
                    Console.WriteLine("           1. Add employee                    ");
                    Console.WriteLine("           2. Edit Employees                  ");
                    Console.WriteLine("           3. See employees                   ");
                    Console.WriteLine("           4. Delete employee                 ");
                    Console.WriteLine("           5. Quit                            ");
                    Console.WriteLine("                                              ");
                    Console.WriteLine("<-------------------------------------------->");
                    Console.Write("Whats your option: ");
                    Option = int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Please put a valid response");
                    continue;
                }
                break;
            }

            switch (Option)
            {
                case 1:
                    List<double> full = FullPay();
                    Console.WriteLine($"They worked {full[0]}");
                    Console.WriteLine($"They get paid ${full[1]} per hour");
                    Console.WriteLine($"The gross pay is ${full[2]}");
                    Console.WriteLine($"The net pay is {full[3]}");
                    break;
                case 2:
                    Console.WriteLine("Not available yet");
                    break;
                case 3:
                    Console.WriteLine("Not available yet");
                    break;
                case 4:
                    Console.WriteLine("Not available yet");
                    break;
                case 5:
                    break;
            }
        }

        public static void Main(string[] args)
        {
            GrossPayMenu();
        }
    }
}