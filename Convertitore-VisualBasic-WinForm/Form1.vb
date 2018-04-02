Imports System
Imports System.Windows.Forms
Imports System.Drawing

Public Class Form1Convertitore

    Private temperatura As Double
    Private UnitTempIn As String

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Verifica che l'unita' di misura della temperatura sia scelta
        If ComboBoxInT.SelectedIndex = -1 Then
            'MessageBox.Show("Scegliere Le unita'di Misura")
            labInfo.Text = "Prima scegliere la scala di input"
            Return
        Else
            ' Memorizzo l'indice relativo all'unità di misura
            UnitTempIn = Misure.Temperature.Simboli(ComboBoxInT.SelectedIndex)
        End If

        Dim contenuto As String = (valueInput.Text.ToString()).Replace("."c, ","c)
        Dim verifica As Boolean = Double.TryParse(contenuto, temperatura)

        If Not verifica Then
            valueInput.Clear()
            valueInput.BackColor = System.Drawing.Color.Red
            'valueInput.Text = "VALORE NON NUMERICO"
            labInfo.Text = "Hai inserito un VALORE NON NUMERICO"
            Dim ii As Integer = 0

            For Each txb As Control In Pannello.Controls
                If (TypeOf txb Is TextBox) AndAlso ii < 8 Then
                    txb.Text = Nothing
                    ii += 1
                End If
            Next txb
            Return
        End If

        If Not Misure.Temperature.ValiateTemp(UnitTempIn, temperatura) Then
            'MessageBox.Show("Valore fuori scala")
            If ComboBoxInT.SelectedItem = "Kelvin" Then
                labInfo.Text = "Il valore minimo inseribile per i " & ComboBoxInT.SelectedItem & " è " & Misure.Temperature.AbsValueTemp(ComboBoxInT.SelectedIndex)
            ElseIf ComboBoxInT.SelectedItem = "Delisle" Then
                labInfo.Text = "Il valore massimo inseribile per i gradi " & ComboBoxInT.SelectedItem & " è " & Misure.Temperature.AbsValueTemp(ComboBoxInT.SelectedIndex)
            Else
                labInfo.Text = "Il valore minimo inseribile per i gradi " & ComboBoxInT.SelectedItem & " è " & Misure.Temperature.AbsValueTemp(ComboBoxInT.SelectedIndex)
            End If
            Dim ii As Integer = 0

            For Each txb As Control In Pannello.Controls
                If (TypeOf txb Is TextBox) AndAlso ii < 8 Then
                    txb.Text = Nothing
                    ii += 1
                End If
            Next txb
            valueInput.BackColor = Color.Red
            Return
        End If

        Dim value As New Misure.Temperature(UnitTempIn, temperatura)
        Dim result(7) As Double
        Dim i As Integer = 0
        For Each simbol As String In Misure.Temperature.Simboli
            If i > Misure.Temperature.Simboli.Length Then
                Return
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            result(i) = Math.Round(value.ConvertValueTemp(simbol), 3)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '' result(i) = Math.Round(value.ConvertTemp(simbol), 3)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            i += 1
        Next simbol

        i = 0
        For Each txb As Control In Pannello.Controls
            If (TypeOf txb Is TextBox) AndAlso i < 8 Then
                txb.Text = result(i).ToString()
                i += 1
            End If
        Next txb
        labInfo.Text = "Convertito " & valueInput.Text & " " & Misure.Temperature.SimbolUnitTemp(ComboBoxInT.SelectedIndex)

    End Sub

    Private Sub Form1Convertitore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0

        ' Inizializa la ComboBox per la lista delle Temperature
        ComboBoxInT.Items.AddRange(Misure.Temperature.NameUnitTemp)

        ' Inabilita le textBox per le temperature convertite
        ' I nomi delle TextBox devono essere le prime 8 in ordine alfabetico

        For Each item As Control In Pannello.Controls
            If TypeOf item Is TextBox Then
                item.BackColor = Color.Yellow
                item.Enabled = False
                If i = 7 Then
                    i += 1
                    Return
                Else
                    i += 1
                End If
            End If
        Next item

    End Sub

    Private Sub ComboBoxInT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxInT.SelectedIndexChanged

        If ComboBoxInT.SelectedItem = "Kelvin" Then
            labInfo.Text = "Inserisci i " & ComboBoxInT.SelectedItem & " da convertire"
            valueInput.BackColor = Color.White
        Else
            labInfo.Text = "Inserisci i gradi " & ComboBoxInT.SelectedItem & " da convertire"
            valueInput.BackColor = Color.White
        End If
        labScala.Text = Misure.Temperature.SimbolUnitTemp(ComboBoxInT.SelectedIndex)

    End Sub

    Private Sub valueInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valueInput.TextChanged

        If ComboBoxInT.SelectedIndex <> -1 Then
            labInfo.Text = "Pronto per convertire " & valueInput.Text & " " & Misure.Temperature.SimbolUnitTemp(ComboBoxInT.SelectedIndex)
            valueInput.BackColor = Color.White
        End If

    End Sub

End Class

