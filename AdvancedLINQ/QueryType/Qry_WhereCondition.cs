using DataLayer.PretendCompanyModals;
using Newtonsoft.Json;

namespace QueryType
{
    public class Qry_WhereCondition
    {
        public string EmpWhereSalaryLessThan(List<EmployeeModel> employees, decimal salary)
        {
            try
            {
                List<EmployeeModel> result = (from employee in employees
                                              where employee.AnnualSalary < salary
                                              select employee).ToList();
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
        public string EmpWhereIsManager(List<EmployeeModel> employees, bool IsManager)
        {
            try
            {
                List<EmployeeModel> result = (from employee in employees
                                              where employee.IsManager == IsManager
                                              select employee).ToList();
                return JsonConvert.SerializeObject(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}