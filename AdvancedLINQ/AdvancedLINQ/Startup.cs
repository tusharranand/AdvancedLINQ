using DataLayer;
using MethodType;
using QueryType;

namespace AdvancedLINQ
{
    internal class Startup
    {
        public static void Main(string[] args)
        {
            List<DataLayer.PretendCompanyModals.EmployeeModel> employees = Data.GetEmployees();
            //var departments = Data.GetDepartments();

            #region Method Type examples for Where condition
            Mtd_WhereCondition mtd_WhereSample = new();
            string result = mtd_WhereSample.EmpWhereSalaryLessThan(employees, 450m);
            Console.WriteLine(result + "\n");
            result = mtd_WhereSample.EmpWhereIsManager(employees, false);
            Console.WriteLine(result + "\n");
            #endregion

            #region Query Type examples for Where condition
            Qry_WhereCondition qry_WhereSample = new();
            result = qry_WhereSample.EmpWhereSalaryLessThan(employees, 350m);
            Console.WriteLine(result + "\n");
            result = qry_WhereSample.EmpWhereIsManager(employees, true);
            Console.WriteLine(result + "\n");
            #endregion
            _ = Console.ReadKey();
        }
    }
}