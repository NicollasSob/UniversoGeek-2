﻿namespace UniversoGeek.API.Models
{
    public class ResetPasswordRequest
    {
        public string Email { get; set; }
        public string SenhaAtual { get; set; }
        public string NovaSenha { get; set; }
    }
}
