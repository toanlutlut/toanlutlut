namespace RotateElement_V2
{
    partial class Window_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_left = new System.Windows.Forms.Button();
            this.but_right = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle";
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(77, 22);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(50, 20);
            this.Angle.TabIndex = 1;
            this.Angle.Text = "45";
            this.Angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Angle.TextChanged += new System.EventHandler(this.TextBox_Angle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "degrees";
            // 
            // but_left
            // 
            this.but_left.Image = global::RotateElement_V2.Properties.Resources.rotate_left1;
            this.but_left.Location = new System.Drawing.Point(37, 53);
            this.but_left.Name = "but_left";
            this.but_left.Size = new System.Drawing.Size(50, 25);
            this.but_left.TabIndex = 3;
            this.but_left.UseVisualStyleBackColor = true;
            this.but_left.Click += new System.EventHandler(this.but_left_Click);
            // 
            // but_right
            // 
            this.but_right.Image = global::RotateElement_V2.Properties.Resources.rotate_right1;
            this.but_right.Location = new System.Drawing.Point(114, 52);
            this.but_right.Name = "but_right";
            this.but_right.Size = new System.Drawing.Size(50, 25);
            this.but_right.TabIndex = 4;
            this.but_right.UseVisualStyleBackColor = true;
            this.but_right.Click += new System.EventHandler(this.but_right_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Window_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 121);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.but_right);
            this.Controls.Add(this.but_left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(230, 160);
            this.MinimumSize = new System.Drawing.Size(230, 160);
            this.Name = "Window_Form";
            this.Text = "Rotate Element";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_left;
        private System.Windows.Forms.Button but_right;
        private System.Windows.Forms.Button button3;
    }
}