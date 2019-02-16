using Auxidus.Framework.Validation.Visitor;
using Me.Data.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Me.Data.Domain.Validation
{
    public class AuthorValidator : IValidator<Author>
    {
        public IEnumerable<string> BrokenRules(Author entity)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
