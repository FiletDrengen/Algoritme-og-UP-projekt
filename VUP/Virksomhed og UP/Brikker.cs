using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Color = Microsoft.Xna.Framework.Color;

namespace Virksomhed_og_UP
{
    public class Brikker
    {
        private Texture2D sprite;
        private Color color = Color.White;
        private Vector2 position;

        public Brikker(int højde, int pos)
        {
            sprite = GameWorld.sprites["Block"];
            position = new Vector2(pos * 10, 10);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, color, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 1);
        }
    }
}