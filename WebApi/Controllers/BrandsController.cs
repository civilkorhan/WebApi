using Business.Abstract;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAcces.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
       private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public IActionResult Add(CreatBrandRequest creatBrandRequest)
        {
            CreatedBrandsResponse createdBrandsResponse=_brandService.Add(creatBrandRequest);
            return Ok(createdBrandsResponse);
        }
        
        [HttpGet]
        public IActionResult Get()
        {
           return Ok( _brandService.GetAll());
        }
    }
}
