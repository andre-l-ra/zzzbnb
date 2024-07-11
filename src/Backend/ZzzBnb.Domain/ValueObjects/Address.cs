namespace ZzzBnb.Domain.ValueObjects;

public class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string PostalCode { get; private set; }

    public Address(string street, string city, string state, string postalCode)
    {
        Street = street;
        City = city;
        State = state;
        PostalCode = postalCode;
    }

    // Equals e GetHashCode para comparar objetos de valor por suas propriedades
    public override bool Equals(object obj)
    {
        if(ReferenceEquals(this, obj)) { return true; };
        if(ReferenceEquals(null, obj)) { return false; };

        return obj is Address address &&
        Street == address.Street &&
        City == address.City &&
        State == address.State &&
        PostalCode == address.PostalCode;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Street, City, State, PostalCode);
    }

}