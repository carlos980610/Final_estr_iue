namespace Automotriz
{
    partial class Part_add
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
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblPart = new System.Windows.Forms.Label();
            this.lblPart_valor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Volver al Menú";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parte :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(66, 21);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(22, 13);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "xxx";
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(66, 58);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(22, 13);
            this.lblPart.TabIndex = 6;
            this.lblPart.Text = "xxx";
            // 
            // lblPart_valor
            // 
            this.lblPart_valor.AutoSize = true;
            this.lblPart_valor.Location = new System.Drawing.Point(66, 98);
            this.lblPart_valor.Name = "lblPart_valor";
            this.lblPart_valor.Size = new System.Drawing.Size(22, 13);
            this.lblPart_valor.TabIndex = 7;
            this.lblPart_valor.Text = "xxx";
            // 
            // Part_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPart_valor);
            this.Controls.Add(this.lblPart);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "Part_add";
            this.Text = "Part_add";
            this.Load += new System.EventHandler(this.Part_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Label lblPart_valor;
    }
}