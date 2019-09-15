namespace _09_12
{
    partial class Form
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
            System.Windows.Forms.Label lRect;
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.tbRect = new System.Windows.Forms.TextBox();
            lRect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lRect
            // 
            lRect.AutoSize = true;
            lRect.Location = new System.Drawing.Point(3, 0);
            lRect.Name = "lRect";
            lRect.Size = new System.Drawing.Size(209, 23);
            lRect.TabIndex = 3;
            lRect.Text = "Кол-во прямоугольников:";
            lRect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Top;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(5);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(840, 433);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Location = new System.Drawing.Point(394, 5);
            this.btn.Margin = new System.Windows.Forms.Padding(5);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(59, 33);
            this.btn.TabIndex = 1;
            this.btn.Text = "Draw";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.draw);
            // 
            // flp
            // 
            this.flp.AutoSize = true;
            this.flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp.Controls.Add(lRect);
            this.flp.Controls.Add(this.tbRect);
            this.flp.Controls.Add(this.btn);
            this.flp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp.Location = new System.Drawing.Point(0, 442);
            this.flp.Margin = new System.Windows.Forms.Padding(5);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(840, 43);
            this.flp.TabIndex = 2;
            // 
            // tbRect
            // 
            this.tbRect.Location = new System.Drawing.Point(220, 5);
            this.tbRect.Margin = new System.Windows.Forms.Padding(5);
            this.tbRect.Name = "tbRect";
            this.tbRect.Size = new System.Drawing.Size(164, 30);
            this.tbRect.TabIndex = 2;
            this.tbRect.TextChanged += new System.EventHandler(this.draw);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 485);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.canvas);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rainbow";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.draw);
            this.Resize += new System.EventHandler(this.draw);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tbRect;
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}

