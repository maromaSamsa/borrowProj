
namespace borrowProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button nameSubmitButton;
            this.inputMyNameLebel = new System.Windows.Forms.Label();
            this.inputFriendNameLebel = new System.Windows.Forms.Label();
            this.inputMyNameTextbox = new System.Windows.Forms.TextBox();
            this.inputFriendNameTextbox = new System.Windows.Forms.TextBox();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.friendNameLabel = new System.Windows.Forms.Label();
            this.myName = new System.Windows.Forms.Label();
            this.friendName = new System.Windows.Forms.Label();
            this.myCapitalLebel = new System.Windows.Forms.Label();
            this.friendCapitalLebel = new System.Windows.Forms.Label();
            this.myCapital = new System.Windows.Forms.Label();
            this.friendCapital = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.paybackButton = new System.Windows.Forms.Button();
            nameSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameSubmitButton
            // 
            nameSubmitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nameSubmitButton.Location = new System.Drawing.Point(425, 36);
            nameSubmitButton.Name = "nameSubmitButton";
            nameSubmitButton.Size = new System.Drawing.Size(75, 66);
            nameSubmitButton.TabIndex = 15;
            nameSubmitButton.Text = "確認";
            nameSubmitButton.UseVisualStyleBackColor = true;
            nameSubmitButton.Click += new System.EventHandler(this.nameSubmitButton_Click);
            // 
            // inputMyNameLebel
            // 
            this.inputMyNameLebel.AutoSize = true;
            this.inputMyNameLebel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputMyNameLebel.Location = new System.Drawing.Point(52, 35);
            this.inputMyNameLebel.Name = "inputMyNameLebel";
            this.inputMyNameLebel.Size = new System.Drawing.Size(121, 20);
            this.inputMyNameLebel.TabIndex = 1;
            this.inputMyNameLebel.Text = "輸入我的名字：";
            // 
            // inputFriendNameLebel
            // 
            this.inputFriendNameLebel.AutoSize = true;
            this.inputFriendNameLebel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputFriendNameLebel.Location = new System.Drawing.Point(52, 78);
            this.inputFriendNameLebel.Name = "inputFriendNameLebel";
            this.inputFriendNameLebel.Size = new System.Drawing.Size(137, 20);
            this.inputFriendNameLebel.TabIndex = 2;
            this.inputFriendNameLebel.Text = "輸入朋友的名字；";
            this.inputFriendNameLebel.Click += new System.EventHandler(this.inputFriendNameLebel_Click);
            // 
            // inputMyNameTextbox
            // 
            this.inputMyNameTextbox.Location = new System.Drawing.Point(201, 35);
            this.inputMyNameTextbox.Name = "inputMyNameTextbox";
            this.inputMyNameTextbox.Size = new System.Drawing.Size(187, 23);
            this.inputMyNameTextbox.TabIndex = 3;
            // 
            // inputFriendNameTextbox
            // 
            this.inputFriendNameTextbox.Location = new System.Drawing.Point(201, 79);
            this.inputFriendNameTextbox.Name = "inputFriendNameTextbox";
            this.inputFriendNameTextbox.Size = new System.Drawing.Size(187, 23);
            this.inputFriendNameTextbox.TabIndex = 4;
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myNameLabel.Location = new System.Drawing.Point(52, 146);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(93, 20);
            this.myNameLabel.TabIndex = 5;
            this.myNameLabel.Text = "我的名字： ";
            this.myNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // friendNameLabel
            // 
            this.friendNameLabel.AutoSize = true;
            this.friendNameLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendNameLabel.Location = new System.Drawing.Point(279, 146);
            this.friendNameLabel.Name = "friendNameLabel";
            this.friendNameLabel.Size = new System.Drawing.Size(109, 20);
            this.friendNameLabel.TabIndex = 6;
            this.friendNameLabel.Text = "朋友的名字： ";
            // 
            // myName
            // 
            this.myName.AutoSize = true;
            this.myName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myName.Location = new System.Drawing.Point(161, 146);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(57, 20);
            this.myName.TabIndex = 7;
            this.myName.Text = "無名氏";
            // 
            // friendName
            // 
            this.friendName.AutoSize = true;
            this.friendName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendName.Location = new System.Drawing.Point(404, 146);
            this.friendName.Name = "friendName";
            this.friendName.Size = new System.Drawing.Size(57, 20);
            this.friendName.TabIndex = 8;
            this.friendName.Text = "無名氏";
            // 
            // myCapitalLebel
            // 
            this.myCapitalLebel.AutoSize = true;
            this.myCapitalLebel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myCapitalLebel.Location = new System.Drawing.Point(52, 194);
            this.myCapitalLebel.Name = "myCapitalLebel";
            this.myCapitalLebel.Size = new System.Drawing.Size(79, 20);
            this.myCapitalLebel.TabIndex = 9;
            this.myCapitalLebel.Text = "我的$$： ";
            // 
            // friendCapitalLebel
            // 
            this.friendCapitalLebel.AutoSize = true;
            this.friendCapitalLebel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendCapitalLebel.Location = new System.Drawing.Point(279, 194);
            this.friendCapitalLebel.Name = "friendCapitalLebel";
            this.friendCapitalLebel.Size = new System.Drawing.Size(111, 20);
            this.friendCapitalLebel.TabIndex = 10;
            this.friendCapitalLebel.Text = "朋友的的$$： ";
            // 
            // myCapital
            // 
            this.myCapital.AutoSize = true;
            this.myCapital.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myCapital.Location = new System.Drawing.Point(161, 194);
            this.myCapital.Name = "myCapital";
            this.myCapital.Size = new System.Drawing.Size(18, 20);
            this.myCapital.TabIndex = 11;
            this.myCapital.Text = "0";
            // 
            // friendCapital
            // 
            this.friendCapital.AutoSize = true;
            this.friendCapital.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.friendCapital.Location = new System.Drawing.Point(404, 194);
            this.friendCapital.Name = "friendCapital";
            this.friendCapital.Size = new System.Drawing.Size(18, 20);
            this.friendCapital.TabIndex = 12;
            this.friendCapital.Text = "0";
            // 
            // borrowButton
            // 
            this.borrowButton.Enabled = false;
            this.borrowButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowButton.Location = new System.Drawing.Point(52, 248);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(448, 50);
            this.borrowButton.TabIndex = 13;
            this.borrowButton.Text = "向 XXX 借 OOO 元";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // paybackButton
            // 
            this.paybackButton.Enabled = false;
            this.paybackButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paybackButton.Location = new System.Drawing.Point(52, 316);
            this.paybackButton.Name = "paybackButton";
            this.paybackButton.Size = new System.Drawing.Size(448, 50);
            this.paybackButton.TabIndex = 14;
            this.paybackButton.Text = "還 XXX  OOO 元";
            this.paybackButton.UseVisualStyleBackColor = true;
            this.paybackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 390);
            this.Controls.Add(nameSubmitButton);
            this.Controls.Add(this.paybackButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.friendCapital);
            this.Controls.Add(this.myCapital);
            this.Controls.Add(this.friendCapitalLebel);
            this.Controls.Add(this.myCapitalLebel);
            this.Controls.Add(this.friendName);
            this.Controls.Add(this.myName);
            this.Controls.Add(this.friendNameLabel);
            this.Controls.Add(this.myNameLabel);
            this.Controls.Add(this.inputFriendNameTextbox);
            this.Controls.Add(this.inputMyNameTextbox);
            this.Controls.Add(this.inputFriendNameLebel);
            this.Controls.Add(this.inputMyNameLebel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inputMyNameLebel;
        private System.Windows.Forms.Label inputFriendNameLebel;
        private System.Windows.Forms.TextBox inputMyNameTextbox;
        private System.Windows.Forms.TextBox inputFriendNameTextbox;
        private System.Windows.Forms.Label myNameLabel;
        private System.Windows.Forms.Label friendNameLabel;
        private System.Windows.Forms.Label myName;
        private System.Windows.Forms.Label friendName;
        private System.Windows.Forms.Label myCapitalLebel;
        private System.Windows.Forms.Label friendCapitalLebel;
        private System.Windows.Forms.Label myCapital;
        private System.Windows.Forms.Label friendCapital;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button paybackButton;
    }
}

