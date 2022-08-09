using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CourseLibrary.API.Controllers
{
    [ApiController]
    [Route("api/authors")]
    // [Route("api/[controller]")] // not the best approach 

    public class AuthorsController: ControllerBase //ControllerBase for APIs
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;
        public AuthorsController(ICourseLibraryRepository courseLibraryRepository)
        {
            _courseLibraryRepository = courseLibraryRepository ?? 
                throw new ArgumentNullException(nameof(courseLibraryRepository));
        }
        [HttpGet()]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthors();
            //return new JsonResult(authorsFromRepo); //jsonresult always return json
            return Ok(authorsFromRepo);
        }

        [HttpGet("{authorId:guid}")]
        public IActionResult GetAuthor(Guid authorId)
        {
            var authorsFromRepo = _courseLibraryRepository.GetAuthor(authorId);

/*            if (! _courseLibraryRepository.AuthorExists(authorId))
            {
                return NotFound();
            }
*/
            if (authorsFromRepo == null)
            {
                return NotFound();
            }

            return Ok(authorsFromRepo);
            //return new JsonResult(authorsFromRepo);
        }
    }
}
