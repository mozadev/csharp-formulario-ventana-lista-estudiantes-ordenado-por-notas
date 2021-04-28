
namespace ListasEstudiantePOO
{
    partial class Form1
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
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxInformacion = new System.Windows.Forms.ListBox();
            this.btnORDEN = new System.Windows.Forms.Button();
            this.listBoxordenado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(270, 138);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(132, 23);
            this.btnAgregarEstudiante.TabIndex = 0;
            this.btnAgregarEstudiante.Text = "Agregrar Estudiante";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(215, 96);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(187, 23);
            this.txtEdad.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(215, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad";
            // 
            // listBoxInformacion
            // 
            this.listBoxInformacion.FormattingEnabled = true;
            this.listBoxInformacion.ItemHeight = 15;
            this.listBoxInformacion.Location = new System.Drawing.Point(270, 187);
            this.listBoxInformacion.Name = "listBoxInformacion";
            this.listBoxInformacion.Size = new System.Drawing.Size(132, 124);
            this.listBoxInformacion.TabIndex = 5;
            // 
            // btnORDEN
            // 
            this.btnORDEN.Location = new System.Drawing.Point(138, 138);
            this.btnORDEN.Name = "btnORDEN";
            this.btnORDEN.Size = new System.Drawing.Size(103, 23);
            this.btnORDEN.TabIndex = 6;
            this.btnORDEN.Text = "ordenar por edad";
            this.btnORDEN.UseVisualStyleBackColor = true;
            this.btnORDEN.Click += new System.EventHandler(this.btnORDEN_Click);
            // 
            // listBoxordenado
            // 
            this.listBoxordenado.FormattingEnabled = true;
            this.listBoxordenado.ItemHeight = 15;
            this.listBoxordenado.Location = new System.Drawing.Point(138, 187);
            this.listBoxordenado.Name = "listBoxordenado";
            this.listBoxordenado.Size = new System.Drawing.Size(120, 124);
            this.listBoxordenado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxordenado);
            this.Controls.Add(this.btnORDEN);
            this.Controls.Add(this.listBoxInformacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxInformacion;
        private System.Windows.Forms.Button btnORDEN;
        private System.Windows.Forms.ListBox listBoxordenado;
    }
}

