using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

using Core.Interface;
using Core.Entities;
using API.Dtos;
using API.Controllers;
using Infrastructure.UnitOfWork;

namespace API.Controllers;
public class RegionController : BaseApiController
{
    /*private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public RegionController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<RegionDto>>> Get()
    {
        var regiones = await unitOfWork.Regiones.GetAllAsync();
        return Ok(regiones);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult> Get(int id)
    {
        var region = await unitOfWork.Regiones.GetByIdAsync(id);
        return Ok(region);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<Region>> Post(RegionDto regionDto)
    {
        var region = this.mapper.Map<Pais>(regionDto);
        this.unitOfWork.Paises.Add(region);
        await unitOfWork.SaveAsync();
        if (region == null)
        {
            return BadRequest();
        }
        regionDto.Id = region.Id;
        return CreatedAtAction(nameof(Post), new { id = regionDto.Id }, regionDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RegionDto>> Put(int id, [FromBody]RegionDto regionDto)
    {
        if(regionDto == null)
            return NotFound();
        var region = this.mapper.Map<Pais>(regionDto);
        unitOfWork.Paises.Update(region);
        await unitOfWork.SaveAsync();
        return regionDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var regiones = await unitOfWork.Regiones.GetByIdAsync(id);
        if (regiones == null)
        {
            return NotFound();
        }
        unitOfWork.Regiones.Remove(regiones);
        await unitOfWork.SaveAsync();
        return NoContent();
        
    }
    */
}