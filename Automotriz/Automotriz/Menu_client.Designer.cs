namespace Automotriz
{
    partial class Menu_client
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvClient_Info = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId_Cliente = new System.Windows.Forms.Label();
            this.dgvCars_Owner = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarvehiculo = new System.Windows.Forms.TextBox();
            this.btnBuscarvehiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars_Owner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(676, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 20);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvClient_Info
            // 
            this.dgvClient_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient_Info.Location = new System.Drawing.Point(15, 82);
            this.dgvClient_Info.Name = "dgvClient_Info";
            this.dgvClient_Info.Size = new System.Drawing.Size(623, 84);
            this.dgvClient_Info.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Información personal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Id Cliente:";
            // 
            // lblId_Cliente
            // 
            this.lblId_Cliente.AutoSize = true;
            this.lblId_Cliente.Location = new System.Drawing.Point(73, 9);
            this.lblId_Cliente.Name = "lblId_Cliente";
            this.lblId_Cliente.Size = new System.Drawing.Size(35, 13);
            this.lblId_Cliente.TabIndex = 25;
            this.lblId_Cliente.Text = "XXXX";
            // 
            // dgvCars_Owner
            // 
            this.dgvCars_Owner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars_Owner.Location = new System.Drawing.Point(12, 195);
            this.dgvCars_Owner.Name = "dgvCars_Owner";
            this.dgvCars_Owner.Size = new System.Drawing.Size(753, 176);
            this.dgvCars_Owner.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vehiculos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Digite la placa del vehiculo ";
            // 
            // txtBuscarvehiculo
            // 
            this.txtBuscarvehiculo.Location = new System.Drawing.Point(155, 405);
            this.txtBuscarvehiculo.Name = "txtBuscarvehiculo";
            this.txtBuscarvehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarvehiculo.TabIndex = 29;
            this.txtBuscarvehiculo.TextChanged += new System.EventHandler(this.txtBuscarvehiculo_TextChanged);
            // 
            // btnBuscarvehiculo
            // 
            this.btnBuscarvehiculo.Location = new System.Drawing.Point(261, 405);
            this.btnBuscarvehiculo.Name = "btnBuscarvehiculo";
            this.btnBuscarvehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarvehiculo.TabIndex = 30;
            this.btnBuscarvehiculo.Text = "Buscar";
            this.btnBuscarvehiculo.UseVisualStyleBackColor = true;
            this.btnBuscarvehiculo.Click += new System.EventHandler(this.btnBuscarvehiculo_Click);
            // 
            // Menu_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 464);
            this.Controls.Add(this.btnBuscarvehiculo);
            this.Controls.Add(this.txtBuscarvehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCars_Owner);
            this.Controls.Add(this.lblId_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClient_Info);
            this.Controls.Add(this.btnSalir);
            this.Name = "Menu_client";
            this.Text = "Menu_client";
            this.Load += new System.EventHandler(this.Menu_client_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars_Owner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvClient_Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId_Cliente;
        private System.Windows.Forms.DataGridView dgvCars_Owner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarvehiculo;
        private System.Windows.Forms.Button btnBuscarvehiculo;
    }
}