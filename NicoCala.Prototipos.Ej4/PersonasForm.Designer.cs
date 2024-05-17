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
            EdicionGroupBox = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            EdicionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // PersonasList
            // 
            PersonasList.Columns.AddRange(new ColumnHeader[] { DocumentoCol, NombreCol, ApellidoCol, TelefonoCol });
            PersonasList.FullRowSelect = true;
            PersonasList.GridLines = true;
            PersonasList.Location = new Point(12, 12);
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
            EliminarBoton.Location = new Point(671, 261);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(75, 23);
            EliminarBoton.TabIndex = 1;
            EliminarBoton.Text = "&Eliminar";
            EliminarBoton.UseVisualStyleBackColor = true;
            // 
            // EditarBoton
            // 
            EditarBoton.Location = new Point(590, 261);
            EditarBoton.Name = "EditarBoton";
            EditarBoton.Size = new Size(75, 23);
            EditarBoton.TabIndex = 2;
            EditarBoton.Text = "Editar";
            EditarBoton.UseVisualStyleBackColor = true;
            // 
            // NuevoBoton
            // 
            NuevoBoton.Location = new Point(509, 261);
            NuevoBoton.Name = "NuevoBoton";
            NuevoBoton.Size = new Size(75, 23);
            NuevoBoton.TabIndex = 3;
            NuevoBoton.Text = "Nuevo";
            NuevoBoton.UseVisualStyleBackColor = true;
            // 
            // EdicionGroupBox
            // 
            EdicionGroupBox.Controls.Add(textBox6);
            EdicionGroupBox.Controls.Add(label7);
            EdicionGroupBox.Controls.Add(textBox5);
            EdicionGroupBox.Controls.Add(label6);
            EdicionGroupBox.Controls.Add(textBox4);
            EdicionGroupBox.Controls.Add(label5);
            EdicionGroupBox.Controls.Add(comboBox1);
            EdicionGroupBox.Controls.Add(label4);
            EdicionGroupBox.Controls.Add(textBox3);
            EdicionGroupBox.Controls.Add(label3);
            EdicionGroupBox.Controls.Add(textBox2);
            EdicionGroupBox.Controls.Add(label2);
            EdicionGroupBox.Controls.Add(textBox1);
            EdicionGroupBox.Controls.Add(label1);
            EdicionGroupBox.Location = new Point(17, 305);
            EdicionGroupBox.Name = "EdicionGroupBox";
            EdicionGroupBox.Size = new Size(734, 298);
            EdicionGroupBox.TabIndex = 4;
            EdicionGroupBox.TabStop = false;
            EdicionGroupBox.Text = "EdicionGroup";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 19);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Documento";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(544, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 19);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Documento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 102);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 23);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 84);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 9;
            label5.Text = "Documento";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(354, 102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 23);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 84);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 11;
            label6.Text = "Documento";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(544, 102);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 23);
            textBox6.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 84);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 13;
            label7.Text = "Documento";
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 615);
            Controls.Add(EdicionGroupBox);
            Controls.Add(NuevoBoton);
            Controls.Add(EditarBoton);
            Controls.Add(EliminarBoton);
            Controls.Add(PersonasList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PersonasForm";
            Text = "Form1";
            Load += PersonasForm_Load;
            EdicionGroupBox.ResumeLayout(false);
            EdicionGroupBox.PerformLayout();
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
        private GroupBox EdicionGroupBox;
        private Label label1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox1;
    }
}
