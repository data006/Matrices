Public Class frmMatricesVB



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSolve.Click

        Dim matrizUno() As String = txtMatriz1.Text.Split(" ")
        Dim matrizDos() As String = txtMatriz2.Text.Split(" ")
        Dim R1, R2, C1, C2, i, l, d As Integer

        R1 = cmbR1.SelectedItem
        R2 = cmbR2.SelectedItem
        C1 = cmbC1.SelectedItem
        C2 = cmbC2.SelectedItem


        Dim M1(R1 * C1 - 1) As Integer
        Dim M2(R2 * C2 - 1) As Integer




        If txtMatriz1.Text IsNot String.Empty Then
            'Vaciar matrices
            For Each dato In matrizUno
                M1(i) = dato
                i += 1
            Next
            i = 0
        End If





        If cmbOperacion.SelectedItem = "T" Then
            Dim matrizResultadoTranspuesta((R1 * C1) - 1) As String
            MsgBox("Transpuesta")
            For i = 0 To C1 - 1
                For j = 0 To R1 - 1
                    matrizResultadoTranspuesta(R1 * i + j) = matrizUno(C1 * j + i)

                    MsgBox(matrizResultadoTranspuesta(R1 * i + j))
                Next
            Next
            For i = 0 To (R1 * C1 - 1)
                matrizResultadoTranspuesta(i) = matrizResultadoTranspuesta(i)
            Next
        End If


        i = 0
        If txtMatriz2.Text IsNot String.Empty Then
            For Each dato In matrizDos
                M2(i) = dato
                i += 1
            Next
            i = 0
        End If












        'Resta
        If cmbOperacion.SelectedItem = "-" Then
            If C1 = C2 And R1 = R2 Then
                MsgBox("Resta")
                Dim M3(R1 * C2 - 1) As Integer

                For i = 0 To (R1 * C2 - 1)

                    M3(i) = M1(i) - M2(i)

                    MsgBox(M3(i))

                Next
            End If

        End If






        'Suma
        If cmbOperacion.SelectedItem = "+" Then
            If C1 = C2 And R1 = R2 Then
                MsgBox("Suma")
                Dim M3(R1 * C2 - 1) As Integer

                For i = 0 To (R1 * C2 - 1)

                    M3(i) = M1(i) + M2(i)

                    MsgBox(M3(i))

                Next
            End If

        End If









        'Multiplicacion
        If cmbOperacion.SelectedItem = "*" Then
            If C1 = R2 Then
                MsgBox("Multiplicacion")
                Dim M3(R1 * C2 - 1) As Integer

                For i = 0 To (C2 - 1)

                    For j = 0 To (R1 - 1)

                        For k = 0 To (C1 - 1)

                            M3(i * C2 + j) += M1(i * C1 + k) * M2(k * C2 + j)

                        Next

                        MsgBox(M3(i * C2 + j))

                    Next

                Next
            End If

        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbOperacion.SelectedIndex = 0
        cmbR1.SelectedIndex = 0
        cmbC1.SelectedIndex = 0
        cmbR2.SelectedIndex = 0
        cmbC2.SelectedIndex = 0
    End Sub


End Class
