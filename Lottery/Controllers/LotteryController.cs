using System.Web.Http;
using Lottery.Logic.Processors;
using Lottery.Models;

namespace Lottery.Controllers
{
    [Route("api/lottery")]
    public class LotteryController : ApiController
    {
        // GET: api/lottery
        [HttpGet]
        public GetDrawnNumbersProcessorResult Get()
        {
            var processor = new GetDrawnNumbersProcessor();
            return processor.Process();
        }

        [HttpPut]
        [Route("api/lottery/iswinner")]
        public IsWinningTicketProcessorResult GetIsWinningTicket(TicketModel ticket)
        {
            var processor = new IsWinningTicketProcessor();
            return processor.Process(ticket);
        }

        [HttpPost]
        public DrawNumbersProcessorResult DrawNumbers()
        {
            var processor = new DrawNumbersProcessor();
            return processor.Process();
        }
    }
}
