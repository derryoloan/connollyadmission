
Public Class ClearForm
        Public Sub clearGrpBox(root As Control)


            For Each ctrl As Control In root.Controls

                clearGrpBox(ctrl)

                If TypeOf ctrl Is TextBox Then

                    CType(ctrl, TextBox).Text = String.Empty
                End If
                If TypeOf ctrl Is ComboBox Then
                    CType(ctrl, ComboBox).Text = String.Empty
                End If
            Next ctrl

        End Sub
    End Class

