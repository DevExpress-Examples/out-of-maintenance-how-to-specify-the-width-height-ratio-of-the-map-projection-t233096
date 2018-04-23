Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CustomRatios
    Partial Public Class Form1
        Inherits Form

        Private Const filepath As String = "..\..\Data\Countries.shp"
        Private Const defaultSideSize As Integer = 512

        Private Class WidthHeightRatio
            Public Property Name() As String
            Public Property Value() As Double

            Public Overrides Function ToString() As String
                Return Name
            End Function
        End Class

        Private ratios As New List(Of WidthHeightRatio)() From { _
            New WidthHeightRatio() With {.Name = "Default", .Value = 1}, _
            New WidthHeightRatio() With {.Name = "Lambert", .Value = 3.14}, _
            New WidthHeightRatio() With {.Name = "Behrmann", .Value = 2.36}, _
            New WidthHeightRatio() With {.Name = "Trystan Edwards", .Value = 2}, _
            New WidthHeightRatio() With {.Name = "Gall-Peters", .Value = 1.57}, _
            New WidthHeightRatio() With {.Name = "Balthasart", .Value = 1.3} _
        }

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            cbRatio.Properties.Items.AddRange(ratios)
            cbRatio.SelectedIndex = 0

            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Dim uri As New Uri(baseUri, filepath)
            mapControl1.Layers.Add(New VectorItemsLayer() With { _
                .Data = New ShapefileDataAdapter() With {.FileUri = uri} _
            })
        End Sub

        Private Sub OnRatioSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRatio.SelectedIndexChanged
            mapControl1.InitialMapSize = New Size() With {.Width = defaultSideSize, .Height = CInt((defaultSideSize / CType(cbRatio.SelectedItem, WidthHeightRatio).Value))}
        End Sub
    End Class
End Namespace
