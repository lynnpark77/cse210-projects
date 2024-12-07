public class Product
{
    private string _productName ="";
    private string _id = "";
    private decimal _price = 0m;
    private int _quantity = 0;

    public Product(string name, string id, decimal price, int quantity)
    {
        _productName = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public decimal CalculateCost()
    {
        return _price * _quantity;
    }
    public string GetPackingInfo()
    {
        return $" {_productName} - {_id} {_price} {_quantity}";
    }

}