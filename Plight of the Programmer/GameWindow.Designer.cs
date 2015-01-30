namespace Plight_of_the_Programmer
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pnlPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Enabled = false;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(800, 600);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Visible = false;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // lblPlay
            // 
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.Green;
            this.lblPlay.Location = new System.Drawing.Point(360, 360);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(214, 100);
            this.lblPlay.TabIndex = 6;
            this.lblPlay.Text = "> Play";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            this.lblPlay.MouseEnter += new System.EventHandler(this.lblPlay_MouseEnter);
            this.lblPlay.MouseLeave += new System.EventHandler(this.lblPlay_MouseLeave);
            // 
            // lblCharacter
            // 
            this.lblCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.ForeColor = System.Drawing.Color.Green;
            this.lblCharacter.Location = new System.Drawing.Point(360, 460);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(385, 100);
            this.lblCharacter.TabIndex = 7;
            this.lblCharacter.Text = "Character";
            this.lblCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCharacter.Click += new System.EventHandler(this.lblCharacter_Click);
            this.lblCharacter.MouseEnter += new System.EventHandler(this.lblCharacter_MouseEnter);
            this.lblCharacter.MouseLeave += new System.EventHandler(this.lblCharacter_MouseLeave);
            // 
            // pnlPause
            // 
            this.pnlPause.BackgroundImage = global::Plight_of_the_Programmer.Properties.Resources.pauseMenu;
            this.pnlPause.Controls.Add(this.lblMenu);
            this.pnlPause.Controls.Add(this.lblContinue);
            this.pnlPause.Enabled = false;
            this.pnlPause.Location = new System.Drawing.Point(200, 175);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(400, 250);
            this.pnlPause.TabIndex = 5;
            this.pnlPause.Visible = false;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblMenu.Font = new System.Drawing.Font("Power Red and Green", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMenu.Location = new System.Drawing.Point(121, 185);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(103, 50);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Menu";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            this.lblMenu.MouseEnter += new System.EventHandler(this.lblMenu_MouseEnter);
            this.lblMenu.MouseLeave += new System.EventHandler(this.lblMenu_MouseLeave);
            // 
            // lblContinue
            // 
            this.lblContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblContinue.Font = new System.Drawing.Font("Power Red and Green", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContinue.Location = new System.Drawing.Point(121, 135);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(155, 50);
            this.lblContinue.TabIndex = 0;
            this.lblContinue.Text = "> Continue";
            this.lblContinue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblContinue.Click += new System.EventHandler(this.lblContinue_Click);
            this.lblContinue.MouseEnter += new System.EventHandler(this.lblContinue_MouseEnter);
            this.lblContinue.MouseLeave += new System.EventHandler(this.lblContinue_MouseLeave);
            // 
            // pbCharacter
            // 
            this.pbCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.pbCharacter.Image = global::Plight_of_the_Programmer.Properties.Resources.jordanRun;
            this.pbCharacter.Location = new System.Drawing.Point(115, 348);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(154, 252);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharacter.TabIndex = 4;
            this.pbCharacter.TabStop = false;
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.pbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMenu.Image = global::Plight_of_the_Programmer.Properties.Resources.Menu;
            this.pbMenu.Location = new System.Drawing.Point(0, 0);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(800, 600);
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlPause);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 628);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(806, 628);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plight of the Programmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            this.pnlPause.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Label lblMenu;
        //public System.Windows.Forms.KeyEventHandler.GameWindow_KeyUp;
        

    }
}

