namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message, string deteils)
        {
            StatusCode = statusCode;
            Message = message;
            Details = deteils;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}
