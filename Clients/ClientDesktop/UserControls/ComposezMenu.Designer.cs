
namespace ClientDesktop.UserControls
{
    partial class ComposezMenu
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComposezMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chekSoir = new System.Windows.Forms.CheckBox();
            this.chekMidi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerMenu = new System.Windows.Forms.DateTimePicker();
            this.dataGridListeMenu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListeMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComposezMenu
            // 
            this.btnComposezMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComposezMenu.Location = new System.Drawing.Point(3, 3);
            this.btnComposezMenu.Name = "btnComposezMenu";
            this.btnComposezMenu.Size = new System.Drawing.Size(478, 46);
            this.btnComposezMenu.TabIndex = 0;
            this.btnComposezMenu.Text = "Afficher le menu";
            this.btnComposezMenu.UseVisualStyleBackColor = true;
            this.btnComposezMenu.Click += new System.EventHandler(this.btnComposezMenu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnComposezMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridListeMenu, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65919F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.69507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.33184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.08969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 446);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.33891F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerMenu, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 64);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chekSoir, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chekMidi, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(140, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(335, 26);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // chekSoir
            // 
            this.chekSoir.AutoSize = true;
            this.chekSoir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chekSoir.Location = new System.Drawing.Point(170, 3);
            this.chekSoir.Name = "chekSoir";
            this.chekSoir.Size = new System.Drawing.Size(46, 19);
            this.chekSoir.TabIndex = 11;
            this.chekSoir.Text = "Soir";
            this.chekSoir.UseVisualStyleBackColor = true;
            // 
            // chekMidi
            // 
            this.chekMidi.AutoSize = true;
            this.chekMidi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chekMidi.Location = new System.Drawing.Point(3, 3);
            this.chekMidi.Name = "chekMidi";
            this.chekMidi.Size = new System.Drawing.Size(50, 19);
            this.chekMidi.TabIndex = 10;
            this.chekMidi.Text = "Midi";
            this.chekMidi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionez une date";
            // 
            // dateTimePickerMenu
            // 
            this.dateTimePickerMenu.Location = new System.Drawing.Point(140, 3);
            this.dateTimePickerMenu.Name = "dateTimePickerMenu";
            this.dateTimePickerMenu.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerMenu.TabIndex = 5;
            // 
            // dataGridListeMenu
            // 
            this.dataGridListeMenu.AllowUserToAddRows = false;
            this.dataGridListeMenu.AllowUserToDeleteRows = false;
            this.dataGridListeMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListeMenu.ColumnHeadersVisible = false;
            this.dataGridListeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridListeMenu.Location = new System.Drawing.Point(3, 125);
            this.dataGridListeMenu.Name = "dataGridListeMenu";
            this.dataGridListeMenu.ReadOnly = true;
            this.dataGridListeMenu.RowHeadersVisible = false;
            this.dataGridListeMenu.RowTemplate.Height = 25;
            this.dataGridListeMenu.Size = new System.Drawing.Size(478, 272);
            this.dataGridListeMenu.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selectionez un service";
            // 
            // ComposezMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComposezMenu";
            this.Size = new System.Drawing.Size(484, 446);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListeMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnComposezMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridListeMenu;
        private System.Windows.Forms.CheckBox chekSoir;
        private System.Windows.Forms.CheckBox chekMidi;
        private System.Windows.Forms.Label label2;
    }
}
