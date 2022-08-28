using Microsoft.AspNetCore.Mvc;
using employeeAPI.models;

namespace first_.net_task.services
{
    public interface employeeinterface
    {
       Task<List<employee>> GET();
        Task<employee> GetById(int id);
        Task<List<employee>> Create(employee employee);
        Task<List<employee>> Update(int id, employee employee);
        Task<List<employee>> Delete(int id);
        
    }
}