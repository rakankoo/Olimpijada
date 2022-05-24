
namespace Olimpijada
{
    partial class Ucesnici
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
            this.btOtkazi = new System.Windows.Forms.Button();
            this.btUbaci = new System.Windows.Forms.Button();
            this.btDesnoSkroz = new System.Windows.Forms.Button();
            this.btDesno = new System.Windows.Forms.Button();
            this.btLevoSkroz = new System.Windows.Forms.Button();
            this.btLevo = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btObrisi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDRZAVA = new System.Windows.Forms.TextBox();
            this.textDISCIPLINA = new System.Windows.Forms.TextBox();
            this.textPREZIME = new System.Windows.Forms.TextBox();
            this.textIME = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textMAIL = new System.Windows.Forms.TextBox();
            this.textPASS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btOtkazi
            // 
            this.btOtkazi.Enabled = false;
            this.btOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOtkazi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btOtkazi.Location = new System.Drawing.Point(26, 19);
            this.btOtkazi.Name = "btOtkazi";
            this.btOtkazi.Size = new System.Drawing.Size(108, 44);
            this.btOtkazi.TabIndex = 49;
            this.btOtkazi.Text = "OTKAŽI";
            this.btOtkazi.UseVisualStyleBackColor = true;
            this.btOtkazi.Visible = false;
            // 
            // btUbaci
            // 
            this.btUbaci.Enabled = false;
            this.btUbaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUbaci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btUbaci.Location = new System.Drawing.Point(222, 388);
            this.btUbaci.Name = "btUbaci";
            this.btUbaci.Size = new System.Drawing.Size(108, 44);
            this.btUbaci.TabIndex = 48;
            this.btUbaci.Text = "UBACI";
            this.btUbaci.UseVisualStyleBackColor = true;
            this.btUbaci.Click += new System.EventHandler(this.btUbaci_Click);
            // 
            // btDesnoSkroz
            // 
            this.btDesnoSkroz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesnoSkroz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDesnoSkroz.Location = new System.Drawing.Point(664, 382);
            this.btDesnoSkroz.Name = "btDesnoSkroz";
            this.btDesnoSkroz.Size = new System.Drawing.Size(75, 44);
            this.btDesnoSkroz.TabIndex = 47;
            this.btDesnoSkroz.Text = ">>";
            this.btDesnoSkroz.UseVisualStyleBackColor = true;
            this.btDesnoSkroz.Click += new System.EventHandler(this.btDesnoSkroz_Click);
            // 
            // btDesno
            // 
            this.btDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDesno.Location = new System.Drawing.Point(584, 382);
            this.btDesno.Name = "btDesno";
            this.btDesno.Size = new System.Drawing.Size(74, 44);
            this.btDesno.TabIndex = 46;
            this.btDesno.Text = ">";
            this.btDesno.UseVisualStyleBackColor = true;
            this.btDesno.Click += new System.EventHandler(this.btDesno_Click);
            // 
            // btLevoSkroz
            // 
            this.btLevoSkroz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLevoSkroz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLevoSkroz.Location = new System.Drawing.Point(43, 382);
            this.btLevoSkroz.Name = "btLevoSkroz";
            this.btLevoSkroz.Size = new System.Drawing.Size(75, 44);
            this.btLevoSkroz.TabIndex = 45;
            this.btLevoSkroz.Text = "<<";
            this.btLevoSkroz.UseVisualStyleBackColor = true;
            this.btLevoSkroz.Click += new System.EventHandler(this.btLevoSkroz_Click);
            // 
            // btLevo
            // 
            this.btLevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLevo.Location = new System.Drawing.Point(124, 382);
            this.btLevo.Name = "btLevo";
            this.btLevo.Size = new System.Drawing.Size(75, 44);
            this.btLevo.TabIndex = 44;
            this.btLevo.Text = "<";
            this.btLevo.UseVisualStyleBackColor = true;
            this.btLevo.Click += new System.EventHandler(this.btLevo_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDodaj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDodaj.Location = new System.Drawing.Point(221, 338);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(108, 44);
            this.btDodaj.TabIndex = 43;
            this.btDodaj.Text = "DODAJ";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIzmeni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btIzmeni.Location = new System.Drawing.Point(450, 364);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(108, 44);
            this.btIzmeni.TabIndex = 42;
            this.btIzmeni.Text = "IZMENI";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btObrisi
            // 
            this.btObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btObrisi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btObrisi.Location = new System.Drawing.Point(336, 364);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(108, 44);
            this.btObrisi.TabIndex = 41;
            this.btObrisi.Text = "OBRIŠI";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(633, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "DRZAVA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "LOZINKA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(591, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "PREZIME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "E-MAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "DISCIPLINA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "IME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID";
            // 
            // textDRZAVA
            // 
            this.textDRZAVA.Enabled = false;
            this.textDRZAVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDRZAVA.Location = new System.Drawing.Point(613, 181);
            this.textDRZAVA.Name = "textDRZAVA";
            this.textDRZAVA.Size = new System.Drawing.Size(142, 28);
            this.textDRZAVA.TabIndex = 32;
            this.textDRZAVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDISCIPLINA
            // 
            this.textDISCIPLINA.Enabled = false;
            this.textDISCIPLINA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDISCIPLINA.Location = new System.Drawing.Point(261, 264);
            this.textDISCIPLINA.Name = "textDISCIPLINA";
            this.textDISCIPLINA.Size = new System.Drawing.Size(271, 28);
            this.textDISCIPLINA.TabIndex = 31;
            this.textDISCIPLINA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPREZIME
            // 
            this.textPREZIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPREZIME.Location = new System.Drawing.Point(486, 98);
            this.textPREZIME.Name = "textPREZIME";
            this.textPREZIME.Size = new System.Drawing.Size(304, 28);
            this.textPREZIME.TabIndex = 30;
            this.textPREZIME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textIME
            // 
            this.textIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIME.Location = new System.Drawing.Point(196, 98);
            this.textIME.Name = "textIME";
            this.textIME.Size = new System.Drawing.Size(226, 28);
            this.textIME.TabIndex = 29;
            this.textIME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(51, 98);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(63, 28);
            this.textID.TabIndex = 28;
            this.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textMAIL
            // 
            this.textMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMAIL.Location = new System.Drawing.Point(11, 181);
            this.textMAIL.Name = "textMAIL";
            this.textMAIL.Size = new System.Drawing.Size(319, 28);
            this.textMAIL.TabIndex = 27;
            this.textMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPASS
            // 
            this.textPASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPASS.Location = new System.Drawing.Point(362, 181);
            this.textPASS.Name = "textPASS";
            this.textPASS.Size = new System.Drawing.Size(161, 28);
            this.textPASS.TabIndex = 26;
            this.textPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ucesnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOtkazi);
            this.Controls.Add(this.btUbaci);
            this.Controls.Add(this.btDesnoSkroz);
            this.Controls.Add(this.btDesno);
            this.Controls.Add(this.btLevoSkroz);
            this.Controls.Add(this.btLevo);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDRZAVA);
            this.Controls.Add(this.textDISCIPLINA);
            this.Controls.Add(this.textPREZIME);
            this.Controls.Add(this.textIME);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textMAIL);
            this.Controls.Add(this.textPASS);
            this.Name = "Ucesnici";
            this.Text = "Ucesnici";
            this.Load += new System.EventHandler(this.Ucesnici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOtkazi;
        private System.Windows.Forms.Button btUbaci;
        private System.Windows.Forms.Button btDesnoSkroz;
        private System.Windows.Forms.Button btDesno;
        private System.Windows.Forms.Button btLevoSkroz;
        private System.Windows.Forms.Button btLevo;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btObrisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDRZAVA;
        private System.Windows.Forms.TextBox textDISCIPLINA;
        private System.Windows.Forms.TextBox textPREZIME;
        private System.Windows.Forms.TextBox textIME;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textMAIL;
        private System.Windows.Forms.TextBox textPASS;
    }
}