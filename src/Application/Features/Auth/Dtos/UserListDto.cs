﻿using Domain.Entities;

namespace Application.Features.Auth.Dtos;

public class UserListDto
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string FeelText { get; set; }
    public virtual List<OperationClaim> OperationClaims { get; set; }
}