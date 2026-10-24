using System.Text.Json.Serialization;

class ScriptureEntry
{
    [JsonPropertyName("chapter")]
    public string Book { get; set; } = "";

    [JsonPropertyName("chapterNumber")]
    public int Chapter { get; set; }

    [JsonPropertyName("verseNumber")]
    public int Verse { get; set; }

    [JsonPropertyName("quote")]
    public string Quote { get; set; } = "";
}