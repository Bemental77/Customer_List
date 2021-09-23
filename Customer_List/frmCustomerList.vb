
'Author: Casey Bement
'Purpose: Instantiate a Customer Class
'Date: 09/23/2021

Option Strict On
Option Explicit On

Imports System.ComponentModel
Public Class frmCustomerList

    'Module Level Object
    Dim lstCustomers As New BindingList(Of Customer)


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'Validate all data in textboxes
        If txtCustomerID.Text <> String.Empty Then
            If txtFirstName.Text <> String.Empty Then
                If txtLastName.Text <> String.Empty Then
                    If txtAddress.Text <> String.Empty Then
                        If txtCity.Text <> String.Empty Then
                            If txtState.Text <> String.Empty Then
                                If txtZip.Text <> String.Empty Then
                                    If IsDate(txtCustomerSince.Text) = True Then
                                        'Declare Objects and Variables
                                        Dim objCustomer As New Customer(txtCustomerID.Text)
                                        Dim intCustomerYears As Integer

                                        'Assign Customer Properties
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
                                        objCustomer.Calculate_Years(txtCustomerSince.Text, intCustomerYears)
                                        lblCustomerYearsOutput.Text = intCustomerYears.ToString

                                        'Add new Customer object to list of customers
                                        lstCustomers.Add(objCustomer)


                                    Else
                                        Call Msg("Customer Since field must be a date.")
                                        txtCustomerSince.Focus()
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
        lbxCustomers.DataSource = lstCustomers
        lbxCustomers.DisplayMember = "CustomerID"
    End Sub

    Private Sub lbxCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxCustomers.SelectedIndexChanged

        Dim objSelectedCustomer As Customer = CType(lbxCustomers.SelectedItem, Customer)
        MessageBox.Show(objSelectedCustomer.Full_Name)
    End Sub
End Class

