Public Class MainPanel
    Public Const StandardRoom = 1
    Public Const Apartment = 100
    Public Const KingsRoom = 200
    Public Const Breakfast = 10
    Public Const GYM = 20
    Public Const Kindergarten = 80
    Public Const Swimming = 100
    Public Const Adults = 25
    Public Const Kids = 15
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlEffectHome.Visible = True
        pnl2.Visible = False
        pnl3.Visible = False
        pnl4.Visible = False
        pnl5.Visible = False
        pnlhome.Visible = True
        pnlopcija2.Visible = False
        pnlopcija3.Visible = False
        pnlopcija4.Visible = False






    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        pnl2.Visible = True
        pnlEffectHome.Visible = False

        pnl3.Visible = False
        pnl4.Visible = False
        pnl5.Visible = False
        pnlhome.Visible = False
        pnlopcija2.Visible = True
        pnlopcija3.Visible = False
        pnlopcija4.Visible = False


    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        pnlEffectHome.Visible = False
        pnl2.Visible = False
        pnl3.Visible = True
        pnl4.Visible = False
        pnl5.Visible = False
        pnlhome.Visible = False
        pnlopcija2.Visible = False
        pnlopcija3.Visible = True
        pnlopcija4.Visible = False


    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        pnlEffectHome.Visible = False
        pnl2.Visible = False
        pnl3.Visible = False
        pnl4.Visible = True
        pnl5.Visible = False
        pnlhome.Visible = False
        pnlopcija2.Visible = False
        pnlopcija3.Visible = False
        pnlopcija4.Visible = True


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnl2.Visible = True
        pnlEffectHome.Visible = False

        pnl3.Visible = False
        pnl4.Visible = False
        pnl5.Visible = False
        pnlhome.Visible = False
        pnlopcija2.Visible = True
        pnlopcija3.Visible = False
        pnlopcija4.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlEffectHome.Visible = False
        pnl2.Visible = False
        pnl3.Visible = True
        pnl4.Visible = False
        pnl5.Visible = False
        pnlhome.Visible = False
        pnlopcija2.Visible = False
        pnlopcija3.Visible = True
        pnlopcija4.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlEffectHome.Visible = False
        pnl2.Visible = False
        pnl3.Visible = False
        pnl4.Visible = True
        pnl5.Visible = False
        pnlhome.Visible = False
        pnlopcija2.Visible = False
        pnlopcija3.Visible = False
        pnlopcija4.Visible = True


    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        About.Show()
        Me.Hide()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim NrNights1 As Integer
        Dim RoomType As Integer
        Dim Person As Integer
        Dim Services As Integer
        Dim Tax As Integer
        Dim SUM1 As Integer
        Dim SUM2 As Integer
        Dim SUM3 As Integer
        Dim Total As Integer
        Dim Kids1 As Integer
        Dim PreSum As Integer
        Dim TotalNoTax As Integer

        Try
            NrNights1 = CInt(txtnr.Text)
            Person = CInt(txtnumberadult.Text)

            Kids1 = CInt(txtnumberkids.Text)
            Tax = CInt(txtID2.Text)

        Catch ex As Exception
            MessageBox.Show("Invalid Input, Please enter numeric value")
            txtnr.SelectAll()
            txtnr.Clear()
            txtnr.Focus()

        End Try
        If chboxstand.Checked = True Then
            RoomType = StandardRoom

        End If
        If chboxapartment.Checked = True Then
            RoomType = Apartment

        End If
        If chboxking.Checked = True Then
            RoomType = KingsRoom

        End If

        If radbreak.Checked = True Then
            Services = Breakfast
        End If
        If radgym.Checked = True = True Then
            Services = GYM
        End If

        If radkinderg.Checked = True = True Then
            Services = Kindergarten
        End If
        If radswim.Checked = True = True Then
            Services = Swimming
        End If
        PreSum = Person * Adults + Kids1 * Kids
        SUM1 = NrNights1 * RoomType * PreSum
        SUM2 = SUM1 * Tax
        SUM3 = SUM2 + SUM1
        Total = SUM3 + Services


        TotalNoTax = SUM1 + Services

        lblTotal.Text = Total.ToString("c")

        lblnotax.Text = TotalNoTax.ToString("c")



    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim Result = MsgBox("This Room is already Booked. Do you want to choose another one", MsgBoxStyle.YesNo, "Title String")

        If Result = MsgBoxResult.Yes Then
            MsgBox("Choose Another one ")
        Else
            MsgBox("Thank you for using Check In Room")
        End If
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btn123.Click
        MessageBox.Show("The Room has been checked and reserved")
        btn123.BackColor = Color.Red
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Cinema.Show()
        Me.Hide()

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Theater.Show()
        Me.Hide()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        City.Show()
        Me.Hide()

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Payroll.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmsign.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Profil.Show()
        Me.Hide()

    End Sub
End Class