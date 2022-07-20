using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatricesCS
{
	public partial class frmMatricesCS : Form
	{
		public frmMatricesCS()
		{
			InitializeComponent();
		}

		private void frmMatricesCS_Load(object sender, EventArgs e)
		{
			cmbOperacion.SelectedIndex = 0;
			cmbR1.SelectedIndex = 0;
			cmbC1.SelectedIndex = 0;
			cmbR2.SelectedIndex = 0;
			cmbC2.SelectedIndex = 0;
		}

		private void btnSolve_Click(object sender, EventArgs e)
		{
			var matrizUno = txtMatriz1.Text.Split(' ');
			var matrizDos = txtMatriz2.Text.Split(' ');
			int R1, R2, C1, C2, i = default(int), l, d;
			R1 = Conversions.ToInteger(cmbR1.SelectedItem);
			R2 = Conversions.ToInteger(cmbR2.SelectedItem);
			C1 = Conversions.ToInteger(cmbC1.SelectedItem);
			C2 = Conversions.ToInteger(cmbC2.SelectedItem);
			var M1 = new int[(R1 * C1)];
			var M2 = new int[(R2 * C2)];
			if (txtMatriz1.Text != string.Empty)
			{
				// Vaciar matrices
				foreach (var dato in matrizUno)
				{
					M1[i] = Conversions.ToInteger(dato);
					i += 1;
				}

				i = 0;
			}

			if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbOperacion.SelectedItem, "T", false)))
			{
				var matrizResultadoTranspuesta = new string[(R1 * C1)];
				MessageBox.Show("Transpuesta");
				var loopTo = C1 - 1;
				for (i = 0; i <= loopTo; i++)
				{
					for (int j = 0, loopTo1 = R1 - 1; j <= loopTo1; j++)
					{
						matrizResultadoTranspuesta[R1 * i + j] = matrizUno[C1 * j + i];
						MessageBox.Show(matrizResultadoTranspuesta[R1 * i + j]);
					}
				}

				var loopTo2 = R1 * C1 - 1;
				for (i = 0; i <= loopTo2; i++)
					matrizResultadoTranspuesta[i] = matrizResultadoTranspuesta[i];
			}

			i = 0;
			if (txtMatriz2.Text != string.Empty)
			{
				foreach (var dato in matrizDos)
				{
					M2[i] = Conversions.ToInteger(dato);
					i += 1;
				}

				i = 0;
			}












			// Resta
			if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbOperacion.SelectedItem, "-", false)))
			{
				if (C1 == C2 & R1 == R2)
				{
					MessageBox.Show("Resta");
					var M3 = new int[(R1 * C2)];
					var loopTo3 = R1 * C2 - 1;
					for (i = 0; i <= loopTo3; i++)
					{
						M3[i] = M1[i] - M2[i];
						Interaction.MsgBox(M3[i]);
					}
				}
			}






			// Suma
			if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbOperacion.SelectedItem, "+", false)))
			{
				if (C1 == C2 & R1 == R2)
				{
					MessageBox.Show("Suma");
					var M3 = new int[(R1 * C2)];
					var loopTo4 = R1 * C2 - 1;
					for (i = 0; i <= loopTo4; i++)
					{
						M3[i] = M1[i] + M2[i];
						Interaction.MsgBox(M3[i]);
					}
				}
			}









			// Multiplicacion
			if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(cmbOperacion.SelectedItem, "*", false)))
			{
				if (C1 == R2)
				{
					MessageBox.Show("Multiplicacion");
					var M3 = new int[(R1 * C2)];
					var loopTo5 = C2 - 1;
					for (i = 0; i <= loopTo5; i++)
					{
						for (int j = 0, loopTo6 = R1 - 1; j <= loopTo6; j++)
						{
							for (int k = 0, loopTo7 = C1 - 1; k <= loopTo7; k++)
								M3[i * C2 + j] += M1[i * C1 + k] * M2[k * C2 + j];
							Interaction.MsgBox(M3[i * C2 + j]);
						}
					}
				}
			}
		}
	}
}
