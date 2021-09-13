using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public class ServicoStaticService : IServicoService
    {
        List<Servico> GetServicos()
        {
            List<Servico> servicos = new();
            servicos.Add(new Servico { Id = 1, Nome = "Manicure", Preco = 30.00, Duracao = 40 });
            servicos.Add(new Servico { Id = 2, Nome = "Pedicure", Preco = 40.00, Duracao = 60 });
            servicos.Add(new Servico { Id = 3, Nome = "Esmaltação", Preco = 20.00, Duracao = 30 });
            servicos.Add(new Servico { Id = 4, Nome = "Pé e Mão", Preco = 65.00, Duracao = 100 });
            servicos.Add(new Servico { Id = 5, Nome = "Blindagem", Preco = 150.00, Duracao = 150 });
            servicos.Add(new Servico { Id = 6, Nome = "Alongamento", Preco = 230.00, Duracao = 240 });
            servicos.Add(new Servico { Id = 7, Nome = "Manut. Blindagem", Preco = 70.00, Duracao = 100 });
            servicos.Add(new Servico { Id = 8, Nome = "Manut. Alongamento", Preco = 120.00, Duracao = 120 });

            return servicos;
        }

        public List<Servico> getAll()
        {
            return GetServicos();
        }

        public Servico get(int? id)
        {
            return GetServicos().FirstOrDefault(s => s.Id == id);
        }

        public bool create(Servico servico)
        {

            return false;
        }        

        public bool update(Servico s)
        {
            return false;
        }

        public bool delete(int? id)
        {
            return false;
        }
    }
}

