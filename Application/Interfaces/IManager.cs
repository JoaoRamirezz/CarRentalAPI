namespace Application.Interfaces;

public interface IManager<TRequest, TResponse>
{
    Task<IEnumerable<TResponse>> GetAllAsync();

    Task<TResponse> GetByIdAsync(int id);

    Task<TResponse> CreateAsync(TRequest request);

    Task<TResponse> UpdateAsync(int id, TRequest request);

    Task<TResponse> DeleteAsync(int id);
}