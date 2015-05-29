Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient

Public Class Oliv

    Private Sub Oliv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DataGridForShow()

    End Sub

#Region "TAB FORNITORI"

    Private Sub DataGridForShow()

        ApriConnessione()

        Dim ds As New DataSet
        Dim dt As New DataTable

        ds.Tables.Add(dt)
        Dim da As New SqlDataAdapter
        stringasql = "SELECT * FROM fornitori"
        da = New SqlDataAdapter(stringasql, connection)
        da.Fill(dt)
        DataGridFornitori.DataSource = dt.DefaultView

        'Imposto i nomi alle etichette delle colonne della DataGrid e la loro larghezza in pixel
        DataGridFornitori.Columns("ID_fornitore").HeaderText = "ID"
        DataGridFornitori.Columns("ID_fornitore").Width = 50
        DataGridFornitori.Columns("intestazione").HeaderText = "Intestazione"
        DataGridFornitori.Columns("intestazione").Width = 125
        DataGridFornitori.Columns("indirizzo").HeaderText = "Indirizzo"
        DataGridFornitori.Columns("indirizzo").Width = 135
        DataGridFornitori.Columns("citta").HeaderText = "Città"
        DataGridFornitori.Columns("citta").Width = 100
        DataGridFornitori.Columns("provincia").HeaderText = "Prov."
        DataGridFornitori.Columns("provincia").Width = 60
        DataGridFornitori.Columns("cap").HeaderText = "CAP"
        DataGridFornitori.Columns("cap").Width = 60
        DataGridFornitori.Columns("tel").HeaderText = "Recapito"
        DataGridFornitori.Columns("tel").Width = 100
        DataGridFornitori.Columns("email").HeaderText = "Email"
        DataGridFornitori.Columns("email").Width = 125

        ChiudiConnessione()

    End Sub

    Private Sub DataGridFornitori_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridFornitori.CellClick

        btnInsertFornitore.Visible = False
        btnReturnFornitore.Visible = True
        btnDeleteFornitore.Enabled = True
        btnModFornitore.Enabled = True

        Me.txtId.Text = DataGridFornitori.CurrentRow.Cells(0).Value().ToString
        Me.txtIntestazione.Text = DataGridFornitori.CurrentRow.Cells(1).Value().ToString
        Me.txtIndirizzo.Text = DataGridFornitori.CurrentRow.Cells(2).Value().ToString
        Me.txtCitta.Text = DataGridFornitori.CurrentRow.Cells(3).Value().ToString
        Me.txtProvincia.Text = DataGridFornitori.CurrentRow.Cells(4).Value().ToString
        Me.txtCap.Text = DataGridFornitori.CurrentRow.Cells(5).Value().ToString
        Me.txtTel.Text = DataGridFornitori.CurrentRow.Cells(6).Value().ToString
        Me.txtEmail.Text = DataGridFornitori.CurrentRow.Cells(7).Value().ToString

        DataGridFornitori.CurrentRow.Selected = True

    End Sub

    Private Sub btnInsertFornitore_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertFornitore.Click

        ApriConnessione()

        If txtIntestazione.Text = "" Then
            MessageBox.Show("Spiacente l'intestazione del fornitore è Obligatoria", "Esito inserimento fornitore", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            stringasql = "INSERT into Fornitori(intestazione, indirizzo, citta, provincia, cap, tel, email) VALUES('"
            stringasql = stringasql & Me.txtIntestazione.Text & "'" & ","
            stringasql = stringasql & "'" & Me.txtIndirizzo.Text & "'" & ","
            stringasql = stringasql & "'" & Me.txtCitta.Text & "'" & ","
            stringasql = stringasql & "'" & Me.txtProvincia.Text & "'" & ","
            stringasql = stringasql & "'" & Me.txtCap.Text & "'" & ","
            stringasql = stringasql & "'" & Me.txtTel.Text & "'" & ","
            stringasql = stringasql & "'" & Me.txtEmail.Text & "'" & ")"
            cmd = New SqlCommand(stringasql, connection)

            Dim risputente As Integer
            Try
                risputente = cmd.ExecuteNonQuery()
                If risputente = 1 Then

                    DataGridForShow()
                    'PopolaComboFornitori()
                    'PopolaComboFornitoriInt()
                    clearFornitore()

                    MessageBox.Show("Inserimento di " & Me.txtIntestazione.Text & " effettuato con successo.", "Esito inserimento fornitore", MessageBoxButtons.OK)

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Errore: Nessun Dato Inserito su fornitori", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ChiudiConnessione()

    End Sub

    Private Sub btnReturnFornitore_Click(sender As System.Object, e As System.EventArgs) Handles btnReturnFornitore.Click

        clearFornitore()

        btnReturnFornitore.Visible = False
        btnInsertFornitore.Visible = True
        btnDeleteFornitore.Enabled = False
        btnModFornitore.Enabled = False

    End Sub

    Private Sub btnModFornitore_Click(sender As System.Object, e As System.EventArgs) Handles btnModFornitore.Click

        ApriConnessione()

        If txtIntestazione.Text = "" Then
            MessageBox.Show("Spiacente l'intestazione del fornitore è Obligatoria", "Esito inserimento fornitore", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else

            stringasql = "UPDATE Fornitori SET intestazione = '" & Me.txtIntestazione.Text & "'" & ", indirizzo ='" & Me.txtIndirizzo.Text & "'"
            stringasql = stringasql & " , citta = '" & Me.txtCitta.Text & "'" & ", provincia = '" & Me.txtProvincia.Text & "'"
            stringasql = stringasql & " , cap = '" & Me.txtCap.Text & "'" & ", tel = '" & Me.txtTel.Text & "'" & ", email ='" & Me.txtEmail.Text & "'"
            stringasql = stringasql & " WHERE(id_fornitore = " & DataGridFornitori.CurrentRow.Cells(0).Value() & ")"

            cmd = New SqlCommand(stringasql, connection)

            Dim risputente As Integer
            Try
                risputente = cmd.ExecuteNonQuery()
                If risputente = 1 Then

                    DataGridForShow()
                    'PopolaComboFornitori()
                    'PopolaComboFornitoriInt()
                    clearFornitore()

                    btnReturnFornitore.Visible = False
                    btnInsertFornitore.Visible = True
                    btnDeleteFornitore.Enabled = False
                    btnModFornitore.Enabled = False

                    MessageBox.Show("Modifica di " & DataGridFornitori.CurrentRow.Cells(1).Value() & " effettuata con successo.", "Esito inserimento fornitore", MessageBoxButtons.OK)

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Errore: Nessun Dato Modificato su Fornitori", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ChiudiConnessione()

    End Sub

    Private Sub btnDeleteFornitore_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteFornitore.Click

        ApriConnessione()

        stringasql = "DELETE FROM Fornitori WHERE id_fornitore = " & DataGridFornitori.CurrentRow.Cells(0).Value
        cmd = New SqlCommand(stringasql, connection)

        Dim risputente As Integer
        Try
            risputente = cmd.ExecuteNonQuery()
            If risputente = 1 Then

                DataGridForShow()
                'PopolaComboFornitori()
                'PopolaComboFornitoriInt()
                clearFornitore()

                btnReturnFornitore.Visible = False
                btnInsertFornitore.Visible = True
                btnDeleteFornitore.Enabled = False
                btnModFornitore.Enabled = False

                MessageBox.Show("Eliminazione del fornitore " & DataGridFornitori.CurrentRow.Cells(1).Value() & " COMPLETATA.", "Esito eliminazione fornitore", MessageBoxButtons.OK)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore: Nessun dato Eliminato su Fornitori", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ChiudiConnessione()

    End Sub

    Private Sub btnSearchFornitori_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchFornitori.Click

        ApriConnessione()

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        stringasql = "SELECT * FROM Fornitori WHERE intestazione LIKE '%" & txtSearchFornitori.Text & "%'"
        da = New SqlDataAdapter(stringasql, connection)
        da.Fill(dt)
        DataGridFornitori.DataSource = dt.DefaultView
        DataGridFornitori.ClearSelection()

        'Imposto i nomi alle etichette delle colonne della DataGrid e la loro larghezza in pixel
        DataGridFornitori.Columns("ID_fornitore").HeaderText = "ID"
        DataGridFornitori.Columns("ID_fornitore").Width = 50
        DataGridFornitori.Columns("intestazione").HeaderText = "Intestazione"
        DataGridFornitori.Columns("intestazione").Width = 125
        DataGridFornitori.Columns("indirizzo").HeaderText = "Indirizzo"
        DataGridFornitori.Columns("indirizzo").Width = 135
        DataGridFornitori.Columns("citta").HeaderText = "Città"
        DataGridFornitori.Columns("citta").Width = 100
        DataGridFornitori.Columns("provincia").HeaderText = "Prov."
        DataGridFornitori.Columns("provincia").Width = 60
        DataGridFornitori.Columns("cap").HeaderText = "CAP"
        DataGridFornitori.Columns("cap").Width = 60
        DataGridFornitori.Columns("tel").HeaderText = "Recapito"
        DataGridFornitori.Columns("tel").Width = 100
        DataGridFornitori.Columns("email").HeaderText = "Email"
        DataGridFornitori.Columns("email").Width = 125

        ChiudiConnessione()

    End Sub

    Private Sub clearFornitore()

        Me.txtId.Text = ""
        Me.txtIntestazione.Text = ""
        Me.txtIndirizzo.Text = ""
        Me.txtCitta.Text = ""
        Me.txtProvincia.Text = ""
        Me.txtCap.Text = ""
        Me.txtTel.Text = ""
        Me.txtEmail.Text = ""

    End Sub

    Private Sub btnRefreshFornitore_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshFornitore.Click

        DataGridForShow()
        DataGridFornitori.ClearSelection()

    End Sub

    Private Sub btnPrintFornitori_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintFornitori.Click

        PrintDGV.Print_DataGridView(DataGridFornitori)

    End Sub

#End Region

    Private Sub btn_about_Click(sender As System.Object, e As System.EventArgs) Handles btn_about.Click
        Dim inf As New Info

        inf.Show()

    End Sub

End Class
