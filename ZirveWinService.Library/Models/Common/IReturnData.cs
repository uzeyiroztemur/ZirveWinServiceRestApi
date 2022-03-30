namespace ZirveWinService.Library.Models
{
    public interface IReturnData<T>
    {
        ReturnStatus Status { get; set; }
        string Message { get; set; }
        T Data { get; set; }
        int TotalCount { get; set; }
    }

    public interface IReturnData
    {
        ReturnStatus Status { get; set; }
        string Message { get; set; }
    }
}
