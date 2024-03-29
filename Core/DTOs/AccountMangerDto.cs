﻿namespace Core.DTOs
{
    public class AccountMangerDto
    {
        public string? Message { get; set; }
        public bool IsAuthenticated { get; set; } = false;
        public string? Username { get; set; }
        public string? Email { get; set; }
        public List<string>? Roles { get; set; }
        public string? Token { get; set; }
        public DateTime? ExpiresOn { get; set; }

        public bool Success { get; set; } = false;
    }
}
