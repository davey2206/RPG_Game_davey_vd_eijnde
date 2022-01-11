
namespace RPG_Game
{
    partial class MapForm
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyBox5 = new System.Windows.Forms.PictureBox();
            this.EnemyBox4 = new System.Windows.Forms.PictureBox();
            this.EnemyBox3 = new System.Windows.Forms.PictureBox();
            this.EnemyBox2 = new System.Windows.Forms.PictureBox();
            this.EnemyBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // EnemyBox5
            // 
            this.EnemyBox5.Location = new System.Drawing.Point(164, 12);
            this.EnemyBox5.Name = "EnemyBox5";
            this.EnemyBox5.Size = new System.Drawing.Size(32, 32);
            this.EnemyBox5.TabIndex = 5;
            this.EnemyBox5.TabStop = false;
            this.EnemyBox5.Tag = "Enemy";
            // 
            // EnemyBox4
            // 
            this.EnemyBox4.Location = new System.Drawing.Point(126, 12);
            this.EnemyBox4.Name = "EnemyBox4";
            this.EnemyBox4.Size = new System.Drawing.Size(32, 32);
            this.EnemyBox4.TabIndex = 4;
            this.EnemyBox4.TabStop = false;
            this.EnemyBox4.Tag = "Enemy";
            // 
            // EnemyBox3
            // 
            this.EnemyBox3.Location = new System.Drawing.Point(88, 12);
            this.EnemyBox3.Name = "EnemyBox3";
            this.EnemyBox3.Size = new System.Drawing.Size(32, 32);
            this.EnemyBox3.TabIndex = 3;
            this.EnemyBox3.TabStop = false;
            this.EnemyBox3.Tag = "Enemy";
            // 
            // EnemyBox2
            // 
            this.EnemyBox2.Location = new System.Drawing.Point(50, 12);
            this.EnemyBox2.Name = "EnemyBox2";
            this.EnemyBox2.Size = new System.Drawing.Size(32, 32);
            this.EnemyBox2.TabIndex = 2;
            this.EnemyBox2.TabStop = false;
            this.EnemyBox2.Tag = "Enemy";
            // 
            // EnemyBox1
            // 
            this.EnemyBox1.Location = new System.Drawing.Point(12, 12);
            this.EnemyBox1.Name = "EnemyBox1";
            this.EnemyBox1.Size = new System.Drawing.Size(32, 32);
            this.EnemyBox1.TabIndex = 1;
            this.EnemyBox1.TabStop = false;
            this.EnemyBox1.Tag = "Enemy";
            // 
            // PlayerBox
            // 
            this.PlayerBox.Image = global::RPG_Game.Properties.Resources.Player_boy;
            this.PlayerBox.Location = new System.Drawing.Point(7, 374);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(75, 75);
            this.PlayerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerBox.TabIndex = 0;
            this.PlayerBox.TabStop = false;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.EnemyBox5);
            this.Controls.Add(this.EnemyBox4);
            this.Controls.Add(this.EnemyBox3);
            this.Controls.Add(this.EnemyBox2);
            this.Controls.Add(this.EnemyBox1);
            this.Controls.Add(this.PlayerBox);
            this.Name = "MapForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.PictureBox EnemyBox1;
        private System.Windows.Forms.PictureBox EnemyBox2;
        private System.Windows.Forms.PictureBox EnemyBox3;
        private System.Windows.Forms.PictureBox EnemyBox4;
        private System.Windows.Forms.PictureBox EnemyBox5;
        private System.Windows.Forms.Timer GameTimer;
    }
}

