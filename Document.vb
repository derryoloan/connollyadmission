Imports Microsoft.Office.Interop
Imports System.IO

Public Class Document
    Inherits Admission

    Private xlsx As Excel.Application = Nothing
    Private book As Excel.Workbook = Nothing
    Private books As Excel.Workbooks = Nothing
    Private sheet As Excel.Worksheet = Nothing
    Private sheets As Excel.Sheets = Nothing
    Private range As Excel.Range = Nothing
    Dim savefiledialog1 As New SaveFileDialog
    Private sMedSource As String
    Private sMedSourceName As String
    Private sTelephoneNumber As String
    Private dDispensedDate As Date
    Public Property MedSource As String
        Get
            Return sMedSource
        End Get
        Set(value As String)
            sMedSource = value
        End Set
    End Property
    Public Property MedSourceName As String
        Get
            Return sMedSourceName
        End Get
        Set(value As String)
            sMedSourceName = value
        End Set
    End Property
    Public Property TelephoneNumber As String
        Get
            Return sTelephoneNumber
        End Get
        Set(value As String)
            sTelephoneNumber = value
        End Set
    End Property
    Public Property DispensedDate As Date
        Get
            Return dDispensedDate
        End Get
        Set(value As Date)
            dDispensedDate = value
        End Set
    End Property
    Public Sub CreatePatientDoc()

        '' Set up Document

        Dim LineNumber As Integer = 1


        ''Excel
        '' Save to Excel
        savefiledialog1.Title = "Save Excel File"
        savefiledialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel files (*.xls)|*.xls"
        savefiledialog1.ShowDialog()
        'exit if no file selected
        If savefiledialog1.FileName = "" Then
            Exit Sub
        End If
        'create objects to interface to Excel

        'create a workbook and get reference to first worksheet
        CreateExcelObjects()
        ''The Document


        '' Set up Patient Details
        sheet.Cells(1, 1).value = "Patient Name"
        sheet.Cells(1, 2).value = Name

        sheet.Cells(1, 3).Value = "MRN:"
        sheet.Cells(1, 4).value = ID

        sheet.Cells(2, 1).value = "DOB:"
        sheet.Cells(2, 2).value = DOB
        'Line(3)
        LineNumber = LineNumber + 3
        sheet.Cells(4, 1).value = "Area"
        sheet.Cells(4, 2).value = Location
        'Line(2)
        LineNumber = LineNumber + 2
        sheet.Cells(6, 1).value = "Symphony ID:"
        sheet.Cells(6, 3).value = Symphony
        'Line(5)
        LineNumber = LineNumber + 5
        sheet.Cells(10, 1).value = "Medical/Surgical Conditions"
        sheet.Cells(10, 1).font.bold = True

        ''Set up Listview table for Past Medical and Surgical History

        sheet.Cells(11, 2).value = "Medical/Surgical ID"
        sheet.Cells(11, 3).value = "Medical/Surgical Condition"
        'Line (1)
        LineNumber = LineNumber + 1
        'Export Each Row Start
        For i As Integer = 0 To MedicalSurgicalList.Items.Count - 1

            sheet.Cells(i + LineNumber, 2).Value = MedicalSurgicalList.Items(i).Text
            sheet.Cells(i + LineNumber, 3).Value = MedicalSurgicalList.Items(i).SubItems(1).Text
        Next
        LineNumber = LineNumber + MedicalSurgicalList.Items.Count - 1

        '' Add Formatting

        range = sheet.Range(sheet.Cells(11, 2), sheet.Cells(LineNumber, 3))
        range.Font.Bold = True
        Dim border As Excel.Borders = range.Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 2.0
        ''Line(2)
        LineNumber = LineNumber + 2

        sheet.Cells(LineNumber, 1).value = "Family Risk Factors"
        sheet.Cells(LineNumber, 1).font.bold = True
        'Line(1)
        LineNumber = LineNumber + 1
        'set up Family Risk factors
        Dim columnsCountM As Integer = FamilyRiskList.Columns.Count
        For Each column In FamilyRiskList.Columns
            sheet.Cells(LineNumber, column.Index + 2).Value = column.HeaderText.ToString
        Next
        'Export Header Name End

        ' LineNumber(1)
        LineNumber = LineNumber + 1

        'Export Each Row Start
        For i As Integer = 0 To FamilyRiskList.Rows.Count - 1
            Dim columnIndexM As Integer = 0
            Do Until columnIndexM = columnsCountM
                If FamilyRiskList.Rows(i).Cells(1).Value <> "" Then
                    sheet.Cells(i + LineNumber, columnIndexM + 2).Value = FamilyRiskList.Rows(i).Cells(columnIndexM).Value
                End If
                columnIndexM = columnIndexM + 1
            Loop
        Next
        LineNumber = LineNumber - 1
        Dim endLineNumber As Integer = 1
        If FamilyRiskList.Rows.Count > 1 Then
            endLineNumber = LineNumber + FamilyRiskList.Rows.Count - 1
        Else
            endLineNumber = LineNumber + 1
        End If

        '' Add Formatting

        range = sheet.Range(sheet.Cells(LineNumber, 2), sheet.Cells(endLineNumber, columnsCountM + 1))
        range.Font.Bold = True
        Dim borderM As Excel.Borders = range.Borders
        borderM.LineStyle = Excel.XlLineStyle.xlContinuous
        borderM.Weight = 2.0
        LineNumber = LineNumber + FamilyRiskList.Rows.Count - 1
        MessageBox.Show(LineNumber)
        'Line(2)
        LineNumber = LineNumber + 2
        sheet.Cells(LineNumber, 1).value = "Patient Social Factors"
        sheet.Cells(LineNumber, 1).font.bold = True
        'Line(1)
        LineNumber = LineNumber + 1

        'set up Patient Social Factors
        Dim columnsCountS As Integer = SocialHistory.Columns.Count
        For Each column In SocialHistory.Columns
            sheet.Cells(LineNumber, column.Index + 2).Value = column.HeaderText.ToString
        Next
        'Export Header Name End

        ' LineNumber(1)
        LineNumber = LineNumber + 1

        'Export Each Row Start
        For s As Integer = 0 To SocialHistory.Rows.Count - 1
            Dim columnIndexS As Integer = 0
            Do Until columnIndexS = columnsCountS
                If SocialHistory.Rows(s).Cells(1).Value <> "" Then
                    sheet.Cells(s + LineNumber, columnIndexS + 2).Value = SocialHistory.Rows(s).Cells(columnIndexS).Value
                End If
                columnIndexS = columnIndexS + 1
            Loop
        Next

        Dim endLineNumberS As Integer = 1
        If SocialHistory.Rows.Count > 1 Then
            endLineNumber = LineNumber + SocialHistory.Rows.Count - 1
        Else
            endLineNumber = LineNumber + 1
        End If

        '' Add Formatting

        range = sheet.Range(sheet.Cells(LineNumber, 2), sheet.Cells(endLineNumber, columnsCountS + 1))
        range.Font.Bold = True
        Dim borderS As Excel.Borders = range.Borders
        borderS.LineStyle = Excel.XlLineStyle.xlContinuous
        borderS.Weight = 2.0
        LineNumber = LineNumber + SocialHistory.Rows.Count - 1
        MessageBox.Show(LineNumber)
        sheet.Columns("A:I").autofit()

        'save the workbook and clean up
        book.SaveAs(savefiledialog1.FileName)
        xlsx.Workbooks.Close()
        xlsx.Quit()
        CancelExcelObjects()

        savefiledialog1.FileName = ""
        MessageBox.Show("Patient Document Saved")



    End Sub

    Public Sub CreateAdmissionDoc()

        '' Set up Document

        Dim LineNumber As Integer = 1


        ''Excel
        '' Save to Excel
        savefiledialog1.Title = "Save Excel File"
        savefiledialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel files (*.xls)|*.xls"
        savefiledialog1.ShowDialog()
        'exit if no file selected
        If savefiledialog1.FileName = "" Then
            Exit Sub
        End If
        'create objects to interface to Excel & Reference to Workbook

        CreateExcelObjects()

        ''The Document


        '' Set up Patient Details
        sheet.Cells(1, 1) = "Patient Name:"
        sheet.Cells(1, 2) = Name

        sheet.Cells(1, 3) = "MRN:"
        sheet.Cells(1, 4) = ID

        'Line(1)
        LineNumber = LineNumber + 1

        sheet.Cells(LineNumber, 1) = "Consultant:"
        sheet.Cells(LineNumber, 2) = Consultant

        sheet.Cells(LineNumber, 3) = "Date of Admission:"
        sheet.Cells(LineNumber, 4) = AdmissionDate

        'Line(1)
        LineNumber = LineNumber + 1

        sheet.Cells(LineNumber, 1) = "Admitting Doctor:"
        sheet.Cells(LineNumber, 2) = AdmittingDr

        sheet.Cells(LineNumber, 3) = "Referral Date:"
        sheet.Cells(LineNumber, 4) = ReferralDate

        'Line(1)
        LineNumber = LineNumber + 1

        sheet.Cells(LineNumber, 1) = "MCRN:"
        sheet.Cells(LineNumber, 2) = MCRN

        sheet.Cells(LineNumber, 3) = "Date Seen:"
        sheet.Cells(LineNumber, 4) = DateSeen

        'Line(1)
        LineNumber = LineNumber + 1

        sheet.Cells(LineNumber, 1) = "Bleep:"
        sheet.Cells(LineNumber, 2) = Bleep

        sheet.Cells(LineNumber, 3) = "Referral Reason:"
        sheet.Cells(LineNumber, 4) = ReferralReason

        'Line(1)
        LineNumber = LineNumber + 1

        sheet.Cells(LineNumber, 2) = "Current Location"
        sheet.Cells(LineNumber, 3) = Ward

        'Line(2)
        LineNumber = LineNumber + 2


        sheet.Cells(LineNumber, 1) = "Presenting Complaint"
        sheet.Cells(LineNumber, 1).font.bold = True
        'Line(2)
        LineNumber = LineNumber + 2

        'set up Presenting Complaint

        Dim columnsCountPC As Integer = PresentingComplaintList.Columns.Count
        For Each column In PresentingComplaintList.Columns
            sheet.Cells(LineNumber, column.Index + 2).Value = column.HeaderText.ToString
        Next
        'Export Header Name End

        ' LineNumber(1)
        LineNumber = LineNumber + 1

        'Export Each Row Start
        For i As Integer = 0 To PresentingComplaintList.Rows.Count - 1
            Dim columnIndexPC As Integer = 0
            Do Until columnIndexPC = columnsCountPC
                If PresentingComplaintList.Rows(i).Cells(1).Value <> "" Then
                    sheet.Cells(i + LineNumber, columnIndexPC + 2).Value = PresentingComplaintList.Rows(i).Cells(columnIndexPC).Value

                End If
                columnIndexPC = columnIndexPC + 1
            Loop
        Next
        LineNumber = LineNumber - 1
        Dim endLineNumber As Integer = 1
        If PresentingComplaintList.Rows.Count > 1 Then
            endLineNumber = LineNumber + PresentingComplaintList.Rows.Count - 1
        Else
            endLineNumber = LineNumber + 1
        End If

        '' Add Formatting
        range = sheet.Range(sheet.Cells(LineNumber, 2), sheet.Cells(endLineNumber, columnsCountPC + 1))
        range.Font.Bold = True
        Dim borderM As Excel.Borders = range.Borders
        borderM.LineStyle = Excel.XlLineStyle.xlContinuous
        borderM.Weight = 2.0
        LineNumber = LineNumber + PresentingComplaintList.Rows.Count - 1

        'Line(2)
        LineNumber = LineNumber + 2
        'Add Relevant Risks Listbox


        sheet.Cells(LineNumber, 1).value = "Relevant Risk"
        sheet.Cells(LineNumber, 1).font.bold = True
        'Line (1)
        LineNumber = LineNumber + 1
        'Export Each Row Start
        'MessageBox.Show(RiskList.Items.Count)
        For RiskCount As Integer = 0 To RiskList.Items.Count - 1

            sheet.Cells(RiskCount + LineNumber, 2).Value = RiskList.Items(RiskCount)

        Next
        Dim endLineNumberRelR As Integer = 1
        If RiskList.Items.Count > 1 Then
            endLineNumberRelR = LineNumber + RiskList.Items.Count - 1
        Else
            endLineNumberRelR = LineNumber + 1
        End If




        '' Add Formatting
        range = sheet.Range(sheet.Cells(LineNumber, 2), sheet.Cells(endLineNumberRelR, 2))
        range.Font.Bold = True
        Dim border As Excel.Borders = range.Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 2.0
        LineNumber = LineNumber + RiskList.Items.Count - 1
        sheet.Columns("A:I").autofit()

        'Add New Page

        sheet.Rows(LineNumber + 5).PageBreak = 1

        'Add Diagnosis Details

        sheet.Cells(LineNumber + 6, 1) = "Diagnosis Details"
        'Add lines
        LineNumber = LineNumber + 7

        'Diagnosis Details Columns

        Dim columnsCountDD As Integer = DiagnosisGrid.Columns.Count
        For Each column In DiagnosisGrid.Columns
            sheet.Cells(LineNumber, column.Index + 2).Value = column.HeaderText.ToString
        Next
        'Export Header Name End

        ' LineNumber(1)
        LineNumber = LineNumber + 1

        'Export Each Row Start
        For i As Integer = 0 To DiagnosisGrid.Rows.Count - 1
            Dim columnIndexDD As Integer = 0
            Do Until columnIndexDD = columnsCountDD
                If DiagnosisGrid.Rows(i).Cells(1).Value <> "" Then
                    sheet.Cells(i + LineNumber, columnIndexDD + 2).Value = DiagnosisGrid.Rows(i).Cells(columnIndexDD).Value

                End If
                columnIndexDD = columnIndexDD + 1
            Loop
        Next
        LineNumber = LineNumber - 1
        endLineNumber = 1
        If DiagnosisGrid.Rows.Count > 1 Then
            endLineNumber = LineNumber + DiagnosisGrid.Rows.Count - 1
        Else
            endLineNumber = LineNumber + 1
        End If

        '' Add Formatting
        range = sheet.Range(sheet.Cells(LineNumber, 2), sheet.Cells(endLineNumber, columnsCountDD + 1))
        range.Font.Bold = True
        Dim borderD As Excel.Borders = range.Borders
        borderD.LineStyle = Excel.XlLineStyle.xlContinuous
        borderD.Weight = 2.0
        LineNumber = LineNumber + DiagnosisGrid.Rows.Count - 1
        'Add lines
        LineNumber = LineNumber + 3
        'Add Registrar Assesment

        sheet.Cells(LineNumber, 1) = "Registrar Assesment"
        'Lines
        LineNumber = LineNumber + 2

        sheet.Cells(LineNumber, 1) = "Assesment"
        'Line
        LineNumber = LineNumber + 1

        'Reg
        sheet.Cells(LineNumber, 2) = RegAssesment
        'Line
        LineNumber = LineNumber + 2

        sheet.Cells(LineNumber, 1) = "Impression"
        'Line
        LineNumber = LineNumber + 1

        'Reg
        sheet.Cells(LineNumber, 2) = RegImpression
        'Line
        LineNumber = LineNumber + 2

        sheet.Cells(LineNumber, 1) = "Plan"
        'Line
        LineNumber = LineNumber + 1

        'Reg
        sheet.Cells(LineNumber, 2) = RegPlan
        'Line
        LineNumber = LineNumber + 2

        sheet.Cells(LineNumber, 1) = "Registrar Name"
        sheet.Cells(LineNumber, 3) = "Registrar ID"

        'Reg
        sheet.Cells(LineNumber, 2) = RegName
        sheet.Cells(LineNumber, 4) = RegID
        'Line
        LineNumber = LineNumber + 3

        'Add Consultant Assesment

        sheet.Cells(LineNumber, 1) = "Consultant Assesment"
        'Lines
        LineNumber = LineNumber + 2

        sheet.Cells(LineNumber, 1) = "Assesment"
        'Line
        LineNumber = LineNumber + 1

        'Con
        sheet.Cells(LineNumber, 2) = ConAssesment
        'Line
        LineNumber = LineNumber + 2

        sheet.Cells(LineNumber, 1) = "Impression"
        'Line
        LineNumber = LineNumber + 1

        'Con
        sheet.Cells(LineNumber, 2) = ConImpression
        'Line
        LineNumber = LineNumber + 2

        'Con
        sheet.Cells(LineNumber, 1) = "Plan"
        'Line
        LineNumber = LineNumber + 1

        'Con
        sheet.Cells(LineNumber, 2) = ConPlan
        'Line
        LineNumber = LineNumber + 2

        sheet.Cells(LineNumber, 1) = "Consultant Name"
        sheet.Cells(LineNumber, 3) = "Consultant ID"

        'Con
        sheet.Cells(LineNumber, 2) = ConName
        sheet.Cells(LineNumber, 4) = ConID
        'Line


        'save the workbook and clean up
        book.SaveAs(savefiledialog1.FileName)
        xlsx.Workbooks.Close()
        xlsx.Quit()
        releaseObject(sheet)
        releaseObject(book)
        releaseObject(xlsx)
        savefiledialog1.FileName = ""
        MessageBox.Show("Patient Admission Document Saved")



    End Sub

    Public Sub CreateDischargeSummary()
        '' Set up Document




        ''Excel
        '' Save to Excel
        savefiledialog1.Title = "Save Excel File"
        savefiledialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel files (*.xls)|*.xls"
        savefiledialog1.ShowDialog()
        'exit if no file selected
        If savefiledialog1.FileName = "" Then
            Exit Sub
        End If
        'create objects to interface to Excel
        'create a workbook and get reference to first worksheet

        CreateExcelObjects()


        ''The Document


        '' Set up Patient Details
        sheet.Cells(1, 1).value = "Patient Name"
        sheet.Cells(1, 2).value = Name

        sheet.Cells(1, 4).Value = "MRN"
        sheet.Cells(1, 5).value = ID
        'Space
        Dim LineNumber As Integer = 2
        sheet.Cells(3, 1).value = "Symphony"
        sheet.Cells(3, 2).value = Symphony
        '2 Spaces
        sheet.Cells(5, 1).value = "Progress Summary"
        sheet.Cells(5, 2).value = ProgressSummary
        '2 Spaces
        LineNumber = LineNumber + 4
        sheet.Cells(7, 1) = "Diagnosis from Admission"
        '1Space
        LineNumber = LineNumber + 3
        ''Set up DataGridview for Diagnosis

        Dim columnsCount As Integer = DiagnosisGrid.Columns.Count
        For Each column In DiagnosisGrid.Columns
            sheet.Cells(9, column.Index + 2).Value = column.HeaderText.ToString
        Next
        'Export Header Name End
        LineNumber = LineNumber + 1
        'Export Each Row Start
        For i As Integer = 0 To DiagnosisGrid.Rows.Count - 1
            Dim columnIndex As Integer = 0
            Do Until columnIndex = columnsCount
                If DiagnosisGrid.Rows(i).Cells(1).Value <> "" Then
                    sheet.Cells(i + LineNumber, columnIndex + 2).Value = DiagnosisGrid.Rows(i).Cells(columnIndex).Value
                End If
                columnIndex = columnIndex + 1
            Loop
        Next
        LineNumber = LineNumber + DiagnosisGrid.Rows.Count - 1

        '' Add Formatting

        range = sheet.Range(sheet.Cells(9, 2), sheet.Cells(LineNumber - 1, columnsCount + 1))
        range.Font.Bold = True
        Dim border As Excel.Borders = range.Borders
        border.LineStyle = Excel.XlLineStyle.xlContinuous
        border.Weight = 2.0

        ''Set up Datagrid for Medication
        ' Add 2 spaces and title
        LineNumber = LineNumber + 2
        sheet.Cells(LineNumber, 1).Value = "Discharge Medication List"
        'Add Space
        LineNumber = LineNumber + 2

        Dim columnsCountM As Integer = DischargeMeds.Columns.Count
        For Each column In DischargeMeds.Columns
            sheet.Cells(LineNumber, column.Index + 1).Value = column.HeaderText.ToString
        Next
        'Export Header Name End
        LineNumber = LineNumber + 1
        'Export Each Row Start
        For i As Integer = 0 To DischargeMeds.Rows.Count - 1
            Dim columnIndexM As Integer = 0
            Do Until columnIndexM = columnsCountM
                If DischargeMeds.Rows(i).Cells(1).Value <> "" Then
                    sheet.Cells(i + LineNumber, columnIndexM + 1).Value = DischargeMeds.Rows(i).Cells(columnIndexM).Value
                End If
                columnIndexM = columnIndexM + 1
            Loop
        Next
        Dim endLineNumber As Integer = 1
        If DischargeMeds.Rows.Count > 1 Then
            endLineNumber = LineNumber + DischargeMeds.Rows.Count - 1
        Else
            endLineNumber = LineNumber + 1
        End If
        LineNumber = LineNumber - 1
        '' Add Formatting
        range = sheet.Range(sheet.Cells(LineNumber, 1), sheet.Cells(endLineNumber - 1, columnsCountM))
        range.Font.Bold = True
        Dim borderM As Excel.Borders = range.Borders
        borderM.LineStyle = Excel.XlLineStyle.xlContinuous
        borderM.Weight = 2.0



        sheet.Columns("A:I").autofit()


        'save the workbook and clean up
        book.SaveAs(savefiledialog1.FileName)
        savefiledialog1.FileName = ""
        xlsx.Workbooks.Close()
        xlsx.Quit()


        CancelExcelObjects()

        MessageBox.Show("Discharge Summary Saved")

    End Sub

    Public Sub ExportExcel(MedicationList As DataGridView)
        'Export the listview to an Excel spreadsheet
        savefiledialog1.Title = "Save Excel File"
        savefiledialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel files (*.xls)|*.xls"
        savefiledialog1.ShowDialog()
        'exit if no file selected
        If savefiledialog1.FileName = "" Then
            Exit Sub
        End If
        'create objects to interface to Excel and get reference to first worksheet


        CreateExcelObjects()


        'step through rows and columns and copy data to worksheet
        sheet.Cells(1, 1) = "Medication Reconcilliation"
        sheet.Cells(1, 1).font.bold = True
        sheet.Cells(1, 2) = "(Pre-Admission Medication List)"
        sheet.Cells(1, 2).font.bold = True

        sheet.Cells(4, 1) = "Medication History Source:"
        sheet.Cells(4, 1).font.bold = True
        sheet.Cells(4, 2) = sMedSource
        sheet.Cells(4, 2).font.bold = True
        sheet.Cells(4, 3) = "Name of Source:"
        sheet.Cells(4, 3).font.bold = True
        sheet.Cells(4, 4) = sMedSourceName
        sheet.Cells(4, 4).font.bold = True

        ''Set up Datagrid for Medication

        Dim LineNumber As Integer = 7
        sheet.Cells(LineNumber, 1).Value = "Admission Medication List"
        sheet.Cells(LineNumber, 1).font.bold = True
        LineNumber = LineNumber + 2
        Dim columnsCountM As Integer = MedicationList.Columns.Count
        For Each column In MedicationList.Columns
            sheet.Cells(LineNumber, column.Index + 1).Value = column.HeaderText.ToString
        Next
        LineNumber = LineNumber + 1
        'Export Header Name End

        'Export Each Row Start
        For i As Integer = 0 To MedicationList.Rows.Count - 1
            Dim columnIndexM As Integer = 0
            Do Until columnIndexM = columnsCountM
                If MedicationList.Rows(i).Cells(1).Value <> "" Then
                    sheet.Cells(i + LineNumber, columnIndexM + 1).Value = MedicationList.Rows(i).Cells(columnIndexM).Value
                End If
                columnIndexM = columnIndexM + 1
            Loop
        Next
        Dim endLineNumber As Integer = 1
        If MedicationList.Rows.Count > 1 Then
            endLineNumber = LineNumber + MedicationList.Rows.Count - 1
        Else
            endLineNumber = LineNumber + 1
        End If
        LineNumber = LineNumber - 1
        '' Add Formatting
        range = sheet.Range(sheet.Cells(LineNumber, 1), sheet.Cells(endLineNumber - 1, columnsCountM))
        range.Font.Bold = True
        Dim borderM As Excel.Borders = range.Borders
        borderM.LineStyle = Excel.XlLineStyle.xlContinuous
        borderM.Weight = 2.0
        sheet.Columns("A:I").autofit()
        'save the workbook and clean up

        book.SaveAs(savefiledialog1.FileName)

        xlsx.Workbooks.Close()

        xlsx.Quit()
        CancelExcelObjects()

        MessageBox.Show("Admission Medication List Saved")
        savefiledialog1.FileName = ""
    End Sub
    Private Sub CancelExcelObjects()
        releaseObject(range)
        releaseObject(sheet)
        releaseObject(sheets)
        releaseObject(book)
        releaseObject(books)
        releaseObject(xlsx)
    End Sub

    Private Sub CreateExcelObjects()

        'create a workbook and get reference to first worksheet
        xlsx = New Excel.Application
        books = xlsx.Workbooks
        book = books.Add()
        sheets = book.Sheets
        sheet = sheets.Add()

    End Sub


    Private Sub releaseObject(ByRef obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub
End Class
