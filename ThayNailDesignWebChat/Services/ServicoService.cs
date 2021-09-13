using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Data;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public class ServicoService : IServicoService
    {
        ThayNailDesignContext context;

        public ServicoService(ThayNailDesignContext context)
        {
            this.context = context;
        }

        public List<Servico> getAll()
        {

            return context.Servico.ToList();

        }
        public bool create(Servico servico)
        {
            try
            {
                context.Servico.Add(servico);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Servico get(int? id)
        {
            return context.Servico.FirstOrDefault(s => s.Id == id);
        }

        public bool update(Servico s)
        {
            try
            {
                context.Servico.Update(s);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int? id)
        {
            try
            {
                context.Servico.Remove(get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
