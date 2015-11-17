namespace Lottery.Domain
{
    public class NumberValue : Entity
    {
        public int Value { get; set; }

        public override bool Equals(object obj)
        {
            var numberValueObj = obj as NumberValue;
            if (numberValueObj != null)
                return Value.Equals(numberValueObj.Value);

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}