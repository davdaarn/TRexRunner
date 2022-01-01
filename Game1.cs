using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using TrexRunner.Graphics;

namespace TrexRunner
{
  public class Game1 : Game
  {
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private const string ASSET_SPRITESHEET = "TrexSpritesheet";
    private const string ASSET_HIT = "hit";
    private const string ASSET_BUTTON = "button-press";
    private const string ASSET_SCORE = "score-reached";

    private SoundEffect _sfxHit;
    private SoundEffect _sfxButtonPress;
    private SoundEffect _sfxScoreReached;

    private Texture2D _spriteSheetTexture;

    public Game1()
    {
      _graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";
      IsMouseVisible = true;
    }

    protected override void Initialize()
    {
      // TODO: Add your initialization logic here

      base.Initialize();
    }

    protected override void LoadContent()
    {
      _spriteBatch = new SpriteBatch(GraphicsDevice);

      _sfxHit = Content.Load<SoundEffect>(ASSET_HIT);
      _sfxButtonPress = Content.Load<SoundEffect>(ASSET_BUTTON);
      _sfxScoreReached = Content.Load<SoundEffect>(ASSET_SCORE);

      _spriteSheetTexture = Content.Load<Texture2D>(ASSET_SPRITESHEET);
    }

    protected override void Update(GameTime gameTime)
    {
      if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        Exit();

      // TODO: Add your update logic here

      base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
      GraphicsDevice.Clear(Color.White);

      Sprite sprite = new Sprite(_spriteSheetTexture, 848, 0, 44, 52);

      _spriteBatch.Begin();

      sprite.Draw(_spriteBatch, new Vector2(10, 10));

      _spriteBatch.End();

      base.Draw(gameTime);
    }
  }
}
