namespace HW
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
            this.pb = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.cb = new System.Windows.Forms.ComboBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.Location = new System.Drawing.Point(50, 88);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(141, 211);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Layout += new System.Windows.Forms.LayoutEventHandler(this.resize);
            this.pb.Resize += new System.EventHandler(this.resize);
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.Location = new System.Drawing.Point(3, 102);
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
            this.flp.Controls.Add(this.cb);
            this.flp.Controls.Add(this.tb1);
            this.flp.Controls.Add(this.tb2);
            this.flp.Controls.Add(this.btn);
            this.flp.Dock = System.Windows.Forms.DockStyle.Right;
            this.flp.Location = new System.Drawing.Point(529, 0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(178, 419);
            this.flp.TabIndex = 2;
            // 
            // cb
            // 
            this.cb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb.Items.AddRange(new object[] {
            "Квадрат с ромбом",
            "Квадрат с кругом",
            "Круги",
            "Звезда",
            "Линии",
            "Прямоугольники",
            "Решетка",
            "Круги (1)",
            "Числа",
            "Сумма квадратов",
            "Сумма",
            "Сумма (1)",
            "Сумма (2)",
            "Сумма (3)",
            "Факториал",
            "Косинусы",
            "Линия под углом"});
            this.cb.Location = new System.Drawing.Point(3, 3);
            this.cb.MaxDropDownItems = 20;
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(172, 31);
            this.cb.TabIndex = 3;
            this.cb.Text = "Квадрат с ромбом";
            this.cb.SelectedIndexChanged += new System.EventHandler(this.draw);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(3, 30);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(172, 30);
            this.tb1.TabIndex = 4;
            this.tb1.Text = "0";
            this.tb1.Visible = false;
            this.tb1.TextChanged += new System.EventHandler(this.draw);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 23;
            this.lb.Location = new System.Drawing.Point(248, 232);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(211, 96);
            this.lb.TabIndex = 3;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(3, 66);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(172, 30);
            this.tb2.TabIndex = 5;
            this.tb2.Text = "5";
            this.tb2.TextChanged += new System.EventHandler(this.draw);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 419);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.pb);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "Homework";
            this.Resize += new System.EventHandler(this.resize);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.TextBox tb2;
    }
}

