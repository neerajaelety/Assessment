using System.ComponentModel.DataAnnotations;
namespace ProjectApi.Models
{
    public class User
    {
        [Key]
        public int ID { set; get; }
        [StringLength(50)]
        public string LastName { set; get; }

        [StringLength(50)]
        public string FirstName { set; get; }
        public int Age { set; get; }
        [StringLength(100)]
        public string Intrests { set; get; }
        [StringLength(255)]
        public string Address { set; get; }
    }
}
