using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace FugaDasOvelhas
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Player player;
        private Random random;
        private Texture2D background;

        private IList<Animal> animalsFarm;

        private float elapsedTime = 3f;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            Window.Title = "Fuga das Ovelhas - V1.0.";
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            random = new Random();
            animalsFarm = new List<Animal>();
            background = Content.Load<Texture2D>("background");
            player = new Player(this, new Vector2(340f, 70f));
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState key = Keyboard.GetState();
            if (key.IsKeyDown(Keys.Left))
                player.MoveParaEsquerda();
            else if (key.IsKeyDown(Keys.Right))
                player.MoveParaDireita();

            Spawn();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(background, new Vector2(0, 0), Color.White);

            player.Draw(spriteBatch);

            foreach (Animal animal in animalsFarm)
                animal.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void Spawn()
        {
            int i = random.Next(0, 5);
            Vector2 position = new Vector2(random.Next(0, 800), 360f);

            switch (i)
            {
                case 1:
                    animalsFarm.Add(new Animal(this, position, "cat"));
                    break;

                case 2:
                    animalsFarm.Add(new Animal(this, position, "dog"));
                    break;

                case 3:
                    animalsFarm.Add(new Animal(this, position, "cow"));
                    break;

                case 4:
                    animalsFarm.Add(new Animal(this, position, "horse"));
                    break;

                case 5:
                    animalsFarm.Add(new Animal(this, position, "pig"));
                    break;

                case 6:
                    animalsFarm.Add(new Animal(this, position, "sheep"));
                    break;
                default:
                    break;
            }

        }
    }
}
