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
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.lbRatio = New System.Windows.Forms.ListBox()
            Me.label1 = New System.Windows.Forms.Label()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Location = New System.Drawing.Point(4, 4)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(504, 504)
            Me.mapControl1.TabIndex = 0
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.lbRatio)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(508, 4)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
            Me.panel1.Size = New System.Drawing.Size(200, 504)
            Me.panel1.TabIndex = 1
            ' 
            ' lbRatio
            ' 
            Me.lbRatio.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbRatio.FormattingEnabled = True
            Me.lbRatio.Location = New System.Drawing.Point(4, 21)
            Me.lbRatio.Name = "lbRatio"
            Me.lbRatio.Size = New System.Drawing.Size(192, 483)
            Me.lbRatio.TabIndex = 1
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Location = New System.Drawing.Point(4, 4)
            Me.label1.Name = "label1"
            Me.label1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
            Me.label1.Size = New System.Drawing.Size(110, 17)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Width/Height Ratio:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(712, 512)
            Me.Controls.Add(Me.mapControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(4)
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private panel1 As System.Windows.Forms.Panel
        Private lbRatio As System.Windows.Forms.ListBox
        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace

