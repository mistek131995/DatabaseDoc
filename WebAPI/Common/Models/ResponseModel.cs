namespace Web_API.Common.Models;

public class ResponseModel
{
    public string Message { get; set; }
    public string Payload { get; set; }
    public ResponseTypes Type { get; set; }
    public enum ResponseTypes
    {
        Success,
        Error
    }
}