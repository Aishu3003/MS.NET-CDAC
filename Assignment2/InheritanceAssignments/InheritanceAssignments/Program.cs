using System.Net;

namespace InheritanceAssignments
{
    internal class Program
    {
       

        void display()
        {
            Console.WriteLine("display method");
        }
        void insert()
        {
            Console.WriteLine("");
        }
        void update()
        {
            Console.WriteLine("update method");
        }
        void delete()
        {
            Console.WriteLine("delete method");
        }

        static void Main(string[] args)
        {

            Employee employee = new Manager();
            employee.CalcNetSalary();

            IDbfunctions idb;
            idb = (IDbfunctions)employee;
            idb.insert();
            idb.update();
            idb.display();
            idb.delete();


           
        }
}
    public abstract class Employee
    {
        private static int lastEmpNo = 0;
        private int EmpNo;
        private string Name;
        private short DeptNo;
       public abstract decimal Basic
        {
            get; set;
        }


        public Employee(string name="default", short deptNo=1, decimal basic=0)
        {
            EmpNo = lastEmpNo;
            Name = name;
            DeptNo = deptNo;
            Basic = basic;
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
                if (value < 0 || value > 100000)

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

        public abstract decimal CalcNetSalary();






    }
    public interface IDbfunctions
    {
        void display();
        void insert();
         void update();
        void delete();
    }
    public class Manager : Employee
    {

        private string Designation;
        public string designation
        {
            get; set;
        }
        public override decimal Basic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal CalcNetSalary()
        {
          if(Basic>0 || Basic<50000)
                return 0.9m * Basic;
          else
                throw new NotImplementedException();

        }

       

        public Manager(string name = "default", short deptNo = 1, decimal basic = 0,string _designation="") : base(name, deptNo, basic)
        {
            Designation = _designation;
        }
    }
    public class GeneralManager : Manager
    {
        private string Perks;

        public GeneralManager(string name = "default", short deptNo = 1, decimal basic = 0,string _perks="") : base(name, deptNo, basic)
        {
            Perks = _perks;
        }

        public string Perks1
        {
            get; set;
        }

        public override decimal CalcNetSalary()
        {
            //  throw new NotImplementedException();
            if (Basic > 50000 || Basic < 70000)
                return 0.9m * Basic;
            else
                throw new NotImplementedException();
        }


    }
    public class CEO : Employee
    {
        public CEO(string name = "default", short deptNo = 1, decimal basic = 0) : base(name, deptNo, basic)
        {
        }

        public override decimal Basic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public sealed override decimal CalcNetSalary()
        {
            if (Basic > 70000 || Basic < 100000)
                return 0.9m * Basic;
            else
                throw new NotImplementedException();
        }




    }

}