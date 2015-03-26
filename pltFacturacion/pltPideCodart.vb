Public Class pltPideCodart
    Dim mvarCantidad As Integer

    Public Property Cantidad()
        Get
            Cantidad = mvarCantidad
        End Get
        Set(ByVal value)
            mvarCantidad = value
        End Set
    End Property

    Public Sub CargarArticulo(ByVal codigobarras As String, ByVal cadena As String)
        Dim ds As DataSet
        If wflfacturacion.wflarticulos.ExisteArticulo(cadena, codigobarras) Then
            'Trae los valoes del articulo ingresado
            ds = wflfacturacion.wflarticulos.ObtenerListaParaGrilla(cadena, codigobarras)
        End If
    End Sub
End Class
