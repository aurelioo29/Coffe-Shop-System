Imports System.Data.SqlClient
Module Module1
    'AUTOCODE UNTUK MASTER-MENU
    Function MenuAutocode(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True"

            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn

                Select Case X
                    Case "menu"
                        cmdX.CommandText = "SELECT TOP 1 id_menu from Menu WHERE SUBSTRING(id_menu,3,2) = '" & Format(Y, "yy") &
                                           "'AND SUBSTRING(id_menu,5,2) = '" & Format(Y, "MM") & "' ORDER BY id_menu DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            Last = CInt(Mid(drX.Item("id_menu"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "menu"
                If Z Then
                    Return "MN" & Format(Y, "yyMM") & "101"
                Else
                    Return "MN" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function
    'AUTOCODE UNTUK MASTER-SUPPLIER
    Function SupplierAutocode(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True ; Encrypt=False"

            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn

                Select Case X
                    Case "supplier"
                        cmdX.CommandText = "SELECT TOP 1 id_supplier from Supplier WHERE SUBSTRING(id_supplier,3,2) = '" & Format(Y, "yy") &
                                           "'AND SUBSTRING(id_supplier,5,2) = '" & Format(Y, "MM") & "' ORDER BY id_supplier DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            Last = CInt(Mid(drX.Item("id_supplier"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "supplier"
                If Z Then
                    Return "SP" & Format(Y, "yyMM") & "1001"
                Else
                    Return "SP" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function

    'AUTOCODE UNTUK TRANSAKSI-PENJUALAN
    Function PenjualanAutocode(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True ; Encrypt=False"

            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn

                Select Case X
                    Case "penjualan"
                        cmdX.CommandText = "SELECT TOP 1 id_penjualan from Penjualan WHERE SUBSTRING(id_penjualan,3,2) = '" & Format(Y, "yy") &
                                           "'AND SUBSTRING(id_penjualan,5,2) = '" & Format(Y, "MM") & "' ORDER BY id_penjualan DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            Last = CInt(Mid(drX.Item("id_penjualan"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "penjualan"
                If Z Then
                    Return "PJ" & Format(Y, "yyMM") & "101"
                Else
                    Return "PJ" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function
    'AUTOCODE UNTUK TRANSAKSI-PERALATAN
    Function PeralatanAutocode(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True ; Encrypt=False"

            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn

                Select Case X
                    Case "peralatan"
                        cmdX.CommandText = "SELECT TOP 1 id_pembelian from TransaksiPeralatan WHERE SUBSTRING(id_pembelian,3,2) = '" & Format(Y, "yy") &
                                           "'AND SUBSTRING(id_pembelian,5,2) = '" & Format(Y, "MM") & "' ORDER BY id_pembelian DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            Last = CInt(Mid(drX.Item("id_pembelian"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "peralatan"
                If Z Then
                    Return "PP" & Format(Y, "yyMM") & "101"
                Else
                    Return "PP" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function
    'AUTOCODE UNTUK PEMBELIAN-BAHAN
    Function BahanAutocode(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True ; Encrypt=False"

            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn

                Select Case X
                    Case "bahan"
                        cmdX.CommandText = "SELECT TOP 1 id_pembeli from PembelianBahan WHERE SUBSTRING(id_pembeli,3,2) = '" & Format(Y, "yy") &
                                           "'AND SUBSTRING(id_pembeli,5,2) = '" & Format(Y, "MM") & "' ORDER BY id_pembeli DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            Last = CInt(Mid(drX.Item("id_pembeli"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "bahan"
                If Z Then
                    Return "PK" & Format(Y, "yyMM") & "101"
                Else
                    Return "PK" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function
    'AUTOCODE UNTUK PEMAKAIAN-BAHAN
    Function PemakaianAutocode(X As String, Y As DateTime) As String
        Dim Z As Boolean = True
        Dim Last As Integer

        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source=AURELIO\ACERNITRO ; Initial Catalog=UAS_Kel9 ; Integrated Security=True ; Encrypt=False"

            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn

                Select Case X
                    Case "pemakaian"
                        cmdX.CommandText = "SELECT TOP 1 id_pemakaian from PemakaianBahan WHERE SUBSTRING(id_pemakaian,3,2) = '" & Format(Y, "yy") &
                                           "'AND SUBSTRING(id_pemakaian,5,2) = '" & Format(Y, "MM") & "' ORDER BY id_pemakaian DESC"
                End Select

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            Last = CInt(Mid(drX.Item("id_pemakaian"), 7, 4))
                            Z = False
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using

        Select Case X
            Case "pemakaian"
                If Z Then
                    Return "PB" & Format(Y, "yyMM") & "101"
                Else
                    Return "PB" & Format(Y, "yyMM") & (Last + 1).ToString
                End If
        End Select
        Return ""
    End Function
End Module