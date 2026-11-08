using Microsoft.AspNetCore.Mvc;
using MeMe.API.Models;

namespace MeMe.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private static readonly List<Event> events = new()
        {
            new Event
            {
                Id = 1,
                Name = "Kávézás Hugival",
                StartDateTime = new DateTime(2026, 11, 7, 14, 0, 0),
                DurationMinutes = 60,
                Location = "Tatabánya",
                Priority = EventPriority.Medium,
                Note = "Közös délutáni program",
                IsCompleted = false
            },
            new Event
            {
                Id = 2,
                Name = "Edzés",
                StartDateTime = new DateTime(2026, 11, 7, 17, 0, 0),
                DurationMinutes = 90,
                Location = "Edzőterem",
                Priority = EventPriority.High,
                Note = "Lábnap",
                IsCompleted = false
            }
        };

        [HttpGet]
        public IActionResult GetEvents()
        {
            return Ok(events);
        }
    }
}