using System.ComponentModel.DataAnnotations;

namespace netBootcamp.TASK_3
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public DateTime AddDate { get; set; }

    }
}
