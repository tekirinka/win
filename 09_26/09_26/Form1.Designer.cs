namespace _09_26
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
            this.lb = new System.Windows.Forms.ListBox();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btn = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 23;
            this.lb.Location = new System.Drawing.Point(0, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(120, 451);
            this.lb.TabIndex = 0;
            // 
            // flp
            // 
            this.flp.AutoSize = true;
            this.flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp.Controls.Add(this.cb);
            this.flp.Controls.Add(this.label1);
            this.flp.Controls.Add(this.tb1);
            this.flp.Controls.Add(this.label2);
            this.flp.Controls.Add(this.tb2);
            this.flp.Controls.Add(this.label3);
            this.flp.Controls.Add(this.tb3);
            this.flp.Controls.Add(this.btn);
            this.flp.Dock = System.Windows.Forms.DockStyle.Right;
            this.flp.Location = new System.Drawing.Point(397, 0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(170, 451);
            this.flp.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Location = new System.Drawing.Point(3, 138);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(43, 33);
            this.btn.TabIndex = 0;
            this.btn.Text = "OK";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.draw);
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.Location = new System.Drawing.Point(3, 3);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(164, 31);
            this.cb.TabIndex = 1;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.draw);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(9, 30);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(158, 30);
            this.tb1.TabIndex = 2;
            this.tb1.Text = "100";
            this.tb1.TextChanged += new System.EventHandler(this.draw);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(9, 66);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(158, 30);
            this.tb2.TabIndex = 3;
            this.tb2.Text = "5";
            this.tb2.TextChanged += new System.EventHandler(this.draw);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(9, 102);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(158, 30);
            this.tb3.TabIndex = 4;
            this.tb3.Text = "3";
            this.tb3.TextChanged += new System.EventHandler(this.draw);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 5;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 6;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 7;
            this.label3.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 451);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.lb);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "09_26";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.resize);
            this.Resize += new System.EventHandler(this.resize);
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb3;
    }
}

