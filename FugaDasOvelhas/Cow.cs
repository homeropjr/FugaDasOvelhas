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
    public class Cow
    {
        private SoundEffect soundEffect;

        public Texture2D texture { get; set; }

        public Vector2 position { get; set; }
        
        public Cow(Game game, Vector2 position)
        {
            this.position = position;
            this.texture = game.Content.Load<Texture2D>("cow");            
            this.soundEffect = game.Content.Load<SoundEffect>(@"Audio\scottish_highland_moo");
            this.soundEffect.Play();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
