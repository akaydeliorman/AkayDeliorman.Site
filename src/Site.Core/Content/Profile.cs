namespace Site.Core.Content;

public record Profile(
    string FullName,
    LocalizedText Headline,
    LocalizedText Summary,
    LocalizedText Location,
    LocalizedText Citizenship,
    IReadOnlyList<LocalizedText> Languages,
    string? PhotoUrl = null);
