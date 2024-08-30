namespace ConexionEjemplo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.lbContactTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tboxContacName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(648, 38);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(572, 280);
            this.dataGrid.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCargar.Location = new System.Drawing.Point(1046, 383);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(164, 34);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Informaciòn";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBuscar.Location = new System.Drawing.Point(768, 386);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(214, 31);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar usuarios ";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID usuarios ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.txtBuscar.Location = new System.Drawing.Point(809, 347);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(126, 20);
            this.txtBuscar.TabIndex = 6;
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.BackColor = System.Drawing.SystemColors.Info;
            this.tboxCustomerID.Location = new System.Drawing.Point(304, 46);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(126, 20);
            this.tboxCustomerID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = " ID usuarios ";
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.BackColor = System.Drawing.SystemColors.Info;
            this.tboxCompanyName.Location = new System.Drawing.Point(304, 104);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(126, 20);
            this.tboxCompanyName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre de Compañia ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.BackColor = System.Drawing.SystemColors.Info;
            this.tboxContactTitle.Location = new System.Drawing.Point(303, 212);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(126, 20);
            this.tboxContactTitle.TabIndex = 12;
            // 
            // lbContactTitle
            // 
            this.lbContactTitle.AutoSize = true;
            this.lbContactTitle.Location = new System.Drawing.Point(189, 212);
            this.lbContactTitle.Name = "lbContactTitle";
            this.lbContactTitle.Size = new System.Drawing.Size(108, 13);
            this.lbContactTitle.TabIndex = 11;
            this.lbContactTitle.Text = "Numero de Contacto ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customers ID";
            // 
            // tboxAddress
            // 
            this.tboxAddress.BackColor = System.Drawing.SystemColors.Info;
            this.tboxAddress.Location = new System.Drawing.Point(311, 256);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(126, 20);
            this.tboxAddress.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Direccion\r\n";
            // 
            // tboxCity
            // 
            this.tboxCity.BackColor = System.Drawing.SystemColors.Info;
            this.tboxCity.Location = new System.Drawing.Point(311, 298);
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(126, 20);
            this.tboxCity.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ciudad";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnInsertar.Location = new System.Drawing.Point(69, 406);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(179, 42);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Ingresar ";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // tboxContacName
            // 
            this.tboxContacName.BackColor = System.Drawing.SystemColors.Info;
            this.tboxContacName.Location = new System.Drawing.Point(304, 159);
            this.tboxContacName.Name = "tboxContacName";
            this.tboxContacName.Size = new System.Drawing.Size(126, 20);
            this.tboxContacName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Contacto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btModificar.Location = new System.Drawing.Point(268, 406);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(179, 43);
            this.btModificar.TabIndex = 22;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEliminar.Location = new System.Drawing.Point(467, 406);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(179, 43);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar usuario ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 514);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.tboxContacName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tboxCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.lbContactTitle);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.Label lbContactTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tboxContacName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

