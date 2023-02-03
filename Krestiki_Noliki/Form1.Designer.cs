namespace Krestiki_Noliki
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крестикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ноликиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Игрок";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.Location = new System.Drawing.Point(585, 175);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(182, 74);
            this.buttonPlay.TabIndex = 10;
            this.buttonPlay.Text = "Начать игру сначала";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viborToolStripMenuItem
            // 
            this.viborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.крестикиToolStripMenuItem,
            this.ноликиToolStripMenuItem});
            this.viborToolStripMenuItem.Name = "viborToolStripMenuItem";
            this.viborToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.viborToolStripMenuItem.Text = "Выбор игрока";
            this.viborToolStripMenuItem.Click += new System.EventHandler(this.выборИгрокаToolStripMenuItem_Click);
            // 
            // крестикиToolStripMenuItem
            // 
            this.крестикиToolStripMenuItem.Name = "крестикиToolStripMenuItem";
            this.крестикиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.крестикиToolStripMenuItem.Text = "Крестики";
            this.крестикиToolStripMenuItem.Click += new System.EventHandler(this.крестикиToolStripMenuItem_Click);
            // 
            // ноликиToolStripMenuItem
            // 
            this.ноликиToolStripMenuItem.Name = "ноликиToolStripMenuItem";
            this.ноликиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ноликиToolStripMenuItem.Text = "Нолики";
            this.ноликиToolStripMenuItem.Click += new System.EventHandler(this.ноликиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 563);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button buttonPlay;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viborToolStripMenuItem;
        private ToolStripMenuItem крестикиToolStripMenuItem;
        private ToolStripMenuItem ноликиToolStripMenuItem;
    }
}