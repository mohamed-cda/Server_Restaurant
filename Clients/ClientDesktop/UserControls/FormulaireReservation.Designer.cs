
namespace ClientDesktop.UserControls
{
    partial class FormulaireReservation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualiserResrvation = new System.Windows.Forms.Button();
            this.dataGridResrvation = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPage = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bntSuivant = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResrvation)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActualiserResrvation, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridResrvation, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(509, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Liste des reservations";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnActualiserResrvation
            // 
            this.btnActualiserResrvation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualiserResrvation.Location = new System.Drawing.Point(3, 503);
            this.btnActualiserResrvation.Name = "btnActualiserResrvation";
            this.btnActualiserResrvation.Size = new System.Drawing.Size(509, 44);
            this.btnActualiserResrvation.TabIndex = 1;
            this.btnActualiserResrvation.Text = "Actueliser";
            this.btnActualiserResrvation.UseVisualStyleBackColor = true;
            
            // 
            // dataGridResrvation
            // 
            this.dataGridResrvation.AllowUserToAddRows = false;
            this.dataGridResrvation.AllowUserToDeleteRows = false;
            this.dataGridResrvation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridResrvation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResrvation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResrvation.Location = new System.Drawing.Point(3, 53);
            this.dataGridResrvation.Name = "dataGridResrvation";
            this.dataGridResrvation.ReadOnly = true;
            this.dataGridResrvation.RowTemplate.Height = 25;
            this.dataGridResrvation.Size = new System.Drawing.Size(509, 444);
            this.dataGridResrvation.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.03312F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.96688F));
            this.tableLayoutPanel5.Controls.Add(this.lblPage, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bntSuivant, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 553);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(509, 44);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPage.Location = new System.Drawing.Point(205, 14);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(54, 15);
            this.lblPage.TabIndex = 6;
            this.lblPage.Text = "page";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(124, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "<<< ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bntSuivant
            // 
            this.bntSuivant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bntSuivant.Location = new System.Drawing.Point(265, 10);
            this.bntSuivant.Name = "bntSuivant";
            this.bntSuivant.Size = new System.Drawing.Size(75, 23);
            this.bntSuivant.TabIndex = 8;
            this.bntSuivant.Text = ">>>";
            this.bntSuivant.UseVisualStyleBackColor = true;
            // 
            // FormulaireReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormulaireReservation";
            this.Size = new System.Drawing.Size(515, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResrvation)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualiserResrvation;
        private System.Windows.Forms.DataGridView dataGridResrvation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntSuivant;
    }
}
