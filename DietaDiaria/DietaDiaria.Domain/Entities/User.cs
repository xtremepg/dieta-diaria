﻿using DietaDiaria.Domain._Base;
using FluentValidation;

namespace DietaDiaria.Domain.Entities
{
    public class User : Entity<long, User>
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string Image { get; private set; }

        protected User() { }

        public User(string username,
                    string password,
                    string name)
        {
            Username = username;
            Password = password;
            Name = name;
        }
        
        public override bool Validar()
        {
            RuleFor(_ => _.Username)
                .NotNull()
                .NotEmpty();

            RuleFor(_ => _.Password)
                .NotNull()
                .NotEmpty();

            RuleFor(_ => _.Name)
                .NotNull()
                .NotEmpty();

            ValidationResult = Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
