'Program: AOT Sculpture Sale
' Me:frmReceipt.vb
' Date: 4/20/2020
'Author: G.Tang
'Purpose: allows the user to look and print a reciept 

Option Strict On
Option Explicit On


Imports System.Drawing.Printing

Public Class frmReceipt
    Inherits System.Windows.Forms.Form

    ' It's important that all the event procedures work with the same PrintDocument
    ' object.
    'Private WithEvents pdoc As New PrintDocument()
    '=============================================================
    Private Sub btnDialog_Click(sender As Object, e As EventArgs) Handles btnDialog.Click
        Dim dialog As New PrintDialog()
        dialog.Document = pdoc

        If dialog.ShowDialog = DialogResult.OK Then
            pdoc.Print()
        End If
    End Sub
    '=============================================================
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Dim ppd As New PrintPreviewDialog()
        Try
            ppd.Document = pdoc
            ppd.ShowDialog()
        Catch exp As Exception
            MessageBox.Show("An error occurred while trying to load the " &
                "document for Print Preview. Make sure you currently have " &
                "access to a printer. A printer must be connected and " &
                "accessible for Print Preview to work.", Me.Text,
                 MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '=============================================================
    Private Sub btnPage_Click(sender As Object, e As EventArgs) Handles btnPage.Click
        Dim psd As New PageSetupDialog()
        With psd
            .Document = pdoc
            .PageSettings = pdoc.DefaultPageSettings
        End With

        If psd.ShowDialog = DialogResult.OK Then
            pdoc.DefaultPageSettings = psd.PageSettings
        End If
    End Sub
    '=============================================================
    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strReceipt As String
        txtDocument.Text = "AOT Jaeger Statue" & ControlChars.NewLine &
            "258 Shinginasha" & ControlChars.NewLine &
            "Wall Maria, OS 61536" & ControlChars.NewLine &
            "Phone: (471) 555-9658" & ControlChars.NewLine &
            "Email: gJaegers@gmail.com" & ControlChars.NewLine

        For shoIndex As Short = 1 To 10
            strReceipt = ""
            If g_strItems(shoIndex, 2) <> "0" Then
                strReceipt = g_strItems(shoIndex, 2) & Space(4) &
                    g_strItems(shoIndex, 0) & Space(4) &
                    g_strItems(shoIndex, 1) & Space(4) &
                    g_strItems(shoIndex, 3) & ControlChars.NewLine
                txtDocument.Text &= strReceipt
            End If
        Next shoIndex
        strReceipt = "=======================" & ControlChars.NewLine &
            "Net:      " & FormatCurrency(g_decNetSale) & ControlChars.NewLine &
            "Sculptor Tax:" & FormatCurrency(g_decSculptor) & ControlChars.NewLine &
            "Tax:" & FormatCurrency(g_decStateTax) & ControlChars.NewLine &
            "==========================" & ControlChars.NewLine &
            "Total:    " & FormatCurrency(g_decGrossSale) & ControlChars.NewLine &
            "Paid :    " & FormatCurrency(g_decTendered) & ControlChars.NewLine &
            "Change:   " & FormatCurrency(g_decChange) & ControlChars.NewLine
        txtDocument.Text &= strReceipt

        txtDocument.Text &= ControlChars.NewLine & Format(Now, "dddd MMMM dd, yyyy hh:mm:ss tt")
    End Sub
    '=============================================================
    ' PrintPage is the foundational printing event. This event gets fired for every 
    ' page that will be printed. You could also handle the BeginPrint and EndPrint
    ' events for more control.
    ' 
    ' The following is very 
    ' fast and useful for plain text as MeasureString calculates the text that
    ' can be fitted on an entire page. This is not that useful, however, for 
    ' formatted text. In that case you would want to have word-level (vs page-level)
    ' control, which is more complicated.
    Private Sub pdoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdoc.PrintPage
        ' Declare a variable to hold the position of the last printed char. Declare
        ' as static so that subsequent PrintPage events can reference it.
        Static intCurrentChar As Int32
        ' Initialize the font to be used for printing.
        Dim font As New Font("Microsoft Sans Serif", 12)

        Dim intPrintAreaHeight, intPrintAreaWidth, marginLeft, marginTop As Int32
        With pdoc.DefaultPageSettings
            ' Initialize local variables that contain the bounds of the printing 
            ' area rectangle.
            intPrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            intPrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right

            ' Initialize local variables to hold margin values that will serve
            ' as the X and Y coordinates for the upper left corner of the printing 
            ' area rectangle.
            marginLeft = .Margins.Left ' X coordinate
            marginTop = .Margins.Top ' Y coordinate
        End With

        ' If the user selected Landscape mode, swap the printing area height 
        ' and width.
        If pdoc.DefaultPageSettings.Landscape Then
            Dim intTemp As Int32
            intTemp = intPrintAreaHeight
            intPrintAreaHeight = intPrintAreaWidth
            intPrintAreaWidth = intTemp
        End If

        ' Calculate the total number of lines in the document based on the height of
        ' the printing area and the height of the font.
        Dim intLineCount As Int32 = CInt(intPrintAreaHeight / font.Height)
        ' Initialize the rectangle structure that defines the printing area.
        Dim rectPrintingArea As New RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight)

        ' Instantiate the StringFormat class, which encapsulates text layout 
        ' information (such as alignment and line spacing), display manipulations 
        ' (such as ellipsis insertion and national digit substitution) and OpenType 
        ' features. Use of StringFormat causes MeasureString and DrawString to use
        ' only an integer number of lines when printing each page, ignoring partial
        ' lines that would otherwise likely be printed if the number of lines per 
        ' page do not divide up cleanly for each page (which is usually the case).
        ' See further discussion in the SDK documentation about StringFormatFlags.
        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)
        ' Call MeasureString to determine the number of characters that will fit in
        ' the printing area rectangle. The CharFitted Int32 is passed ByRef and used
        ' later when calculating intCurrentChar and thus HasMorePages. LinesFilled 
        ' is not needed for this sample but must be passed when passing CharsFitted.
        ' Mid is used to pass the segment of remaining text left off from the 
        ' previous page of printing (recall that intCurrentChar was declared as 
        ' static.
        Dim intLinesFilled, intCharsFitted As Int32
        e.Graphics.MeasureString(Mid(txtDocument.Text, intCurrentChar + 1), font,
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), fmt,
                    intCharsFitted, intLinesFilled)

        ' Print the text to the page.
        e.Graphics.DrawString(Mid(txtDocument.Text, intCurrentChar + 1), font,
            Brushes.Black, rectPrintingArea, fmt)

        ' Advance the current char to the last char printed on this page. As 
        ' intCurrentChar is a static variable, its value can be used for the next
        ' page to be printed. It is advanced by 1 and passed to Mid() to print the
        ' next page (see above in MeasureString()).
        intCurrentChar += intCharsFitted

        ' HasMorePages tells the printing module whether another PrintPage event
        ' should be fired.
        If intCurrentChar < txtDocument.Text.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            ' You must explicitly reset intCurrentChar as it is static.
            intCurrentChar = 0
        End If
    End Sub
    '=============================================================
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call frmPOS.btnClear_Click(sender, e)
        Call modMain.InitializeitemArray()
        Me.Close()
        frmPOS.Show()
    End Sub
End Class
