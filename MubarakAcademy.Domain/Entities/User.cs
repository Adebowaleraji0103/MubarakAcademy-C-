using MubarakAcademy.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MubarakAcademy.Domain.Entities
{
   public class User:BaseEntity
    {
        [Key]
        public Guid UserId { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
    }
}
