'   Rogel SJ Corral
'   17 June 2019
'   Simple VB application to display
'       a standard ASCII character.


Public Class MainForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        'Dim myASCII As Char
        Dim userInput As Integer

        If tbInput.Text = "" Then
            MessageBox.Show("Please input a value", "",
                                MessageBoxButtons.OK)
            UnitsInputSelect()
        ElseIf Integer.TryParse(tbInput.Text, userInput) Then
            If (userInput >= 0 And userInput <= 255) Then
                Dim enc As System.Text.Encoding
                enc = System.Text.Encoding.GetEncoding("CP437")

                Dim bytes = Enumerable.Range(0, 256).Select(Function(b) CByte(b)).ToArray
                Dim chars() = enc.GetChars(bytes)

                lbOutputASCII.Text = chars(userInput)
                btnReset.Select()
            Else
                MessageBox.Show("Please enter whole numbers only between 0 and 255.", "",
                                MessageBoxButtons.OK)
                UnitsInputSelect()
            End If
        Else
            MessageBox.Show("Please enter whole numbers only.", "",
                                MessageBoxButtons.OK)
            UnitsInputSelect()
        End If
    End Sub

    Private Sub UnitsInputSelect()
        tbInput.Select()
        tbInput.SelectionStart = 0
        tbInput.SelectionLength = tbInput.Text.Length
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbInput.Clear()
        lbOutputASCII.Text = ""
        btnGenerate.Select()
        tbInput.Focus()
    End Sub
End Class
