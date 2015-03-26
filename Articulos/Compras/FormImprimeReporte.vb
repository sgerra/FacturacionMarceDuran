Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormImprimeReporte
    Private myReport As New ReportDocument
    Public Sub AbrirFormulario(ByVal idcompra As Integer)
        ImprimirReporte(idcompra)
        Me.ShowDialog()
    End Sub

    Private Sub ImprimirReporte(ByVal idcompra As Integer)

        myReport = rpt
        rpt.FileName = Application.StartupPath & ("\reporteCompras.rpt")
        inicializarConexion()
        rpt.SetParameterValue("IdCompra", idcompra)
        Cr.ReportSource = rpt 'HttpContext.Current.Server.MapPath("rptgastos.rpt")
        Cr.Show()
    End Sub
    Private Sub inicializarConexion()
        Dim crConnectionInfo As New ConnectionInfo
        Dim strPassword As String = ""
        Dim strUsuario As String = ""

        Try
            '---------------------------------------------------
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim CrTables As Tables
            Dim CrTable As Table
            'myReport = New ReportDocument
            '---------------------------------------------------------
            CrTables = myReport.Database.Tables

            strPassword = My.Settings.pwd
            strUsuario = My.Settings.usuario

            With crConnectionInfo
                .ServerName = My.Settings.servidor
                .DatabaseName = My.Settings.baseconexion
                .UserID = strUsuario
                .Password = strPassword
            End With

            CrTables = myReport.Database.Tables
            Dim strLocation As String

            'Seteo la conexion para el reporte.
            For Each CrTable In CrTables
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
                strLocation = CrTable.Location
                'CrTable.Location = "SPDele_Control_Depositos_Total_new;1"
                CrTable.Location = strLocation
            Next
            'Seteo la conexion para cada uno de los sub reportes.
            Dim crSections As Sections
            Dim crReportObjects As ReportObjects
            Dim crSubreportObject As SubreportObject
            Dim crSubreportDocument As ReportDocument
            crSections = myReport.ReportDefinition.Sections
            Dim CrTablesSubReporte = myReport.Database.Tables
            For Each crSection As Section In crSections
                crReportObjects = crSection.ReportObjects
                For Each crReportObject As ReportObject In crReportObjects
                    If (crReportObject.Kind = ReportObjectKind.SubreportObject) Then
                        crSubreportObject = CType(crReportObject, SubreportObject)
                        crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName)

                        CrTablesSubReporte = crSubreportDocument.Database.Tables
                        For Each CrTable In CrTablesSubReporte
                            crtableLogoninfo = CrTable.LogOnInfo

                            crtableLogoninfo.ConnectionInfo = crConnectionInfo
                            CrTable.ApplyLogOnInfo(crtableLogoninfo)
                            strLocation = CrTable.Location
                            CrTable.Location = strLocation
                        Next
                    End If
                Next
            Next
        Catch ex As Exception
            Throw ex
        Finally
            crConnectionInfo = Nothing
        End Try
    End Sub

    Private Sub Cr_Load(sender As Object, e As EventArgs) Handles Cr.Load

    End Sub
End Class