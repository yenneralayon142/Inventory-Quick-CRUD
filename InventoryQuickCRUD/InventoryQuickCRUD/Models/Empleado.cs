using System.ComponentModel.DataAnnotations;

namespace InventoryQuickCRUD.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre Empleado")]
        public string Name { get; set; }
        [Display(Name = "Cargo")]
        public string Designation { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public DateTime? RecordCreation { get; set; }

        public DateTime? RecordUpdateOn { get; set; }

        public bool Estate { get; set; } = true;

    }
}
