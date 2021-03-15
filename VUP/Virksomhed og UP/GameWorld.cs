using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Virksomhed_og_UP
{
    public class GameWorld : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public List<int> numbers = new List<int>() { 6, 4, 9, 5, 2, 225, 22, 45, 5, 34, 8, 7, 10, 40, 30, 25, 34, 54, 8, 5, 43, 22, };
        private List<Brikker> brikker = new List<Brikker>();
        public static Dictionary<string, Texture2D> sprites = new Dictionary<string, Texture2D>();
        private Texture2D Baggrund;

        public GameWorld()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            sprites.Add("Block", Content.Load<Texture2D>("Block"));
            for (int i = 1; i < numbers.Count; i++)
            {
                brikker.Add(new Brikker(numbers[i], i));
            }
            Baggrund = Content.Load<Texture2D>("Baggrund");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.F1))
                numbers = QuickSort.Quick(numbers);

            if (Keyboard.GetState().IsKeyDown(Keys.F2))
                numbers = InsertionSort.Insertionsort(numbers);

            if (Keyboard.GetState().IsKeyDown(Keys.F3))
                numbers = Bubblesort.bubblesort(numbers);

            if (Keyboard.GetState().IsKeyDown(Keys.F1) || Keyboard.GetState().IsKeyDown(Keys.F2) || Keyboard.GetState().IsKeyDown(Keys.F3))
            {
                brikker.Clear();
                for (int i = 1; i < numbers.Count; i++)
                    brikker.Add(new Brikker(numbers[i], i));
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            foreach (var item in brikker)
            {
                _spriteBatch.Begin();
                item.Draw(_spriteBatch);
                _spriteBatch.End();
            }
            _spriteBatch.Begin();
            _spriteBatch.Draw(Baggrund, new Vector2(0, 0), Color.White);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}