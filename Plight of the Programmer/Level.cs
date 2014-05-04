using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Plight_of_the_Programmer
{
    class Level
    {
        /*----Variables-----*/
        private static string levelID = "w1s1";
        private static int levelHeight;
        private static int levelWidth;
        private static string levelDesign;

        /*-----Members-----*/
        private static TextureID[,] tileID = new TextureID[LevelWidth, LevelHeight];

        /*-----Get/Set-----*/
        public static string LevelID
        {
            get { return levelID; }
            set { levelID = value; }
        }
        public static int LevelHeight
        {
            get { return levelHeight; }
            set { levelHeight = value; }
        }
        public static int LevelWidth
        {
            get { return levelWidth; }
            set { levelWidth = value; }
        }
        public static string LevelDesign
        {
            get { return levelDesign; }
            set { levelDesign = value; }
        }
        public static TextureID[,] TileID
        {
            get { return tileID; }
            set { tileID = value; }
        }

        /*-----Functions-----*/
        public static void initLevel()
        {
            string levelFile = "Levels/" + LevelID.ToString() + ".txt";
            try 
            {
                using (StreamReader sr = new StreamReader(levelFile)) 
                {
                    LevelWidth = Convert.ToInt32(sr.ReadLine());
                    LevelHeight = Convert.ToInt32(sr.ReadLine());
                    LevelDesign = sr.ReadLine();
                    TileID = new TextureID[LevelWidth,LevelHeight];
                    string line;
                    for (int y = 0; y < LevelHeight; y++)
                    {
                        line = sr.ReadLine();
                        string[] row = line.Split(new Char[] { ',' });
                        for (int x = 0; x < LevelWidth; x++)
                        {
                            switch (Convert.ToInt32(row[x]))
                            {
                                case 1:
                                    TileID[x,y] = TextureID.playerSpawn;
                                    Player.Xpos = ((x * GraphicsEngine.TILE_SIZE)+10);
                                    Player.Ypos = ((y * GraphicsEngine.TILE_SIZE)+16);
                                    break;
                                case 2:
                                    TileID[x, y] = TextureID.levelEnd;
                                    break;
                                case 3:
                                    TileID[x, y] = TextureID.floorL;
                                    break;
                                case 4:
                                    TileID[x, y] = TextureID.floorC;
                                    break;
                                case 5:
                                    TileID[x, y] = TextureID.floorR;
                                    break;
                                case 6:
                                    TileID[x, y] = TextureID.floorB;
                                    break;
                                case 7:
                                    TileID[x, y] = TextureID.wallL;
                                    break;
                                case 8:
                                    TileID[x, y] = TextureID.wallC;
                                    break;
                                case 9:
                                    TileID[x, y] = TextureID.wallR;
                                    break;
                                case 10:
                                    TileID[x, y] = TextureID.wallB;
                                    break;
                                case 11:
                                    TileID[x, y] = TextureID.platformL;
                                    break;
                                case 12:
                                    TileID[x, y] = TextureID.platformC;
                                    break;
                                case 13:
                                    TileID[x, y] = TextureID.platformR;
                                    break;
                                case 14:
                                    TileID[x, y] = TextureID.platformB;
                                    break;
                                default:
                                    TileID[x, y] = TextureID.air;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception e) 
            {
                // Let the user know what went wrong.
            }            
        }
    }
}
