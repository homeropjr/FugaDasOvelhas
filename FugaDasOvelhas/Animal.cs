using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FugaDasOvelhas
{
    public class Animal
    {

        public Texture2D texture { get; set; }

        public Vector2 position { get; set; }

        private SoundEffect soundEffect;

        public Animal(Game game, Vector2 position, Texture2D texture, string content)
        {
            this.position = position;
            this.texture = game.Content.Load<Texture2D>(texture.Name);
            this.soundEffect = game.Content.Load<SoundEffect>(content);            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
