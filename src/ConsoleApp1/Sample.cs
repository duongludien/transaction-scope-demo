using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Sample
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Sample(string name)
        {
            Name = name;
        }
    }
}
