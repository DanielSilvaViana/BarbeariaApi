using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Barbearia.API.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public string? Telefone { get; set; }
        [EmailAddress(ErrorMessage = "Favor digitar um email válido.")]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "Data De Nascimento")]
        public DateTime DataNascimento { get; set; }

    }
}