using AutoMapper;
using Lottery.Domain;

namespace Lottery.Models.Mapping
{
    public class MapConfigurator
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<DrawnNumbers, DrawnNumbersModel>();
                config.CreateMap<NumberValue, NumberValueModel>();
                config.CreateMap<NumberValueModel, NumberValue>();
                config.CreateMap<TicketModel, Ticket>();
                config.CreateMap<ChanceModel, Chance>();
            });
        }
    }
}
