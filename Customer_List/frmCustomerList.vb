
'Author: Casey Bement
'Purpose: Instantiate a Customer Class
'Date: 10/06/2021

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmCustomerList

    'Module level Object
    Dim lstCustomers As New BindingList(Of Customer)
    Dim objCustomer As New Customer()
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'Validate all data in textboxes
        If txtCustomerID.Text <> String.Empty Then
            If txtFirstName.Text <> String.Empty Then
                If txtLastName.Text <> String.Empty Then
                    If txtAddress.Text <> String.Empty Then
                        If txtCity.Text <> String.Empty Then
                            If txtState.Text <> String.Empty Then
                                If txtZip.Text <> String.Empty Then


                                    'Assign Customer Properties
                                    objCustomer.CustomerID = txtCustomerID.Text
                                    objCustomer.FirstName = txtFirstName.Text
                                    objCustomer.LastName = txtLastName.Text
                                    objCustomer.Address = txtAddress.Text
                                    objCustomer.City = txtCity.Text
                                    objCustomer.State = txtState.Text
                                    objCustomer.Zip = txtZip.Text

                                    'Process and Display Output
                                    lblFullNameOutput.Text = objCustomer.Full_Name
                                    lblStreetAddressOutput.Text = objCustomer.Address
                                    lblCityStateOutput.Text = objCustomer.City_State

                                    If btnSave.Text = "Save Customer" Then
                                        'Add new customer object to list of customers
                                        lstCustomers.Add(objCustomer)
                                        InsertCustomer()
                                    ElseIf btnSave.Text = "Update Customer" Then
                                        UpdateCustomer
                                    ElseIf btnSave.Text = "Delete Customer" Then
                                        DeleteCustomer
                                    End If

                                Else
                                        Call Msg("Zip can not be blank.")
                                    txtZip.Focus()
                                End If
                            Else
                                Call Msg("State can not be blank.")
                                txtState.Focus()
                            End If
                        Else
                            Call Msg("City can not be blank.")
                            txtCity.Focus()
                        End If
                    Else
                        Call Msg("Address can not be blank.")
                        txtAddress.Focus()
                    End If
                Else
                    Call Msg("Last Name can not be blank.")
                    txtLastName.Focus()
                End If
            Else
                Call Msg("First Name can not be blank.")
                txtFirstName.Focus()
            End If
        Else
            Call Msg("Customer ID can not be blank.")
            txtCustomerID.Focus()
        End If

    End Sub

    Public Sub Msg(ByVal strMsg As String)
        MessageBox.Show(strMsg, "Customer Application", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Bind BindList to Listbox
        lbxCustomers.DataSource = lstCustomers
        lbxCustomers.DisplayMember = "CustomerID"

        Reload_lbxCustomers()
    End Sub

    Private Sub Reload_lbxCustomers()
        'Clear Listbox
        lstCustomers.Clear()

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As New SqlCommand("Select * from Customer_Tbl;", dbConnection)

        'Execture Command into a DataReader
        Dim rdrCustomer As SqlDataReader = cmdSelect.ExecuteReader

        If rdrCustomer.HasRows Then
            While rdrCustomer.Read
                Dim objStoredCustomer As New Customer(rdrCustomer.Item("Customer_ID").ToString)
                objStoredCustomer.FirstName = rdrCustomer.Item("FirstName").ToString
                objStoredCustomer.LastName = rdrCustomer.Item("LastName").ToString
                objStoredCustomer.Address = rdrCustomer.Item("Address").ToString
                objStoredCustomer.City = rdrCustomer.Item("City").ToString
                objStoredCustomer.State = rdrCustomer.Item("State").ToString
                objStoredCustomer.Zip = rdrCustomer.Item("Zip").ToString
                objStoredCustomer.Email = rdrCustomer.Item("Email").ToString

                lstCustomers.Add(objStoredCustomer)
            End While
        End If

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Sub LbxCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCustomers.SelectedIndexChanged
        If lbxCustomers.SelectedIndex >= 0 Then

            Dim objSelectedCustomer As Customer = CType(lbxCustomers.SelectedItem, Customer)
            MessageBox.Show(objSelectedCustomer.Full_Name)

            'Populate TextBoxes with selected customer
            txtCustomerID.Text = objSelectedCustomer.CustomerID
            txtFirstName.Text = objSelectedCustomer.FirstName
            txtLastName.Text = objSelectedCustomer.LastName
            txtAddress.Text = objSelectedCustomer.Address
            txtCity.Text = objSelectedCustomer.City
            txtState.Text = objSelectedCustomer.State
            txtZip.Text = objSelectedCustomer.Zip

            'Determine if this is an edit or delete
            Dim intResult As Integer = MessageBox.Show("Are you deleting this record?", "Customer List", MessageBoxButtons.YesNo)
            If intResult = DialogResult.No Then
                btnSave.Text = "Update Customer"
                txtCustomerID.Enabled = False
            ElseIf intResult = DialogResult.Yes Then
                btnSave.Text = "Delete Customer"
                txtCustomerID.Enabled = False
            End If

        End If
    End Sub

    Private Function OpenDBConnection() As SqlConnection
        'Create a connection string
        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 9)



        Dim strconnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + strPath + "MyOrganization.mdf"

        'Create a Connection object
        Dim dbConnection As New SqlConnection(strconnection)

        Try
            'Open Database
            dbConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
        Return dbConnection
    End Function

    Public Sub InsertCustomer()
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create Sql String
        Dim strSQL = "Insert into Customer_Tbl (FirstName,LastName,Address,City,State,Zip) values (@FirstName,@LastName,@Address,@City,@State,@Zip)"
        'Create Command 
        Dim cmdInsert As New SqlCommand(strSQL, dbConnection)

        'Populate the Parameters of the Insert
        cmdInsert.Parameters.AddWithValue("FirstName", lstCustomers.Last.FirstName)
        cmdInsert.Parameters.AddWithValue("LastName", lstCustomers.Last.LastName)
        cmdInsert.Parameters.AddWithValue("Address", lstCustomers.Last.Address)
        cmdInsert.Parameters.AddWithValue("City", lstCustomers.Last.City)
        cmdInsert.Parameters.AddWithValue("State", lstCustomers.Last.State)
        cmdInsert.Parameters.AddWithValue("Zip", lstCustomers.Last.Zip)

        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstCustomers.Last.FirstName & " was inserted.")
            Else
                MessageBox.Show("The insert failed.")
            End If

        Catch ex As Exception
            MessageBox.Show("DB Insert Failed" & ex.Message)
        End Try
    End Sub

    Public Sub UpdateCustomer()
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create Sql String
        Dim strSQL = "Update Customer_Tbl set FirstName ='" & txtFirstName.Text & "',LastName = '" & txtLastName.Text & "',Address='" & txtAddress.Text & "',City='" & txtCity.Text & "',State='" & txtState.Text & "',Zip='" & txtZip.Text & "' Where Customer_ID = '" & txtCustomerID.Text & "'"
        MessageBox.Show(strSQL)
        'Create Command 
        Dim cmdUpdate As New SqlCommand(strSQL, dbConnection)



        Try
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(objCustomer.CustomerID & " was updated.")
            Else
                MessageBox.Show("The update failed.")
            End If

        Catch ex As Exception
            MessageBox.Show("DB update Failed" & ex.Message)
        End Try

        Reload_lbxCustomers()
    End Sub
    Private Sub DeleteCustomer()
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create Sql String
        Dim strSQL = "Delete from Customer_Tbl where Customer_ID = '" & objCustomer.CustomerID & "'"
        MessageBox.Show(strSQL)
        'Create Command 
        Dim cmdDelete As New SqlCommand(strSQL, dbConnection)



        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show("Record was deleted.")
            Else
                MessageBox.Show("The delete failed.")
            End If

        Catch ex As Exception
            MessageBox.Show("DB delete Failed" & ex.Message)
        End Try

        Reload_lbxCustomers()
        ClearInput()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Private Sub ClearInput()
        txtCustomerID.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtCity.Text = String.Empty
        txtState.Text = String.Empty
        txtZip.Text = String.Empty
        btnSave.Text = "Save Customer"
        txtCustomerID.Enabled = True
    End Sub
End Class

