using CourseLibrary.API.Models;
using CourseLibrary.API.Services;
using CourseLibrary.API.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using CourseLibrary.API.ResourceParameters;

namespace CourseLibrary.API.Controllers
{
    [ApiController]
    [Route("api/authors")]
    // [Route("api/[controller]")] // not the best approach 

    public class AuthorsController: ControllerBase //ControllerBase for APIs
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;
        private readonly IMapper _mapper;

        public AuthorsController(ICourseLibraryRepository courseLibraryRepository,
            IMapper mapper)
        {
            _courseLibraryRepository = courseLibraryRepository ?? 
                throw new ArgumentNullException(nameof(courseLibraryRepository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }
        /*        [HttpGet()]
                public IActionResult GetAuthors()
                {
                    var authorsFromRepo = _courseLibraryRepository.GetAuthors();
                    //return new JsonResult(authorsFromRepo); //jsonresult always return json
                    return Ok(authorsFromRepo);
                }
        */
        /*        [HttpGet()]
                public IActionResult GetAuthors()
                {
                    var authorsFromRepo = _courseLibraryRepository.GetAuthors();
                    var authors = new List<AuthorDto>();

                    foreach (var author in authorsFromRepo)
                    {
                        authors.Add(new AuthorDto()
                        {
                            Id = author.Id,
                            Name = $"{author.FirstName} {author.LastName}",
                            MainCategory = author.MainCategory,
                            Age = author.DateOfBirth.GetCurrentAge()
                        }); ;
                    }
                    return Ok(authors);
                }
        */
        [HttpGet()]
        [HttpHead] // folosim pentru a nu returna un body 
        public ActionResult<IEnumerable<AuthorDto>> GetAuthors( 
            [FromQuery] AuthorsResourceParameters  authorsResourceParameters) // aici e nevoie de atributul fromquery
           // /* [FromQuery(Name = "")]*/ string mainCategory, string searchQuery)
        {
            //throw new Exception("Test exception");
            var authorsFromRepo = _courseLibraryRepository.GetAuthors(authorsResourceParameters);
            var authors = new List<AuthorDto>();

            return Ok(_mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo));
        }

        [HttpGet("/{authorId}", Name = "GetAuthor")]
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

            return Ok(_mapper.Map<AuthorDto>(authorsFromRepo));
            //return new JsonResult(authorsFromRepo);
        }

        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(AuthorForCreationDto author)
        { 
            if(author == null)
            {
                return BadRequest();
            }
            var authorEntity = _mapper.Map<Entities.Author>(author);
            _courseLibraryRepository.AddAuthor(authorEntity);
            _courseLibraryRepository.Save();

            var authorToReturn = _mapper.Map<AuthorDto>(authorEntity);
            return CreatedAtRoute("GetAuthor",
                new { authorID = authorToReturn.Id },
                authorToReturn);
        }
    }
}
