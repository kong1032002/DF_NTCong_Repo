namespace DF_NTCong_Repo_Core.Models.DAL
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _dataContext;
        public ProductRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        /// <summary>
        /// Delete product from DB
        /// </summary>
        /// <param name="ProductId">Product id</param>
        public void DeleteProduct(int ProductId)
        {
            Product_Table product_ = _dataContext.Product_Table.Find(ProductId);
            _dataContext.Product_Table.Remove(product_);
        }
        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public Product_Table GetProductById(int ProductId)
        {
            return _dataContext.Product_Table.Find(ProductId);
        }
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product_Table> GetProducts()
        {
            return _dataContext.Product_Table.ToList();
        }
        /// <summary>
        /// Insert product to DB
        /// </summary>
        /// <param name="product_"></param>
        public void InsertProduct(Product_Table product_)
        {
            _dataContext.Product_Table.Add(product_);
        }
        /// <summary>
        /// Save change
        /// </summary>
        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }
        /// <summary>
        /// Edit Product
        /// </summary>
        /// <param name="product_"></param>
        public void UpdateProduct(Product_Table product_)
        {
            _dataContext.Update(product_);
        }
    }
}
