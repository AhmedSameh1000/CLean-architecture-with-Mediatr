﻿namespace SchoolProject.Core.Feature.Authentication.DTOs
{
    public class ResetPasswordDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}