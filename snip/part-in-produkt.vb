Sub CATMain()

Dim productDocument1 As ProductDocument
Set productDocument1 = CATIA.ActiveDocument

Dim product1 As Product
Set product1 = productDocument1.Product

Dim products1 As Products
Set products1 = product1.Products

Dim product2 As Product
Set product2 = products1.AddNewComponent("Part", "y005" + Str(Math.Rnd(100))
                                                
'Dim partname As String
'Set partname = "y005" + Str(vbmath.Randomize(100))

        'KNOWN UNRESOLVED ERROR ADDNEWCOMPONENT
                                                'RESOLVED EXISTING NAME
'Dim product2 As Product
'On Error Resume Next
'Set product2 = products1.AddNewComponent("Part", "y002")
'MsgBox Err.Description
'On Error GoTo 0
                                                
End Sub
