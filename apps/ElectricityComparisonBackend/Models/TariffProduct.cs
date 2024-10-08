using System.Text.Json.Serialization;

namespace ElectricityComparisonBackend.Models;

public class TariffProduct
{
  [JsonPropertyName("name")]
  public string Name { get; set; } = string.Empty;

  [JsonPropertyName("type")]
  public int Type { get; set; }

  [JsonPropertyName("includedKwh")]
  public long? IncludedKwh { get; set; }

  [JsonPropertyName("baseCost")]
  public decimal BaseCost { get; set; }

  [JsonPropertyName("additionalKwhCost")]
  public decimal AdditionalKwhCost { get; set; }
}
