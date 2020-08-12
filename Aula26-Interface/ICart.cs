namespace Aula26_Interface
{
    public interface ICart
    {
        void Read();
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void UpdateProduct(int code ,  Product newProduct);
        void ShowTotal();

    }
}