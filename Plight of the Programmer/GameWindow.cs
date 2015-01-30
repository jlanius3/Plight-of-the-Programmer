using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices; // Command Line

namespace Plight_of_the_Programmer
{
    public partial class GameWindow : Form
    {
        /*-----Constants-----*/
        public const int CANVAS_HEIGHT = 600;
        public const int CANVAS_WIDTH = 800;

        /*-----Variables-----*/
        private bool inMenu = true;
        private bool gameRunning = false; // Prevents function from relaunching.
        int charCount = 0;
        private int menuButton = 0;
        private int pauseButton = 0;

        /*-----Members-----*/
        private Game game = new Game();
        PrivateFontCollection pfc = new PrivateFontCollection();
        
        /**/

        public GameWindow()
        {
            InitializeComponent();

        }

        // Canvas paint function - launches paint functionality.
        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (gameRunning == false)
            {
                gameRunning = true;
                Graphics g = pnlCanvas.CreateGraphics();
                game.startGame(g);
            }
        }

        // Allows the command line to be seen during normal execution.
        private void GameWindow_Load(object sender, EventArgs e)
        {
            AllocConsole();
             byte[] fontData = Plight_of_the_Programmer.Properties.Resources.PKMNFL_0;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            pfc.AddMemoryFont(fontPtr, fontData.Length);
            Marshal.FreeCoTaskMem(fontPtr);
            Font customFont50B = new Font(pfc.Families[0], 50.0F, FontStyle.Bold);
            Font customFont25 = new Font(pfc.Families[0], 24.75F);

            lblPlay.Font = customFont50B;
            lblCharacter.Font = customFont50B;
            lblContinue.Font = customFont25;
            lblMenu.Font = customFont25;
        
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        
        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!inMenu)
            {
                game.stopGame();
            }
        }

        /*------------------------------------------------------------------
          Eventually make it so Up/Down Arrow Keys call following functions.
          ------------------------------------------------------------------ */

        private void lblPlay_Click(object sender, EventArgs e)
        {
            inMenu = false;
            lblPlay.Visible = false;
            lblPlay.Enabled = false;
            lblCharacter.Visible = false;
            lblCharacter.Enabled = false;
            pbCharacter.Visible = false;
            pbCharacter.Enabled = false;
            pnlCanvas.Enabled = true;
            pnlCanvas.Visible = true;
            pbMenu.Visible = false;
            pbMenu.Enabled = false;
        }

        private void lblCharacter_Click(object sender, EventArgs e)
        {
            charCount++;
            switch (charCount % 2)
            {
                case 0:
                    Player.Skin = "Jordan";
                    pbCharacter.Image = Plight_of_the_Programmer.Properties.Resources.jordanRun;
                    break;
                case 1:
                    Player.Skin = "Michael";
                    pbCharacter.Image = Plight_of_the_Programmer.Properties.Resources.michaelRun;
                    break;
            }
        }

        private void lblContinue_Click(object sender, EventArgs e)
        {
            game.unpause();
            pnlPause.Visible = false;
            pnlPause.Enabled = false;
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            game.stopGame();
            Game.paused = false;

            pbMenu.Enabled = true;
            pbMenu.Visible = true;
            pnlPause.Visible = false;
            pnlPause.Enabled = false;
            pnlCanvas.Visible = false;
            pnlCanvas.Enabled = false;
            lblPlay.Enabled = true;
            lblPlay.Visible = true;
            lblCharacter.Enabled = true;
            lblCharacter.Visible = true;
            pbCharacter.Enabled = true;
            pbCharacter.Visible = true;
            inMenu = true;
            gameRunning = false;
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (inMenu == false)
            {
                if (Game.paused == false)
                {
                    if (e.KeyCode == Keys.Left)
                    {
                        Player.movement(1);

                    }
                    if (e.KeyCode == Keys.Right)
                    {
                        Player.movement(2);

                    }
                    if (e.KeyCode == Keys.Up)
                    {
                        Player.movement(0);
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        Player.movement(5);
                    }
                    if (e.KeyCode == Keys.Escape)
                    {
                        game.pause();
                        pnlPause.Enabled = true;
                        pnlPause.Visible = true;
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                    {
                        if (pauseButton == 0)
                        { MenuSelect(); }
                        else
                        { ContinueSelect(); }
                    }
                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.X)
                    {
                        if (pauseButton == 0)
                        { lblContinue_Click(this, new EventArgs()); }
                        else
                        { lblMenu_Click(this, new EventArgs()); }
                    }
                    if (e.KeyCode == Keys.Escape)
                    {
                        lblContinue_Click(this, new EventArgs());
                    }
                }
            }
            else
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                {
                    if (menuButton == 0)
                    { CharacterSelect(); }
                    else
                    { PlaySelect(); }
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.X)
                {
                    if (menuButton == 0)
                    { lblPlay_Click(this, new EventArgs()); }
                    else
                    { lblCharacter_Click(this, new EventArgs());  }
                }
            }
        }
        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                Player.movement(3);


            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            { Player.movement(4); }
        }

        private void PlaySelect()
        {
            lblCharacter.Text = "Character";
            lblPlay.Text = "> Play";
            menuButton = 0;
        }

        private void CharacterSelect()
        {
            lblPlay.Text = "Play";
            lblCharacter.Text = "> Character";
            menuButton = 1;
        }

        private void ContinueSelect()
        {
            lblMenu.Text = "Menu";
            lblContinue.Text = "> Continue";
            pauseButton = 0;
        }

        private void MenuSelect()
        {
            lblContinue.Text = "Continue";
            lblMenu.Text = "> Menu";
            pauseButton = 1;
        }

        private void lblPlay_MouseEnter(object sender, EventArgs e)
        {
            lblPlay.ForeColor = Color.FromArgb(12, 191, 0);
            PlaySelect();
        }

        private void lblPlay_MouseLeave(object sender, EventArgs e)
        {
            lblPlay.ForeColor = Color.Green;
        }

        private void lblCharacter_MouseEnter(object sender, EventArgs e)
        {
            lblCharacter.ForeColor = Color.FromArgb(12, 191, 0);
            CharacterSelect();
        }

        private void lblCharacter_MouseLeave(object sender, EventArgs e)
        {
            lblCharacter.ForeColor = Color.Green;
        }

        private void lblContinue_MouseEnter(object sender, EventArgs e)
        {
            lblContinue.ForeColor = Color.White;
            ContinueSelect();
        }

        private void lblContinue_MouseLeave(object sender, EventArgs e)
        {
            lblContinue.ForeColor = Color.Gainsboro;
        }

        private void lblMenu_MouseEnter(object sender, EventArgs e)
        {
            lblMenu.ForeColor = Color.White;
            MenuSelect();
        }

        private void lblMenu_MouseLeave(object sender, EventArgs e)
        {
            lblMenu.ForeColor = Color.Gainsboro;
        }
    }
}
