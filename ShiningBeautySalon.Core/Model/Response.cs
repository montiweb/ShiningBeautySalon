
namespace ShiningBeautySalon.Core.Model
{
    public class Response<T> : IResponse<T>
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
