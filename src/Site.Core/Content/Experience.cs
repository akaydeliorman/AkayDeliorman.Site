namespace Site.Core.Content;

public record Experience(
    LocalizedText Role,
    LocalizedText Company,
    DateOnly Start,
    DateOnly? End,
    IReadOnlyList<ExperienceItem> Items);

public record ExperienceItem(
    LocalizedText? Title,
    IReadOnlyList<string> Technologies,
    IReadOnlyList<LocalizedText> Highlights);