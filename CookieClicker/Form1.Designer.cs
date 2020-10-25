namespace CookieClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.infoPanel = new System.Windows.Forms.Panel();
            this.cookieCntLbl = new System.Windows.Forms.Label();
            this.cookieLbl = new System.Windows.Forms.Label();
            this.buyPanel = new System.Windows.Forms.Panel();
            this.FactoryCntLbl = new System.Windows.Forms.Label();
            this.MineCntLbl = new System.Windows.Forms.Label();
            this.FarmCntLbl = new System.Windows.Forms.Label();
            this.grannyCntLbl = new System.Windows.Forms.Label();
            this.cursorCntLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grannyTxt = new System.Windows.Forms.Label();
            this.cursorCntTxt = new System.Windows.Forms.Label();
            this.ImprovementsLbl = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.cookieBtn = new System.Windows.Forms.Button();
            this.CookiePanel = new System.Windows.Forms.Panel();
            this.cursorsBtn = new System.Windows.Forms.Button();
            this.grannyBtn = new System.Windows.Forms.Button();
            this.farmBtn = new System.Windows.Forms.Button();
            this.MineBtn = new System.Windows.Forms.Button();
            this.factoryBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.infoPanel.SuspendLayout();
            this.buyPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.CookiePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.cookieCntLbl);
            this.infoPanel.Controls.Add(this.cookieLbl);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(200, 450);
            this.infoPanel.TabIndex = 0;
            // 
            // cookieCntLbl
            // 
            this.cookieCntLbl.AutoSize = true;
            this.cookieCntLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cookieCntLbl.Location = new System.Drawing.Point(57, 54);
            this.cookieCntLbl.Name = "cookieCntLbl";
            this.cookieCntLbl.Size = new System.Drawing.Size(38, 45);
            this.cookieCntLbl.TabIndex = 0;
            this.cookieCntLbl.Text = "0";
            this.cookieCntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cookieLbl
            // 
            this.cookieLbl.AutoSize = true;
            this.cookieLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cookieLbl.Location = new System.Drawing.Point(3, 9);
            this.cookieLbl.Name = "cookieLbl";
            this.cookieLbl.Size = new System.Drawing.Size(147, 45);
            this.cookieLbl.TabIndex = 0;
            this.cookieLbl.Text = "Cookies:";
            // 
            // buyPanel
            // 
            this.buyPanel.Controls.Add(this.FactoryCntLbl);
            this.buyPanel.Controls.Add(this.MineCntLbl);
            this.buyPanel.Controls.Add(this.FarmCntLbl);
            this.buyPanel.Controls.Add(this.grannyCntLbl);
            this.buyPanel.Controls.Add(this.cursorCntLbl);
            this.buyPanel.Controls.Add(this.label4);
            this.buyPanel.Controls.Add(this.label3);
            this.buyPanel.Controls.Add(this.label2);
            this.buyPanel.Controls.Add(this.grannyTxt);
            this.buyPanel.Controls.Add(this.cursorCntTxt);
            this.buyPanel.Controls.Add(this.ImprovementsLbl);
            this.buyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buyPanel.Location = new System.Drawing.Point(600, 0);
            this.buyPanel.Name = "buyPanel";
            this.buyPanel.Size = new System.Drawing.Size(200, 450);
            this.buyPanel.TabIndex = 1;
            // 
            // FactoryCntLbl
            // 
            this.FactoryCntLbl.AutoSize = true;
            this.FactoryCntLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FactoryCntLbl.Location = new System.Drawing.Point(159, 174);
            this.FactoryCntLbl.Name = "FactoryCntLbl";
            this.FactoryCntLbl.Size = new System.Drawing.Size(19, 21);
            this.FactoryCntLbl.TabIndex = 0;
            this.FactoryCntLbl.Text = "0";
            // 
            // MineCntLbl
            // 
            this.MineCntLbl.AutoSize = true;
            this.MineCntLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MineCntLbl.Location = new System.Drawing.Point(159, 144);
            this.MineCntLbl.Name = "MineCntLbl";
            this.MineCntLbl.Size = new System.Drawing.Size(19, 21);
            this.MineCntLbl.TabIndex = 0;
            this.MineCntLbl.Text = "0";
            // 
            // FarmCntLbl
            // 
            this.FarmCntLbl.AutoSize = true;
            this.FarmCntLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FarmCntLbl.Location = new System.Drawing.Point(159, 114);
            this.FarmCntLbl.Name = "FarmCntLbl";
            this.FarmCntLbl.Size = new System.Drawing.Size(19, 21);
            this.FarmCntLbl.TabIndex = 0;
            this.FarmCntLbl.Text = "0";
            // 
            // grannyCntLbl
            // 
            this.grannyCntLbl.AutoSize = true;
            this.grannyCntLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grannyCntLbl.Location = new System.Drawing.Point(159, 84);
            this.grannyCntLbl.Name = "grannyCntLbl";
            this.grannyCntLbl.Size = new System.Drawing.Size(19, 21);
            this.grannyCntLbl.TabIndex = 0;
            this.grannyCntLbl.Text = "0";
            // 
            // cursorCntLbl
            // 
            this.cursorCntLbl.AutoSize = true;
            this.cursorCntLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cursorCntLbl.Location = new System.Drawing.Point(159, 54);
            this.cursorCntLbl.Name = "cursorCntLbl";
            this.cursorCntLbl.Size = new System.Drawing.Size(19, 21);
            this.cursorCntLbl.TabIndex = 0;
            this.cursorCntLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Factory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Farm";
            // 
            // grannyTxt
            // 
            this.grannyTxt.AutoSize = true;
            this.grannyTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grannyTxt.Location = new System.Drawing.Point(23, 84);
            this.grannyTxt.Name = "grannyTxt";
            this.grannyTxt.Size = new System.Drawing.Size(65, 21);
            this.grannyTxt.TabIndex = 0;
            this.grannyTxt.Text = "Granny";
            // 
            // cursorCntTxt
            // 
            this.cursorCntTxt.AutoSize = true;
            this.cursorCntTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cursorCntTxt.Location = new System.Drawing.Point(23, 54);
            this.cursorCntTxt.Name = "cursorCntTxt";
            this.cursorCntTxt.Size = new System.Drawing.Size(66, 21);
            this.cursorCntTxt.TabIndex = 0;
            this.cursorCntTxt.Text = "Cursors";
            // 
            // ImprovementsLbl
            // 
            this.ImprovementsLbl.AutoSize = true;
            this.ImprovementsLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImprovementsLbl.Location = new System.Drawing.Point(23, 9);
            this.ImprovementsLbl.Name = "ImprovementsLbl";
            this.ImprovementsLbl.Size = new System.Drawing.Size(155, 30);
            this.ImprovementsLbl.TabIndex = 0;
            this.ImprovementsLbl.Text = "Improvements";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.factoryBtn);
            this.bottomPanel.Controls.Add(this.MineBtn);
            this.bottomPanel.Controls.Add(this.farmBtn);
            this.bottomPanel.Controls.Add(this.grannyBtn);
            this.bottomPanel.Controls.Add(this.cursorsBtn);
            this.bottomPanel.Controls.Add(this.label9);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(200, 250);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(400, 200);
            this.bottomPanel.TabIndex = 2;
            // 
            // cookieBtn
            // 
            this.cookieBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cookieBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cookieBtn.BackgroundImage")));
            this.cookieBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cookieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cookieBtn.Location = new System.Drawing.Point(167, 84);
            this.cookieBtn.Name = "cookieBtn";
            this.cookieBtn.Size = new System.Drawing.Size(50, 50);
            this.cookieBtn.TabIndex = 3;
            this.cookieBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cookieBtn.UseVisualStyleBackColor = true;
            this.cookieBtn.Click += new System.EventHandler(this.cookieBtn_Click);
            // 
            // CookiePanel
            // 
            this.CookiePanel.Controls.Add(this.cookieBtn);
            this.CookiePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CookiePanel.Location = new System.Drawing.Point(200, 0);
            this.CookiePanel.Name = "CookiePanel";
            this.CookiePanel.Size = new System.Drawing.Size(400, 250);
            this.CookiePanel.TabIndex = 3;
            // 
            // cursorsBtn
            // 
            this.cursorsBtn.Location = new System.Drawing.Point(76, 79);
            this.cursorsBtn.Name = "cursorsBtn";
            this.cursorsBtn.Size = new System.Drawing.Size(75, 23);
            this.cursorsBtn.TabIndex = 0;
            this.cursorsBtn.Text = "Cursors";
            this.cursorsBtn.UseVisualStyleBackColor = true;
            this.cursorsBtn.Click += new System.EventHandler(this.cursorsBtn_Click);
            // 
            // grannyBtn
            // 
            this.grannyBtn.Location = new System.Drawing.Point(167, 79);
            this.grannyBtn.Name = "grannyBtn";
            this.grannyBtn.Size = new System.Drawing.Size(75, 23);
            this.grannyBtn.TabIndex = 0;
            this.grannyBtn.Text = "Granny";
            this.grannyBtn.UseVisualStyleBackColor = true;
            this.grannyBtn.Click += new System.EventHandler(this.grannyBtn_Click);
            // 
            // farmBtn
            // 
            this.farmBtn.Location = new System.Drawing.Point(260, 79);
            this.farmBtn.Name = "farmBtn";
            this.farmBtn.Size = new System.Drawing.Size(75, 23);
            this.farmBtn.TabIndex = 0;
            this.farmBtn.Text = "Farm";
            this.farmBtn.UseVisualStyleBackColor = true;
            this.farmBtn.Click += new System.EventHandler(this.farmBtn_Click);
            // 
            // MineBtn
            // 
            this.MineBtn.Location = new System.Drawing.Point(76, 126);
            this.MineBtn.Name = "MineBtn";
            this.MineBtn.Size = new System.Drawing.Size(75, 23);
            this.MineBtn.TabIndex = 0;
            this.MineBtn.Text = "Mine";
            this.MineBtn.UseVisualStyleBackColor = true;
            this.MineBtn.Click += new System.EventHandler(this.MineBtn_Click);
            // 
            // factoryBtn
            // 
            this.factoryBtn.Location = new System.Drawing.Point(167, 126);
            this.factoryBtn.Name = "factoryBtn";
            this.factoryBtn.Size = new System.Drawing.Size(75, 23);
            this.factoryBtn.TabIndex = 0;
            this.factoryBtn.Text = "Factory";
            this.factoryBtn.UseVisualStyleBackColor = true;
            this.factoryBtn.Click += new System.EventHandler(this.factoryBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(167, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Buy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CookiePanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.buyPanel);
            this.Controls.Add(this.infoPanel);
            this.Name = "Form1";
            this.Text = "CookieClicker";
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.buyPanel.ResumeLayout(false);
            this.buyPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.CookiePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel buyPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button cookieBtn;
        private System.Windows.Forms.Label cookieCntLbl;
        private System.Windows.Forms.Label cookieLbl;
        private System.Windows.Forms.Panel CookiePanel;
        private System.Windows.Forms.Label FactoryCntLbl;
        private System.Windows.Forms.Label MineCntLbl;
        private System.Windows.Forms.Label FarmCntLbl;
        private System.Windows.Forms.Label grannyCntLbl;
        private System.Windows.Forms.Label cursorCntLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label grannyTxt;
        private System.Windows.Forms.Label cursorCntTxt;
        private System.Windows.Forms.Label ImprovementsLbl;
        private System.Windows.Forms.Button factoryBtn;
        private System.Windows.Forms.Button MineBtn;
        private System.Windows.Forms.Button farmBtn;
        private System.Windows.Forms.Button grannyBtn;
        private System.Windows.Forms.Button cursorsBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
    }
}

