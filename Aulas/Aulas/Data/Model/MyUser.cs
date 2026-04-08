using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aulas.Data.Model{

    public class MyUser{

        [Key]
        public int Id { get; set; }//PK
        public string Name { get; set; }//50 caractres, not null
        public DateTime  BirthDate { get; set; }
        public string CellPhone  { get; set; } // 17 caractres, not null
        public string UserID  { get; set; } // 50 caractres, null
 

    }
}
