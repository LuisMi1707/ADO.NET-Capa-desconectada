namespace CapaDesconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridNoTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBusquedaNt = new System.Windows.Forms.TextBox();
            this.btnBuscarNt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarTIpado = new System.Windows.Forms.Button();
            this.tboxBuscarTipado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.tboxCompaniName = new System.Windows.Forms.TextBox();
            this.tboxContactName = new System.Windows.Forms.TextBox();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.tboxAddres = new System.Windows.Forms.TextBox();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.btnInsertarT = new System.Windows.Forms.Button();
            this.btnActualizarNT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridNoTipado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet No Tipado";
            // 
            // gridNoTipado
            // 
            this.gridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNoTipado.Location = new System.Drawing.Point(0, 32);
            this.gridNoTipado.Name = "gridNoTipado";
            this.gridNoTipado.Size = new System.Drawing.Size(337, 217);
            this.gridNoTipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(451, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(0, 32);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(337, 217);
            this.gridTipado.TabIndex = 0;
            this.gridTipado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTipado_CellContentClick);
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(66, 273);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(209, 23);
            this.btnObtenerNoTipado.TabIndex = 2;
            this.btnObtenerNoTipado.Text = "Obtener Datos No Tipado";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(523, 273);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(209, 23);
            this.btnObtenerTipado.TabIndex = 3;
            this.btnObtenerTipado.Text = "Obtener Datos Tipado";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Cliente";
            // 
            // tbBusquedaNt
            // 
            this.tbBusquedaNt.Location = new System.Drawing.Point(90, 317);
            this.tbBusquedaNt.Name = "tbBusquedaNt";
            this.tbBusquedaNt.Size = new System.Drawing.Size(100, 20);
            this.tbBusquedaNt.TabIndex = 5;
            // 
            // btnBuscarNt
            // 
            this.btnBuscarNt.Location = new System.Drawing.Point(12, 343);
            this.btnBuscarNt.Name = "btnBuscarNt";
            this.btnBuscarNt.Size = new System.Drawing.Size(112, 36);
            this.btnBuscarNt.TabIndex = 6;
            this.btnBuscarNt.Text = "Buscar Cliente";
            this.btnBuscarNt.UseVisualStyleBackColor = true;
            this.btnBuscarNt.Click += new System.EventHandler(this.btnBuscarNt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CustomerID";
            // 
            // btnBuscarTIpado
            // 
            this.btnBuscarTIpado.Location = new System.Drawing.Point(460, 360);
            this.btnBuscarTIpado.Name = "btnBuscarTIpado";
            this.btnBuscarTIpado.Size = new System.Drawing.Size(123, 36);
            this.btnBuscarTIpado.TabIndex = 9;
            this.btnBuscarTIpado.Text = "Enviar";
            this.btnBuscarTIpado.UseVisualStyleBackColor = true;
            this.btnBuscarTIpado.Click += new System.EventHandler(this.btnBuscarTIpado_Click);
            // 
            // tboxBuscarTipado
            // 
            this.tboxBuscarTipado.Location = new System.Drawing.Point(609, 320);
            this.tboxBuscarTipado.Name = "tboxBuscarTipado";
            this.tboxBuscarTipado.Size = new System.Drawing.Size(100, 20);
            this.tboxBuscarTipado.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CustomerID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Company Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contact Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(811, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contact Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Addres";
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(898, 58);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.tboxCustomerID.TabIndex = 15;
            this.tboxCustomerID.TextChanged += new System.EventHandler(this.tboxCustomerID_TextChanged);
            // 
            // tboxCompaniName
            // 
            this.tboxCompaniName.Location = new System.Drawing.Point(899, 84);
            this.tboxCompaniName.Name = "tboxCompaniName";
            this.tboxCompaniName.Size = new System.Drawing.Size(100, 20);
            this.tboxCompaniName.TabIndex = 16;
            // 
            // tboxContactName
            // 
            this.tboxContactName.Location = new System.Drawing.Point(898, 113);
            this.tboxContactName.Name = "tboxContactName";
            this.tboxContactName.Size = new System.Drawing.Size(100, 20);
            this.tboxContactName.TabIndex = 17;
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(898, 142);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(100, 20);
            this.tboxContactTitle.TabIndex = 18;
            // 
            // tboxAddres
            // 
            this.tboxAddres.Location = new System.Drawing.Point(898, 173);
            this.tboxAddres.Name = "tboxAddres";
            this.tboxAddres.Size = new System.Drawing.Size(100, 20);
            this.tboxAddres.TabIndex = 19;
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(228, 317);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(112, 36);
            this.btnInsertarCliente.TabIndex = 20;
            this.btnInsertarCliente.Text = "Insertar Cliente NT";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // btnInsertarT
            // 
            this.btnInsertarT.Location = new System.Drawing.Point(625, 360);
            this.btnInsertarT.Name = "btnInsertarT";
            this.btnInsertarT.Size = new System.Drawing.Size(123, 36);
            this.btnInsertarT.TabIndex = 21;
            this.btnInsertarT.Text = "Insertar Cliente T";
            this.btnInsertarT.UseVisualStyleBackColor = true;
            this.btnInsertarT.Click += new System.EventHandler(this.btnInsertarT_Click);
            // 
            // btnActualizarNT
            // 
            this.btnActualizarNT.Location = new System.Drawing.Point(228, 370);
            this.btnActualizarNT.Name = "btnActualizarNT";
            this.btnActualizarNT.Size = new System.Drawing.Size(112, 36);
            this.btnActualizarNT.TabIndex = 22;
            this.btnActualizarNT.Text = "Actualizar";
            this.btnActualizarNT.UseVisualStyleBackColor = true;
            this.btnActualizarNT.Click += new System.EventHandler(this.btnActualizarNT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.btnActualizarNT);
            this.Controls.Add(this.btnInsertarT);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.tboxAddres);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.tboxContactName);
            this.Controls.Add(this.tboxCompaniName);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxBuscarTipado);
            this.Controls.Add(this.btnBuscarTIpado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarNt);
            this.Controls.Add(this.tbBusquedaNt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTipado);
            this.Controls.Add(this.btnObtenerNoTipado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridNoTipado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBusquedaNt;
        private System.Windows.Forms.Button btnBuscarNt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarTIpado;
        private System.Windows.Forms.TextBox tboxBuscarTipado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.TextBox tboxCompaniName;
        private System.Windows.Forms.TextBox tboxContactName;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.TextBox tboxAddres;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Button btnInsertarT;
        private System.Windows.Forms.Button btnActualizarNT;
    }
}

