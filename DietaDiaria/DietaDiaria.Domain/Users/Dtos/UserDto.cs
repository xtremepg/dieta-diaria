using DietaDiaria.Domain.Users.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DietaDiaria.Domain.Users.Dtos
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public static UserDto Cast(User model)
        {
            return new UserDto
            {
                Username = model.Username,
                Password = model.Password,
                Name = model.Name,
                Image = model.Image
            };
        }
    }
}
