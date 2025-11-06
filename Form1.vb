Public Class Form1
    ' defini iun structure etudiante 
    Structure Etudiant
        Dim Nom As String
        Dim Prenom As String
        Dim Note As Double
    End Structure

    ' Tableau pour 3 étudiants : 
    Dim etudiants(2) As Etudiant '2 car automatiquement bourn inf est 0 si ma7atithech inti 
    Dim index As Integer = 0 ' pour calcul le nb des etudiant saisi 

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        If index > 2 Then
            MessageBox.Show("Vous avez déjà saisi les 3 étudiants!!")
            Exit Sub
        End If


        Dim noteTemp As Double
        If Not Double.TryParse(txtnote.Text, noteTemp) Then '' Vérifier la validité de la note
            MessageBox.Show("Veuillez entrer une note valide.")
            Exit Sub
        End If


        etudiants(index).Nom = txtnom.Text
        etudiants(index).Prenom = txtprenom.Text
        etudiants(index).Note = noteTemp
        index += 1

        MessageBox.Show("Étudiant ajouté avec succès !")

    End Sub

    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        If index = 0 Then
            MessageBox.Show("Aucun étudiant enregistré.")
            Exit Sub
        End If

        ' Calcul du meilleur et de la moyenne :
        Dim meilleur As Etudiant = etudiants(0)
        Dim somme As Double = 0

        For i As Integer = 0 To index - 1
            somme += etudiants(i).Note
            If etudiants(i).Note > meilleur.Note Then
                meilleur = etudiants(i)
            End If
        Next

        Dim moyenne As Double = somme / index

        ' Affichage dans les labels :
        millieur.Text = "Meilleur étudiant : " & meilleur.Nom & " (" & meilleur.Note & ")"
        moyen.Text = "Moyenne générale : " & moyenne.ToString("0.00")
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        txtnom.Clear()
        txtprenom.Clear()
        txtnote.Clear()
        txtnom.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
