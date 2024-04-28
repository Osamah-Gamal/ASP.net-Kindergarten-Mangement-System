using System.ComponentModel.DataAnnotations;

namespace Kindergarten.Models
{
    public class Student
    {
        [Key]

        public int Id { get; set; }



        public string Name { get; set; }


        public int Age { get; set; }

        public DateTime Birth { get; set; }

      
        public int Card { get; set; }

        public string Gender { get; set; }


        public int Level { get; set; }

        public string Address { get; set; }

        public string State { get; set; }
    }
}
