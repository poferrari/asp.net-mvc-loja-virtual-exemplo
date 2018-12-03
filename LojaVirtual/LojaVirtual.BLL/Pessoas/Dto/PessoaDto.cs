using LojaVirtual.BLL._Atributos;
using System;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.BLL.Pessoas.Dto
{
    public class PessoaDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        [MaxLength(14)]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF em formato inválido")]
        [CustomValidationCPF(ErrorMessage = "CPF incorreto")]
        public string CPF { get; set; }
        public string CEP { get; set; }
        public string Celular { get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set; }
        [Display(Name = "UF", Description = "Unidade Federativa (UF)")]
        [UIHint("UFDropDownList")]
        public int UFId { get; set; }
        [Display(Name = "Município")]
        [UIHint("MunicipioDropDownList")]
        public int MunicipioId { get; set; }
    }
}
