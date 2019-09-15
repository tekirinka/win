namespace Lines
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
            System.Windows.Forms.Label label1;
            this.pb = new System.Windows.Forms.PictureBox();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.tb = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(626, 331);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // flp
            // 
            this.flp.AutoSize = true;
            this.flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp.Controls.Add(label1);
            this.flp.Controls.Add(this.tb);
            this.flp.Controls.Add(this.btn);
            this.flp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp.Location = new System.Drawing.Point(0, 349);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(626, 39);
            this.flp.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 39);
            label1.TabIndex = 0;
            label1.Text = "Кол-во линий:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(131, 3);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(249, 30);
            this.tb.TabIndex = 1;
            this.tb.Text = "0";
            this.tb.TextChanged += new System.EventHandler(this.draw);
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Location = new System.Drawing.Point(386, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(59, 33);
            this.btn.TabIndex = 2;
            this.btn.Text = "Draw";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.draw);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 388);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.pb);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lines";
            this.Load += new System.EventHandler(this.draw);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.draw);
            this.Resize += new System.EventHandler(this.draw);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btn;
    }
}

