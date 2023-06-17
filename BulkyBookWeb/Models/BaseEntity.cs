using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
