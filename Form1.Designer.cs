namespace boxing_choice_game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pagetxt = new System.Windows.Forms.Label();
            this.QandA = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pagetxt
            // 
            this.pagetxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pagetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagetxt.ForeColor = System.Drawing.Color.Khaki;
            this.pagetxt.Location = new System.Drawing.Point(29, 9);
            this.pagetxt.Name = "pagetxt";
            this.pagetxt.Size = new System.Drawing.Size(534, 55);
            this.pagetxt.TabIndex = 0;
            this.pagetxt.Text = "the bell rings and your opponent is standing there your in a boxing ring";
            this.pagetxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QandA
            // 
            this.QandA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QandA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QandA.ForeColor = System.Drawing.Color.Khaki;
            this.QandA.Location = new System.Drawing.Point(92, 278);
            this.QandA.Name = "QandA";
            this.QandA.Size = new System.Drawing.Size(415, 31);
            this.QandA.TabIndex = 1;
            this.QandA.Text = " should you uppercut or right hook him?";
            this.QandA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yes.Location = new System.Drawing.Point(12, 312);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(267, 58);
            this.yes.TabIndex = 2;
            this.yes.Text = "uppercut ";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.Click += new System.EventHandler(this.button1_Click);
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.SystemColors.ControlText;
            this.no.Location = new System.Drawing.Point(295, 312);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(284, 58);
            this.no.TabIndex = 3;
            this.no.Text = "right hook";
            this.no.UseVisualStyleBackColor = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Image = global::boxing_choice_game.Properties.Resources.mikey;
            this.picture.Location = new System.Drawing.Point(119, 77);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(365, 208);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(591, 382);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.QandA);
            this.Controls.Add(this.pagetxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "boxing game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pagetxt;
        private System.Windows.Forms.Label QandA;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.PictureBox picture;
    }
}

