using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using ThayNailDesign.Models;


namespace ThayNailDesign.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<ThayNailDesignContext>();
                context.Database.Migrate();

                if (!context.Cliente.Any())
                {
                    context.Cliente.Add(new Cliente { Nome = "Juliane", Telefone = "91111-1111", Nasc = new DateTime(2001, 01, 01) });
                    context.Cliente.Add(new Cliente { Nome = "Bárbara", Telefone = "92222-2222", Nasc = new DateTime(2002, 02, 02) });
                    context.Cliente.Add(new Cliente { Nome = "Letícia", Telefone = "93333-3333", Nasc = new DateTime(2003, 03, 03) });
                    context.Cliente.Add(new Cliente { Nome = "Débora", Telefone = "94444-4444", Nasc = new DateTime(2004, 04, 04) });
                    context.Cliente.Add(new Cliente { Nome = "Jessy", Telefone = "95555-5555", Nasc = new DateTime(2005, 05, 05) });
                    context.Cliente.Add(new Cliente { Nome = "Flávia", Telefone = "96666-6666", Nasc = new DateTime(2006, 06, 06) });
                    context.Cliente.Add(new Cliente { Nome = "Mariana", Telefone = "97777-7777", Nasc = new DateTime(2007, 07, 07) });
                    context.Cliente.Add(new Cliente { Nome = "Ingrid", Telefone = "98888-8888", Nasc = new DateTime(2008, 08, 08) });
                    context.Cliente.Add(new Cliente { Nome = "Simone", Telefone = "99999-9999", Nasc = new DateTime(2009, 09, 09) });
                    context.Cliente.Add(new Cliente { Nome = "Rosangela", Telefone = "91010-1010", Nasc = new DateTime(2010, 10, 10) });
                }

                if (!context.Servico.Any())
                {
                    context.Servico.Add(new Servico { Nome = "Manicure", Preco = 35, Duracao = 45 });
                    context.Servico.Add(new Servico { Nome = "Pedicure", Preco = 45, Duracao = 60 });
                    context.Servico.Add(new Servico { Nome = "Blindagem", Preco = 120, Duracao = 120 });
                    context.Servico.Add(new Servico { Nome = "Alongamento", Preco = 230, Duracao = 240 });
                    context.Servico.Add(new Servico { Nome = "Spá de pés", Preco = 80, Duracao = 60 });
                    context.Servico.Add(new Servico { Nome = "Plástica de pés", Preco = 100, Duracao = 60 });
                    context.Servico.Add(new Servico { Nome = "Pacote - Manicure e Pedicure", Preco = 280, Duracao = 360 });
                    context.Servico.Add(new Servico { Nome = "Manutenção Blindagem", Preco = 60, Duracao = 120 });
                    context.Servico.Add(new Servico { Nome = "Manutenção Alongamento", Preco = 120, Duracao = 180 });
                    context.Servico.Add(new Servico { Nome = "Pacote Blindagem", Preco = 240, Duracao = 360 });
                    context.Servico.Add(new Servico { Nome = "Pacote Alongamento", Preco = 600, Duracao = 420 });
                    context.Servico.Add(new Servico { Nome = "Manicure e Pedicure", Preco = 70, Duracao = 120 });
                    context.Servico.Add(new Servico { Nome = "Decoração", Preco = 15, Duracao = 30 });
                }

                context.SaveChanges();
            }
        }
    }
}
