﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace The_Deep_One
{
    public class News
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ContentManager Content;

        Souls souls;
        DeepOne deepone;
        Buttons buttons;

        public int newstick = 0;
        public Rectangle newspos;
        public Texture2D news1;
        public Texture2D news2;
        public Texture2D news3;
        public Texture2D news4;
        public Texture2D news5;
        public Texture2D news6;
        public Texture2D news7;
        public Texture2D news8;

        private int newssound1 = 0;
        private int newssound2 = 0;
        private int newssound3 = 0;
        private int newssound4 = 0;
        private int newssound5 = 0;
        private int newssound6 = 0;
        private int newssound7 = 0;
        private int newssound8 = 0;

        private SpriteFont font;
        private SpriteFont fontlarge;
        public Rectangle Screen;

        public News()
        {
            Content.RootDirectory = "Content";
        }
        public News(DeepOne p_deepone, GraphicsDeviceManager p_graphics, SpriteBatch p_spriteBatch, ContentManager content, Souls p_souls, Buttons p_buttons)
        {
            Content = content;
            deepone = p_deepone;
            graphics = p_graphics;
            spriteBatch = p_spriteBatch;
            souls = p_souls;
            buttons = p_buttons;
        }

        public void LoadNewsContent()
        {
            news1 = Content.Load<Texture2D>("News1");
            news2 = Content.Load<Texture2D>("News2");
            news3 = Content.Load<Texture2D>("News3");
            news4 = Content.Load<Texture2D>("News4");
            news5 = Content.Load<Texture2D>("News5");
            news6 = Content.Load<Texture2D>("News6");
            news7 = Content.Load<Texture2D>("News7");
            news8 = Content.Load<Texture2D>("News8");
            newspos.X = 15;
            newspos.Y = 55;
            newspos.Width = 368;
            newspos.Height = 551;

            font = Content.Load<SpriteFont>("font");
            fontlarge = Content.Load<SpriteFont>("fontlarge");
        }

        public void Update(GameTime gameTime)
        {
            MouseState newState = Mouse.GetState();

            #region NEWS
            switch (souls.souls)
            {
                case 1:
                    newstick = 1;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 200 && newstick == 1)
            {
                case true:
                    newstick = 2;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 1000 && newstick == 2)
            {
                case true:
                    newstick = 3;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 10000 && newstick == 3)
            {
                case true:
                    newstick = 4;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 1000000 && newstick == 4)
            {
                case true:
                    newstick = 5;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 10000000 && newstick == 5)
            {
                case true:
                    newstick = 6;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 1000000000 && newstick == 6)
            {
                case true:
                    newstick = 7;
                    break;
                default:
                    break;
            }
            switch (souls.souls >= 10000000000 && newstick == 7)
            {
                case true:
                    newstick = 8;
                    break;
                default:
                    break;
            }
            #endregion


        }

        public void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();

            switch (newstick)
            {
                case 1:
                    spriteBatch.Draw(news1, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    switch (deepone.neWsInst.State == SoundState.Stopped && newssound1 == 0)
                    {
                        case true:
                            deepone.neWsInst.Play();
                            newssound1 = 1;
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    spriteBatch.Draw(news2, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    switch (deepone.neWsInst.State == SoundState.Stopped && newssound2 == 0)
                    {
                        case true:
                            deepone.neWsInst.Play();
                            newssound2 = 1;
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    spriteBatch.Draw(news3, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    switch (deepone.neWsInst.State == SoundState.Stopped && newssound3 == 0)
                    {
                        case true:
                            deepone.neWsInst.Play();
                            newssound3 = 1;
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    spriteBatch.Draw(news4, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    switch (deepone.neWsInst.State == SoundState.Stopped && newssound4 == 0)
                    {
                        case true:
                            deepone.neWsInst.Play();
                            newssound4 = 1;
                            break;
                        default:
                            break;
                    }
                    break;
                case 5:
                    spriteBatch.Draw(news5, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    switch (deepone.neWsInst.State == SoundState.Stopped && newssound5 == 0)
                    {
                        case true:
                            deepone.neWsInst.Play();
                            newssound5 = 1;
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    spriteBatch.Draw(news6, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    switch (deepone.neWsInst.State == SoundState.Stopped && newssound6 == 0)
                    {
                        case true:
                            deepone.neWsInst.Play();
                            newssound6 = 1;
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    spriteBatch.Draw(news7, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    switch (deepone.neWsInst.State == SoundState.Stopped && newssound7 == 0)
                    {
                        case true:
                            deepone.neWsInst.Play();
                            newssound7 = 1;
                            break;
                        default:
                            break;
                    }
                    break;
                case 8:
                    spriteBatch.Draw(news8, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
                    switch (deepone.neWsInst.State == SoundState.Stopped && newssound8 == 0)
                    {
                        case true:
                            deepone.neWsInst.Play();
                            newssound8 = 1;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
