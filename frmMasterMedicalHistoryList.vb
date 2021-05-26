Public Class frmMasterMedicalHistoryList
    Dim myMaster As New Master
    Dim myadmission As New Admission

    Private Sub frmMasterMedicalHistoryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtNewMedicalHistory_TextChanged(sender As Object, e As EventArgs) Handles txtNewMedicalHistory.TextChanged
        myMaster.MedicalHistory = txtNewMedicalHistory.Text

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNewMedicalHistory.Text <> "" Then
            myMaster.MedicalHistory_ID = "x" & DateTime.Now
            If myMaster.AddMedicalHistory() = True Then
                MessageBox.Show("New Medical/Surgical History term added")
                Dim item1 As New ListViewItem(myMaster.MedicalHistory_ID)
                item1.SubItems.Add(myMaster.MedicalHistory)
                frmAdmission.lstvMedicalHistory.Items.Add(item1)
                txtNewMedicalHistory.Text = ""
                frmAdmission.Show()
                Me.Close()
            Else
                MessageBox.Show("Medical/Surgical Term not added.")
            End If
        Else
            MessageBox.Show("Please Ensure Medical/Surgical History term is filled in")
        End If
    End Sub



    Private Sub lstvMasterMedicalHistory_DoubleClick(sender As Object, e As EventArgs) Handles lstvMasterMedicalHistory.DoubleClick


        Dim item1 As New ListViewItem
        item1.Text = lstvMasterMedicalHistory.SelectedItems(0).Text
        item1.SubItems.Add(lstvMasterMedicalHistory.SelectedItems(0).SubItems(1))
        frmAdmission.lstvMedicalHistory.Items.Add(item1)
        frmAdmission.Show()
        Me.Close()

    End Sub
End Class