using Auxidus.Framework.Validation.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Me.Data.Domain.Entities
{
    public class Author : IValidatable<Author>
    {
        public Author()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }

        public ICollection<Article> Articles { get; set; }

        public bool Validate(IValidator<Author> validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            return validator.IsValid(this);
        }
    }
}
