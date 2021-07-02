using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfessorLookup.Models
{
    public record Professor
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
    }
}
