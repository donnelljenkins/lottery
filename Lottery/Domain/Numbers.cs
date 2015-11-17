using System.Collections.Generic;

namespace Lottery.Domain
{
    public class Numbers : Entity
    {
        public ICollection<NumberValue> Values { get; set; }
    }
}