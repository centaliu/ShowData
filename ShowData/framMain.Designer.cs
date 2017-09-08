namespace ShowData
{
    partial class framMain
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabVWXYZ = new System.Windows.Forms.TabPage();
            this.tabSTU = new System.Windows.Forms.TabPage();
            this.tabPQR = new System.Windows.Forms.TabPage();
            this.tabMNO = new System.Windows.Forms.TabPage();
            this.tabJKL = new System.Windows.Forms.TabPage();
            this.tabGHI = new System.Windows.Forms.TabPage();
            this.tabDEF = new System.Windows.Forms.TabPage();
            this.tabABC = new System.Windows.Forms.TabPage();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 594);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 34);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tabVWXYZ
            // 
            this.tabVWXYZ.Location = new System.Drawing.Point(4, 22);
            this.tabVWXYZ.Name = "tabVWXYZ";
            this.tabVWXYZ.Size = new System.Drawing.Size(1264, 396);
            this.tabVWXYZ.TabIndex = 7;
            this.tabVWXYZ.Text = "VWXYZ";
            this.tabVWXYZ.UseVisualStyleBackColor = true;
            // 
            // tabSTU
            // 
            this.tabSTU.Location = new System.Drawing.Point(4, 22);
            this.tabSTU.Name = "tabSTU";
            this.tabSTU.Size = new System.Drawing.Size(1264, 396);
            this.tabSTU.TabIndex = 6;
            this.tabSTU.Text = "STU";
            this.tabSTU.UseVisualStyleBackColor = true;
            // 
            // tabPQR
            // 
            this.tabPQR.Location = new System.Drawing.Point(4, 22);
            this.tabPQR.Name = "tabPQR";
            this.tabPQR.Size = new System.Drawing.Size(1264, 396);
            this.tabPQR.TabIndex = 5;
            this.tabPQR.Text = "PQR";
            this.tabPQR.UseVisualStyleBackColor = true;
            // 
            // tabMNO
            // 
            this.tabMNO.Location = new System.Drawing.Point(4, 22);
            this.tabMNO.Name = "tabMNO";
            this.tabMNO.Size = new System.Drawing.Size(1264, 396);
            this.tabMNO.TabIndex = 4;
            this.tabMNO.Text = "MNO";
            this.tabMNO.UseVisualStyleBackColor = true;
            // 
            // tabJKL
            // 
            this.tabJKL.Location = new System.Drawing.Point(4, 22);
            this.tabJKL.Name = "tabJKL";
            this.tabJKL.Size = new System.Drawing.Size(1264, 396);
            this.tabJKL.TabIndex = 3;
            this.tabJKL.Text = "JKL";
            this.tabJKL.UseVisualStyleBackColor = true;
            // 
            // tabGHI
            // 
            this.tabGHI.Location = new System.Drawing.Point(4, 22);
            this.tabGHI.Name = "tabGHI";
            this.tabGHI.Padding = new System.Windows.Forms.Padding(3);
            this.tabGHI.Size = new System.Drawing.Size(1264, 396);
            this.tabGHI.TabIndex = 2;
            this.tabGHI.Text = "GHI";
            this.tabGHI.UseVisualStyleBackColor = true;
            // 
            // tabDEF
            // 
            this.tabDEF.Location = new System.Drawing.Point(4, 22);
            this.tabDEF.Name = "tabDEF";
            this.tabDEF.Padding = new System.Windows.Forms.Padding(3);
            this.tabDEF.Size = new System.Drawing.Size(1264, 396);
            this.tabDEF.TabIndex = 1;
            this.tabDEF.Text = "DEF";
            this.tabDEF.UseVisualStyleBackColor = true;
            // 
            // tabABC
            // 
            this.tabABC.Location = new System.Drawing.Point(4, 22);
            this.tabABC.Name = "tabABC";
            this.tabABC.Padding = new System.Windows.Forms.Padding(3);
            this.tabABC.Size = new System.Drawing.Size(1264, 541);
            this.tabABC.TabIndex = 0;
            this.tabABC.Text = "ABC";
            this.tabABC.UseVisualStyleBackColor = true;
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabABC);
            this.tabCtrl.Controls.Add(this.tabDEF);
            this.tabCtrl.Controls.Add(this.tabGHI);
            this.tabCtrl.Controls.Add(this.tabJKL);
            this.tabCtrl.Controls.Add(this.tabMNO);
            this.tabCtrl.Controls.Add(this.tabPQR);
            this.tabCtrl.Controls.Add(this.tabSTU);
            this.tabCtrl.Controls.Add(this.tabVWXYZ);
            this.tabCtrl.Location = new System.Drawing.Point(12, 21);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1272, 567);
            this.tabCtrl.TabIndex = 1;
            // 
            // framMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 640);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.btnLoad);
            this.MaximizeBox = false;
            this.Name = "framMain";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.framMain_Load);
            this.tabCtrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabPage tabVWXYZ;
        private System.Windows.Forms.TabPage tabSTU;
        private System.Windows.Forms.TabPage tabPQR;
        private System.Windows.Forms.TabPage tabMNO;
        private System.Windows.Forms.TabPage tabJKL;
        private System.Windows.Forms.TabPage tabGHI;
        private System.Windows.Forms.TabPage tabDEF;
        private System.Windows.Forms.TabPage tabABC;
        private System.Windows.Forms.TabControl tabCtrl;
    }
}

