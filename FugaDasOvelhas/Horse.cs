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
    public class Horse
    {

        private SoundEffect soundEffect;

        public Texture2D texture { get; set; }

        public Vector2 position { get; set; }
        
        public Horse(Game game, Vector2 position)
        {
            this.position = position;
            this.texture = game.Content.Load<Texture2D>("horse");            
            this.soundEffect = game.Content.Load<SoundEffect>(@"Audio\horse-whinny");
            this.soundEffect.Play();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
