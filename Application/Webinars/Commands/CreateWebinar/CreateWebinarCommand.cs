namespace Application.Webinars.Commands.CreateWebinar;

public sealed record CreateWebinarCommand(string Name, DateTime ScheduledOn);