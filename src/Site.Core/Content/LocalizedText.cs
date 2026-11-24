namespace Site.Core.Content;

public record LocalizedText(string Tr, string En)
{
    public string Get(string language) => language == "en" ? En : Tr;

    public static LocalizedText Same(string text) => new(text, text);
}