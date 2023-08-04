//! add to top of Model pages to temp disable the warning*
#pragma warning disable CS8618

//!Add below to add validations
using System.ComponentModel.DataAnnotations;

namespace DojSurveyModelP.Models;

public class Survey
{
    [Required]
    [MinLength(2)]
    public string YourName {get; set;}

    [Required]
    public string DojoLocation {get; set;}
    
    [Required]
    public string FavoriteLanguage {get; set;}

    [MinLength(20)]
    public string? CommentOptional {get; set;}

}
