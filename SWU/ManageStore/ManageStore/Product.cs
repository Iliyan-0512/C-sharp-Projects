namespace ManageStore
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SerianNumber { get; set; }
        public Unit MeasurId { get; set; }
        public Mesuare Measur { get; set; }
        public double Price { get; set; }
    }
}
