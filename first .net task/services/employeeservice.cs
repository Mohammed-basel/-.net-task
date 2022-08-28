using employeeAPI.models;
using first_.net_task.services;
using static System.Reflection.Metadata.BlobBuilder;

namespace employeeAPI.services
{
    public class employeeservice : employeeinterface
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
        

        public async Task<List<employee>> Create(employee employees)
        {
            employeeslist.Add(employees);
            return (employeeslist);
        }

        public async Task<List<employee>> Delete(int id)
        {
            employee employee = employeeslist.First(x => x.Id == id);
            employeeslist.Remove(employee);
            return (employeeslist);
        }

        public async Task<employee> GetById(int id)
        {
            return (employeeslist.First(x => x.Id == id)); 
        }

        public async Task<List<employee>> GET() {
            return employeeslist;
                }
            


        public async Task<List<employee>> Update(int Id,employee update)
        {
            ;
            employee employee = employeeslist.First(x => x.Id == update.Id);
            employee.Name = update.Name;
            employee.Name = update.Name;
            return (employeeslist);
        }
    }
}
