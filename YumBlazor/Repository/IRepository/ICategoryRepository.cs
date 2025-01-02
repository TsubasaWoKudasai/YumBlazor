using YumBlazor.Data;

namespace YumBlazor.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public Task<Category> Create(Category obj);
        public Task<Category> Update(Category obj);
        public Task<bool> Delete(int id);
        public Task<Category> Get(int id);
        public Task<IEnumerable<Category>> GetAll();

    }
}
