using AutoMapper;
using Lottery.Domain;
using Lottery.Models;

namespace Lottery.Logic.Processors
{
    public class IsWinningTicketProcessor
    {
        private readonly IsWinningTicketCommand _command;

        public IsWinningTicketProcessor(IsWinningTicketCommand command = null)
        {
            _command = command ?? new IsWinningTicketCommand();
        }

        public IsWinningTicketProcessorResult Process(TicketModel model)
        {
            var entity = Mapper.Map<Ticket>(model);

            var result = _command.Execute(entity);

            return new IsWinningTicketProcessorResult(result);
        }
    }
}