Imports System.Data.SqlClient
Public Class Reports
    Inherits Admission

    Dim sConnect As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derry\Documents\ConnollyAdmissions.mdf;Integrated Security=True;Connect Timeout=30"
    Private sATC As String
    Private dgvReportPatientMed As New DataGridView
    Public Property ReportPatientMedGrid As DataGridView
        Get
            Return dgvReportPatientMed
        End Get
        Set(value As DataGridView)
            dgvReportPatientMed = value
        End Set
    End Property
    Public Property ATC As String
        Get
            Return sATC
        End Get
        Set(value As String)
            sATC = value
        End Set
    End Property

    Public Function findMedication_atcPatient() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()

            'Search for Progress Notes
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Report_Medication_atcPatient"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@idATC", SqlDbType.VarChar, 50).Value = sATC
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            Dim ReportCount As Integer = 0
            dgvReportPatientMed.Rows.Clear()
            If dgvReportPatientMed.Columns.Count < 1 Then
                dgvReportPatientMed.Columns.Add("MRN", "MRN")
                dgvReportPatientMed.Columns.Add("Name", "Patient Name")
                dgvReportPatientMed.Columns.Add("Ward", "Ward")
                dgvReportPatientMed.Columns.Add("Medication", "Medication")
                dgvReportPatientMed.Columns(3).Width = 175
            End If
            While myDataReader.Read()

                If IsDBNull(myDataReader.Item("MRN")) = False Then
                    dgvReportPatientMed.Rows.Add()
                    dgvReportPatientMed.Rows(ReportCount).Cells(0).Value = myDataReader.Item("MRN")
                    If IsDBNull(myDataReader.Item("PatientName")) = False Then
                        dgvReportPatientMed.Rows(ReportCount).Cells(1).Value = myDataReader.Item("PatientName")
                        dgvReportPatientMed.Rows(ReportCount).Cells(2).Value = myDataReader.Item("Ward")
                        dgvReportPatientMed.Rows(ReportCount).Cells(3).Value = myDataReader.Item("MedicationName")
                    End If
                    ReportCount = ReportCount + 1
                Else Return False
                End If
            End While
            Return True

            myDataReader.Close()
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try


    End Function

End Class
