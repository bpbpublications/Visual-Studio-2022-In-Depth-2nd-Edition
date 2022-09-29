Imports System.Math
Public Class Form1

    Private Const intLeaves As Integer = 18
    Private arrColors(intLeaves - 1) As Color

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Const dbMinHeight As Double = -11
        Const dbMaxHeight As Double = 11

        Const dbTotalHeight As Double = dbMaxHeight - dbMinHeight

        Dim dbTotalWidth As Double = dbTotalHeight * Me.ClientSize.Width / Me.ClientSize.Height

        Dim dbMiddle As Double = Me.ClientSize.Height / dbTotalHeight

        e.Graphics.ScaleTransform(dbMiddle, dbMiddle)
        e.Graphics.TranslateTransform(dbTotalWidth / 2, -dbMinHeight)

        Const PI As Double = 3.14159265
        Const lngLines As Long = 7500

        Dim i As Long
        Dim a
        Dim b As Double
        Dim ptOne As PointF
        Dim ptTwo As PointF

        a = 0
        ptTwo = New PointF(b * Sin(a), -b * Cos(a))

        Dim pPen As New Pen(Color.Blue, 0)

        For i = 0 To lngLines
            a = i * intLeaves * PI / lngLines

            b = 7 * (1 + Sin(11 * a / 5)) - 4 * Sin(30 * a / 3) ^ 4 * Sin(2 * Cos(3 * a) - 14 * a) ^ 6
            ptOne = ptTwo

            ptTwo = New PointF(b * Sin(a), -b * Cos(a))

            pPen.Color = GetNewColour(a)

            e.Graphics.DrawLine(pPen, ptOne, ptTwo)

        Next i

        pPen.Dispose()

    End Sub

    Private Function GetNewColour(c As Double) As Color

        Return arrColors(Int(c / PI))

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SetStyle(
            ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.DoubleBuffer Or
            ControlStyles.ResizeRedraw,
            True)

        Me.UpdateStyles()

        Me.BackColor = Color.Black

        arrColors = New Color() {
        Color.DarkMagenta,
        Color.Brown,
        Color.Orange,
        Color.SeaShell,
        Color.Beige,
        Color.Aquamarine,
        Color.DodgerBlue,
        Color.Purple,
        Color.Fuchsia,
        Color.Red,
        Color.Chocolate,
        Color.White,
        Color.DarkGreen,
        Color.Gold,
        Color.Blue,
        Color.Violet,
        Color.Pink,
        Color.MistyRose,
        Color.Orange,
        Color.Yellow,
        Color.Chartreuse,
        Color.Teal,
        Color.SkyBlue,
        Color.MediumOrchid
        }


    End Sub
End Class
