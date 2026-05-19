namespace Day1
{
    public interface IOrderDiscount
    {
        public decimal CalculateFinalAmount(Order order);
    }
}