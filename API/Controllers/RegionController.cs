using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers;

public class RegionController : BaseApiController
{
    private readonly IUnitofWork unitofWork;
    public RegionController(IUnitofWork unitofWork)
    {
        this.unitofWork = unitofWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Region>>> GetRegions()
    {
        var regions = await unitofWork.Regiones.GetByIdAsync();
        return Ok(regions);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Region>> Post(Region region)
    {
        this.unitofWork.Regiones.Add(region);
        await this.unitofWork.SaveAsync();
        if (region == null)
        {
            return BadRequest();
        }
        return CreatedAtActionResult(nameof(Post), new {id = region.IdCod}, region);
    }
}
