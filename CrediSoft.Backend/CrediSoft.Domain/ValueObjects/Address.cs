using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Domain.ValueObjects
{
    public record Address
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public Address(string street, string city, string state, string country, string postalCode)
        {
            Street = street ?? throw new ArgumentException("Street is required.");
            City = city ?? throw new ArgumentException("City is required.");
            State = state ?? string.Empty;
            Country = country ?? throw new ArgumentException("Country is required.");
            PostalCode = postalCode ?? string.Empty;
        }
        public override string ToString() => $"{Street}, {City}, {State}, {Country}";
    }
}
