namespace SuperParser.DAL.Entities
{
    public class Address
    {
        public string City { get; set; } 
        public string Street { get; set; }
        public string Building { get; set; }
        public object Description { get; set; }
        public string Raw { get; set; }
    }
}
