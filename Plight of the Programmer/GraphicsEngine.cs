﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace Plight_of_the_Programmer
{
    class GraphicsEngine
    {
        /*-----Constants-----*/
        public const int TILE_SIZE = 50;

        /*-----Variables-----*/
        private Bitmap tex_player;
        private Bitmap tex_floor;
        private Bitmap tex_wall;
        private Bitmap tex_platformC;
        private Bitmap tex_platformL;
        private Bitmap tex_platformR;
        private Bitmap levelBitmap;

        /*-----Members-----*/
        private Graphics drawHandle;
        private Thread renderThread;
        private EventWaitHandle ewh;

        /*-----Functions-----*/
        public GraphicsEngine(Graphics g)
        {
            drawHandle = g;
        }

        public void initGraphics()
        {
            loadTiles();
            buildLevel();

            // Starts the render thread
            Player.Leftmovethread = new Thread(new ThreadStart(Player.movementleft));
            Player.Vertmovethread = new Thread(new ThreadStart(Player.Vertmovement));
            Player.Rightmovethread = new Thread(new ThreadStart(Player.movementright));
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
            Player.Leftmovethread.Start();
            Player.Vertmovethread.Start();
            Player.Rightmovethread.Start();

            
        }

        public void unpause()
        {
            ewh.Set();
        }

        public void stopGraphics()
        {
            renderThread.Abort();
            Player.Leftmovethread.Abort();
            Player.Rightmovethread.Abort();
            Player.Vertmovethread.Abort();
        }

        public void loadTiles()
        {
            // List of all images to be used.
            switch (Player.Skin)
            {
                case "Jordan":
                    tex_player = Plight_of_the_Programmer.Properties.Resources.jordan;
                    break;
                case "Michael":
                    tex_player = Plight_of_the_Programmer.Properties.Resources.michael;
                    break;
            }
            tex_floor = Plight_of_the_Programmer.Properties.Resources.floor;
            tex_wall = Plight_of_the_Programmer.Properties.Resources.wall;
            tex_platformC = Plight_of_the_Programmer.Properties.Resources.platCenterDigital;
            tex_platformL = Plight_of_the_Programmer.Properties.Resources.platLeftDigital;
            tex_platformR = Plight_of_the_Programmer.Properties.Resources.platRightDigital;
        }

        public void buildLevel()
        {
            Level.initLevel();
            levelBitmap = new Bitmap(Level.LevelWidth * TILE_SIZE, Level.LevelHeight * TILE_SIZE);
            Graphics levelGraphics = Graphics.FromImage(levelBitmap);
            TextureID[,] textures = Level.TileID;

            for (int x = 0; x < Level.LevelWidth; x++)
            {
                for (int y = 0; y < Level.LevelHeight; y++)
                {
                    switch (textures[x, y])
                    {
                        case TextureID.floorL:
                        case TextureID.floorC:
                        case TextureID.floorR:
                        case TextureID.floorB:
                            levelGraphics.DrawImage(tex_floor, x * TILE_SIZE, y * TILE_SIZE);
                            break;
                        case TextureID.wallL:
                        case TextureID.wallC:
                        case TextureID.wallR:
                        case TextureID.wallB:
                            levelGraphics.DrawImage(tex_wall, x * TILE_SIZE, y * TILE_SIZE);
                            break;
                        case TextureID.platformL:
                            levelGraphics.DrawImage(tex_platformL, x * TILE_SIZE, y * TILE_SIZE);
                            break;
                        case TextureID.platformC:
                            levelGraphics.DrawImage(tex_platformC, x * TILE_SIZE, y * TILE_SIZE);
                            break;
                        case TextureID.platformR:
                            levelGraphics.DrawImage(tex_platformR, x * TILE_SIZE, y * TILE_SIZE);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void render()
        {
            // Benchmarking info
            int framesRendered = 0;
            long startTime = Environment.TickCount;
            long endTime = 0;
            ewh = new EventWaitHandle(false, EventResetMode.AutoReset);

            // Objects used for constructing the individual frames of the game.
            Bitmap frame = new Bitmap(GameWindow.CANVAS_WIDTH, GameWindow.CANVAS_HEIGHT);
            Graphics frameGraphics = Graphics.FromImage(frame);

            while (true)
            {
                // Background Color.
                frameGraphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 15, 0)), 0, 0, GameWindow.CANVAS_WIDTH, GameWindow.CANVAS_HEIGHT);

                frameGraphics.DrawImage(levelBitmap, 0, 0);

                //
                frameGraphics.DrawImage(tex_player, Player.Xpos, Player.Ypos);

                // Draw the frame on the canvas.
                drawHandle.DrawImage(frame, 0, 0);

                // Benchmarking
                framesRendered++;
                if (Environment.TickCount >= startTime + 1000)
                {
                    Console.WriteLine("GrEngine: " + framesRendered + " fps");
                    framesRendered = 0;
                    startTime = Environment.TickCount;
                }

                if (Game.paused == true)
                {
                    ewh.WaitOne();
                }
            }
        }
    }
}
