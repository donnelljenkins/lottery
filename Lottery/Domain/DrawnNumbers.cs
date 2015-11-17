using System;

namespace Lottery.Domain
{
    public class DrawnNumbers : Numbers, IDrawnEntity
    {
        public DateTime DrawDate { get; set; }
    }
}