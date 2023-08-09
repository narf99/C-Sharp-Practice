
namespace CS_Regionals_2017
{
    partial class Form1
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
            this.PaydaysCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstDay = new System.Windows.Forms.CheckBox();
            this.LastDay = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.Output = new System.Windows.Forms.Label();
            this.OutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month";
            // 
            // PaydaysCheckBox
            // 
            this.PaydaysCheckBox.AutoSize = true;
            this.PaydaysCheckBox.Location = new System.Drawing.Point(76, 165);
            this.PaydaysCheckBox.Name = "PaydaysCheckBox";
            this.PaydaysCheckBox.Size = new System.Drawing.Size(99, 17);
            this.PaydaysCheckBox.TabIndex = 1;
            this.PaydaysCheckBox.Text = "Month Paydays";
            this.PaydaysCheckBox.UseVisualStyleBackColor = true;
            this.PaydaysCheckBox.CheckedChanged += new System.EventHandler(this.PaydaysCheckBox_CheckedChanged);
            // 
            // FirstDay
            // 
            this.FirstDay.AutoSize = true;
            this.FirstDay.Location = new System.Drawing.Point(179, 165);
            this.FirstDay.Name = "FirstDay";
            this.FirstDay.Size = new System.Drawing.Size(112, 17);
            this.FirstDay.TabIndex = 2;
            this.FirstDay.Text = "First Business Day";
            this.FirstDay.UseVisualStyleBackColor = true;
            this.FirstDay.CheckedChanged += new System.EventHandler(this.FirstDay_CheckedChanged);
            // 
            // LastDay
            // 
            this.LastDay.AutoSize = true;
            this.LastDay.Location = new System.Drawing.Point(303, 165);
            this.LastDay.Name = "LastDay";
            this.LastDay.Size = new System.Drawing.Size(113, 17);
            this.LastDay.TabIndex = 3;
            this.LastDay.Text = "Last Business Day";
            this.LastDay.UseVisualStyleBackColor = true;
            this.LastDay.CheckedChanged += new System.EventHandler(this.LastDay_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(251, 74);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(100, 20);
            this.YearBox.TabIndex = 5;
            this.YearBox.TextChanged += new System.EventHandler(this.YearBox_TextChanged);
            // 
            // MonthBox
            // 
            this.MonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Items.AddRange(new object[] {
            "",
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthBox.Location = new System.Drawing.Point(108, 74);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(121, 21);
            this.MonthBox.TabIndex = 6;
            this.MonthBox.SelectedIndexChanged += new System.EventHandler(this.MonthBox_SelectedIndexChanged);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(192, 200);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 7;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(107, 352);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(303, 352);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output";
            // 
            // OutputPanel
            // 
            this.OutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPanel.Controls.Add(this.Output);
            this.OutputPanel.Location = new System.Drawing.Point(67, 249);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(349, 100);
            this.OutputPanel.TabIndex = 11;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(4, 4);
            this.Output.MaximumSize = new System.Drawing.Size(349, 100);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 385);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastDay);
            this.Controls.Add(this.FirstDay);
            this.Controls.Add(this.PaydaysCheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BPA State - CS_2017_REG_00051589";
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox PaydaysCheckBox;
        private System.Windows.Forms.CheckBox FirstDay;
        private System.Windows.Forms.CheckBox LastDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label Output;
    }
}

