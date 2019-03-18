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
    public class Pig
    {
        public Texture2D texture { get; set; }

        public Vector2 position { get; set; }

        private SoundEffect soundEffect;

        public Pig(Game game, Vector2 position)
        {
            this.texture = game.Content.Load<Texture2D>("pig");
            this.position = position;
            this.soundEffect = game.Content.Load<SoundEffect>(@"Audio\animals_pigs_grunt");
            this.soundEffect.Play();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
