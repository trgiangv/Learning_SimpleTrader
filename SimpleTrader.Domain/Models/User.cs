﻿namespace SimpleTrader.Domain.Models
{
    public class User : DomainObject
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
