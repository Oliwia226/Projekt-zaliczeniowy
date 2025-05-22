namespace projekt___angielski_quiz
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dotlumaczenia = new System.Windows.Forms.TextBox();
            this.tlumacz = new System.Windows.Forms.Button();
            this.tlumaczenie = new System.Windows.Forms.Label();
            this.losowe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.odpowiedz = new System.Windows.Forms.TextBox();
            this.czas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.prawidlowe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bledne = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.dotlumaczenia, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlumacz, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlumaczenie, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dotlumaczenia
            // 
            this.dotlumaczenia.Location = new System.Drawing.Point(4, 4);
            this.dotlumaczenia.Multiline = true;
            this.dotlumaczenia.Name = "dotlumaczenia";
            this.dotlumaczenia.Size = new System.Drawing.Size(313, 30);
            this.dotlumaczenia.TabIndex = 0;
            // 
            // tlumacz
            // 
            this.tlumacz.Location = new System.Drawing.Point(324, 4);
            this.tlumacz.Name = "tlumacz";
            this.tlumacz.Size = new System.Drawing.Size(153, 30);
            this.tlumacz.TabIndex = 1;
            this.tlumacz.Text = "TŁUMACZ";
            this.tlumacz.UseVisualStyleBackColor = true;
            this.tlumacz.Click += new System.EventHandler(this.tlumacz_Click);
            // 
            // tlumaczenie
            // 
            this.tlumaczenie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlumaczenie.Location = new System.Drawing.Point(484, 1);
            this.tlumaczenie.Name = "tlumaczenie";
            this.tlumaczenie.Size = new System.Drawing.Size(314, 30);
            this.tlumaczenie.TabIndex = 2;
            this.tlumaczenie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // losowe
            // 
            this.losowe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.losowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.losowe.Location = new System.Drawing.Point(149, 155);
            this.losowe.Name = "losowe";
            this.losowe.Size = new System.Drawing.Size(150, 30);
            this.losowe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(353, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "⟶";
            // 
            // odpowiedz
            // 
            this.odpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odpowiedz.Location = new System.Drawing.Point(470, 149);
            this.odpowiedz.Name = "odpowiedz";
            this.odpowiedz.Size = new System.Drawing.Size(150, 36);
            this.odpowiedz.TabIndex = 4;
            this.odpowiedz.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // czas
            // 
            this.czas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.Location = new System.Drawing.Point(720, 55);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(70, 40);
            this.czas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(516, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pozostały czas:";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(14, 55);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(140, 40);
            this.start.TabIndex = 7;
            this.start.Text = "Rozpocznij test";
            this.start.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prawidłowe odpowiedzi:";
            // 
            // prawidlowe
            // 
            this.prawidlowe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prawidlowe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prawidlowe.Location = new System.Drawing.Point(172, 232);
            this.prawidlowe.Name = "prawidlowe";
            this.prawidlowe.Size = new System.Drawing.Size(35, 35);
            this.prawidlowe.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Błędne odpowiedzi:";
            // 
            // bledne
            // 
            this.bledne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bledne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bledne.Location = new System.Drawing.Point(417, 232);
            this.bledne.Name = "bledne";
            this.bledne.Size = new System.Drawing.Size(35, 35);
            this.bledne.TabIndex = 11;
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.Location = new System.Drawing.Point(160, 55);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(40, 40);
            this.info.TabIndex = 12;
            this.info.Text = "?";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 503);
            this.Controls.Add(this.info);
            this.Controls.Add(this.bledne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prawidlowe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.odpowiedz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.losowe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox dotlumaczenia;
        private System.Windows.Forms.Button tlumacz;
        private System.Windows.Forms.Label tlumaczenie;
        private System.Windows.Forms.Label losowe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odpowiedz;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prawidlowe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bledne;
        private System.Windows.Forms.Button info;
    }
}

