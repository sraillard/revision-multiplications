Imports System.Windows.Forms

Public Class EcranPrincipal

    ' Stockage liste
    Public Liste() As String = {}
    ' Random
    Public r As Random
    ' Index question
    Public Index As Integer = 0
    ' Question
    Public a, b As Integer
    ' Erreurs
    Public NbErreurs As Integer = 0
    ' Temps total
    Public TempsTotal As Integer = 0
    ' Mesure temps
    Public tsDebut, tsFin As DateTime

    Private Sub EcranPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Création liste
        Dim x, y, n As Integer
        Liste = {}
        For x = 1 To 9
            For y = 1 To 9
                If y <= x Then
                    Array.Resize(Liste, Liste.Count + 1)
                    Liste(Liste.Count - 1) = x.ToString + "," + y.ToString
                End If
            Next
        Next

        ' Random liste
        r = New Random(My.Computer.Clock.TickCount)
        Dim i, j As Integer
        For i = 0 To Liste.Count - 1
            j = r.Next(i, Liste.Count - 1)
            Dim s As String = Liste(i)
            Liste(i) = Liste(j)
            Liste(j) = s
        Next

        ' Message démarrage
        MessageBox.Show("Cliquez sur OK pour commencer !", "Démarrage", MessageBoxButtons.OK)

        ' Première question
        Index = 0
        NbErreurs = 0
        TempsTotal = 0
        AffichageQuestion()

    End Sub

    Public Sub AffichageQuestion()
        ' Préparation question
        Dim s As String = Liste(Index)
        Dim Tokens() As String = s.Split(","c)
        If r.Next(1, 2) = 2 Then
            a = CInt(Tokens(0))
            b = CInt(Tokens(1))
        Else
            a = CInt(Tokens(1))
            b = CInt(Tokens(0))
        End If
        ' Affichage
        lQuestion.Text = a.ToString + " x " + b.ToString + " = "
        tbReponse.Text = ""
        tbReponse.Focus()
        ' Question suivante
        Index += 1
        ' Début réponse
        tsDebut = DateTime.Now
    End Sub

    Private Sub tbReponse_KeyDown(sender As Object, e As KeyEventArgs) Handles tbReponse.KeyDown
        If e.KeyCode = Keys.Enter And tbReponse.Text <> "" Then
            ' Récupération réponse
            Dim Reponse As Integer
            Try
                Reponse = CInt(tbReponse.Text)
            Catch ex As Exception
                Reponse = -1
            End Try
            ' Fin réponse
            tsFin = DateTime.Now
            ' Calcul durée
            TempsTotal += tsFin.Subtract(tsDebut).TotalSeconds
            ' Test résultat
            If a * b <> Reponse Then
                ' Erreur !
                NbErreurs += 1
                MessageBox.Show(a.ToString + "x" + b.ToString + "=" + (a * b).ToString + " et non pas " + Reponse.ToString + " !" + vbCrLf + "Cliquez sur OK pour continuer !", "Erreur", MessageBoxButtons.OK)
            End If
            ' Question suivante ou fin
            If Index <= Liste.Count - 1 Then
                ' Question suivante
                AffichageQuestion()
            Else
                ' Fin
                MessageBox.Show("Le test est fini !", "Fin", MessageBoxButtons.OK)
            End If
            ' Suppression beep
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub tTimer_Tick(sender As Object, e As EventArgs) Handles tTimer.Tick
        lInfos.Text = "Question " + Index.ToString + " sur " + Liste.Count.ToString + " - " + NbErreurs.ToString + " erreurs - Temps total de " + TempsTotal.ToString + " secondes"
    End Sub

End Class