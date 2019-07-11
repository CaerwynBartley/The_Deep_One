﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System;
using System.Linq;

namespace The_Deep_One
{
    public class DeepOne : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        int millisecondsPerFrame = 1000; //Update every 1 second
        int timeSinceLastUpdate = 0; //Accumulate the elapsed time

        public Texture2D rect;
        public Texture2D temp;
        public Texture2D logo;

        // Mouse
        public Rectangle MouseDest;
        public int MouseX, MouseY;
        public int debug = 0;


        Souls souls = new Souls();
        Buttons buttons;
        News news;

        // Upgrades
        public int upgrade1 = 0;
        public int upgrade2 = 0;
        public int upgrade3 = 0;
        public int upgrade4 = 0;
        public int upgrade5 = 0;
        public int upgrade6 = 0;
        public int upgrade7 = 0;
        public int upgrade8 = 0;

        // News
        //public int newstick = 0;
        //public Rectangle newspos;
        //public Texture2D news1;
        //public Texture2D news2;
        //public Texture2D news3;
        //public Texture2D news4;
        //public Texture2D news5;
        //public Texture2D news6;
        //public Texture2D news7;
        //public Texture2D news8;

        // Images
        public int imagetick = 0;
        public Texture2D image1;
        public Rectangle image1pos;
        public Texture2D image2;
        public Rectangle image2pos;
        public Texture2D image3;
        public Rectangle image3pos;
        public Texture2D image4;
        public Rectangle image4pos;
        public Texture2D image5;
        public Rectangle image5pos;
        public Texture2D image6;
        public Rectangle image6pos;
        public Texture2D image7;
        public Rectangle image7pos;
        public Texture2D image8;
        public Rectangle image8pos;

        public int endstate = 0;

        private SpriteFont font;
        private SpriteFont fontlarge;
        public Rectangle Screen;

        public DeepOne()
        {
            graphics = new GraphicsDeviceManager(this);
            
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1600; // Window Width
            graphics.PreferredBackBufferHeight = 900;// Window Height

            this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Screen.Width = GraphicsDevice.Viewport.Width;
            Screen.Height = GraphicsDevice.Viewport.Height;
            Screen.X = 0;
            Screen.Y = 0;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            buttons = new Buttons(this, graphics, spriteBatch, Content, souls);
            news = new News(this, graphics, spriteBatch, Content, souls, buttons);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            temp = Content.Load<Texture2D>("temp");
            logo = Content.Load<Texture2D>("logo");
            rect = Content.Load<Texture2D>("rect");

            buttons.LoadButtonContent();

            news.LoadNewsContent();
            //#region NEWS
            //news1 = Content.Load<Texture2D>("News1");
            //news2 = Content.Load<Texture2D>("News2");
            //news3 = Content.Load<Texture2D>("News3");
            //news4 = Content.Load<Texture2D>("News4");
            //news5 = Content.Load<Texture2D>("News5");
            //news6 = Content.Load<Texture2D>("News6");
            //news7 = Content.Load<Texture2D>("News7");
            //news8 = Content.Load<Texture2D>("News8");
            //newspos.X = 15;
            //newspos.Y = 55;
            //newspos.Width = 368;
            //newspos.Height = 551;
            //#endregion

            #region IMAGES LOAD
            image1 = Content.Load<Texture2D>("1");
            image1pos.X = 340;
            image1pos.Y = 130;
            image1pos.Width = 850;
            image1pos.Height = 601;
            image2 = Content.Load<Texture2D>("2");
            image2pos.X = 352;
            image2pos.Y = 140;
            image2pos.Width = 832;
            image2pos.Height = 514;
            image3 = Content.Load<Texture2D>("3");
            image3pos.X = 340;
            image3pos.Y = 140;
            image3pos.Width = 855;
            image3pos.Height = 486;
            image4 = Content.Load<Texture2D>("4");
            image4pos.X = 320;
            image4pos.Y = 140;
            image4pos.Width = 855;
            image4pos.Height = 486;
            image5 = Content.Load<Texture2D>("5");
            image5pos.X = 320;
            image5pos.Y = 140;
            image5pos.Width = 855;
            image5pos.Height = 486;
            image6 = Content.Load<Texture2D>("6");
            image6pos.X = 320;
            image6pos.Y = 140;
            image6pos.Width = 855;
            image6pos.Height = 486;
            image7 = Content.Load<Texture2D>("7");
            image7pos.X = 420;
            image7pos.Y = 10;
            image7pos.Width = 596;
            image7pos.Height = 850;
            image8 = Content.Load<Texture2D>("8");
            image8pos.X = 500;
            image8pos.Y = 70;
            image8pos.Width = 601;
            image8pos.Height = 768;
            #endregion

            font = Content.Load<SpriteFont>("font");
            fontlarge = Content.Load<SpriteFont>("fontlarge");
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            //Changes Time
            timeSinceLastUpdate += (int)gameTime.ElapsedGameTime.TotalMilliseconds;
            switch (timeSinceLastUpdate >= millisecondsPerFrame)
            {
                case true:
                    timeSinceLastUpdate = 0;
                    #region UPGRADES
                    switch (upgrade1 > 0)
                    {
                        case true:
                            souls.souls += (upgrade1 *2);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade2 > 0)
                    {
                        case true:
                            souls.souls += (upgrade2 * 10);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade3 > 0)
                    {
                        case true:
                            souls.souls += (upgrade3 * 50);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade4 > 0)
                    {
                        case true:
                            souls.souls += (upgrade4 * 100);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade5 > 0)
                    {
                        case true:
                            souls.souls += (upgrade5 * 1000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade6 > 0)
                    {
                        case true:
                            souls.souls += (upgrade6 * 10000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade7 > 0)
                    {
                        case true:
                            souls.souls += (upgrade7 * 100000);
                            break;
                        default:
                            break;
                    }

                    switch (upgrade8 > 0)
                    {
                        case true:
                            souls.souls += (upgrade8 * 1000000);
                            break;
                        default:
                            break;
                    }
                        #endregion
                    break;
                default:
                    break;
            }

            #region LOOPS
            switch (souls.souls < 0)
            {
                case true:
                    souls.souls = 0;
                    break;
                default:
                    break;
            }

            switch (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                case true:
                    Exit();
                    break;
                default:
                    break;
            }

            switch (souls.souls >= 10000000000)
            {
                case true:
                    buttons.completetick = 1;
                    break;
                default:
                    break;
            }

            switch (buttons.button10Pressedtick == 1)
            {
                case true:
                    endstate = 1;
                    break;
                default:
                    break;
            }
            #endregion

            //Mouse position state
            MouseY = Mouse.GetState().Y;
            MouseX = Mouse.GetState().X;

            // Mouse clicking
            MouseState newState = Mouse.GetState();

            switch (newState.LeftButton == ButtonState.Pressed)
            {
                case true:
                    MouseDest.X = MouseX;
                    MouseDest.Y = MouseY;
                    break;
                default:
                    break;
            }

            buttons.Update(gameTime);

            news.Update(gameTime);
            
            //#region NEWS
            //switch (souls.souls)
            //{
            //    case 1:
            //        newstick = 1;
            //        break;
            //    default:
            //        break;
            //}
            //switch (souls.souls >= 200 && newstick == 1)
            //{
            //    case true:
            //        newstick = 2;
            //        break;
            //    default:
            //        break;
            //}
            //switch (souls.souls >= 1000 && newstick == 2)
            //{
            //    case true:
            //        newstick = 3;
            //        break;
            //    default:
            //        break;
            //}
            //switch (souls.souls >= 10000 && newstick == 3)
            //{
            //    case true:
            //        newstick = 4;
            //        break;
            //    default:
            //        break;
            //}
            //switch (souls.souls >= 1000000 && newstick == 4)
            //{
            //    case true:
            //        newstick = 5;
            //        break;
            //    default:
            //        break;
            //}
            //switch (souls.souls >= 10000000 && newstick == 5)
            //{
            //    case true:
            //        newstick = 6;
            //        break;
            //    default:
            //        break;
            //}
            //switch (souls.souls >= 1000000000 && newstick == 6)
            //{
            //    case true:
            //        newstick = 7;
            //        break;
            //    default:
            //        break;
            //}
            //switch (souls.souls >= 10000000000 && newstick == 7)
            //{
            //    case true:
            //        newstick = 8;
            //        break;
            //    default:
            //        break;
            //}
            //#endregion

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            MouseState newState = Mouse.GetState();

            spriteBatch.Begin();

            //spriteBatch.Draw(temp, new Rectangle(0, 0, Screen.Width, Screen.Height), Color.White);
            spriteBatch.Draw(logo, new Rectangle(1100, 445, 655, 655), Color.White);


            //#region NEWS DRAWING
            //switch (newstick)
            //{
            //    case 1:
            //        spriteBatch.Draw(news1, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
            //        break;
            //    case 2:
            //        spriteBatch.Draw(news2, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
            //        break;
            //    case 3:
            //        spriteBatch.Draw(news3, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
            //        break;
            //    case 4:
            //        spriteBatch.Draw(news4, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
            //        break;
            //    case 5:
            //        spriteBatch.Draw(news5, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
            //        break;
            //    case 6:
            //        spriteBatch.Draw(news6, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
            //        break;
            //    case 7:
            //        spriteBatch.Draw(news7, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
            //        break;
            //    case 8:
            //        spriteBatch.Draw(news8, new Rectangle(newspos.X, newspos.Y, newspos.Width, newspos.Height), Color.White);
            //        break;
            //    default:
            //        break;
            //}
            //#endregion
            news.Draw(gameTime);

            #region IMAGES DRAWING
            switch (news.newstick)
            {
                case 1:
                    spriteBatch.Draw(image1, new Rectangle(image1pos.X, image1pos.Y, image1pos.Width, image1pos.Height), Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(image2, new Rectangle(image2pos.X, image2pos.Y, image2pos.Width, image2pos.Height), Color.White);
                    break;
                case 3:
                    spriteBatch.Draw(image3, new Rectangle(image3pos.X, image3pos.Y, image3pos.Width, image3pos.Height), Color.White);
                    break;
                case 4:
                    spriteBatch.Draw(image4, new Rectangle(image4pos.X, image4pos.Y, image4pos.Width, image4pos.Height), Color.White);
                    break;
                case 5:
                    spriteBatch.Draw(image5, new Rectangle(image5pos.X, image5pos.Y, image5pos.Width, image5pos.Height), Color.White);
                    break;
                case 6:
                    spriteBatch.Draw(image6, new Rectangle(image6pos.X, image6pos.Y, image6pos.Width, image6pos.Height), Color.White);
                    break;
                case 7:
                    spriteBatch.Draw(image7, new Rectangle(image7pos.X, image7pos.Y, image7pos.Width, image7pos.Height), Color.White);
                    break;
                case 8:
                    spriteBatch.Draw(image8, new Rectangle(image8pos.X, image8pos.Y, image8pos.Width, image8pos.Height), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            buttons.Draw(gameTime);

            spriteBatch.DrawString(fontlarge, "10 Billion is required to please The Deep One", new Vector2(15, 860), Color.White);

            #region END
            switch (souls.souls >= 10000000000)
            {
                case true:
                    spriteBatch.DrawString(fontlarge, "Souls: 10000000000", new Vector2(15, 15), Color.White);
                    spriteBatch.DrawString(fontlarge, "Continue?", new Vector2(buttons.button10pos.X + 70, buttons.button10pos.Y + 12), Color.White);
                    break;
                case false:
                    spriteBatch.DrawString(fontlarge, "Souls: " + souls.souls, new Vector2(15, 15), Color.White);
                    break;
                default:
                    break;
            }

            switch (endstate >= 1)
            {
                case true:
                    spriteBatch.Draw(rect, new Rectangle(0, 0, 1600, 900), Color.Black);
                    spriteBatch.DrawString(fontlarge, "The Deep One is pleased", new Vector2(665, 400), Color.White);
                    break;
                default:
                    break;
            }

            switch (endstate == 1)
            {
                case true:
                    spriteBatch.Draw(buttons.button11, new Rectangle(buttons.button11pos.X, buttons.button11pos.Y, buttons.button11pos.Width, buttons.button11pos.Height), Color.White);
                    spriteBatch.DrawString(fontlarge, "Reset", new Vector2(buttons.button11pos.X + 95, buttons.button11pos.Y + 12), Color.White);
                    break;
                default:
                    break;
            }
            #endregion

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
