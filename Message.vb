Public Class Message

    Public Sub ReportError(ByVal sError As String, ByVal ex As Exception)
            MessageBox.Show(sError & "Error:" & ex.Message & "Error Source:" & ex.Source)
        End Sub

End Class
