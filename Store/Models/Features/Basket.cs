namespace Store.Models.Features;

public class Basket
{
    private List<BasketItem> _items = new List<BasketItem>();
    public void Add(Person p, int quantity)
    {
        var baskeyItem = _items.Where(c => c.person.Id == p.Id).FirstOrDefault();
        if (baskeyItem != null)
        {
            baskeyItem.Quantity += quantity;
        }
        else
        {
            _items.Add(new BasketItem
            {
                Quantity = quantity,
                person = p
            });
        }
    }

    public void Remove(Person p)
    {
        _items.RemoveAll(c => c.person.Id == p.Id);
    }

    public int TotalPrice() => _items.Sum(c => c.person.Id * c.Quantity);

    public void Clear() => _items.Clear();

    public IEnumerable<BasketItem> Items => Items;
}

public class BasketItem
{
    public int Id { get; set; }
    public Person person { get; set; }
    public int Quantity { get; set; }
}

        