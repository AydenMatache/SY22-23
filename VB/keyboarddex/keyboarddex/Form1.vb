Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MechanicalButton.Click
        DisplayPictureBox.Image = MechanicalPicture.Image
        NameLabel.Text = "Mechanical"
        DescriptionLabel.Text = "Spring and Slider Allow For Switch Acuation by Force Applied to Leaf"
        PriceLable.Text = "$$$"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LaserButton.Click
        DisplayPictureBox.Image = LaserPicture.Image
        NameLabel.Text = "Laser"
        DescriptionLabel.Text = "Laser Projected Onto Table, Senses when Keys are Pressed"
        PriceLable.Text = "$$$"
    End Sub

    Private Sub MembraneButton_Click(sender As Object, e As EventArgs) Handles MembraneButton.Click
        DisplayPictureBox.Image = MembranePicture.Image
        NameLabel.Text = "Membrane"
        DescriptionLabel.Text = "Rubber Dome Activates Leaf"
        PriceLable.Text = "$"
    End Sub

    Private Sub OpticalButton_Click(sender As Object, e As EventArgs) Handles OpticalButton.Click
        DisplayPictureBox.Image = OpticalPicture.Image
        NameLabel.Text = "Optical"
        DescriptionLabel.Text = "Spring and Slider Allow For Switch Acuation by Sensing Break In Laser"
        PriceLable.Text = "$$"
    End Sub

    Private Sub ElectroButton_Click(sender As Object, e As EventArgs) Handles ElectroButton.Click
        DisplayPictureBox.Image = ElectroPicture.Image
        NameLabel.Text = "Electro Capacative"
        DescriptionLabel.Text = "Spring and Rubber Dome Allow For Switch Acuation by Contact Between Two Capastive Pads"
        PriceLable.Text = "$$$$"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles DescriptionLabel.Click

    End Sub

    Private Sub MembranePicture_Click(sender As Object, e As EventArgs) Handles MembranePicture.Click

    End Sub
End Class
