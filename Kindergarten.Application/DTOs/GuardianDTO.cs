﻿namespace Kindergarten.Application.DTOs;
public class GuardianDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<ChildDTO> Children { get; set; }
}