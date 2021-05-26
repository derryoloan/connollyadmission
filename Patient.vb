Imports System.Data.SqlClient
Public Class Patient
    Inherits Person
    Dim mymaster As New Master
    Dim sConnect As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derry\Documents\ConnollyAdmissions.mdf;Integrated Security=True;Connect Timeout=30"
    Private dDOB As Date
    Private sStatus As String
    Private sSymphony As String
    Private sRelevantRisk As String
    Private sPreviousSymphony As String
    Private sFamilyHistoryExtFamily As String
    Private sFamilyHistorySiblings As String
    Private sFamilyRelation As String
    Private sFamilyHistoryMother As String
    Private sFamilyHistory As String
    Private RiskFactor As String
    Private MedicalSurgical As String
    Private MedicalSurgical_ID As String
    Private lstvMedicalSurgicalList As ListView
    Private dgvFamilyRiskList As New DataGridView
    Private lstFamilyHistory As ListBox
    Private lstRiskList As ListBox
    Private lstvPatientDetails As ListView
    ''Social History
    Private dgvSocialHistoryList As New DataGridView
    Private sLivesWith As String = ""
    Private sCarers As String = ""
    Private sServices As String = ""
    Private sHouseType As String = ""
    Private sHouseStories As String = ""
    Private sToiletLocation As String = ""
    Private sBedroomLocation As String = ""
    Private sOccupation As String = ""
    Private sSmoking As String = ""
    Private sAlcohol As String = ""
    Private sDressing As String = ""
    Private sWashing As String = ""
    Private sFeeding As String = ""
    Private sContinence As String = ""
    Private sTransfers As String = ""
    Private sMobility As String = ""
    ''Properties
    Public Property SocialHistory As DataGridView
        Get
            Return dgvSocialHistoryList
        End Get
        Set(value As DataGridView)
            dgvSocialHistoryList = value
        End Set
    End Property



    Public Property PatientDetails As ListView
        Get
            Return lstvPatientDetails
        End Get
        Set(value As ListView)
            lstvPatientDetails = value
        End Set
    End Property
    Public Property RelevantRisk As String
        Get
            Return sRelevantRisk
        End Get
        Set(value As String)
            sRelevantRisk = value
        End Set
    End Property
    Public Property MedicalSurgicalList As ListView
        Get
            Return lstvMedicalSurgicalList
        End Get
        Set(value As ListView)
            lstvMedicalSurgicalList = value
        End Set
    End Property
    Public Property RiskList As ListBox
        Get
            Return lstRiskList
        End Get
        Set(value As ListBox)
            lstRiskList = value
        End Set
    End Property
    Public Property FamilyHistoryMother As String
        Get
            Return sFamilyHistoryMother
        End Get
        Set(value As String)
            sFamilyHistoryMother = value
        End Set
    End Property
    Public Property FamilyRelation As String
        Get
            Return sFamilyRelation
        End Get
        Set(value As String)
            sFamilyRelation = value
        End Set
    End Property
    Public Property FamilyHistorySiblings As String
        Get
            Return sFamilyHistorySiblings
        End Get
        Set(value As String)
            sFamilyHistorySiblings = value
        End Set
    End Property
    Public Property FamilyHistoryExtFamily As String
        Get
            Return sFamilyHistoryExtFamily
        End Get
        Set(value As String)
            sFamilyHistoryExtFamily = value
        End Set
    End Property
    Public Property FamilyRiskList As DataGridView
        Get
            Return dgvFamilyRiskList
        End Get
        Set(value As DataGridView)
            dgvFamilyRiskList = value
        End Set
    End Property
    Public Property FamilyHistory As ListBox
        Get
            Return lstFamilyHistory
        End Get
        Set(value As ListBox)
            lstFamilyHistory = value
        End Set
    End Property

    Public Property DOB As Date
        Get
            Return dDOB
        End Get
        Set(value As Date)
            dDOB = value
        End Set
    End Property
    Public Property Symphony As String
        Get
            Return sSymphony
        End Get
        Set(value As String)
            sSymphony = value
        End Set
    End Property
    Public Property Status As String
        Get
            Return sStatus
        End Get
        Set(value As String)
            sStatus = value
        End Set
    End Property
    Public Property PrevSymphony As String
        Get
            Return sPreviousSymphony
        End Get
        Set(value As String)
            sPreviousSymphony = value
        End Set
    End Property
    '' Class Functionality


    Public Function AddPatientDetails() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Patient Details to Patient Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Add_Patient"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@MRN", SqlDbType.VarChar).Value = ID
                    .Add("@PatientName", SqlDbType.VarChar).Value = Name
                    .Add("@Area", SqlDbType.VarChar).Value = Location
                    .Add("@DOB", SqlDbType.Date).Value = dDOB
                    .Add("@Status", SqlDbType.VarChar).Value = sStatus
                    .Add("@Symphony", SqlDbType.VarChar).Value = sSymphony
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
    Public Function AddPatientHistory() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Delete Patient History
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Delete_Patient_History"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@MRN", SqlDbType.VarChar).Value = ID
                End With
                .ExecuteNonQuery()
            End With
            'Add Family History

            For fHistoryCount = 0 To dgvFamilyRiskList.Rows.Count - 1
                Dim myCommand1 As New SqlCommand
                With myCommand1
                    .Connection = myconnection
                    .CommandText = "Add_Patient_FamilyHistory"
                    .CommandType = CommandType.StoredProcedure
                    With .Parameters



                        With dgvFamilyRiskList.Rows(fHistoryCount)
                            sFamilyHistory = .Cells(0).Value
                            sFamilyRelation = .Cells(1).Value
                        End With

                        .Add("@MRN", SqlDbType.VarChar, 50).Value = ID
                        .Add("@FamilyHistory", SqlDbType.VarChar, 50).Value = sFamilyHistory
                        .Add("@FamilyRelation", SqlDbType.VarChar, 50).Value = sFamilyRelation
                    End With

                    If sFamilyHistory <> "" And sFamilyRelation <> "" Then
                        .ExecuteNonQuery()
                    End If

                End With
            Next
            'Add Relevant Risks
            Dim RiskCount As Integer = 0
            For RiskCount = 0 To lstRiskList.Items.Count - 1
                Dim myCommand2 As New SqlCommand
                With myCommand2
                    .Connection = myconnection
                    .CommandText = "Add_Patient_RiskFactors"
                    .CommandType = CommandType.StoredProcedure
                    With .Parameters
                        RiskFactor = lstRiskList.Items(RiskCount)
                        .Add("@MRN", SqlDbType.VarChar, 50).Value = ID
                        .Add("@RiskFactor", SqlDbType.VarChar, 50).Value = RiskFactor
                    End With
                    .ExecuteNonQuery()
                End With
            Next
            'Add Medical Surgical History
            Dim MedSurg As Integer = 0
            For MedSurg = 0 To lstvMedicalSurgicalList.Items.Count - 1
                Dim myCommand3 As New SqlCommand
                With myCommand3
                    .Connection = myconnection
                    .CommandText = "Add_Patient_MedicalSurgicalHistory"
                    .CommandType = CommandType.StoredProcedure
                    With .Parameters
                        With lstvMedicalSurgicalList.Items(MedSurg)
                            MedicalSurgical_ID = .Text
                            MedicalSurgical = .SubItems(1).Text
                        End With
                        .Add("@MedicalSurgicalHistory_ID", SqlDbType.VarChar, 50).Value = MedicalSurgical_ID
                        .Add("@MedicalSurgicalHistory", SqlDbType.VarChar, 50).Value = MedicalSurgical
                        .Add("@MRN", SqlDbType.VarChar, 50).Value = ID
                    End With
                    .ExecuteNonQuery()
                End With
            Next
            ''Add Social History
            Dim myCommand4 As New SqlCommand

            With myCommand4
                .Connection = myconnection
                .CommandText = "UpdatePatient_SocialHistory"
                .CommandType = CommandType.StoredProcedure
                If dgvSocialHistoryList.Rows(0).Cells(1).Value <> "" Then
                    sLivesWith = dgvSocialHistoryList.Rows(0).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(1).Cells(1).Value <> "" Then
                    sCarers = dgvSocialHistoryList.Rows(1).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(2).Cells(1).Value <> "" Then
                    sServices = dgvSocialHistoryList.Rows(2).Cells(1).Value
                End If

                If dgvSocialHistoryList.Rows(3).Cells(1).Value <> "" Then
                    sHouseType = dgvSocialHistoryList.Rows(3).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(4).Cells(1).Value <> "" Then
                    sHouseStories = dgvSocialHistoryList.Rows(4).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(5).Cells(1).Value <> "" Then
                    sToiletLocation = dgvSocialHistoryList.Rows(5).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(6).Cells(1).Value <> "" Then
                    sBedroomLocation = dgvSocialHistoryList.Rows(6).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(7).Cells(1).Value <> "" Then
                    sOccupation = dgvSocialHistoryList.Rows(7).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(8).Cells(1).Value <> "" Then
                    sSmoking = dgvSocialHistoryList.Rows(8).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(9).Cells(1).Value <> "" Then
                    sAlcohol = dgvSocialHistoryList.Rows(9).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(10).Cells(1).Value <> "" Then
                    sDressing = dgvSocialHistoryList.Rows(10).Cells(1).Value
                End If

                If dgvSocialHistoryList.Rows(11).Cells(1).Value <> "" Then
                    sWashing = dgvSocialHistoryList.Rows(11).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(12).Cells(1).Value <> "" Then
                    sFeeding = dgvSocialHistoryList.Rows(12).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(13).Cells(1).Value <> "" Then
                    sContinence = dgvSocialHistoryList.Rows(13).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(14).Cells(1).Value <> "" Then
                    sTransfers = dgvSocialHistoryList.Rows(14).Cells(1).Value
                End If
                If dgvSocialHistoryList.Rows(15).Cells(1).Value <> "" Then
                    sMobility = dgvSocialHistoryList.Rows(15).Cells(1).Value
                End If

                With .Parameters
                    .Add("@MRN", SqlDbType.VarChar).Value = ID
                    .Add("@LivesWith", SqlDbType.VarChar, 50).Value = sLivesWith
                    .Add("@Carers", SqlDbType.VarChar, 50).Value = sCarers
                    .Add("@Services", SqlDbType.VarChar, 50).Value = sServices
                    .Add("@HouseType", SqlDbType.VarChar, 50).Value = sHouseType
                    .Add("@HouseStories", SqlDbType.VarChar, 50).Value = sHouseStories
                    .Add("@ToiletLocation", SqlDbType.VarChar, 50).Value = sToiletLocation
                    .Add("@BedroomLocation", SqlDbType.VarChar, 50).Value = sBedroomLocation
                    .Add("@Occupation", SqlDbType.VarChar, 50).Value = sOccupation
                    .Add("@Smoking", SqlDbType.VarChar, 50).Value = sSmoking
                    .Add("@Alcohol", SqlDbType.VarChar, 50).Value = sAlcohol
                    .Add("@Dressing", SqlDbType.VarChar, 50).Value = sDressing
                    .Add("@Washing", SqlDbType.VarChar, 50).Value = sWashing
                    .Add("@Feeding", SqlDbType.VarChar, 50).Value = sFeeding
                    .Add("@Continence", SqlDbType.VarChar, 50).Value = sContinence
                    .Add("@Transfers", SqlDbType.VarChar, 50).Value = sTransfers
                    .Add("@Mobility", SqlDbType.VarChar, 50).Value = sMobility
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
    Public Function findPatientView() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Search for MedicalSurgicalHistory
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Patient_MedicalSurgicalHistory"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@MRN", SqlDbType.VarChar, 50).Value = ID
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())

                If myDataReader.Item("MedicalSurgicalHistory_ID") <> "" Then

                    Dim item1 As New ListViewItem
                    item1.Text = myDataReader.Item("MedicalSurgicalHistory_ID")
                    item1.SubItems.Add(myDataReader.Item("MedicalSurgicalHistory"))
                    lstvMedicalSurgicalList.Items.Add(item1)
                End If
            End While
            myDataReader.Close()
            'Search for Family History
            Dim myCommand1 As New SqlCommand
            With myCommand1
                .Connection = myconnection
                .CommandText = "Search_Patient_FamilyHistory"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@MRN", SqlDbType.VarChar, 50).Value = ID
            End With

            Dim myDataReader1 As SqlDataReader = myCommand1.ExecuteReader
            Dim RiskCount As Integer = 0

            Dim cmbRiskFactors As New DataGridViewComboBoxColumn()
            cmbRiskFactors.HeaderText = "Risk Factor"
            cmbRiskFactors.Name = "RiskFactors"
            mymaster.findFamilyHistoryList(cmbRiskFactors)
            dgvFamilyRiskList.Columns.Add(cmbRiskFactors)

            Dim cmbFamilyRelationship As New DataGridViewComboBoxColumn()
            cmbFamilyRelationship.HeaderText = "Family Relation"
            cmbFamilyRelationship.Name = "RelationRiskFactor"
            cmbFamilyRelationship.MaxDropDownItems = 4
            cmbFamilyRelationship.Items.Add("Mother")
            cmbFamilyRelationship.Items.Add("Father")
            cmbFamilyRelationship.Items.Add("Siblings")
            cmbFamilyRelationship.Items.Add("Ext.Family")
            dgvFamilyRiskList.Columns.Add(cmbFamilyRelationship)
            While (myDataReader1.Read())

                If IsDBNull(myDataReader1.Item("FamilyHistory")) = False Then
                    dgvFamilyRiskList.Rows.Add()
                    dgvFamilyRiskList.Rows(RiskCount).Cells(0).Value = myDataReader1.Item("FamilyHistory")
                    If IsDBNull(myDataReader1.Item("FamilyRelation")) = False Then
                        dgvFamilyRiskList.Rows(RiskCount).Cells(1).Value = myDataReader1.Item("FamilyRelation")
                    End If

                    RiskCount = RiskCount + 1

                End If
            End While
            myDataReader1.Close()
            'Search for Family Riskfactors
            Dim myCommand2 As New SqlCommand
            With myCommand2
                .Connection = myconnection
                .CommandText = "Search_Patient_RiskFactors"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@MRN", SqlDbType.VarChar, 50).Value = ID
            End With

            Dim myDataReader2 As SqlDataReader = myCommand2.ExecuteReader
            While (myDataReader2.Read())
                If myDataReader2.Item("RiskFactor") <> "" Then
                    lstRiskList.Items.Add(myDataReader2.Item("RiskFactor"))
                End If
            End While
            myDataReader2.Close()
            'Search for Family Riskfactors
            Dim myCommand3 As New SqlCommand
            With myCommand3
                .Connection = myconnection
                .CommandText = "Search_Patient_SocialHistory"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@MRN", SqlDbType.VarChar, 50).Value = ID
            End With

            Dim myDataReader3 As SqlDataReader = myCommand3.ExecuteReader
            dgvSocialHistoryList.Columns.Add("SocialItem", "Item")
            dgvSocialHistoryList.Columns.Add("SocialAssesment", "Assesment")
            dgvSocialHistoryList.Rows.Add(16)
            dgvSocialHistoryList.Rows(0).Cells(0).Value = "Lives With:"
            dgvSocialHistoryList.Rows(1).Cells(0).Value = "Carers:"
            dgvSocialHistoryList.Rows(2).Cells(0).Value = "Services:"
            dgvSocialHistoryList.Rows(3).Cells(0).Value = "House Type:"
            dgvSocialHistoryList.Rows(4).Cells(0).Value = "House Stories:"
            dgvSocialHistoryList.Rows(5).Cells(0).Value = "Toilet Location:"
            dgvSocialHistoryList.Rows(6).Cells(0).Value = "Bedroom Location:"
            dgvSocialHistoryList.Rows(7).Cells(0).Value = "Occupation:"
            dgvSocialHistoryList.Rows(8).Cells(0).Value = "Smoking:"
            dgvSocialHistoryList.Rows(9).Cells(0).Value = "Alcohol:"
            dgvSocialHistoryList.Rows(10).Cells(0).Value = "Dressing:"
            dgvSocialHistoryList.Rows(11).Cells(0).Value = "Washing:"
            dgvSocialHistoryList.Rows(12).Cells(0).Value = "Feeding:"
            dgvSocialHistoryList.Rows(13).Cells(0).Value = "Continence:"
            dgvSocialHistoryList.Rows(14).Cells(0).Value = "Transfers:"
            dgvSocialHistoryList.Rows(15).Cells(0).Value = "Mobility:"
            While (myDataReader3.Read())
                If IsDBNull(myDataReader3.Item("LivesWith")) = False Then
                    dgvSocialHistoryList.Rows(0).Cells(1).Value = myDataReader3.Item("LivesWith")
                End If
                If IsDBNull(myDataReader3.Item("Carers")) = False Then
                    dgvSocialHistoryList.Rows(1).Cells(1).Value = myDataReader3.Item("Carers")
                End If
                If IsDBNull(myDataReader3.Item("Services")) = False Then
                    dgvSocialHistoryList.Rows(2).Cells(1).Value = myDataReader3.Item("Services")
                End If
                If IsDBNull(myDataReader3.Item("HouseType")) = False Then
                    dgvSocialHistoryList.Rows(3).Cells(1).Value = myDataReader3.Item("HouseType")
                End If
                If IsDBNull(myDataReader3.Item("HouseStories")) = False Then
                    dgvSocialHistoryList.Rows(4).Cells(1).Value = myDataReader3.Item("HouseStories")
                End If
                If IsDBNull(myDataReader3.Item("ToiletLocation")) = False Then
                    dgvSocialHistoryList.Rows(5).Cells(1).Value = myDataReader3.Item("ToiletLocation")
                End If
                If IsDBNull(myDataReader3.Item("BedroomLocation")) = False Then
                    dgvSocialHistoryList.Rows(6).Cells(1).Value = myDataReader3.Item("BedroomLocation")
                End If
                If IsDBNull(myDataReader3.Item("Occupation")) = False Then
                    dgvSocialHistoryList.Rows(7).Cells(1).Value = myDataReader3.Item("Occupation")
                End If
                If IsDBNull(myDataReader3.Item("Smoking")) = False Then
                    dgvSocialHistoryList.Rows(8).Cells(1).Value = myDataReader3.Item("Smoking")
                End If
                If IsDBNull(myDataReader3.Item("Alcohol")) = False Then
                    dgvSocialHistoryList.Rows(9).Cells(1).Value = myDataReader3.Item("Alcohol")
                End If
                If IsDBNull(myDataReader3.Item("Dressing")) = False Then
                    dgvSocialHistoryList.Rows(10).Cells(1).Value = myDataReader3.Item("Dressing")
                End If
                If IsDBNull(myDataReader3.Item("Washing")) = False Then
                    dgvSocialHistoryList.Rows(11).Cells(1).Value = myDataReader3.Item("Washing")
                End If
                If IsDBNull(myDataReader3.Item("Feeding")) = False Then
                    dgvSocialHistoryList.Rows(12).Cells(1).Value = myDataReader3.Item("Feeding")
                End If
                If IsDBNull(myDataReader3.Item("Continence")) = False Then
                    dgvSocialHistoryList.Rows(13).Cells(1).Value = myDataReader3.Item("Continence")
                End If
                If IsDBNull(myDataReader3.Item("Transfers")) = False Then
                    dgvSocialHistoryList.Rows(14).Cells(1).Value = myDataReader3.Item("Transfers")
                End If
                If IsDBNull(myDataReader3.Item("Mobility")) = False Then
                    dgvSocialHistoryList.Rows(15).Cells(1).Value = myDataReader3.Item("Mobility")
                End If

            End While
            myDataReader3.Close()
            Return True
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
    Public Function findID() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "SearchID"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@SearchID", SqlDbType.VarChar, 50).Value = ID
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("PatientName") <> "" Then
                    Name = myDataReader.Item("PatientName")
                    sSymphony = myDataReader.Item("Symphony")
                    sStatus = myDataReader.Item("Status")
                    dDOB = myDataReader.Item("DOB")
                    Location = myDataReader.Item("Area")
                    Return True
                Else Return False
                End If
            End While
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
    Public Sub findID(ByRef lstv, SearchName)
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "NameSearch"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@SearchName", SqlDbType.VarChar, 50).Value = SearchName
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("PatientName") <> "" Then

                    Dim item1 As New ListViewItem
                    item1.Text = myDataReader.Item("PatientName")
                    item1.SubItems.Add(myDataReader.Item("MRN"))
                    item1.SubItems.Add(myDataReader.Item("Symphony"))
                    item1.SubItems.Add(myDataReader.Item("Status"))
                    lstv.Items.Add(item1)
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
    Public Sub findStatus()
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Patient_Status"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = sStatus
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            While (myDataReader.Read())
                If myDataReader.Item("PatientName") <> "" Then

                    Dim item1 As New ListViewItem
                    item1.Text = myDataReader.Item("PatientName")
                    item1.SubItems.Add(myDataReader.Item("MRN"))
                    item1.SubItems.Add(myDataReader.Item("Area"))
                    item1.SubItems.Add(myDataReader.Item("DOB"))
                    item1.SubItems.Add(myDataReader.Item("Symphony"))
                    item1.SubItems.Add(myDataReader.Item("Status"))
                    lstvPatientDetails.Items.Add(item1)
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
