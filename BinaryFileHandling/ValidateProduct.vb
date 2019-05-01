'Program: BinaryFileHandling
'Me: ValidateProduct.vb
'Date: 4/30/2019
'Author: Jason Welch
'Purpose: Class to Validate File data

Option Strict On
Option Explicit On

Public Class ValidateProduct
    '==========================================================================================
    'Name: New()
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Default Constructor
    Public Sub New()

    End Sub
    '==========================================================================================
    'Name: NameIsPresent()
    'Date: 4/30/2019
    'Author: Jason Welch
    Public Function NameIsPresent(nameString As String) As Boolean
        If nameString IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
    '==========================================================================================
    'Name: CodeIsPresent()
    'Date: 4/30/2019
    'Author: Jason Welch
    Public Function CodeIsPresent(codeString As String) As Boolean
        If codeString IsNot Nothing Then
            Return True
        Else
            Return False
        End If
    End Function
    '==========================================================================================
    'Name: PriceIsPresent()
    'Date: 4/30/2019
    'Author: Jason Welch
    Public Function PriceIsPresent(priceDecimal As Decimal) As Boolean
        If Not priceDecimal = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    '==========================================================================================
    'Name: IsDecimal()
    'Date: 4/30/2019
    'Author: Jason Welch
    Public Function IsDecimal(ByVal inParam As Object) As Boolean
        If TypeOf inParam Is Decimal Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
'================================== No Code Follows ===========================================