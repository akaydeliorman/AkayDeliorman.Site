namespace Site.Core.Content;

public record Education(
    LocalizedText Degree,
    LocalizedText School,
    int StartYear,
    int EndYear,
    string? Gpa = null);