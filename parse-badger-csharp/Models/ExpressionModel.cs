using System.ComponentModel.DataAnnotations;

namespace parse_badger_csharp.Models
{
    public class ExpressionModel
    {
        [Required]
        public string Expression { get; set; }
    }
}