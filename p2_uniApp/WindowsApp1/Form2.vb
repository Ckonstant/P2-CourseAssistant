Public Class Form2
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
    Dim names As String()
    Dim epiloghs As String()
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.GunaCircleProgressBar7.Visible = False
        names = {"Απειροστικός Ι", "Αγγλικά", "Γενική Φυσική", "Γραμμική Άλγεβρα", "Εισαγωγή στον Προγραμματισμό", "Εισαγωγή στους Η/Υ και Πληροφορική",
                                "Απειροστικός Λογισμός ΙΙ", "Βασικές Αρχές Κυκλωμάτων", "Διακριτά Μαθηματικά Ι", "Τεχνικές Αντικειμενοστρεφούς Προγραμματισμού",
                                "Ανάπτυξη Λογισμικού", "Διακριτά Μαθηματικά ΙΙ", "Δομές Δεδομένων", "Πιθανότητες και Στατιστική", "Ψηφιακή Σχεδίαση Ι",
                                "Αρχές Γλωσσών Προγραμματισμού", "Εισαγωγή στην Αριθμητική Ανάλυση", "Ηλεκτρονική", "Σχεδίαση και Ανάλυση Αλγορίθμων", "Ψηφιακή Σχεδίαση ΙΙ",
                                "Θεωρία Υπολογισμού", "Προγραμματισμός Συστημάτων", "Σήματα και Συστήματα", "Yπολογιστικά Μαθηματικά", "Αρχιτεκτονική Υπολογιστών",
                                "Λειτουργικά Συστήματα", "Tεχνητή Νοημοσύνη", "Τηλεπικοινωνιακά Συστήματα",
                                "Βάσεις Δεδομένων", "Γραφικά Υπολογιστών και Συστήματα Αλληλεπίδρασης", "Δίκτυα Υπολογιστών Ι",
                                "Δίκτυα Υπολογιστών ΙΙ", "Μεταφραστές", "Τεχνολογία Λογισμικού", "Μικροεπεξεργαστές"}
        epiloghs = {"Αλληλεπίδραση Ανθρώπου Υπολογιστή", "Μηχανική Μάθηση", "Ανάκτηση Πληροφορίας", "Ανάπτυξη Λογισμικού ΙΙ", "Αρχιτεκτονική Υπολογιστών ΙΙ", "Ασύρματα Δίκτυα",
            "Ασφάλεια Υπολογιστικών και Επικοινωνιακών Συστημάτων", "Βελτιστοποίηση", "Δοκιμή και Αξιοπιστία Ηλεκτρονικών Συστημάτων",
            "Εξελικτικός Υπολογισμός", "Εξόρυξη Δεδομένων", "Θεωρία Γραφημάτων", "Θεωρία Πληροφορίας και Κωδίκων", "Ιατρική Πληροφορική",
            "Κυκλώματα VLSI", "Μεταφραστές ΙΙ", "Παράλληλα Συστήματα και Προγραμματισμός",
            "Πολυμέσα", "Προηγμένη Σχεδίαση Αλγορίθμων και Δομών", "Προσομοίωση και Μοντελοποίηση Υπολογιστικών Συστημάτων", "Προχωρημένα Θέματα Τεχνολογίας και Εφαρμογών Βάσεων Δεδομένων",
            "Ρομποτική", "Υπολογιστική Γεωμετρία", "Υπολογιστική Νοημοσύνη", "Υπολογιστική Πολυπλοκότητα", "Ψηφιακή Επεξεργασία Εικόνας",
              "Διαχείριση Σύνθετων Δεδομένων", "Τεχνολογίες Διαδικτύου",
              "Αλγοριθμικές Τεχνικές για Δεδομένα Ευρείας Κλίμακας", "Ασύρματες Ζεύξεις", "Διδακτική της Πληροφορικής", "Εικονική, Επαυξημένη και Μικτή Πραγματικότητα",
            "Προηγμένες Μέθοδοι 3Δ Γραφικών"
            }

        For i As Integer = 0 To 5 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            c.courseName.Text = names(i)
            FlowLayoutPanel2.Controls.Add(c)
        Next
        For i As Integer = 6 To 9 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            c.courseName.Text = names(i)
            FlowLayoutPanel3.Controls.Add(c)
        Next
        For i As Integer = 10 To 14 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            c.courseName.Text = names(i)
            FlowLayoutPanel4.Controls.Add(c)
        Next
        For i As Integer = 15 To 19 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            c.courseName.Text = names(i)
            FlowLayoutPanel5.Controls.Add(c)
        Next
        For i As Integer = 20 To 24 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            c.courseName.Text = names(i)
            FlowLayoutPanel6.Controls.Add(c)
        Next
        For i As Integer = 25 To 27 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            c.courseName.Text = names(i)
            FlowLayoutPanel7.Controls.Add(c)
        Next
        For i As Integer = 28 To 30 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            c.courseName.Text = names(i)
            FlowLayoutPanel8.Controls.Add(c)
        Next
        For i As Integer = 31 To 33 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            c.courseName.Text = names(i)
            FlowLayoutPanel9.Controls.Add(c)
        Next
        For i As Integer = 0 To epiloghs.Length - 1 Step 1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = epiloghs(i)
            c.courseName.Text = epiloghs(i)
            FlowLayoutPanel11.Controls.Add(c)
        Next

        Dim x As courseControl = New courseControl
        x.GunaAdvenceTileButton1.Text = names(34)
        x.courseName.Text = names(34)
        FlowLayoutPanel10.Controls.Add(x)
        GunaAdvenceButton1.PerformClick()
    End Sub



    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If FlowLayoutPanel2.Visible = False Then
            FlowLayoutPanel2.Visible = True
            GunaAdvenceButton1.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel2.Visible = False
            GunaAdvenceButton1.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If FlowLayoutPanel3.Visible = False Then
            FlowLayoutPanel3.Visible = True
            GunaAdvenceButton2.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel3.Visible = False
            GunaAdvenceButton2.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        If FlowLayoutPanel4.Visible = False Then
            FlowLayoutPanel4.Visible = True
            GunaAdvenceButton3.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel4.Visible = False
            GunaAdvenceButton3.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        If FlowLayoutPanel5.Visible = False Then
            FlowLayoutPanel5.Visible = True
            GunaAdvenceButton4.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel5.Visible = False
            GunaAdvenceButton4.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        If FlowLayoutPanel6.Visible = False Then
            FlowLayoutPanel6.Visible = True
            GunaAdvenceButton5.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel6.Visible = False
            GunaAdvenceButton5.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        If FlowLayoutPanel7.Visible = False Then
            FlowLayoutPanel7.Visible = True
            GunaAdvenceButton6.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel7.Visible = False
            GunaAdvenceButton6.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        If FlowLayoutPanel8.Visible = False Then
            FlowLayoutPanel8.Visible = True
            GunaAdvenceButton7.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel8.Visible = False
            GunaAdvenceButton7.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        If FlowLayoutPanel9.Visible = False Then
            FlowLayoutPanel9.Visible = True
            GunaAdvenceButton8.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel9.Visible = False
            GunaAdvenceButton8.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton9.Click
        If FlowLayoutPanel10.Visible = False Then
            FlowLayoutPanel10.Visible = True
            GunaAdvenceButton9.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel10.Visible = False
            GunaAdvenceButton9.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton10.Click
        If FlowLayoutPanel11.Visible = False Then
            FlowLayoutPanel11.Visible = True
            GunaAdvenceButton10.Image = My.Resources.expand_arrow_24px
        Else
            FlowLayoutPanel11.Visible = False
            GunaAdvenceButton10.Image = My.Resources.more_than_16px
        End If
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub
End Class