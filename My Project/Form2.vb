Public Class Form2
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim intQuantity As Integer
        Dim strCustName As String
        Dim intPhoneNo As Integer
        Dim strEmail As String
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblTotal As Double

        intQuantity = Val(txtQuantity.Text)
        strCustName = Val(txtCustName.Text)
        intPhoneNo = Val(txtPhoneNo.Text)
        strEmail = Val(txtEmail.Text)

        If chkBangkok.Checked = True And chkHatYai2.Checked = True Then
            lblTPrice.Text = "30.00"
            dblSubTotal = intQuantity * 30.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkBangkok.Checked = True And chkKL2.Checked = True Then
            lblTPrice.Text = "130.00"
            dblSubTotal = intQuantity * 130.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkBangkok.Checked = True And chkSingapore2.Checked = True Then
            lblTPrice.Text = "150.00"
            dblSubTotal = intQuantity * 150.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkHatYai.Checked = True And chkBangkok2.Checked = True Then
            lblTPrice.Text = "30.00"
            dblSubTotal = intQuantity * 30.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkHatYai.Checked = True And chkKL2.Checked = True Then
            lblTPrice.Text = "85.00"
            dblSubTotal = intQuantity * 85.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkHatYai.Checked = True And chkSingapore2.Checked = True Then
            lblTPrice.Text = "105.00"
            dblSubTotal = intQuantity * 105.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkKL.Checked = True And chkBangkok2.Checked = True Then
            lblTPrice.Text = "130.00"
            dblSubTotal = intQuantity * 130.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkKL.Checked = True And chkHatYai2.Checked = True Then
            lblTPrice.Text = "85.00"
            dblSubTotal = intQuantity * 85.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkKL.Checked = True And chkSingapore2.Checked = True Then
            lblTPrice.Text = "25.00"
            dblSubTotal = intQuantity * 25.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkSingapore.Checked = True And chkBangkok2.Checked = True Then
            lblTPrice.Text = "150.00"
            dblSubTotal = intQuantity * 150.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkSingapore.Checked = True And chkHatYai2.Checked = True Then
            lblTPrice.Text = "105.00"
            dblSubTotal = intQuantity * 105.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        If chkSingapore.Checked = True And chkKL2.Checked = True Then
            lblTPrice.Text = "25.00"
            dblSubTotal = intQuantity * 25.0
            dblTax = dblSubTotal * 0.06
            dblTotal = dblSubTotal + dblTax
        End If

        lblSubTotal.Text = dblSubTotal.ToString("c2")
        lblTax.Text = dblTax.ToString("c2")
        lblTotal.Text = dblTotal.ToString("c2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        chkBangkok.Checked = False
        chkBangkok2.Checked = False
        chkHatYai.Checked = False
        chkHatYai2.Checked = False
        chkKL.Checked = False
        chkKL2.Checked = False
        chkSingapore.Checked = False
        chkSingapore2.Checked = False
        txtQuantity.Text = String.Empty
        lblTPrice.Text = String.Empty
        lblSubTotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Form3.Show()
    End Sub
End Class