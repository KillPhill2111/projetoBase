using HelperStockBeta.Domain.Entities;

namespace HelperStockBeta.Domain.Interface
{
    public interface ICategoryRepository
    {
        //Assinaturas Customizadas
        
        Task<IEnumerable<Category>> GetCategoriesAsync();//a tarefa traz um array 
        Task<Category> GetIdByAsync(int id);//a tarefa necessita um Id

        //Assinatura de CRUD
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> RemoveAsync(Category category);
    }
}
