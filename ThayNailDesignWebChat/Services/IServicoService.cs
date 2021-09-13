using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public interface IServicoService
    {
        bool create(Servico servico);
        bool delete(int? id);
        Servico get(int? id);
        List<Servico> getAll();
        bool update(Servico servico);
    }
}
