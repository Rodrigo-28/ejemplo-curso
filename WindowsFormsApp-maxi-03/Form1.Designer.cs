
namespace WindowsFormsApp_maxi_03
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listElemento = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkBoxChocolate = new System.Windows.Forms.CheckBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupTipos = new System.Windows.Forms.GroupBox();
            this.rbtVenezuela = new System.Windows.Forms.RadioButton();
            this.rtbperu = new System.Windows.Forms.RadioButton();
            this.rbtArgentina = new System.Windows.Forms.RadioButton();
            this.labelColor = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.groupTipos.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNombre.Location = new System.Drawing.Point(212, 46);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(200, 20);
            this.textNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(81, 519);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listElemento
            // 
            this.listElemento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listElemento.Location = new System.Drawing.Point(81, 282);
            this.listElemento.Name = "listElemento";
            this.listElemento.Size = new System.Drawing.Size(219, 218);
            this.listElemento.TabIndex = 6;
            this.listElemento.UseCompatibleStateImageBehavior = false;
            this.listElemento.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(92, 79);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(90, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "fecha Nacimiento";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaNacimiento.Location = new System.Drawing.Point(212, 73);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimiento.TabIndex = 1;
            // 
            // checkBoxChocolate
            // 
            this.checkBoxChocolate.AutoSize = true;
            this.checkBoxChocolate.Location = new System.Drawing.Point(206, 130);
            this.checkBoxChocolate.Name = "checkBoxChocolate";
            this.checkBoxChocolate.Size = new System.Drawing.Size(125, 17);
            this.checkBoxChocolate.TabIndex = 2;
            this.checkBoxChocolate.Text = "te gusta el chocolate";
            this.checkBoxChocolate.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(211, 4);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(178, 31);
            this.labelTitulo.TabIndex = 7;
            this.labelTitulo.Text = "perfil persona";
            // 
            // groupTipos
            // 
            this.groupTipos.Controls.Add(this.rbtVenezuela);
            this.groupTipos.Controls.Add(this.rtbperu);
            this.groupTipos.Controls.Add(this.rbtArgentina);
            this.groupTipos.Location = new System.Drawing.Point(108, 163);
            this.groupTipos.Name = "groupTipos";
            this.groupTipos.Size = new System.Drawing.Size(334, 48);
            this.groupTipos.TabIndex = 3;
            this.groupTipos.TabStop = false;
            this.groupTipos.Text = "tipo";
            // 
            // rbtVenezuela
            // 
            this.rbtVenezuela.AutoSize = true;
            this.rbtVenezuela.Location = new System.Drawing.Point(219, 16);
            this.rbtVenezuela.Name = "rbtVenezuela";
            this.rbtVenezuela.Size = new System.Drawing.Size(74, 17);
            this.rbtVenezuela.TabIndex = 2;
            this.rbtVenezuela.Text = "venezuela";
            this.rbtVenezuela.UseVisualStyleBackColor = true;
            // 
            // rtbperu
            // 
            this.rtbperu.AutoSize = true;
            this.rtbperu.Location = new System.Drawing.Point(125, 16);
            this.rtbperu.Name = "rtbperu";
            this.rtbperu.Size = new System.Drawing.Size(46, 17);
            this.rtbperu.TabIndex = 1;
            this.rtbperu.Text = "peru";
            this.rtbperu.UseVisualStyleBackColor = true;
            // 
            // rbtArgentina
            // 
            this.rbtArgentina.AutoSize = true;
            this.rbtArgentina.Checked = true;
            this.rbtArgentina.Location = new System.Drawing.Point(9, 19);
            this.rbtArgentina.Name = "rbtArgentina";
            this.rbtArgentina.Size = new System.Drawing.Size(69, 17);
            this.rbtArgentina.TabIndex = 0;
            this.rbtArgentina.TabStop = true;
            this.rbtArgentina.Text = "argentina";
            this.rbtArgentina.UseVisualStyleBackColor = true;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(108, 218);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(69, 13);
            this.labelColor.TabIndex = 9;
            this.labelColor.Text = "Color favorito";
            // 
            // cboColor
            // 
            this.cboColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(268, 218);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(174, 21);
            this.cboColor.TabIndex = 4;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(95, 253);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 5;
            this.btnVerPerfil.Text = "ver perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 644);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.groupTipos);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.checkBoxChocolate);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listElemento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textNombre);
            this.MaximumSize = new System.Drawing.Size(796, 683);
            this.MinimumSize = new System.Drawing.Size(594, 625);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupTipos.ResumeLayout(false);
            this.groupTipos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listElemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.CheckBox checkBoxChocolate;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupTipos;
        private System.Windows.Forms.RadioButton rbtVenezuela;
        private System.Windows.Forms.RadioButton rtbperu;
        private System.Windows.Forms.RadioButton rbtArgentina;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

