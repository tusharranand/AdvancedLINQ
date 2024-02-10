using DataLayer;
using DataLayer.PretendCompanyModals;
using DataLayer.PretendCompanyModels;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class DataTest
    {
        [Fact] 
        public void GetEmployeesList_Data()
        {
            //Arrange
            int employeeCount_Expected = 8;

            //Act
            List<EmployeeModel> employeesList_Actual = Data.GetEmployees();

            //Assert
            employeesList_Actual.Should().NotBeNull();
            employeesList_Actual.Count.Should().Be(employeeCount_Expected);
        }

        [Fact] 
        public void GetDepartmentList_Data()
        {
            //Arrange
            int employeeCount_Expected = 4;

            //Act
            List<DepartmentModel> departmentList_Actual = Data.GetDepartments();

            //Assert
            departmentList_Actual.Should().NotBeNull();
            departmentList_Actual.Count.Should().Be(employeeCount_Expected);
        }
    }
}
