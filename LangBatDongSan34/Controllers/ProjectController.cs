using Microsoft.AspNetCore.Mvc;

namespace LangBatDongSan34.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly LangBatDongSan43Context _context;

        public ProjectController(LangBatDongSan43Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetProjects()
        {
            return Ok(await _context.Projects.ToListAsync());
        }

        [HttpGet("WithStoreProcedure")]
        public async Task<ActionResult<List<Project>>> GetAllProjectsWithSP(
            string typeIds = "",
            decimal priceMin = 0,
            decimal priceMax = 0,
            int isPublished = 1,
            int status = 0,
            int investorId = 0,
            int provinceId = 0,
            int districtId = 0,
            int communeId = 0,
            int orderBy = 0,
            int pageIndex = 0,
            int pageSize = 15
        )
        {
            try
            {
                var result = await _context.Projects
                    .FromSqlRaw(
                        $"huongnd.GetAllProject {(typeIds == "" ? "null" : ("'" + typeIds + "'"))}, " +
                        $"{(priceMin == 0 ? "null" : priceMin)}, " +
                        $"{(priceMax == 0 ? "null" : priceMax)}, " +
                        $"{isPublished}, {status}, " +
                        $"{investorId}, {provinceId}, {districtId}, {communeId}, " +
                        $"{orderBy}, {pageIndex}, {pageSize}"
                    )
                    .ToListAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception($"Params error: {ex.Message}");
            }
        }
    }
}
