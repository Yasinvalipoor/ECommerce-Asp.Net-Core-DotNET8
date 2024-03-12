namespace Store.Pager
{
    public class PageData<T>
    {
        public List<T> Data { get; set; } 
        public PageInfo PageInfo { get; set; }

    }
}
