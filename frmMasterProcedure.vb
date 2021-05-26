Public Class frmMasterProcedure
    Private Sub lvMasterProcedure_DoubleClick(sender As Object, e As EventArgs) Handles lvMasterProcedure.DoubleClick
        Dim item1 As New ListViewItem
        item1.Text = lvMasterProcedure.SelectedItems(0).Text
        item1.SubItems.Add(lvMasterProcedure.SelectedItems(0).SubItems(1))
        frmAdmission.lvProcedureList.Items.Add(item1)
        frmAdmission.Show()
        Me.Close()
    End Sub
End Class