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
            this.fabian = new System.Windows.Forms.Label();
            this.Nästa = new System.Windows.Forms.Button();
            this.Tidigare = new System.Windows.Forms.Button();
            this.Fråga1 = new System.Windows.Forms.Panel();
            this.fråga_1 = new System.Windows.Forms.Label();
            this.Språk = new System.Windows.Forms.Label();
            this.Indiska = new System.Windows.Forms.RadioButton();
            this.Engelska = new System.Windows.Forms.RadioButton();
            this.Kinesiska = new System.Windows.Forms.RadioButton();
            this.Ryska = new System.Windows.Forms.RadioButton();
            this.Fråga2 = new System.Windows.Forms.Panel();
            this.fråga_2 = new System.Windows.Forms.Label();
            this.Baseboll = new System.Windows.Forms.Label();
            this.åtta = new System.Windows.Forms.RadioButton();
            this.nio = new System.Windows.Forms.RadioButton();
            this.tio = new System.Windows.Forms.RadioButton();
            this.elva = new System.Windows.Forms.RadioButton();
            this.Fråga3 = new System.Windows.Forms.Panel();
            this.fråga_3 = new System.Windows.Forms.Label();
            this.Tänder = new System.Windows.Forms.Label();
            this.Trettio = new System.Windows.Forms.RadioButton();
            this.Trettioett = new System.Windows.Forms.RadioButton();
            this.Trettiotvå = new System.Windows.Forms.RadioButton();
            this.Trettiotre = new System.Windows.Forms.RadioButton();
            this.Fråga4 = new System.Windows.Forms.Panel();
            this.fråga_4 = new System.Windows.Forms.Label();
            this.Huvudstad = new System.Windows.Forms.Label();
            this.Istanbul = new System.Windows.Forms.RadioButton();
            this.Izmir = new System.Windows.Forms.RadioButton();
            this.Adana = new System.Windows.Forms.RadioButton();
            this.Ankara = new System.Windows.Forms.RadioButton();
            this.Fråga5 = new System.Windows.Forms.Panel();
            this.fråga_5 = new System.Windows.Forms.Label();
            this.Förkortning = new System.Windows.Forms.Label();
            this.Ram1 = new System.Windows.Forms.RadioButton();
            this.Ram2 = new System.Windows.Forms.RadioButton();
            this.Ram3 = new System.Windows.Forms.RadioButton();
            this.Ram4 = new System.Windows.Forms.RadioButton();
            this.Resultat = new System.Windows.Forms.Panel();
            this.fil = new System.Windows.Forms.Label();
            this.ResultatTitel = new System.Windows.Forms.Label();
            this.SkrivUt = new System.Windows.Forms.Button();
            this.Frågesport.SuspendLayout();
            this.Fråga1.SuspendLayout();
            this.Fråga2.SuspendLayout();
            this.Fråga3.SuspendLayout();
            this.Fråga4.SuspendLayout();
            this.Fråga5.SuspendLayout();
            this.Resultat.SuspendLayout();
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
            this.Frågesport.Controls.Add(this.fabian);
            this.Frågesport.Controls.Add(this.Titel);
            this.Frågesport.Controls.Add(this.Starta);
            this.Frågesport.Location = new System.Drawing.Point(0, 0);
            this.Frågesport.Name = "Frågesport";
            this.Frågesport.Size = new System.Drawing.Size(799, 450);
            this.Frågesport.TabIndex = 3;
            // 
            // fabian
            // 
            this.fabian.AutoSize = true;
            this.fabian.Location = new System.Drawing.Point(588, 415);
            this.fabian.Name = "fabian";
            this.fabian.Size = new System.Drawing.Size(145, 13);
            this.fabian.TabIndex = 2;
            this.fabian.Text = "Skapad av: Fabian Albinsson";
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
            this.Fråga1.Controls.Add(this.fråga_1);
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
            // fråga_1
            // 
            this.fråga_1.AutoSize = true;
            this.fråga_1.Location = new System.Drawing.Point(9, 9);
            this.fråga_1.Name = "fråga_1";
            this.fråga_1.Size = new System.Drawing.Size(60, 13);
            this.fråga_1.TabIndex = 5;
            this.fråga_1.Text = "Fråga (1/5)";
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
            this.Kinesiska.CheckedChanged += new System.EventHandler(this.Kinesiska_CheckedChanged);
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
            // Fråga2
            // 
            this.Fråga2.Controls.Add(this.fråga_2);
            this.Fråga2.Controls.Add(this.Baseboll);
            this.Fråga2.Controls.Add(this.åtta);
            this.Fråga2.Controls.Add(this.nio);
            this.Fråga2.Controls.Add(this.tio);
            this.Fråga2.Controls.Add(this.elva);
            this.Fråga2.Location = new System.Drawing.Point(0, 0);
            this.Fråga2.Name = "Fråga2";
            this.Fråga2.Size = new System.Drawing.Size(799, 396);
            this.Fråga2.TabIndex = 5;
            // 
            // fråga_2
            // 
            this.fråga_2.AutoSize = true;
            this.fråga_2.Location = new System.Drawing.Point(9, 9);
            this.fråga_2.Name = "fråga_2";
            this.fråga_2.Size = new System.Drawing.Size(60, 13);
            this.fråga_2.TabIndex = 6;
            this.fråga_2.Text = "Fråga (2/5)";
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
            // åtta
            // 
            this.åtta.AutoSize = true;
            this.åtta.Location = new System.Drawing.Point(224, 177);
            this.åtta.Name = "åtta";
            this.åtta.Size = new System.Drawing.Size(31, 17);
            this.åtta.TabIndex = 1;
            this.åtta.TabStop = true;
            this.åtta.Text = "8";
            this.åtta.UseVisualStyleBackColor = true;
            // 
            // nio
            // 
            this.nio.AutoSize = true;
            this.nio.Location = new System.Drawing.Point(456, 177);
            this.nio.Name = "nio";
            this.nio.Size = new System.Drawing.Size(31, 17);
            this.nio.TabIndex = 2;
            this.nio.TabStop = true;
            this.nio.Text = "9";
            this.nio.UseVisualStyleBackColor = true;
            // 
            // tio
            // 
            this.tio.AutoSize = true;
            this.tio.Location = new System.Drawing.Point(224, 262);
            this.tio.Name = "tio";
            this.tio.Size = new System.Drawing.Size(37, 17);
            this.tio.TabIndex = 3;
            this.tio.TabStop = true;
            this.tio.Text = "10";
            this.tio.UseVisualStyleBackColor = true;
            // 
            // elva
            // 
            this.elva.AutoSize = true;
            this.elva.Location = new System.Drawing.Point(456, 262);
            this.elva.Name = "elva";
            this.elva.Size = new System.Drawing.Size(37, 17);
            this.elva.TabIndex = 4;
            this.elva.TabStop = true;
            this.elva.Text = "11";
            this.elva.UseVisualStyleBackColor = true;
            // 
            // Fråga3
            // 
            this.Fråga3.Controls.Add(this.fråga_3);
            this.Fråga3.Controls.Add(this.Tänder);
            this.Fråga3.Controls.Add(this.Trettio);
            this.Fråga3.Controls.Add(this.Trettioett);
            this.Fråga3.Controls.Add(this.Trettiotvå);
            this.Fråga3.Controls.Add(this.Trettiotre);
            this.Fråga3.Location = new System.Drawing.Point(0, 0);
            this.Fråga3.Name = "Fråga3";
            this.Fråga3.Size = new System.Drawing.Size(799, 396);
            this.Fråga3.TabIndex = 6;
            // 
            // fråga_3
            // 
            this.fråga_3.AutoSize = true;
            this.fråga_3.Location = new System.Drawing.Point(9, 9);
            this.fråga_3.Name = "fråga_3";
            this.fråga_3.Size = new System.Drawing.Size(60, 13);
            this.fråga_3.TabIndex = 7;
            this.fråga_3.Text = "Fråga (3/5)";
            // 
            // Tänder
            // 
            this.Tänder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tänder.AutoSize = true;
            this.Tänder.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tänder.Location = new System.Drawing.Point(123, 59);
            this.Tänder.Name = "Tänder";
            this.Tänder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tänder.Size = new System.Drawing.Size(441, 33);
            this.Tänder.TabIndex = 0;
            this.Tänder.Text = "Hur många tänder har en vuxen?";
            // 
            // Trettio
            // 
            this.Trettio.AutoSize = true;
            this.Trettio.Location = new System.Drawing.Point(224, 177);
            this.Trettio.Name = "Trettio";
            this.Trettio.Size = new System.Drawing.Size(37, 17);
            this.Trettio.TabIndex = 1;
            this.Trettio.TabStop = true;
            this.Trettio.Text = "30";
            this.Trettio.UseVisualStyleBackColor = true;
            // 
            // Trettioett
            // 
            this.Trettioett.AutoSize = true;
            this.Trettioett.Location = new System.Drawing.Point(456, 177);
            this.Trettioett.Name = "Trettioett";
            this.Trettioett.Size = new System.Drawing.Size(37, 17);
            this.Trettioett.TabIndex = 2;
            this.Trettioett.TabStop = true;
            this.Trettioett.Text = "31";
            this.Trettioett.UseVisualStyleBackColor = true;
            // 
            // Trettiotvå
            // 
            this.Trettiotvå.AutoSize = true;
            this.Trettiotvå.Location = new System.Drawing.Point(224, 262);
            this.Trettiotvå.Name = "Trettiotvå";
            this.Trettiotvå.Size = new System.Drawing.Size(37, 17);
            this.Trettiotvå.TabIndex = 3;
            this.Trettiotvå.TabStop = true;
            this.Trettiotvå.Text = "32";
            this.Trettiotvå.UseVisualStyleBackColor = true;
            // 
            // Trettiotre
            // 
            this.Trettiotre.AutoSize = true;
            this.Trettiotre.Location = new System.Drawing.Point(456, 262);
            this.Trettiotre.Name = "Trettiotre";
            this.Trettiotre.Size = new System.Drawing.Size(37, 17);
            this.Trettiotre.TabIndex = 4;
            this.Trettiotre.TabStop = true;
            this.Trettiotre.Text = "33";
            this.Trettiotre.UseVisualStyleBackColor = true;
            // 
            // Fråga4
            // 
            this.Fråga4.Controls.Add(this.fråga_4);
            this.Fråga4.Controls.Add(this.Huvudstad);
            this.Fråga4.Controls.Add(this.Istanbul);
            this.Fråga4.Controls.Add(this.Izmir);
            this.Fråga4.Controls.Add(this.Adana);
            this.Fråga4.Controls.Add(this.Ankara);
            this.Fråga4.Location = new System.Drawing.Point(0, 0);
            this.Fråga4.Name = "Fråga4";
            this.Fråga4.Size = new System.Drawing.Size(799, 396);
            this.Fråga4.TabIndex = 7;
            // 
            // fråga_4
            // 
            this.fråga_4.AutoSize = true;
            this.fråga_4.Location = new System.Drawing.Point(9, 9);
            this.fråga_4.Name = "fråga_4";
            this.fråga_4.Size = new System.Drawing.Size(60, 13);
            this.fråga_4.TabIndex = 7;
            this.fråga_4.Text = "Fråga (4/5)";
            // 
            // Huvudstad
            // 
            this.Huvudstad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Huvudstad.AutoSize = true;
            this.Huvudstad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huvudstad.Location = new System.Drawing.Point(123, 59);
            this.Huvudstad.Name = "Huvudstad";
            this.Huvudstad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Huvudstad.Size = new System.Drawing.Size(433, 33);
            this.Huvudstad.TabIndex = 0;
            this.Huvudstad.Text = "VIlken är huvudstaden i Turkiet?";
            this.Huvudstad.Click += new System.EventHandler(this.label1_Click);
            // 
            // Istanbul
            // 
            this.Istanbul.AutoSize = true;
            this.Istanbul.Location = new System.Drawing.Point(224, 177);
            this.Istanbul.Name = "Istanbul";
            this.Istanbul.Size = new System.Drawing.Size(62, 17);
            this.Istanbul.TabIndex = 1;
            this.Istanbul.TabStop = true;
            this.Istanbul.Text = "Istanbul";
            this.Istanbul.UseVisualStyleBackColor = true;
            // 
            // Izmir
            // 
            this.Izmir.AutoSize = true;
            this.Izmir.Location = new System.Drawing.Point(456, 177);
            this.Izmir.Name = "Izmir";
            this.Izmir.Size = new System.Drawing.Size(46, 17);
            this.Izmir.TabIndex = 2;
            this.Izmir.TabStop = true;
            this.Izmir.Text = "Izmir";
            this.Izmir.UseVisualStyleBackColor = true;
            // 
            // Adana
            // 
            this.Adana.AutoSize = true;
            this.Adana.Location = new System.Drawing.Point(224, 262);
            this.Adana.Name = "Adana";
            this.Adana.Size = new System.Drawing.Size(56, 17);
            this.Adana.TabIndex = 3;
            this.Adana.TabStop = true;
            this.Adana.Text = "Adana";
            this.Adana.UseVisualStyleBackColor = true;
            // 
            // Ankara
            // 
            this.Ankara.AutoSize = true;
            this.Ankara.Location = new System.Drawing.Point(456, 262);
            this.Ankara.Name = "Ankara";
            this.Ankara.Size = new System.Drawing.Size(59, 17);
            this.Ankara.TabIndex = 4;
            this.Ankara.TabStop = true;
            this.Ankara.Text = "Ankara";
            this.Ankara.UseVisualStyleBackColor = true;
            // 
            // Fråga5
            // 
            this.Fråga5.Controls.Add(this.fråga_5);
            this.Fråga5.Controls.Add(this.Förkortning);
            this.Fråga5.Controls.Add(this.Ram1);
            this.Fråga5.Controls.Add(this.Ram2);
            this.Fråga5.Controls.Add(this.Ram3);
            this.Fråga5.Controls.Add(this.Ram4);
            this.Fråga5.Location = new System.Drawing.Point(0, 0);
            this.Fråga5.Name = "Fråga5";
            this.Fråga5.Size = new System.Drawing.Size(799, 396);
            this.Fråga5.TabIndex = 8;
            // 
            // fråga_5
            // 
            this.fråga_5.AutoSize = true;
            this.fråga_5.Location = new System.Drawing.Point(9, 9);
            this.fråga_5.Name = "fråga_5";
            this.fråga_5.Size = new System.Drawing.Size(60, 13);
            this.fråga_5.TabIndex = 7;
            this.fråga_5.Text = "Fråga (5/5)";
            // 
            // Förkortning
            // 
            this.Förkortning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Förkortning.AutoSize = true;
            this.Förkortning.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Förkortning.Location = new System.Drawing.Point(123, 59);
            this.Förkortning.Name = "Förkortning";
            this.Förkortning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Förkortning.Size = new System.Drawing.Size(431, 33);
            this.Förkortning.TabIndex = 0;
            this.Förkortning.Text = "Vad står förkortningen RAM för?";
            // 
            // Ram1
            // 
            this.Ram1.AutoSize = true;
            this.Ram1.Location = new System.Drawing.Point(224, 177);
            this.Ram1.Name = "Ram1";
            this.Ram1.Size = new System.Drawing.Size(143, 17);
            this.Ram1.TabIndex = 1;
            this.Ram1.TabStop = true;
            this.Ram1.Text = "Random Access Memory";
            this.Ram1.UseVisualStyleBackColor = true;
            // 
            // Ram2
            // 
            this.Ram2.AutoSize = true;
            this.Ram2.Location = new System.Drawing.Point(456, 177);
            this.Ram2.Name = "Ram2";
            this.Ram2.Size = new System.Drawing.Size(164, 17);
            this.Ram2.TabIndex = 2;
            this.Ram2.TabStop = true;
            this.Ram2.Text = "Registered Account Manager";
            this.Ram2.UseVisualStyleBackColor = true;
            // 
            // Ram3
            // 
            this.Ram3.AutoSize = true;
            this.Ram3.Location = new System.Drawing.Point(224, 262);
            this.Ram3.Name = "Ram3";
            this.Ram3.Size = new System.Drawing.Size(146, 17);
            this.Ram3.TabIndex = 3;
            this.Ram3.TabStop = true;
            this.Ram3.Text = "Relevant Access Memory";
            this.Ram3.UseVisualStyleBackColor = true;
            // 
            // Ram4
            // 
            this.Ram4.AutoSize = true;
            this.Ram4.Location = new System.Drawing.Point(456, 262);
            this.Ram4.Name = "Ram4";
            this.Ram4.Size = new System.Drawing.Size(150, 17);
            this.Ram4.TabIndex = 4;
            this.Ram4.TabStop = true;
            this.Ram4.Text = "Restore Account Manager";
            this.Ram4.UseVisualStyleBackColor = true;
            // 
            // Resultat
            // 
            this.Resultat.Controls.Add(this.fil);
            this.Resultat.Controls.Add(this.ResultatTitel);
            this.Resultat.Controls.Add(this.SkrivUt);
            this.Resultat.Location = new System.Drawing.Point(0, 0);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(799, 409);
            this.Resultat.TabIndex = 4;
            // 
            // fil
            // 
            this.fil.AutoSize = true;
            this.fil.Location = new System.Drawing.Point(296, 325);
            this.fil.Name = "fil";
            this.fil.Size = new System.Drawing.Size(150, 13);
            this.fil.TabIndex = 2;
            this.fil.Text = "Filen kommer att heta Resultat";
            // 
            // ResultatTitel
            // 
            this.ResultatTitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResultatTitel.AutoSize = true;
            this.ResultatTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultatTitel.Location = new System.Drawing.Point(299, 42);
            this.ResultatTitel.Name = "ResultatTitel";
            this.ResultatTitel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultatTitel.Size = new System.Drawing.Size(200, 55);
            this.ResultatTitel.TabIndex = 0;
            this.ResultatTitel.Text = "Resultat";
            // 
            // SkrivUt
            // 
            this.SkrivUt.Location = new System.Drawing.Point(309, 200);
            this.SkrivUt.Name = "SkrivUt";
            this.SkrivUt.Size = new System.Drawing.Size(178, 56);
            this.SkrivUt.TabIndex = 1;
            this.SkrivUt.Text = "Tryck för att skriva ut resultatet";
            this.SkrivUt.UseVisualStyleBackColor = true;
            this.SkrivUt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Frågesport);
            this.Controls.Add(this.Fråga1);
            this.Controls.Add(this.Fråga2);
            this.Controls.Add(this.Fråga3);
            this.Controls.Add(this.Fråga4);
            this.Controls.Add(this.Fråga5);
            this.Controls.Add(this.Resultat);
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
            this.Fråga3.ResumeLayout(false);
            this.Fråga3.PerformLayout();
            this.Fråga4.ResumeLayout(false);
            this.Fråga4.PerformLayout();
            this.Fråga5.ResumeLayout(false);
            this.Fråga5.PerformLayout();
            this.Resultat.ResumeLayout(false);
            this.Resultat.PerformLayout();
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
        private System.Windows.Forms.RadioButton åtta;
        private System.Windows.Forms.RadioButton nio;
        private System.Windows.Forms.RadioButton tio;
        private System.Windows.Forms.RadioButton elva;
        private System.Windows.Forms.Panel Fråga3;
        private System.Windows.Forms.Label Tänder;
        private System.Windows.Forms.RadioButton Trettio;
        private System.Windows.Forms.RadioButton Trettioett;
        private System.Windows.Forms.RadioButton Trettiotvå;
        private System.Windows.Forms.RadioButton Trettiotre;
        private System.Windows.Forms.Panel Fråga4;
        private System.Windows.Forms.Label Huvudstad;
        private System.Windows.Forms.RadioButton Istanbul;
        private System.Windows.Forms.RadioButton Izmir;
        private System.Windows.Forms.RadioButton Adana;
        private System.Windows.Forms.RadioButton Ankara;
        private System.Windows.Forms.Panel Fråga5;
        private System.Windows.Forms.Label Förkortning;
        private System.Windows.Forms.RadioButton Ram1;
        private System.Windows.Forms.RadioButton Ram2;
        private System.Windows.Forms.RadioButton Ram3;
        private System.Windows.Forms.RadioButton Ram4;
        private System.Windows.Forms.Label fabian;
        private System.Windows.Forms.Panel Resultat;
        private System.Windows.Forms.Label ResultatTitel;
        private System.Windows.Forms.Button SkrivUt;
        private System.Windows.Forms.Label fråga_1;
        private System.Windows.Forms.Label fråga_2;
        private System.Windows.Forms.Label fråga_3;
        private System.Windows.Forms.Label fråga_4;
        private System.Windows.Forms.Label fråga_5;
        private System.Windows.Forms.Label fil;
    }
}

