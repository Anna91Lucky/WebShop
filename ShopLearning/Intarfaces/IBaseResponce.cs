namespace ShopLearning.Intarfaces
{
    public interface IBaseResponce<T>
    {
        T Data { get; }
        ResultStatusCode StatusCode { get; set; }
    }
    public enum ResultStatusCode
    {
        OK = 200,
        NotFound = 404,
        Error = 500
    }
}
