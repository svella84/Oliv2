﻿Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Collections

Public Class PrintDGV
    Private Shared StrFormat As StringFormat         ' Holds content of a TextBox Cell to write by DrawString
    Private Shared StrFormatComboBox As StringFormat ' Holds content of a Boolean Cell to write by DrawImage
    Private Shared CellButton As Button          ' Holds the Contents of Button Cell
    Private Shared CellCheckBox As CheckBox      ' Holds the Contents of CheckBox Cell
    Private Shared CellComboBox As ComboBox      ' Holds the Contents of ComboBox Cell

    Private Shared TotalWidth As Int16           ' Summation of Columns widths
    Private Shared RowPos As Int16               ' Position of currently printing row 
    Private Shared NewPage As Boolean            ' Indicates if a new page reached 
    Private Shared PageNo As Int16               ' Number of pages to print 
    Private Shared ColumnLefts As New ArrayList  ' Left Coordinate of Columns
    Private Shared ColumnWidths As New ArrayList ' Width of Columns
    Private Shared ColumnTypes As New ArrayList  ' DataType of Columns
    Private Shared CellHeight As Int16           ' Height of DataGrid Cell
    Private Shared RowsPerPage As Int16          ' Number of Rows per Page 
    Private Shared WithEvents PrintDoc As New System.Drawing.Printing.PrintDocument ' PrintDocumnet Object used for printing

    Private Shared PrintTitle As String = ""               ' Header of pages
    Private Shared dgv As DataGridView                     ' Holds DataGrid Object to print its contents
    Private Shared SelectedColumns As New List(Of String)  ' The Columns Selected by user to print.
    Private Shared AvailableColumns As New List(Of String) ' All Columns avaiable in DataGrid   
    Private Shared PrintAllRows As Boolean = True          ' True = print all rows,  False = print selected rows    
    Private Shared FitToPageWidth As Boolean = True        ' True = Fits selected columns to page width ,  False = Print columns as showed 
    Private Shared PageLandscape As Boolean = True         ' True = page landscape ,  False = page portrait 
    Private Shared HeaderHeight As Int16 = 0

    Public Shared Sub Print_DataGridView(ByVal dgv1 As DataGridView)
        Dim ppvw As PrintPreviewDialog

        Try
            ' Getting DataGridView object to print
            dgv = dgv1

            ' Getting all Coulmns Names in the DataGridView
            AvailableColumns.Clear()
            For Each c As DataGridViewColumn In dgv.Columns
                If Not c.Visible Then Continue For
                AvailableColumns.Add(c.HeaderText)
            Next

            ' Showing the PrintOption Form
            Dim dlg As New PrintOptions(AvailableColumns)
            If dlg.ShowDialog() <> DialogResult.OK Then Exit Sub

            ' Saving some printing attributes
            PrintTitle = dlg.PrintTitle
            PrintAllRows = dlg.PrintAllRows
            FitToPageWidth = dlg.FitToPageWidth
            PageLandscape = dlg.PageLandscape
            SelectedColumns = dlg.GetSelectedColumns

            RowsPerPage = 0
            ppvw = New PrintPreviewDialog

            If PageLandscape Then
                PrintDoc.DefaultPageSettings.Landscape = True
            Else
                PrintDoc.DefaultPageSettings.Landscape = False
            End If

            ppvw.Document = PrintDoc

            ' Showing the Print Preview Page
            If ppvw.ShowDialog() <> DialogResult.OK Then Exit Sub
            ' Printing the Documnet
            PrintDoc.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Shared Sub PrintDoc_BeginPrint(ByVal sender As Object, _
                ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDoc.BeginPrint
        Try
            ' Formatting the Content of Text Cells to print
            StrFormat = New StringFormat
            StrFormat.Alignment = StringAlignment.Center
            StrFormat.LineAlignment = StringAlignment.Center
            StrFormat.Trimming = StringTrimming.EllipsisCharacter

            ' Formatting the Content of Combo Cells to print
            StrFormatComboBox = New StringFormat
            StrFormatComboBox.LineAlignment = StringAlignment.Center
            StrFormatComboBox.FormatFlags = StringFormatFlags.NoWrap
            StrFormatComboBox.Trimming = StringTrimming.EllipsisCharacter

            ColumnLefts.Clear()
            ColumnWidths.Clear()
            ColumnTypes.Clear()
            CellHeight = 0
            RowsPerPage = 0

            ' For various column types
            CellButton = New Button
            CellCheckBox = New CheckBox
            CellComboBox = New ComboBox

            TotalWidth = 0
            For Each GridCol As DataGridViewColumn In dgv.Columns
                If Not GridCol.Visible Then Continue For
                If Not SelectedColumns.Contains(GridCol.HeaderText) Then Continue For
                TotalWidth += GridCol.Width
            Next
            PageNo = 1
            NewPage = True
            RowPos = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Shared Sub PrintDoc_PrintPage(ByVal sender As Object, _
            ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        Dim tmpWidth As Int16, i As Int16
        Dim tmpTop As Int16 = e.MarginBounds.Top
        Dim tmpLeft As Int16 = 35

        Try
            ' Before starting first page, it saves Width & Height of Headers and CoulmnType
            If PageNo = 1 Then
                For Each GridCol As DataGridViewColumn In dgv.Columns
                    If Not GridCol.Visible Then Continue For
                    If Not SelectedColumns.Contains(GridCol.HeaderText) Then
                        Continue For
                    End If

                    ' Detemining whether the columns are fitted to page or not.
                    If FitToPageWidth Then
                        tmpWidth = CType(Math.Floor(GridCol.Width / TotalWidth * _
                                   TotalWidth * (e.MarginBounds.Width / TotalWidth) + 14), Int16)
                    Else
                        tmpWidth = GridCol.Width + 12
                    End If


                    HeaderHeight = e.Graphics.MeasureString(GridCol.HeaderText, _
                                   GridCol.InheritedStyle.Font, tmpWidth).Height + 25

                    ColumnLefts.Add(tmpLeft)
                    ColumnWidths.Add(tmpWidth)
                    ColumnTypes.Add(GridCol.GetType)
                    tmpLeft += tmpWidth
                Next
            End If

            ' Printing Current Page, Row by Row
            Do While RowPos <= dgv.Rows.Count - 1
                Dim GridRow As DataGridViewRow = dgv.Rows(RowPos)
                If GridRow.IsNewRow OrElse (Not PrintAllRows AndAlso Not GridRow.Selected) Then
                    RowPos += 1 : Continue Do
                End If

                CellHeight = GridRow.Height + 15 'Larghezza della cella

                If tmpTop + CellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    DrawFooter(e, RowsPerPage)
                    NewPage = True
                    PageNo += 1
                    e.HasMorePages = True
                    Exit Sub
                Else
                    If NewPage Then

                        Dim drawFont As New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                        ' Draw Header
                        e.Graphics.DrawString(PrintTitle, drawFont, _
                                Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - _
                        e.Graphics.MeasureString(PrintTitle, drawFont, e.MarginBounds.Width).Height - 20)

                        Dim s As String = Now.ToLongDateString + " " + Now.ToShortTimeString

                        e.Graphics.DrawString(s, drawFont, _
                           Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - _
                           e.Graphics.MeasureString(s, drawFont, _
                           e.MarginBounds.Width).Width), e.MarginBounds.Top - _
                           e.Graphics.MeasureString(PrintTitle, drawFont, _
                           e.MarginBounds.Width).Height - 20)

                        ' Draw Columns
                        tmpTop = e.MarginBounds.Top
                        i = 0
                        For Each GridCol As DataGridViewColumn In dgv.Columns
                            If Not GridCol.Visible Then Continue For
                            If Not SelectedColumns.Contains(GridCol.HeaderText) Then
                                Continue For
                            End If

                            e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGreen), _
                                    New Rectangle(ColumnLefts(i), tmpTop, ColumnWidths(i), HeaderHeight))

                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(ColumnLefts(i), _
                                    tmpTop, ColumnWidths(i), HeaderHeight))

                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, _
                                    New SolidBrush(GridCol.InheritedStyle.ForeColor), _
                                    New RectangleF(ColumnLefts(i), tmpTop, ColumnWidths(i), _
                                    HeaderHeight), StrFormat)
                            i += 1
                        Next
                        NewPage = False

                        tmpTop += HeaderHeight
                    End If

                    i = 0
                    For Each Cel As DataGridViewCell In GridRow.Cells
                        If Not Cel.OwningColumn.Visible Then Continue For
                        If Not SelectedColumns.Contains(Cel.OwningColumn.HeaderText) Then
                            Continue For
                        End If

                        ' For the TextBox Column
                        If ColumnTypes(i) Is GetType(DataGridViewTextBoxColumn) OrElse _
                           ColumnTypes(i) Is GetType(DataGridViewLinkColumn) Then

                            e.Graphics.DrawString(Cel.Value.ToString, Cel.InheritedStyle.Font, _
                                    New SolidBrush(Cel.InheritedStyle.ForeColor), _
                                    New RectangleF(ColumnLefts(i), tmpTop, ColumnWidths(i), _
                                    CellHeight), StrFormat)

                            ' For the Button Column
                        ElseIf ColumnTypes(i) Is GetType(DataGridViewButtonColumn) Then

                            CellButton.Text = Cel.Value.ToString
                            CellButton.Size = New Size(ColumnWidths(i), CellHeight)
                            Dim bmp As New Bitmap(CellButton.Width, CellButton.Height)
                            CellButton.DrawToBitmap(bmp, New Rectangle(0, 0, _
                                    bmp.Width, bmp.Height))
                            e.Graphics.DrawImage(bmp, New Point(ColumnLefts(i), tmpTop))

                            ' For the CheckBox Column
                        ElseIf ColumnTypes(i) Is GetType(DataGridViewCheckBoxColumn) Then

                            CellCheckBox.Size = New Size(14, 14)
                            CellCheckBox.Checked = CType(Cel.Value, Boolean)
                            Dim bmp As New Bitmap(ColumnWidths(i), CellHeight)
                            Dim tmpGraphics As Graphics = Graphics.FromImage(bmp)
                            tmpGraphics.FillRectangle(Brushes.White, New Rectangle(0, 0, _
                                    bmp.Width, bmp.Height))
                            CellCheckBox.DrawToBitmap(bmp, New Rectangle(CType((bmp.Width - _
                                    CellCheckBox.Width) / 2, Int32), CType((bmp.Height - _
                                    CellCheckBox.Height) / 2, Int32), CellCheckBox.Width, _
                                    CellCheckBox.Height))
                            e.Graphics.DrawImage(bmp, New Point(ColumnLefts(i), tmpTop))

                            ' For the ComboBox Column
                        ElseIf ColumnTypes(i) Is GetType(DataGridViewComboBoxColumn) Then

                            CellComboBox.Size = New Size(ColumnWidths(i), CellHeight)
                            Dim bmp As New Bitmap(CellComboBox.Width, CellComboBox.Height)
                            CellComboBox.DrawToBitmap(bmp, New Rectangle(0, 0, _
                                    bmp.Width, bmp.Height))
                            e.Graphics.DrawImage(bmp, New Point(ColumnLefts(i), tmpTop))
                            e.Graphics.DrawString(Cel.Value.ToString, Cel.InheritedStyle.Font, _
                                    New SolidBrush(Cel.InheritedStyle.ForeColor), _
                                    New RectangleF(ColumnLefts(i) + 1, tmpTop, ColumnWidths(i) _
                                    - 16, CellHeight), StrFormatComboBox)

                            ' For the Image Column
                        ElseIf ColumnTypes(i) Is GetType(DataGridViewImageColumn) Then

                            Dim CelSize As Rectangle = New Rectangle(ColumnLefts(i), _
                                    tmpTop, ColumnWidths(i), CellHeight)
                            Dim ImgSize As Size = CType(Cel.FormattedValue, Image).Size
                            e.Graphics.DrawImage(Cel.FormattedValue, New Rectangle(ColumnLefts(i) _
                                    + CType(((CelSize.Width - ImgSize.Width) / 2), Int32), _
                                    tmpTop + CType(((CelSize.Height - ImgSize.Height) / 2),  _
                                    Int32), CType(Cel.FormattedValue, Image).Width, CType(Cel.FormattedValue,  _
                                    Image).Height))

                        End If

                        ' Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(ColumnLefts(i), _
                                tmpTop, ColumnWidths(i), CellHeight))

                        i += 1

                    Next
                    tmpTop += CellHeight

                End If

                RowPos += 1
                ' For the first page it calculates Rows per Page
                If PageNo = 1 Then
                    RowsPerPage += 1
                End If
            Loop

            If RowsPerPage = 0 Then Exit Sub

            ' Write Footer (Page Number)
            DrawFooter(e, RowsPerPage)

            e.HasMorePages = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub

    Private Shared Sub DrawFooter(ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByVal RowsPerPage As Int32)
        Dim cnt As Integer

        ' Detemining rows number to print
        If PrintAllRows Then
            If dgv.Rows(dgv.Rows.Count - 1).IsNewRow Then
                ' When the DataGridView doesn't allow adding rows
                cnt = dgv.Rows.Count - 2
            Else
                ' When the DataGridView allows adding rows
                cnt = dgv.Rows.Count - 1
            End If
        Else
            cnt = dgv.SelectedRows.Count
        End If

        Dim drawFont As New Font("Microsoft Sans Serif", 10)

        ' Writing the Page Number on the Bottom of Page
        Dim PageNum As String = PageNo.ToString + " of " + _
                    Math.Ceiling(cnt / RowsPerPage).ToString
        e.Graphics.DrawString(PageNum, drawFont, Brushes.Black, _
                    e.MarginBounds.Left + (e.MarginBounds.Width - _
                    e.Graphics.MeasureString(PageNum, drawFont, _
                    e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top + _
                    e.MarginBounds.Height + 31)

    End Sub

End Class
