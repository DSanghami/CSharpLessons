namespace NWind.Models
{

    public class RepositoryEmployee
    {
        private NorthwindContext _context; // if instantiated is not done we will have null pointer exception
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public  List<Employee> AllEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
