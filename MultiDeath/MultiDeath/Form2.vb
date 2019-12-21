Public Class Form2
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkLblEULA.LinkClicked
        Process.Start("https://www.microsoft.com/en-us/servicesagreement/")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        BtnInstall.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        BtnInstall.Enabled = False
    End Sub

    Private Sub BtnInstall_Click(sender As Object, e As EventArgs) Handles BtnInstall.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class