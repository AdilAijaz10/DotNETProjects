namespace GenericRepositoryPatternWebAPI.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        //Foreign Key
        public int PrdoductId { get; set; }
        //Navigation Property
        public Product Product { get; set; }

    }
}
