namespace DF_NTCong_Repo_Core.Models.DAL
{
    public interface IProductRepository
    {
        IEnumerable<Product_Table> GetProducts();
        Product_Table GetProductById(int ProductId);
        void InsertProduct(Product_Table product_);
        void UpdateProduct(Product_Table product_);
        void DeleteProduct(int ProductId);
        void SaveChanges();
    }
}
