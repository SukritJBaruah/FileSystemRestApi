using FileSystemRest.Contracts.FileSystemInfo;
using FileSystemRest.Models;
using Microsoft.AspNetCore.Mvc;

namespace FileSystemRest.Controllers;

[ApiController, Route("fsi")]
public class FSIController : ControllerBase{
    
    [HttpPost()]
    public IActionResult CreateFSI(CreateFSIRequest request){
        var fsi = new Fsi(
            request.Name,
            request.Id,
            request.MimeType,
            request.DataB64,
            request.CreatedDateUnixTime,
            DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
            request.ParentId
        );
        //TODO: add to db

        var response = new FSIResponse(
            fsi.Name,
            fsi.Id,
            fsi.MimeType,
            fsi.DataB64,
            fsi.CreatedDateUnixTime,
            fsi.UpdatedDateUnixTime,
            fsi.ParentId
        );

        return CreatedAtAction(
            nameof(GetFSI),
            new{id = request.Id},
            response);
    }

    [HttpGet("{id}")]
    public IActionResult GetFSI(string id){
        return Ok(id);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateFSI(string id, UpdateFSIRequest request){
        return Ok(request);
    }

    [HttpDelete("id}")]
    public IActionResult DeleteFSI(string id){
        return Ok(id);
    }

}