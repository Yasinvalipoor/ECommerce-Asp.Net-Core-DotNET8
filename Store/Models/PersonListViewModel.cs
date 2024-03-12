using Store.Pager;

namespace Store.Models
{
    public class PersonListViewModel
    {
        public PageData<Person>? data { get; set; }
        public string? CurrentCategory { get; set; }
    }
}
