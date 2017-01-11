Imports System.IO

Class MainWindow
    Dim databaseContext As New DataClasses1DataContext
    Dim ViewerViewSource As System.Windows.Data.CollectionViewSource
    Dim ImagePath As String = System.AppDomain.CurrentDomain.BaseDirectory & "\Songs\" 'create a physical folder

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded

        Dim TableViewSource As System.Windows.Data.CollectionViewSource = CType(Me.FindResource("TableViewSource"), System.Windows.Data.CollectionViewSource)
        'set the CollectionViewSource.Source to load data
    End Sub


    Private Sub RemoveImagesFromDBAndFileLocation(ByVal removeFileName As String)
        Dim simpleFileName As String = Path.GetFileName(removeFileName)

        'remove item
        Dim deleteItem = From photos In databaseContext.Tables Where photos.path = removeFileName Select photos

        'proceed with deleting
        For Each detail As Table In deleteItem
            databaseContext.Tables.DeleteOnSubmit(detail)
        Next
        databaseContext.SubmitChanges()

        'Reload the listbox
        LoadImagesFromDatabase()

    End Sub

    Private Sub btnMp3_Click(sender As Object, e As RoutedEventArgs) Handles btnMp3.Click
        Dim frm As Form1 = New Form1()
        frm.ShowDialog()
    End Sub


    Private Sub LoadImagesFromDatabase()
        'place ViewerViewsource into CollectionViewSource
        ViewerViewSource = CType(Me.FindResource("TableViewSource"), System.Windows.Data.CollectionViewSource)
        'query all images
        Dim photosQuery = From TMA2MediaPlayer In databaseContext.Tables Select TMA2MediaPlayer
        'load data 
        ViewerViewSource.Source = photosQuery

    End Sub

    Private Sub SaveImagesToDBAndFileLocation(ByVal dlgFileName As String)
        Dim simpleFileName As String = Path.GetFileName(dlgFileName)

        'Add the path into database (use LINQ
        Dim newImage As New Table()
        newImage.title = simpleFileName.Substring(0, simpleFileName.Length - 4)
        newImage.path = simpleFileName
        databaseContext.Tables.InsertOnSubmit(newImage)
        databaseContext.SubmitChanges()

        'Adds the physical file into the image file
        file.Copy(dlgFileName, ImagePath & simpleFileName, True)

        'Reload listbox
        LoadImagesFromDatabase()

    End Sub

    

    Private Sub btnAdd_Click(sender As Object, e As RoutedEventArgs) Handles btnAdd.Click
        'Creates OpenFileDialog
        Dim dlg As New Microsoft.Win32.OpenFileDialog()
        'Set filter for the file extensions
        dlg.Filter = "All files (*.*|*.*"

        'Display OpenFileDialog 
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        'Get the selected file and show in the ListBox
        If result = True Then
            SaveImagesToDBAndFileLocation(dlg.FileName)
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As RoutedEventArgs) Handles btnDelete.Click
        RemoveImagesFromDBAndFileLocation(Lstboxmain.SelectedValue.ToString())
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As RoutedEventArgs) Handles btnUpdate.Click
        databaseContext.SubmitChanges()
    End Sub
   
End Class
