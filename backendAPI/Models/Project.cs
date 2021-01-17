using System.ComponentModel.DataAnnotations.Schema;

namespace backendAPI.Models
{
    public class Project
    {
        
        public string Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        
        public int Score { get; set; }
        
        public int DurationInDays { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        
        [ForeignKey("User")]
        public string UserEmail { get; set; }
        
        public int BugsCount { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public bool MadeDadeline { get; set; }

    }
}