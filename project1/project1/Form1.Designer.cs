namespace project1
{
    partial class jsq
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
            this.buttonadd = new System.Windows.Forms.Button();
            this.textBoxop1 = new System.Windows.Forms.TextBox();
            this.textBoxop2 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonadd.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonadd.Location = new System.Drawing.Point(337, 135);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(94, 95);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // textBoxop1
            // 
            this.textBoxop1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxop1.Location = new System.Drawing.Point(150, 135);
            this.textBoxop1.Name = "textBoxop1";
            this.textBoxop1.Size = new System.Drawing.Size(181, 42);
            this.textBoxop1.TabIndex = 1;
            this.textBoxop1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxop2
            // 
            this.textBoxop2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxop2.Location = new System.Drawing.Point(150, 188);
            this.textBoxop2.Name = "textBoxop2";
            this.textBoxop2.Size = new System.Drawing.Size(181, 42);
            this.textBoxop2.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(437, 158);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(141, 52);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Result";
            // 
            // jsq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 360);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxop2);
            this.Controls.Add(this.textBoxop1);
            this.Controls.Add(this.buttonadd);
            this.Name = "jsq";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.TextBox textBoxop1;
        private System.Windows.Forms.TextBox textBoxop2;
        private System.Windows.Forms.Label labelResult;
    }
}

