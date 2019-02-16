using Auxidus.Framework.Validation.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Me.Data.Domain.Entities
{
    public class Article : IValidatable<Article>
    {
        public Article(Author author)
        {
            if (!author.Validate(out var brokenRules))
                throw new AggregateException("Author must be valid when creating an article", brokenRules.Select(e => new Exception(e)));
        }

        public int Id { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public byte[] Content { get; set; }
        public string PermanentLink { get; set; }

        public bool Validate(IValidator<Article> validator, out IEnumerable<string> brokenRules)
        {
            brokenRules = validator.BrokenRules(this);
            return validator.IsValid(this);
        }
    }
}
