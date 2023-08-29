namespace ReactAspWorkShop.BackEnd.Model.Response.Common
{
    public class BaseResponse<T>
    {
        public decimal Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; } = "unexpected error";
        public List<string> Error { get; set; } = new List<string>();
        public T? ResponseObject { get; set; }
    }
}
