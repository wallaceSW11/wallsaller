using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.domain.Entities
{
    public class Client : EntityBase
    {
        public string Name { get; set; }
        public int FoneNumber { get; set; }

        public void Validate(out ValidationResult validationResult)
        {
            validationResult = new ClientValidator().Validate(this);
        }
    }
}