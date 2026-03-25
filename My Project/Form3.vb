Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCustName.Text = Form2.txtCustName.Text
        lblPhoneNo.Text = Form2.txtPhoneNo.Text
        lblEmail.Text = Form2.txtEmail.Text
        lblTPrice.Text = Form2.lblTPrice.Text
        lblQuantity.Text = Form2.txtQuantity.Text
        lblSubTotal.Text = Form2.lblSubTotal.Text
        lblTax.Text = Form2.lblTax.Text
        lblTotal.Text = Form2.lblTotal.Text

        If Form2.chkBangkok.Checked = True And Form2.chkHatYai2.Checked = True Then
            lblFrom.Text = "Bangkok"
            lblTo.Text = "Hat Yai"
        ElseIf Form2.chkBangkok.Checked = True And Form2.chkKL2.Checked = True Then
            lblFrom.Text = "Bangkok"
            lblTo.Text = "Kuala Lumpur"
        ElseIf Form2.chkBangkok.Checked = True And Form2.chkSingapore2.Checked = True Then
            lblFrom.Text = "Bangkok"
            lblTo.Text = "Singapore"
        ElseIf Form2.chkHatYai.Checked = True And Form2.chkBangkok2.Checked = True Then
            lblFrom.Text = "Hat Yai"
            lblTo.Text = "Bangkok"
        ElseIf Form2.chkHatYai.Checked = True And Form2.chkKL2.Checked = True Then
            lblFrom.Text = "Hat Yai"
            lblTo.Text = "Kuala Lumpur"
        ElseIf Form2.chkHatYai.Checked = True And Form2.chkSingapore2.Checked = True Then
            lblFrom.Text = "Hat Yai"
            lblTo.Text = "Singapore"
        ElseIf Form2.chkKL.Checked = True And Form2.chkBangkok2.Checked = True Then
            lblFrom.Text = "Kuala Lumpur"
            lblTo.Text = "Bangkok"
        ElseIf Form2.chkKL.Checked = True And Form2.chkHatYai2.Checked = True Then
            lblFrom.Text = "Kuala Lumpur"
            lblTo.Text = "Hat Yai"
        ElseIf Form2.chkKL.Checked = True And Form2.chkSingapore2.Checked = True Then
            lblFrom.Text = "Kuala Lumpur"
            lblTo.Text = "Singapore"
        ElseIf Form2.chkSingapore.Checked = True And Form2.chkBangkok2.Checked = True Then
            lblFrom.Text = "Singapore"
            lblTo.Text = "Bangkok"
        ElseIf Form2.chkSingapore.Checked = True And Form2.chkHatYai2.Checked = True Then
            lblFrom.Text = "Singapore"
            lblTo.Text = "Hat Yai"
        ElseIf Form2.chkSingapore.Checked = True And Form2.chkKL2.Checked = True Then
            lblFrom.Text = "Singapore"
            lblTo.Text = "Kuala Lumpur"
        End If
    End Sub
End Class