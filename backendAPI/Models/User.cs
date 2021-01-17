using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace backendAPI.Models
{
    public class User
    {
        
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Team { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string JoinedAt { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Avatar { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Key]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }
        
        public string Token { get; set; }
        
       
    }
}