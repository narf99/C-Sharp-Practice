using System;
using System.Collections.Generic;

namespace CS_2019_Nationals
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
        
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerTxt = new System.Windows.Forms.Label();
            this.playerGold = new System.Windows.Forms.Label();
            this.shopTxt = new System.Windows.Forms.Label();
            this.shopGold = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.questBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.itemInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.ListBox();
            this.shopBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerTxt
            // 
            this.playerTxt.AutoSize = true;
            this.playerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTxt.Location = new System.Drawing.Point(8, 27);
            this.playerTxt.Name = "playerTxt";
            this.playerTxt.Size = new System.Drawing.Size(145, 51);
            this.playerTxt.TabIndex = 0;
            this.playerTxt.Text = "Player";
            // 
            // playerGold
            // 
            this.playerGold.AutoSize = true;
            this.playerGold.Location = new System.Drawing.Point(159, 57);
            this.playerGold.Name = "playerGold";
            this.playerGold.Size = new System.Drawing.Size(54, 13);
            this.playerGold.TabIndex = 1;
            this.playerGold.Text = "3000 gold";
            // 
            // shopTxt
            // 
            this.shopTxt.AutoSize = true;
            this.shopTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopTxt.Location = new System.Drawing.Point(386, 27);
            this.shopTxt.Name = "shopTxt";
            this.shopTxt.Size = new System.Drawing.Size(123, 51);
            this.shopTxt.TabIndex = 2;
            this.shopTxt.Text = "Shop";
            // 
            // shopGold
            // 
            this.shopGold.AutoSize = true;
            this.shopGold.Location = new System.Drawing.Point(515, 57);
            this.shopGold.Name = "shopGold";
            this.shopGold.Size = new System.Drawing.Size(54, 13);
            this.shopGold.TabIndex = 3;
            this.shopGold.Text = "3001 gold";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(17, 332);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(98, 332);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // questBtn
            // 
            this.questBtn.Location = new System.Drawing.Point(56, 361);
            this.questBtn.Name = "questBtn";
            this.questBtn.Size = new System.Drawing.Size(75, 23);
            this.questBtn.TabIndex = 6;
            this.questBtn.Text = "Auto-Quest";
            this.questBtn.UseVisualStyleBackColor = true;
            this.questBtn.Click += new System.EventHandler(this.questBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(209, 332);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(75, 23);
            this.buyBtn.TabIndex = 7;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(290, 332);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(75, 23);
            this.sellBtn.TabIndex = 8;
            this.sellBtn.Text = "Sell";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(247, 415);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(444, 332);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(84, 23);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Refresh Shop";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // itemInfo
            // 
            this.itemInfo.AutoSize = true;
            this.itemInfo.Location = new System.Drawing.Point(206, 267);
            this.itemInfo.Name = "itemInfo";
            this.itemInfo.Size = new System.Drawing.Size(111, 39);
            this.itemInfo.TabIndex = 13;
            this.itemInfo.Text = "Name: Bag of Holding\r\nWeight: 1\r\nValue: 200 gold";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // playerBox
            // 
            this.playerBox.FormattingEnabled = true;
            this.playerBox.Location = new System.Drawing.Point(11, 81);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(169, 238);
            this.playerBox.TabIndex = 11;
            this.playerBox.SelectedIndexChanged += new System.EventHandler(this.playerBox_SelectedIndexChanged);
            // 
            // shopBox
            // 
            this.shopBox.FormattingEnabled = true;
            this.shopBox.Location = new System.Drawing.Point(395, 81);
            this.shopBox.Name = "shopBox";
            this.shopBox.Size = new System.Drawing.Size(169, 238);
            this.shopBox.TabIndex = 12;
            this.shopBox.SelectedIndexChanged += new System.EventHandler(this.shopBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.itemInfo);
            this.Controls.Add(this.shopBox);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.questBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.shopGold);
            this.Controls.Add(this.shopTxt);
            this.Controls.Add(this.playerGold);
            this.Controls.Add(this.playerTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void updatePlayer(Character player)
        {
            playerGold.Text = player.Gold + " Gold";
            playerBox.Items.Clear();
            for (int i = player.Items.Count - 1; i >= 0; i--)
            {
                playerBox.Items.Add(player.Items[i].Name);
            }
        }

        public void updateShop(Character shop)
        {
            shopGold.Text = shop.Gold + " Gold";
            shopBox.Items.Clear();
            for (int i = shop.Items.Count - 1; i >= 0; i--)
            {
                shopBox.Items.Add(shop.Items[i].Name);
            }
        }

        #endregion

        private System.Windows.Forms.Label playerTxt;
        private System.Windows.Forms.Label playerGold;
        private System.Windows.Forms.Label shopTxt;
        private System.Windows.Forms.Label shopGold;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button questBtn;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ListBox playerBox;
        private System.Windows.Forms.ListBox shopBox;
        private System.Windows.Forms.Label itemInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

