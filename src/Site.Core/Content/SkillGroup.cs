namespace Site.Core.Content;

public record SkillGroup(LocalizedText Name, IReadOnlyList<LocalizedText> Items);