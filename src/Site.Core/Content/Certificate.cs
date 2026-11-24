namespace Site.Core.Content;

public record Certificate(
    LocalizedText Name,
    LocalizedText Issuer,
    int Year,
    bool InProgress = false,
    LocalizedText? Details = null);


