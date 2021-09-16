
namespace CWA_Assessment
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
            this.label1 = new System.Windows.Forms.Label();
            this.TransactionsBTN = new System.Windows.Forms.PictureBox();
            this.trailBTN = new System.Windows.Forms.PictureBox();
            this.closeBTN = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(513, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transactions";
            // 
            // TransactionsBTN
            // 
            this.TransactionsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransactionsBTN.Image = global::CWA_Assessment.Properties.Resources.transfer_icon;
            this.TransactionsBTN.Location = new System.Drawing.Point(472, 224);
            this.TransactionsBTN.Name = "TransactionsBTN";
            this.TransactionsBTN.Size = new System.Drawing.Size(169, 94);
            this.TransactionsBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TransactionsBTN.TabIndex = 3;
            this.TransactionsBTN.TabStop = false;
            this.TransactionsBTN.Click += new System.EventHandler(this.TransactionsBTN_Click);
            this.TransactionsBTN.MouseLeave += new System.EventHandler(this.TransactionsBTN_MouseLeave);
            this.TransactionsBTN.MouseHover += new System.EventHandler(this.TransactionsBTN_MouseHover);
            // 
            // trailBTN
            // 
            this.trailBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trailBTN.Image = global::CWA_Assessment.Properties.Resources.trail;
            this.trailBTN.Location = new System.Drawing.Point(165, 224);
            this.trailBTN.Name = "trailBTN";
            this.trailBTN.Size = new System.Drawing.Size(169, 94);
            this.trailBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trailBTN.TabIndex = 2;
            this.trailBTN.TabStop = false;
            this.trailBTN.Click += new System.EventHandler(this.trailBTN_Click);
            this.trailBTN.MouseLeave += new System.EventHandler(this.trailBTN_MouseLeave);
            this.trailBTN.MouseHover += new System.EventHandler(this.trailBTN_MouseHover);
            // 
            // closeBTN
            // 
            this.closeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBTN.Image = ((System.Drawing.Image)(resources.GetObject("closeBTN.Image")));
            this.closeBTN.Location = new System.Drawing.Point(732, 12);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(38, 28);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBTN.TabIndex = 1;
            this.closeBTN.TabStop = false;
            this.closeBTN.Click += new System.EventHandler(this.pictureBox1_Click);
            this.closeBTN.MouseLeave += new System.EventHandler(this.closeBTN_MouseLeave);
            this.closeBTN.MouseHover += new System.EventHandler(this.closeBTN_MouseHover);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.logo.Image = global::CWA_Assessment.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(140, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(200, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trail Balance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransactionsBTN);
            this.Controls.Add(this.trailBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.logo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox closeBTN;
        private System.Windows.Forms.PictureBox trailBTN;
        private System.Windows.Forms.PictureBox TransactionsBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

