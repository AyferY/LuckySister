using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySistem.Consol.Common
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTimeOffset createdOn { get; set; }
    }
}
