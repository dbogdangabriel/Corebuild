using CourseLibrary.API.Models;
using CourseLibrary.API.Services;
using CourseLibrary.API.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using CourseLibrary.API.ResourceParameters;
using System.Linq;

namespace CourseLibrary.API.Controllers
{

    [ApiController]
    [Route("api/authorcollections")]
    // [Route("api/[controller]")] // not the best approach 

    public class AuthorCollectionsController : ControllerBase //ControllerBase for APIs
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;
        private readonly IMapper _mapper;

        public AuthorCollectionsController(ICourseLibraryRepository courseLibraryRepository,
            IMapper mapper)
        {
            _courseLibraryRepository = courseLibraryRepository ??
                throw new ArgumentNullException(nameof(courseLibraryRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }


        [HttpGet("({ids})", Name ="GetAuthorCollection")]
        public IActionResult GetAuthorCollection(
            [FromRoute] 
            [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                return BadRequest();
            }

            var authorEntities = _courseLibraryRepository.GetAuthors(ids);
            
            if(ids.Count() != authorEntities.Count())
            {
                return NotFound();
            }
            var authorToReturn = _mapper.Map<IEnumerable<AuthorDto>>(authorEntities);

            return Ok(authorToReturn);
        }

        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthorCollection(
            IEnumerable<AuthorForCreationDto> authorCollection)
        {
            if (authorCollection == null)
            {
                return BadRequest();
            }
            var authorEntities = _mapper.Map<IEnumerable<Entities.Author>>(authorCollection);

            foreach (var author in authorEntities)
            {
                _courseLibraryRepository.AddAuthor(author);
            }
            _courseLibraryRepository.Save();
            var authorCollectionToReturn = _mapper.Map<IEnumerable<AuthorDto>>(authorEntities);
            var idsAsString = string.Join(",", authorCollectionToReturn.Select(a => a.Id));
            return CreatedAtRoute("GetAuthorCollection",
                new { ids = idsAsString },
                authorCollectionToReturn);

        }
    }
}
