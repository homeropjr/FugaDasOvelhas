using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FugaDasOvelhas
{
    public class Animal
    {
        public Texture2D texture { get; set; }

        public Vector2 position { get; set; }

        public Animal(Game game, Vector2 position,  string textureName)
        {
            this.position = position;
            this.texture = game.Content.Load<Texture2D>(textureName);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
