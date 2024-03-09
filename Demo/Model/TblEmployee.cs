using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Demo.Model
{
    public class TblEmployee
    {
        [Key] // to set primary on table 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // to set identity on table increment by 1
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]

        public string LastName { get; set; }
        [StringLength(50)]

        public string Email { get; set; }

        public int Age { get; set; }

        public DateTime Doj { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public int IsMarried { get; set; }

        public int IsActive { get; set; }

        public int DesignationID { get; set; }

        [StringLength(50)]
        [NotMapped] // this column is not included in table
        public string Designation { get; set; }



    }
}
