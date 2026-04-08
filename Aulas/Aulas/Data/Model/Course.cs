using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model{

    public class Course{

        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        public string Name { get; set; } = "";


        public int CurricularYear {  get; set; }
        public int Semester {  get; set; }
    }
}
