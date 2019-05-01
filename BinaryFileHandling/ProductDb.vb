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
        'Dim ms As New MemoryStream(My.Resources.Products)
        'Dim binaryReader As New BinaryReader(ms)
        ''Dim pos As Short = 0
        ''Dim length As Short = CShort(binaryReader.BaseStream.Length)
        'Dim productList As New List(Of Product)

        'While binaryReader.BaseStream.CanRead
        '    Dim currentProduct As New Product
        '    With binaryReader
        '        currentProduct.Code = .ReadString
        '        currentProduct.Name = .ReadString
        '        currentProduct.Price = .ReadDecimal
        '    End With
        '    productList.Add(currentProduct)
        '    'pos += 1S
        'End While
        'ms.Close
        'binaryReader.Close
        Dim bts() As Byte = My.Resources.Products

        Return productList
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
