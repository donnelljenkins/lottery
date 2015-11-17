using AutoMapper;
using Lottery.Logic.Commands;
using Lottery.Models;

namespace Lottery.Logic.Processors
{
    public class GetDrawnNumbersProcessor
    {
        private readonly GetDrawnNumbersCommand _command;

        public GetDrawnNumbersProcessor(GetDrawnNumbersCommand command = null)
        {
            _command = command ?? new GetDrawnNumbersCommand();
        }

        public GetDrawnNumbersProcessorResult Process()
        {
            var entity = _command.Execute(null);

            var model = Mapper.Map<DrawnNumbersModel>(entity);

            return new GetDrawnNumbersProcessorResult(model);
        }
    }

    public class GetDrawnNumbersProcessorResult
    {
        public bool Successful { get; set; }

        public DrawnNumbersModel DrawnNumbers { get; set; }

        public GetDrawnNumbersProcessorResult(DrawnNumbersModel drawnNumbers)
        {
            Successful = drawnNumbers != null;
            DrawnNumbers = drawnNumbers;
        }
    }
}
