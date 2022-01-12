
namespace RPG_Game
{
    partial class CombatForm
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
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            this.EnemyBox = new System.Windows.Forms.PictureBox();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.lbEnemy = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.txtEnemy = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerBox
            // 
            this.PlayerBox.Location = new System.Drawing.Point(12, 12);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(300, 300);
            this.PlayerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerBox.TabIndex = 0;
            this.PlayerBox.TabStop = false;
            // 
            // EnemyBox
            // 
            this.EnemyBox.Location = new System.Drawing.Point(588, 12);
            this.EnemyBox.Name = "EnemyBox";
            this.EnemyBox.Size = new System.Drawing.Size(300, 300);
            this.EnemyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyBox.TabIndex = 1;
            this.EnemyBox.TabStop = false;
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.Location = new System.Drawing.Point(6, 315);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(93, 33);
            this.lbPlayer.TabIndex = 2;
            this.lbPlayer.Text = "label1";
            // 
            // lbEnemy
            // 
            this.lbEnemy.AutoSize = true;
            this.lbEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnemy.Location = new System.Drawing.Point(582, 324);
            this.lbEnemy.Name = "lbEnemy";
            this.lbEnemy.Size = new System.Drawing.Size(93, 33);
            this.lbEnemy.TabIndex = 3;
            this.lbEnemy.Text = "label2";
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(31, 494);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(121, 44);
            this.btnAttack.TabIndex = 4;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Enabled = false;
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer.Location = new System.Drawing.Point(212, 456);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(577, 38);
            this.txtPlayer.TabIndex = 5;
            // 
            // txtEnemy
            // 
            this.txtEnemy.Enabled = false;
            this.txtEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnemy.Location = new System.Drawing.Point(212, 500);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(577, 38);
            this.txtEnemy.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(355, 160);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(193, 47);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to map";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbGame
            // 
            this.lbGame.AutoSize = true;
            this.lbGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGame.Location = new System.Drawing.Point(315, 100);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(272, 55);
            this.lbGame.TabIndex = 8;
            this.lbGame.Text = "Game Over";
            this.lbGame.Visible = false;
            // 
            // CombatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lbGame);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtEnemy);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lbEnemy);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.EnemyBox);
            this.Controls.Add(this.PlayerBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CombatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CombatForm";
            this.Load += new System.EventHandler(this.CombatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.PictureBox EnemyBox;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Label lbEnemy;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.TextBox txtEnemy;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbGame;
    }
}