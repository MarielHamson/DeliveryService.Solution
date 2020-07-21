namespace PackageDelivery.Models
{
  public class Parcel
  {
    public int Height { get; set; }
    public int Width { get; set; }
    public int Depth { get; set; }
    public int Weight { get; set; }

    public Parcel(int height, int width, int depth, int weight)
    {
      Height = height;
      Width = width;
      Depth = depth;
      Weight = weight;
    }
    // properties, methods, etc. will go here.

  }
}