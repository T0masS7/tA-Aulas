using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aulas.Data.Model{

    public class MyUser{

        [Key]
        public int Id { get; set; }//PK

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        [StringLength(50)]
        public string Name { get; set; } = "";

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime  BirthDate { get; set; }

        [StringLength(17)]
        [Display(Name = "Número de Telefone")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        public string CellPhone { get; set; } = "";

        [StringLength(50)]
        public string? UserID {get;set;}  // 50 caractres, null

    }
}
