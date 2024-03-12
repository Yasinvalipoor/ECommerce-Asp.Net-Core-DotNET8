namespace Store.Pager
{
    public class PageInfo
    {
        public int PageSize { get; set; }
        public int PageNumbr { get; set; }
        public int TotalCount { get; set; }
        public int PageCount => (int)(Math.Ceiling((double)TotalCount / PageSize));

        public int PageNumber { get; internal set; }
    }
}
