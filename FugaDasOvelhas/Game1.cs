using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FugaDasOvelhas
{
    public class Game1 : Game
    {

        public enum Animals
        {
            Dog,
            Cow,
            Horse,
            Pig,
            Cat,
            Sheep
        }

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Player player;
        private Sheep sheep;
        private Random random;
        private Texture2D background;
        private Dog dog;
        private Cow cow;
        private Horse horse;
        private Pig pig;
        private Cat cat;

        private IList<Animal> animalsFarm;

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
            dog = new Dog(this, new Vector2(10f, 360f));
            cow = new Cow(this, new Vector2(30f, 360f));
            horse = new Horse(this, new Vector2(70f, 360f));
            pig = new Pig(this, new Vector2(130f, 360f));
            cat = new Cat(this, new Vector2(230f, 360f));

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

            foreach (Animal animal in animalsFarm)
                animal.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void Spawn()
        {
            int i = random.Next(0, 5);
            Vector2 position = new Vector2(random.Next(0, 800), 340f);

            switch ((Animals)i)
            {
                case Animals.Dog:
                    Texture2D texture = new Texture2D();
                    texture.Name = "Dog";
                    animalsFarm.Add(new Animal(this, position, texture, "");
                    break;

                case Animals.Cow:
                    animalsFarm.Add(new Cow(this, positon));
                    break;
                    
                    case Animals.Horse:
                    animalsFarm.Add(new Horse(this, positon));
                    break;

                case Animals.Pig:
                    animalsFarm.Add(new Pig(this, positon));
                    break;

                case Animals.Cat:
                    animalsFarm.Add(new Cat(this, positon));
                    break;

                case Animals.Sheep:
                    animalsFarm.Add(new Sheep(this, positon));
                    break;
                    
                default:
                    break;
            }
        }
    }
}
