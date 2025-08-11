using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Prestamos_V2.Models
{
    public class Pagos
    {
        [Required(ErrorMessage = "El campo ID es obligatorio.")]
        [Display(Name = "ID del Pago")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Cedula es obligatorio. ")]
        [Display(Name = "Cedula del Cliente")]
        [StringLength(15)]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio. ")]
        [Display(Name = "Nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio. ")]
        [Display(Name = "Apellido")]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Monto es obligatorio.")]
        [Display(Name = "Monto del Pago")]
        [DataType(DataType.Currency)]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
        [Display(Name = "Fecha del Pago")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo Método de Pago es obligatorio.")]
        [Display(Name = "Método de Pago")]
        [StringLength(50)]
        public string MetodoPago { get; set; }

        // Relación
        public ICollection<Prestamos> Prestamos { get; set; }
        public ICollection<Clientes> Clientes { get; set; }
    }
}
