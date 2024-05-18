namespace NicoCala.Prototipos.Ej4
{
    partial class PersonasForm
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
            PersonasList = new ListView();
            DocumentoCol = new ColumnHeader();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            TelefonoCol = new ColumnHeader();
            EliminarBoton = new Button();
            EditarBoton = new Button();
            NuevoBoton = new Button();
            ListaGroup = new GroupBox();
            ListaGroup.SuspendLayout();
            SuspendLayout();
            // 
            // PersonasList
            // 
            PersonasList.Columns.AddRange(new ColumnHeader[] { DocumentoCol, NombreCol, ApellidoCol, TelefonoCol });
            PersonasList.FullRowSelect = true;
            PersonasList.GridLines = true;
            PersonasList.Location = new Point(6, 29);
            PersonasList.MultiSelect = false;
            PersonasList.Name = "PersonasList";
            PersonasList.Size = new Size(734, 243);
            PersonasList.TabIndex = 0;
            PersonasList.UseCompatibleStateImageBehavior = false;
            PersonasList.View = View.Details;
            // 
            // DocumentoCol
            // 
            DocumentoCol.Text = "Documento";
            DocumentoCol.Width = 90;
            // 
            // NombreCol
            // 
            NombreCol.Text = "Nombre";
            NombreCol.Width = 180;
            // 
            // ApellidoCol
            // 
            ApellidoCol.Text = "Apellido";
            ApellidoCol.Width = 180;
            // 
            // TelefonoCol
            // 
            TelefonoCol.Text = "Telefono";
            TelefonoCol.Width = 180;
            // 
            // EliminarBoton
            // 
            EliminarBoton.Location = new Point(658, 278);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(75, 23);
            EliminarBoton.TabIndex = 1;
            EliminarBoton.Text = "&Eliminar";
            EliminarBoton.UseVisualStyleBackColor = true;
            EliminarBoton.Click += EliminarBoton_Click;
            // 
            // EditarBoton
            // 
            EditarBoton.Location = new Point(577, 278);
            EditarBoton.Name = "EditarBoton";
            EditarBoton.Size = new Size(75, 23);
            EditarBoton.TabIndex = 2;
            EditarBoton.Text = "Editar";
            EditarBoton.UseVisualStyleBackColor = true;
            EditarBoton.Click += EditarBoton_Click;
            // 
            // NuevoBoton
            // 
            NuevoBoton.Location = new Point(496, 278);
            NuevoBoton.Name = "NuevoBoton";
            NuevoBoton.Size = new Size(75, 23);
            NuevoBoton.TabIndex = 3;
            NuevoBoton.Text = "Nuevo";
            NuevoBoton.UseVisualStyleBackColor = true;
            NuevoBoton.Click += NuevoBoton_Click;
            // 
            // ListaGroup
            // 
            ListaGroup.Controls.Add(PersonasList);
            ListaGroup.Controls.Add(EditarBoton);
            ListaGroup.Controls.Add(NuevoBoton);
            ListaGroup.Controls.Add(EliminarBoton);
            ListaGroup.Location = new Point(12, 12);
            ListaGroup.Name = "ListaGroup";
            ListaGroup.Size = new Size(750, 307);
            ListaGroup.TabIndex = 5;
            ListaGroup.TabStop = false;
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 327);
            Controls.Add(ListaGroup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PersonasForm";
            Text = "Form1";
            Load += PersonasForm_Load;
            ListaGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView PersonasList;
        private ColumnHeader DocumentoCol;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader TelefonoCol;
        private Button EliminarBoton;
        private Button EditarBoton;
        private Button NuevoBoton;
        private GroupBox ListaGroup;
    }
}
