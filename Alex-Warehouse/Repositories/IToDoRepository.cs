using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secret_Warehouse.Models;

namespace Secret_Warehouse.Repositories
{
    public interface IToDoRepository
    {
        Task<IEnumerable<Todo>> Get();
        
        void Post(Todo todo);

        //void Update(Todo todo);

        //void Delete(int? id);
    }
}