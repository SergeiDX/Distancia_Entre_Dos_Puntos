<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.txtresul = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNcalcular = New System.Windows.Forms.Button()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.txtY2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Distancia Entre Dos Puntos"
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(42, 311)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(100, 22)
        Me.txtX1.TabIndex = 1
        '
        'txtY1
        '
        Me.txtY1.Location = New System.Drawing.Point(42, 360)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(100, 22)
        Me.txtY1.TabIndex = 2
        '
        'txtresul
        '
        Me.txtresul.Enabled = False
        Me.txtresul.Location = New System.Drawing.Point(207, 399)
        Me.txtresul.Name = "txtresul"
        Me.txtresul.Size = New System.Drawing.Size(162, 22)
        Me.txtresul.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Distancia_Entre_Dos_Puntos.My.Resources.Resources.disntaniaentredospuntos
        Me.PictureBox1.Location = New System.Drawing.Point(98, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BTNcalcular
        '
        Me.BTNcalcular.Location = New System.Drawing.Point(219, 311)
        Me.BTNcalcular.Name = "BTNcalcular"
        Me.BTNcalcular.Size = New System.Drawing.Size(75, 23)
        Me.BTNcalcular.TabIndex = 5
        Me.BTNcalcular.Text = "Calcular"
        Me.BTNcalcular.UseVisualStyleBackColor = True
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(395, 311)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(100, 22)
        Me.txtX2.TabIndex = 6
        '
        'txtY2
        '
        Me.txtY2.Location = New System.Drawing.Point(395, 360)
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(100, 22)
        Me.txtY2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "X1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Y1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Y2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "X2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Distancia"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(219, 356)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 13
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(395, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtY2)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.BTNcalcular)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtresul)
        Me.Controls.Add(Me.txtY1)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Ejercicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents txtY1 As TextBox
    Friend WithEvents txtresul As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNcalcular As Button
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents txtY2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents Button1 As Button
End Class
