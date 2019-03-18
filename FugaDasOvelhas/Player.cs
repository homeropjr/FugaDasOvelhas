using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace FugaDasOvelhas
{
    public class Player
    {
        private float speed = 2f;
        private Song song;

        public Texture2D texture { get; set; }

        public Vector2 position { get; set; }

        public Player(Game game, Vector2 position)
        {
            this.texture = game.Content.Load<Texture2D>("player");
            this.song = game.Content.Load<Song>(@"Audio\zapsplat_cartoon_ufo_hover");            
            this.position = position;

            PlaySound();
        }

        public void Update(GameTime gameTime)
        {

        }

        public void PlaySound()
        {
            MediaPlayer.Play(song);
            MediaPlayer.IsRepeating = true;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public void MoveParaEsquerda()
        {
            position -= new Vector2(speed, 0);
        }

        public void MoveParaDireita()
        {
            position += new Vector2(speed, 0);
        }
    }
}
