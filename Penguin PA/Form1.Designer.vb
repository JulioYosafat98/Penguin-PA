<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.PicPenguin = New System.Windows.Forms.PictureBox()
        CType(Me.PicPenguin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPenguin
        '
        Me.PicPenguin.BackgroundImage = Global.Penguin_PA.My.Resources.Resources.Back
        Me.PicPenguin.Image = Global.Penguin_PA.My.Resources.Resources.Intro_1
        Me.PicPenguin.Location = New System.Drawing.Point(-3, -2)
        Me.PicPenguin.Name = "PicPenguin"
        Me.PicPenguin.Size = New System.Drawing.Size(2616, 834)
        Me.PicPenguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPenguin.TabIndex = 0
        Me.PicPenguin.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2612, 835)
        Me.Controls.Add(Me.PicPenguin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicPenguin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrAnimation As Timer
    Friend WithEvents PicPenguin As PictureBox
End Class
