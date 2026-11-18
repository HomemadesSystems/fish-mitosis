
Public Class fish
    'Alright lets get down to business.


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configures the fish spawning system
        Me.StartPosition = FormStartPosition.Manual

        'Calculate ocean size
        Dim resolution As Rectangle = Screen.PrimaryScreen.WorkingArea
        'Establish world borders
        Dim maxX As Integer = Math.Max(0, resolution.Width - Me.Width)
        Dim maxY As Integer = Math.Max(0, resolution.Height - Me.Height)
        'Calculates a random X value based on "maxX" and "maxY"
        Dim rng As New Random(Guid.NewGuid().GetHashCode())
        Dim randomX As Integer = rng.Next(0, maxX + 1)
        Dim randomY As Integer = rng.Next(0, maxY + 1)
        'Finally, we declare the spawn point.
        Me.Location = New Point(randomX, randomY)
        'queue annoying music
        My.Computer.Audio.Play(My.Resources.fish, AudioPlayMode.BackgroundLoop)
        'And we are done with initializing.
    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'makes one new fish spawn every click
        Dim mitosis As New fish()
        mitosis.Show()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'OK who's splitting the fish?!
        Dim onefish As New fish()
        Dim twofish As New fish()
        onefish.Show()
        twofish.Show()
        'Would you, could you, on a train?
    End Sub

End Class