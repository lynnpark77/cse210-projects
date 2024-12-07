public class Product
{
    private string _productName ="";
    private string _id = "";
    private double _price = 0;
    private int _quantity = 0;

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateCost()
    {
        return _price * _quantity;
    }
    public string GetPackingInfo()
    {
        return $" {_productName} - {_id}";
    }

}