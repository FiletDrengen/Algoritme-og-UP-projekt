﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Virksomhed_og_UP
{
    public class Brikker
    {
        private Texture2D sprite;
        private Color color;
        private Vector2 position;
        private Rectangle destinationRectangle;

        public Brikker(int højde, int pos)
        {
            sprite = GameWorld.sprites["Block"];
            position = new Vector2(pos * 30, 1030);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 10, højde);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, destinationRectangle, Color.White);
            //spriteBatch.Draw(sprite, position, null, color, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 1);
        }
    }
}