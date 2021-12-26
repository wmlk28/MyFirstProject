namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEXECTYPE = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCRONDAY = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCRONDAYWEEK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCRONDAYMONTH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCRONMONTH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCRONEXPRESS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEXECISINTERVAL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCRONHOUR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCRONMINTS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCRONSECDS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "更新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "业务接口";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cmbEXECTYPE);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(31, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 196);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "定时接口";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "执行频率：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEXECTYPE
            // 
            this.cmbEXECTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEXECTYPE.FormattingEnabled = true;
            this.cmbEXECTYPE.Items.AddRange(new object[] {
            "天",
            "周",
            "月",
            "自定义"});
            this.cmbEXECTYPE.Location = new System.Drawing.Point(106, 40);
            this.cmbEXECTYPE.Name = "cmbEXECTYPE";
            this.cmbEXECTYPE.Size = new System.Drawing.Size(121, 23);
            this.cmbEXECTYPE.TabIndex = 1;
            this.cmbEXECTYPE.SelectedIndexChanged += new System.EventHandler(this.cmbEXECTYPE_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCRONDAY);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(28, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "天";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "每几天：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCRONDAY
            // 
            this.txtCRONDAY.Location = new System.Drawing.Point(78, 42);
            this.txtCRONDAY.Name = "txtCRONDAY";
            this.txtCRONDAY.Size = new System.Drawing.Size(116, 25);
            this.txtCRONDAY.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCRONDAYWEEK);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(257, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 75);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "周";
            // 
            // txtCRONDAYWEEK
            // 
            this.txtCRONDAYWEEK.Location = new System.Drawing.Point(78, 42);
            this.txtCRONDAYWEEK.Name = "txtCRONDAYWEEK";
            this.txtCRONDAYWEEK.Size = new System.Drawing.Size(116, 25);
            this.txtCRONDAYWEEK.TabIndex = 4;
            this.txtCRONDAYWEEK.Text = "1,2,3,4,5,6,7";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "频率：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCRONMONTH);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtCRONDAYMONTH);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(439, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(416, 80);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "月";
            // 
            // txtCRONDAYMONTH
            // 
            this.txtCRONDAYMONTH.Location = new System.Drawing.Point(78, 42);
            this.txtCRONDAYMONTH.Name = "txtCRONDAYMONTH";
            this.txtCRONDAYMONTH.Size = new System.Drawing.Size(116, 25);
            this.txtCRONDAYMONTH.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "第几天：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCRONMONTH
            // 
            this.txtCRONMONTH.Location = new System.Drawing.Point(278, 42);
            this.txtCRONMONTH.Name = "txtCRONMONTH";
            this.txtCRONMONTH.Size = new System.Drawing.Size(116, 25);
            this.txtCRONMONTH.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(208, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "每月：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtCRONEXPRESS);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(517, 92);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(208, 59);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "自定义";
            // 
            // txtCRONEXPRESS
            // 
            this.txtCRONEXPRESS.Location = new System.Drawing.Point(121, 32);
            this.txtCRONEXPRESS.Name = "txtCRONEXPRESS";
            this.txtCRONEXPRESS.Size = new System.Drawing.Size(208, 25);
            this.txtCRONEXPRESS.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "CRON表达式：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEXECISINTERVAL
            // 
            this.cmbEXECISINTERVAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEXECISINTERVAL.FormattingEnabled = true;
            this.cmbEXECISINTERVAL.Items.AddRange(new object[] {
            "间隔重复",
            "仅一次"});
            this.cmbEXECISINTERVAL.Location = new System.Drawing.Point(110, 374);
            this.cmbEXECISINTERVAL.Name = "cmbEXECISINTERVAL";
            this.cmbEXECISINTERVAL.Size = new System.Drawing.Size(121, 23);
            this.cmbEXECISINTERVAL.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(29, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "每天频率：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCRONHOUR
            // 
            this.txtCRONHOUR.Location = new System.Drawing.Point(293, 375);
            this.txtCRONHOUR.Name = "txtCRONHOUR";
            this.txtCRONHOUR.Size = new System.Drawing.Size(99, 25);
            this.txtCRONHOUR.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(259, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "时：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCRONMINTS
            // 
            this.txtCRONMINTS.Location = new System.Drawing.Point(454, 375);
            this.txtCRONMINTS.Name = "txtCRONMINTS";
            this.txtCRONMINTS.Size = new System.Drawing.Size(99, 25);
            this.txtCRONMINTS.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(420, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "分：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCRONSECDS
            // 
            this.txtCRONSECDS.Location = new System.Drawing.Point(606, 375);
            this.txtCRONSECDS.Name = "txtCRONSECDS";
            this.txtCRONSECDS.Size = new System.Drawing.Size(99, 25);
            this.txtCRONSECDS.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(572, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "秒：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(262, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 42);
            this.button4.TabIndex = 13;
            this.button4.Text = "确定添加";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(381, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 46);
            this.button5.TabIndex = 14;
            this.button5.Text = "删除任务";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(548, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(116, 25);
            this.txtId.TabIndex = 16;
            this.txtId.Text = "666";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(505, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "id：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 426);
            this.Controls.Add(this.txtCRONSECDS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCRONMINTS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCRONHOUR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEXECISINTERVAL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEXECTYPE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCRONDAY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCRONDAYWEEK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCRONMONTH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCRONDAYMONTH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtCRONEXPRESS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEXECISINTERVAL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCRONHOUR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCRONMINTS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCRONSECDS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
    }
}

