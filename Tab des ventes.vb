Public Class Tab
    Private Sub cb_produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_produit.SelectedIndexChanged
        Dim P As Double
        If (cb_produit.SelectedItem = "Clavier") Then
            P = 31.55
        ElseIf (cb_produit.SelectedItem = "Casque") Then
            P = 45.75
        ElseIf (cb_produit.SelectedItem = "Souris") Then
            P = 25.75
        ElseIf (cb_produit.SelectedItem = "Web-Cam") Then
            P = 61.35
        ElseIf (cb_produit.SelectedItem = "Pc") Then
            P = 1275.5
        End If
        txt_pu.Text = P
    End Sub
    Private Sub cb_qte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_qte.SelectedIndexChanged
        txt_mtht.Text = txt_pu.Text * cb_qte.SelectedItem
    End Sub
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        If (cb_produit.SelectedIndex = -1) Then
            MsgBox("      Ajouter un Produit ")
        Else
            lst_produit.Items.Add(cb_produit.Text)
            lst_pu.Items.Add(txt_pu.Text)
            lst_qte.Items.Add(cb_qte.Text)
            lst_mtht.Items.Add(txt_mtht.Text)
            videe()
            suppa()
            Dim s, ss, sss As Double
            For Each x As Double In lst_mtht.Items
                sss = sss + x
            Next
            txt_totmtht.Text = sss
            For Each x As Double In lst_qte.Items
                ss = ss + x
            Next
            txt_totqte.Text = ss
            For Each x As Double In lst_pu.Items
                s = s + x
            Next
            txt_totpu.Text = s
        End If
    End Sub
    Private Sub btn_vider_Click(sender As Object, e As EventArgs) Handles btn_vider.Click
        suppa()
    End Sub
    Private Sub btn_calculer_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click
        txt_mtht1.Text = txt_totmtht.Text
        Dim remise, tva, apayer As Double
        tva = txt_mtht1.Text * 0.2
        If (txt_mtht1.Text > 1000) Then
            remise = txt_mtht1.Text * 0.01
        Else
            remise = 0
        End If
        apayer = txt_mtht1.Text + tva - remise
        txt_remise.Text = remise
        txt_apayer.Text = apayer
        txt_tva.Text = tva
    End Sub
    Private Sub lst_produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_produit.SelectedIndexChanged
        Dim a As Integer = lst_produit.SelectedIndex
        If lst_produit.SelectedIndex = a Then
            lst_pu.SelectedIndex = a
            lst_qte.SelectedIndex = a
            lst_mtht.SelectedIndex = a
        End If
    End Sub
    Public Sub btn_upprimer_Click(sender As Object, e As EventArgs) Handles btn_upprimer.Click

        If lst_produit.SelectedIndex <> -1 Then
            majour()
            suppboxs()
            videe()
            txt_mtht1.Clear()
        Else
            MsgBox("     Selectionner un produit pour le Supprimer ")
        End If
    End Sub
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        If lst_produit.SelectedIndex <> -1 Then
            cb_produit.Text = lst_produit.SelectedItem
            txt_pu.Text = lst_pu.SelectedItem
            cb_qte.Text = lst_qte.SelectedItem
            txt_mtht.Text = lst_mtht.SelectedItem
            txt_mtht1.Clear()
            majour()
            suppboxs()
            videe()
        Else
            MsgBox("     Selectionner un produit pour le Modifier ")
        End If
    End Sub
    Private Sub btn_Quitter_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        Me.Close()
    End Sub
    Public Sub suppboxs()
        Dim a As Integer = lst_produit.SelectedIndex
        lst_produit.Items.RemoveAt(a)
        lst_pu.Items.RemoveAt(a)
        lst_qte.Items.RemoveAt(a)
        lst_mtht.Items.RemoveAt(a)
    End Sub
    Public Sub suppa()
        txt_mtht.Clear()
        txt_pu.Clear()
        cb_produit.SelectedIndex = -1
        cb_qte.SelectedIndex = -1
    End Sub
    Public Sub videe()
        txt_remise.Clear()
        txt_tva.Clear()
        txt_apayer.Clear()
    End Sub
    Public Sub majour()
        Dim a As Integer = lst_produit.SelectedIndex
        txt_totmtht.Text = txt_totmtht.Text - lst_mtht.SelectedItem
        txt_totpu.Text = txt_totpu.Text - lst_pu.SelectedItem
        txt_totqte.Text = txt_totqte.Text - lst_qte.SelectedItem
    End Sub
End Class