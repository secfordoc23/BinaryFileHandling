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
    Public Function GetProduct() As List(Of Product)
        Dim productList As New List(Of Product)
        Dim ms As New MemoryStream(My.Resources.Products)
        Dim binaryReader As New BinaryReader(ms)

        Do While binaryReader.PeekChar <> -1
            Dim currentProduct As New Product
            currentProduct.Code = binaryReader.ReadString
            currentProduct.Name = binaryReader.ReadString
            currentProduct.Price = binaryReader.ReadDecimal
            productList.Add(currentProduct)
        Loop

        ms.Close()
        binaryReader.Close()

        Return productList
    End Function
    '==========================================================================================
    'Name: SaveProduct
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Write Data from a Binary File
    Public Sub SaveProduct(productList As List(Of Product))
        Dim ms As New MemoryStream(My.Resources.Products)
        Dim binaryWriter As New BinaryWriter(ms)

        For Each product As Product In productList
            binaryWriter.Write(product.DisplayMessage)
        Next
        ms.Close()
        binaryWriter.Close()
    End Sub
End Class
'================================== No Code Follows ===========================================
