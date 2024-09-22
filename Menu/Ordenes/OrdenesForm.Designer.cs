namespace LoginCAI.Menu.Ordenes
{
    partial class OrdenesForm
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
            mostrarOrdenesBtn = new Button();
            GenerarOrdenBtn = new Button();
            SuspendLayout();
            // 
            // mostrarOrdenesBtn
            // 
            mostrarOrdenesBtn.Location = new Point(81, 44);
            mostrarOrdenesBtn.Name = "mostrarOrdenesBtn";
            mostrarOrdenesBtn.Size = new Size(182, 41);
            mostrarOrdenesBtn.TabIndex = 0;
            mostrarOrdenesBtn.Text = "Mostrar Ordenes";
            mostrarOrdenesBtn.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenBtn
            // 
            GenerarOrdenBtn.Location = new Point(488, 44);
            GenerarOrdenBtn.Name = "GenerarOrdenBtn";
            GenerarOrdenBtn.Size = new Size(181, 41);
            GenerarOrdenBtn.TabIndex = 1;
            GenerarOrdenBtn.Text = "Generar Orden Preparacion";
            GenerarOrdenBtn.UseVisualStyleBackColor = true;
            GenerarOrdenBtn.Click += button2_Click;
            // 
            // OrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GenerarOrdenBtn);
            Controls.Add(mostrarOrdenesBtn);
            Name = "OrdenesForm";
            Text = "OrdenesForm";
            ResumeLayout(false);
        }

        #endregion

        private Button mostrarOrdenesBtn;
        private Button GenerarOrdenBtn;
    }
}