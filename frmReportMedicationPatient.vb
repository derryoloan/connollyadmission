Public Class frmReportMedicationPatient
    Dim myReports As New Reports

    Private Sub txtATC_TextChanged(sender As Object, e As EventArgs) Handles txtATC.TextChanged
        myReports.ATC = txtATC.Text
    End Sub

    Private Sub btnATCSearch_Click(sender As Object, e As EventArgs) Handles btnATCSearch.Click
        If myReports.ATC <> "" Then
            myReports.ReportPatientMedGrid = dgvReportPatientMed
            If myReports.findMedication_atcPatient <> False Then
                dgvReportPatientMed = myReports.ReportPatientMedGrid
            Else MessageBox.Show("No Medications Found")
            End If
        Else
            MessageBox.Show("Please Enter an ATC Value")
        End If
    End Sub

    Private Sub dgvReportPatientMed_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReportPatientMed.CellContentClick

    End Sub

    Private Sub dgvReportPatientMed_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReportPatientMed.CellContentDoubleClick
        Dim myfrmPatientIn As New frmPatientIn
        myReports.ID = dgvReportPatientMed.SelectedCells(0).Value
        'Me.Cursor = Cursors.WaitCursor
        If myReports.findID() <> False Then

            myfrmPatientIn.txtPatMRN.Text = myReports.ID
            myfrmPatientIn.txtPatName.Text = myReports.Name
            myfrmPatientIn.txtPatSymphony.Text = myReports.Symphony
            myfrmPatientIn.txtPatStatus.Text = myReports.Status
            myfrmPatientIn.dtpPatDOB.Value = myReports.DOB
            myfrmPatientIn.txtPatArea.Text = myReports.Location
            myfrmPatientIn.Show()
            Me.Close()
            'Me.Cursor = Cursors.Default

        Else
            'Me.Cursor = Cursors.Default
            MessageBox.Show("Patient Not Found")

        End If

    End Sub

    Private Sub btnMainUser_Click(sender As Object, e As EventArgs) Handles btnMainUser.Click
        Dim myfrmMainUser As New frmMainUser
        myfrmMainUser.Show()
        Me.Close()
    End Sub
End Class