
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reoadBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.preview = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.LblNumPage = new System.Windows.Forms.Label();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClientMobil = new System.Windows.Forms.Button();
            this.btnClientDesktop = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.reoadBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.reservationDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.188161F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.81184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // reoadBtn
            // 
            this.reoadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reoadBtn.Location = new System.Drawing.Point(730, 0);
            this.reoadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reoadBtn.Name = "reoadBtn";
            this.reoadBtn.Size = new System.Drawing.Size(119, 33);
            this.reoadBtn.TabIndex = 0;
            this.reoadBtn.Text = "Reload";
            this.reoadBtn.UseVisualStyleBackColor = true;
            this.reoadBtn.Click += new System.EventHandler(this.reoadBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.preview, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.next, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblNumPage, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(730, 461);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(100, 37);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // preview
            // 
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Location = new System.Drawing.Point(3, 3);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(27, 31);
            this.preview.TabIndex = 0;
            this.preview.Text = "<";
            this.preview.UseVisualStyleBackColor = true;
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // next
            // 
            this.next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.next.Location = new System.Drawing.Point(69, 3);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(28, 31);
            this.next.TabIndex = 1;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // LblNumPage
            // 
            this.LblNumPage.AutoSize = true;
            this.LblNumPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNumPage.Location = new System.Drawing.Point(36, 0);
            this.LblNumPage.Name = "LblNumPage";
            this.LblNumPage.Size = new System.Drawing.Size(27, 37);
            this.LblNumPage.TabIndex = 2;
            this.LblNumPage.Text = "1";
            this.LblNumPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.reservationDataGridView, 2);
            this.reservationDataGridView.Location = new System.Drawing.Point(3, 36);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.ReadOnly = true;
            this.reservationDataGridView.RowHeadersVisible = false;
            this.reservationDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.reservationDataGridView.RowTemplate.Height = 25;
            this.reservationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationDataGridView.Size = new System.Drawing.Size(843, 416);
            this.reservationDataGridView.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.BtnClientMobil, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClientDesktop, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSupprimer, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 464);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(340, 43);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // BtnClientMobil
            // 
            this.BtnClientMobil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClientMobil.Location = new System.Drawing.Point(3, 3);
            this.BtnClientMobil.Name = "BtnClientMobil";
            this.BtnClientMobil.Size = new System.Drawing.Size(107, 37);
            this.BtnClientMobil.TabIndex = 0;
            this.BtnClientMobil.Text = "Client mobil";
            this.BtnClientMobil.UseVisualStyleBackColor = true;
            this.BtnClientMobil.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnClientDesktop
            // 
            this.btnClientDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientDesktop.Location = new System.Drawing.Point(116, 3);
            this.btnClientDesktop.Name = "btnClientDesktop";
            this.btnClientDesktop.Size = new System.Drawing.Size(107, 37);
            this.btnClientDesktop.TabIndex = 1;
            this.btnClientDesktop.Text = "Client Desktop";
            this.btnClientDesktop.UseVisualStyleBackColor = true;
            this.btnClientDesktop.Click += new System.EventHandler(this.btnClientDesktop_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupprimer.Location = new System.Drawing.Point(229, 3);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(108, 37);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button reoadBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label LblNumPage;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnClientMobil;
        private System.Windows.Forms.Button btnClientDesktop;
        private System.Windows.Forms.Button btnSupprimer;
    }
}

