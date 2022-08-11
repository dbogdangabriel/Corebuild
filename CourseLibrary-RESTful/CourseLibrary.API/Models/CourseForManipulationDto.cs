using CourseLibrary.API.ValidationAttributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(
            ErrorMessage = "Title must be different from description")]
    public abstract class CourseForManipulationDto
    {

            [Required(ErrorMessage = "You should fill out a title.")]
            [MaxLength(100, ErrorMessage = "The title shouldn't have more than 100 characters. ")]
            public string Title { get; set; }
            [MaxLength(500, ErrorMessage = "The description shouldn't have more than 500 characters. ")]
            public virtual string Description { get; set; } // virtual property are used when we have an implementation in the base class

    }

}
