using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;// Command Line

namespace Plight_of_the_Programmer
{ 
    class Player
    {
        /*-----Variables-----*/
        private static string skin = "Jordan";
        private static int xPos = 0;
        private static int yPos = 0;
        public static Thread Leftmovethread;
        public static Thread Vertmovethread;
        public static Thread Rightmovethread;
        public static int TILE_SIZE = GraphicsEngine.TILE_SIZE;
        public static int q=0;
        public static int f=0;
        public static int g=0;
        public static int rl = 0;
        public static int rr = 0;
        public static int TACO = 3;
        public static int Updetect;

        /*-----Get/Set-----*/
        public static string Skin
        {
            get { return skin; }
            set { skin = value; }
        }
        public static int Xpos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public static int Ypos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        /*-----Threads-------*/
        public static void Vertmovement()
        {
            while (true)
            {
                while (Updetect == 2)
                {//up
                    Thread.Sleep(10);
                    if (movementx(0) == false)
                    {
                        Ypos = Ypos + 1;
                    }
                } while (Updetect == 1)
                {//up
                    Thread.Sleep(10);
                    if (movementx(0) == false)
                    {
                        Ypos = Ypos - 1;
                    }
                }
                
            }
        }
        public static void movementright()
        {
            while (true)
            {
                while (TACO == 2)
                {//right
                    System.Threading.Thread.Sleep(10);
                    if (movementx(1) == false)
                    { Xpos = Xpos + 1; }
                    {

                    }
                }
            }
        }
        public static void movementleft()
        {
            while (true)
            { while (TACO == 1)
                { //left movement
                    System.Threading.Thread.Sleep(10);
                    if (movementx(-1) == false)
                    { Xpos = Xpos - 1; }
                }
            }
        }


        /*-----Functions-----*/

        public static bool movementx(int r)
<<<<<<< HEAD
        {
            int TILE_SIZE = GraphicsEngine.TILE_SIZE;
            int q = ((Xpos + 24) / TILE_SIZE);
            int f = ((Ypos + 32) / TILE_SIZE);
            int g = ((Ypos-1) / TILE_SIZE);
            int rl = ((Xpos + r ) / TILE_SIZE);
           // int rr = ((Xpos + 2) / TILE_SIZE);

            for (int p = rl; p <= q; p++)
            {
                for (int pp = g; pp <=f; pp++)
                {
                    switch (Level.TileID[p, pp])
                    {
                        case TextureID.air:
                        case TextureID.playerSpawn:
                        case TextureID.levelEnd:
                            // Xpos = Xpos - 1;
                            break;
                        case TextureID.floorL:
                        case TextureID.floorC:
                        case TextureID.floorR:
                        case TextureID.floorB:
                        case TextureID.wallL:
                        case TextureID.wallC:
                        case TextureID.wallR:
                        case TextureID.wallB:
                        case TextureID.platformL:
                        case TextureID.platformC:
                        case TextureID.platformR:
                        case TextureID.platformB:
                            return true;
                        //break;
                    }
                }

            }
            return false;
        }
        public static void movement(int w)
        {
=======
        {
            int TILE_SIZE = GraphicsEngine.TILE_SIZE;
            int q = ((Xpos + 24) / TILE_SIZE);
            int f = ((Ypos + 32) / TILE_SIZE);
            int g = ((Ypos-1) / TILE_SIZE);
            int rl = ((Xpos + r ) / TILE_SIZE);
           // int rr = ((Xpos + 2) / TILE_SIZE);

            for (int p = rl; p <= q; p++)
            {
                for (int pp = g; pp <=f; pp++)
                {
                    switch (Level.TileID[p, pp])
                    {
                        case TextureID.air:
                        case TextureID.playerSpawn:
                        case TextureID.levelEnd:
                            // Xpos = Xpos - 1;
                            break;
                        case TextureID.floorL:
                        case TextureID.floorC:
                        case TextureID.floorR:
                        case TextureID.floorB:
                        case TextureID.wallL:
                        case TextureID.wallC:
                        case TextureID.wallR:
                        case TextureID.wallB:
                        case TextureID.platformL:
                        case TextureID.platformC:
                        case TextureID.platformR:
                        case TextureID.platformB:
                            return true;
                        //break;
                    }
                }

            }
            return false;
        }
        public static void movement(int w)
        {//this is a comment to find on github
>>>>>>> origin/graphics-update
                       switch (w)
                       {
                           case 0://move up
                               Updetect = 1;
                           
                               break;
                           case 1://move left
                               TACO = 1;
                               break;
                           case 2://move right
                               TACO = 2;
                               break;
                           case 3: //kill horizontal movement
                               TACO = 3;
                               break;
                           case 4://kill verticle movement
                               Updetect = 0;
                               break;
                           case 5:
                               Updetect = 2;
                               break;
                       }
        }
    
   }
}
