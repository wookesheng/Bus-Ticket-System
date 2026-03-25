<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCustDetails = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.grpTicketInformation = New System.Windows.Forms.GroupBox()
        Me.chkSingapore2 = New System.Windows.Forms.CheckBox()
        Me.chkKL2 = New System.Windows.Forms.CheckBox()
        Me.chkHatYai2 = New System.Windows.Forms.CheckBox()
        Me.chkBangkok2 = New System.Windows.Forms.CheckBox()
        Me.chkSingapore = New System.Windows.Forms.CheckBox()
        Me.chkKL = New System.Windows.Forms.CheckBox()
        Me.chkHatYai = New System.Windows.Forms.CheckBox()
        Me.chkBangkok = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTPrice = New System.Windows.Forms.Label()
        Me.lblTicketPrice = New System.Windows.Forms.Label()
        Me.grpPriceInformation = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTaxx = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblSTotal = New System.Windows.Forms.Label()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpFrom = New System.Windows.Forms.GroupBox()
        Me.grpTo = New System.Windows.Forms.GroupBox()
        Me.grpCustDetails.SuspendLayout()
        Me.grpTicketInformation.SuspendLayout()
        Me.grpPriceInformation.SuspendLayout()
        Me.grpFrom.SuspendLayout()
        Me.grpTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking Bus Ticket Information"
        '
        'grpCustDetails
        '
        Me.grpCustDetails.BackColor = System.Drawing.Color.Transparent
        Me.grpCustDetails.Controls.Add(Me.txtEmail)
        Me.grpCustDetails.Controls.Add(Me.lblEmail)
        Me.grpCustDetails.Controls.Add(Me.txtPhoneNo)
        Me.grpCustDetails.Controls.Add(Me.lblPhoneNo)
        Me.grpCustDetails.Controls.Add(Me.txtCustName)
        Me.grpCustDetails.Controls.Add(Me.lblCustName)
        Me.grpCustDetails.Location = New System.Drawing.Point(29, 91)
        Me.grpCustDetails.Name = "grpCustDetails"
        Me.grpCustDetails.Size = New System.Drawing.Size(299, 352)
        Me.grpCustDetails.TabIndex = 1
        Me.grpCustDetails.TabStop = False
        Me.grpCustDetails.Text = "Customer Details"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(105, 184)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(173, 22)
        Me.txtEmail.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 184)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 16)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email:"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(105, 119)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(173, 22)
        Me.txtPhoneNo.TabIndex = 3
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(6, 119)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(70, 16)
        Me.lblPhoneNo.TabIndex = 2
        Me.lblPhoneNo.Text = "Phone No:"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(105, 55)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(173, 22)
        Me.txtCustName.TabIndex = 1
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Location = New System.Drawing.Point(6, 55)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(47, 16)
        Me.lblCustName.TabIndex = 0
        Me.lblCustName.Text = "Name:"
        '
        'grpTicketInformation
        '
        Me.grpTicketInformation.BackColor = System.Drawing.Color.Transparent
        Me.grpTicketInformation.Controls.Add(Me.grpTo)
        Me.grpTicketInformation.Controls.Add(Me.grpFrom)
        Me.grpTicketInformation.Controls.Add(Me.btnClear)
        Me.grpTicketInformation.Controls.Add(Me.btnCheck)
        Me.grpTicketInformation.Controls.Add(Me.txtQuantity)
        Me.grpTicketInformation.Controls.Add(Me.lblQuantity)
        Me.grpTicketInformation.Controls.Add(Me.lblTPrice)
        Me.grpTicketInformation.Controls.Add(Me.lblTicketPrice)
        Me.grpTicketInformation.Location = New System.Drawing.Point(388, 91)
        Me.grpTicketInformation.Name = "grpTicketInformation"
        Me.grpTicketInformation.Size = New System.Drawing.Size(307, 352)
        Me.grpTicketInformation.TabIndex = 2
        Me.grpTicketInformation.TabStop = False
        Me.grpTicketInformation.Text = "Ticket Information"
        '
        'chkSingapore2
        '
        Me.chkSingapore2.AutoSize = True
        Me.chkSingapore2.Location = New System.Drawing.Point(6, 119)
        Me.chkSingapore2.Name = "chkSingapore2"
        Me.chkSingapore2.Size = New System.Drawing.Size(92, 20)
        Me.chkSingapore2.TabIndex = 34
        Me.chkSingapore2.Text = "Singapore"
        Me.chkSingapore2.UseVisualStyleBackColor = True
        '
        'chkKL2
        '
        Me.chkKL2.AutoSize = True
        Me.chkKL2.Location = New System.Drawing.Point(6, 93)
        Me.chkKL2.Name = "chkKL2"
        Me.chkKL2.Size = New System.Drawing.Size(110, 20)
        Me.chkKL2.TabIndex = 33
        Me.chkKL2.Text = "Kuala Lumpur"
        Me.chkKL2.UseVisualStyleBackColor = True
        '
        'chkHatYai2
        '
        Me.chkHatYai2.AutoSize = True
        Me.chkHatYai2.Location = New System.Drawing.Point(6, 67)
        Me.chkHatYai2.Name = "chkHatYai2"
        Me.chkHatYai2.Size = New System.Drawing.Size(73, 20)
        Me.chkHatYai2.TabIndex = 32
        Me.chkHatYai2.Text = "Hat Yai"
        Me.chkHatYai2.UseVisualStyleBackColor = True
        '
        'chkBangkok2
        '
        Me.chkBangkok2.AutoSize = True
        Me.chkBangkok2.Location = New System.Drawing.Point(6, 37)
        Me.chkBangkok2.Name = "chkBangkok2"
        Me.chkBangkok2.Size = New System.Drawing.Size(83, 20)
        Me.chkBangkok2.TabIndex = 31
        Me.chkBangkok2.Text = "Bangkok"
        Me.chkBangkok2.UseVisualStyleBackColor = True
        '
        'chkSingapore
        '
        Me.chkSingapore.AutoSize = True
        Me.chkSingapore.Location = New System.Drawing.Point(6, 119)
        Me.chkSingapore.Name = "chkSingapore"
        Me.chkSingapore.Size = New System.Drawing.Size(92, 20)
        Me.chkSingapore.TabIndex = 30
        Me.chkSingapore.Text = "Singapore"
        Me.chkSingapore.UseVisualStyleBackColor = True
        '
        'chkKL
        '
        Me.chkKL.AutoSize = True
        Me.chkKL.Location = New System.Drawing.Point(6, 93)
        Me.chkKL.Name = "chkKL"
        Me.chkKL.Size = New System.Drawing.Size(110, 20)
        Me.chkKL.TabIndex = 29
        Me.chkKL.Text = "Kuala Lumpur"
        Me.chkKL.UseVisualStyleBackColor = True
        '
        'chkHatYai
        '
        Me.chkHatYai.AutoSize = True
        Me.chkHatYai.Location = New System.Drawing.Point(6, 67)
        Me.chkHatYai.Name = "chkHatYai"
        Me.chkHatYai.Size = New System.Drawing.Size(73, 20)
        Me.chkHatYai.TabIndex = 28
        Me.chkHatYai.Text = "Hat Yai"
        Me.chkHatYai.UseVisualStyleBackColor = True
        '
        'chkBangkok
        '
        Me.chkBangkok.AutoSize = True
        Me.chkBangkok.Location = New System.Drawing.Point(6, 37)
        Me.chkBangkok.Name = "chkBangkok"
        Me.chkBangkok.Size = New System.Drawing.Size(83, 20)
        Me.chkBangkok.TabIndex = 27
        Me.chkBangkok.Text = "Bangkok"
        Me.chkBangkok.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(187, 300)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 37)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(19, 300)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(87, 37)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(93, 256)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(181, 22)
        Me.txtQuantity.TabIndex = 7
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(6, 259)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(58, 16)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity:"
        '
        'lblTPrice
        '
        Me.lblTPrice.BackColor = System.Drawing.Color.White
        Me.lblTPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTPrice.Location = New System.Drawing.Point(93, 205)
        Me.lblTPrice.Name = "lblTPrice"
        Me.lblTPrice.Size = New System.Drawing.Size(181, 23)
        Me.lblTPrice.TabIndex = 5
        Me.lblTPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTicketPrice
        '
        Me.lblTicketPrice.AutoSize = True
        Me.lblTicketPrice.Location = New System.Drawing.Point(8, 212)
        Me.lblTicketPrice.Name = "lblTicketPrice"
        Me.lblTicketPrice.Size = New System.Drawing.Size(81, 16)
        Me.lblTicketPrice.TabIndex = 4
        Me.lblTicketPrice.Text = "Ticket Price:"
        '
        'grpPriceInformation
        '
        Me.grpPriceInformation.BackColor = System.Drawing.Color.Transparent
        Me.grpPriceInformation.Controls.Add(Me.lblTotal)
        Me.grpPriceInformation.Controls.Add(Me.lblTotal1)
        Me.grpPriceInformation.Controls.Add(Me.lblTax)
        Me.grpPriceInformation.Controls.Add(Me.lblTaxx)
        Me.grpPriceInformation.Controls.Add(Me.lblSubTotal)
        Me.grpPriceInformation.Controls.Add(Me.lblSTotal)
        Me.grpPriceInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPriceInformation.Location = New System.Drawing.Point(752, 91)
        Me.grpPriceInformation.Name = "grpPriceInformation"
        Me.grpPriceInformation.Size = New System.Drawing.Size(299, 352)
        Me.grpPriceInformation.TabIndex = 3
        Me.grpPriceInformation.TabStop = False
        Me.grpPriceInformation.Text = "Price Information"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(103, 264)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(163, 62)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotal1
        '
        Me.lblTotal1.AutoSize = True
        Me.lblTotal1.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal1.Location = New System.Drawing.Point(20, 290)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(41, 16)
        Me.lblTotal1.TabIndex = 4
        Me.lblTotal1.Text = "Total:"
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.White
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(103, 144)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(163, 62)
        Me.lblTax.TabIndex = 3
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTaxx
        '
        Me.lblTaxx.AutoSize = True
        Me.lblTaxx.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxx.Location = New System.Drawing.Point(20, 175)
        Me.lblTaxx.Name = "lblTaxx"
        Me.lblTaxx.Size = New System.Drawing.Size(60, 16)
        Me.lblTaxx.TabIndex = 2
        Me.lblTaxx.Text = "Tax(6%):"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.White
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Location = New System.Drawing.Point(103, 34)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(163, 62)
        Me.lblSubTotal.TabIndex = 1
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSTotal
        '
        Me.lblSTotal.AutoSize = True
        Me.lblSTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTotal.Location = New System.Drawing.Point(20, 58)
        Me.lblSTotal.Name = "lblSTotal"
        Me.lblSTotal.Size = New System.Drawing.Size(68, 16)
        Me.lblSTotal.TabIndex = 0
        Me.lblSTotal.Text = "Sub Total:"
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(915, 469)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(136, 46)
        Me.btnSummary.TabIndex = 5
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(752, 469)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(136, 46)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'grpFrom
        '
        Me.grpFrom.Controls.Add(Me.chkBangkok)
        Me.grpFrom.Controls.Add(Me.chkHatYai)
        Me.grpFrom.Controls.Add(Me.chkKL)
        Me.grpFrom.Controls.Add(Me.chkSingapore)
        Me.grpFrom.Location = New System.Drawing.Point(0, 34)
        Me.grpFrom.Name = "grpFrom"
        Me.grpFrom.Size = New System.Drawing.Size(121, 156)
        Me.grpFrom.TabIndex = 35
        Me.grpFrom.TabStop = False
        Me.grpFrom.Text = "From:"
        '
        'grpTo
        '
        Me.grpTo.Controls.Add(Me.chkBangkok2)
        Me.grpTo.Controls.Add(Me.chkSingapore2)
        Me.grpTo.Controls.Add(Me.chkHatYai2)
        Me.grpTo.Controls.Add(Me.chkKL2)
        Me.grpTo.Location = New System.Drawing.Point(178, 34)
        Me.grpTo.Name = "grpTo"
        Me.grpTo.Size = New System.Drawing.Size(129, 156)
        Me.grpTo.TabIndex = 6
        Me.grpTo.TabStop = False
        Me.grpTo.Text = "To:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1073, 537)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.grpPriceInformation)
        Me.Controls.Add(Me.grpTicketInformation)
        Me.Controls.Add(Me.grpCustDetails)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Booking Form"
        Me.grpCustDetails.ResumeLayout(False)
        Me.grpCustDetails.PerformLayout()
        Me.grpTicketInformation.ResumeLayout(False)
        Me.grpTicketInformation.PerformLayout()
        Me.grpPriceInformation.ResumeLayout(False)
        Me.grpPriceInformation.PerformLayout()
        Me.grpFrom.ResumeLayout(False)
        Me.grpFrom.PerformLayout()
        Me.grpTo.ResumeLayout(False)
        Me.grpTo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpCustDetails As GroupBox
    Friend WithEvents grpTicketInformation As GroupBox
    Friend WithEvents grpPriceInformation As GroupBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblCustName As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents lblTicketPrice As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblTPrice As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotal1 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTaxx As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblSTotal As Label
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents chkSingapore2 As CheckBox
    Friend WithEvents chkKL2 As CheckBox
    Friend WithEvents chkHatYai2 As CheckBox
    Friend WithEvents chkBangkok2 As CheckBox
    Friend WithEvents chkSingapore As CheckBox
    Friend WithEvents chkKL As CheckBox
    Friend WithEvents chkHatYai As CheckBox
    Friend WithEvents chkBangkok As CheckBox
    Friend WithEvents grpTo As GroupBox
    Friend WithEvents grpFrom As GroupBox
End Class
