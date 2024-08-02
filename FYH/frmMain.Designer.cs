namespace FYH
{
    partial class frmMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnRezerwacje = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pgLista = new System.Windows.Forms.TabPage();
            this.pgRezerwacja = new System.Windows.Forms.TabPage();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.pgKoszyk = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImieR = new System.Windows.Forms.TextBox();
            this.mthCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtNazwiskoR = new System.Windows.Forms.TextBox();
            this.txtEmailR = new System.Windows.Forms.TextBox();
            this.txtTelefonR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZatwierdz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pgRezerwacja.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(170)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.btnLista);
            this.panel1.Controls.Add(this.btnRezerwacje);
            this.panel1.Controls.Add(this.btnZamknij);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 564);
            this.panel1.TabIndex = 0;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLista.Location = new System.Drawing.Point(30, 73);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(147, 53);
            this.btnLista.TabIndex = 3;
            this.btnLista.Text = "Lista domków";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnRezerwacje
            // 
            this.btnRezerwacje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btnRezerwacje.FlatAppearance.BorderSize = 0;
            this.btnRezerwacje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezerwacje.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRezerwacje.Location = new System.Drawing.Point(30, 132);
            this.btnRezerwacje.Name = "btnRezerwacje";
            this.btnRezerwacje.Size = new System.Drawing.Size(147, 53);
            this.btnRezerwacje.TabIndex = 2;
            this.btnRezerwacje.Text = "Twoje Rezerwacje";
            this.btnRezerwacje.UseVisualStyleBackColor = false;
            this.btnRezerwacje.Click += new System.EventHandler(this.btnRezerwacje_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btnZamknij.FlatAppearance.BorderSize = 0;
            this.btnZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamknij.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnZamknij.Location = new System.Drawing.Point(30, 515);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(147, 33);
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = false;
            this.btnZamknij.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home4u";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pgLista);
            this.tabControl1.Controls.Add(this.pgRezerwacja);
            this.tabControl1.Controls.Add(this.pgKoszyk);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ItemSize = new System.Drawing.Size(61, 20);
            this.tabControl1.Location = new System.Drawing.Point(207, -14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 566);
            this.tabControl1.TabIndex = 1;
            // 
            // pgLista
            // 
            this.pgLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(216)))), ((int)(((byte)(162)))));
            this.pgLista.Location = new System.Drawing.Point(4, 24);
            this.pgLista.Margin = new System.Windows.Forms.Padding(0);
            this.pgLista.Name = "pgLista";
            this.pgLista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pgLista.Size = new System.Drawing.Size(660, 538);
            this.pgLista.TabIndex = 0;
            this.pgLista.Text = "Lista";
            // 
            // pgRezerwacja
            // 
            this.pgRezerwacja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(216)))), ((int)(((byte)(162)))));
            this.pgRezerwacja.Controls.Add(this.btnZatwierdz);
            this.pgRezerwacja.Controls.Add(this.label6);
            this.pgRezerwacja.Controls.Add(this.label5);
            this.pgRezerwacja.Controls.Add(this.label4);
            this.pgRezerwacja.Controls.Add(this.label3);
            this.pgRezerwacja.Controls.Add(this.txtTelefonR);
            this.pgRezerwacja.Controls.Add(this.txtEmailR);
            this.pgRezerwacja.Controls.Add(this.txtNazwiskoR);
            this.pgRezerwacja.Controls.Add(this.mthCalendar);
            this.pgRezerwacja.Controls.Add(this.txtImieR);
            this.pgRezerwacja.Controls.Add(this.label2);
            this.pgRezerwacja.Controls.Add(this.btnAnuluj);
            this.pgRezerwacja.Location = new System.Drawing.Point(4, 24);
            this.pgRezerwacja.Name = "pgRezerwacja";
            this.pgRezerwacja.Padding = new System.Windows.Forms.Padding(3);
            this.pgRezerwacja.Size = new System.Drawing.Size(660, 538);
            this.pgRezerwacja.TabIndex = 1;
            this.pgRezerwacja.Text = "Rezerwacja";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btnAnuluj.FlatAppearance.BorderSize = 0;
            this.btnAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuluj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnuluj.Location = new System.Drawing.Point(337, 499);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(151, 33);
            this.btnAnuluj.TabIndex = 3;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            // 
            // pgKoszyk
            // 
            this.pgKoszyk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(216)))), ((int)(((byte)(162)))));
            this.pgKoszyk.Location = new System.Drawing.Point(4, 24);
            this.pgKoszyk.Name = "pgKoszyk";
            this.pgKoszyk.Size = new System.Drawing.Size(660, 538);
            this.pgKoszyk.TabIndex = 2;
            this.pgKoszyk.Text = "Koszyk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imię";
            // 
            // txtImieR
            // 
            this.txtImieR.Location = new System.Drawing.Point(450, 63);
            this.txtImieR.Name = "txtImieR";
            this.txtImieR.Size = new System.Drawing.Size(100, 26);
            this.txtImieR.TabIndex = 5;
            // 
            // mthCalendar
            // 
            this.mthCalendar.Location = new System.Drawing.Point(368, 325);
            this.mthCalendar.Name = "mthCalendar";
            this.mthCalendar.TabIndex = 6;
            // 
            // txtNazwiskoR
            // 
            this.txtNazwiskoR.Location = new System.Drawing.Point(454, 137);
            this.txtNazwiskoR.Name = "txtNazwiskoR";
            this.txtNazwiskoR.Size = new System.Drawing.Size(100, 26);
            this.txtNazwiskoR.TabIndex = 7;
            // 
            // txtEmailR
            // 
            this.txtEmailR.Location = new System.Drawing.Point(454, 198);
            this.txtEmailR.Name = "txtEmailR";
            this.txtEmailR.Size = new System.Drawing.Size(100, 26);
            this.txtEmailR.TabIndex = 8;
            // 
            // txtTelefonR
            // 
            this.txtTelefonR.Location = new System.Drawing.Point(454, 256);
            this.txtTelefonR.Name = "txtTelefonR";
            this.txtTelefonR.Size = new System.Drawing.Size(100, 26);
            this.txtTelefonR.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data";
            // 
            // btnZatwierdz
            // 
            this.btnZatwierdz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btnZatwierdz.FlatAppearance.BorderSize = 0;
            this.btnZatwierdz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatwierdz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnZatwierdz.Location = new System.Drawing.Point(494, 499);
            this.btnZatwierdz.Name = "btnZatwierdz";
            this.btnZatwierdz.Size = new System.Drawing.Size(154, 33);
            this.btnZatwierdz.TabIndex = 14;
            this.btnZatwierdz.Text = "Zatwierdź";
            this.btnZatwierdz.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(216)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home4u";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.pgRezerwacja.ResumeLayout(false);
            this.pgRezerwacja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pgLista;
        private System.Windows.Forms.TabPage pgRezerwacja;
        private System.Windows.Forms.Button btnRezerwacje;
        private System.Windows.Forms.TabPage pgKoszyk;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefonR;
        private System.Windows.Forms.TextBox txtEmailR;
        private System.Windows.Forms.TextBox txtNazwiskoR;
        private System.Windows.Forms.MonthCalendar mthCalendar;
        private System.Windows.Forms.TextBox txtImieR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZatwierdz;
    }
}

