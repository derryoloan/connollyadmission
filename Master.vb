Imports System.Data.SqlClient
Public Class Master
    ''Functional variables
    Dim sConnect As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derry\Documents\ConnollyAdmissions.mdf;Integrated Security=True;Connect Timeout=30"
    ''Class variables
    Private sProcedureSearchID As String
    Private sMedicalHistorySearchID As String
    Private sMedicationSearchID As String
    Private sConsultant_ID As String
    Private sConsultantName As String
    Private sDiagnosisSearchID As String
    Private sDiagnosis_ID As String
    Private sDiagnosis As String
    Private sFamilyHistory_ID As String
    Private sFamilyHistory As String
    Private sMedicalHistory_ID As String
    Private sMedicalHistory As String
    Private sMedication_ID As String
    Private sMedicationName As String
    Private sPC_ID As String
    Private sPresentingComplaint As String
    Private sReg_ID As String
    Private sRegName As String
    Private sRiskFactor_ID As String
    Private sRiskFactor As String
    ''Class Properties

    ''                                Diagnosis
    Public Property Diagnosis_ID As String
        Set(value As String)
            sDiagnosis_ID = value
        End Set
        Get
            Return sDiagnosis_ID
        End Get
    End Property
    Public Property Diagnosis As String
        Set(value As String)
            sDiagnosis = value
        End Set
        Get
            Return sDiagnosis
        End Get
    End Property
    Public Property DiagnosisSearchID As String
        Set(value As String)
            sDiagnosisSearchID = value
        End Set
        Get
            Return sDiagnosisSearchID
        End Get
    End Property
    ''                               Family History
    Public Property FamilyHistory_ID As String
        Set(value As String)
            sFamilyHistory_ID = value
        End Set
        Get
            Return sFamilyHistory_ID
        End Get
    End Property
    Public Property FamilyHistory As String
        Set(value As String)
            sFamilyHistory = value
        End Set
        Get
            Return sFamilyHistory
        End Get
    End Property
    ''                                 Risk Factor
    Public Property RiskFactor_ID As String
        Set(value As String)
            sRiskFactor_ID = value
        End Set
        Get
            Return sRiskFactor_ID
        End Get
    End Property
    Public Property RiskFactor As String
        Set(value As String)
            sRiskFactor = value
        End Set
        Get
            Return sRiskFactor
        End Get
    End Property
    ''                                Presenting complaint

    Public Property PC_ID As String
        Set(value As String)
            sPC_ID = value
        End Set
        Get
            Return sPC_ID
        End Get
    End Property
    Public Property PresentingComplaint As String
        Set(value As String)
            sPresentingComplaint = value
        End Set
        Get
            Return sPresentingComplaint
        End Get
    End Property

    ''                                Medical History
    Public Property MedicalHistory As String
        Set(value As String)
            sMedicalHistory = value
        End Set
        Get
            Return sMedicalHistory
        End Get
    End Property
    Public Property MedicalHistory_ID As String
        Set(value As String)
            sMedicalHistory_ID = value
        End Set
        Get
            Return sMedicalHistory_ID
        End Get
    End Property
    Public Property MedicalHistorySearchID As String
        Set(value As String)
            sMedicalHistorySearchID = value
        End Set
        Get
            Return sMedicalHistorySearchID
        End Get
    End Property
    ''                               Medication

    Public Property Medication_ID As String
        Set(value As String)
            sMedication_ID = value
        End Set
        Get
            Return sMedication_ID
        End Get
    End Property
    Public Property MedicationName As String
        Set(value As String)
            If value <> "x" Then
                sMedicationName = value
            Else
                sMedicationName = "Unknown"
            End If
        End Set
        Get
            Return sMedicationName
        End Get
    End Property

    Public Property MedicationSearchID As String
        Set(value As String)
            sMedicationSearchID = value
        End Set
        Get
            Return sMedicationSearchID
        End Get
    End Property
    ''                                     Registrar
    Public Property Reg_ID As String
        Set(value As String)
            sReg_ID = value
        End Set
        Get
            Return sReg_ID
        End Get
    End Property
    Public Property RegName As String
        Set(value As String)
            sRegName = value
        End Set
        Get
            Return sRegName
        End Get
    End Property

    ''                                     Consultant
    Public Property Consultant_ID As String
        Set(value As String)
            sConsultant_ID = value
        End Set
        Get
            Return sConsultant_ID
        End Get
    End Property
    Public Property ConsultantName As String
        Set(value As String)
            sConsultantName = value
        End Set
        Get
            Return sConsultantName
        End Get
    End Property
    ''                                     Procedure
    Public Property ProcedureSearchID As String
        Set(value As String)
            sProcedureSearchID = value
        End Set
        Get
            Return sProcedureSearchID
        End Get
    End Property

    ''Class Functionality


    ''                                             Presenting Complaint
    Public Function AddPresentingComplaint() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Medication Details to Medication Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Master_PresentingComplaint"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@PC_ID", SqlDbType.VarChar).Value = sPC_ID
                    .Add("@PresentingComplaint", SqlDbType.VarChar).Value = sPresentingComplaint
                End With
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    Public Sub findPCList(ByRef cmbBox As DataGridViewComboBoxColumn)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Master_PresentingComplaint"
                .CommandType = CommandType.StoredProcedure
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("PresentingComplaint") <> "" Then
                    cmbBox.Items.Add(myDataReader.Item("PresentingComplaint"))
                End If
            End While
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Sub


    ''                                             Family History
    Public Function AddFamilyHistory() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Medication Details to Medication Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Master_FamilyHistory"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@FamilyHistory_ID", SqlDbType.VarChar).Value = sFamilyHistory_ID
                    .Add("@FamilyHistory", SqlDbType.VarChar).Value = sFamilyHistory
                End With
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function

    Public Sub findFamilyHistoryList(ByRef cmbBox As DataGridViewComboBoxColumn)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Master_FamilyHistory"
                .CommandType = CommandType.StoredProcedure
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("FamilyHistory") <> "" Then
                    cmbBox.Items.Add(myDataReader.Item("FamilyHistory"))
                End If
            End While
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Sub

    ''                                     Risk Factor
    Public Function AddRiskFactor() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Medication Details to Medication Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Master_RiskFactor"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@RiskFactor_ID", SqlDbType.VarChar).Value = sRiskFactor_ID
                    .Add("@RiskFactor", SqlDbType.VarChar).Value = sRiskFactor
                End With
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    Public Sub findRiskFactor(ByRef cmbBox As ComboBox)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Master_RiskFactor"
                .CommandType = CommandType.StoredProcedure
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("RiskFactor") <> "" Then
                    cmbBox.Items.Add(myDataReader.Item("RiskFactor"))
                End If
            End While
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Sub



    ''                                       Medical Surgical History
    Public Function AddMedicalHistory() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Medication Details to Medication Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Master_MedicalHistory"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@MedicalHistory_ID", SqlDbType.VarChar).Value = sMedicalHistory_ID
                    .Add("@MedicalHistory", SqlDbType.VarChar).Value = sMedicalHistory
                End With
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()
                End If
            End If
        End Try
    End Function
    Public Sub findMedicalHistory(ByRef lstv1)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Master_MedicalHistory"
                .CommandType = CommandType.StoredProcedure

                With .Parameters
                    .Add("@SearchID", SqlDbType.VarChar, 50).Value = sMedicalHistorySearchID
                End With
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("MedicalHistory") <> "" Then

                    Dim item1 As New ListViewItem
                    item1.Text = myDataReader.Item("MedicalHistory_Id")
                    item1.SubItems.Add(myDataReader.Item("MedicalHistory"))
                    lstv1.Items.Add(item1)
                End If
            End While
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Sub
    ''                                       Medication
    Public Function AddMedication() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Medication Details to Medication Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Master_Medication"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Medication_ID", SqlDbType.VarChar).Value = sMedication_ID
                    .Add("@MedicationName", SqlDbType.VarChar).Value = sMedicationName
                End With
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    Public Sub findMedication(ByRef lstv1)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Master_Medication"
                .CommandType = CommandType.StoredProcedure

                With .Parameters
                    .Add("@SearchID", SqlDbType.VarChar, 50).Value = sMedicationSearchID
                End With
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("MedicationName") <> "" Then

                    Dim item1 As New ListViewItem
                    item1.Text = myDataReader.Item("Medication_Id")
                    item1.SubItems.Add(myDataReader.Item("MedicationName"))
                    lstv1.Items.Add(item1)
                End If
            End While
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Sub
    ''                                       Diagnosis
    Public Function AddDiagnosis() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Medication Details to Medication Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Master_Diagnosis"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Diagnosis_ID", SqlDbType.VarChar).Value = sDiagnosis_ID
                    .Add("@Diagnosis", SqlDbType.VarChar).Value = sDiagnosis
                End With
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    Public Sub findDiagnosis(ByRef lstv1)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Master_Diagnosis"
                .CommandType = CommandType.StoredProcedure

                With .Parameters
                    .Add("@SearchID", SqlDbType.VarChar, 50).Value = sDiagnosisSearchID
                End With
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("Diagnosis") <> "" Then

                    Dim item1 As New ListViewItem
                    item1.Text = myDataReader.Item("Diagnosis_Id")
                    item1.SubItems.Add(myDataReader.Item("Diagnosis"))
                    lstv1.Items.Add(item1)
                End If
            End While
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Sub
    ''                                          Registrar
    Public Function AddReg() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Medication Details to Medication Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Master_Reg"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Reg_ID", SqlDbType.VarChar).Value = sReg_ID
                    .Add("@RegName", SqlDbType.VarChar).Value = sRegName
                End With
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    ''                                          Consultant
    Public Function AddConsultant() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Medication Details to Medication Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Master_Consultant"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Consultant_ID", SqlDbType.VarChar).Value = sConsultant_ID
                    .Add("@ConsultantName", SqlDbType.VarChar).Value = sConsultantName
                End With
                .ExecuteNonQuery()
            End With
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)
            Return False
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    Public Sub findConsultantList(ByRef cmbBox As ComboBox)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Master_Consultant"
                .CommandType = CommandType.StoredProcedure
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("ConsultantName") <> "" Then
                    cmbBox.Items.Add(myDataReader.Item("ConsultantName"))
                End If
            End While
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Sub
    ''                                  Procedure
    Public Sub findProcedure(ByRef lstv1)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Master_Procedure"
                .CommandType = CommandType.StoredProcedure

                With .Parameters
                    .Add("@SearchID", SqlDbType.VarChar, 50).Value = sProcedureSearchID
                End With
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("Procedure") <> "" Then

                    Dim item1 As New ListViewItem
                    item1.Text = myDataReader.Item("Procedure_Id")
                    item1.SubItems.Add(myDataReader.Item("Procedure"))
                    lstv1.Items.Add(item1)
                End If
            End While
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Error Finding Item", ex)
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Sub

End Class
