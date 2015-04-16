Imports Infoware.Datos

Public Class Utilerias
  Public Shared Function NumaLetras(ByVal num As Double) As String
    Dim Result As String = String.Empty
    Dim dec As String
    Dim ent As String

    num = Math.Abs(num)
    ent = Int(num).ToString.Trim
    dec = (Int(Math.Round(Math.Round(num - Int(num), 5) * 100))).ToString("00")

    Dim t As Integer
    For t = 0 To ent.Length - 1
      Dim refpos As Integer = ent.Length - t
      Dim pos3 As Integer = refpos Mod 3

      Dim txtparc As String = ""
      Select Case pos3
        Case 1
          Dim ok As Boolean = True
          If t > 0 Then
            If ent.Chars(t - 1) = "1" Then
              ok = False
            End If
          End If
          If ok Then
            Select Case ent.Chars(t)
              Case "1" : txtparc = "un "
              Case "2" : txtparc = "dos "
              Case "3" : txtparc = "tres "
              Case "4" : txtparc = "cuatro "
              Case "5" : txtparc = "cinco "
              Case "6" : txtparc = "seis "
              Case "7" : txtparc = "siete "
              Case "8" : txtparc = "ocho "
              Case "9" : txtparc = "nueve "
              Case "0" : txtparc = " "
            End Select
          End If
        Case 2
          Select Case ent.Chars(t)
            Case "1"
              Select Case ent.Chars(t + 1)
                Case "1" : txtparc = "once "
                Case "2" : txtparc = "doce "
                Case "3" : txtparc = "trece "
                Case "4" : txtparc = "catorce "
                Case "5" : txtparc = "quince "
                Case "6" : txtparc = "dieciseis "
                Case "7" : txtparc = "diecisiete "
                Case "8" : txtparc = "dieciocho "
                Case "9" : txtparc = "diecinueve "
                Case "0" : txtparc = "diez "
              End Select
            Case "2" : txtparc = IIf(ent.Chars(t + 1) = "0", "veinte ", "veinti")
            Case "3" : txtparc = "treinta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "4" : txtparc = "cuarenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "5" : txtparc = "cincuenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "6" : txtparc = "sesenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "7" : txtparc = "setenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "8" : txtparc = "ochenta " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "9" : txtparc = "noventa " & IIf(ent.Chars(t + 1) = "0", "", "y ")
            Case "0" : txtparc = ""
          End Select
        Case 0
          Select Case ent.Chars(t)
            Case "1" : txtparc = IIf(ent.Chars(t + 1) = "0" And ent.Chars(t + 2) = "0", "cien ", "ciento ")
            Case "2" : txtparc = "doscientos "
            Case "3" : txtparc = "trescientos "
            Case "4" : txtparc = "cuatrocientos "
            Case "5" : txtparc = "quinientos "
            Case "6" : txtparc = "seiscientos "
            Case "7" : txtparc = "setecientos "
            Case "8" : txtparc = "ochocientos "
            Case "9" : txtparc = "novecientos "
            Case "0" : txtparc = ""
          End Select
      End Select

      Result += txtparc

      Select Case refpos
        Case 4 : Result = Result & "mil "
        Case 7
          If Val(ent.Substring(0, ent.Length - 7 + 1)) > 1 Then
            Result = Result & "millones "
          Else
            Result = Result & "millón "
          End If
        Case 10 : Result = Result & "mil "
        Case 13
          If Val(ent.Substring(0, ent.Length - 13 + 1)) > 1 Then
            Result = Result & "billones "
          Else
            Result = Result & "billón "
          End If
        Case 16 : Result = Result & "mil "
        Case 19
          If Val(ent.Substring(0, ent.Length - 19 + 1)) > 1 Then
            Result = Result & "trillones "
          Else
            Result = Result & "trillón "
          End If
      End Select
    Next

    Result = Result & dec & "/100"
    Return Result
  End Function

  Public Shared Function listameses() As Object()
    Dim meses() As Object
    meses = New Object() {"", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    Return meses
  End Function

  Public Shared Function fechahoraservidor(ByVal _operadordatos As OperadorDatos) As Date
    Dim result As Date = Now.Date
    Try
      With _operadordatos
        .Procedimiento = "proc_FechaHoraServidor"
        .Ejecutar(result)
      End With

    Catch ex As Exception

    End Try
    Return result
  End Function
End Class
