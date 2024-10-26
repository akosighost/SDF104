Public Class Form1
    Private randomNumber As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartNewGame()
    End Sub

    Private Sub StartNewGame()
        ' Generate a random number between 1 and 100
        Dim random As New Random()
        randomNumber = random.Next(1, 51)
        lblResult.Text = "Guess a number between 1 and 50!"
        txtGuess.Clear()
        txtReveal.Clear()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim userGuess As Integer

        ' Validate user input
        If Integer.TryParse(txtGuess.Text, userGuess) Then
            If userGuess < randomNumber Then
                lblResult.Text = "Too low! Try again."
            ElseIf userGuess > randomNumber Then
                lblResult.Text = "Too high! Try again."
            Else
                lblResult.Text = "Congratulations! You guessed the number!"
            End If
        Else
            lblResult.Text = "Please enter a valid number."
        End If
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        StartNewGame()
    End Sub

    Private Sub btnNewGame_Click_1(sender As Object, e As EventArgs) Handles btnNewGame.Click

    End Sub

    Private Sub btnReveal_Click(sender As Object, e As EventArgs) Handles btnReveal.Click
        txtReveal.Text = randomNumber
    End Sub

    Private Sub txtGuess_TextChanged(sender As Object, e As EventArgs) Handles txtGuess.TextChanged

    End Sub
End Class
