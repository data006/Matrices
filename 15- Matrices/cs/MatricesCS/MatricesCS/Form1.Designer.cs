namespace MatricesCS
{
	partial class frmMatricesCS
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
			this.Label7 = new System.Windows.Forms.Label();
			this.btnSolve = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmbC2 = new System.Windows.Forms.ComboBox();
			this.cmbR2 = new System.Windows.Forms.ComboBox();
			this.cmbC1 = new System.Windows.Forms.ComboBox();
			this.cmbR1 = new System.Windows.Forms.ComboBox();
			this.cmbOperacion = new System.Windows.Forms.ComboBox();
			this.txtMatriz2 = new System.Windows.Forms.TextBox();
			this.txtMatriz1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Label7
			// 
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(217, 294);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(189, 13);
			this.Label7.TabIndex = 43;
			this.Label7.Text = "Ingresar datos separados por espacios";
			// 
			// btnSolve
			// 
			this.btnSolve.Location = new System.Drawing.Point(262, 195);
			this.btnSolve.Name = "btnSolve";
			this.btnSolve.Size = new System.Drawing.Size(75, 23);
			this.btnSolve.TabIndex = 42;
			this.btnSolve.Text = "Solve";
			this.btnSolve.UseVisualStyleBackColor = true;
			this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(467, 67);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(14, 13);
			this.Label6.TabIndex = 41;
			this.Label6.Text = "C";
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(140, 67);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(14, 13);
			this.Label5.TabIndex = 40;
			this.Label5.Text = "C";
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(356, 67);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(15, 13);
			this.Label4.TabIndex = 39;
			this.Label4.Text = "R";
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(30, 67);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(15, 13);
			this.Label3.TabIndex = 38;
			this.Label3.Text = "R";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(412, 18);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(110, 31);
			this.Label2.TabIndex = 37;
			this.Label2.Text = "Matriz 2";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(85, 18);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(110, 31);
			this.Label1.TabIndex = 36;
			this.Label1.Text = "Matriz 1";
			// 
			// cmbC2
			// 
			this.cmbC2.FormattingEnabled = true;
			this.cmbC2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cmbC2.Location = new System.Drawing.Point(487, 64);
			this.cmbC2.Name = "cmbC2";
			this.cmbC2.Size = new System.Drawing.Size(70, 21);
			this.cmbC2.TabIndex = 35;
			// 
			// cmbR2
			// 
			this.cmbR2.FormattingEnabled = true;
			this.cmbR2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cmbR2.Location = new System.Drawing.Point(377, 64);
			this.cmbR2.Name = "cmbR2";
			this.cmbR2.Size = new System.Drawing.Size(70, 21);
			this.cmbR2.TabIndex = 34;
			// 
			// cmbC1
			// 
			this.cmbC1.FormattingEnabled = true;
			this.cmbC1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cmbC1.Location = new System.Drawing.Point(161, 64);
			this.cmbC1.Name = "cmbC1";
			this.cmbC1.Size = new System.Drawing.Size(70, 21);
			this.cmbC1.TabIndex = 33;
			// 
			// cmbR1
			// 
			this.cmbR1.FormattingEnabled = true;
			this.cmbR1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cmbR1.Location = new System.Drawing.Point(51, 64);
			this.cmbR1.Name = "cmbR1";
			this.cmbR1.Size = new System.Drawing.Size(70, 21);
			this.cmbR1.TabIndex = 32;
			// 
			// cmbOperacion
			// 
			this.cmbOperacion.FormattingEnabled = true;
			this.cmbOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "T"});
			this.cmbOperacion.Location = new System.Drawing.Point(257, 168);
			this.cmbOperacion.Name = "cmbOperacion";
			this.cmbOperacion.Size = new System.Drawing.Size(88, 21);
			this.cmbOperacion.TabIndex = 31;
			// 
			// txtMatriz2
			// 
			this.txtMatriz2.Location = new System.Drawing.Point(377, 91);
			this.txtMatriz2.Multiline = true;
			this.txtMatriz2.Name = "txtMatriz2";
			this.txtMatriz2.Size = new System.Drawing.Size(180, 174);
			this.txtMatriz2.TabIndex = 30;
			// 
			// txtMatriz1
			// 
			this.txtMatriz1.Location = new System.Drawing.Point(51, 91);
			this.txtMatriz1.Multiline = true;
			this.txtMatriz1.Name = "txtMatriz1";
			this.txtMatriz1.Size = new System.Drawing.Size(180, 174);
			this.txtMatriz1.TabIndex = 29;
			// 
			// frmMatricesCS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 331);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.btnSolve);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cmbC2);
			this.Controls.Add(this.cmbR2);
			this.Controls.Add(this.cmbC1);
			this.Controls.Add(this.cmbR1);
			this.Controls.Add(this.cmbOperacion);
			this.Controls.Add(this.txtMatriz2);
			this.Controls.Add(this.txtMatriz1);
			this.Name = "frmMatricesCS";
			this.Text = "Matrices";
			this.Load += new System.EventHandler(this.frmMatricesCS_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Button btnSolve;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox cmbC2;
		internal System.Windows.Forms.ComboBox cmbR2;
		internal System.Windows.Forms.ComboBox cmbC1;
		internal System.Windows.Forms.ComboBox cmbR1;
		internal System.Windows.Forms.ComboBox cmbOperacion;
		internal System.Windows.Forms.TextBox txtMatriz2;
		internal System.Windows.Forms.TextBox txtMatriz1;
	}
}

