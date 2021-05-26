Public Class frmMainMenu
    Private Sub AddNewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewPatientToolStripMenuItem.Click
        Dim myFrmPatientNew As New frmPatientNew
        myFrmPatientNew.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim myFrmPatientSearch As New frmPatientSearch
        myFrmPatientSearch.Show()
        Me.Close()
    End Sub

    Private Sub UpdateInpatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInpatientsToolStripMenuItem.Click

    End Sub

    Private Sub DiscahargeInPatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscahargeInPatientsToolStripMenuItem.Click

    End Sub

    Private Sub WardListToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddToMastercodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToMastercodesToolStripMenuItem.Click
        Dim myfrmMaintenance As New frmMaintenance
        myfrmMaintenance.ShowDialog()
    End Sub

    Private Sub ViewMasterCodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMasterCodesToolStripMenuItem.Click

    End Sub

    Private Sub AmmendPatientRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmmendPatientRecordToolStripMenuItem.Click

    End Sub

    Private Sub btnUserMenu_Click(sender As Object, e As EventArgs) Handles btnUserMenu.Click
        frmMainUser.Show()
        Me.Close()
    End Sub

    Private Sub PatientByMedicationATCCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientByMedicationATCCodeToolStripMenuItem.Click
        Dim myfrmReportMedicationPatient As New frmReportMedicationPatient
        myfrmReportMedicationPatient.Show()
        Me.Close()

    End Sub
End Class