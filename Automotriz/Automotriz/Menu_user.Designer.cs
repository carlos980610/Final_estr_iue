namespace Automotriz
{
    partial class Menu_user
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
            this.txtSearch_Car = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSee_Cars = new System.Windows.Forms.Button();
            this.btnSee_Clients = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegister_Car = new System.Windows.Forms.Button();
            this.btnSeeGarage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar vehiculo:";
            // 
            // txtSearch_Car
            // 
            this.txtSearch_Car.Location = new System.Drawing.Point(104, 47);
            this.txtSearch_Car.Name = "txtSearch_Car";
            this.txtSearch_Car.Size = new System.Drawing.Size(154, 20);
            this.txtSearch_Car.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(266, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 20);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSee_Cars
            // 
            this.btnSee_Cars.Location = new System.Drawing.Point(16, 115);
            this.btnSee_Cars.Name = "btnSee_Cars";
            this.btnSee_Cars.Size = new System.Drawing.Size(141, 23);
            this.btnSee_Cars.TabIndex = 3;
            this.btnSee_Cars.Text = "Ver Vehiculos";
            this.btnSee_Cars.UseVisualStyleBackColor = true;
            this.btnSee_Cars.Click += new System.EventHandler(this.btnSee_Cars_Click);
            // 
            // btnSee_Clients
            // 
            this.btnSee_Clients.Location = new System.Drawing.Point(16, 144);
            this.btnSee_Clients.Name = "btnSee_Clients";
            this.btnSee_Clients.Size = new System.Drawing.Size(141, 23);
            this.btnSee_Clients.TabIndex = 4;
            this.btnSee_Clients.Text = "Ver Clientes";
            this.btnSee_Clients.UseVisualStyleBackColor = true;
            this.btnSee_Clients.Click += new System.EventHandler(this.btnSee_Clients_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(283, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnRegister_Car
            // 
            this.btnRegister_Car.Location = new System.Drawing.Point(163, 115);
            this.btnRegister_Car.Name = "btnRegister_Car";
            this.btnRegister_Car.Size = new System.Drawing.Size(141, 23);
            this.btnRegister_Car.TabIndex = 6;
            this.btnRegister_Car.Text = "Registar Vehiculo";
            this.btnRegister_Car.UseVisualStyleBackColor = true;
            this.btnRegister_Car.Click += new System.EventHandler(this.btnRegister_Car_Click);
            // 
            // btnSeeGarage
            // 
            this.btnSeeGarage.Location = new System.Drawing.Point(163, 144);
            this.btnSeeGarage.Name = "btnSeeGarage";
            this.btnSeeGarage.Size = new System.Drawing.Size(141, 23);
            this.btnSeeGarage.TabIndex = 7;
            this.btnSeeGarage.Text = "Ver Taller";
            this.btnSeeGarage.UseVisualStyleBackColor = true;
            // 
            // Menu_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.btnSeeGarage);
            this.Controls.Add(this.btnRegister_Car);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSee_Clients);
            this.Controls.Add(this.btnSee_Cars);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtSearch_Car);
            this.Controls.Add(this.label1);
            this.Name = "Menu_user";
            this.Text = "Menu_user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch_Car;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSee_Cars;
        private System.Windows.Forms.Button btnSee_Clients;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegister_Car;
        private System.Windows.Forms.Button btnSeeGarage;
    }
}