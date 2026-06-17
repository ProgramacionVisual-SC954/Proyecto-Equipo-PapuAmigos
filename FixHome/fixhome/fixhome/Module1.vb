Module Module1

    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim login As New Form1

        If login.ShowDialog() = DialogResult.OK Then
            Application.Run(New menu_principal)
        End If
    End Sub

End Module