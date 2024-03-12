using Store.Models;
using Store.Pager;

namespace Store.Operation
{
    public class ConcreteReader : IPeopleReader
    {
        private readonly PersonDbContext personDbContext;
        public ConcreteReader(PersonDbContext personDbContext)
        {
            this.personDbContext = personDbContext;
        }

        public PageData<Person> GetAll(int PageNumber, int PageSize)
        {
            var result = new PageData<Person>()
            {
                PageInfo = new PageInfo()
                {
                    PageNumbr = PageNumber,
                    PageSize = PageSize
                }
            };
            result.Data = personDbContext.People.Skip((PageNumber - 1) * PageSize).Take(PageSize).ToList();
            result.PageInfo.TotalCount = personDbContext.People.Count();
            return result;
        }
    }
}
