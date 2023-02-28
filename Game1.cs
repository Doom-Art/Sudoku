using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Sudoku
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectTex;
        SpriteFont numFont;
        int[,] board;
        Random rand;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 633;
            _graphics.PreferredBackBufferHeight = 633;
            _graphics.ApplyChanges();
            rand = new Random();
            board = new int[9, 9];
            List<int> row1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> row2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> row3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> row4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> row5 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> row6 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> row7 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> row8 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> row9 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group5 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group6 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group7 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group8 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> group9 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int tempInt;
            bool findNum;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    findNum = false;
                    tempInt = rand.Next(10);
                    if (j == 0){
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row1.Contains(tempInt) && group1.Contains(tempInt)){
                                    row1.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if(i<6)
                            while (!findNum)
                            {
                                if (row1.Contains(tempInt) && group2.Contains(tempInt)){
                                    row1.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row1.Contains(tempInt) && group3.Contains(tempInt)){
                                    row1.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    else if (j == 1){
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row2.Contains(tempInt) && group1.Contains(tempInt)){
                                    row2.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if (i < 6)
                            while (!findNum)
                            {
                                if (row2.Contains(tempInt) && group2.Contains(tempInt)){
                                    row2.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row2.Contains(tempInt) && group3.Contains(tempInt)){
                                    row2.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    else if (j == 2)
                    {
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row3.Contains(tempInt) && group1.Contains(tempInt))
                                {
                                    row3.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if (i < 6)
                            while (!findNum)
                            {
                                if (row3.Contains(tempInt) && group2.Contains(tempInt))
                                {
                                    row3.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row3.Contains(tempInt) && group3.Contains(tempInt))
                                {
                                    row3.Remove(tempInt); group1.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    else if (j == 3)
                    {
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row4.Contains(tempInt) && group4.Contains(tempInt))
                                {
                                    row4.Remove(tempInt); group4.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if (i < 6)
                            while (!findNum)
                            {
                                if (row4.Contains(tempInt) && group5.Contains(tempInt))
                                {
                                    row4.Remove(tempInt); group5.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row4.Contains(tempInt) && group6.Contains(tempInt))
                                {
                                    row4.Remove(tempInt); group6.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    else if (j == 4)
                    {
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row5.Contains(tempInt) && group4.Contains(tempInt))
                                {
                                    row5.Remove(tempInt); group4.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if (i < 6)
                            while (!findNum)
                            {
                                if (row5.Contains(tempInt) && group5.Contains(tempInt))
                                {
                                    row5.Remove(tempInt); group5.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row5.Contains(tempInt) && group6.Contains(tempInt))
                                {
                                    row5.Remove(tempInt); group6.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    else if (j == 5)
                    {
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row6.Contains(tempInt) && group4.Contains(tempInt))
                                {
                                    row6.Remove(tempInt); group4.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if (i < 6)
                            while (!findNum)
                            {
                                if (row6.Contains(tempInt) && group5.Contains(tempInt))
                                {
                                    row6.Remove(tempInt); group5.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row6.Contains(tempInt) && group6.Contains(tempInt))
                                {
                                    row6.Remove(tempInt); group6.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    else if (j == 6)
                    {
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row7.Contains(tempInt) && group7.Contains(tempInt))
                                {
                                    row7.Remove(tempInt); group7.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if (i < 6)
                            while (!findNum)
                            {
                                if (row7.Contains(tempInt) && group8.Contains(tempInt))
                                {
                                    row7.Remove(tempInt); group8.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row7.Contains(tempInt) && group9.Contains(tempInt))
                                {
                                    row7.Remove(tempInt); group9.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    else if (j == 7)
                    {
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row8.Contains(tempInt) && group7.Contains(tempInt))
                                {
                                    row8.Remove(tempInt); group7.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if (i < 6)
                            while (!findNum)
                            {
                                if (row8.Contains(tempInt) && group8.Contains(tempInt))
                                {
                                    row8.Remove(tempInt); group8.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row8.Contains(tempInt) && group9.Contains(tempInt))
                                {
                                    row8.Remove(tempInt); group9.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    else if (j == 8)
                    {
                        if (i <= 2)
                            while (!findNum)
                            {
                                if (row9.Contains(tempInt) && group7.Contains(tempInt))
                                {
                                    row9.Remove(tempInt); group7.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else if (i < 6)
                            while (!findNum)
                            {
                                if (row9.Contains(tempInt) && group8.Contains(tempInt))
                                {
                                    row9.Remove(tempInt); group8.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                        else
                            while (!findNum)
                            {
                                if (row9.Contains(tempInt) && group9.Contains(tempInt))
                                {
                                    row9.Remove(tempInt); group9.Remove(tempInt); findNum = true;
                                }
                                else tempInt = rand.Next(10);
                            }
                    }
                    board[i, j] = tempInt;
                }
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            numFont = Content.Load<SpriteFont>("numFont");
            rectTex = Content.Load<Texture2D>("rectangle");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            int tempI; int tempJ;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    tempI = i;
                    tempJ = j;
                    if (i > 5)
                        tempI += 2;
                    else if (i > 2)
                        tempI++;
                    if (j > 5)
                        tempJ += 2;
                    else if (j > 2)
                        tempJ++;
                    _spriteBatch.Draw(rectTex, new Rectangle((tempI * 70), tempJ * 70, 69, 69), Color.White);
                    _spriteBatch.DrawString(numFont, Convert.ToString(board[i, j]), new Vector2((70 * tempI), (70 * tempJ)), Color.Black);
                }

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        
    }
}