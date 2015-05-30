Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient

Public Class Oliv

    Private Sub Oliv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DataGridForShow()
        DataGridSilosShow()
        DataGridFornitoriToAllSilosShow()

        PopolaComboOlio()

    End Sub

#Region "TAB FORNITORI"

    Private Sub DataGridForShow()

        ApriConnessione()

        Dim ds As New DataSet
        Dim dt As New DataTable

        ds.Tables.Add(dt)
        Dim da As New SqlDataAdapter
        stringasql = "SELECT * FROM Fornitori"
        da = New SqlDataAdapter(stringasql, connection)
        da.Fill(dt)
        DataGridFornitori.DataSource = dt.DefaultView

        'Imposto i nomi alle etichette delle colonne della DataGrid e la loro larghezza in pixel
        DataGridFornitori.Columns("id_fornitore").HeaderText = "ID"
        DataGridFornitori.Columns("id_fornitore").MinimumWidth = 50
        DataGridFornitori.Columns("intestazione").HeaderText = "Intestazione"
        DataGridFornitori.Columns("intestazione").MinimumWidth = 125
        DataGridFornitori.Columns("indirizzo").HeaderText = "Indirizzo"
        DataGridFornitori.Columns("indirizzo").MinimumWidth = 135
        DataGridFornitori.Columns("citta").HeaderText = "Città"
        DataGridFornitori.Columns("citta").MinimumWidth = 100
        DataGridFornitori.Columns("provincia").HeaderText = "Prov."
        DataGridFornitori.Columns("provincia").MinimumWidth = 60
        DataGridFornitori.Columns("cap").HeaderText = "CAP"
        DataGridFornitori.Columns("cap").MinimumWidth = 60
        DataGridFornitori.Columns("tel").HeaderText = "Recapito"
        DataGridFornitori.Columns("tel").MinimumWidth = 100
        DataGridFornitori.Columns("email").HeaderText = "Email"
        DataGridFornitori.Columns("email").MinimumWidth = 125

        DataGridFornitori.ClearSelection()

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

        DataGridFornitori.ClearSelection()

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
        DataGridFornitori.Columns("ID_fornitore").MinimumWidth = 50
        DataGridFornitori.Columns("intestazione").HeaderText = "Intestazione"
        DataGridFornitori.Columns("intestazione").MinimumWidth = 125
        DataGridFornitori.Columns("indirizzo").HeaderText = "Indirizzo"
        DataGridFornitori.Columns("indirizzo").MinimumWidth = 135
        DataGridFornitori.Columns("citta").HeaderText = "Città"
        DataGridFornitori.Columns("citta").MinimumWidth = 100
        DataGridFornitori.Columns("provincia").HeaderText = "Prov."
        DataGridFornitori.Columns("provincia").MinimumWidth = 60
        DataGridFornitori.Columns("cap").HeaderText = "CAP"
        DataGridFornitori.Columns("cap").MinimumWidth = 60
        DataGridFornitori.Columns("tel").HeaderText = "Recapito"
        DataGridFornitori.Columns("tel").MinimumWidth = 100
        DataGridFornitori.Columns("email").HeaderText = "Email"
        DataGridFornitori.Columns("email").MinimumWidth = 125

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

#Region "TAB SILOS"

    'SILOS
    Private Sub DataGridSilosShow()

        ApriConnessione()

        Dim ds As New DataSet
        Dim dt As New DataTable

        ds.Tables.Add(dt)
        Dim da As New SqlDataAdapter
        stringasql = "SELECT Silos.id_silos, Silos.tipo_silos, Silos.capienza, Silos.fk_olio, Olio.tipo_olio, Silos.carico FROM (Silos INNER JOIN Olio ON Silos.fk_olio = Olio.id_olio)"
        da = New SqlDataAdapter(stringasql, connection)
        da.Fill(dt)
        DataGridSilos.DataSource = dt.DefaultView

        'Imposto i nomi alle etichette delle colonne della DataGrid e la loro larghezza in pixel
        DataGridSilos.Columns("id_silos").HeaderText = "ID"
        DataGridSilos.Columns("id_silos").MinimumWidth = 30
        DataGridSilos.Columns("id_silos").Width = 50
        DataGridSilos.Columns("tipo_silos").HeaderText = "Silos"
        DataGridSilos.Columns("tipo_silos").MinimumWidth = 60
        DataGridSilos.Columns("capienza").HeaderText = "Capienza(Kg)"
        DataGridSilos.Columns("capienza").MinimumWidth = 70
        DataGridSilos.Columns("fk_olio").Visible = False
        DataGridSilos.Columns("tipo_olio").HeaderText = "Tipo Olio"
        DataGridSilos.Columns("tipo_olio").MinimumWidth = 110
        DataGridSilos.Columns("carico").HeaderText = "Carico"
        DataGridSilos.Columns("carico").MinimumWidth = 70

        DataGridSilos.ClearSelection()

        ChiudiConnessione()

    End Sub

    Public Sub PopolaComboOlio()

        stringasql = "SELECT id_olio, tipo_olio FROM Olio"
        Dim daOlio As New SqlDataAdapter(stringasql, connection)
        Dim dsOlio As New DataSet
        daOlio.Fill(dsOlio, "Olio")
        Dim dtOlio As DataTable = dsOlio.Tables("Olio")
        Dim row As DataRow = dtOlio.NewRow()
        cbOlioToSilos.DataSource = dtOlio
        cbOlioToSilos.ValueMember = "ID_olio"
        cbOlioToSilos.DisplayMember = "tipo_olio"

    End Sub

    Private Sub DataGridSilos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridSilos.CellClick

        btnModSilos.Enabled = True
        Me.cbOlioToSilos.Text = DataGridSilos.CurrentRow.Cells(4).Value()
        DataGridSilos.CurrentRow.Selected = True

        GroupBox3.Text = "FORNITORI SILOS " & DataGridSilos.CurrentRow.Cells(0).Value() & ""
        DataGridFornitoriToSilosShow()

    End Sub

    Private Sub btnModSilos_Click(sender As Object, e As EventArgs) Handles btnModSilos.Click

        ApriConnessione()

        stringasql = "UPDATE Silos SET fk_olio = '" & Me.cbOlioToSilos.SelectedValue & "'"
        stringasql = stringasql & " WHERE(id_silos = " & DataGridSilos.CurrentRow.Cells(0).Value() & ")"

        cmd = New SqlCommand(stringasql, connection)

        Dim risputente As Integer
        Try

            risputente = cmd.ExecuteNonQuery()
            ChiudiConnessione()
            If (risputente = 1 And DataGridSilos.CurrentRow.Cells(5).Value() = 0) Then

                MessageBox.Show("Modifica del tipo olio per " & DataGridSilos.CurrentRow.Cells(1).Value() & " effettuata con successo.", "Esito modifica olio", MessageBoxButtons.OK)
                DataGridSilosShow()

                'Me.cbOlioO.Text = DataGridSilos.Rows(Me.cbSilosTO.SelectedIndex).Cells(4).Value
                'Me.cbOlioD.Text = DataGridSilos.Rows(Me.cbSilosTD.SelectedIndex).Cells(4).Value
                'Me.cb9Olio.Text = DataGridSilos.Rows(Me.cbSilosS.SelectedIndex).Cells(4).Value
                'Me.cb8Olio.Text = DataGridSilos.Rows(Me.cbSilosC.SelectedIndex).Cells(4).Value

            Else

                MessageBox.Show("Modifica del tipo olio per " & DataGridSilos.CurrentRow.Cells(1).Value() & " non effettuate perchè il carico e diverso da 0.", "Esito modifica olio", MessageBoxButtons.OK)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore: Nessun Dato Modificat su silos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnPrintSilos_Click(sender As Object, e As EventArgs) Handles btnPrintSilos.Click

        PrintDGV.Print_DataGridView(DataGridSilos)

    End Sub

    'FORNITORI
    Private Sub DataGridFornitoriToAllSilosShow()

        ApriConnessione()

        Dim ds As New DataSet
        Dim dt As New DataTable

        ds.Tables.Add(dt)
        Dim da As New SqlDataAdapter
        stringasql = "SELECT FornIntoSilos.id_FIntoS, FornIntoSilos.data_inserimento, Fornitori.intestazione, FornIntoSilos.nda, FornIntoSilos.data_da, FornIntoSilos.azione, FornIntoSilos.fk_azione, FornIntoSilos.fk_silos FROM (FornIntoSilos INNER JOIN Fornitori ON FornIntoSilos.fk_fornitore = Fornitori.id_fornitore)"
        da = New SqlDataAdapter(stringasql, connection)
        da.Fill(dt)
        DataGridFornitoriToSilos.DataSource = dt.DefaultView

        'Imposto i nomi alle etichette delle colonne della DataGrid e la loro larghezza in pixel
        DataGridFornitoriToSilos.Columns("id_FIntoS").Visible = False
        DataGridFornitoriToSilos.Columns("data_inserimento").HeaderText = "Inserimento"
        DataGridFornitoriToSilos.Columns("data_inserimento").MinimumWidth = 80
        DataGridFornitoriToSilos.Columns("intestazione").HeaderText = "Intestazione"
        DataGridFornitoriToSilos.Columns("intestazione").MinimumWidth = 125
        DataGridFornitoriToSilos.Columns("nda").HeaderText = "NDA"
        DataGridFornitoriToSilos.Columns("nda").MinimumWidth = 50
        DataGridFornitoriToSilos.Columns("data_da").HeaderText = "Data DA"
        DataGridFornitoriToSilos.Columns("data_da").MinimumWidth = 80
        DataGridFornitoriToSilos.Columns("azione").HeaderText = "Azione"
        DataGridFornitoriToSilos.Columns("azione").MinimumWidth = 90
        DataGridFornitoriToSilos.Columns("fk_azione").HeaderText = "ID"
        DataGridFornitoriToSilos.Columns("fk_azione").MinimumWidth = 35
        DataGridFornitoriToSilos.Columns("fk_silos").HeaderText = "Silos"
        DataGridFornitoriToSilos.Columns("fk_silos").MinimumWidth = 40

        DataGridFornitoriToSilos.ClearSelection()

        ChiudiConnessione()

    End Sub

    Private Sub DataGridFornitoriToSilosShow()

        ApriConnessione()

        Dim ds As New DataSet
        Dim dt As New DataTable

        ds.Tables.Add(dt)
        Dim da As New SqlDataAdapter
        stringasql = "SELECT FornIntoSilos.id_FIntoS, FornIntoSilos.data_inserimento, Fornitori.intestazione, FornIntoSilos.nda, FornIntoSilos.data_da, FornIntoSilos.azione, FornIntoSilos.fk_azione, FornIntoSilos.fk_silos FROM (FornIntoSilos INNER JOIN Fornitori ON FornIntoSilos.fk_fornitore = Fornitori.id_fornitore) WHERE (fk_silos = " & DataGridSilos.CurrentRow.Cells(0).Value() & ")"
        da = New SqlDataAdapter(stringasql, connection)
        da.Fill(dt)
        DataGridFornitoriToSilos.DataSource = dt.DefaultView

        'Imposto i nomi alle etichette delle colonne della DataGrid e la loro larghezza in pixel
        DataGridFornitoriToSilos.Columns("id_FIntoS").Visible = False
        DataGridFornitoriToSilos.Columns("data_inserimento").HeaderText = "Inserimento"
        DataGridFornitoriToSilos.Columns("data_inserimento").MinimumWidth = 80
        DataGridFornitoriToSilos.Columns("intestazione").HeaderText = "Intestazione"
        DataGridFornitoriToSilos.Columns("intestazione").MinimumWidth = 125
        DataGridFornitoriToSilos.Columns("nda").HeaderText = "NDA"
        DataGridFornitoriToSilos.Columns("nda").MinimumWidth = 50
        DataGridFornitoriToSilos.Columns("data_da").HeaderText = "Data DA"
        DataGridFornitoriToSilos.Columns("data_da").MinimumWidth = 80
        DataGridFornitoriToSilos.Columns("azione").HeaderText = "Azione"
        DataGridFornitoriToSilos.Columns("azione").MinimumWidth = 90
        DataGridFornitoriToSilos.Columns("fk_azione").HeaderText = "ID"
        DataGridFornitoriToSilos.Columns("fk_azione").MinimumWidth = 35
        DataGridFornitoriToSilos.Columns("fk_silos").HeaderText = "Silos"
        DataGridFornitoriToSilos.Columns("fk_silos").MinimumWidth = 40

        DataGridFornitoriToSilos.ClearSelection()

        ChiudiConnessione()

    End Sub

    Private Sub btnRefreshFornitoreToSilos_Click(sender As Object, e As EventArgs) Handles btnRefreshFornitoreToSilos.Click
        
        btnModSilos.Enabled = False
        Me.cbOlioToSilos.Text = ""

        GroupBox3.Text = "FORNITORI"

        DataGridSilos.ClearSelection()
        DataGridFornitoriToAllSilosShow()

    End Sub

    Private Sub btnSearchFornitoriToSilos_Click(sender As Object, e As EventArgs) Handles btnSearchFornitoriToSilos.Click

        ApriConnessione()

        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        If (txtSearchFornitoriToSilos.Text = "") Then
            stringasql = "SELECT FornIntoSilos.id_FIntoS, FornIntoSilos.data_inserimento, Fornitori.intestazione, FornIntoSilos.nda, FornIntoSilos.data_da, FornIntoSilos.azione, FornIntoSilos.fk_azione, FornIntoSilos.fk_silos FROM (FornIntoSilos INNER JOIN Fornitori ON FornIntoSilos.fk_fornitore = Fornitori.id_fornitore) WHERE (FornIntoSilos.nda LIKE '%" & txtSearchFornitoriNDAToSilos.Text & "%')"
        ElseIf (txtSearchFornitoriNDAToSilos.Text = "") Then
            stringasql = "SELECT FornIntoSilos.id_FIntoS, FornIntoSilos.data_inserimento, Fornitori.intestazione, FornIntoSilos.nda, FornIntoSilos.data_da, FornIntoSilos.azione, FornIntoSilos.fk_azione, FornIntoSilos.fk_silos FROM (FornIntoSilos INNER JOIN Fornitori ON FornIntoSilos.fk_fornitore = Fornitori.id_fornitore) WHERE (Fornitori.intestazione LIKE '%" & txtSearchFornitoriToSilos.Text & "%')"
        Else
            stringasql = "SELECT FornIntoSilos.id_FIntoS, FornIntoSilos.data_inserimento, Fornitori.intestazione, FornIntoSilos.nda, FornIntoSilos.data_da, FornIntoSilos.azione, FornIntoSilos.fk_azione, FornIntoSilos.fk_silos FROM (FornIntoSilos INNER JOIN Fornitori ON FornIntoSilos.fk_fornitore = Fornitori.id_fornitore) WHERE (Fornitori.intestazione LIKE '%" & txtSearchFornitoriToSilos.Text & "%' AND FornIntoSilos.nda LIKE '%" & txtSearchFornitoriNDAToSilos.Text & "%')"
        End If

        da = New SqlDataAdapter(stringasql, connection)
        da.Fill(dt)
        DataGridFornitoriToSilos.DataSource = dt.DefaultView

        'Imposto i nomi alle etichette delle colonne della DataGrid e la loro larghezza in pixel
        DataGridFornitoriToSilos.Columns("id_FIntoS").Visible = False
        DataGridFornitoriToSilos.Columns("data_inserimento").HeaderText = "Inserimento"
        DataGridFornitoriToSilos.Columns("data_inserimento").MinimumWidth = 80
        DataGridFornitoriToSilos.Columns("intestazione").HeaderText = "Intestazione"
        DataGridFornitoriToSilos.Columns("intestazione").MinimumWidth = 125
        DataGridFornitoriToSilos.Columns("nda").HeaderText = "NDA"
        DataGridFornitoriToSilos.Columns("nda").MinimumWidth = 50
        DataGridFornitoriToSilos.Columns("data_da").HeaderText = "Data DA"
        DataGridFornitoriToSilos.Columns("data_da").MinimumWidth = 80
        DataGridFornitoriToSilos.Columns("azione").HeaderText = "Azione"
        DataGridFornitoriToSilos.Columns("azione").MinimumWidth = 90
        DataGridFornitoriToSilos.Columns("fk_azione").HeaderText = "ID"
        DataGridFornitoriToSilos.Columns("fk_azione").MinimumWidth = 35
        DataGridFornitoriToSilos.Columns("fk_silos").HeaderText = "Silos"
        DataGridFornitoriToSilos.Columns("fk_silos").MinimumWidth = 40

        DataGridFornitoriToSilos.ClearSelection()

        ChiudiConnessione()
    End Sub

    Private Sub btnPrintFornitoriToSilos_Click(sender As Object, e As EventArgs) Handles btnPrintFornitoriToSilos.Click

        PrintDGV.Print_DataGridView(DataGridFornitoriToSilos)

    End Sub

#End Region

#Region "TAB CARICO"

#End Region

#Region "TAB CONFEZIONAMENTO"

#End Region

#Region "TAB TRASFERIMENTO"

#End Region

#Region "TAB INTERROGAZIONI"

#End Region

End Class