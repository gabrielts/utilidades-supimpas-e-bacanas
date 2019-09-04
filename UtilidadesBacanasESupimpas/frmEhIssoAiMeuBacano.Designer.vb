<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEhIssoAiMeuBacano
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEhIssoAiMeuBacano))
        Me.btnMatarJavaw = New System.Windows.Forms.Button()
        Me.notifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnMINIZAPROTRAYMEUBACANO = New System.Windows.Forms.Button()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'btnMatarJavaw
        '
        Me.btnMatarJavaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatarJavaw.ForeColor = System.Drawing.Color.Red
        Me.btnMatarJavaw.Image = Global.UtilidadesSupimpasEBacanas.My.Resources.Resources.KILLJAVA
        Me.btnMatarJavaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatarJavaw.Location = New System.Drawing.Point(12, 12)
        Me.btnMatarJavaw.Name = "btnMatarJavaw"
        Me.btnMatarJavaw.Size = New System.Drawing.Size(233, 80)
        Me.btnMatarJavaw.TabIndex = 0
        Me.btnMatarJavaw.Text = "MATAR JAVAW!"
        Me.btnMatarJavaw.UseCompatibleTextRendering = True
        Me.btnMatarJavaw.UseVisualStyleBackColor = True
        '
        'notifyIcon
        '
        Me.notifyIcon.Icon = CType(resources.GetObject("notifyIcon.Icon"), System.Drawing.Icon)
        Me.notifyIcon.Text = "Notificação dedicada a Bruno Thomas Silva"
        Me.notifyIcon.Visible = True
        '
        'btnMINIZAPROTRAYMEUBACANO
        '
        Me.btnMINIZAPROTRAYMEUBACANO.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMINIZAPROTRAYMEUBACANO.ForeColor = System.Drawing.Color.Blue
        Me.btnMINIZAPROTRAYMEUBACANO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMINIZAPROTRAYMEUBACANO.ImageKey = "bacano.ico"
        Me.btnMINIZAPROTRAYMEUBACANO.ImageList = Me.imgList
        Me.btnMINIZAPROTRAYMEUBACANO.Location = New System.Drawing.Point(251, 12)
        Me.btnMINIZAPROTRAYMEUBACANO.Name = "btnMINIZAPROTRAYMEUBACANO"
        Me.btnMINIZAPROTRAYMEUBACANO.Size = New System.Drawing.Size(233, 80)
        Me.btnMINIZAPROTRAYMEUBACANO.TabIndex = 1
        Me.btnMINIZAPROTRAYMEUBACANO.Text = "Minimizar para o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " TRAY MEU BACANO!"
        Me.btnMINIZAPROTRAYMEUBACANO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMINIZAPROTRAYMEUBACANO.UseVisualStyleBackColor = True
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "16170722149.jpg")
        Me.imgList.Images.SetKeyName(1, "bacano.ico")
        '
        'frmEhIssoAiMeuBacano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 100)
        Me.Controls.Add(Me.btnMINIZAPROTRAYMEUBACANO)
        Me.Controls.Add(Me.btnMatarJavaw)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEhIssoAiMeuBacano"
        Me.Text = "Utilidades Supimpas e Bacanas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMatarJavaw As Button
    Friend WithEvents notifyIcon As NotifyIcon
    Friend WithEvents btnMINIZAPROTRAYMEUBACANO As Button
    Friend WithEvents imgList As ImageList
End Class
