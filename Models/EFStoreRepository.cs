namespace Jejan_SportsStore.Models
{
    public class EFStoreRepository: IStoreRepository
    {
        public StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
