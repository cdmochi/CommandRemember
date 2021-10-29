using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Commander.Models 
{
    public class Command 
    {
        public int Id { get; set; }
        
        public string HowTo{ get; set; }
        
        [NotNull]
        [StringLength(50)]
        public string Line{ get; set; }

        [NotNull]
        [StringLength(10)]
        public string Platform { get; set; }
    }
}