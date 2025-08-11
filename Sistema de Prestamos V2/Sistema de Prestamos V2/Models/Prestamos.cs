using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Prestamos_V2.Models
{
    public class Prestamos
    {
        [Required(ErrorMessage = "El campo ID es obligatorio.")]
        [Display(Name = "ID del Préstamo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Cedula es obligatorio.")]
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
        [Display(Name = "Monto del Préstamo")]
        [DataType(DataType.Currency)]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El campo Tasa de Interés es obligatorio.")]
        [Display(Name = "Tasa de Interés (%)")]
        public double TasaInteres { get; set; }

        [Required(ErrorMessage = "El campo Monto de la Cuota obligatorio.")]
        [Display(Name = "Monto Cuota")]
        public decimal MontoCuota { get; set; }

        [Required(ErrorMessage = "El campo de Cantidad de Cuotas es obligatorio.")]
        [Display(Name = "Cantidad de Cuotas")]
        public decimal CantidadCuotas { get; set; }

        [Required(ErrorMessage = "El campo de Tiempo es obligatorio.")]
        [Display(Name = "Tiempo del Préstamo")]
        public decimal Tiempo { get; set; }

        // Relación
        public ICollection<Clientes> Cliente { get; set; }
    }
}
