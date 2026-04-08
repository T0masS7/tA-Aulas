using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aulas.Data.Model{
    /// <summary>
    /// classes que herda todas as características do MyUser,ou seja,
    /// tem Id,Nome,Email,etc
    /// E pode ter outras cararcteristicas específicas de um estudante
    /// </summary>
    public class Student : MyUser {

        public int StudentNumber  { get; set; }
        public decimal TuitionFee  {get;set;} //(8,2)
        public DateTime RegistrationDate {  get; set; }

    }
}
