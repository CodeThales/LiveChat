using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThayNailDesign.Models
{
    public class Servico
    {
        [Display(Name = "#")]        
        public int Id { get; set; }

        [Display(Name = "Serviço")]
        [Required(ErrorMessage = "É obrigatório informar o nome do serviço!")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "É obrigatório informar o preço do serviço!")]
        public double Preco { get; set; }

        [Display(Name = "Tempo de Execução")]
        [Required(ErrorMessage = "É obrigatório informar o tempo de execução do serviço!")]
        public int Duracao { get; set; }

    }
}
