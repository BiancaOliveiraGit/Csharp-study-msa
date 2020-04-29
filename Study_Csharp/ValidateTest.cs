using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel   not working

namespace Study_Csharp
{
    public class ValidateTest
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public string Name { get; set; }
        public bool IsValid { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Id <= 0)
        //        yield return new ValidationResult("Product Id is required", new[] { "id" });

        //}
    }
}
