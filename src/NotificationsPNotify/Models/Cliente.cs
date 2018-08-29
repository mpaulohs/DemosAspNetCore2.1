using System.ComponentModel.DataAnnotations;

namespace NotificationsPNotify.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        public string Nome { get; set; }
        public bool SimularException { get; set; }
    }
}
