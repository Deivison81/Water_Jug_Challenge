namespace Water_Jug_Challenge.Application.Contracts.Services
{
    public interface IgenericServices<T>
    {
        Task<T> Llenar(T value);

        Task<T> Vaciar(T value);
        
        Task<T> Transferir(T value);
    }
}
