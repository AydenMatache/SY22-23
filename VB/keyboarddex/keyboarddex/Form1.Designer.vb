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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MembraneButton = New System.Windows.Forms.Button()
        Me.MechanicalButton = New System.Windows.Forms.Button()
        Me.OpticalButton = New System.Windows.Forms.Button()
        Me.ElectroButton = New System.Windows.Forms.Button()
        Me.DisplayPictureBox = New System.Windows.Forms.PictureBox()
        Me.LaserButton = New System.Windows.Forms.Button()
        Me.ElectroPicture = New System.Windows.Forms.PictureBox()
        Me.MembranePicture = New System.Windows.Forms.PictureBox()
        Me.MechanicalPicture = New System.Windows.Forms.PictureBox()
        Me.OpticalPicture = New System.Windows.Forms.PictureBox()
        Me.LaserPicture = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PriceLable = New System.Windows.Forms.Label()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectroPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembranePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MechanicalPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpticalPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MembraneButton
        '
        Me.MembraneButton.Location = New System.Drawing.Point(24, 355)
        Me.MembraneButton.Name = "MembraneButton"
        Me.MembraneButton.Size = New System.Drawing.Size(94, 29)
        Me.MembraneButton.TabIndex = 0
        Me.MembraneButton.Text = "Membrane"
        Me.MembraneButton.UseVisualStyleBackColor = True
        '
        'MechanicalButton
        '
        Me.MechanicalButton.Location = New System.Drawing.Point(187, 355)
        Me.MechanicalButton.Name = "MechanicalButton"
        Me.MechanicalButton.Size = New System.Drawing.Size(94, 29)
        Me.MechanicalButton.TabIndex = 1
        Me.MechanicalButton.Text = "Mechanical"
        Me.MechanicalButton.UseVisualStyleBackColor = True
        '
        'OpticalButton
        '
        Me.OpticalButton.Location = New System.Drawing.Point(350, 355)
        Me.OpticalButton.Name = "OpticalButton"
        Me.OpticalButton.Size = New System.Drawing.Size(94, 29)
        Me.OpticalButton.TabIndex = 2
        Me.OpticalButton.Text = "Optical"
        Me.OpticalButton.UseVisualStyleBackColor = True
        '
        'ElectroButton
        '
        Me.ElectroButton.Location = New System.Drawing.Point(488, 355)
        Me.ElectroButton.Name = "ElectroButton"
        Me.ElectroButton.Size = New System.Drawing.Size(147, 29)
        Me.ElectroButton.TabIndex = 3
        Me.ElectroButton.Text = "Electro-Capacitive"
        Me.ElectroButton.UseVisualStyleBackColor = True
        '
        'DisplayPictureBox
        '
        Me.DisplayPictureBox.Location = New System.Drawing.Point(-1, 0)
        Me.DisplayPictureBox.Name = "DisplayPictureBox"
        Me.DisplayPictureBox.Size = New System.Drawing.Size(408, 319)
        Me.DisplayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayPictureBox.TabIndex = 8
        Me.DisplayPictureBox.TabStop = False
        '
        'LaserButton
        '
        Me.LaserButton.Location = New System.Drawing.Point(682, 355)
        Me.LaserButton.Name = "LaserButton"
        Me.LaserButton.Size = New System.Drawing.Size(91, 29)
        Me.LaserButton.TabIndex = 9
        Me.LaserButton.Text = "Laser"
        Me.LaserButton.UseVisualStyleBackColor = True
        '
        'ElectroPicture
        '
        Me.ElectroPicture.Image = CType(resources.GetObject("ElectroPicture.Image"), System.Drawing.Image)
        Me.ElectroPicture.Location = New System.Drawing.Point(791, 441)
        Me.ElectroPicture.Name = "ElectroPicture"
        Me.ElectroPicture.Size = New System.Drawing.Size(10, 10)
        Me.ElectroPicture.TabIndex = 10
        Me.ElectroPicture.TabStop = False
        '
        'MembranePicture
        '
        Me.MembranePicture.Image = CType(resources.GetObject("MembranePicture.Image"), System.Drawing.Image)
        Me.MembranePicture.Location = New System.Drawing.Point(791, 441)
        Me.MembranePicture.Name = "MembranePicture"
        Me.MembranePicture.Size = New System.Drawing.Size(10, 10)
        Me.MembranePicture.TabIndex = 12
        Me.MembranePicture.TabStop = False
        '
        'MechanicalPicture
        '
        Me.MechanicalPicture.Image = CType(resources.GetObject("MechanicalPicture.Image"), System.Drawing.Image)
        Me.MechanicalPicture.Location = New System.Drawing.Point(791, 441)
        Me.MechanicalPicture.Name = "MechanicalPicture"
        Me.MechanicalPicture.Size = New System.Drawing.Size(10, 10)
        Me.MechanicalPicture.TabIndex = 13
        Me.MechanicalPicture.TabStop = False
        '
        'OpticalPicture
        '
        Me.OpticalPicture.Image = CType(resources.GetObject("OpticalPicture.Image"), System.Drawing.Image)
        Me.OpticalPicture.Location = New System.Drawing.Point(791, 441)
        Me.OpticalPicture.Name = "OpticalPicture"
        Me.OpticalPicture.Size = New System.Drawing.Size(10, 10)
        Me.OpticalPicture.TabIndex = 14
        Me.OpticalPicture.TabStop = False
        '
        'LaserPicture
        '
        Me.LaserPicture.Image = CType(resources.GetObject("LaserPicture.Image"), System.Drawing.Image)
        Me.LaserPicture.Location = New System.Drawing.Point(791, 441)
        Me.LaserPicture.Name = "LaserPicture"
        Me.LaserPicture.Size = New System.Drawing.Size(10, 10)
        Me.LaserPicture.TabIndex = 15
        Me.LaserPicture.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(413, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(413, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Price:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(471, 9)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(13, 20)
        Me.NameLabel.TabIndex = 19
        Me.NameLabel.Text = " "
        '
        'PriceLable
        '
        Me.PriceLable.AutoSize = True
        Me.PriceLable.Location = New System.Drawing.Point(463, 131)
        Me.PriceLable.Name = "PriceLable"
        Me.PriceLable.Size = New System.Drawing.Size(13, 20)
        Me.PriceLable.TabIndex = 20
        Me.PriceLable.Text = " "
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(507, 65)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(13, 20)
        Me.DescriptionLabel.TabIndex = 21
        Me.DescriptionLabel.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.PriceLable)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LaserPicture)
        Me.Controls.Add(Me.OpticalPicture)
        Me.Controls.Add(Me.MechanicalPicture)
        Me.Controls.Add(Me.MembranePicture)
        Me.Controls.Add(Me.ElectroPicture)
        Me.Controls.Add(Me.LaserButton)
        Me.Controls.Add(Me.DisplayPictureBox)
        Me.Controls.Add(Me.ElectroButton)
        Me.Controls.Add(Me.OpticalButton)
        Me.Controls.Add(Me.MechanicalButton)
        Me.Controls.Add(Me.MembraneButton)
        Me.Name = "Form1"
        Me.Text = "KeyboardDex"
        CType(Me.DisplayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectroPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembranePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MechanicalPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpticalPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MembraneButton As Button
    Friend WithEvents MechanicalButton As Button
    Friend WithEvents OpticalButton As Button
    Friend WithEvents ElectroButton As Button
    Friend WithEvents DisplayPictureBox As PictureBox
    Friend WithEvents LaserButton As Button
    Friend WithEvents ElectroPicture As PictureBox
    Friend WithEvents MembranePicture As PictureBox
    Friend WithEvents MechanicalPicture As PictureBox
    Friend WithEvents OpticalPicture As PictureBox
    Friend WithEvents LaserPicture As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents PriceLable As Label
    Friend WithEvents DescriptionLabel As Label
End Class
