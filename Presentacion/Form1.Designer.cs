
namespace Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboBoxCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtBoxFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 58);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(640, 282);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(14, 24);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 1;
            this.lblCampo.Text = "Campo:";
            // 
            // cboBoxCampo
            // 
            this.cboBoxCampo.FormattingEnabled = true;
            this.cboBoxCampo.Location = new System.Drawing.Point(70, 21);
            this.cboBoxCampo.Name = "cboBoxCampo";
            this.cboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.cboBoxCampo.TabIndex = 2;
            this.cboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.cboBoxCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(229, 24);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 3;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cboBoxCriterio
            // 
            this.cboBoxCriterio.FormattingEnabled = true;
            this.cboBoxCriterio.Location = new System.Drawing.Point(289, 21);
            this.cboBoxCriterio.Name = "cboBoxCriterio";
            this.cboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboBoxCriterio.TabIndex = 4;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(451, 24);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtBoxFiltro
            // 
            this.txtBoxFiltro.Location = new System.Drawing.Point(508, 21);
            this.txtBoxFiltro.Name = "txtBoxFiltro";
            this.txtBoxFiltro.Size = new System.Drawing.Size(117, 20);
            this.txtBoxFiltro.TabIndex = 6;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(695, 19);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(91, 23);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(669, 58);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(281, 282);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulo.TabIndex = 8;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(311, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 28);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(421, 369);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 29);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(531, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 29);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(770, 373);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 16;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(134, 374);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(137, 20);
            this.textBoxFiltroAvanzado.TabIndex = 17;
            this.textBoxFiltroAvanzado.TextChanged += new System.EventHandler(this.textBoxFiltroAvanzado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filtro Avanzado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtBoxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cboBoxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboBoxCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.dgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1120, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboBoxCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboBoxCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtBoxFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Label label1;
    }
}

