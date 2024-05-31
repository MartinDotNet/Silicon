using System.ComponentModel.DataAnnotations;

namespace WebApp.Filters;

public class Checkboxrequired : ValidationAttribute
{
    public override bool IsValid(object? value) => value is bool b && b;
  
}
