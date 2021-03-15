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
        private bool isSort = false;

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

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.NumPad1))
            {
                numbers = QuickSort.Quick(numbers);
                brikker.Clear();
                for (int i = 1; i < numbers.Count; i++)
                {
                    brikker.Add(new Brikker(numbers[i], i));
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.NumPad2))
            {
                numbers = InsertionSort.Insertionsort(numbers);
                brikker.Clear();
                for (int i = 1; i < numbers.Count; i++)
                {
                    brikker.Add(new Brikker(numbers[i], i));
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.NumPad3))
            {
                numbers = Bubblesort.bubblesort(numbers);
                brikker.Clear();
                for (int i = 1; i < numbers.Count; i++)
                {
                    brikker.Add(new Brikker(numbers[i], i));
                }
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

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}