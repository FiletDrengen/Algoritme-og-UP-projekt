using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Threading;

namespace Virksomhed_og_UP
{
    public class GameWorld : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public List<int> numbers = new List<int>() { 6, 4, 9, 5, 40, 435, 3, 213, 54, 600, 400, 59, 90, 146, 246, 342, 3, 123, };
        private List<Brikker> brikker = new List<Brikker>();
        public static Dictionary<string, Texture2D> sprites = new Dictionary<string, Texture2D>();
        private Texture2D Baggrund;
        private Texture2D Dania;

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
            Dania = Content.Load<Texture2D>("erhvervsakademi-dania");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.F1))
            {
                numbers = QuickSort.Quick(numbers);
            }

            if (Keyboard.GetState().IsKeyDown(Keys.F2))
            {
                Thread thread2 = new Thread(() => InsertionSort.Insertion(numbers));
                thread2.Start();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.F3))
            {
                Thread thread3 = new Thread(() => Bubblesort.Bubble(numbers));
                thread3.Start();
            }

            brikker.Clear();
            for (int i = 1; i < numbers.Count; i++)
                brikker.Add(new Brikker(numbers[i], i));

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
            _spriteBatch.Draw(Dania, new Vector2(1700, 10), Color.White);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}