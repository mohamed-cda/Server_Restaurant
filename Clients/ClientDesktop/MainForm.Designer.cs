
namespace ClientDesktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManu = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnPlat = new System.Windows.Forms.Button();
            this.btnIngredients = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnManu, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReservation, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPlat, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnIngredients, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(582, 401);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnManu
            // 
            this.btnManu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManu.Location = new System.Drawing.Point(3, 3);
            this.btnManu.Name = "btnManu";
            this.btnManu.Size = new System.Drawing.Size(285, 194);
            this.btnManu.TabIndex = 0;
            this.btnManu.Text = "Menus";
            this.btnManu.UseVisualStyleBackColor = true;
            
            // 
            // btnReservation
            // 
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReservation.Location = new System.Drawing.Point(294, 3);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(285, 194);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "Reservations";
            this.btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnPlat
            // 
            this.btnPlat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlat.Location = new System.Drawing.Point(3, 203);
            this.btnPlat.Name = "btnPlat";
            this.btnPlat.Size = new System.Drawing.Size(285, 195);
            this.btnPlat.TabIndex = 2;
            this.btnPlat.Text = "Plats";
            this.btnPlat.UseVisualStyleBackColor = true;
            
            // 
            // btnIngredients
            // 
            this.btnIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIngredients.Location = new System.Drawing.Point(294, 203);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Size = new System.Drawing.Size(285, 195);
            this.btnIngredients.TabIndex = 3;
            this.btnIngredients.Text = "Ingredients";
            this.btnIngredients.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(582, 401);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "MainForm";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnGestMenu;
        private System.Windows.Forms.Button btnGestResrvation;
        private System.Windows.Forms.Button btnGestPlat;
        private System.Windows.Forms.Button btnVisuCommande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnManu;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnPlat;
        private System.Windows.Forms.Button btnIngredients;
    }
}

