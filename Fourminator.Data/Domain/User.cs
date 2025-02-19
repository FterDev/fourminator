using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourminator.Data.Domain
{
    public class User
    {
        public Guid Id { get; set; } = new Guid();
        public string ExternalId { get; set; }
        public string Nickname { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
