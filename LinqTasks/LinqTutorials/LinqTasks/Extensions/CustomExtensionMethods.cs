using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        return emps
            .Where(emp => emps.Any(subordinate => subordinate.Mgr == emp))
            .OrderBy(emp => emp.Ename)
            .ThenByDescending(emp => emp.Salary);
    }
}
