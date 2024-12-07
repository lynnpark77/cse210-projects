using System;
using System.Net.Sockets;

public class Customer
{
    private string _customer = "";
    private Address _address;

    public Customer(string name, Address address)
    {
        _customer = name;
        _address = address;
    }

    public string GetName()
    {
        return _customer;
    }
    public void SetName(string name)
    {
        _customer = name;
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }


}