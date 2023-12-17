namespace day2Assignments
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee( "Amol");
            Employee o4 = new Employee();
           
            displayEmpDetails(o1);
            displayEmpDetails(o2);
            displayEmpDetails(o3);
            displayEmpDetails(o4);  
            
            
        }

        public static void displayEmpDetails(Employee employee)
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"EmpNo:{employee.EmpNo1}");
            Console.WriteLine($"EmpName:{employee.Name1}");
            Console.WriteLine($"EmpSal:{employee.Basic_Sal}");
            Console.WriteLine($"EmpDeptNo:{employee.Dept_No}");
            Console.WriteLine($"EmpNetSalary:{employee.GetNetSalary()}");
            Console.WriteLine();

        }

    }
    public class Employee
    {
        private static int defalultEmpNo = 0;
        private int EmpNo;
        private string Name;
        private decimal Basic;
        private short DeptNo;

        public Employee(string name=null, decimal basic=0, short deptNo=1)
        {
            defalultEmpNo++;

            EmpNo = defalultEmpNo;
            Name = name;
            Basic = basic;
            DeptNo = deptNo;
        }

        public int EmpNo1
        {
            get { return EmpNo; }
            set
            {
                if (value > 0)

                    Console.WriteLine("Invalid input");

                else

                    EmpNo = value;


            }
        }
    public string Name1
        {
            get { return Name; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    Console.WriteLine("invalid input");

                else

                    Name = value;
                
            }
        }
        public decimal Basic_Sal
        {
            get { return Basic; }
            set
            {
                if(value<0 || value >100000)
                
                    Console.WriteLine("Invalid input");
                Basic = value;
            }
        }
        public short Dept_No
        {
            get { return DeptNo; }
            set
            {
                if (value > 0)
                    Console.WriteLine("Invalid Input");
                else
                    DeptNo = value;


 
            }
        }

        public decimal GetNetSalary()
        {
            return 0.9m * Basic;
        }


        

    }
}