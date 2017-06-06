namespace Automotriz
{
    partial class Workshop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal_Cars = new System.Windows.Forms.Label();
            this.txtCar_Plate = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd_to_Workshop = new System.Windows.Forms.Button();
            this.dgvCars_in_repair = new System.Windows.Forms.DataGridView();
            this.dgvCars_in_maintenance = new System.Windows.Forms.DataGridView();
            this.cmbService_Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCar_Mark = new System.Windows.Forms.Label();
            this.lblCar_Model = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCar_Owner = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars_in_repair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars_in_maintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehiculos en reparación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehiculos en Mantenimeinto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total de vehiculos en el taller:";
            // 
            // lblTotal_Cars
            // 
            this.lblTotal_Cars.AutoSize = true;
            this.lblTotal_Cars.Location = new System.Drawing.Point(418, 17);
            this.lblTotal_Cars.Name = "lblTotal_Cars";
            this.lblTotal_Cars.Size = new System.Drawing.Size(28, 13);
            this.lblTotal_Cars.TabIndex = 4;
            this.lblTotal_Cars.Text = "###";
            // 
            // txtCar_Plate
            // 
            this.txtCar_Plate.Location = new System.Drawing.Point(28, 291);
            this.txtCar_Plate.Name = "txtCar_Plate";
            this.txtCar_Plate.Size = new System.Drawing.Size(100, 20);
            this.txtCar_Plate.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(904, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Volver al menú";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd_to_Workshop
            // 
            this.btnAdd_to_Workshop.Location = new System.Drawing.Point(352, 289);
            this.btnAdd_to_Workshop.Name = "btnAdd_to_Workshop";
            this.btnAdd_to_Workshop.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_to_Workshop.TabIndex = 9;
            this.btnAdd_to_Workshop.Text = "Añadir";
            this.btnAdd_to_Workshop.UseVisualStyleBackColor = true;
            // 
            // dgvCars_in_repair
            // 
            this.dgvCars_in_repair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars_in_repair.Location = new System.Drawing.Point(12, 78);
            this.dgvCars_in_repair.Name = "dgvCars_in_repair";
            this.dgvCars_in_repair.Size = new System.Drawing.Size(488, 150);
            this.dgvCars_in_repair.TabIndex = 10;
            // 
            // dgvCars_in_maintenance
            // 
            this.dgvCars_in_maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars_in_maintenance.Location = new System.Drawing.Point(540, 78);
            this.dgvCars_in_maintenance.Name = "dgvCars_in_maintenance";
            this.dgvCars_in_maintenance.Size = new System.Drawing.Size(488, 150);
            this.dgvCars_in_maintenance.TabIndex = 11;
            // 
            // cmbService_Type
            // 
            this.cmbService_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService_Type.FormattingEnabled = true;
            this.cmbService_Type.Items.AddRange(new object[] {
            "Mantenimiento",
            "Reparacion"});
            this.cmbService_Type.Location = new System.Drawing.Point(225, 291);
            this.cmbService_Type.Name = "cmbService_Type";
            this.cmbService_Type.Size = new System.Drawing.Size(121, 21);
            this.cmbService_Type.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Añadir vehiculos al taller";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Placa del Vehiculo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Servicio";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnSearch.Location = new System.Drawing.Point(134, 289);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Marca";
            // 
            // lblCar_Mark
            // 
            this.lblCar_Mark.AutoSize = true;
            this.lblCar_Mark.Location = new System.Drawing.Point(86, 325);
            this.lblCar_Mark.Name = "lblCar_Mark";
            this.lblCar_Mark.Size = new System.Drawing.Size(28, 13);
            this.lblCar_Mark.TabIndex = 18;
            this.lblCar_Mark.Text = "XXX";
            // 
            // lblCar_Model
            // 
            this.lblCar_Model.AutoSize = true;
            this.lblCar_Model.Location = new System.Drawing.Point(86, 348);
            this.lblCar_Model.Name = "lblCar_Model";
            this.lblCar_Model.Size = new System.Drawing.Size(28, 13);
            this.lblCar_Model.TabIndex = 20;
            this.lblCar_Model.Text = "XXX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Modelo";
            // 
            // lblCar_Owner
            // 
            this.lblCar_Owner.AutoSize = true;
            this.lblCar_Owner.Location = new System.Drawing.Point(239, 325);
            this.lblCar_Owner.Name = "lblCar_Owner";
            this.lblCar_Owner.Size = new System.Drawing.Size(28, 13);
            this.lblCar_Owner.TabIndex = 22;
            this.lblCar_Owner.Text = "XXX";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Propietario";
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 395);
            this.Controls.Add(this.lblCar_Owner);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblCar_Model);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCar_Mark);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbService_Type);
            this.Controls.Add(this.dgvCars_in_maintenance);
            this.Controls.Add(this.dgvCars_in_repair);
            this.Controls.Add(this.btnAdd_to_Workshop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCar_Plate);
            this.Controls.Add(this.lblTotal_Cars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Workshop";
            this.Text = "Workshop";
            this.Load += new System.EventHandler(this.Workshop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars_in_repair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars_in_maintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal_Cars;
        private System.Windows.Forms.TextBox txtCar_Plate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd_to_Workshop;
        private System.Windows.Forms.DataGridView dgvCars_in_repair;
        private System.Windows.Forms.DataGridView dgvCars_in_maintenance;
        private System.Windows.Forms.ComboBox cmbService_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCar_Mark;
        private System.Windows.Forms.Label lblCar_Model;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCar_Owner;
        private System.Windows.Forms.Label label12;
    }
}