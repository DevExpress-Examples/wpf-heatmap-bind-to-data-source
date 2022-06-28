Imports DevExpress.Xpf.Core
Imports System
Imports System.Data
Imports System.IO
Imports System.Windows
Imports System.Xml
Imports System.Xml.Linq

Namespace HeatmapDataSource

    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            DataContext = CreateDataSet("/Data/BalanceOfTrade.xml")
        End Sub
    End Class

    Public Module DataLoader

        Private Function GetStream(ByVal fileName As String) As Stream
            Dim uri As Uri = New Uri(fileName, UriKind.RelativeOrAbsolute)
            Return Application.GetResourceStream(uri).Stream
        End Function

        Public Function LoadXDocumentFromResources(ByVal fileName As String) As XDocument
            Try
                Return XDocument.Load(GetStream(fileName))
            Catch
                Return Nothing
            End Try
        End Function

        Public Function LoadXmlDocumentFromResources(ByVal fileName As String) As XmlDocument
            Dim document As XmlDocument = New XmlDocument()
            Try
                document.Load(GetStream(fileName))
                Return document
            Catch
                Return Nothing
            End Try
        End Function

        Public Function CreateDataSet(ByVal fileName As String) As DataTable
            If Not String.IsNullOrWhiteSpace(fileName) Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(GetStream(fileName))
                If dataSet.Tables.Count > 0 Then Return dataSet.Tables(0)
            End If

            Return Nothing
        End Function
    End Module
End Namespace
