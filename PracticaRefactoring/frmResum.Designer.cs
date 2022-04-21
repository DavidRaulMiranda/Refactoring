namespace PracticaRefactoring
{
    partial class frmResum
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
            this.lblObservacions = new System.Windows.Forms.Label();
            this.dtgProductes = new System.Windows.Forms.DataGridView();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbldescompte = new System.Windows.Forms.Label();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblBrut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblestat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObservacions
            // 
            this.lblObservacions.AutoSize = true;
            this.lblObservacions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacions.Location = new System.Drawing.Point(423, 9);
            this.lblObservacions.Name = "lblObservacions";
            this.lblObservacions.Size = new System.Drawing.Size(88, 13);
            this.lblObservacions.TabIndex = 23;
            this.lblObservacions.Text = "Observacions:";
            // 
            // dtgProductes
            // 
            this.dtgProductes.AllowUserToAddRows = false;
            this.dtgProductes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductes.Location = new System.Drawing.Point(31, 118);
            this.dtgProductes.MultiSelect = false;
            this.dtgProductes.Name = "dtgProductes";
            this.dtgProductes.ReadOnly = true;
            this.dtgProductes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductes.Size = new System.Drawing.Size(380, 229);
            this.dtgProductes.TabIndex = 24;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(48, 29);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(22, 13);
            this.lblComanda.TabIndex = 34;
            this.lblComanda.Text = "-0-";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(377, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(22, 13);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "-0-";
            // 
            // lbldescompte
            // 
            this.lbldescompte.AutoSize = true;
            this.lbldescompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescompte.Location = new System.Drawing.Point(297, 404);
            this.lbldescompte.Name = "lbldescompte";
            this.lbldescompte.Size = new System.Drawing.Size(22, 13);
            this.lbldescompte.TabIndex = 32;
            this.lbldescompte.Text = "-0-";
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesa.Location = new System.Drawing.Point(213, 404);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(22, 13);
            this.lblDespesa.TabIndex = 31;
            this.lblDespesa.Text = "-0-";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(126, 404);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(22, 13);
            this.lblIva.TabIndex = 30;
            this.lblIva.Text = "-0-";
            // 
            // lblBrut
            // 
            this.lblBrut.AutoSize = true;
            this.lblBrut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrut.Location = new System.Drawing.Point(48, 404);
            this.lblBrut.Name = "lblBrut";
            this.lblBrut.Size = new System.Drawing.Size(22, 13);
            this.lblBrut.TabIndex = 29;
            this.lblBrut.Text = "-0-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Import Brut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Despeses env.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Descompte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Import Net";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(48, 58);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(22, 13);
            this.lblClient.TabIndex = 40;
            this.lblClient.Text = "-0-";
            // 
            // lblestat
            // 
            this.lblestat.AutoSize = true;
            this.lblestat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestat.Location = new System.Drawing.Point(423, 41);
            this.lblestat.Name = "lblestat";
            this.lblestat.Size = new System.Drawing.Size(22, 13);
            this.lblestat.TabIndex = 41;
            this.lblestat.Text = "-0-";
            // 
            // frmResum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblestat);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbldescompte);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblBrut);
            this.Controls.Add(this.dtgProductes);
            this.Controls.Add(this.lblObservacions);
            this.Name = "frmResum";
            this.Text = "Resum de comanda";
            this.Load += new System.EventHandler(this.frmResum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblObservacions;
        private System.Windows.Forms.DataGridView dtgProductes;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbldescompte;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblBrut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblestat;
    }
}