namespace RockPaperScissor
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
            this.Paper1 = new System.Windows.Forms.PictureBox();
            this.Scissor1 = new System.Windows.Forms.PictureBox();
            this.Rock1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Scissor2 = new System.Windows.Forms.PictureBox();
            this.Rock2 = new System.Windows.Forms.PictureBox();
            this.Paper2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Paper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper2)).BeginInit();
            this.SuspendLayout();
            // 
            // Paper1
            // 
            this.Paper1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paper1.BackgroundImage")));
            this.Paper1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Paper1.Location = new System.Drawing.Point(44, 44);
            this.Paper1.Name = "Paper1";
            this.Paper1.Size = new System.Drawing.Size(119, 106);
            this.Paper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paper1.TabIndex = 0;
            this.Paper1.TabStop = false;
            this.Paper1.Visible = false;
            // 
            // Scissor1
            // 
            this.Scissor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Scissor1.Image = ((System.Drawing.Image)(resources.GetObject("Scissor1.Image")));
            this.Scissor1.Location = new System.Drawing.Point(46, 44);
            this.Scissor1.Name = "Scissor1";
            this.Scissor1.Size = new System.Drawing.Size(117, 106);
            this.Scissor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Scissor1.TabIndex = 1;
            this.Scissor1.TabStop = false;
            this.Scissor1.Visible = false;
            // 
            // Rock1
            // 
            this.Rock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rock1.Image = ((System.Drawing.Image)(resources.GetObject("Rock1.Image")));
            this.Rock1.Location = new System.Drawing.Point(55, 44);
            this.Rock1.Name = "Rock1";
            this.Rock1.Size = new System.Drawing.Size(98, 114);
            this.Rock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Rock1.TabIndex = 2;
            this.Rock1.TabStop = false;
            this.Rock1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rock",
            "Paper",
            "Scissor"});
            this.comboBox1.Location = new System.Drawing.Point(42, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Choose Attack...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Attack !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Scissor2
            // 
            this.Scissor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Scissor2.Image = ((System.Drawing.Image)(resources.GetObject("Scissor2.Image")));
            this.Scissor2.Location = new System.Drawing.Point(275, 44);
            this.Scissor2.Name = "Scissor2";
            this.Scissor2.Size = new System.Drawing.Size(117, 106);
            this.Scissor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Scissor2.TabIndex = 5;
            this.Scissor2.TabStop = false;
            this.Scissor2.Visible = false;
            // 
            // Rock2
            // 
            this.Rock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Rock2.Image = ((System.Drawing.Image)(resources.GetObject("Rock2.Image")));
            this.Rock2.Location = new System.Drawing.Point(294, 44);
            this.Rock2.Name = "Rock2";
            this.Rock2.Size = new System.Drawing.Size(98, 114);
            this.Rock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Rock2.TabIndex = 6;
            this.Rock2.TabStop = false;
            this.Rock2.Visible = false;
            // 
            // Paper2
            // 
            this.Paper2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paper2.BackgroundImage")));
            this.Paper2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Paper2.Location = new System.Drawing.Point(275, 44);
            this.Paper2.Name = "Paper2";
            this.Paper2.Size = new System.Drawing.Size(119, 106);
            this.Paper2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paper2.TabIndex = 7;
            this.Paper2.TabStop = false;
            this.Paper2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "You : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Johnny : 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "VS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Paper2);
            this.Controls.Add(this.Rock2);
            this.Controls.Add(this.Scissor2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Rock1);
            this.Controls.Add(this.Scissor1);
            this.Controls.Add(this.Paper1);
            this.Name = "Form1";
            this.Text = "Rock. Paper,Scissor";
            ((System.ComponentModel.ISupportInitialize)(this.Paper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scissor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paper2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Paper1;
        private System.Windows.Forms.PictureBox Scissor1;
        private System.Windows.Forms.PictureBox Rock1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Scissor2;
        private System.Windows.Forms.PictureBox Rock2;
        private System.Windows.Forms.PictureBox Paper2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

