﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Core.DomainObjects;

namespace UniversoGeek.Domain.Entities
{
    public class Client : Entity
    {
        protected Client() { }
        public Client(string name,
            Email email,
            Cpf cpf,
            bool active)
        {
            Name = name;
            Email = email.Address;//altera aqui
            Cpf = cpf.Number;//altera aqui
            Active = active;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }//altera aqui
        public string Cpf { get; private set; }//altera aqui
        public bool Active { get; private set; }
        public Guid AddressId { get; private set; }
        public Address Address { get; private set; }
        public string Password { get; private set; }    

        public void SetAddress(Address address)
        {
            Address = address;
            AddressId = address.Id;
        }

        public void ChangeEmail(string email)
        {
            Email = email;//altera aqui
        }

        public void SetPassword(string password)
        {
            Password = password;
        }

    }
}
