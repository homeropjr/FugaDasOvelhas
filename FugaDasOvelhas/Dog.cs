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
    public class Dog
    {
        public Texture2D texture { get; set; }

        private SoundEffect soundEffect;

        public Vector2 position { get; set; }
        
        public Dog(Game game, Vector2 position)
        {
            this.position = position;
            this.texture = game.Content.Load<Texture2D>("Dog");            
            this.soundEffect = game.Content.Load<SoundEffect>(@"Audio\zapsplat_animals_dog");
            this.soundEffect.Play();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
