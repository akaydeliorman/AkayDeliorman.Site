using System.Globalization;

namespace Site.Web.Localization;

public static class LocalizedRoutes
{
    // Türkçe adres -> İngilizce adres
    private static readonly Dictionary<string, string> TrToEn = new()
    {
        ["/"] = "/en",
        ["/hakkimda"] = "/en/about",
        ["/projeler"] = "/en/projects",
    };

    // Şu anki istek İngilizce mi? (7a'daki kapı görevlisinin taktığı rozete bakar)
    public static bool IsEnglish => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en";

    // Verilen adresin diğer dildeki karşılığını döndürür.
    public static string GetAlternatePath(string path)
    {
        // 1) Türkçe salonda mı? Tablonun SOL sütununda ara.
        if (TrToEn.TryGetValue(path, out var enPath))
        {
            return enPath;
        }

        // 2) İngilizce salonda mı? Tablonun SAĞ sütununda satır satır ara.
        foreach (var pair in TrToEn)
        {
            if (pair.Value == path)
            {
                return pair.Key;
            }
        }

        // 3) Tabloda yok (ör. olmayan sayfa): diğer salonun girişine yolla.
        return path.StartsWith("/en") ? "/" : "/en";
    }
}