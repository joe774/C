
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.lbl品項總價 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.tBx數量 = new System.Windows.Forms.TextBox();
            this.btn加入訂購單 = new System.Windows.Forms.Button();
            this.btn查看訂購單 = new System.Windows.Forms.Button();
            this.lBx冷飲品項 = new System.Windows.Forms.ListBox();
            this.cbx甜度 = new System.Windows.Forms.ComboBox();
            this.cbx冰塊 = new System.Windows.Forms.ComboBox();
            this.lBx配料 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(242, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "冷飲店訂購單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "訂購人(電話)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(41, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "冷飲品項";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(374, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "甜度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(374, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "冰塊";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(374, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "配料";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(22, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "數量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(213, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "單價";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(399, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "品項總價";
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl單價.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(242, 491);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(97, 27);
            this.lbl單價.TabIndex = 9;
            this.lbl單價.Text = "XXX元";
            // 
            // lbl品項總價
            // 
            this.lbl品項總價.AutoSize = true;
            this.lbl品項總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl品項總價.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl品項總價.Location = new System.Drawing.Point(458, 491);
            this.lbl品項總價.Name = "lbl品項總價";
            this.lbl品項總價.Size = new System.Drawing.Size(97, 27);
            this.lbl品項總價.TabIndex = 10;
            this.lbl品項總價.Text = "XXX元";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(105, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 27);
            this.label12.TabIndex = 11;
            this.label12.Text = "杯";
            // 
            // txt訂購人
            // 
            this.txt訂購人.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂購人.Location = new System.Drawing.Point(27, 125);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(225, 40);
            this.txt訂購人.TabIndex = 12;
            // 
            // tBx數量
            // 
            this.tBx數量.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tBx數量.Location = new System.Drawing.Point(21, 488);
            this.tBx數量.Name = "tBx數量";
            this.tBx數量.Size = new System.Drawing.Size(78, 40);
            this.tBx數量.TabIndex = 13;
            this.tBx數量.TextChanged += new System.EventHandler(this.tBx數量_TextChanged);
            // 
            // btn加入訂購單
            // 
            this.btn加入訂購單.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂購單.Location = new System.Drawing.Point(180, 551);
            this.btn加入訂購單.Name = "btn加入訂購單";
            this.btn加入訂購單.Size = new System.Drawing.Size(182, 40);
            this.btn加入訂購單.TabIndex = 14;
            this.btn加入訂購單.Text = "加入訂購單";
            this.btn加入訂購單.UseVisualStyleBackColor = true;
            this.btn加入訂購單.Click += new System.EventHandler(this.btn加入訂購單_Click);
            // 
            // btn查看訂購單
            // 
            this.btn查看訂購單.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查看訂購單.Location = new System.Drawing.Point(388, 551);
            this.btn查看訂購單.Name = "btn查看訂購單";
            this.btn查看訂購單.Size = new System.Drawing.Size(182, 40);
            this.btn查看訂購單.TabIndex = 15;
            this.btn查看訂購單.Text = "查看訂購單";
            this.btn查看訂購單.UseVisualStyleBackColor = true;
            this.btn查看訂購單.Click += new System.EventHandler(this.btn查看訂購單_Click);
            // 
            // lBx冷飲品項
            // 
            this.lBx冷飲品項.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBx冷飲品項.FormattingEnabled = true;
            this.lBx冷飲品項.ItemHeight = 24;
            this.lBx冷飲品項.Location = new System.Drawing.Point(27, 221);
            this.lBx冷飲品項.Name = "lBx冷飲品項";
            this.lBx冷飲品項.Size = new System.Drawing.Size(312, 196);
            this.lBx冷飲品項.TabIndex = 17;
            this.lBx冷飲品項.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lBx冷飲品項_DrawItem);
            this.lBx冷飲品項.SelectedIndexChanged += new System.EventHandler(this.lBx冷飲品項_SelectedIndexChanged);
            // 
            // cbx甜度
            // 
            this.cbx甜度.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx甜度.FormattingEnabled = true;
            this.cbx甜度.Location = new System.Drawing.Point(404, 155);
            this.cbx甜度.Name = "cbx甜度";
            this.cbx甜度.Size = new System.Drawing.Size(151, 32);
            this.cbx甜度.TabIndex = 18;
            this.cbx甜度.SelectedIndexChanged += new System.EventHandler(this.cbx甜度_SelectedIndexChanged);
            // 
            // cbx冰塊
            // 
            this.cbx冰塊.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx冰塊.FormattingEnabled = true;
            this.cbx冰塊.Location = new System.Drawing.Point(404, 221);
            this.cbx冰塊.Name = "cbx冰塊";
            this.cbx冰塊.Size = new System.Drawing.Size(151, 32);
            this.cbx冰塊.TabIndex = 19;
            this.cbx冰塊.SelectedIndexChanged += new System.EventHandler(this.cbx冰塊_SelectedIndexChanged);
            // 
            // lBx配料
            // 
            this.lBx配料.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBx配料.FormattingEnabled = true;
            this.lBx配料.ItemHeight = 21;
            this.lBx配料.Location = new System.Drawing.Point(388, 287);
            this.lBx配料.Name = "lBx配料";
            this.lBx配料.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBx配料.Size = new System.Drawing.Size(182, 130);
            this.lBx配料.TabIndex = 20;
            this.lBx配料.SelectedIndexChanged += new System.EventHandler(this.lBx配料_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(599, 618);
            this.Controls.Add(this.lBx配料);
            this.Controls.Add(this.cbx冰塊);
            this.Controls.Add(this.cbx甜度);
            this.Controls.Add(this.lBx冷飲品項);
            this.Controls.Add(this.btn查看訂購單);
            this.Controls.Add(this.btn加入訂購單);
            this.Controls.Add(this.tBx數量);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl品項總價);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "冷飲店訂購單";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label lbl品項總價;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.TextBox tBx數量;
        private System.Windows.Forms.Button btn加入訂購單;
        private System.Windows.Forms.Button btn查看訂購單;
        private System.Windows.Forms.ListBox lBx冷飲品項;
        private System.Windows.Forms.ComboBox cbx甜度;
        private System.Windows.Forms.ComboBox cbx冰塊;
        private System.Windows.Forms.ListBox lBx配料;
    }
}

