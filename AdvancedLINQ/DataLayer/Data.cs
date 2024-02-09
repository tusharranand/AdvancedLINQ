using DataLayer.PretendCompanyModals;
using DataLayer.PretendCompanyModels;

namespace DataLayer
{
    public static class Data
    {
        private static List<EmployeeModel> EmployeeList { get; set; }
        private static List<DepartmentModel> DepartmentList { get; set; }

        public static List<EmployeeModel> GetEmployees()
        {
            if (EmployeeList == null || EmployeeList.Count == 0)
            {
                EmployeeList = new()
                {
                    new EmployeeModel()
                    {
                        ID = 1,
                        FirstName = "Mamie",
                        LastName = "Sanders",
                        IsManager = true,
                        AnnualSalary = 600.08m,
                        DepartmentID = 1
                    },
                    new EmployeeModel()
                    {
                        ID = 2,
                        FirstName = "Ebony",
                        LastName = "Farrell",
                        IsManager = false,
                        AnnualSalary = 450.2m,
                        DepartmentID =3
                    },
                    new EmployeeModel()
                    {
                        ID = 3,
                        FirstName = "Alexandria",
                        LastName = "Marks",
                        IsManager = false,
                        AnnualSalary = 350m,
                        DepartmentID = 2
                    },
                    new EmployeeModel()
                    {
                        ID = 4,
                        FirstName = "Meghan",
                        LastName = "Church",
                        IsManager = true,
                        AnnualSalary = 450.12m,
                        DepartmentID = 2
                    },
                    new EmployeeModel()
                    {
                        ID = 5,
                        FirstName = "Martina",
                        LastName = "Hull",
                        IsManager = true,
                        AnnualSalary = 700.85m,
                        DepartmentID = 3
                    },
                    new EmployeeModel()
                    {
                        ID = 6,
                        FirstName = "Miranda",
                        LastName = "Klein",
                        IsManager = false,
                        AnnualSalary = 280.85m,
                        DepartmentID = 1
                    },
                    new EmployeeModel()
                    {
                        ID = 7,
                        FirstName = "Valentine",
                        LastName = "Escobar",
                        IsManager = false,
                        AnnualSalary = 390m,
                        DepartmentID = 3
                    },
                    new EmployeeModel()
                    {
                        ID = 8,
                        FirstName = "Kim",
                        LastName = "Golden",
                        IsManager = false,
                        AnnualSalary = 440.10m,
                        DepartmentID = 3
                    },
                };
            }
            return EmployeeList;
        }

        public static List<DepartmentModel> GetDepartments()
        {
            if (DepartmentList == null || DepartmentList.Count == 0)
            {
                DepartmentList = new()
                {
                    new DepartmentModel()
                    {
                        ID= 1,
                        ShortName = "Admin",
                        LongName = "Administration"
                    },
                    new DepartmentModel()
                    {
                        ID= 2,
                        ShortName = "HR",
                        LongName = "Human Resources"
                    },
                    new DepartmentModel()
                    {
                        ID= 3,
                        ShortName = "Tech",
                        LongName = "Technology"
                    },
                    new DepartmentModel()
                    {
                        ID= 4,
                        ShortName = "HK",
                        LongName = "House Keeping"
                    },
                };
            }
            return DepartmentList;
        }
    }
}
