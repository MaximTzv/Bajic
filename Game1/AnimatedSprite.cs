
using System.Security.AccessControl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game1
{
    class AnimatedSprite
    {
        private int currentFrame;
        private int totalFrames;

        public AnimatedSprite(Texture2D texture, int rows, int cols)
        {
            this.Texture = texture;
            this.Rows = rows;
            this.Cols = cols;
            this.currentFrame = 0;
            this.totalFrames = this.Rows*this.Cols;
        }

        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }

        public void Update()
        {
            this.currentFrame++;
            if (this.currentFrame == this.totalFrames)
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = Texture.Width/this.Cols;
            int height = Texture.Height/this.Rows;

            int row = this.currentFrame/this.Cols;
            int column = this.currentFrame%this.Cols;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
