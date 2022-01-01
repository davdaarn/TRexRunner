using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TrexRunner.Graphics
{
  public class Sprite
  {
    public Texture2D Texture { get; private set; }

    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Color Color { get; set; } = Color.White;

    public Sprite(Texture2D texture, int x, int y, int width, int height)
    {
      this.Texture = texture;
      this.X = x;
      this.Y = y;
      this.Width = width;
      this.Height = height;
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 position)
    {
      spriteBatch.Draw(Texture, position, new Rectangle(X, Y, Width, Height), Color);
    }
  }
}