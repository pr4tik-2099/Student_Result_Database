namespace Student_base
{
    partial class Remove_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Student));
            this.dlt_btn = new System.Windows.Forms.Button();
            this.Show_btn = new System.Windows.Forms.Button();
            this.rno_txt = new System.Windows.Forms.TextBox();
            this.result_gbox = new System.Windows.Forms.GroupBox();
            this.marks_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srno_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.result_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlt_btn
            // 
            this.dlt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dlt_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlt_btn.Location = new System.Drawing.Point(333, 485);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(87, 35);
            this.dlt_btn.TabIndex = 20;
            this.dlt_btn.Text = "Delete";
            this.dlt_btn.UseVisualStyleBackColor = true;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // Show_btn
            // 
            this.Show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_btn.Location = new System.Drawing.Point(333, 174);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(91, 35);
            this.Show_btn.TabIndex = 19;
            this.Show_btn.Text = "Show";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // rno_txt
            // 
            this.rno_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rno_txt.Location = new System.Drawing.Point(379, 90);
            this.rno_txt.Name = "rno_txt";
            this.rno_txt.Size = new System.Drawing.Size(235, 34);
            this.rno_txt.TabIndex = 18;
            // 
            // result_gbox
            // 
            this.result_gbox.Controls.Add(this.marks_txt);
            this.result_gbox.Controls.Add(this.label2);
            this.result_gbox.Controls.Add(this.srno_txt);
            this.result_gbox.Controls.Add(this.label3);
            this.result_gbox.Controls.Add(this.name_txt);
            this.result_gbox.Controls.Add(this.label4);
            this.result_gbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_gbox.Location = new System.Drawing.Point(133, 215);
            this.result_gbox.Name = "result_gbox";
            this.result_gbox.Size = new System.Drawing.Size(534, 250);
            this.result_gbox.TabIndex = 17;
            this.result_gbox.TabStop = false;
            this.result_gbox.Text = "Result";
            // 
            // marks_txt
            // 
            this.marks_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marks_txt.Location = new System.Drawing.Point(255, 147);
            this.marks_txt.Name = "marks_txt";
            this.marks_txt.Size = new System.Drawing.Size(235, 34);
            this.marks_txt.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // srno_txt
            // 
            this.srno_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srno_txt.Location = new System.Drawing.Point(255, 89);
            this.srno_txt.Name = "srno_txt";
            this.srno_txt.Size = new System.Drawing.Size(235, 34);
            this.srno_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Roll no";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(255, 33);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(235, 34);
            this.name_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 44);
            this.label5.TabIndex = 16;
            this.label5.Text = "Remove Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Roll no";
            // 
            // Remove_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(741, 532);
            this.Controls.Add(this.dlt_btn);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.rno_txt);
            this.Controls.Add(this.result_gbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Remove_Student";
            this.Text = "Remove_Student";
            this.Load += new System.EventHandler(this.Remove_Student_Load);
            this.result_gbox.ResumeLayout(false);
            this.result_gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dlt_btn;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.TextBox rno_txt;
        private System.Windows.Forms.GroupBox result_gbox;
        private System.Windows.Forms.TextBox marks_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srno_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}