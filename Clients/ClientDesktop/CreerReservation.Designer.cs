
namespace ClientDesktop
{
    partial class CreerReservation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DateReseravation = new System.Windows.Forms.Label();
            this.lblNomReservation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNomReservation = new System.Windows.Forms.TextBox();
            this.textPrenomReservation = new System.Windows.Forms.TextBox();
            this.textTelephoneReservation = new System.Windows.Forms.TextBox();
            this.textQuantiteReservation = new System.Windows.Forms.TextBox();
            this.btnValiderAjout = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtnMidi = new System.Windows.Forms.RadioButton();
            this.radioBtnSoir = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DateReseravation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNomReservation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textNomReservation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textPrenomReservation, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textTelephoneReservation, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textQuantiteReservation, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnValiderAjout, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 293);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DateReseravation
            // 
            this.DateReseravation.AutoSize = true;
            this.DateReseravation.Location = new System.Drawing.Point(3, 0);
            this.DateReseravation.Name = "DateReseravation";
            this.DateReseravation.Size = new System.Drawing.Size(108, 15);
            this.DateReseravation.TabIndex = 0;
            this.DateReseravation.Text = "Date de reservation";
            // 
            // lblNomReservation
            // 
            this.lblNomReservation.AutoSize = true;
            this.lblNomReservation.Location = new System.Drawing.Point(3, 29);
            this.lblNomReservation.Name = "lblNomReservation";
            this.lblNomReservation.Size = new System.Drawing.Size(34, 15);
            this.lblNomReservation.TabIndex = 1;
            this.lblNomReservation.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Téléphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantitée";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Formule";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Midi ou Soir";
            // 
            // textNomReservation
            // 
            this.textNomReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNomReservation.Location = new System.Drawing.Point(153, 32);
            this.textNomReservation.Name = "textNomReservation";
            this.textNomReservation.Size = new System.Drawing.Size(301, 23);
            this.textNomReservation.TabIndex = 9;
            // 
            // textPrenomReservation
            // 
            this.textPrenomReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPrenomReservation.Location = new System.Drawing.Point(153, 61);
            this.textPrenomReservation.Name = "textPrenomReservation";
            this.textPrenomReservation.Size = new System.Drawing.Size(301, 23);
            this.textPrenomReservation.TabIndex = 10;
            // 
            // textTelephoneReservation
            // 
            this.textTelephoneReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTelephoneReservation.Location = new System.Drawing.Point(153, 90);
            this.textTelephoneReservation.Name = "textTelephoneReservation";
            this.textTelephoneReservation.Size = new System.Drawing.Size(301, 23);
            this.textTelephoneReservation.TabIndex = 11;
            // 
            // textQuantiteReservation
            // 
            this.textQuantiteReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textQuantiteReservation.Location = new System.Drawing.Point(153, 119);
            this.textQuantiteReservation.Name = "textQuantiteReservation";
            this.textQuantiteReservation.Size = new System.Drawing.Size(301, 23);
            this.textQuantiteReservation.TabIndex = 12;
            // 
            // btnValiderAjout
            // 
            this.btnValiderAjout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValiderAjout.Location = new System.Drawing.Point(3, 218);
            this.btnValiderAjout.Name = "btnValiderAjout";
            this.btnValiderAjout.Size = new System.Drawing.Size(144, 83);
            this.btnValiderAjout.TabIndex = 15;
            this.btnValiderAjout.Text = "Valider";
            this.btnValiderAjout.UseVisualStyleBackColor = true;
            this.btnValiderAjout.Click += new System.EventHandler(this.btnValiderAjout_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioBtnMidi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioBtnSoir, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(153, 188);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 24);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // radioBtnMidi
            // 
            this.radioBtnMidi.AutoSize = true;
            this.radioBtnMidi.Location = new System.Drawing.Point(3, 3);
            this.radioBtnMidi.Name = "radioBtnMidi";
            this.radioBtnMidi.Size = new System.Drawing.Size(49, 18);
            this.radioBtnMidi.TabIndex = 0;
            this.radioBtnMidi.TabStop = true;
            this.radioBtnMidi.Text = "Midi";
            this.radioBtnMidi.UseVisualStyleBackColor = true;
            // 
            // radioBtnSoir
            // 
            this.radioBtnSoir.AutoSize = true;
            this.radioBtnSoir.Location = new System.Drawing.Point(153, 3);
            this.radioBtnSoir.Name = "radioBtnSoir";
            this.radioBtnSoir.Size = new System.Drawing.Size(45, 18);
            this.radioBtnSoir.TabIndex = 1;
            this.radioBtnSoir.TabStop = true;
            this.radioBtnSoir.Text = "Soir";
            this.radioBtnSoir.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(153, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 34);
            this.listBox1.TabIndex = 18;
            // 
            // CreerReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 293);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(473, 332);
            this.Name = "CreerReservation";
            this.Text = "Creer Reservation  mobil";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DateReseravation;
        private System.Windows.Forms.Label lblNomReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNomReservation;
        private System.Windows.Forms.TextBox textPrenomReservation;
        private System.Windows.Forms.TextBox textTelephoneReservation;
        private System.Windows.Forms.TextBox textQuantiteReservation;
        private System.Windows.Forms.Button btnValiderAjout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioBtnMidi;
        private System.Windows.Forms.RadioButton radioBtnSoir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
    }
}