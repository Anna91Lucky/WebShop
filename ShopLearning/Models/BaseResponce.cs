using ShopLearning.Intarfaces;

namespace ShopLearning.Models
{
    public class BaseResponce<T> : IBaseResponce<T>
    {
        public T Data => throw new NotImplementedException();

        public ResultStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}
