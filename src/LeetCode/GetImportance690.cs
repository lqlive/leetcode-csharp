using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class GetImportance690
{
    Dictionary<int, Employee> employeeMap = new Dictionary<int, Employee>();
    public int GetImportance(IList<Employee> employees, int id)
    {
        employeeMap = employees.ToDictionary(e => e.id);

        return DFS(id);
    }

    public int DFS(int id)
    {
        var employee = employeeMap[id];
        var total = employee.importance;

        foreach (var item in employee.subordinates)
        {
            total += DFS(item);
        }
        return total;
    }
}

public class Employee
{
    public int id;
    public int importance;
    public IList<int> subordinates;
}