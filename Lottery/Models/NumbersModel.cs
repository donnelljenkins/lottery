using System.Collections.Generic;

namespace Lottery.Models
{
    public class NumbersModel : Model
    {
        public ICollection<NumberValueModel> Values { get; set; }

        public NumbersModel()
        {
            Values = new List<NumberValueModel>();
        }
    }
}