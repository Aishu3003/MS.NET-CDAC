using System.Xml.Linq;

namespace ArrayAssignments
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee[] arrEmps = new Employee[5];
            for (int i = 0; i < arrEmps.Length; i++)
            {
                arrEmps[i] = new Employee();

                Console.WriteLine("Enter the name ,DeptNo,Salary:");
                arrEmps[i].Name = Console.ReadLine();

                arrEmps[i].DeptNo = Convert.ToInt16(Console.ReadLine());

                arrEmps[i].Salary = Convert.ToDecimal(Console.ReadLine());


            }
            foreach (Employee emp in arrEmps)
            {
                emp.printInfo();
            }
            Employee highsalEmployee=GetEmployeeWithHighestSalary(arrEmps);
            Console.WriteLine($"\n Employee with High Salary:");
            highsalEmployee.printInfo();


            Console.WriteLine();

            Console.WriteLine("Enter the element to search:");
            int empToSearch=Convert.ToInt32(Console.ReadLine());
            Employee foundEmployee = FindEmployeeByEmpNo(arrEmps, empToSearch);
            if(foundEmployee != null)
            {
                Console.WriteLine($"\nEmployee with EmpNo {empToSearch} found");
                foundEmployee.printInfo();
            }
            else
            {
                Console.WriteLine($"Employee with EmpNo {empToSearch} not found");
            }


        }
            static Employee GetEmployeeWithHighestSalary(Employee[] employees)
            {
                Employee highestSalaryEmployee = employees[0];

                foreach (Employee emp in employees)
                {
                    if (emp.Salary > highestSalaryEmployee.Salary)
                    {
                        highestSalaryEmployee = emp;
                    }
                }

                return highestSalaryEmployee;
            }

           static Employee FindEmployeeByEmpNo(Employee[] employees, int empNo)
            {
                foreach (Employee emp in employees)
                {
                    if(emp.EmpNo == empNo)
                    {
                        return emp;
                    }
                }

            return null;
            }


        
    }
    public class Employee
    {
        static int lastEmpNo = 0;
        public int EmpNo { set; get; }

        public string Name { set; get; }
        public short DeptNo { set; get; }   
        public  decimal Salary { set; get; }

        public Employee(string name="default", short deptNo=0, decimal salary=1)
        {
            EmpNo = ++lastEmpNo;
            Name = name;
            DeptNo = deptNo;
            Salary = salary;
        }
        public void printInfo()
        {
            Console.WriteLine("Employee Record: ");
            Console.WriteLine("\tName     : " + Name);
            Console.WriteLine("\tDeptNo  : " + DeptNo);
            Console.WriteLine("\tSalary     : " + Salary);
        }


    }
}