
using System;
using System.Collections.Generic;
using SharedKernel;

public class Owner
{
  public Owner(string firstname, string lastname)
  {
    Name=PersonFullName.Create(firstname,lastname);
    Id=Guid.NewGuid();
  }
  public Guid Id { get; set; }
  public PersonFullName Name { get; set; }
  public int CurrentTeamId{get;set;}
  public List<int> PastTeams{get;set;}
}