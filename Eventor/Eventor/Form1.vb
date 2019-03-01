Imports Microsoft.Win32

Public Class Form1
    Private Event Appexit2()
    Public Sub New()
        AddHandler Application.ApplicationExit, AddressOf AppExit
        AddHandler Microsoft.Win32.SystemEvents.SessionEnding, AddressOf Eventori
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub
#Region "durch herunterfahren des Systems"
    Private Sub Eventori(sender As Object, e As SessionEndingEventArgs)
        MsgBox("herunterfahren des systems")
    End Sub

    Private Sub AppExit()
        'Closing by pressing the X
        Debug.Print("Programm wurde vom Nutzer mit klick auf Y geschlossen")
    End Sub

#End Region

#Region "eigenes Event"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent Appexit2() 'auslösen des Events
        Application.Exit() 'beenden des Programmes. Löst seltsamerweise nicht das Standardevent aus
    End Sub

    Private Sub Appexit2_Handler() Handles Me.Appexit2 'Handler für das Event
        MsgBox("Beenden durch einen anderen Knopf")
    End Sub


#End Region
End Class