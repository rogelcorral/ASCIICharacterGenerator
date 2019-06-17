'   Rogel SJ Corral
'   17 June 2019
'   Simple VB application to display
'       a standard ASCII character.


Public Class MainForm
    Private Sub tbExit_Click(sender As Object, e As EventArgs) Handles tbExit.Click
        Application.Exit()
    End Sub

    Private Sub tbGenerate_Click(sender As Object, e As EventArgs) Handles tbGenerate.Click

        'Dim myASCII As Char
        Dim userInput As Integer

        If tbInput.Text = "" Then
            MessageBox.Show("Please input a value", "",
                                MessageBoxButtons.OK)
            UnitsInputSelect()
        ElseIf Integer.TryParse(tbInput.Text, userInput) Then
            lbOutputASCII.Text = ChrW(userInput)
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
End Class
