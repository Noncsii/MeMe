namespace MeMe.API.Models
{
    public enum EventPriority
    {
        Low = 1,
        Medium = 2,
        High = 3,
        Critical = 4
    }

    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime StartDateTime { get; set; }

        public int DurationMinutes { get; set; }

        public string? Location { get; set; }

        public EventPriority Priority { get; set; }

        public string? Note { get; set; }

        public bool IsCompleted { get; set; }
    }
}