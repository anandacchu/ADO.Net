
using ADO.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetEmployeeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepository employeeRepo = new EmployeeRepository();
            Employee_Payroll model = new Employee_Payroll();
            Console.WriteLine("Enter the choice \n 0.GetAllEmployeeDetails\n 1.AddingEmployee\n" +
               " 2.UpdateEmployee\n 3.DeletingTheEmployee\n 4.InsertIntoTwoTables\n" +
               " 5.InsertionUsingTsql\n 6.RetrivetheEmployeeAccordingToDateRange\n 7.FindSumAvgMinMaxCount");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    employeeRepo.GetAllEmployees();
                    break;
                case 1:
                    model.Name = "Anand";
                    model.Department = "HR";
                    model.Address = "3rd main";
                    model.Phone = 789562611;
                    model.BasicPay = 3000000;
                    model.StartDate = "2004-09-08";
                    model.Gender = "M";
                    model.TaxablePay = 79000;
                    model.NetPay = 6588;
                    model.IncomTax = 5676;
                    model.Deductions = 2345;
                    employeeRepo.AddEmployee(model);
                    employeeRepo.GetAllEmployees();
                    break;
                case 2:

                    model.BasicPay = 3000001;
                    model.Name = "Vishwas";
                    employeeRepo.UpdateEmployee(model);
                    employeeRepo.GetAllEmployees();
                    break;
                case 3:
                    model.Name = "Anand";
                    employeeRepo.DeleteEmployee(model);
                    employeeRepo.GetAllEmployees();
                    break;

                case 4:
                    model.Name = "Anand";
                    model.Gender = "M";
                    model.Address = "1st main";
                    employeeRepo.InsertIntoTwoTables(model);
                    employeeRepo.GetAllEmployees();
                    break;

                case 5:
                    model.Name = "Anand";
                    model.Department = "HR";
                    model.Address = "3rd main";
                    model.Phone = 878929884;
                    model.BasicPay = 3000000;
                    model.StartDate = "2004-09-08";
                    model.Gender = "M";
                    model.TaxablePay = 79000;
                    model.NetPay = 6588;
                    model.IncomTax = 5676;
                    model.Deductions = 2345;
                    employeeRepo.AddEmployee(model);
                    //so to add the information we will use the addmethod so thats y i am commenting it
                    //employeeRepo.InsertIntoTwoTablesusingTSQL(model);
                    employeeRepo.GetAllEmployees();
                    break;

                case 6:

                    employeeRepo.RetrivetheEmployeeAccordingToDateRange(model);

                    break;
                case 7:

                    employeeRepo.getAggrigateSumSalary(model);
                    employeeRepo.getAggrigateAVGSalary(model);
                    employeeRepo.getAggrigateMAXSalary(model);
                    employeeRepo.getAggrigateMINSalary(model);
                    employeeRepo.getAggrigateCOUNTSalary(model);
                    break;



            }
        }


    }
}