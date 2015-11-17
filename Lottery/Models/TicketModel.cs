using System;
using System.Collections.Generic;

namespace Lottery.Models
{
    public class TicketModel: Model
    {
        public DateTime DrawDate { get; set; }

        public ICollection<ChanceModel> Chances { get; set; }
    }
}