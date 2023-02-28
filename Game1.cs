using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
            List<List<int>> rows = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                rows.Add(new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            }
            List<List<int>> groups = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                groups.Add(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            }
            List<List<int>> collumns = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                collumns.Add(new List<int> { 1,2,3,4,5,6,7,8,9});
            }
            int tempInt; bool numSet; int tempGroup;
            for (int i = 0; i<9; i++)
                for (int j =0; j < 9; j++)
                {
                    numSet = false;
                    tempInt = rand.Next(1, 10);
                    tempGroup = 0 + (i/3)+((j/3)*3);
                    while (!numSet)
                    {
                        if (rows[j].Contains(tempInt) && collumns[i].Contains(tempInt) && groups[tempGroup].Contains(tempInt))
                        {
                            rows[j].Remove(tempInt); collumns[i].Remove(tempInt); groups[tempGroup].Remove(tempInt); numSet = true; board[i, j] = tempInt;
                        }
                        else
                        {
                            tempInt = rand.Next(1, 10);
                        }
                    }
                }
            List<List<int>> list = new List<List<int>>();
                
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
                    tempI = 0;
                    tempJ = 0;
                    if (i > 5)
                        tempI += 2;
                    else if (i > 2)
                        tempI +=1;
                    if (j > 5)
                        tempJ += 2;
                    else if (j > 2)
                        tempJ+= 1;
                    _spriteBatch.Draw(rectTex, new Rectangle((i * 70)+tempI, (j * 70)+tempJ, 69, 69), Color.White);
                    _spriteBatch.DrawString(numFont, Convert.ToString(board[i, j]), new Vector2((70 * i)+tempI+2, (70 * j)+tempJ+2), Color.Black);
                }

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        
    }
}