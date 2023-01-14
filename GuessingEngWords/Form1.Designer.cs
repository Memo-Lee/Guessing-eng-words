
namespace GuessingEngWords
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
            this.components = new System.ComponentModel.Container();
            this.EngLabel = new System.Windows.Forms.Label();
            this.TrLabel = new System.Windows.Forms.Label();
            this.EngBox = new System.Windows.Forms.TextBox();
            this.TrBox = new System.Windows.Forms.TextBox();
            this.WordLabel = new System.Windows.Forms.Label();
            this.WordNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTimer = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LblCevap = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EngLabel
            // 
            this.EngLabel.AutoSize = true;
            this.EngLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.EngLabel.ForeColor = System.Drawing.Color.Black;
            this.EngLabel.Location = new System.Drawing.Point(151, 100);
            this.EngLabel.Name = "EngLabel";
            this.EngLabel.Size = new System.Drawing.Size(169, 38);
            this.EngLabel.TabIndex = 0;
            this.EngLabel.Text = "Engilish : ";
            // 
            // TrLabel
            // 
            this.TrLabel.AutoSize = true;
            this.TrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.TrLabel.ForeColor = System.Drawing.Color.Black;
            this.TrLabel.Location = new System.Drawing.Point(151, 182);
            this.TrLabel.Name = "TrLabel";
            this.TrLabel.Size = new System.Drawing.Size(162, 38);
            this.TrLabel.TabIndex = 1;
            this.TrLabel.Text = "Turkish : ";
            // 
            // EngBox
            // 
            this.EngBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EngBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EngBox.ForeColor = System.Drawing.Color.Red;
            this.EngBox.Location = new System.Drawing.Point(318, 105);
            this.EngBox.Name = "EngBox";
            this.EngBox.Size = new System.Drawing.Size(301, 34);
            this.EngBox.TabIndex = 2;
            // 
            // TrBox
            // 
            this.TrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TrBox.Location = new System.Drawing.Point(318, 187);
            this.TrBox.Name = "TrBox";
            this.TrBox.Size = new System.Drawing.Size(301, 34);
            this.TrBox.TabIndex = 1;
            this.TrBox.TextChanged += new System.EventHandler(this.TrBox_TextChanged);
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WordLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.WordLabel.Location = new System.Drawing.Point(506, 142);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(77, 25);
            this.WordLabel.TabIndex = 5;
            this.WordLabel.Text = "Word :";
            // 
            // WordNum
            // 
            this.WordNum.AutoSize = true;
            this.WordNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WordNum.ForeColor = System.Drawing.Color.OrangeRed;
            this.WordNum.Location = new System.Drawing.Point(578, 142);
            this.WordNum.Name = "WordNum";
            this.WordNum.Size = new System.Drawing.Size(24, 25);
            this.WordNum.TabIndex = 6;
            this.WordNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(383, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time : ";
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTimer.ForeColor = System.Drawing.Color.Lime;
            this.LblTimer.Location = new System.Drawing.Point(476, 248);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(46, 32);
            this.LblTimer.TabIndex = 8;
            this.LblTimer.Text = "20";
            this.LblTimer.Click += new System.EventHandler(this.label2_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCevap.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblCevap.Location = new System.Drawing.Point(384, 324);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(46, 25);
            this.LblCevap.TabIndex = 9;
            this.LblCevap.Text = "cvp";
            this.LblCevap.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(797, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.LblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordNum);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.TrBox);
            this.Controls.Add(this.EngBox);
            this.Controls.Add(this.TrLabel);
            this.Controls.Add(this.EngLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EngLabel;
        private System.Windows.Forms.Label TrLabel;
        private System.Windows.Forms.TextBox EngBox;
        private System.Windows.Forms.TextBox TrBox;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label WordNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Button button1;
    }
}

