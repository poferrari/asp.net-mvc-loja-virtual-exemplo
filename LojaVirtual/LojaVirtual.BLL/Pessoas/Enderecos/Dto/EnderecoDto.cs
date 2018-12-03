using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.BLL.Pessoas.Enderecos.Dto
{
    public class EnderecoDto
    {
        [Display(Name = "UF", Description = "Unidade Federativa (UF)")]
        [UIHint("UFDropDownList")]
        public int UFId { get; set; }
        [Display(Name = "Município")]
        [UIHint("MunicipioDropDownList")]
        public int MunicipioId { get; set; }
    }
}
