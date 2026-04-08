using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model{
    /// <summary>
    /// Classe do relationamento entre alunos e disciplinas
    /// </summary>
    [PrimaryKey(nameof(StudentFK),nameof(CourseFK))] //Pk Composta(EF
    public class Registration{

        public DateTime RegistrationDate {get;set;} = DateTime.Now;

        //FK para Student
        //[Key, Column(Order = 1)] -> valido para entity framework < 6
        public int StudentFK { get; set; }
        public Student Student { get; set; } = null!;

        //Fk para course
        //[Key, Column(Order = 2)] -> valido para entity framework < 6
        public int CourseFK { get; set; }
        public Course Course { get; set; } = null!;

    }
}
