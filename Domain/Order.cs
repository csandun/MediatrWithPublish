namespace MediatrWithPublish.Domain;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public decimal Total { get; set; }
    public DateTime CreatedAt { get; set; }
}