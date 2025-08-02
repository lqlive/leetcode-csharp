using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    public class GetImportance690Test
    {
        [Fact]
        public void TestGetImportance()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    id = 1,
                    importance = 5,
                    subordinates = []
                }
            };
            var result = new GetImportance690().GetImportance(employees, 1);

            Assert.Equal(5, result);
        }
    }
}