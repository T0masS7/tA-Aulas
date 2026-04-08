using System.ComponentModel.DataAnnotations;

namespace Aulas.Data.Model{

    public class Course{

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Curricular {  get; set; }
        public int Semester {  get; set; }
    }
}
