using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace parse_badger_csharp.Models
{
    public class ExpressionParameterModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Value { get; set; }
    }

    public class ExpressionModel
    {
        [Required]
        public string Expression { get; set; }

        public List<ExpressionParameterModel> Parameters { get; set; } = new List<ExpressionParameterModel>();
    }
}