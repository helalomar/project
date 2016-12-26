namespace test1
{
    partial class MovieGuide
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
            this.moviesh = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.starslb = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviesh
            // 
            this.moviesh.BackColor = System.Drawing.Color.White;
            this.moviesh.FormattingEnabled = true;
            this.moviesh.Location = new System.Drawing.Point(17, 87);
            this.moviesh.Name = "moviesh";
            this.moviesh.Size = new System.Drawing.Size(121, 21);
            this.moviesh.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "show cast";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // starslb
            // 
            this.starslb.BackColor = System.Drawing.Color.White;
            this.starslb.FormattingEnabled = true;
            this.starslb.Location = new System.Drawing.Point(299, 87);
            this.starslb.Name = "starslb";
            this.starslb.Size = new System.Drawing.Size(120, 95);
            this.starslb.TabIndex = 2;
            this.starslb.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(360, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(59, 17);
            this.listBox1.TabIndex = 3;
            this.listBox1.UseWaitCursor = true;
            this.listBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year of release";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(29, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "add movie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MovieGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test1.Properties.Resources.ab;
            this.ClientSize = new System.Drawing.Size(447, 333);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.starslb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moviesh);
            this.Name = "MovieGuide";
            this.Text = "Movie Guide";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox moviesh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox starslb;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}