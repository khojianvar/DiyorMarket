﻿namespace DiyorMarket.Domain.DTOs.Customer
{
    public record CustomerForCreateDto(
        string FirstName,
        string LastName,
        string PhoneNumber);
}
