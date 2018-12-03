using LojaVirtual.Resources;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.BLL.Departamentos.Dto
{
    public class DepartamentoDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(Resource.QuantidadeCaracter150)]
        [Display(Name = "Nome", Description = "Nome do departamento")]
        public string Nome { get; set; }
        
        [StringLength(Resource.QuantidadeCaracter300)]
        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
    }
}
