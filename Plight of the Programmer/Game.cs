using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing; // Attached to Graphics Engine

namespace Plight_of_the_Programmer
{
    class Game
    {
        /*-----Variables-----*/
        public static bool paused = false;

        /*-----Members-----*/
        private GraphicsEngine grEngine;

        public void startGame(Graphics g)
        {
            grEngine = new GraphicsEngine(g);
            grEngine.initGraphics();
        }

        public void pause()
        {
            paused = true;
        }

        public void unpause()
        {
            grEngine.unpause();
            paused = false;
        }

        public void stopGame()
        {
            grEngine.stopGraphics();
        }
    }

    public enum TextureID
    {
        air,
        playerSpawn,
        levelEnd,
        floorL,
        floorC,
        floorR,
        floorB,
        wallL,
        wallC,
        wallR,
        wallB,
        platformL,
        platformC,
        platformR,
        platformB
    }
}
