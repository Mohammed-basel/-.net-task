using employeeAPI.models;

namespace employeeAPI.services
{
    public class employeeservice
    {
        static List<employee> employeeslist { get; }
        static int nextempid = 4;
        static employeeservice()
        {
            employeeslist = new List<employee>()
            {
                new employee {Id = 1,Name= "mohammed",job = "software developer ",salary = 3000},
                new employee {Id = 2,Name= "omar",job = "web devoleper ",salary = 2000},
                new employee {Id = 3,Name= "faisal",job = "graphic designer ",salary = 2200},

            };
        }
        public static List<employee> GETALL() => employeeslist;

        public static employee GET(int id) => employeeslist.FirstOrDefault(p => p.Id == id);

        public static void Add(employee employee)
        {
            employee.Id = nextempid++;
            employeeslist.Add(employee);
        }
        public static void Update(employee employee)
        {
            var index = employeeslist.FindIndex(e => e.Id == employee.Id);
            if (index == -1)
                return;
            employeeslist[index] = employee;

        }
        public static void Delete(int id)
        {
            var employee = GET(id);
            if(employee is null)
                return;
            employeeslist.Remove(employee);
        }
    }
}
