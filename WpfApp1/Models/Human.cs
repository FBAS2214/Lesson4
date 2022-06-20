using System;

namespace WpfApp1.Models
{
    public class Human
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string? ImageUrl { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }


        //public override string ToString()
        // => @$"{Firstname} - {Lastname} - {Gender} - {Phone} - {Email} - {Address}";

    }
}
