
namespace ShiningBeautySalon.Core.Model
{
    public interface IResponse<TResult>
    {
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        TResult Result { get; set; }
    }
}
