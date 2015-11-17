using System;

namespace Lottery.Domain
{
    public interface IDrawnEntity
    {
        DateTime DrawDate { get; set; }
    }
}