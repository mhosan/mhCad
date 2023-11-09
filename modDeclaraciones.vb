Imports System.IO

Module modDeclaraciones
    Public ultimoComando As String
    Public ubicacionSoporte As String
    Public ubicacionHelp As String
    Public aplicacionNombre As String
    Public sepDecimal As String
    Public sepMiles As String
    Public entidad As VectorDraw.Professional.vdPrimaries.vdFigure
    Public seguir As Boolean = True
    Public distanciaOffset As Double
    Public valorOsnap As String
    Public poligonosCantidad As Integer
    Public ufCantidad As Integer
    Public ucCantidad As Integer
    Public scCantidad As Integer
    'Public matrizEspesores As VectorDraw.Geometry.DoubleArray = New VectorDraw.Geometry.DoubleArray(255)
    Public matrizEspesores(255) As Double
    Public versionVisadores As Boolean

    Sub New()
        '--------------
        ' el help
        '--------------
        ubicacionHelp = Application.StartupPath
        frmPpal.HelpProvider1.HelpNamespace = ubicacionHelp & "\mhcad.chm"
        'Dim soporteDefault As Object
        'soporteDefault = frmPpal.VdF.BaseControl.ActiveDocument.SupportPath
        '--------------
        ' soporte
        '--------------
        ubicacionSoporte = Application.StartupPath & "\mhcadt\"

    End Sub

End Module
