namespace Site.Core.Content;

public record Project(
    string Slug,
    LocalizedText Title,
    LocalizedText Context,
    int Year,
    LocalizedText Summary,
    IReadOnlyList<string> Technologies,
    IReadOnlyList<LocalizedText> Highlights,
    bool IsFeatured,
    string? RepoUrl = null);