using DataLayer;
using DataLayer.PretendCompanyModals;
using DataLayer.PretendCompanyModels;
using FluentAssertions;

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
            _ = employeesList_Actual.Should().NotBeNull();
            _ = employeesList_Actual.Count.Should().Be(employeeCount_Expected);
        }

        [Fact]
        public void GetDepartmentList_Data()
        {
            //Arrange
            int employeeCount_Expected = 4;

            //Act
            List<DepartmentModel> departmentList_Actual = Data.GetDepartments();

            //Assert
            _ = departmentList_Actual.Should().NotBeNull();
            _ = departmentList_Actual.Count.Should().Be(employeeCount_Expected);
        }
    }
}
