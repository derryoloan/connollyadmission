Public Class frmPatientInList
    Private Sub lstPatientDetails_DoubleClick(sender As Object, e As EventArgs) Handles lstPatientDetails.DoubleClick
        Select Case lstPatientDetails.SelectedItems.Item(0).SubItems(5).Text.ToString

            Case = "In-Patient"
                Dim myfrmPatientIn As New frmPatientIn
                myfrmPatientIn.txtPatName.Text = lstPatientDetails.SelectedItems.Item(0).Text
                myfrmPatientIn.txtPatMRN.Text = lstPatientDetails.SelectedItems.Item(0).SubItems(1).Text
                myfrmPatientIn.txtPatArea.Text = lstPatientDetails.SelectedItems.Item(0).SubItems(2).Text
                myfrmPatientIn.dtpPatDOB.Value = lstPatientDetails.SelectedItems.Item(0).SubItems(3).Text
                myfrmPatientIn.txtPatSymphony.Text = lstPatientDetails.SelectedItems.Item(0).SubItems(4).Text
                myfrmPatientIn.txtPatStatus.Text = lstPatientDetails.SelectedItems.Item(0).SubItems(5).Text
                myfrmPatientIn.Show()
                Me.Close()

            Case = "Clinic"
                Dim myfrmPatientClinic As New frmPatientClinic
                myfrmPatientClinic.txtPatName.Text = lstPatientDetails.SelectedItems.Item(0).Text
                myfrmPatientClinic.txtPatMRN.Text = lstPatientDetails.SelectedItems.Item(0).SubItems(1).Text
                myfrmPatientClinic.txtPatArea.Text = lstPatientDetails.SelectedItems.Item(0).SubItems(2).Text
                myfrmPatientClinic.dtpPatDOB.Value = lstPatientDetails.SelectedItems.Item(0).SubItems(3).Text
                myfrmPatientClinic.txtPatSymphony.Text = lstPatientDetails.SelectedItems.Item(0).SubItems(4).Text
                myfrmPatientClinic.lblStatus.Text = lstPatientDetails.SelectedItems.Item(0).SubItems(5).Text
                myfrmPatientClinic.Show()
                Me.Close()
        End Select
    End Sub
End Class