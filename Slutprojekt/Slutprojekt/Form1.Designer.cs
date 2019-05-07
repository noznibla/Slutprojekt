namespace Slutprojekt
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
            this.Titel = new System.Windows.Forms.Label();
            this.Starta = new System.Windows.Forms.Button();
            this.Frågesport = new System.Windows.Forms.Panel();
            this.Nästa = new System.Windows.Forms.Button();
            this.Tidigare = new System.Windows.Forms.Button();
            this.Fråga1 = new System.Windows.Forms.Panel();
            this.Indiska = new System.Windows.Forms.RadioButton();
            this.Engelska = new System.Windows.Forms.RadioButton();
            this.Kinesiska = new System.Windows.Forms.RadioButton();
            this.Ryska = new System.Windows.Forms.RadioButton();
            this.Språk = new System.Windows.Forms.Label();
            this.Fråga2 = new System.Windows.Forms.Panel();
            this.Baseboll = new System.Windows.Forms.Label();
            this.sju = new System.Windows.Forms.RadioButton();
            this.åtta = new System.Windows.Forms.RadioButton();
            this.nio = new System.Windows.Forms.RadioButton();
            this.tio = new System.Windows.Forms.RadioButton();
            this.Frågesport.SuspendLayout();
            this.Fråga1.SuspendLayout();
            this.Fråga2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titel
            // 
            this.Titel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titel.Location = new System.Drawing.Point(270, 42);
            this.Titel.Name = "Titel";
            this.Titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Titel.Size = new System.Drawing.Size(257, 55);
            this.Titel.TabIndex = 0;
            this.Titel.Text = "Frågesport";
            // 
            // Starta
            // 
            this.Starta.Location = new System.Drawing.Point(309, 200);
            this.Starta.Name = "Starta";
            this.Starta.Size = new System.Drawing.Size(178, 56);
            this.Starta.TabIndex = 1;
            this.Starta.Text = "Starta\r\n";
            this.Starta.UseVisualStyleBackColor = true;
            this.Starta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frågesport
            // 
            this.Frågesport.Controls.Add(this.Titel);
            this.Frågesport.Controls.Add(this.Starta);
            this.Frågesport.Location = new System.Drawing.Point(0, 0);
            this.Frågesport.Name = "Frågesport";
            this.Frågesport.Size = new System.Drawing.Size(799, 396);
            this.Frågesport.TabIndex = 3;
            // 
            // Nästa
            // 
            this.Nästa.Location = new System.Drawing.Point(708, 415);
            this.Nästa.Name = "Nästa";
            this.Nästa.Size = new System.Drawing.Size(80, 23);
            this.Nästa.TabIndex = 4;
            this.Nästa.Text = "Nästa fråga";
            this.Nästa.UseVisualStyleBackColor = true;
            this.Nästa.Click += new System.EventHandler(this.Nästa_Click);
            // 
            // Tidigare
            // 
            this.Tidigare.Location = new System.Drawing.Point(12, 415);
            this.Tidigare.Name = "Tidigare";
            this.Tidigare.Size = new System.Drawing.Size(80, 23);
            this.Tidigare.TabIndex = 5;
            this.Tidigare.Text = "Tidigare fråga";
            this.Tidigare.UseVisualStyleBackColor = true;
            this.Tidigare.Click += new System.EventHandler(this.Tidigare_Click);
            // 
            // Fråga1
            // 
            this.Fråga1.Controls.Add(this.Språk);
            this.Fråga1.Controls.Add(this.Indiska);
            this.Fråga1.Controls.Add(this.Engelska);
            this.Fråga1.Controls.Add(this.Kinesiska);
            this.Fråga1.Controls.Add(this.Ryska);
            this.Fråga1.Location = new System.Drawing.Point(0, 0);
            this.Fråga1.Name = "Fråga1";
            this.Fråga1.Size = new System.Drawing.Size(799, 396);
            this.Fråga1.TabIndex = 4;
            // 
            // Indiska
            // 
            this.Indiska.AutoSize = true;
            this.Indiska.Location = new System.Drawing.Point(224, 177);
            this.Indiska.Name = "Indiska";
            this.Indiska.Size = new System.Drawing.Size(59, 17);
            this.Indiska.TabIndex = 1;
            this.Indiska.TabStop = true;
            this.Indiska.Text = "Indiska";
            this.Indiska.UseVisualStyleBackColor = true;
            // 
            // Engelska
            // 
            this.Engelska.AutoSize = true;
            this.Engelska.Location = new System.Drawing.Point(456, 177);
            this.Engelska.Name = "Engelska";
            this.Engelska.Size = new System.Drawing.Size(69, 17);
            this.Engelska.TabIndex = 2;
            this.Engelska.TabStop = true;
            this.Engelska.Text = "Engelska";
            this.Engelska.UseVisualStyleBackColor = true;
            // 
            // Kinesiska
            // 
            this.Kinesiska.AutoSize = true;
            this.Kinesiska.Location = new System.Drawing.Point(224, 262);
            this.Kinesiska.Name = "Kinesiska";
            this.Kinesiska.Size = new System.Drawing.Size(70, 17);
            this.Kinesiska.TabIndex = 3;
            this.Kinesiska.TabStop = true;
            this.Kinesiska.Text = "Kinesiska";
            this.Kinesiska.UseVisualStyleBackColor = true;
            // 
            // Ryska
            // 
            this.Ryska.AutoSize = true;
            this.Ryska.Location = new System.Drawing.Point(456, 262);
            this.Ryska.Name = "Ryska";
            this.Ryska.Size = new System.Drawing.Size(55, 17);
            this.Ryska.TabIndex = 4;
            this.Ryska.TabStop = true;
            this.Ryska.Text = "Ryska";
            this.Ryska.UseVisualStyleBackColor = true;
            // 
            // Språk
            // 
            this.Språk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Språk.AutoSize = true;
            this.Språk.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Språk.Location = new System.Drawing.Point(123, 59);
            this.Språk.Name = "Språk";
            this.Språk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Språk.Size = new System.Drawing.Size(567, 33);
            this.Språk.TabIndex = 0;
            this.Språk.Text = "Vilket är det mest talade språket i världen?";
            // 
            // Fråga2
            // 
            this.Fråga2.Controls.Add(this.Baseboll);
            this.Fråga2.Controls.Add(this.sju);
            this.Fråga2.Controls.Add(this.åtta);
            this.Fråga2.Controls.Add(this.nio);
            this.Fråga2.Controls.Add(this.tio);
            this.Fråga2.Location = new System.Drawing.Point(0, 0);
            this.Fråga2.Name = "Fråga2";
            this.Fråga2.Size = new System.Drawing.Size(799, 396);
            this.Fråga2.TabIndex = 5;
            // 
            // Baseboll
            // 
            this.Baseboll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Baseboll.AutoSize = true;
            this.Baseboll.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baseboll.Location = new System.Drawing.Point(123, 59);
            this.Baseboll.Name = "Baseboll";
            this.Baseboll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Baseboll.Size = new System.Drawing.Size(616, 33);
            this.Baseboll.TabIndex = 0;
            this.Baseboll.Text = "Hur många spelare finns det i ett baseboll lag?";
            // 
            // sju
            // 
            this.sju.AutoSize = true;
            this.sju.Location = new System.Drawing.Point(224, 177);
            this.sju.Name = "sju";
            this.sju.Size = new System.Drawing.Size(31, 17);
            this.sju.TabIndex = 1;
            this.sju.TabStop = true;
            this.sju.Text = "7";
            this.sju.UseVisualStyleBackColor = true;
            // 
            // åtta
            // 
            this.åtta.AutoSize = true;
            this.åtta.Location = new System.Drawing.Point(456, 177);
            this.åtta.Name = "åtta";
            this.åtta.Size = new System.Drawing.Size(31, 17);
            this.åtta.TabIndex = 2;
            this.åtta.TabStop = true;
            this.åtta.Text = "8";
            this.åtta.UseVisualStyleBackColor = true;
            // 
            // nio
            // 
            this.nio.AutoSize = true;
            this.nio.Location = new System.Drawing.Point(224, 262);
            this.nio.Name = "nio";
            this.nio.Size = new System.Drawing.Size(31, 17);
            this.nio.TabIndex = 3;
            this.nio.TabStop = true;
            this.nio.Text = "9";
            this.nio.UseVisualStyleBackColor = true;
            // 
            // tio
            // 
            this.tio.AutoSize = true;
            this.tio.Location = new System.Drawing.Point(456, 262);
            this.tio.Name = "tio";
            this.tio.Size = new System.Drawing.Size(37, 17);
            this.tio.TabIndex = 4;
            this.tio.TabStop = true;
            this.tio.Text = "10";
            this.tio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Frågesport);
            this.Controls.Add(this.Fråga1);
            this.Controls.Add(this.Fråga2);
            this.Controls.Add(this.Tidigare);
            this.Controls.Add(this.Nästa);
            this.Name = "Form1";
            this.Text = "Frågesport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Frågesport.ResumeLayout(false);
            this.Frågesport.PerformLayout();
            this.Fråga1.ResumeLayout(false);
            this.Fråga1.PerformLayout();
            this.Fråga2.ResumeLayout(false);
            this.Fråga2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Button Starta;
        private System.Windows.Forms.Panel Frågesport;
        private System.Windows.Forms.Button Nästa;
        private System.Windows.Forms.Button Tidigare;
        private System.Windows.Forms.Panel Fråga1;
        private System.Windows.Forms.RadioButton Ryska;
        private System.Windows.Forms.RadioButton Kinesiska;
        private System.Windows.Forms.RadioButton Engelska;
        private System.Windows.Forms.RadioButton Indiska;
        private System.Windows.Forms.Label Språk;
        private System.Windows.Forms.Panel Fråga2;
        private System.Windows.Forms.Label Baseboll;
        private System.Windows.Forms.RadioButton sju;
        private System.Windows.Forms.RadioButton åtta;
        private System.Windows.Forms.RadioButton nio;
        private System.Windows.Forms.RadioButton tio;
    }
}

