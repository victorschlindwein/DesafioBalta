﻿using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace DesafioBalta.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Senha {  get; set; }
    }
}