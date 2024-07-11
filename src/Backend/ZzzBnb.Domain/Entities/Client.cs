using ZzzBnb.Domain.Aggregates;
using ZzzBnb.Domain.Exceptions;
using ZzzBnb.Domain.ValueObjects;

namespace ZzzBnb.Domain.Entities;

public class Client : BaseEntity, IAggregateRoot
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }

    public Address Address { get; private set; }

    private readonly List<Reservation> _reservations;
    public IReadOnlyCollection<Reservation> Reservations => _reservations.AsReadOnly();

    public Client(string name, string email, string phone, Address address)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
        _reservations = new List<Reservation>();            
    }

    public void UpdateInformations(string name, string phone, string email, Address address)
    {
        Name = name;
        Phone = phone;
        Email = email;
        Address = address;
        UpdateTimestamp();
    }

    public void AddReservation(Reservation reservation)
    {
        _reservations.Add(reservation);
        UpdateTimestamp();
    }

    public void RemoveReservation(Reservation reservation)
    {
        _reservations.Remove(reservation);
        UpdateTimestamp();
    }

    public void Validate()
    {
        if(string.IsNullOrWhiteSpace(Name)) throw new ClienteDomainException("Nome é obrigatótio");
        if(string.IsNullOrWhiteSpace(Phone)) throw new ClienteDomainException("O telefone é obrigatório");
        if(string.IsNullOrWhiteSpace(Email)) throw new ClienteDomainException("O email é obrigatório");
        if(Address == null) throw new ClienteDomainException("O endereço é obrigatório");


        
    }    
}