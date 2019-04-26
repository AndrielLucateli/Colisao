namespace Aula_2_prototipo
{
    partial class frmMove
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgGameOver = new System.Windows.Forms.PictureBox();
            this.pbMuro = new System.Windows.Forms.PictureBox();
            this.pbPersonagem = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgGameOver
            // 
            this.imgGameOver.Image = global::Aula_2_prototipo.Properties.Resources.tenor;
            this.imgGameOver.Location = new System.Drawing.Point(-1, 0);
            this.imgGameOver.Name = "imgGameOver";
            this.imgGameOver.Size = new System.Drawing.Size(808, 459);
            this.imgGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGameOver.TabIndex = 2;
            this.imgGameOver.TabStop = false;
            this.imgGameOver.Tag = "GameOverTag";
            this.imgGameOver.Visible = false;
            // 
            // pbMuro
            // 
            this.pbMuro.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbMuro.Image = global::Aula_2_prototipo.Properties.Resources.milos;
            this.pbMuro.Location = new System.Drawing.Point(566, 86);
            this.pbMuro.Name = "pbMuro";
            this.pbMuro.Size = new System.Drawing.Size(134, 316);
            this.pbMuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMuro.TabIndex = 1;
            this.pbMuro.TabStop = false;
            this.pbMuro.Tag = "muro";
            // 
            // pbPersonagem
            // 
            this.pbPersonagem.Image = global::Aula_2_prototipo.Properties.Resources.RedGhost;
            this.pbPersonagem.Location = new System.Drawing.Point(222, 154);
            this.pbPersonagem.Name = "pbPersonagem";
            this.pbPersonagem.Size = new System.Drawing.Size(56, 60);
            this.pbPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonagem.TabIndex = 0;
            this.pbPersonagem.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(321, 99);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(206, 39);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // frmMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.imgGameOver);
            this.Controls.Add(this.pbMuro);
            this.Controls.Add(this.pbPersonagem);
            this.Name = "frmMove";
            this.Text = "Movimento do Personagem";
            this.Load += new System.EventHandler(this.frmMove_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMove_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMove_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPersonagem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMuro;
        private System.Windows.Forms.PictureBox imgGameOver;
        private System.Windows.Forms.Label lblGameOver;
    }
}

