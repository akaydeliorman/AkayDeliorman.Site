using Site.Core.Content;

namespace Site.Web.Localization;

public static class LocalizedTextExtensions
{
    public static string Text(this LocalizedText text) =>
        text.Get(LocalizedRoutes.IsEnglish ? "en" : "tr");
}