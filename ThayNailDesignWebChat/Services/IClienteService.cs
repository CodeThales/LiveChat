using System.Collections.Generic;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public interface IClienteService
    {
        bool Create(Cliente cliente);
        Cliente GetSingle(int? id);
        List<Cliente> GetAll(string busca = null, bool sort = false);
        bool Update(Cliente cliente);
        bool Delete(int? id);
        
    }
}