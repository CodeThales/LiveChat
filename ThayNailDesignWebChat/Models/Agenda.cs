using System;
using System.ComponentModel.DataAnnotations;


namespace ThayNailDesign.Models
{
    public class Agenda
    {
        [Display(Name = "#")]
        public int id { get; set; }


        [Display(Name = "Nome do cliente")]
        [Required(ErrorMessage = "Informe o cliente!")]
        public int clienteId { get; set; }        

        [Display(Name = "Nome do cliente")]
        public Cliente cliente { get; set; }


        [Display(Name = "Serviço")]
        [Required(ErrorMessage = "Informe o serviço que será realizado!")]
        public int servicoId { get; set; }
       
        [Display(Name = "Serviço")]
        public Servico servico { get; set; }


        [Display(Name = "Data/Hora")]
        [Required(ErrorMessage = "Informe data e hora para o atendimento!")]
        public DateTime? data { get; set; }


        [Display(Name = "Info Adicional")]
        public string descricao { get; set; }
        
    }
}
