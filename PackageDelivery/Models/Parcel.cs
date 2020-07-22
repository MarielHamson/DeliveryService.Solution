namespace PackageDelivery.Models
{
  public class Parcel
  {
    public int Height { get; set; } = 0;
    public int Width { get; set; } = 0;
    public int Length { get; set; } = 0;
    public int Weight { get; set; } = 0;

    public Parcel(int height, int width, int length, int weight)
    {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
    }
    // properties, methods, etc. will go here.
    public int findVolume()
    {
      return Length * Width * Height;
    }

    public int findPrice(int volume)
    {
      return volume * Weight;
    }
  }
}