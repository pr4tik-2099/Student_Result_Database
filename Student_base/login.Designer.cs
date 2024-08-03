namespace Student_base
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.cls_txt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msg_lbl = new System.Windows.Forms.Label();
            this.lgn_txt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cls_txt
            // 
            this.cls_txt.BackColor = System.Drawing.Color.Transparent;
            this.cls_txt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cls_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cls_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cls_txt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cls_txt.Location = new System.Drawing.Point(394, 0);
            this.cls_txt.Name = "cls_txt";
            this.cls_txt.Size = new System.Drawing.Size(60, 34);
            this.cls_txt.TabIndex = 0;
            this.cls_txt.Text = "X";
            this.cls_txt.UseVisualStyleBackColor = false;
            this.cls_txt.Click += new System.EventHandler(this.cls_txt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.msg_lbl);
            this.panel1.Controls.Add(this.lgn_txt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pass_txt);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 474);
            this.panel1.TabIndex = 1;
            // 
            // msg_lbl
            // 
            this.msg_lbl.AutoSize = true;
            this.msg_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msg_lbl.Location = new System.Drawing.Point(70, 378);
            this.msg_lbl.Name = "msg_lbl";
            this.msg_lbl.Size = new System.Drawing.Size(50, 24);
            this.msg_lbl.TabIndex = 6;
            this.msg_lbl.Text = "\'\'\'\'\'\'\'\'";
            // 
            // lgn_txt
            // 
            this.lgn_txt.BackColor = System.Drawing.Color.Transparent;
            this.lgn_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lgn_txt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lgn_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgn_txt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgn_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lgn_txt.Location = new System.Drawing.Point(154, 423);
            this.lgn_txt.Name = "lgn_txt";
            this.lgn_txt.Size = new System.Drawing.Size(87, 34);
            this.lgn_txt.TabIndex = 2;
            this.lgn_txt.Text = "Login";
            this.lgn_txt.UseVisualStyleBackColor = false;
            this.lgn_txt.Click += new System.EventHandler(this.lgn_txt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 105);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.Location = new System.Drawing.Point(33, 260);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(328, 34);
            this.pass_txt.TabIndex = 4;
            this.pass_txt.UseSystemPasswordChar = true;
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(33, 164);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(328, 34);
            this.name_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 300);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 23);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cls_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cls_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button lgn_txt;
        private System.Windows.Forms.Label msg_lbl;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}