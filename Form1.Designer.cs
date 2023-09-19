
namespace Buoi3_lab02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btndinhdang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnew = new System.Windows.Forms.ToolStripButton();
            this.btnsave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbfont = new System.Windows.Forms.ToolStripComboBox();
            this.cmbsize = new System.Windows.Forms.ToolStripComboBox();
            this.btnindam = new System.Windows.Forms.ToolStripButton();
            this.btninnghieng = new System.Windows.Forms.ToolStripButton();
            this.btngachchan = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.btndinhdang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItem1.Text = "Tạo văn bản mới";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItem2.Text = "Mở văn bản";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItem3.Text = "Lưu nội dung văn bản";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(231, 22);
            this.toolStripMenuItem4.Text = "Thoát";
            // 
            // btndinhdang
            // 
            this.btndinhdang.Name = "btndinhdang";
            this.btndinhdang.Size = new System.Drawing.Size(74, 20);
            this.btndinhdang.Text = "Định dạng";
            this.btndinhdang.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnew,
            this.btnsave,
            this.toolStripSeparator1,
            this.cmbfont,
            this.cmbsize,
            this.btnindam,
            this.btninnghieng,
            this.btngachchan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnew
            // 
            this.btnnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(23, 22);
            this.btnnew.Text = "New";
            // 
            // btnsave
            // 
            this.btnsave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(23, 22);
            this.btnsave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbfont
            // 
            this.cmbfont.Name = "cmbfont";
            this.cmbfont.Size = new System.Drawing.Size(121, 25);
            // 
            // cmbsize
            // 
            this.cmbsize.Name = "cmbsize";
            this.cmbsize.Size = new System.Drawing.Size(121, 25);
            // 
            // btnindam
            // 
            this.btnindam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnindam.Image = ((System.Drawing.Image)(resources.GetObject("btnindam.Image")));
            this.btnindam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnindam.Name = "btnindam";
            this.btnindam.Size = new System.Drawing.Size(23, 22);
            this.btnindam.Text = "In đậm";
            // 
            // btninnghieng
            // 
            this.btninnghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btninnghieng.Image = ((System.Drawing.Image)(resources.GetObject("btninnghieng.Image")));
            this.btninnghieng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btninnghieng.Name = "btninnghieng";
            this.btninnghieng.Size = new System.Drawing.Size(23, 22);
            this.btninnghieng.Text = "In nghiêng";
            // 
            // btngachchan
            // 
            this.btngachchan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btngachchan.Image = ((System.Drawing.Image)(resources.GetObject("btngachchan.Image")));
            this.btngachchan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btngachchan.Name = "btngachchan";
            this.btngachchan.Size = new System.Drawing.Size(23, 22);
            this.btngachchan.Text = "Gạch chân";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(751, 396);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btndinhdang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnew;
        private System.Windows.Forms.ToolStripButton btnsave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmbfont;
        private System.Windows.Forms.ToolStripComboBox cmbsize;
        private System.Windows.Forms.ToolStripButton btnindam;
        private System.Windows.Forms.ToolStripButton btninnghieng;
        private System.Windows.Forms.ToolStripButton btngachchan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

