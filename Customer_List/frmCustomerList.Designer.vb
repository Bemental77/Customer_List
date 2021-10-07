<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerList
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
        Me.lblCityStateOutput = New System.Windows.Forms.Label()
        Me.lblStreetAddressOutput = New System.Windows.Forms.Label()
        Me.lblFullNameOutput = New System.Windows.Forms.Label()
        Me.lblCityState = New System.Windows.Forms.Label()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lbxCustomers = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCityStateOutput
        '
        Me.lblCityStateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCityStateOutput.Location = New System.Drawing.Point(396, 392)
        Me.lblCityStateOutput.Name = "lblCityStateOutput"
        Me.lblCityStateOutput.Size = New System.Drawing.Size(145, 23)
        Me.lblCityStateOutput.TabIndex = 46
        '
        'lblStreetAddressOutput
        '
        Me.lblStreetAddressOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStreetAddressOutput.Location = New System.Drawing.Point(134, 425)
        Me.lblStreetAddressOutput.Name = "lblStreetAddressOutput"
        Me.lblStreetAddressOutput.Size = New System.Drawing.Size(145, 23)
        Me.lblStreetAddressOutput.TabIndex = 45
        '
        'lblFullNameOutput
        '
        Me.lblFullNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullNameOutput.Location = New System.Drawing.Point(132, 394)
        Me.lblFullNameOutput.Name = "lblFullNameOutput"
        Me.lblFullNameOutput.Size = New System.Drawing.Size(145, 23)
        Me.lblFullNameOutput.TabIndex = 44
        '
        'lblCityState
        '
        Me.lblCityState.Location = New System.Drawing.Point(294, 393)
        Me.lblCityState.Name = "lblCityState"
        Me.lblCityState.Size = New System.Drawing.Size(97, 23)
        Me.lblCityState.TabIndex = 43
        Me.lblCityState.Text = "City, State Zip:"
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.Location = New System.Drawing.Point(30, 426)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(97, 23)
        Me.lblStreetAddress.TabIndex = 42
        Me.lblStreetAddress.Text = "Street Address:"
        '
        'lblFullName
        '
        Me.lblFullName.Location = New System.Drawing.Point(30, 394)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(97, 23)
        Me.lblFullName.TabIndex = 41
        Me.lblFullName.Text = "Full Name:"
        '
        'btnSave
        '
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(134, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(144, 23)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "Save Customer"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(134, 251)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(144, 20)
        Me.txtZip.TabIndex = 39
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(134, 214)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(144, 20)
        Me.txtState.TabIndex = 38
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(134, 175)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(144, 20)
        Me.txtCity.TabIndex = 37
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(134, 139)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(144, 20)
        Me.txtAddress.TabIndex = 36
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(134, 99)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(144, 20)
        Me.txtLastName.TabIndex = 35
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(134, 62)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(144, 20)
        Me.txtFirstName.TabIndex = 34
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(134, 22)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(144, 20)
        Me.txtCustomerID.TabIndex = 33
        '
        'lblZip
        '
        Me.lblZip.Location = New System.Drawing.Point(30, 254)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(84, 32)
        Me.lblZip.TabIndex = 32
        Me.lblZip.Text = "Zip Code:"
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(30, 217)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(97, 23)
        Me.lblState.TabIndex = 31
        Me.lblState.Text = "State:"
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(30, 178)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(97, 23)
        Me.lblCity.TabIndex = 30
        Me.lblCity.Text = "City:"
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(30, 139)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(97, 23)
        Me.lblAddress.TabIndex = 29
        Me.lblAddress.Text = "Street Address:"
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(30, 102)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(97, 23)
        Me.lblLastName.TabIndex = 28
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(30, 65)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(97, 23)
        Me.lblFirstName.TabIndex = 27
        Me.lblFirstName.Text = "First Name:"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(30, 25)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(97, 23)
        Me.lblCustomerID.TabIndex = 26
        Me.lblCustomerID.Text = "Customer ID:"
        '
        'lbxCustomers
        '
        Me.lbxCustomers.FormattingEnabled = True
        Me.lbxCustomers.Location = New System.Drawing.Point(310, 25)
        Me.lbxCustomers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbxCustomers.Name = "lbxCustomers"
        Me.lbxCustomers.Size = New System.Drawing.Size(244, 329)
        Me.lbxCustomers.TabIndex = 51
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(12, 329)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 23)
        Me.btnClear.TabIndex = 52
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmCustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(584, 491)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lbxCustomers)
        Me.Controls.Add(Me.lblCityStateOutput)
        Me.Controls.Add(Me.lblStreetAddressOutput)
        Me.Controls.Add(Me.lblFullNameOutput)
        Me.Controls.Add(Me.lblCityState)
        Me.Controls.Add(Me.lblStreetAddress)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCustomerList"
        Me.Text = "Add Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCityStateOutput As Label
    Friend WithEvents lblStreetAddressOutput As Label
    Friend WithEvents lblFullNameOutput As Label
    Friend WithEvents lblCityState As Label
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lbxCustomers As ListBox
    Friend WithEvents btnClear As Button
End Class
