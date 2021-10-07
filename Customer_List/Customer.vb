'Author: Kyle Loewenhagen
'Purpose: Manage the Customer
'Date: ##/##/####

Option Strict On
Option Explicit On
Public Class Customer
    'Define Class or Module Level Variables
    Private mstrCustomerID As String
    Private mstrFirstName As String
    Private mstrLastName As String
    Private mstrAddress As String
    Private mstrCity As String
    Private mstrState As String
    Private mstrZip As String
    Private mstrEmail As String

    Public Property CustomerID As String
        Get
            Return mstrCustomerID
        End Get
        Set(ByVal strValue As String)
            mstrCustomerID = strValue
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return mstrFirstName
        End Get
        Set(ByVal strValue As String)
            mstrFirstName = strValue
        End Set
    End Property

    Public Property LastName As String
        Get
            Return mstrLastName
        End Get
        Set(ByVal strValue As String)
            mstrLastName = strValue
        End Set
    End Property

    Public Property Address As String
        Get
            Return mstrAddress
        End Get
        Set(ByVal strValue As String)
            mstrAddress = strValue
        End Set
    End Property

    Public Property City As String
        Get
            Return mstrCity
        End Get
        Set(ByVal strValue As String)
            mstrCity = strValue
        End Set
    End Property

    Public Property State As String
        Get
            Return mstrState
        End Get
        Set(ByVal strValue As String)
            mstrState = strValue
        End Set
    End Property

    Public Property Zip As String
        Get
            Return mstrZip
        End Get
        Set(ByVal strValue As String)
            mstrZip = strValue
        End Set
    End Property

    Public Property Email As String
        Get
            Return mstrEmail
        End Get
        Set(ByVal strValue As String)
            mstrEmail = strValue
        End Set
    End Property

    'Default Constructor
    Public Sub New()
        mstrCustomerID = String.Empty
        mstrFirstName = String.Empty
        mstrLastName = String.Empty
        mstrAddress = String.Empty
        mstrCity = String.Empty
        mstrState = String.Empty
        mstrZip = String.Empty
        mstrEmail = String.Empty
    End Sub

    'Overload Constructors
    Public Sub New(ByVal strCustomerID As String)
        mstrCustomerID = strCustomerID
        mstrFirstName = String.Empty
        mstrLastName = String.Empty
        mstrAddress = String.Empty
        mstrCity = String.Empty
        mstrState = String.Empty
        mstrZip = String.Empty
        mstrEmail = String.Empty
    End Sub

    'Method
    Public Function Full_Name() As String
        Return mstrFirstName & " " & mstrLastName
    End Function

    Public Function City_State() As String
        Return mstrCity & ", " & mstrState & "  " & mstrZip
    End Function

    Public Sub Calculate_Years(ByVal strCustomerDate As String, ByRef intYears As Integer)
        intYears = CInt(DateDiff(DateInterval.Year, CDate(strCustomerDate), Date.Now))
    End Sub


End Class
