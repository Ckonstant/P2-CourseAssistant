Public Class PanelEx
    Inherits Panel

    Public Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        If Not BackgroundImage Is Nothing Then
            If BackgroundImageLayout = ImageLayout.Tile Then

                Dim x As Integer, y As Integer
                While x <= DisplayRectangle.Width
                    y = 0
                    While y <= DisplayRectangle.Height
                        e.Graphics.DrawImage(
                            BackgroundImage,
                            New Point(x - HorizontalScroll.Value,
                                      y - VerticalScroll.Value))
                        y += BackgroundImage.Height
                    End While
                    x += BackgroundImage.Width
                End While
            Else
                e.Graphics.DrawImage(BackgroundImage,
                                     New Point(-HorizontalScroll.Value,
                                               -VerticalScroll.Value))
            End If
        Else
            MyBase.OnPaintBackground(e)
        End If
    End Sub
End Class
