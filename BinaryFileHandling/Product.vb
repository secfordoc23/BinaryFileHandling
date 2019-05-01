'Program: BinaryFileHandling
'Me: Product.vb
'Date: 4/30/2019
'Author: Jason Welch
'Purpose: Class to hold data from file

Option Strict On
Option Explicit On

Public Class Product
    Private codeString As String
    Private nameString As String
    Private priceDecimal As Decimal

    '==========================================================================================
    'Name: New()
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Default Constructor
    Public Sub New()

    End Sub
    '==========================================================================================
    'Name: New()
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Parameterized Constructor
    Public Sub New(codeString As String, nameString As String, priceDecimal As Decimal)
        Me.codeString = codeString
        Me.nameString = nameString
        Me.priceDecimal = priceDecimal
    End Sub
    '==========================================================================================
    'Name: Code()
    'Date: 4/30/2019
    'Author: Jason Welch
    Public Property Code() As String
        Get
            Return codeString
        End Get
        Set(ByVal value As String)
            codeString = value
        End Set
    End Property
    '==========================================================================================
    'Name: Price()
    'Date: 4/30/2019
    'Author: Jason Welch
    Public Property Price() As Decimal
        Get
            Return priceDecimal
        End Get
        Set(ByVal value As Decimal)
            priceDecimal = value
        End Set
    End Property
    '==========================================================================================
    'Name: Name()
    'Date: 4/30/2019
    'Author: Jason Welch
    Public Property Name() As String
        Get
            Return nameString
        End Get
        Set(ByVal value As String)
            nameString = value
        End Set
    End Property
    '==========================================================================================
    'Name: DisplayMessage
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Returns a formated string of properties
    Public Function DisplayMessage() As String
        Return codeString & " " & nameString & " " & priceDecimal
    End Function

End Class
'================================== No Code Follows ===========================================
