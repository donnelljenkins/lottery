using System;
using System.Collections.Generic;

namespace Lottery.Domain
{
    public class Ticket: Entity, IDrawnEntity
    {
        public DateTime DrawDate { get; set; }

        public ICollection<Chance> Chances { get; set; }
    }
}