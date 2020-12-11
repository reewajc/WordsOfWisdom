
namespace WordsOfWisdom
{
    partial class frmWordsOfWisdom
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
            this.lblFirstQuote = new System.Windows.Forms.Label();
            this.lblSecondQuote = new System.Windows.Forms.Label();
            this.lblThirdQuote = new System.Windows.Forms.Label();
            this.lblFourthQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstQuote
            // 
            this.lblFirstQuote.BackColor = System.Drawing.Color.Black;
            this.lblFirstQuote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstQuote.Location = new System.Drawing.Point(84, 55);
            this.lblFirstQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstQuote.Name = "lblFirstQuote";
            this.lblFirstQuote.Size = new System.Drawing.Size(384, 150);
            this.lblFirstQuote.TabIndex = 0;
            this.lblFirstQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFirstQuote.MouseHover += new System.EventHandler(this.LblFirstQuote_MouseHover);
            // 
            // lblSecondQuote
            // 
            this.lblSecondQuote.BackColor = System.Drawing.Color.Black;
            this.lblSecondQuote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondQuote.Location = new System.Drawing.Point(557, 55);
            this.lblSecondQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondQuote.Name = "lblSecondQuote";
            this.lblSecondQuote.Size = new System.Drawing.Size(451, 150);
            this.lblSecondQuote.TabIndex = 1;
            this.lblSecondQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSecondQuote.MouseHover += new System.EventHandler(this.LblSecondQuote_MouseHover);
            // 
            // lblThirdQuote
            // 
            this.lblThirdQuote.BackColor = System.Drawing.Color.Black;
            this.lblThirdQuote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdQuote.Location = new System.Drawing.Point(84, 288);
            this.lblThirdQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThirdQuote.Name = "lblThirdQuote";
            this.lblThirdQuote.Size = new System.Drawing.Size(384, 150);
            this.lblThirdQuote.TabIndex = 2;
            this.lblThirdQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThirdQuote.MouseHover += new System.EventHandler(this.LblThirdQuote_MouseHover);
            // 
            // lblFourthQuote
            // 
            this.lblFourthQuote.BackColor = System.Drawing.Color.Black;
            this.lblFourthQuote.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthQuote.Location = new System.Drawing.Point(563, 288);
            this.lblFourthQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFourthQuote.Name = "lblFourthQuote";
            this.lblFourthQuote.Size = new System.Drawing.Size(445, 150);
            this.lblFourthQuote.TabIndex = 3;
            this.lblFourthQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFourthQuote.MouseHover += new System.EventHandler(this.LblFourthQuote_MouseHover);
            // 
            // frmWordsOfWisdom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblFourthQuote);
            this.Controls.Add(this.lblThirdQuote);
            this.Controls.Add(this.lblSecondQuote);
            this.Controls.Add(this.lblFirstQuote);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWordsOfWisdom";
            this.Text = "Words Of Wisdom";
            this.Load += new System.EventHandler(this.FrmWordsOfWisdom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstQuote;
        private System.Windows.Forms.Label lblSecondQuote;
        private System.Windows.Forms.Label lblThirdQuote;
        private System.Windows.Forms.Label lblFourthQuote;
    }
}

