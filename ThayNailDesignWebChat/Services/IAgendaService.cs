using System.Collections.Generic;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public interface IAgendaService
    {
        bool create(Agenda agenda);
        bool delete(int? id);
        Agenda get(int? id);
        List<Agenda> getAll();
        bool update(Agenda agenda);
        
    }
}
