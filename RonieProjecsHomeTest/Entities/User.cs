using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RonieProjecsHomeTest.Entities
{
    public class User
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;        
        public string Email { get; set; } = string.Empty;
        public int SourceId { get; set; }
    }
}
