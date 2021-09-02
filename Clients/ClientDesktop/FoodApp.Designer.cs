
namespace ClientDesktop
{
    partial class FoodApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodApp));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIngredient = new System.Windows.Forms.Button();
            this.btnPlat = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.bntAccueil = new System.Windows.Forms.Button();
            this.btnComposezMenuJ = new System.Windows.Forms.Button();
            this.panForm = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.33029F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.66971F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panForm, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1169, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnIngredient, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnPlat, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnMenu, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnReservation, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bntAccueil, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnComposezMenuJ, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 614);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnIngredient
            // 
            this.btnIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIngredient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngredient.Location = new System.Drawing.Point(3, 309);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Size = new System.Drawing.Size(213, 96);
            this.btnIngredient.TabIndex = 2;
            this.btnIngredient.Text = "Ingredients";
            this.btnIngredient.UseVisualStyleBackColor = true;
            this.btnIngredient.Click += new System.EventHandler(this.btnIngredient_Click);
            // 
            // btnPlat
            // 
            this.btnPlat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlat.Location = new System.Drawing.Point(3, 411);
            this.btnPlat.Name = "btnPlat";
            this.btnPlat.Size = new System.Drawing.Size(213, 96);
            this.btnPlat.TabIndex = 3;
            this.btnPlat.Text = "Plats";
            this.btnPlat.UseVisualStyleBackColor = true;
            this.btnPlat.Click += new System.EventHandler(this.btnPlat_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.Location = new System.Drawing.Point(3, 207);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(213, 96);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menus";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservation.Location = new System.Drawing.Point(3, 105);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(213, 96);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "Reservations";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // bntAccueil
            // 
            this.bntAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntAccueil.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntAccueil.Location = new System.Drawing.Point(3, 3);
            this.bntAccueil.Name = "bntAccueil";
            this.bntAccueil.Size = new System.Drawing.Size(213, 96);
            this.bntAccueil.TabIndex = 4;
            this.bntAccueil.Text = "Accueil";
            this.bntAccueil.UseVisualStyleBackColor = true;
            this.bntAccueil.Click += new System.EventHandler(this.bntAccueil_Click);
            // 
            // btnComposezMenuJ
            // 
            this.btnComposezMenuJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComposezMenuJ.Location = new System.Drawing.Point(3, 513);
            this.btnComposezMenuJ.Name = "btnComposezMenuJ";
            this.btnComposezMenuJ.Size = new System.Drawing.Size(213, 98);
            this.btnComposezMenuJ.TabIndex = 5;
            this.btnComposezMenuJ.Text = "Composez le menu du jour";
            this.btnComposezMenuJ.UseVisualStyleBackColor = true;
            this.btnComposezMenuJ.Click += new System.EventHandler(this.btnComposezMenuJ_Click);
            // 
            // panForm
            // 
            this.panForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panForm.BackgroundImage")));
            this.panForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panForm.Location = new System.Drawing.Point(235, 10);
            this.panForm.Margin = new System.Windows.Forms.Padding(10);
            this.panForm.Name = "panForm";
            this.panForm.Padding = new System.Windows.Forms.Padding(50);
            this.panForm.Size = new System.Drawing.Size(924, 600);
            this.panForm.TabIndex = 1;
            this.panForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panForm_Paint);
            // 
            // FoodApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FoodApp";
            this.Text = "FoodApp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnIngredient;
        private System.Windows.Forms.Button btnPlat;
        private System.Windows.Forms.Button bntAccueil;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Panel panForm;
        private System.Windows.Forms.Button btnComposezMenuJ;
    }
}