Public Class UserControl1

    Dim databaseContext As New DataClasses1DataContext
    Dim ViewerViewSource As System.Windows.Data.CollectionViewSource
    Dim mplayer As MediaPlayer = New MediaPlayer
    'Full path to the image
    Dim ImagePath As String = System.AppDomain.CurrentDomain.BaseDirectory & "\Songs\"

    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded
        LoadImagesFromDatabase()
        Dim ViewerViewSource As System.Windows.Data.CollectionViewSource = CType(Me.FindResource("TableViewSource"), System.Windows.Data.CollectionViewSource)
        'Do not load your data at design time.
        'If Not (System.ComponentModel.DesignerProperties.GetIsInDesignMode(Me)) Then
        '	'Load your data here and assign the result to the CollectionViewSource.
        '	Dim myCollectionViewSource As System.Windows.Data.CollectionViewSource = CType(Me.Resources("Resource Key for CollectionViewSource"), System.Windows.Data.CollectionViewSource)
        '	myCollectionViewSource.Source = your data
        'End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As RoutedEventArgs) Handles btnPlay.Click
        Display(ImagePath & lstBoxUser.SelectedValue)
    End Sub

    Private Sub LoadImagesFromDatabase()
        'place ViewerViewsource into CollectionViewSource
        ViewerViewSource = CType(Me.FindResource("TableViewSource"), System.Windows.Data.CollectionViewSource)
        'query all images
        Dim photoQuery = From photos In databaseContext.Tables Select photos
        'load data 
        ViewerViewSource.Source = photoQuery
    End Sub

    Private Sub Display(ByVal p1 As Object)
        mplayer.Stop()
        mplayer.Open(New Uri(p1, UriKind.Relative))
        mplayer.Play()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As RoutedEventArgs) Handles btnNext.Click
        If mplayer.Position.TotalSeconds <> 0 Then
            lstBoxUser.Items.MoveCurrentToNext()
            Display(ImagePath & lstBoxUser.SelectedValue)
        End If
    End Sub
End Class
