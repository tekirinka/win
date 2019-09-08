namespace boxes
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
            this.btn = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn.Location = new System.Drawing.Point(0, 512);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(785, 33);
            this.btn.TabIndex = 1;
            this.btn.Text = "Draw";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.draw);
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(785, 512);
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            this.pb.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.draw);
            this.pb.Click += new System.EventHandler(this.draw);
            this.pb.Resize += new System.EventHandler(this.draw);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 545);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boxes";
            this.Load += new System.EventHandler(this.draw);
            this.Shown += new System.EventHandler(this.draw);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox pb;
    }
}

