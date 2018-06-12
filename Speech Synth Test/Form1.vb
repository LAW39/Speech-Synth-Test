Public Class Form1
    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click

        Dim name As String                                      'Initialises variables
        Dim sentence As String
        Dim StrPhrase As String
        Dim ObjSpeech As Object
        Dim intPitch As Integer

        name = (InputBox("Please enter your name"))             'Inputs name

        If (name) = ("") Then                                   'If name is blank say don't know else state name
            sentence = ("I don't know your name")
        Else
            sentence = ("Your name is " & name)
        End If


        MsgBox(sentence)                                        'State sentence to be spoken

        ObjSpeech = (CreateObject("SAPI.SpVoice"))              'Speech Code
        StrPhrase = (sentence)
        ObjSpeech.Speak("<pitch middle = '" & intPitch & "'/>" + StrPhrase)

    End Sub
End Class
