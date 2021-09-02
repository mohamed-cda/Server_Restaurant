
namespace ClientDesktop.UserControls
{
    partial class FormulaireIngredient
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
            this.btnActivationBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomIngredient = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixIngredient = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bntCreerIngredient = new System.Windows.Forms.Button();
            this.btnModifierIngredient = new System.Windows.Forms.Button();
            this.bntSupprimerIngredient = new System.Windows.Forms.Button();
            this.dataGridViewIngredient = new System.Windows.Forms.DataGridView();
            this.panIngrPiedPage = new System.Windows.Forms.TableLayoutPanel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.bntSuivant = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredient)).BeginInit();
            this.panIngrPiedPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnActivationBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewIngredient, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panIngrPiedPage, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnActivationBtn
            // 
            this.btnActivationBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActivationBtn.Location = new System.Drawing.Point(3, 3);
            this.btnActivationBtn.Name = "btnActivationBtn";
            this.btnActivationBtn.Size = new System.Drawing.Size(509, 44);
            this.btnActivationBtn.TabIndex = 0;
            this.btnActivationBtn.Text = "Creer un nouvel ingredient";
            this.btnActivationBtn.UseVisualStyleBackColor = true;
            this.btnActivationBtn.Click += new System.EventHandler(this.btnActivationBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNomIngredient, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(509, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtNomIngredient
            // 
            this.txtNomIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomIngredient.Location = new System.Drawing.Point(103, 10);
            this.txtNomIngredient.Name = "txtNomIngredient";
            this.txtNomIngredient.Size = new System.Drawing.Size(403, 23);
            this.txtNomIngredient.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPrixIngredient, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(509, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prix";
            // 
            // txtPrixIngredient
            // 
            this.txtPrixIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrixIngredient.Location = new System.Drawing.Point(103, 10);
            this.txtPrixIngredient.Name = "txtPrixIngredient";
            this.txtPrixIngredient.Size = new System.Drawing.Size(403, 23);
            this.txtPrixIngredient.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.bntCreerIngredient, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnModifierIngredient, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.bntSupprimerIngredient, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(509, 44);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // bntCreerIngredient
            // 
            this.bntCreerIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntCreerIngredient.Location = new System.Drawing.Point(3, 3);
            this.bntCreerIngredient.Name = "bntCreerIngredient";
            this.bntCreerIngredient.Size = new System.Drawing.Size(163, 38);
            this.bntCreerIngredient.TabIndex = 0;
            this.bntCreerIngredient.Text = "Creer";
            this.bntCreerIngredient.UseVisualStyleBackColor = true;
            this.bntCreerIngredient.Click += new System.EventHandler(this.bntCreerIngredient_Click);
            // 
            // btnModifierIngredient
            // 
            this.btnModifierIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModifierIngredient.Location = new System.Drawing.Point(172, 3);
            this.btnModifierIngredient.Name = "btnModifierIngredient";
            this.btnModifierIngredient.Size = new System.Drawing.Size(163, 38);
            this.btnModifierIngredient.TabIndex = 1;
            this.btnModifierIngredient.Text = "Modifier";
            this.btnModifierIngredient.UseVisualStyleBackColor = true;
            this.btnModifierIngredient.Click += new System.EventHandler(this.btnModifierIngredient_Click);
            // 
            // bntSupprimerIngredient
            // 
            this.bntSupprimerIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntSupprimerIngredient.Location = new System.Drawing.Point(341, 3);
            this.bntSupprimerIngredient.Name = "bntSupprimerIngredient";
            this.bntSupprimerIngredient.Size = new System.Drawing.Size(165, 38);
            this.bntSupprimerIngredient.TabIndex = 2;
            this.bntSupprimerIngredient.Text = "Supprimer";
            this.bntSupprimerIngredient.UseVisualStyleBackColor = true;
            this.bntSupprimerIngredient.Click += new System.EventHandler(this.bntSupprimerIngredient_Click);
            // 
            // dataGridViewIngredient
            // 
            this.dataGridViewIngredient.AllowUserToAddRows = false;
            this.dataGridViewIngredient.AllowUserToDeleteRows = false;
            this.dataGridViewIngredient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIngredient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewIngredient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIngredient.Location = new System.Drawing.Point(3, 203);
            this.dataGridViewIngredient.Name = "dataGridViewIngredient";
            this.dataGridViewIngredient.ReadOnly = true;
            this.dataGridViewIngredient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewIngredient.RowTemplate.Height = 25;
            this.dataGridViewIngredient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIngredient.Size = new System.Drawing.Size(509, 305);
            this.dataGridViewIngredient.TabIndex = 4;
            // 
            // panIngrPiedPage
            // 
            this.panIngrPiedPage.ColumnCount = 3;
            this.panIngrPiedPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.03312F));
            this.panIngrPiedPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panIngrPiedPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.96688F));
            this.panIngrPiedPage.Controls.Add(this.lblPage, 1, 0);
            this.panIngrPiedPage.Controls.Add(this.btnPrecedent, 0, 0);
            this.panIngrPiedPage.Controls.Add(this.bntSuivant, 2, 0);
            this.panIngrPiedPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panIngrPiedPage.Location = new System.Drawing.Point(3, 514);
            this.panIngrPiedPage.Name = "panIngrPiedPage";
            this.panIngrPiedPage.RowCount = 1;
            this.panIngrPiedPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panIngrPiedPage.Size = new System.Drawing.Size(509, 47);
            this.panIngrPiedPage.TabIndex = 6;
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPage.AutoSize = true;
            this.lblPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPage.Location = new System.Drawing.Point(205, 16);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(54, 15);
            this.lblPage.TabIndex = 6;
            this.lblPage.Text = "page";
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrecedent.Location = new System.Drawing.Point(124, 12);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 7;
            this.btnPrecedent.Text = "<<< ";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // bntSuivant
            // 
            this.bntSuivant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bntSuivant.Location = new System.Drawing.Point(265, 12);
            this.bntSuivant.Name = "bntSuivant";
            this.bntSuivant.Size = new System.Drawing.Size(75, 23);
            this.bntSuivant.TabIndex = 8;
            this.bntSuivant.Text = ">>>";
            this.bntSuivant.UseVisualStyleBackColor = true;
            this.bntSuivant.Click += new System.EventHandler(this.bntSuivant_Click);
            // 
            // FormulaireIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormulaireIngredient";
            this.Size = new System.Drawing.Size(515, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIngredient)).EndInit();
            this.panIngrPiedPage.ResumeLayout(false);
            this.panIngrPiedPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnActivationBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomIngredient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixIngredient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button bntCreerIngredient;
        private System.Windows.Forms.Button btnModifierIngredient;
        private System.Windows.Forms.Button bntSupprimerIngredient;
        private System.Windows.Forms.DataGridView dataGridViewIngredient;
        private System.Windows.Forms.TableLayoutPanel panIngrPiedPage;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button bntSuivant;
    }
}
