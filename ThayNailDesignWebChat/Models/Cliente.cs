using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ThayNailDesign.Models
{
    public class Cliente
    {
        [Display(Name = "#")]        
        public int Id { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O preenchimento deste campo é obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O preenchimento deste campo é obrigatório!")]
        public string Telefone { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nasc { get; set; }

        public List<Agenda> Agendas { get; set; }
        public List<Servico> Servicos { get; set; }

    }
}
