using System;
using Lottery.Domain;

namespace Lottery.Logic.Commands
{
    public class DrawNumbersCommand : LotteryCommand<object, object>
    {
        protected override object DoExecute()
        {
            var random = new Random();
            var drawnNumbers = new DrawnNumbers();

            var numbers = new NumberValue[6];
            for (byte i = 0; i < 6; i++)
                numbers[i] = new NumberValue { Value = random.Next(99) };

            drawnNumbers.Values = numbers;

            Context.DrawnNumbers.Add(drawnNumbers);

            return null;
        }
    }
}
