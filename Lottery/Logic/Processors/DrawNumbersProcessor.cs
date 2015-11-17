using Lottery.Logic.Commands;

namespace Lottery.Logic.Processors
{
    public class DrawNumbersProcessor
    {
        private readonly DrawNumbersCommand _command;

        public DrawNumbersProcessor(DrawNumbersCommand command = null)
        {
            _command = command ?? new DrawNumbersCommand();
        }

        public DrawNumbersProcessorResult Process()
        {
            _command.Execute(null);

            return new DrawNumbersProcessorResult();
        }
    }
}