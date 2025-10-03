namespace gis_vn_after_merge_api.Repositories;

public interface IBaseRepository<T, in TKey>
{
	Task<T?> GetById(TKey id);
	Task<List<T>> GetAll();
	Task<int> Create(T entity);
	Task<int> Update(T entity);
	Task<int> Delete(T entity);
}