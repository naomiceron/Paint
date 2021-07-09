namespace PaintNuevo
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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnArco = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnPentagono = new System.Windows.Forms.Button();
            this.btnPoligonoIR = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.clrdColores = new System.Windows.Forms.ColorDialog();
            this.pnlColores = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.nudGrosorLinea = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosorLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Location = new System.Drawing.Point(1, 1);
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1187, 768);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // btnLinea
            // 
            this.btnLinea.Location = new System.Drawing.Point(13, 778);
            this.btnLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(100, 28);
            this.btnLinea.TabIndex = 0;
            this.btnLinea.Text = "Linea";
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(13, 814);
            this.btnCirculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(100, 28);
            this.btnCirculo.TabIndex = 1;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnArco
            // 
            this.btnArco.Location = new System.Drawing.Point(121, 778);
            this.btnArco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArco.Name = "btnArco";
            this.btnArco.Size = new System.Drawing.Size(100, 28);
            this.btnArco.TabIndex = 2;
            this.btnArco.Text = "Arco";
            this.btnArco.UseVisualStyleBackColor = true;
            this.btnArco.Click += new System.EventHandler(this.btnArco_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(121, 814);
            this.btnTriangulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(100, 28);
            this.btnTriangulo.TabIndex = 3;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(229, 778);
            this.btnCuadrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(100, 28);
            this.btnCuadrado.TabIndex = 4;
            this.btnCuadrado.Text = "Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(229, 814);
            this.btnRectangulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(100, 28);
            this.btnRectangulo.TabIndex = 5;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnPentagono
            // 
            this.btnPentagono.Location = new System.Drawing.Point(337, 778);
            this.btnPentagono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPentagono.Name = "btnPentagono";
            this.btnPentagono.Size = new System.Drawing.Size(100, 28);
            this.btnPentagono.TabIndex = 6;
            this.btnPentagono.Text = "Pentagono";
            this.btnPentagono.UseVisualStyleBackColor = true;
            this.btnPentagono.Click += new System.EventHandler(this.btnPentagono_Click);
            // 
            // btnPoligonoIR
            // 
            this.btnPoligonoIR.Location = new System.Drawing.Point(337, 814);
            this.btnPoligonoIR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoligonoIR.Name = "btnPoligonoIR";
            this.btnPoligonoIR.Size = new System.Drawing.Size(100, 28);
            this.btnPoligonoIR.TabIndex = 7;
            this.btnPoligonoIR.Text = "Poligono Irrregular";
            this.btnPoligonoIR.UseVisualStyleBackColor = true;
            this.btnPoligonoIR.Click += new System.EventHandler(this.btnPoligonoIR_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(445, 778);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 28);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pnlColores
            // 
            this.pnlColores.BackColor = System.Drawing.Color.Black;
            this.pnlColores.Location = new System.Drawing.Point(553, 778);
            this.pnlColores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlColores.Name = "pnlColores";
            this.pnlColores.Size = new System.Drawing.Size(61, 62);
            this.pnlColores.TabIndex = 9;
            this.pnlColores.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(445, 812);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // nudGrosorLinea
            // 
            this.nudGrosorLinea.Location = new System.Drawing.Point(623, 782);
            this.nudGrosorLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudGrosorLinea.Name = "nudGrosorLinea";
            this.nudGrosorLinea.Size = new System.Drawing.Size(160, 22);
            this.nudGrosorLinea.TabIndex = 11;
            this.nudGrosorLinea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 844);
            this.Controls.Add(this.nudGrosorLinea);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.pnlColores);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnPoligonoIR);
            this.Controls.Add(this.btnPentagono);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnArco);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnLinea);
            this.Controls.Add(this.pnlCanvas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosorLinea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnArco;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnPentagono;
        private System.Windows.Forms.Button btnPoligonoIR;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog clrdColores;
        private System.Windows.Forms.Panel pnlColores;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.NumericUpDown nudGrosorLinea;
    }
}

