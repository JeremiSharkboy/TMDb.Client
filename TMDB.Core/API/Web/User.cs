

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMDB.Core.API.Web
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Required]
        public int id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(50)]
        public string Username { get; set; }
    }
}