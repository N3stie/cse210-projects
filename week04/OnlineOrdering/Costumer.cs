public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Customer name cannot be empty");

        _name = name;
        _address = address ?? throw new ArgumentNullException(nameof(address));
    }

    public bool LivesInPhilippines() => _address.IsInPhilippines();
    public string GetName() => _name;
    public Address GetAddress() => _address;
}