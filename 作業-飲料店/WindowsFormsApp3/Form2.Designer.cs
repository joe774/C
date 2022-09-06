
namespace WindowsFormsApp3
{
    partial class Form2
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
            this.lbl訂購資料 = new System.Windows.Forms.Label();
            this.lBx訂購品項列表 = new System.Windows.Forms.ListBox();
            this.lbl訂單總價格 = new System.Windows.Forms.Label();
            this.btn移除所有品項 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.chk稅金 = new System.Windows.Forms.CheckBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.group = new System.Windows.Forms.GroupBox();
            this.btn離開 = new System.Windows.Forms.Button();
            this.btn儲存訂單 = new System.Windows.Forms.Button();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲訂購品項列表";
            // 
            // lbl訂購資料
            // 
            this.lbl訂購資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl訂購資料.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購資料.Location = new System.Drawing.Point(392, 50);
            this.lbl訂購資料.Name = "lbl訂購資料";
            this.lbl訂購資料.Size = new System.Drawing.Size(236, 27);
            this.lbl訂購資料.TabIndex = 1;
            this.lbl訂購資料.Text = "訂購資料";
            // 
            // lBx訂購品項列表
            // 
            this.lBx訂購品項列表.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBx訂購品項列表.FormattingEnabled = true;
            this.lBx訂購品項列表.HorizontalScrollbar = true;
            this.lBx訂購品項列表.ItemHeight = 24;
            this.lBx訂購品項列表.Location = new System.Drawing.Point(12, 92);
            this.lBx訂購品項列表.Name = "lBx訂購品項列表";
            this.lBx訂購品項列表.Size = new System.Drawing.Size(634, 268);
            this.lBx訂購品項列表.TabIndex = 2;
            this.lBx訂購品項列表.SelectedIndexChanged += new System.EventHandler(this.lBx訂購品項列表_SelectedIndexChanged);
            // 
            // lbl訂單總價格
            // 
            this.lbl訂單總價格.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl訂單總價格.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價格.Location = new System.Drawing.Point(379, 425);
            this.lbl訂單總價格.Name = "lbl訂單總價格";
            this.lbl訂單總價格.Size = new System.Drawing.Size(278, 27);
            this.lbl訂單總價格.TabIndex = 3;
            this.lbl訂單總價格.Text = "訂購單總價XXXXX元";
            // 
            // btn移除所有品項
            // 
            this.btn移除所有品項.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所有品項.Location = new System.Drawing.Point(252, 475);
            this.btn移除所有品項.Name = "btn移除所有品項";
            this.btn移除所有品項.Size = new System.Drawing.Size(156, 59);
            this.btn移除所有品項.TabIndex = 4;
            this.btn移除所有品項.Text = "移除所選品項";
            this.btn移除所有品項.UseVisualStyleBackColor = true;
            this.btn移除所有品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(440, 475);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(156, 59);
            this.btn清除所有品項.TabIndex = 5;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = true;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // chk稅金
            // 
            this.chk稅金.AutoSize = true;
            this.chk稅金.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk稅金.Location = new System.Drawing.Point(435, 383);
            this.chk稅金.Name = "chk稅金";
            this.chk稅金.Size = new System.Drawing.Size(161, 28);
            this.chk稅金.TabIndex = 6;
            this.chk稅金.Text = "加入5%稅金";
            this.chk稅金.UseVisualStyleBackColor = true;
            this.chk稅金.CheckedChanged += new System.EventHandler(this.chk稅金_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio1.Location = new System.Drawing.Point(19, 43);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(128, 28);
            this.radio1.TabIndex = 7;
            this.radio1.TabStop = true;
            this.radio1.Text = "買二送一";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio2.Location = new System.Drawing.Point(19, 85);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(128, 28);
            this.radio2.TabIndex = 8;
            this.radio2.TabStop = true;
            this.radio2.Text = "買三送一";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio3.Location = new System.Drawing.Point(19, 119);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(153, 28);
            this.radio3.TabIndex = 9;
            this.radio3.TabStop = true;
            this.radio3.Text = "第二件半價";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.group.Controls.Add(this.radio1);
            this.group.Controls.Add(this.radio3);
            this.group.Controls.Add(this.radio2);
            this.group.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.group.Location = new System.Drawing.Point(12, 383);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(181, 151);
            this.group.TabIndex = 10;
            this.group.TabStop = false;
            this.group.Text = "折扣活動";
            // 
            // btn離開
            // 
            this.btn離開.Location = new System.Drawing.Point(31, 30);
            this.btn離開.Name = "btn離開";
            this.btn離開.Size = new System.Drawing.Size(128, 47);
            this.btn離開.TabIndex = 11;
            this.btn離開.Text = "離開";
            this.btn離開.UseVisualStyleBackColor = true;
            this.btn離開.Click += new System.EventHandler(this.btn離開_Click);
            // 
            // btn儲存訂單
            // 
            this.btn儲存訂單.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存訂單.Location = new System.Drawing.Point(199, 398);
            this.btn儲存訂單.Name = "btn儲存訂單";
            this.btn儲存訂單.Size = new System.Drawing.Size(171, 41);
            this.btn儲存訂單.TabIndex = 12;
            this.btn儲存訂單.Text = "儲存訂單txt";
            this.btn儲存訂單.UseVisualStyleBackColor = true;
            this.btn儲存訂單.Click += new System.EventHandler(this.btn儲存訂單_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(658, 555);
            this.Controls.Add(this.btn儲存訂單);
            this.Controls.Add(this.btn離開);
            this.Controls.Add(this.group);
            this.Controls.Add(this.chk稅金);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所有品項);
            this.Controls.Add(this.lbl訂單總價格);
            this.Controls.Add(this.lBx訂購品項列表);
            this.Controls.Add(this.lbl訂購資料);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "冷飲店結帳單";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl訂購資料;
        private System.Windows.Forms.ListBox lBx訂購品項列表;
        private System.Windows.Forms.Label lbl訂單總價格;
        private System.Windows.Forms.Button btn移除所有品項;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.CheckBox chk稅金;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button btn離開;
        private System.Windows.Forms.Button btn儲存訂單;
    }
}