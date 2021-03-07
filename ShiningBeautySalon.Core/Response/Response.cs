using ShiningBeautySalon.Core.Response;

namespace ShiningBeautySalon.Core.Response
{
    public class Response<TResult>
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public TResult Result { get; set; }
    }
}
