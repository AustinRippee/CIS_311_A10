'------------------------------------------------------------
'-                File Name : myClock.vb                     - 
'-                Part of Project: Main                  -
'------------------------------------------------------------
'-                Written By: Austin Rippee                     -
'-                Written On: April 12th, 2022         -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application form where the
'- user can see the control first hand.
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program creates a painter to display a running clock
'- of the current time.
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'- CurrentForeColor - Sets the text color to black
'- myBrush - Creates the brush with the color black
'- TextFont - Sets the font to the value
'------------------------------------------------------------
Public Class myClock
    'Initializes global variables
    Dim TextFont As New Font("Oswald", 12, FontStyle.Bold)
    Dim myBrush As New SolidBrush(Color.Black)
    Dim CurrentForeColor As Color = Color.Black

    Public Overrides Property ForeColor As Color
        Get
            'Returns the current fore color
            Return CurrentForeColor
        End Get
        'Sets the fore color to whatever value it was set to
        Set(value As Color)
            CurrentForeColor = value
            'Force a re-paint (Forces it to update the foreground color)
            Me.Invalidate()
        End Set
    End Property
    '------------------------------------------------------------
    '-                Subprogram Name: Timer1_Tick            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: April 12th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the timer ticks causing
    '– it to be refreshed and thus running the sub.
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Tells the control to refresh itself
        Me.Refresh()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: OnPaint            -
    '------------------------------------------------------------
    '-                Written By: Austin Rippee                     -
    '-                Written On: April 12th, 2022         -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the program draws the
    '- clock on the canvas so it can actually be visible.
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- e – Holds the PaintEventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- myGfx - creates the graphics                             
    '------------------------------------------------------------
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        'Initializes graphics class to draw the object
        Dim myGfx As Graphics = e.Graphics
        'Sets the currentforecolor to the brush color
        myBrush.Color = CurrentForeColor
        'Prints the value of the system datetimenow with TextFont with myBrush to the canvas
        myGfx.DrawString(DateTime.Now.ToLongTimeString, TextFont, myBrush, 10, 10)
    End Sub
End Class
