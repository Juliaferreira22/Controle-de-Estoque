using System;
using System.ComponentModel.DataAnnotations;


namespace Api.Models

{
    public class Estoque 
    {
        public Estoque () => CriadoEm = DateTime.Now;

        [Required(ErrorMessage = "O campo ID é obrigatório")]
        public int IdProduto {get; set; }


        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }


        [Required(ErrorMessage = "O campo caracterista é obrigatório")]
        public string Caracteristica { get; set; }


        [Required(ErrorMessage = "O campo valor é obrigatório")]
        public double Valor { get; set; }


        [Required(ErrorMessage = "O campo quantidade é obrigatório")]
        public int Quantidade { get; set; }


        [Required(ErrorMessage = "O campo Nome do funcionário é obrigatório")]
        public string NomeFuncionario { get; set; }


        [Required(ErrorMessage = "O campo Loja é obrigatório")]       
        public string Loja { get; set; }



    }
}
