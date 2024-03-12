using Store.Models;
using Store.Pager;

namespace Store.Operation
{
    public interface IPeopleReader
    {
        PageData<Person> GetAll(int PageNumber, int PageSize,string categoryCustomers);
    }
}
