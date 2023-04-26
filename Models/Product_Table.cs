namespace DF_NTCong_Repo_Core.Models;

public partial class Product_Table
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CategoryId { get; set; }
}
