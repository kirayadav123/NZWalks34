﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;



        public RegionsController(IRegionRepository regionRepository, IMapper mapper )
        {

            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }
        [HttpGet]

        public async Task<IActionResult> GetAllRegions()
        {
           var regions = await regionRepository.GetAllAsync();

            //return DTO regions 
            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population,
            //    };

            //    regionsDTO.Add(regionDTO);

            //});
           var regionsDTO =  mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }

        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetRegionAsync")]
        public async Task<IActionResult> GetRegionAsync(Guid id)
        {
          var region = await regionRepository.GetAsync(id);
            if (region == null)
            {
                return NotFound();
            }
            var regionDTO = mapper.Map<Models.DTO.Region>(region);
            return Ok(regionDTO);
        }


        [HttpPost]
        public async Task<IActionResult> AddRegionAsync(Models.DTO.AddRegionReqest addRegionRequest)
        {
            //Request to domain model
           var region = new Models.Domain.Region()
            {
                Code = addRegionRequest.Code,
                    Area = addRegionRequest.Area,
                    Lat = addRegionRequest.Lat,
                    Long = addRegionRequest.Long,
                    Name = addRegionRequest.Name,
                Population = addRegionRequest.Population
            };

            // pass details to Repository
          region = await regionRepository.AddAsync(region);

            //Convrt back to DTO

            var regionDTO = new Models.DTO.Region
            {
                Code = addRegionRequest.Code,
                Area = addRegionRequest.Area,
                Lat = addRegionRequest.Lat,
                Long = addRegionRequest.Long,
                Name = addRegionRequest.Name,
                Population = addRegionRequest.Population

            };
            return CreatedAtAction(nameof(GetRegionAsync), new { id = regionDTO.Id }, regionDTO);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult>DeleteRegionAsync(Guid id)
        {
            //Get the region from the database
          var region = await regionRepository.DeleteAsync(id);



            //If null found
            if (region == null)
            {
                return NotFound();
            }

            //Convert response back to DTO
            var regionDTO = new Models.DTO.Region
            {
                Code = region.Code,
                Area = region.Area,
                Lat = region.Lat,
                Long = region.Long,
                Name = region.Name,
                Population = region.Population
            };

            //return Ok Response
            return Ok(regionDTO);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateRegionAsync([FromRoute]Guid id, [FromBody] Models.DTO.UpdateRegionRequest updateRegionRequest,Models.Domain.Region r3)
        {
            //Convert DTO To Domain model
            var region = new Models.DTO.Region()
            {
                Code = updateRegionRequest.Code,
                Area = updateRegionRequest.Area,
                Lat = updateRegionRequest.Lat,
                Long = updateRegionRequest.Long,
                Name = updateRegionRequest.Name,
                Population = updateRegionRequest.Population,
            };
            //Update Region using repository
            region = await regionRepository.UpdateAsync(id, r3);

            //if null then NotFound
            if(region == null)
            {
                return NotFound();
            }
            //Convert Domain back to DTO
            var regionDTO = new Models.DTO.Region()
            {
                Code = region.Code,
                Area = region.Area,
                Lat = region.Lat,
                Long = region.Long,
                Name = region.Name,
                Population = region.Population
            };

            //Return Ok response
            return Ok(regionDTO);
        }
       
    }
}
