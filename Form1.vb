Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_man_utd.Click
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String
        Dim player4 As String
        Dim player5 As String
        Dim player6 As String
        Dim player7 As String

        player1 = "Cristiano Ronaldo"
        player2 = "Marcus Rashford"
        player3 = "Antony Elanga"
        player4 = "Jadon Sancho"
        player5 = "Jerry Maguire"
        player6 = "David Degea"
        player7 = "Christian Eriksen"

        MessageBox.Show("Players are " & vbNewLine &
                        player1 & vbNewLine &
                        player2 & vbNewLine &
                        player3 & vbNewLine &
                        player4 & vbNewLine &
                        player5 & vbNewLine &
                        player6 & vbNewLine &
                        player7)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_arsenal.Click
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String
        Dim player4 As String
        Dim player5 As String
        Dim player6 As String
        Dim player7 As String

        player1 = "Bukayo Saka"
        player2 = "Gabriel Jesus"
        player3 = "Martin Odeegard"
        player4 = "Musa Saliba"
        player5 = "Granit Xhaka"
        player6 = "Gabriel Martinelli"
        player7 = "Thomas Partey"

        MessageBox.Show("Players are " & vbNewLine &
                        player1 & vbNewLine &
                        player2 & vbNewLine &
                        player3 & vbNewLine &
                        player4 & vbNewLine &
                        player5 & vbNewLine &
                        player6 & vbNewLine &
                        player7)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_chelsea.Click
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String
        Dim player4 As String
        Dim player5 As String
        Dim player6 As String
        Dim player7 As String

        player1 = "Reece James"
        player2 = "Raheem Sterling"
        player3 = "Calum Hudson Odoi"
        player4 = "Christian Pulisic"
        player5 = "Ngolo Kante"
        player6 = "Jorginho"
        player7 = "Eduardo Mendy"

        MessageBox.Show("Players are " & vbNewLine &
                        player1 & vbNewLine &
                        player2 & vbNewLine &
                        player3 & vbNewLine &
                        player4 & vbNewLine &
                        player5 & vbNewLine &
                        player6 & vbNewLine &
                        player7)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_mancity.Click
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String
        Dim player4 As String
        Dim player5 As String
        Dim player6 As String
        Dim player7 As String

        player1 = "Erling Haaland"
        player2 = "John Stones"
        player3 = "Joao Cancelo"
        player4 = "Kyle Walker"
        player5 = "Jack Grealish"
        player6 = "Ikay Gundogan"
        player7 = "Kevin Debruyne"

        MessageBox.Show("Players are " & vbNewLine &
                        player1 & vbNewLine &
                        player2 & vbNewLine &
                        player3 & vbNewLine &
                        player4 & vbNewLine &
                        player5 & vbNewLine &
                        player6 & vbNewLine &
                        player7)

    End Sub

    Private Sub btn_liverpool_Click(sender As Object, e As EventArgs) Handles btn_liverpool.Click
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String
        Dim player4 As String
        Dim player5 As String
        Dim player6 As String
        Dim player7 As String

        player1 = "Mohammed Salah"
        player2 = "Diogo Jota"
        player3 = "Luiz Diaz"
        player4 = "Darwin Nunez"
        player5 = "Thiago Alcantara"
        player6 = "Fabinho"
        player7 = "Allison"

        MessageBox.Show("Players are " & vbNewLine &
                        player1 & vbNewLine &
                        player2 & vbNewLine &
                        player3 & vbNewLine &
                        player4 & vbNewLine &
                        player5 & vbNewLine &
                        player6 & vbNewLine &
                        player7)

    End Sub

    Private Sub lnk_arsenal_next_match_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_arsenal_next_match.LinkClicked
        Dim arsenal_match As Date
        Dim Location As String
        arsenal_match = #01/10/2022#
        Location = "Stamford Bridge"

        MessageBox.Show("Next match Date " & arsenal_match & " against Chelsea" & vbNewLine &
                        "Location: " & Location)
    End Sub

    Private Sub btn_chelsea_next_match_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btn_chelsea_next_match.LinkClicked
        Dim chelsea_match As Date
        Dim Location As String
        chelsea_match = #01/10/2022#
        Location = "Stamford Bridge"

        MessageBox.Show("Next match Date " & chelsea_match & " against Arsenal" & vbNewLine &
                        "Location: " & Location)
    End Sub

    Private Sub lnk_liverpool_next_match_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_liverpool_next_match.LinkClicked
        Dim liverpool_match As Date
        Dim Location As String
        liverpool_match = #04/10/2022#
        Location = "Anfield"

        MessageBox.Show("Next match Date " & liverpool_match & " against Manchester United" & vbNewLine &
                        "Location: " & Location)
    End Sub

    Private Sub lnk_mancity_next_match_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_mancity_next_match.LinkClicked
        Dim mancity_match As Date
        Dim Location As String
        mancity_match = #07/10/2022#
        Location = "Etihad Stadium"

        MessageBox.Show("Next match Date " & mancity_match & " against Tottenham" & vbNewLine &
                        "Location: " & Location)
    End Sub

    Private Sub lnk_manutd_next_match_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_manutd_next_match.LinkClicked
        Dim manutd_match As Date
        Dim Location As String
        manutd_match = #04/10/2022#
        Location = "Anfield"

        MessageBox.Show("Next match Date " & manutd_match & " against Liverpool" & vbNewLine &
                        "Location: " & Location)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_tottenham_next_match.LinkClicked
        Dim tottenham_match As Date
        Dim Location As String

        tottenham_match = #07/10/2022#
        Location = "Etihad Stadium"

        MessageBox.Show("Next Match Date " & tottenham_match & " against Mancity" & vbNewLine &
                        "Location: " & Location)

    End Sub

    Private Sub btn_tottenham_Click(sender As Object, e As EventArgs) Handles btn_tottenham.Click
        Dim player1 As String
        Dim player2 As String
        Dim player3 As String
        Dim player4 As String
        Dim player5 As String
        Dim player6 As String
        Dim player7 As String

        player1 = "Harry Kane"
        player2 = "Heung Min Son"
        player3 = "Kulusevski"
        player4 = "Richarlison"
        player5 = "Hugo Lloris"
        player6 = "Romeo"
        player7 = "Bentacur"
        MessageBox.Show("Players are " & vbNewLine &
                        player1 & vbNewLine &
                        player2 & vbNewLine &
                        player3 & vbNewLine &
                        player4 & vbNewLine &
                        player5 & vbNewLine &
                        player6 & vbNewLine &
                        player7)
    End Sub
End Class
