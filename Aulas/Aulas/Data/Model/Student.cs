using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aulas.Data.Model{
    /// <summary>
    /// classes que herda todas as características do MyUser,ou seja,
    /// tem Id,Nome,Email,etc
    /// E pode ter outras cararcteristicas específicas de um estudante
    /// </summary>
    public class Student : MyUser {

        public int StudentNumber  {get;set;}

        [Precision (8,2)] //Precisão do preço das propinas
        public decimal TuitionFee  {get;set;}

        [Display(Name = "Data de Registro")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime RegistrationDate {get;set;} = DateTime.Now;

    }
}
