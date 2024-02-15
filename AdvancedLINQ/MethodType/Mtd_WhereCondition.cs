using DataLayer.PretendCompanyModals;
using Newtonsoft.Json;

namespace MethodType
{
    public class Mtd_WhereCondition
    {
        public string EmpWhereSalaryLessThan(List<EmployeeModel> employees, decimal salary)
        {
            try
            {
                List<EmployeeModel> result = employees.Where(x => x.AnnualSalary < salary).ToList();
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
                List<EmployeeModel> result = employees.Where(x => x.IsManager == IsManager).ToList();
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