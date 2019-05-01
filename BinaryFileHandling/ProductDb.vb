Option Strict On
Option Explicit On
'Program: BinaryFileHandling
'Me: Product.vb
'Date: 4/30/2019
'Author: Jason Welch
'Purpose: Class to Read and Write binary data to a file

Imports System.IO

Public Class ProductDb
    '    GetProduct (binary in)
    'SaveProduct  (binary out)
    '==========================================================================================
    'Name: New()
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Default Constructor
    Public Sub New()

    End Sub
    '==========================================================================================
    'Name: GetProduct
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Get Data from Binary File
    Public Function GetProduct() As Product
        Dim fileStream As New FileStream(My.Resources.Products.ToString, FileMode.Open)
        Dim binaryReader As New BinaryReader(fileStream)



    End Function
    '==========================================================================================
    'Name: SaveProduct
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Write Data from a Binary File
    Public Sub SaveProduct(newProduct As Product)
        Dim fileStream As New FileStream(My.Resources.Products.ToString, FileMode.Append)
        Dim binaryWriter As New BinaryWriter(fileStream)

        binaryWriter.Write(newProduct.DisplayMessage)

        binaryWriter.Close()
        fileStream.Close()
    End Sub
End Class
'================================== No Code Follows ===========================================
