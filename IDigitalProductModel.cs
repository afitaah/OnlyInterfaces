namespace OnlyInterfaces;

public interface IDigitalProductModel : IProductModel
{
    int TotalDownloadLeft { get; }
}