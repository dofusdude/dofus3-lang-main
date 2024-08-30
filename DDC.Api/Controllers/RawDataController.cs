using Microsoft.AspNetCore.Mvc;

namespace DDC.Api.Controllers;

[Route("{version}/raw")]
[ApiController]
public class RawDataController : ControllerBase
{
    public Task<FileStreamResult> GetMapPositions(string version) => throw new NotImplementedException();
    public Task<FileStreamResult> GetPointsOfInterest(string version) => throw new NotImplementedException();
}
