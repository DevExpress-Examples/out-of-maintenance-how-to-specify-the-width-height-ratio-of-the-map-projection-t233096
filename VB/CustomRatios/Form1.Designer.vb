Namespace CustomRatios
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbRatio = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciMap = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciRatio = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.cbRatio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciMap, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciRatio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Location = New System.Drawing.Point(6, 30)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(620, 316)
            Me.mapControl1.TabIndex = 0
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.cbRatio)
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(4, 4)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(419, 232, 1005, 636)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(632, 352)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cbRatio
            ' 
            Me.cbRatio.Location = New System.Drawing.Point(98, 6)
            Me.cbRatio.Name = "cbRatio"
            Me.cbRatio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbRatio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbRatio.Size = New System.Drawing.Size(528, 20)
            Me.cbRatio.StyleController = Me.layoutControl1
            Me.cbRatio.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.lciMap, Me.lciRatio})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(632, 352)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' lciMap
            ' 
            Me.lciMap.Control = Me.mapControl1
            Me.lciMap.Location = New System.Drawing.Point(0, 24)
            Me.lciMap.Name = "lciMap"
            Me.lciMap.Size = New System.Drawing.Size(624, 320)
            Me.lciMap.TextSize = New System.Drawing.Size(0, 0)
            Me.lciMap.TextVisible = False
            ' 
            ' lciRatio
            ' 
            Me.lciRatio.Control = Me.cbRatio
            Me.lciRatio.Location = New System.Drawing.Point(0, 0)
            Me.lciRatio.Name = "lciRatio"
            Me.lciRatio.Size = New System.Drawing.Size(624, 24)
            Me.lciRatio.Text = "Width/Heiht Ratio:"
            Me.lciRatio.TextSize = New System.Drawing.Size(89, 13)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(640, 360)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(4)
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.cbRatio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciMap, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciRatio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private lciMap As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents cbRatio As DevExpress.XtraEditors.ComboBoxEdit
        Private lciRatio As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

