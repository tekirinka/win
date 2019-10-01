namespace _09_19
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
            System.Windows.Forms.Label label3;
            this.lb = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.tbK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbStep = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(20, 39);
            label1.TabIndex = 0;
            label1.Text = "K";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb
            // 
            this.lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 23;
            this.lb.Location = new System.Drawing.Point(0, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(765, 188);
            this.lb.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Location = new System.Drawing.Point(427, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(45, 33);
            this.btn.TabIndex = 1;
            this.btn.Text = "Fill";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.fill);
            // 
            // flp
            // 
            this.flp.AutoSize = true;
            this.flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp.Controls.Add(label1);
            this.flp.Controls.Add(this.tbK);
            this.flp.Controls.Add(this.label2);
            this.flp.Controls.Add(this.tbN);
            this.flp.Controls.Add(label3);
            this.flp.Controls.Add(this.tbStep);
            this.flp.Controls.Add(this.btn);
            this.flp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp.Location = new System.Drawing.Point(0, 352);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(765, 39);
            this.flp.TabIndex = 2;
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(29, 3);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(100, 30);
            this.tbK.TabIndex = 1;
            this.tbK.Text = "0";
            this.tbK.TextChanged += new System.EventHandler(this.fill);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(135, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "N";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(164, 3);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 30);
            this.tbN.TabIndex = 3;
            this.tbN.Text = "0";
            this.tbN.TextChanged += new System.EventHandler(this.fill);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(270, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 39);
            label3.TabIndex = 4;
            label3.Text = "Step";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(321, 3);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(100, 30);
            this.tbStep.TabIndex = 5;
            this.tbStep.Text = "0";
            this.tbStep.TextChanged += new System.EventHandler(this.fill);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 391);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.lb);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox example";
            this.Load += new System.EventHandler(this.fill);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.layout);
            this.Resize += new System.EventHandler(this.layout);
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbStep;
    }
}

