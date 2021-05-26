Imports System.Data.SqlClient

Public Class Admission

    Inherits Patient
    Dim myMaster As New Master
    'Dim myDocument As New Document
    Dim sConnect As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Derry\Documents\ConnollyAdmissions.mdf;Integrated Security=True;Connect Timeout=30"
    ''Private Variables
    ''Admission Details
    Private dAdmissionDate As Date = Today()
    Private tAdmissionTime As DateTime = Today()
    Private dDischargeDate As Date = Today()
    Private dReferralDate As Date = Today()
    Private dDateSeen As Date = Today()
    Private tSeenTime As DateTime = Today()
    Private sWard As String = ""
    Private sReferralReason As String = ""
    Private sReferralTime As DateTime = Today()
    ''Diagnosis
    Private sDiagnosis_ID As String
    Private sDiagnosisPlan As String
    Private sDiagnosis As String
    Private dgvDiagnosis As New DataGridView
    Private dgvDischargeDiagnosis As New DataGridView
    Private lstvDiagnosisList As ListView
    ''Doctors
    Private sAdmittingDr As String = ""
    Private sMCRN As String = ""
    Private sConsultant As String = ""
    Private sBleep As String = ""
    ''Medication
    Private sPreAdmMedSource As String = ""
    Private sPreAdmSourceName As String = ""
    Private sPreAdmSourceTel As String = ""
    Private dPreAdmMedDate As Date = Today()
    Private sMedication_ID As String
    Private sMedicationName As String
    Private sMedicationDose As String
    Private sMedicationComment As String
    Private dgvMedication As New DataGridView
    Private dgvdischargeMeds As New DataGridView
    ''Presenting Complaint
    Private sPresentingComplaint As String = ""
    Private sPresentingComplaintHistory As String
    Private dgvPresentingComplaintList As New DataGridView
    ''Labs
    Private dLabResultDate As Date
    Private sLabTest As String
    Private dbleLabResult As Double
    Private lstvLabList As ListView
    Private dtLab As DataTable
    Dim dtLab1 As New DataTable()
    Private dgLab As New DataGridView
    ''Progress 
    Private sProgressSummary As String = ""
    Private dProgressDate As DateTime
    Private sProgressNote As String = ""
    Private dgvProgressGrid As New DataGridView
    ''Physical Exam 

    Private dgvVitals As New DataGridView
    Private dgvPhysicalSigns As New DataGridView
    Private dgvOrgans As New DataGridView
    Private dgvLimbs As New DataGridView
    Private dgvAssesment As New DataGridView

    Private sCondition As String = ""
    Private sFluid As String = ""
    Private sTemperature As String = ""
    Private sHeartRate As String = ""
    Private sBP_Lying As String = ""
    Private sBP_Standing As String = ""
    Private sRespRate As String = ""
    Private sO2Sats As String = ""
    Private sGCS As String = ""
    Private s4AT As String = ""
    Private soTime As String = ""
    Private soPerson As String = ""
    Private soPlace As String = ""
    Private sHands_Nails As String = ""
    Private sEyes As String = ""
    Private sENT As String = ""
    Private sBreasts As String = ""
    Private sJVP As String = ""
    Private sCarotidBruits As String = ""
    Private sCervicalLNs As String = ""
    Private sAxillaryLNs As String = ""
    Private sHeartS1 As String = ""
    Private sHeartS2 As String = ""
    Private sHeartAddedSounds As String = ""
    Private sHeartMurmers As String = ""
    Private sChestLeft As String = ""
    Private sChestRight As String = ""
    Private sAbdomenAAA As String = ""
    Private sAbdomenBowelSounds As String = ""
    Private sAbdomenHernia As String = ""
    Private sAbdomenPR As String = ""
    Private sCranial2 As String = ""
    Private sCranial346 As String = ""
    Private sCranial5 As String = ""
    Private sCranial7 As String = ""
    Private sCranial8 As String = ""
    Private sCranial910 As String = ""
    Private sCranial11 As String = ""
    Private sCranial12 As String = ""
    Private sRArmTone As String = ""
    Private sRArmPower As String = ""
    Private sRArmReflexes As String = ""
    Private sRArmCo As String = ""
    Private sRArmSensation As String = ""
    Private sLArmTone As String = ""
    Private sLArmPower As String = ""
    Private sLArmReflexes As String = ""
    Private sLArmCo As String = ""
    Private sLArmSensation As String = ""
    Private sRLegTone As String = ""
    Private sRLegPower As String = ""
    Private sRLegReflexes As String = ""
    Private sRLegCo As String = ""
    Private sRLegSensation As String = ""
    Private sRLegPlantars As String = ""
    Private sLLegTone As String = ""
    Private sLLegPower As String = ""
    Private sLLegReflexes As String = ""
    Private sLLegCo As String = ""
    Private sLLegSensation As String = ""
    Private sLLegPlantars As String = ""
    Private sLegs As String = ""
    Private sPeripheralPulses As String = ""
    Private sGait As String = ""
    Private sBack As String = ""
    Private sJoints As String = ""
    Private sSkin As String = ""
    Private sOthers As String = ""
    ''Image
    Private sECG As String = ""
    Private sCXR As String = ""
    Private sMSU As String = ""
    Private sXRayOther As String = ""
    Private sImageOther As String = ""
    Private dgvImage As New DataGridView
    ''MedicPlans
    Private sConAssesment As String = ""
    Private sConImpression As String = ""
    Private sConPlan As String = ""
    Private sConName As String = ""
    Private sConID As String = ""

    Private sRegAssesment As String = ""
    Private sRegImpression As String = ""
    Private sRegPlan As String = ""
    Private sRegName As String = ""
    Private sRegID As String = ""
    'Previous History
    Private sPreviousSymphony As String = ""
    Private sPreviousProgress As String = ""
    Private dPreviousAdmissionDate As Date
    Private dPreviousDischargeDate As Date
    Private dgvPreviousDiagnosis As New DataGridView
    Private dgvPreviousMedication As New DataGridView
    'DischargeMedication
    Private sDMedication_ID As String
    Private sDMedicationName As String
    Private sDMedicationDose As String
    Private sDMedicationComment As String
    Private dgvDischargeMedication As New DataGridView
    'Procedures
    Private lvProcedureList As ListView
    Private sProcedure As String
    Private sProcedureID As String
    ''Clinic Details
    Private dAppointmentDate As Date



    ''Public Variables

    'Admission Details
    Public Property AdmissionDate As Date
        Get
            Return dAdmissionDate
        End Get
        Set(value As Date)
            dAdmissionDate = value
        End Set
    End Property
    Public Property AdmissionTime As DateTime
        Get
            Return tAdmissionTime
        End Get
        Set(value As DateTime)
            tAdmissionTime = value
        End Set
    End Property
    Public Property DateSeen As Date
        Get
            Return dDateSeen
        End Get
        Set(value As Date)
            dDateSeen = value
        End Set
    End Property
    Public Property SeenTime As DateTime
        Get
            Return tSeenTime
        End Get
        Set(value As DateTime)
            tSeenTime = value
        End Set
    End Property
    Public Property DischargeDate As Date
        Get
            Return dDischargeDate
        End Get
        Set(value As Date)
            dDischargeDate = value
        End Set
    End Property
    Public Property ReferralDate As Date
        Get
            Return dReferralDate
        End Get
        Set(value As Date)
            dReferralDate = value
        End Set
    End Property
    Public Property Ward As String
        Get
            Return sWard
        End Get
        Set(value As String)
            If value <> "" Then
                sWard = value
            Else
                sWard = "Not Entered"
            End If

        End Set
    End Property
    Public Property ReferralReason As String
        Get
            Return sReferralReason
        End Get
        Set(value As String)
            If value <> "" Then
                sReferralReason = value
            Else sReferralReason = "Not Entered"
            End If
        End Set
    End Property
    Public Property ReferralTime As DateTime
        Get
            Return sReferralTime
        End Get
        Set(value As DateTime)
            sReferralTime = value
        End Set
    End Property
    ''Doctors
    Public Property Bleep As String
        Get
            Return sBleep
        End Get
        Set(value As String)
            If value <> "" Then
                sBleep = value
            Else sBleep = "Not Entered"
            End If
        End Set
    End Property
    Public Property AdmittingDr As String
        Get
            Return sAdmittingDr
        End Get
        Set(value As String)
            If value <> "" Then
                sAdmittingDr = value
            Else
                sAdmittingDr = "Not Entered"
            End If
        End Set
    End Property
    Public Property MCRN As String
        Get
            Return sMCRN
        End Get
        Set(value As String)
            If value <> "" Then
                sMCRN = value
            Else sMCRN = "Not Entered"
            End If
        End Set
    End Property
    Public Property Consultant As String
        Get
            Return sConsultant
        End Get
        Set(value As String)
            If value <> "" Then
                sConsultant = value
            Else sConsultant = "Not Entered"
            End If
        End Set
    End Property
    'Presenting Complaint
    Public Property PresentingComplaint As String
        Get
            Return sPresentingComplaint
        End Get
        Set(value As String)
            sPresentingComplaint = value
        End Set
    End Property
    Public Property PresentingComplaintHistory As String
        Get
            Return sPresentingComplaintHistory
        End Get
        Set(value As String)
            sPresentingComplaintHistory = value
        End Set
    End Property

    Public Property PresentingComplaintList As DataGridView
        Get
            Return dgvPresentingComplaintList
        End Get
        Set(value As DataGridView)
            dgvPresentingComplaintList = value
        End Set
    End Property
    'Medication
    Public Property PreAdmMedSource As String
        Get
            Return sPreAdmMedSource
        End Get
        Set(value As String)
            sPreAdmMedSource = value
        End Set
    End Property
    Public Property PreAdmSourceName As String
        Get
            Return sPreAdmSourceName
        End Get
        Set(value As String)
            sPreAdmSourceName = value
        End Set
    End Property
    Public Property PreAdmSourceTel As String
        Get
            Return sPreAdmSourceTel
        End Get
        Set(value As String)
            sPreAdmSourceTel = value
        End Set
    End Property
    Public Property PreAdmMedDate As Date
        Get
            Return dPreAdmMedDate
        End Get
        Set(value As Date)
            dPreAdmMedDate = value
        End Set
    End Property
    Public Property Medication_ID As String
        Get
            Return sMedication_ID
        End Get
        Set(value As String)
            sMedication_ID = value
        End Set
    End Property
    Public Property MedicationName As String
        Get
            Return sMedicationName
        End Get
        Set(value As String)
            sMedicationName = value
        End Set
    End Property

    Public Property MedicationDose As String
        Get
            Return sMedicationDose
        End Get
        Set(value As String)
            sMedicationDose = value
        End Set
    End Property
    Public Property MedicationComment As String
        Get
            Return sMedicationComment
        End Get
        Set(value As String)
            sMedicationComment = value
        End Set
    End Property

    Public Property MedicationList As DataGridView
        Get
            Return dgvMedication
        End Get
        Set(value As DataGridView)
            dgvMedication = value
        End Set
    End Property
    Public Property DischargeMeds As DataGridView
        Get
            Return dgvdischargeMeds
        End Get
        Set(value As DataGridView)
            dgvdischargeMeds = value
        End Set
    End Property
    'Diagnosis
    Public Property DiagnosisID As String
        Get
            Return sDiagnosis_ID
        End Get
        Set(value As String)
            sDiagnosis_ID = value
        End Set
    End Property
    Public Property DiagnosisPlan As String
        Get
            Return sDiagnosisPlan
        End Get
        Set(value As String)
            sDiagnosisPlan = value
        End Set
    End Property
    Public Property Diagnosis As String
        Get
            Return sDiagnosis
        End Get
        Set(value As String)
            sDiagnosis = value
        End Set
    End Property
    Public Property DischargeDiagnosisList As DataGridView
        Get
            Return dgvDischargeDiagnosis
        End Get
        Set(value As DataGridView)
            dgvDischargeDiagnosis = value
        End Set
    End Property
    Public Property DiagnosisGrid As DataGridView
        Get
            Return dgvDiagnosis
        End Get
        Set(value As DataGridView)
            dgvDiagnosis = value
        End Set
    End Property
    Public Property DiagnosisList As ListView
        Get
            Return lstvDiagnosisList
        End Get
        Set(value As ListView)
            lstvDiagnosisList = value
        End Set
    End Property
    ''Labs
    Public Property LabsDataGridView As DataGridView
        Get
            Return dgLab
        End Get
        Set(value As DataGridView)
            dgLab = value
        End Set
    End Property

    Public Property LabsDataTable As DataTable
        Get
            Return dtLab
        End Get
        Set(value As DataTable)
            dtLab = value
        End Set
    End Property
    Public Property LabResultDate As Date
        Get
            Return dLabResultDate
        End Get
        Set(value As Date)
            dLabResultDate = value
        End Set
    End Property
    Public Property LabTest As String
        Get
            Return sLabTest
        End Get
        Set(value As String)
            sLabTest = value
        End Set
    End Property
    Public Property LabResult As Double
        Get
            Return dbleLabResult
        End Get
        Set(value As Double)
            dbleLabResult = value
        End Set
    End Property
    Public Property Lablist As ListView
        Get
            Return lstvLabList
        End Get
        Set(value As ListView)
            lstvLabList = value
        End Set
    End Property
    ''Progress
    Public Property ProgressSummary As String
        Get
            Return sProgressSummary
        End Get
        Set(value As String)
            sProgressSummary = value
        End Set
    End Property
    Public Property ProgressNote As String
        Get
            Return sProgressNote
        End Get
        Set(value As String)
            sProgressNote = value
        End Set
    End Property
    Public Property ProgressDate As DateTime
        Get
            Return dProgressDate
        End Get
        Set(value As Date)
            dProgressDate = value
        End Set
    End Property
    Public Property ProgressGrid As DataGridView
        Get
            Return dgvProgressGrid
        End Get
        Set(value As DataGridView)
            dgvProgressGrid = value
        End Set
    End Property
    ''Physical Examination
    Public Property PhysicalAssesment As DataGridView
        Get
            Return dgvAssesment
        End Get
        Set(value As DataGridView)
            dgvAssesment = value
        End Set
    End Property
    Public Property Limbs As DataGridView
        Set(value As DataGridView)
            dgvLimbs = value
        End Set
        Get
            Return dgvLimbs
        End Get
    End Property
    Public Property Vitals As DataGridView
        Get
            Return dgvVitals
        End Get
        Set(value As DataGridView)
            dgvVitals = value
        End Set
    End Property
    Public Property PhysicalSigns As DataGridView
        Get
            Return dgvPhysicalSigns
        End Get
        Set(value As DataGridView)
            dgvPhysicalSigns = value
        End Set
    End Property
    Public Property Organs As DataGridView
        Get
            Return dgvOrgans
        End Get
        Set(value As DataGridView)
            dgvOrgans = value
        End Set
    End Property

    Public Property Condition As String
        Set(value As String)
            sCondition = value
        End Set
        Get
            Return sCondition
        End Get
    End Property
    Public Property Fluid As String
        Get
            Return sFluid
        End Get
        Set(value As String)
            sFluid = value
        End Set
    End Property
    ''Images
    Public Property Image As DataGridView
        Get
            Return dgvImage
        End Get
        Set(value As DataGridView)
            dgvImage = value
        End Set
    End Property
    ''Medic Plans
    Public Property ConAssesment As String
        Get
            Return sConAssesment
        End Get
        Set(value As String)
            sConAssesment = value
        End Set
    End Property
    Public Property ConImpression As String
        Get
            Return sConImpression
        End Get
        Set(value As String)
            sConImpression = value
        End Set
    End Property
    Public Property ConPlan As String
        Get
            Return sConPlan
        End Get
        Set(value As String)
            sConPlan = value
        End Set
    End Property
    Public Property ConID As String
        Get
            Return sConID
        End Get
        Set(value As String)
            sConID = value
        End Set
    End Property
    Public Property ConName As String
        Get
            Return sConName
        End Get
        Set(value As String)
            sConName = value
        End Set
    End Property
    Public Property RegAssesment As String
        Get
            Return sRegAssesment
        End Get
        Set(value As String)
            sRegAssesment = value
        End Set
    End Property
    Public Property RegImpression As String
        Get
            Return sRegImpression
        End Get
        Set(value As String)
            sRegImpression = value
        End Set
    End Property
    Public Property RegPlan As String
        Get
            Return sRegPlan
        End Get
        Set(value As String)
            sRegPlan = value
        End Set
    End Property
    Public Property RegID As String
        Get
            Return sRegID
        End Get
        Set(value As String)
            sRegID = value
        End Set
    End Property
    Public Property RegName As String
        Get
            Return sRegName
        End Get
        Set(value As String)
            sRegName = value
        End Set
    End Property
    'Previous Progress
    Public Property PreviousSymphony As String
        Set(value As String)
            sPreviousSymphony = value
        End Set
        Get
            Return sPreviousSymphony
        End Get
    End Property
    Public Property PreviousProgress As String
        Set(value As String)
            sPreviousProgress = value
        End Set
        Get
            Return sPreviousProgress
        End Get
    End Property
    Public Property PreviousAdmissionDate As Date
        Get
            Return dPreviousAdmissionDate
        End Get
        Set(value As Date)
            dPreviousAdmissionDate = value
        End Set
    End Property
    Public Property PreviousDischargeDate As Date
        Get
            Return dPreviousDischargeDate
        End Get
        Set(value As Date)
            dPreviousDischargeDate = value
        End Set
    End Property
    Public Property PreviousDiagnosis As DataGridView
        Get
            Return dgvPreviousDiagnosis
        End Get
        Set(value As DataGridView)
            dgvPreviousDiagnosis = value
        End Set
    End Property
    Public Property PreviousMedication As DataGridView
        Get
            Return dgvPreviousMedication
        End Get
        Set(value As DataGridView)
            dgvPreviousMedication = value
        End Set
    End Property
    ''DischargeMeds
    Public Property DischargeMedication As DataGridView
        Get
            Return dgvDischargeMedication
        End Get
        Set(value As DataGridView)
            dgvDischargeMedication = value
        End Set
    End Property
    ''Procedure
    Public Property ProcedureList As ListView
        Get
            Return lvProcedureList
        End Get
        Set(value As ListView)
            lvProcedureList = value
        End Set
    End Property
    ''Clinic
    Public Property AppointmentDate As Date
        Get
            Return dAppointmentDate
        End Get
        Set(value As Date)
            dAppointmentDate = value
        End Set
    End Property






    ''Functions
    Public Function UpdateAdmission() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Admission Details to Admission Table
            Dim myCommand10 As New SqlCommand

            With myCommand10
                .Connection = myconnection
                .CommandText = "Add_Admission"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@AdmissionDate", SqlDbType.Date).Value = dAdmissionDate
                    .Add("@ReferralDate", SqlDbType.Date).Value = dReferralDate
                    .Add("@DateSeen", SqlDbType.Date).Value = dDateSeen
                    .Add("@ReferralReason", SqlDbType.VarChar, 50).Value = sReferralReason

                    .Add("@ReferralTime", SqlDbType.DateTime).Value = sReferralTime
                    .Add("@Consultant", SqlDbType.VarChar, 50).Value = sConsultant
                    .Add("@AdmittingDr", SqlDbType.VarChar, 50).Value = sAdmittingDr
                    .Add("@MCRN", SqlDbType.VarChar, 50).Value = sMCRN
                    .Add("@Bleep", SqlDbType.VarChar, 50).Value = sBleep
                    .Add("@Ward", SqlDbType.VarChar, 50).Value = sWard
                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
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



    Public Function AddAdmission() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Admission Details to Admission Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Update_Admission"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@AdmissionDate", SqlDbType.Date).Value = dAdmissionDate
                    .Add("@AdmissionTime", SqlDbType.DateTime).Value = tAdmissionTime
                    .Add("@ReferralDate", SqlDbType.Date).Value = dReferralDate
                    .Add("@DateSeen", SqlDbType.Date).Value = dDateSeen
                    .Add("@SeenTime", SqlDbType.DateTime).Value = tSeenTime
                    .Add("@ReferralReason", SqlDbType.VarChar, 50).Value = sReferralReason
                    .Add("@ReferralTime", SqlDbType.DateTime).Value = sReferralTime
                    .Add("@Consultant", SqlDbType.VarChar, 50).Value = sConsultant
                    .Add("@AdmittingDr", SqlDbType.VarChar, 50).Value = sAdmittingDr
                    .Add("@MCRN", SqlDbType.VarChar, 50).Value = sMCRN
                    .Add("@Bleep", SqlDbType.VarChar, 50).Value = sBleep
                    .Add("@Ward", SqlDbType.VarChar, 50).Value = sWard
                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
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
    Public Function AddPresentingComplaint() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Delete Presenting Complaint
            Dim myCommand1 As New SqlCommand

            With myCommand1
                .Connection = myconnection
                .CommandText = "Delete_Admission_PresentingComplaint"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar).Value = Symphony
                End With
                .ExecuteNonQuery()
            End With

            'Add Presenting Complaint
            Dim PCCount As Integer

            For PCCount = 0 To dgvPresentingComplaintList.Rows.Count - 1


                Dim myCommand2 As New SqlCommand

                With myCommand2
                    .Connection = myconnection
                    .CommandText = "Add_Admission_PresentingComplaint"
                    .CommandType = CommandType.StoredProcedure
                    With .Parameters
                        With dgvPresentingComplaintList.Rows(PCCount)
                            sPresentingComplaint = .Cells(0).Value
                            sPresentingComplaintHistory = .Cells(1).Value
                        End With
                        .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                        .Add("@PC", SqlDbType.VarChar, 50).Value = sPresentingComplaint
                        .Add("@PCHistory", SqlDbType.VarChar, 50).Value = sPresentingComplaintHistory
                    End With
                    If sPresentingComplaint <> "" Then
                        .ExecuteNonQuery()
                    End If
                End With
            Next
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

    Public Function AddMedication() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()

            'Delete Medication Details
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Delete_MedicationHistory"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar).Value = Symphony
                End With
                .ExecuteNonQuery()
            End With
            'Update Pre-Admission Source details in Admission Databse
            Dim myCommand2 As New SqlCommand

            With myCommand2
                .Connection = myconnection
                .CommandText = "Update_Admission_PreAdmissionDetails"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar).Value = Symphony
                    .Add("@PreAdmMedSource", SqlDbType.VarChar, 50).Value = sPreAdmMedSource
                    .Add("@PreAdmMedDate", SqlDbType.Date).Value = dPreAdmMedDate
                    .Add("@PreAdmSourceTel", SqlDbType.VarChar, 50).Value = sPreAdmSourceTel
                    .Add("@PreAdmSourceName", SqlDbType.VarChar, 50).Value = sPreAdmSourceName
                End With
                .ExecuteNonQuery()
            End With

            'Add Medication 
            Dim MedCount As Integer
            For MedCount = 0 To dgvMedication.Rows.Count - 1
                Dim myCommand1 As New SqlCommand

                With myCommand1
                    .Connection = myconnection
                    .CommandText = "Add_Admission_Medication"
                    .CommandType = CommandType.StoredProcedure

                    With .Parameters

                        With dgvMedication.Rows(MedCount)
                            sMedication_ID = .Cells(0).Value
                            sMedicationName = .Cells(1).Value
                            sMedicationDose = .Cells(2).Value
                            sMedicationComment = .Cells(3).Value
                        End With
                        .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                        .Add("@AdmissionDate", SqlDbType.Date).Value = dAdmissionDate
                        .Add("@Name", SqlDbType.VarChar, 50).Value = sMedicationName
                        .Add("@MedicationDose", SqlDbType.VarChar, 50).Value = sMedicationDose
                        .Add("@Medication_Id", SqlDbType.VarChar, 50).Value = sMedication_ID
                        .Add("@MedicationComment", SqlDbType.VarChar, 50).Value = sMedicationComment
                    End With
                    .ExecuteNonQuery()
                End With
            Next
            Return True
        Catch ex As Exception
            If sMedicationDose = "" Then
                MessageBox.Show("Medication Not Saved-Please Ensure Directions are entered (Add N/A if not Applicable)")
            Else
                Dim myMessage As New Message
                myMessage.ReportError("Record Not Added", ex)
                Return False
            End If
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    Public Function AddDiagnosis() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Delete Diagnosis Details
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Delete_Admission_Diagnosis"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar).Value = Symphony
                End With
                .ExecuteNonQuery()
            End With
            'Add Diagnosis
            Dim DiagnosisCount As Integer
            For DiagnosisCount = 0 To dgvDiagnosis.Rows.Count - 1
                Dim myCommand2 As New SqlCommand

                With myCommand2
                    .Connection = myconnection
                    .CommandText = "Add_Admission_Diagnosis"
                    .CommandType = CommandType.StoredProcedure

                    With .Parameters

                        With dgvDiagnosis.Rows(DiagnosisCount)
                            sDiagnosis_ID = .Cells(0).Value
                            sDiagnosis = .Cells(1).Value
                            sDiagnosisPlan = .Cells(2).Value
                        End With
                        .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                        .Add("@Diagnosis_ID", SqlDbType.VarChar, 50).Value = sDiagnosis_ID
                        .Add("@Diagnosis", SqlDbType.VarChar, 50).Value = sDiagnosis
                        .Add("@DiagnosisPlan", SqlDbType.VarChar, 50).Value = sDiagnosisPlan
                    End With
                    If sDiagnosis_ID <> "" Then
                        .ExecuteNonQuery()
                    End If
                End With
            Next
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
    Public Function AddLabResults() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Delete Labs
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Delete_Admission_Labs"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar).Value = Symphony
                End With
                .ExecuteNonQuery()
            End With
            'Add Labs
            Dim myCommand2 As New SqlCommand

            With myCommand2
                .Connection = myconnection
                .CommandText = "Add_Admission_Lab"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@dtLab", dtLab)
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
    Public Function AddProgress() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Delete Progress
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Delete_Admission_Progress"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar).Value = Symphony
                End With
                .ExecuteNonQuery()
            End With
            'Add Progress
            Dim ProgressCount As Integer
            For ProgressCount = 0 To dgvProgressGrid.Rows.Count - 1
                Dim myCommand2 As New SqlCommand

                With myCommand2
                    .Connection = myconnection
                    .CommandText = "Add_Admission_Progress"
                    .CommandType = CommandType.StoredProcedure

                    With .Parameters
                        With dgvProgressGrid.Rows(ProgressCount)
                            dProgressDate = .Cells(0).Value
                            sProgressNote = .Cells(1).Value
                        End With

                        .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                        .Add("@Date", SqlDbType.DateTime).Value = dProgressDate
                        .Add("@Progress", SqlDbType.VarChar, 50).Value = sProgressNote

                    End With
                    If sProgressNote <> "" Then
                        .ExecuteNonQuery()
                    End If
                End With

            Next
            'Add Progress Summary
            Dim myCommand3 As New SqlCommand

            With myCommand3
                .Connection = myconnection
                .CommandText = "Update_Admission_ProgressSummary"
                .CommandType = CommandType.StoredProcedure

                With .Parameters

                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                    .Add("@ProgressSummary", SqlDbType.VarChar).Value = sProgressSummary

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
    Public Function AddPhysicalExam() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Add Admission Details to Admission Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Update_Admission_PhysicalExam"
                .CommandType = CommandType.StoredProcedure

                ''Add Vitals

                If dgvVitals.Rows(0).Cells(1).Value <> "" Then
                    sTemperature = dgvVitals.Rows(0).Cells(1).Value
                End If
                If dgvVitals.Rows(1).Cells(1).Value <> "" Then
                    sHeartRate = dgvVitals.Rows(1).Cells(1).Value
                End If
                If dgvVitals.Rows(2).Cells(1).Value <> "" Then
                    sBP_Lying = dgvVitals.Rows(2).Cells(1).Value
                End If
                If dgvVitals.Rows(3).Cells(1).Value <> "" Then
                    sBP_Standing = dgvVitals.Rows(3).Cells(1).Value
                End If
                If dgvVitals.Rows(4).Cells(1).Value <> "" Then
                    sRespRate = dgvVitals.Rows(4).Cells(1).Value
                End If
                If dgvVitals.Rows(5).Cells(1).Value <> "" Then
                    sO2Sats = dgvVitals.Rows(5).Cells(1).Value
                End If
                If dgvVitals.Rows(6).Cells(1).Value <> "" Then
                    sGCS = dgvVitals.Rows(6).Cells(1).Value
                End If

                If dgvVitals.Rows(7).Cells(1).Value <> "" Then
                    s4AT = dgvVitals.Rows(7).Cells(1).Value
                End If
                If dgvVitals.Rows(8).Cells(1).Value <> "" Then
                    soTime = dgvVitals.Rows(8).Cells(1).Value
                End If
                If dgvVitals.Rows(9).Cells(1).Value <> "" Then
                    soPerson = dgvVitals.Rows(9).Cells(1).Value
                End If
                If dgvVitals.Rows(10).Cells(1).Value <> "" Then
                    soPlace = dgvVitals.Rows(10).Cells(1).Value
                End If

                ''Add Physical Signs
                If dgvPhysicalSigns.Rows(0).Cells(1).Value <> "" Then
                    sHands_Nails = dgvPhysicalSigns.Rows(0).Cells(1).Value
                End If
                If dgvPhysicalSigns.Rows(1).Cells(1).Value <> "" Then
                    sEyes = dgvPhysicalSigns.Rows(1).Cells(1).Value
                End If
                If dgvPhysicalSigns.Rows(2).Cells(1).Value <> "" Then
                    sENT = dgvPhysicalSigns.Rows(2).Cells(1).Value
                End If
                If dgvPhysicalSigns.Rows(3).Cells(1).Value <> "" Then
                    sBreasts = dgvPhysicalSigns.Rows(3).Cells(1).Value
                End If
                If dgvPhysicalSigns.Rows(4).Cells(1).Value <> "" Then
                    sJVP = dgvPhysicalSigns.Rows(4).Cells(1).Value
                End If
                If dgvPhysicalSigns.Rows(5).Cells(1).Value <> "" Then
                    sCarotidBruits = dgvPhysicalSigns.Rows(5).Cells(1).Value
                End If
                If dgvPhysicalSigns.Rows(6).Cells(1).Value <> "" Then
                    sCervicalLNs = dgvPhysicalSigns.Rows(6).Cells(1).Value
                End If

                If dgvPhysicalSigns.Rows(7).Cells(1).Value <> "" Then
                    sAxillaryLNs = dgvPhysicalSigns.Rows(7).Cells(1).Value
                End If

                ''Organs
                If dgvOrgans.Rows(0).Cells(1).Value <> "" Then
                    sHeartS1 = dgvOrgans.Rows(0).Cells(1).Value
                End If
                If dgvOrgans.Rows(1).Cells(1).Value <> "" Then
                    sHeartS2 = dgvOrgans.Rows(1).Cells(1).Value
                End If
                If dgvOrgans.Rows(2).Cells(1).Value <> "" Then
                    sHeartAddedSounds = dgvOrgans.Rows(2).Cells(1).Value
                End If
                If dgvOrgans.Rows(3).Cells(1).Value <> "" Then
                    sHeartMurmers = dgvOrgans.Rows(3).Cells(1).Value
                End If
                If dgvOrgans.Rows(4).Cells(1).Value <> "" Then
                    sChestLeft = dgvOrgans.Rows(4).Cells(1).Value
                End If
                If dgvOrgans.Rows(5).Cells(1).Value <> "" Then
                    sChestRight = dgvOrgans.Rows(5).Cells(1).Value
                End If
                If dgvOrgans.Rows(6).Cells(1).Value <> "" Then
                    sAbdomenAAA = dgvOrgans.Rows(6).Cells(1).Value
                End If

                If dgvOrgans.Rows(7).Cells(1).Value <> "" Then
                    sAbdomenBowelSounds = dgvOrgans.Rows(7).Cells(1).Value
                End If
                If dgvOrgans.Rows(8).Cells(1).Value <> "" Then
                    sAbdomenHernia = dgvOrgans.Rows(8).Cells(1).Value
                End If
                If dgvOrgans.Rows(9).Cells(1).Value <> "" Then
                    sAbdomenPR = dgvOrgans.Rows(9).Cells(1).Value
                End If
                If dgvOrgans.Rows(10).Cells(1).Value <> "" Then
                    sCranial2 = dgvOrgans.Rows(10).Cells(1).Value
                End If
                If dgvOrgans.Rows(11).Cells(1).Value <> "" Then
                    sCranial346 = dgvOrgans.Rows(11).Cells(1).Value
                End If
                If dgvOrgans.Rows(12).Cells(1).Value <> "" Then
                    sCranial5 = dgvOrgans.Rows(12).Cells(1).Value
                End If
                If dgvOrgans.Rows(13).Cells(1).Value <> "" Then
                    sCranial7 = dgvOrgans.Rows(13).Cells(1).Value
                End If
                If dgvOrgans.Rows(14).Cells(1).Value <> "" Then
                    sCranial8 = dgvOrgans.Rows(14).Cells(1).Value
                End If
                If dgvOrgans.Rows(15).Cells(1).Value <> "" Then
                    sCranial910 = dgvOrgans.Rows(15).Cells(1).Value
                End If
                If dgvOrgans.Rows(16).Cells(1).Value <> "" Then
                    sCranial11 = dgvOrgans.Rows(16).Cells(1).Value
                End If
                If dgvOrgans.Rows(17).Cells(1).Value <> "" Then
                    sCranial12 = dgvOrgans.Rows(17).Cells(1).Value
                End If
                ''Limbs
                If dgvLimbs.Rows(0).Cells(1).Value <> "" Then
                    sRArmTone = dgvLimbs.Rows(0).Cells(1).Value
                End If
                If dgvLimbs.Rows(1).Cells(1).Value <> "" Then
                    sRArmPower = dgvLimbs.Rows(1).Cells(1).Value
                End If
                If dgvLimbs.Rows(2).Cells(1).Value <> "" Then
                    sRArmReflexes = dgvLimbs.Rows(2).Cells(1).Value
                End If
                If dgvLimbs.Rows(3).Cells(1).Value <> "" Then
                    sRArmCo = dgvLimbs.Rows(3).Cells(1).Value
                End If
                If dgvLimbs.Rows(4).Cells(1).Value <> "" Then
                    sRArmSensation = dgvLimbs.Rows(3).Cells(1).Value
                End If

                If dgvLimbs.Rows(0).Cells(2).Value <> "" Then
                    sLArmTone = dgvLimbs.Rows(0).Cells(2).Value
                End If
                If dgvLimbs.Rows(1).Cells(2).Value <> "" Then
                    sLArmPower = dgvLimbs.Rows(1).Cells(2).Value
                End If
                If dgvLimbs.Rows(2).Cells(2).Value <> "" Then
                    sLArmReflexes = dgvLimbs.Rows(2).Cells(2).Value
                End If
                If dgvLimbs.Rows(3).Cells(2).Value <> "" Then
                    sLArmCo = dgvLimbs.Rows(3).Cells(2).Value
                End If
                If dgvLimbs.Rows(4).Cells(2).Value <> "" Then
                    sLArmSensation = dgvLimbs.Rows(4).Cells(2).Value
                End If
                If dgvLimbs.Rows(0).Cells(3).Value <> "" Then
                    sRLegTone = dgvLimbs.Rows(0).Cells(3).Value
                End If
                If dgvLimbs.Rows(1).Cells(3).Value <> "" Then
                    sRLegPower = dgvLimbs.Rows(1).Cells(3).Value
                End If
                If dgvLimbs.Rows(2).Cells(3).Value <> "" Then
                    sRLegReflexes = dgvLimbs.Rows(2).Cells(3).Value
                End If
                If dgvLimbs.Rows(3).Cells(3).Value <> "" Then
                    sRLegCo = dgvLimbs.Rows(3).Cells(3).Value
                End If
                If dgvLimbs.Rows(4).Cells(3).Value <> "" Then
                    sRLegSensation = dgvLimbs.Rows(4).Cells(3).Value
                End If
                If dgvLimbs.Rows(5).Cells(3).Value <> "" Then
                    sRLegPlantars = dgvLimbs.Rows(5).Cells(3).Value
                End If
                If dgvLimbs.Rows(0).Cells(4).Value <> "" Then
                    sLLegTone = dgvLimbs.Rows(0).Cells(4).Value
                End If
                If dgvLimbs.Rows(1).Cells(4).Value <> "" Then
                    sLLegPower = dgvLimbs.Rows(1).Cells(4).Value
                End If
                If dgvLimbs.Rows(2).Cells(4).Value <> "" Then
                    sLLegReflexes = dgvLimbs.Rows(2).Cells(4).Value
                End If
                If dgvLimbs.Rows(3).Cells(4).Value <> "" Then
                    sLLegCo = dgvLimbs.Rows(3).Cells(4).Value
                End If
                If dgvLimbs.Rows(4).Cells(4).Value <> "" Then
                    sLLegSensation = dgvLimbs.Rows(4).Cells(4).Value
                End If
                If dgvLimbs.Rows(5).Cells(4).Value <> "" Then
                    sLLegPlantars = dgvLimbs.Rows(5).Cells(4).Value
                End If
                With .Parameters
                    ''Assesment


                    If dgvAssesment.Rows(0).Cells(1).Value <> "" Then
                        sLegs = dgvAssesment.Rows(0).Cells(1).Value
                    End If

                    If dgvAssesment.Rows(1).Cells(1).Value <> "" Then
                        sPeripheralPulses = dgvAssesment.Rows(1).Cells(1).Value
                    End If
                    If dgvAssesment.Rows(2).Cells(1).Value <> "" Then
                        sGait = dgvAssesment.Rows(2).Cells(1).Value
                    End If
                    If dgvAssesment.Rows(3).Cells(1).Value <> "" Then
                        sBack = dgvAssesment.Rows(3).Cells(1).Value
                    End If
                    If dgvAssesment.Rows(4).Cells(1).Value <> "" Then
                        sJoints = dgvAssesment.Rows(4).Cells(1).Value
                    End If

                    If dgvAssesment.Rows(5).Cells(1).Value <> "" Then
                        sSkin = dgvAssesment.Rows(5).Cells(1).Value
                    End If
                    If dgvAssesment.Rows(6).Cells(1).Value <> "" Then
                        sOthers = dgvAssesment.Rows(6).Cells(1).Value
                    End If


                    ''Vitals

                    .Add("@Condition", SqlDbType.VarChar, 50).Value = sCondition
                    .Add("@Fluid", SqlDbType.VarChar, 50).Value = sFluid
                    .Add("@Temperature", SqlDbType.VarChar, 50).Value = sTemperature
                    .Add("@HeartRate", SqlDbType.VarChar, 50).Value = sHeartRate
                    .Add("@BP_Lying", SqlDbType.VarChar, 50).Value = sBP_Lying
                    .Add("@BP_Standing", SqlDbType.VarChar, 50).Value = sBP_Standing
                    .Add("@RespRate", SqlDbType.VarChar, 50).Value = sRespRate
                    .Add("@O2Sats", SqlDbType.VarChar, 50).Value = sO2Sats
                    .Add("@GCS", SqlDbType.VarChar, 50).Value = sGCS
                    .Add("@4AT", SqlDbType.VarChar, 50).Value = s4AT
                    .Add("@oTime", SqlDbType.VarChar, 50).Value = soTime
                    .Add("@oPerson", SqlDbType.VarChar, 50).Value = soPerson
                    .Add("@oPlace", SqlDbType.VarChar, 50).Value = soPlace

                    ''Physical Signs

                    .Add("@Hands_Nails", SqlDbType.VarChar, 50).Value = sHands_Nails
                    .Add("@Eyes", SqlDbType.VarChar, 50).Value = sEyes
                    .Add("@ENT", SqlDbType.VarChar, 50).Value = sENT
                    .Add("@Breasts", SqlDbType.VarChar, 50).Value = sBreasts
                    .Add("@JVP", SqlDbType.VarChar, 50).Value = sJVP
                    .Add("@CarotidBruits", SqlDbType.VarChar, 50).Value = sCarotidBruits
                    .Add("@Cervical_LNs", SqlDbType.VarChar, 50).Value = sCervicalLNs
                    .Add("@Axillary_LNs", SqlDbType.VarChar, 50).Value = sAxillaryLNs

                    ''Organs
                    .Add("@HeartS1", SqlDbType.VarChar, 50).Value = sHeartS1
                    .Add("@HeartS2", SqlDbType.VarChar, 50).Value = sHeartS2
                    .Add("@HeartAddedSounds", SqlDbType.VarChar, 50).Value = sHeartAddedSounds
                    .Add("@HeartMurmers", SqlDbType.VarChar, 50).Value = sHeartMurmers
                    .Add("@ChestLeft", SqlDbType.VarChar, 50).Value = sChestLeft
                    .Add("@ChestRight", SqlDbType.VarChar, 50).Value = sChestRight
                    .Add("@AbdomenAAA", SqlDbType.VarChar, 50).Value = sAbdomenAAA
                    .Add("@AbdomenBowelSounds", SqlDbType.VarChar, 50).Value = sAbdomenBowelSounds
                    .Add("@AbdomenHernia", SqlDbType.VarChar, 50).Value = sAbdomenHernia
                    .Add("@AbdomenPR", SqlDbType.VarChar, 50).Value = sAbdomenPR
                    .Add("@Cranial2", SqlDbType.VarChar, 50).Value = sCranial2
                    .Add("@Cranial346", SqlDbType.VarChar, 50).Value = sCranial346
                    .Add("@Cranial5", SqlDbType.VarChar, 50).Value = sCranial5
                    .Add("@Cranial7", SqlDbType.VarChar, 50).Value = sCranial7
                    .Add("@Cranial8", SqlDbType.VarChar, 50).Value = sCranial8
                    .Add("@Cranial910", SqlDbType.VarChar, 50).Value = sCranial910
                    .Add("@Cranial11", SqlDbType.VarChar, 50).Value = sCranial11
                    .Add("@Cranial12", SqlDbType.VarChar, 50).Value = sCranial12

                    ''Limbs
                    .Add("RArmTone", SqlDbType.VarChar, 50).Value = sRArmTone
                    .Add("RArmPower", SqlDbType.VarChar, 50).Value = sRArmPower
                    .Add("RArmReflexes", SqlDbType.VarChar, 50).Value = sRArmReflexes
                    .Add("RArmCo", SqlDbType.VarChar, 50).Value = sRArmCo
                    .Add("RArmSensation", SqlDbType.VarChar, 50).Value = sRArmSensation
                    .Add("LArmTone", SqlDbType.VarChar, 50).Value = sLArmTone
                    .Add("LArmPower", SqlDbType.VarChar, 50).Value = sLArmPower
                    .Add("LArmReflexes", SqlDbType.VarChar, 50).Value = sLArmReflexes
                    .Add("LArmCo", SqlDbType.VarChar, 50).Value = sLArmCo
                    .Add("LArmSensation", SqlDbType.VarChar, 50).Value = sLArmSensation
                    .Add("RLegTone", SqlDbType.VarChar, 50).Value = sRLegTone
                    .Add("RLegPower", SqlDbType.VarChar, 50).Value = sRLegPower
                    .Add("RLegReflexes", SqlDbType.VarChar, 50).Value = sRLegReflexes
                    .Add("RLegCo", SqlDbType.VarChar, 50).Value = sRLegCo
                    .Add("RLegSensation", SqlDbType.VarChar, 50).Value = sRLegSensation
                    .Add("RLegPlantars", SqlDbType.VarChar, 50).Value = sRLegPlantars
                    .Add("LLegTone", SqlDbType.VarChar, 50).Value = sLLegTone
                    .Add("LLegPower", SqlDbType.VarChar, 50).Value = sLLegPower
                    .Add("LLegReflexes", SqlDbType.VarChar, 50).Value = sLLegReflexes
                    .Add("LLegCo", SqlDbType.VarChar, 50).Value = sLLegCo
                    .Add("LLegSensation", SqlDbType.VarChar, 50).Value = sLLegSensation
                    .Add("LLegPlantars", SqlDbType.VarChar, 50).Value = sLLegPlantars

                    ''Assesment

                    .Add("Legs", SqlDbType.VarChar, 50).Value = sLegs
                    .Add("PeripheralPulses", SqlDbType.VarChar, 50).Value = sPeripheralPulses
                    .Add("Gait", SqlDbType.VarChar, 50).Value = sGait
                    .Add("Back", SqlDbType.VarChar, 50).Value = sBack
                    .Add("Joints", SqlDbType.VarChar, 50).Value = sJoints
                    .Add("Skin", SqlDbType.VarChar, 50).Value = sSkin
                    .Add("Others", SqlDbType.VarChar, 50).Value = sOthers




                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
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
    ''Image Details
    Public Function AddImageDetails() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Update_Admission_ImageDetails"
                .CommandType = CommandType.StoredProcedure

                With .Parameters

                    If dgvImage.Rows(0).Cells(1).Value <> "" Then
                        sECG = dgvImage.Rows(0).Cells(1).Value
                    End If
                    If dgvImage.Rows(1).Cells(1).Value <> "" Then
                        sCXR = dgvImage.Rows(1).Cells(1).Value
                    End If
                    If dgvImage.Rows(2).Cells(1).Value <> "" Then
                        sMSU = dgvImage.Rows(2).Cells(1).Value
                    End If
                    If dgvImage.Rows(3).Cells(1).Value <> "" Then
                        sXRayOther = dgvImage.Rows(3).Cells(1).Value
                    End If
                    If dgvImage.Rows(4).Cells(1).Value <> "" Then
                        sImageOther = dgvImage.Rows(4).Cells(1).Value
                    End If

                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                    .Add("@ECG", SqlDbType.VarChar, 50).Value = sECG
                    .Add("@CXR", SqlDbType.VarChar, 50).Value = sCXR
                    .Add("@MSU", SqlDbType.VarChar, 50).Value = sMSU
                    .Add("@XRayOther", SqlDbType.VarChar, 50).Value = sXRayOther
                    .Add("@ImageOther", SqlDbType.VarChar, 50).Value = sImageOther
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

    Public Function AddMedicPlan() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Update_Admission_Medic_Assesment"
                .CommandType = CommandType.StoredProcedure

                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                    .Add("@Medic", SqlDbType.VarChar, 50).Value = "Con"
                    .Add("@Assesment", SqlDbType.VarChar).Value = sConAssesment
                    .Add("@Impression", SqlDbType.VarChar).Value = sConImpression
                    .Add("@Plan", SqlDbType.VarChar).Value = sConPlan
                    .Add("@MedicName", SqlDbType.VarChar, 50).Value = sConName
                    .Add("@MedicID", SqlDbType.VarChar, 50).Value = sConID
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
    Public Function AddMedicPlan(Reg As String) As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Update_Admission_Medic_Assesment"
                .CommandType = CommandType.StoredProcedure

                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                    .Add("@Medic", SqlDbType.VarChar, 50).Value = Reg
                    .Add("@Assesment", SqlDbType.VarChar).Value = sRegAssesment
                    .Add("@Impression", SqlDbType.VarChar).Value = sRegImpression
                    .Add("@Plan", SqlDbType.VarChar).Value = sRegPlan
                    .Add("@MedicName", SqlDbType.VarChar, 50).Value = sRegName
                    .Add("@MedicID", SqlDbType.VarChar, 50).Value = sRegID
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
    Public Function AddDischargeMedication() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()

            'Delete Medication Details
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Delete_DischargeMedicationHistory"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar).Value = Symphony
                End With
                .ExecuteNonQuery()
            End With

            'Add DischargeMedication 
            Dim DMedCount As Integer
            For DMedCount = 0 To dgvdischargeMedication.Rows.Count - 1
                Dim myCommand1 As New SqlCommand

                With myCommand1
                    .Connection = myconnection
                    .CommandText = "Add_DischargeMedication"
                    .CommandType = CommandType.StoredProcedure

                    With .Parameters

                        With dgvdischargeMedication.Rows(DMedCount)
                            sDMedication_ID = .Cells(0).Value
                            sDMedicationName = .Cells(1).Value
                            sDMedicationDose = .Cells(2).Value
                            sDMedicationComment = .Cells(3).Value
                        End With
                        .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                        .Add("@AdmissionDate", SqlDbType.Date).Value = dAdmissionDate
                        .Add("@Name", SqlDbType.VarChar, 50).Value = sDMedicationName
                        .Add("@MedicationDose", SqlDbType.VarChar, 50).Value = sDMedicationDose
                        .Add("@Medication_Id", SqlDbType.VarChar, 50).Value = sDMedication_ID
                        .Add("@MedicationComment", SqlDbType.VarChar, 50).Value = sDMedicationComment
                    End With
                    .ExecuteNonQuery()
                End With
            Next
            Return True
        Catch ex As Exception
            If sMedicationDose = "" Then
                MessageBox.Show("Please Enter Medication Directions or N/A")
            Else
                Dim myMessage As New Message
                myMessage.ReportError("Record Not Added", ex)
            End If
            Return False
            'End If
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    Public Function AddProcedure() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Delete Medication Details
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "Delete_Admission_Procedure"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar).Value = Symphony
                End With
                .ExecuteNonQuery()
            End With

            'Add Procedures
            Dim Procedure As Integer = 0
            For Procedure = 0 To lvProcedureList.Items.Count - 1
                Dim myCommand3 As New SqlCommand
                With myCommand3
                    .Connection = myconnection
                    .CommandText = "Add_Admission_Procedure"
                    .CommandType = CommandType.StoredProcedure
                    With .Parameters
                        With lvProcedureList.Items(Procedure)
                            sProcedureID = .Text
                            sProcedure = .SubItems(1).Text
                        End With
                        .Add("@Procedure_ID", SqlDbType.VarChar, 50).Value = sProcedureID
                        .Add("@Procedure", SqlDbType.VarChar, 50).Value = sProcedure
                        .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                    End With
                    .ExecuteNonQuery()
                End With
            Next
            Return True
        Catch ex As Exception
            Dim myMessage As New Message
            myMessage.ReportError("Record Not Added", ex)

            Return False
            'End If
        Finally
            If Not myconnection Is Nothing Then
                If myconnection.State = ConnectionState.Open Then
                    myconnection.Close()

                End If
            End If
        End Try
    End Function
    ''Discharge
    Public Function CloseCurrentAdmission() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Delete Admission from Current Admission tables

            'Add Admission to Admisson_History tables

            Dim myCommand2 As New SqlCommand

            With myCommand2
                .Connection = myconnection
                .CommandText = "Update_Admssion_Patient_Status_OnDischarge"
                .CommandType = CommandType.StoredProcedure

                With .Parameters

                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                    .Add("@MRN", SqlDbType.VarChar, 50).Value = ID
                    .Add("@DischargeDate", SqlDbType.Date).Value = dDischargeDate
                    .Add("@Status", SqlDbType.VarChar, 50).Value = Status
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
    Public Function AddClinic() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()


            'Add Clinic to Clinic table

            Dim myCommand2 As New SqlCommand

            With myCommand2
                .Connection = myconnection
                .CommandText = "Add_ClinicAppointment"
                .CommandType = CommandType.StoredProcedure

                With .Parameters
                    .Add("@MRN", SqlDbType.VarChar, 50).Value = ID
                    .Add("@AppointmentDate", SqlDbType.Date).Value = dAppointmentDate
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
    '' Add Re-Admission Details
    Public Function Add_ReAdmission() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()


            'Add Clinic to Clinic table

            Dim myCommand2 As New SqlCommand

            With myCommand2
                .Connection = myconnection
                .CommandText = "Add_ReAdmission"
                .CommandType = CommandType.StoredProcedure

                With .Parameters
                    .Add("@MRN", SqlDbType.VarChar, 50).Value = ID
                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
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


    ''Find Details for FrmAdmisison

    Public Function findAdmissionView() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Search for Admission Details & PresentingComplaint
            Dim myCommand As New SqlCommand
            With myCommand
                .Connection = myconnection
                .CommandText = "Search_Admission_PresentingComplaint"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With
            Dim myDataReader As SqlDataReader = myCommand.ExecuteReader
            Dim PCCount As Integer = 0
            Dim cmbComplaint As New DataGridViewComboBoxColumn()
            cmbComplaint.HeaderText = "Presenting Complaint"
            cmbComplaint.Name = "Complaint"
            myMaster.findPCList(cmbComplaint)
            dgvPresentingComplaintList.Columns.Add(cmbComplaint)
            dgvPresentingComplaintList.Columns.Add("ComplaintHistory", "History of Presenting Complaint")
            While (myDataReader.Read())

                If IsDBNull(myDataReader.Item("AdmissionDate")) = False Then
                    dAdmissionDate = myDataReader.Item("AdmissionDate")
                    If IsDBNull(myDataReader.Item("AdmissionTime")) = False Then
                        tAdmissionTime = myDataReader.Item("AdmissionTime")
                    End If
                    sWard = myDataReader.Item("Ward")
                    sReferralReason = myDataReader.Item("ReferralReason")
                    sAdmittingDr = myDataReader.Item("AdmittingDr")
                    sMCRN = myDataReader.Item("MCRN")
                    sConsultant = myDataReader.Item("Consultant")
                    dReferralDate = myDataReader.Item("ReferralDate")
                    If IsDBNull(myDataReader.Item("ReferralTime")) = False Then
                        sReferralTime = myDataReader.Item("ReferralTime")
                    End If
                    dDateSeen = myDataReader.Item("DateSeen")
                    If IsDBNull(myDataReader.Item("SeenTime")) = False Then
                        tSeenTime = myDataReader.Item("SeenTime")
                    End If
                    sBleep = myDataReader.Item("Bleep")
                        If IsDBNull(myDataReader.Item("RegImpression")) = False Then
                            sRegImpression = myDataReader.Item("RegImpression")
                            sRegAssesment = myDataReader.Item("RegAssesment")
                            sRegPlan = myDataReader.Item("RegPlan")
                            sRegName = myDataReader.Item("RegName")
                            sRegID = myDataReader.Item("RegID")
                        End If
                        If IsDBNull(myDataReader.Item("ConImpression")) = False Then
                            sConImpression = myDataReader.Item("ConImpression")
                            sConAssesment = myDataReader.Item("ConAssesment")
                            sConPlan = myDataReader.Item("ConPlan")
                            sConName = myDataReader.Item("ConName")
                            sConID = myDataReader.Item("ConID")
                        End If
                        If IsDBNull(myDataReader.Item("ProgressSummary")) = False Then
                            sProgressSummary = myDataReader.Item("ProgressSummary")
                        End If
                    Else MessageBox.Show("Please Ensure an Admission Date is Entered")

                End If

                    If IsDBNull(myDataReader.Item("PC")) = False Then
                    dgvPresentingComplaintList.Rows.Add()
                    dgvPresentingComplaintList.Rows(PCCount).Cells(0).Value = myDataReader.Item("PC")
                    If IsDBNull(myDataReader.Item("PCHistory")) = False Then
                        dgvPresentingComplaintList.Rows(PCCount).Cells(1).Value = myDataReader.Item("PCHistory")
                    End If
                    PCCount = PCCount + 1
                End If
            End While
            myDataReader.Close()
            'Search for Medications
            Dim myCommand1 As New SqlCommand
            With myCommand1
                .Connection = myconnection
                .CommandText = "Search_Admission_Medication"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With
            Dim rowCount As Integer = 0
            dgvMedication.Columns.Add("MedID", "ID")
            dgvMedication.Columns.Add("MedName", "Medication Name")
            dgvMedication.Columns.Add("MedFrequency", "Frequency")
            dgvMedication.Columns.Add("MedComment", "Comment")
            ''Add to Discharge List
            dgvdischargeMeds.Columns.Add("MedID", "ID")
            dgvdischargeMeds.Columns.Add("MedName", "Medication Name")
            dgvdischargeMeds.Columns.Add("MedFrequency", "Frequency")
            dgvdischargeMeds.Columns.Add("MedComment", "Comment")


            Dim myDataReader1 As SqlDataReader = myCommand1.ExecuteReader
            While (myDataReader1.Read())

                If IsDBNull(myDataReader1.Item("PreAdmMedSource")) = False Then
                    sPreAdmMedSource = myDataReader1.Item("PreAdmMedSource")
                    sPreAdmSourceName = myDataReader1.Item("PreAdmSourceName")
                    sPreAdmSourceTel = myDataReader1.Item("PreAdmSourceTel")
                    dPreAdmMedDate = myDataReader1.Item("PreAdmMedDate")

                End If

                If IsDBNull(myDataReader1.Item("Medication_Id")) = False Then
                    dgvMedication.Rows.Add()
                    dgvMedication.Rows(rowCount).Cells(0).Value = myDataReader1.Item("Medication_Id")
                    dgvMedication.Rows(rowCount).Cells(1).Value = myDataReader1.Item("MedicationName")
                    dgvMedication.Rows(rowCount).Cells(2).Value = myDataReader1.Item("Dose")
                    If IsDBNull(myDataReader1.Item("MedicationComment")) = False Then
                        dgvMedication.Rows(rowCount).Cells(3).Value = myDataReader1.Item("MedicationComment")
                    End If
                    ''Add to Discharge Med List
                    dgvdischargeMeds.Rows.Add()
                    dgvdischargeMeds.Rows(rowCount).Cells(0).Value = myDataReader1.Item("Medication_Id")
                    dgvdischargeMeds.Rows(rowCount).Cells(1).Value = myDataReader1.Item("MedicationName")
                    dgvdischargeMeds.Rows(rowCount).Cells(2).Value = myDataReader1.Item("Dose")
                    If IsDBNull(myDataReader1.Item("MedicationComment")) = False Then
                        dgvdischargeMeds.Rows(rowCount).Cells(3).Value = myDataReader1.Item("MedicationComment")
                    End If
                    rowCount = rowCount + 1

                End If
            End While
            myDataReader1.Close()
            'Search for Diagnosis
            Dim myCommand2 As New SqlCommand
            With myCommand2
                .Connection = myconnection
                .CommandText = "Search_Admission_Diagnosis"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With

            Dim DiagnosisCount As Integer = 0
            dgvDiagnosis.Columns.Add("DiagnosisID", "ID")
            dgvDiagnosis.Columns.Add("Diagnosis", "Diagnosis")
            dgvDiagnosis.Columns.Add("DiagnosisPlan", "Plan")
            ''Add to Discharge List
            dgvDischargeDiagnosis.Columns.Add("DischargeDiagnosisID", "ID")
            dgvDischargeDiagnosis.Columns.Add("DischargeDiagnosis", "Diagnosis")
            dgvDischargeDiagnosis.Columns.Add("DiscDiagnosisPlan", "Course")

            Dim myDataReader2 As SqlDataReader = myCommand2.ExecuteReader
            While (myDataReader2.Read())

                If IsDBNull(myDataReader2.Item("Diagnosis_Id")) = False Then
                    dgvDiagnosis.Rows.Add()
                    dgvDiagnosis.Rows(DiagnosisCount).Cells(0).Value = myDataReader2.Item("Diagnosis_Id")
                    dgvDiagnosis.Rows(DiagnosisCount).Cells(1).Value = myDataReader2.Item("Diagnosis")
                    If IsDBNull(myDataReader2.Item("Diagnosis")) = False Then
                        dgvDiagnosis.Rows(DiagnosisCount).Cells(2).Value = myDataReader2.Item("DiagnosisPlan")
                    End If
                    ''Add to Discharge Med List
                    dgvDischargeDiagnosis.Rows.Add()
                    dgvDischargeDiagnosis.Rows(DiagnosisCount).Cells(0).Value = myDataReader2.Item("Diagnosis_Id")
                    dgvDischargeDiagnosis.Rows(DiagnosisCount).Cells(1).Value = myDataReader2.Item("Diagnosis")
                    If IsDBNull(myDataReader2.Item("DiagnosisPlan")) = False Then
                        dgvDischargeDiagnosis.Rows(DiagnosisCount).Cells(2).Value = myDataReader2.Item("DiagnosisPlan")
                    End If
                    DiagnosisCount = DiagnosisCount + 1
                End If

            End While
            myDataReader2.Close()
            'Search for Labs
            Dim myCommand3 As New SqlCommand
            With myCommand3
                .Connection = myconnection
                .CommandText = "Search_Admission_Labs"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With
            Dim myDataReader3 As SqlDataReader = myCommand3.ExecuteReader
            Dim LabTest As String = ""
            Dim LabDate As String = ""
            Dim LabResult As String = ""
            Dim LabRow As Integer = 0
            Dim LabColumn As Integer = 1
            Dim LabDateCheck As String = ""
            While (myDataReader3.Read())
                If IsDBNull(myDataReader3.Item("LabTest")) = False Then

                    LabTest = myDataReader3.Item("LabTest")

                    If IsDBNull(myDataReader3.Item("Date")) = False Then
                        LabDate = myDataReader3.Item("Date")
                    End If

                    If IsDBNull(myDataReader3.Item("LabResult")) = False Then
                        LabResult = myDataReader3.Item("LabResult")
                    Else LabResult = "No Result"
                    End If
                    Select Case LabDateCheck

                        Case Is = ""
                            LabDateCheck = LabDate
                            dgLab.Columns.Add("LabHeading", "Test")
                            dgLab.Columns.Add("LabDate", "Results")
                            dgLab.Rows.Add()
                            dgLab.Rows(0).Cells(0).Value = "Date"
                            dgLab.Rows(0).Cells(LabColumn).Value = LabDate
                            LabRow = LabRow + 1
                            If (LabTest <> "" And LabColumn = 1) Then
                                dgLab.Rows.Add()
                                dgLab.Rows(LabRow).Cells(0).Value = LabTest
                                dgLab.Rows(LabRow).Cells(LabColumn).Value = LabResult
                            End If

                            LabRow = LabRow + 1
                        Case Is = LabDate
                            If (LabTest <> "" And LabColumn = 1) Then
                                dgLab.Rows.Add()
                            End If
                            dgLab.Rows(LabRow).Cells(0).Value = LabTest
                            dgLab.Rows(LabRow).Cells(LabColumn).Value = LabResult
                            LabRow = LabRow + 1
                        Case Is <> LabDate
                            If LabTest <> "" Then
                                LabRow = 1
                                LabDateCheck = LabDate
                            End If
                            dgLab.Columns.Add("LabDate", "")

                            ' dgLab.Columns.Add("LabDate" & LabColumn, "Results")
                            LabColumn = LabColumn + 1
                            dgLab.Rows(0).Cells(LabColumn).Value = LabDate
                            dgLab.Rows(LabRow).Cells(0).Value = LabTest
                            dgLab.Rows(LabRow).Cells(LabColumn).Value = LabResult
                            LabRow = LabRow + 1
                    End Select
                End If
            End While
            myDataReader3.Close()
            'Search for Progress Notes
            Dim myCommand4 As New SqlCommand
            With myCommand4
                .Connection = myconnection
                .CommandText = "Search_Admission_Progress"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With
            Dim myDataReader4 As SqlDataReader = myCommand4.ExecuteReader
            Dim ProgressCount As Integer = 0
            dgvProgressGrid.Columns.Add("ProgressDate", "Date")
            dgvProgressGrid.Columns.Add("ProgressNote", "Progress")

            dgvProgressGrid.Columns(0).DefaultCellStyle.Format = "dd/MM/yyyy"

            While (myDataReader4.Read())

                If IsDBNull(myDataReader4.Item("Date")) = False Then
                    dgvProgressGrid.Rows.Add()
                    dgvProgressGrid.Rows(ProgressCount).Cells(0).Value = myDataReader4.Item("Date")
                    If IsDBNull(myDataReader4.Item("Progress")) = False Then
                        dgvProgressGrid.Rows(ProgressCount).Cells(1).Value = myDataReader4.Item("Progress")
                    End If
                    ProgressCount = ProgressCount + 1
                End If
            End While
            myDataReader4.Close()
            ''Search for Physical Examination

            Dim myCommand5 As New SqlCommand
            With myCommand5
                .Connection = myconnection
                .CommandText = "Search_Admission_PhysicalExam"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With
            ''Vitals DataGrid
            dgvVitals.Columns.Add("Vitals", "Vitals")
            dgvVitals.Columns.Add("vitalFinding", "Finding")
            dgvVitals.Rows.Add(11)
            dgvVitals.Rows(0).Cells(0).Value = "Temperature"
            dgvVitals.Rows(1).Cells(0).Value = "Heart Rate"
            dgvVitals.Rows(2).Cells(0).Value = "BP(Lying)"
            dgvVitals.Rows(3).Cells(0).Value = "BP(Standing)"
            dgvVitals.Rows(4).Cells(0).Value = "Resp.Rate"
            dgvVitals.Rows(5).Cells(0).Value = "O2 Sats"
            dgvVitals.Rows(6).Cells(0).Value = "GCS"
            dgvVitals.Rows(7).Cells(0).Value = "4AT"
            dgvVitals.Rows(8).Cells(0).Value = "Orientation-Time"
            dgvVitals.Rows(9).Cells(0).Value = "Orientation-Person"
            dgvVitals.Rows(10).Cells(0).Value = "Orientation-Place"

            ''PhysicalSigns DataGrid
            dgvPhysicalSigns.Columns.Add("physicalSign", "Physical Sign")
            dgvPhysicalSigns.Columns.Add("physicalFinding", "Finding")
            dgvPhysicalSigns.Rows.Add(8)
            dgvPhysicalSigns.Rows(0).Cells(0).Value = "Hands&Nails"
            dgvPhysicalSigns.Rows(1).Cells(0).Value = "Eyes"
            dgvPhysicalSigns.Rows(2).Cells(0).Value = "ENT"
            dgvPhysicalSigns.Rows(3).Cells(0).Value = "Breasts"
            dgvPhysicalSigns.Rows(4).Cells(0).Value = "JVP"
            dgvPhysicalSigns.Rows(5).Cells(0).Value = "Carotid Bruits"
            dgvPhysicalSigns.Rows(6).Cells(0).Value = "Cervical LNs"
            dgvPhysicalSigns.Rows(7).Cells(0).Value = "Axillary LNs"
            ''Organs Datagrid
            dgvOrgans.Columns.Add("Organ", "Organ")
            dgvOrgans.Columns.Add("organFinding", "Finding")
            dgvOrgans.Rows.Add(18)
            dgvOrgans.Rows(0).Cells(0).Value = "HeartS1"
            dgvOrgans.Rows(1).Cells(0).Value = "HeartS2"
            dgvOrgans.Rows(2).Cells(0).Value = "Heart Added Sounds"
            dgvOrgans.Rows(3).Cells(0).Value = "Heart Murmers"
            dgvOrgans.Rows(4).Cells(0).Value = "Chest Left"
            dgvOrgans.Rows(5).Cells(0).Value = "Chest Right"
            dgvOrgans.Rows(6).Cells(0).Value = "Abdomen AAA"
            dgvOrgans.Rows(7).Cells(0).Value = "Abdomen Bowel Sounds"
            dgvOrgans.Rows(8).Cells(0).Value = "Abdomen Hernia"
            dgvOrgans.Rows(9).Cells(0).Value = "Abdomen PR"
            dgvOrgans.Rows(10).Cells(0).Value = "Cranial 2"
            dgvOrgans.Rows(11).Cells(0).Value = "Cranial 3 4 6"
            dgvOrgans.Rows(12).Cells(0).Value = "Cranial 5"
            dgvOrgans.Rows(13).Cells(0).Value = "Cranial 7"
            dgvOrgans.Rows(14).Cells(0).Value = "Cranial 8"
            dgvOrgans.Rows(15).Cells(0).Value = "Cranial 9 10"
            dgvOrgans.Rows(16).Cells(0).Value = "Cranial 11"
            dgvOrgans.Rows(17).Cells(0).Value = "Cranial 12"

            ''Add Limbs
            dgvLimbs.Columns.Add("Blank", "")
            dgvLimbs.Columns.Add("RightArm", "Right Arm")
            dgvLimbs.Columns.Add("LeftArm", "Left Arm")
            dgvLimbs.Columns.Add("RightLeg", "Right Leg")
            dgvLimbs.Columns.Add("LeftLeg", "Left Leg")
            dgvLimbs.Rows.Add(6)
            dgvLimbs.Rows(0).Cells(0).Value = "Tone"
            dgvLimbs.Rows(1).Cells(0).Value = "Power"
            dgvLimbs.Rows(2).Cells(0).Value = "Reflexes"
            dgvLimbs.Rows(3).Cells(0).Value = "Co-Ordination"
            dgvLimbs.Rows(4).Cells(0).Value = "Sensation"
            dgvLimbs.Rows(5).Cells(0).Value = "Plantars"

            ''Add Assesment
            dgvAssesment.Columns.Add("Area", "Area")
            dgvAssesment.Columns.Add("Assesment", "Assesment")
            dgvAssesment.Rows.Add(7)
            dgvAssesment.Rows(0).Cells(0).Value = "Legs"
            dgvAssesment.Rows(1).Cells(0).Value = "Peripheral Pulses"
            dgvAssesment.Rows(2).Cells(0).Value = "Gait"
            dgvAssesment.Rows(3).Cells(0).Value = "Back"
            dgvAssesment.Rows(4).Cells(0).Value = "Joints"
            dgvAssesment.Rows(5).Cells(0).Value = "Skin"
            dgvAssesment.Rows(6).Cells(0).Value = "Others"




            Dim myDataReader5 As SqlDataReader = myCommand5.ExecuteReader
            While (myDataReader5.Read())

                ''Add Radiobuttons
                If IsDBNull(myDataReader5.Item("Condition")) = False Then
                    sCondition = myDataReader5.Item("Condition")
                End If
                If IsDBNull(myDataReader5.Item("Fluid")) = False Then
                    sFluid = myDataReader5.Item("Fluid")
                End If
                ''Add Vitals-Datagrid

                If IsDBNull(myDataReader5.Item("Temperature")) = False Then

                    dgvVitals.Rows(0).Cells(1).Value = myDataReader5.Item("Temperature")
                End If
                If IsDBNull(myDataReader5.Item("HeartRate")) = False Then
                        dgvVitals.Rows(1).Cells(1).Value = myDataReader5.Item("HeartRate")
                    End If
                    If IsDBNull(myDataReader5.Item("BP(Lying)")) = False Then
                        dgvVitals.Rows(2).Cells(1).Value = myDataReader5.Item("BP(Lying)")
                    End If
                    If IsDBNull(myDataReader5.Item("BP(Standing)")) = False Then
                        dgvVitals.Rows(3).Cells(1).Value = myDataReader5.Item("BP(Standing)")
                    End If
                    If IsDBNull(myDataReader5.Item("RespRate")) = False Then
                        dgvVitals.Rows(4).Cells(1).Value = myDataReader5.Item("RespRate")
                    End If
                    If IsDBNull(myDataReader5.Item("O2Sats")) = False Then
                        dgvVitals.Rows(5).Cells(1).Value = myDataReader5.Item("O2Sats")
                    End If

                    If IsDBNull(myDataReader5.Item("GCS")) = False Then
                        dgvVitals.Rows(6).Cells(1).Value = myDataReader5.Item("GCS")
                    End If
                    If IsDBNull(myDataReader5.Item("4AT")) = False Then
                        dgvVitals.Rows(7).Cells(1).Value = myDataReader5.Item("4AT")
                    End If
                    If IsDBNull(myDataReader5.Item("oTime")) = False Then
                        dgvVitals.Rows(8).Cells(1).Value = myDataReader5.Item("oTime")
                    End If
                    If IsDBNull(myDataReader5.Item("oPerson")) = False Then
                        dgvVitals.Rows(9).Cells(1).Value = myDataReader5.Item("oPerson")
                    End If
                    If IsDBNull(myDataReader5.Item("oPlace")) = False Then
                        dgvVitals.Rows(10).Cells(1).Value = myDataReader5.Item("oPlace")
                    End If


                    'Add Physical Signs-Datagrid

                    If IsDBNull(myDataReader5.Item("Hands_Nails")) = False Then

                    dgvPhysicalSigns.Rows(0).Cells(1).Value = myDataReader5.Item("Hands_Nails")
                End If
                If IsDBNull(myDataReader5.Item("Eyes")) = False Then
                        dgvPhysicalSigns.Rows(1).Cells(1).Value = myDataReader5.Item("Eyes")
                    End If
                    If IsDBNull(myDataReader5.Item("ENT")) = False Then
                        dgvPhysicalSigns.Rows(2).Cells(1).Value = myDataReader5.Item("ENT")
                    End If
                    If IsDBNull(myDataReader5.Item("Breasts")) = False Then
                        dgvPhysicalSigns.Rows(3).Cells(1).Value = myDataReader5.Item("Breasts")
                    End If
                    If IsDBNull(myDataReader5.Item("JVP")) = False Then
                        dgvPhysicalSigns.Rows(4).Cells(1).Value = myDataReader5.Item("JVP")
                    End If
                    If IsDBNull(myDataReader5.Item("CarotidBruits")) = False Then
                        dgvPhysicalSigns.Rows(5).Cells(1).Value = myDataReader5.Item("CarotidBruits")
                    End If

                    If IsDBNull(myDataReader5.Item("CervicalLNs")) = False Then
                        dgvPhysicalSigns.Rows(6).Cells(1).Value = myDataReader5.Item("CervicalLNs")
                    End If

                    If IsDBNull(myDataReader5.Item("AxillaryLNs")) = False Then
                        dgvPhysicalSigns.Rows(7).Cells(1).Value = myDataReader5.Item("AxillaryLNs")
                    End If


                ''Add Organs
                If IsDBNull(myDataReader5.Item("HeartS1")) = False Then

                    dgvOrgans.Rows(0).Cells(1).Value = myDataReader5.Item("HeartS1")
                End If

                If IsDBNull(myDataReader5.Item("HeartS2")) = False Then
                        dgvOrgans.Rows(1).Cells(1).Value = myDataReader5.Item("HeartS2")
                    End If
                    If IsDBNull(myDataReader5.Item("HeartAddedSounds")) = False Then
                        dgvOrgans.Rows(2).Cells(1).Value = myDataReader5.Item("HeartAddedSounds")
                    End If
                    If IsDBNull(myDataReader5.Item("HeartMurmers")) = False Then
                        dgvOrgans.Rows(3).Cells(1).Value = myDataReader5.Item("HeartMurmers")
                    End If
                    If IsDBNull(myDataReader5.Item("ChestLeft")) = False Then
                        dgvOrgans.Rows(4).Cells(1).Value = myDataReader5.Item("ChestLeft")
                    End If
                    If IsDBNull(myDataReader5.Item("ChestRight")) = False Then
                        dgvOrgans.Rows(5).Cells(1).Value = myDataReader5.Item("ChestRight")
                    End If

                    If IsDBNull(myDataReader5.Item("AbdomenAAA")) = False Then
                        dgvOrgans.Rows(6).Cells(1).Value = myDataReader5.Item("AbdomenAAA")
                    End If

                    If IsDBNull(myDataReader5.Item("AbdomenBowelSounds")) = False Then
                        dgvOrgans.Rows(7).Cells(1).Value = myDataReader5.Item("AbdomenBowelSounds")
                    End If
                    If IsDBNull(myDataReader5.Item("AbdomenHernia")) = False Then
                        dgvOrgans.Rows(8).Cells(1).Value = myDataReader5.Item("AbdomenHernia")
                    End If

                    If IsDBNull(myDataReader5.Item("AbdomenPR")) = False Then
                        dgvOrgans.Rows(9).Cells(1).Value = myDataReader5.Item("AbdomenPR")
                    End If
                    If IsDBNull(myDataReader5.Item("Cranial2")) = False Then
                        dgvOrgans.Rows(10).Cells(1).Value = myDataReader5.Item("Cranial2")
                    End If
                    If IsDBNull(myDataReader5.Item("Cranial346")) = False Then
                        dgvOrgans.Rows(11).Cells(1).Value = myDataReader5.Item("Cranial346")
                    End If
                    If IsDBNull(myDataReader5.Item("Cranial5")) = False Then
                        dgvOrgans.Rows(12).Cells(1).Value = myDataReader5.Item("Cranial5")
                    End If
                    If IsDBNull(myDataReader5.Item("Cranial7")) = False Then
                        dgvOrgans.Rows(13).Cells(1).Value = myDataReader5.Item("Cranial7")
                    End If
                    If IsDBNull(myDataReader5.Item("Cranial8")) = False Then
                        dgvOrgans.Rows(14).Cells(1).Value = myDataReader5.Item("Cranial8")
                    End If
                    If IsDBNull(myDataReader5.Item("Cranial910")) = False Then
                        dgvOrgans.Rows(15).Cells(1).Value = myDataReader5.Item("Cranial910")
                    End If
                    If IsDBNull(myDataReader5.Item("Cranial11")) = False Then
                        dgvOrgans.Rows(16).Cells(1).Value = myDataReader5.Item("Cranial11")
                    End If
                If IsDBNull(myDataReader5.Item("Cranial12")) = False Then
                    dgvOrgans.Rows(17).Cells(1).Value = myDataReader5.Item("Cranial12")
                End If

                'Add Limbs
                If IsDBNull(myDataReader5.Item("RArmTone")) = False Then

                    dgvLimbs.Rows(0).Cells(1).Value = myDataReader5.Item("RArmTone")
                End If

                If IsDBNull(myDataReader5.Item("RArmPower")) = False Then
                    dgvLimbs.Rows(1).Cells(1).Value = myDataReader5.Item("RArmPower")
                End If
                If IsDBNull(myDataReader5.Item("RArmReflexes")) = False Then
                    dgvLimbs.Rows(2).Cells(1).Value = myDataReader5.Item("RArmReflexes")
                End If
                If IsDBNull(myDataReader5.Item("RArmCo")) = False Then
                    dgvLimbs.Rows(3).Cells(1).Value = myDataReader5.Item("RArmCo")
                End If
                If IsDBNull(myDataReader5.Item("RArmSensation")) = False Then
                    dgvLimbs.Rows(4).Cells(1).Value = myDataReader5.Item("RArmSensation")
                End If

                dgvLimbs.Rows(5).Cells(1).Value = "N/A"


                If IsDBNull(myDataReader5.Item("LArmTone")) = False Then
                    dgvLimbs.Rows(0).Cells(2).Value = myDataReader5.Item("LArmTone")
                End If

                If IsDBNull(myDataReader5.Item("LArmPower")) = False Then
                    dgvLimbs.Rows(1).Cells(2).Value = myDataReader5.Item("LArmPower")
                End If
                If IsDBNull(myDataReader5.Item("LArmReflexes")) = False Then
                    dgvLimbs.Rows(2).Cells(2).Value = myDataReader5.Item("LArmReflexes")
                End If

                If IsDBNull(myDataReader5.Item("LArmCo")) = False Then
                    dgvLimbs.Rows(3).Cells(2).Value = myDataReader5.Item("LArmCo")
                End If
                If IsDBNull(myDataReader5.Item("LArmSensation")) = False Then
                    dgvLimbs.Rows(4).Cells(2).Value = myDataReader5.Item("LArmSensation")
                End If

                dgvLimbs.Rows(5).Cells(2).Value = "N/A"

                If IsDBNull(myDataReader5.Item("RLegTone")) = False Then
                    dgvLimbs.Rows(0).Cells(3).Value = myDataReader5.Item("RLegTone")
                End If
                If IsDBNull(myDataReader5.Item("RlegPower")) = False Then
                    dgvLimbs.Rows(1).Cells(3).Value = myDataReader5.Item("RLegPower")
                End If
                If IsDBNull(myDataReader5.Item("RLegReflexes")) = False Then
                    dgvLimbs.Rows(2).Cells(3).Value = myDataReader5.Item("RLegReflexes")
                End If
                If IsDBNull(myDataReader5.Item("RLegCo")) = False Then
                    dgvLimbs.Rows(3).Cells(3).Value = myDataReader5.Item("RLegCo")
                End If
                If IsDBNull(myDataReader5.Item("RLegSensation")) = False Then
                    dgvLimbs.Rows(4).Cells(3).Value = myDataReader5.Item("RLegSensation")
                End If
                If IsDBNull(myDataReader5.Item("RLegPlantars")) = False Then
                    dgvLimbs.Rows(5).Cells(3).Value = myDataReader5.Item("RLegPlantars")
                End If
                If IsDBNull(myDataReader5.Item("LLegTone")) = False Then
                        dgvLimbs.Rows(0).Cells(4).Value = myDataReader5.Item("LLegTone")
                    End If
                    If IsDBNull(myDataReader5.Item("LlegPower")) = False Then
                        dgvLimbs.Rows(1).Cells(4).Value = myDataReader5.Item("LLegPower")
                    End If
                    If IsDBNull(myDataReader5.Item("LLegReflexes")) = False Then
                        dgvLimbs.Rows(2).Cells(4).Value = myDataReader5.Item("LLegReflexes")
                    End If
                    If IsDBNull(myDataReader5.Item("LLegCo")) = False Then
                        dgvLimbs.Rows(3).Cells(4).Value = myDataReader5.Item("LLegCo")
                    End If
                    If IsDBNull(myDataReader5.Item("LLegSensation")) = False Then
                        dgvLimbs.Rows(4).Cells(4).Value = myDataReader5.Item("LLegSensation")
                    End If
                    If IsDBNull(myDataReader5.Item("LLegPlantars")) = False Then
                        dgvLimbs.Rows(5).Cells(4).Value = myDataReader5.Item("LLegPlantars")
                    End If
                ''Add Assesment
                If IsDBNull(myDataReader5.Item("Legs")) = False Then
                    dgvAssesment.Rows(0).Cells(1).Value = myDataReader5.Item("Legs")
                End If
                If IsDBNull(myDataReader5.Item("PeripheralPulses")) = False Then
                    dgvAssesment.Rows(1).Cells(1).Value = myDataReader5.Item("PeripheralPulses")
                End If
                If IsDBNull(myDataReader5.Item("Gait")) = False Then
                    dgvAssesment.Rows(2).Cells(1).Value = myDataReader5.Item("Gait")
                End If
                If IsDBNull(myDataReader5.Item("Back")) = False Then
                    dgvAssesment.Rows(3).Cells(1).Value = myDataReader5.Item("Back")
                End If
                If IsDBNull(myDataReader5.Item("Joints")) = False Then
                    dgvAssesment.Rows(4).Cells(1).Value = myDataReader5.Item("Joints")
                End If

                If IsDBNull(myDataReader5.Item("Skin")) = False Then
                    dgvAssesment.Rows(5).Cells(1).Value = myDataReader5.Item("Skin")
                End If

                If IsDBNull(myDataReader5.Item("Others")) = False Then
                    dgvAssesment.Rows(6).Cells(1).Value = myDataReader5.Item("Others")
                End If

            End While
            myDataReader5.Close()
            ''Image Results
            Dim myCommand6 As New SqlCommand
            With myCommand6
                .Connection = myconnection
                .CommandText = "Search_Admission_Image"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With
            Dim myDataReader6 As SqlDataReader = myCommand6.ExecuteReader

            dgvImage.Columns.Add("Image", "Image")
            dgvImage.Columns.Add("ImageDetais", "Image Details")
            dgvImage.Rows.Add(5)
            dgvImage.Rows(0).Cells(0).Value = "ECG"
            dgvImage.Rows(1).Cells(0).Value = "CXR"
            dgvImage.Rows(2).Cells(0).Value = "MSU"
            dgvImage.Rows(3).Cells(0).Value = "XRay Other"
            dgvImage.Rows(4).Cells(0).Value = "Image Other"
            While (myDataReader6.Read())
                If IsDBNull(myDataReader6.Item("ECG")) = False Then
                dgvImage.Rows(0).Cells(1).Value = myDataReader6.Item("ECG")
            End If
            If IsDBNull(myDataReader6.Item("CXR")) = False Then
                    dgvImage.Rows(1).Cells(1).Value = myDataReader6.Item("CXR")
                End If
            If IsDBNull(myDataReader6.Item("MSU")) = False Then
                dgvImage.Rows(2).Cells(1).Value = myDataReader6.Item("MSU")
            End If
            If IsDBNull(myDataReader6.Item("XRayOther")) = False Then
                    dgvImage.Rows(3).Cells(1).Value = myDataReader6.Item("XRayOther")
                End If
                If IsDBNull(myDataReader6.Item("ImageOther")) = False Then
                    dgvImage.Rows(4).Cells(1).Value = myDataReader6.Item("ImageOther")
                End If
            End While
            myDataReader6.Close()
            'Search for DischargeMedications
            Dim myCommand10 As New SqlCommand
            With myCommand10
                .Connection = myconnection
                .CommandText = "Search_DischargeMedication"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With
            Dim rowDCount As Integer = 0
            dgvDischargeMedication.Columns.Add("MedID", "ID")
            dgvDischargeMedication.Columns.Add("MedName", "Medication Name")
            dgvDischargeMedication.Columns.Add("MedFrequency", "Frequency")
            dgvDischargeMedication.Columns.Add("MedComment", "Comment")



            Dim myDataReader10 As SqlDataReader = myCommand10.ExecuteReader
            While (myDataReader10.Read())

                If IsDBNull(myDataReader10.Item("Medication_Id")) = False Then
                    dgvDischargeMedication.Rows.Add()
                    dgvDischargeMedication.Rows(rowDCount).Cells(0).Value = myDataReader10.Item("Medication_Id")
                    dgvDischargeMedication.Rows(rowDCount).Cells(1).Value = myDataReader10.Item("MedicationName")
                    dgvDischargeMedication.Rows(rowDCount).Cells(2).Value = myDataReader10.Item("Dose")
                    If IsDBNull(myDataReader10.Item("MedicationComment")) = False Then
                        dgvDischargeMedication.Rows(rowDCount).Cells(3).Value = myDataReader10.Item("MedicationComment")
                    End If
                    rowDCount = rowDCount + 1

                End If
            End While
            myDataReader10.Close()

            'Find Previous Admission Details

            'Find Previous Symphony Number & Progress Summary
            Dim myCommand7 As New SqlCommand
            With myCommand7
                .Connection = myconnection
                .CommandText = "Search_Admission_History"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@MRN", SqlDbType.VarChar, 50).Value = ID
            End With
            'Set up PreviousDiagnosis Datagrid View
            Dim PreviousDiagnosisCount As Integer = 0
            dgvPreviousDiagnosis.Columns.Add("Diagnosis", "Diagnosis")
            dgvPreviousDiagnosis.Columns.Add("DiagnosisPlan", "Plan")
            'Set up Previous Medication
            Dim PreviousMedication As Integer = 0
            dgvPreviousMedication.Columns.Add("MedicationName", "Medication Name")
            dgvPreviousMedication.Columns.Add("MedicationDose", "Dose")
            dgvPreviousMedication.Columns.Add("MedicationComment", "Comment")
            Dim myDataReader7 As SqlDataReader = myCommand7.ExecuteReader
            While (myDataReader7.Read())

                If IsDBNull(myDataReader7.Item("Symphony")) = False Then
                    sPreviousSymphony = myDataReader7.Item("Symphony")
                End If
                If IsDBNull(myDataReader7.Item("ProgressSummary")) = False Then
                    sPreviousProgress = myDataReader7.Item("ProgressSummary")
                End If
                If IsDBNull(myDataReader7.Item("AdmissionDate")) = False Then
                    dPreviousAdmissionDate = myDataReader7.Item("AdmissionDate")
                End If
                If IsDBNull(myDataReader7.Item("DischargeDate")) = False Then
                    dPreviousDischargeDate = myDataReader7.Item("DischargeDate")
                End If

                'Previous Diagnosis Datagrid
            End While
            myDataReader7.NextResult()
            While (myDataReader7.Read())
                If IsDBNull(myDataReader7.Item("Diagnosis")) = False Then
                    dgvPreviousDiagnosis.Rows.Add()
                    dgvPreviousDiagnosis.Rows(PreviousDiagnosisCount).Cells(0).Value = myDataReader7.Item("Diagnosis")
                    If IsDBNull(myDataReader7.Item("DiagnosisPlan")) = False Then
                        dgvPreviousDiagnosis.Rows(PreviousDiagnosisCount).Cells(1).Value = myDataReader7.Item("DiagnosisPlan")
                    End If
                    PreviousDiagnosisCount = PreviousDiagnosisCount + 1
                End If
            End While
            'Previous Medication Datagrid
            myDataReader7.NextResult()
            While (myDataReader7.Read())
                If IsDBNull(myDataReader7.Item("MedicationName")) = False Then
                    dgvPreviousMedication.Rows.Add()
                    dgvPreviousMedication.Rows(PreviousMedication).Cells(0).Value = myDataReader7.Item("MedicationName")
                    If IsDBNull(myDataReader7.Item("Dose")) = False Then
                        dgvPreviousMedication.Rows(PreviousMedication).Cells(1).Value = myDataReader7.Item("Dose")
                    End If
                    If IsDBNull(myDataReader7.Item("MedicationComment")) = False Then
                        dgvPreviousMedication.Rows(PreviousMedication).Cells(2).Value = myDataReader7.Item("MedicationComment")
                    End If
                    PreviousMedication = PreviousMedication + 1
                End If
            End While

            myDataReader7.Close()
            'Search for Procedure
            Dim myCommand8 As New SqlCommand
            With myCommand8
                .Connection = myconnection
                .CommandText = "Search_AdmissionProcedure"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
            End With
            Dim myDataReader8 As SqlDataReader = myCommand8.ExecuteReader
            While (myDataReader8.Read())
                If myDataReader8.Item("Procedure_ID") <> "" Then

                    Dim item1 As New ListViewItem
                    item1.Text = myDataReader8.Item("Procedure_ID")

                    item1.SubItems.Add(myDataReader8.Item("Procedure"))
                    lvProcedureList.Items.Add(item1)
                End If
            End While
            myDataReader8.Close()

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



    Public Function Update() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            'Update Medication Details in Medication Table & Delete Strengths from Strength Table
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "UpdateInPatient"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                    .Add("@Ward", SqlDbType.VarChar, 50).Value = sWard
                End With
                .ExecuteNonQuery()
                Return True
            End With

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
    Public Function Discharge() As Boolean
        Dim myconnection As SqlConnection = Nothing
        Try
            myconnection = New SqlConnection(sConnect)
            myconnection.Open()
            Dim myCommand As New SqlCommand

            With myCommand
                .Connection = myconnection
                .CommandText = "DischargePatient"
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Symphony", SqlDbType.VarChar, 50).Value = Symphony
                    .Add("@DischargeDate", SqlDbType.Date).Value = dDischargeDate
                    .Add("@Status", SqlDbType.VarChar, 50).Value = "Discharged"
                End With
                .ExecuteNonQuery()
                Return True
            End With

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


End Class
