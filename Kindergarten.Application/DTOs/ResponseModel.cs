namespace Kindergarten.Application.DTOs;
public class ResponseModel
{
    public bool IsSuccess { get; set; }
    public short StatusCode { get; set; }
    public string Message { get; set; } = "";
}
