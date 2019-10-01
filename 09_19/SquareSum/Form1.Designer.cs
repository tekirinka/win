namespace SquareSum
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.FlowLayoutPanel flp;
            this.btn = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lOut = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            flp = new System.Windows.Forms.FlowLayoutPanel();
            flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(22, 23);
            label1.TabIndex = 0;
            label1.Text = "A";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Location = new System.Drawing.Point(3, 144);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(43, 33);
            this.btn.TabIndex = 1;
            this.btn.Text = "OK";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.calculate);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(20, 23);
            label2.TabIndex = 2;
            label2.Text = "B";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(3, 26);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 30);
            this.tbA.TabIndex = 3;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(3, 85);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 30);
            this.tbB.TabIndex = 4;
            // 
            // lOut
            // 
            this.lOut.AutoSize = true;
            this.lOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOut.Location = new System.Drawing.Point(3, 118);
            this.lOut.Name = "lOut";
            this.lOut.Size = new System.Drawing.Size(80, 23);
            this.lOut.TabIndex = 5;
            this.lOut.Text = "_______";
            this.lOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // flp
            // 
            flp.AutoSize = true;
            flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flp.Controls.Add(label1);
            flp.Controls.Add(this.tbA);
            flp.Controls.Add(label2);
            flp.Controls.Add(this.tbB);
            flp.Controls.Add(this.lOut);
            flp.Controls.Add(this.btn);
            flp.Dock = System.Windows.Forms.DockStyle.Fill;
            flp.Location = new System.Drawing.Point(0, 0);
            flp.Name = "flp";
            flp.Size = new System.Drawing.Size(123, 195);
            flp.TabIndex = 6;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(123, 195);
            this.Controls.Add(flp);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Square sum";
            flp.ResumeLayout(false);
            flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lOut;
    }
}

