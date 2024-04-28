using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kid.Models.DBS
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int student_id { get; set; }
       
        
        public string Name { get; set; }

        public string Arabic_language { get; set; }
        public string English_language{ get; set; }
        public string Holy_Quran { get; set; }
        public string Calculation_subject { get; set; }
        public string Drawing_subject { get; set; }
        public int Guardian_id { get; set; }
    }
}
