Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Net.NetworkInformation
Imports Syncfusion.Windows.Forms

Public Class Form1
    Public hideGrade As Boolean = False
    Public names As String()
    Public courseFlag As String
    Public courseID As String()
    Public courseDpLink As String()
    Public typos As String()
    Public courseEksamino As String()
    Public courseDrive As String()
    Public courseDidaskon As String()
    Public courseGrade As String()
    Public courseSite As String()
    Public courseDiscord As String()
    Public courseLab As String()
    Public coursepos As Integer = 0
    Public fullpathview As String
    Public windowFlag As Boolean = False
    Public agaphmenaList As New List(Of String)
    Public pdfFlag As Boolean = True
    Private Sub GunaButton29_Click(sender As Object, e As EventArgs)
        For i As Integer = 10 - 1 To 0 Step -1
            Dim c As courseControl = New courseControl
            c.GunaAdvenceTileButton1.Text = names(i)
            ' FlowLayoutPanel1.Controls.Add(c)
        Next
    End Sub

    Private Sub GunaButton23_Click(sender As Object, e As EventArgs)
        GunaButton23.Visible = False
        GunaButton22.Visible = True
        ' GunaButton14.Visible = False
        'GunaButton15.Visible = True
        GunaPanel8.Visible = False
        GunaPanel8.Width = 187
        GunaTransition1.ShowSync(GunaPanel8)
    End Sub

    Private Sub GunaButton22_Click(sender As Object, e As EventArgs)
        GunaButton22.Visible = False
        GunaButton23.Visible = True
        GunaPanel8.Visible = False
        GunaPanel8.Width = 40
        GunaTransition1.ShowSync(GunaPanel8)
    End Sub
    Function IsInternetConnected() As Boolean

        Return New Ping().Send("www.google.com").Status = IPStatus.Success

    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Timer3.Start()



        If IsInternetConnected() = True Then
            GunaPictureBox3.Visible = True
            GunaPictureBox4.Visible = False
        Else
            GunaPictureBox4.Visible = True
            GunaPictureBox3.Visible = False
        End If
        names = {"Απειροστικός Ι", "Αγγλικά", "Γενική Φυσική", "Γραμμική Άλγεβρα", "Εισαγωγή στον Προγραμματισμό", "Εισαγωγή στους Η/Υ και Πληροφορική",
                                "Απειροστικός Λογισμός ΙΙ", "Βασικές Αρχές Κυκλωμάτων", "Διακριτά Μαθηματικά Ι", "Τεχνικές Αντικειμενοστρεφούς Προγραμματισμού",
                                "Ανάπτυξη Λογισμικού", "Διακριτά Μαθηματικά ΙΙ", "Δομές Δεδομένων", "Πιθανότητες και Στατιστική", "Ψηφιακή Σχεδίαση Ι",
                                "Αρχές Γλωσσών Προγραμματισμού", "Εισαγωγή στην Αριθμητική Ανάλυση", "Ηλεκτρονική", "Σχεδίαση και Ανάλυση Αλγορίθμων", "Ψηφιακή Σχεδίαση ΙΙ",
                                "Θεωρία Υπολογισμού", "Προγραμματισμός Συστημάτων", "Σήματα και Συστήματα", "Yπολογιστικά Μαθηματικά", "Αρχιτεκτονική Υπολογιστών",
                                "Λειτουργικά Συστήματα", "Tεχνητή Νοημοσύνη", "Τηλεπικοινωνιακά Συστήματα",
                                "Βάσεις Δεδομένων", "Γραφικά Υπολογιστών και Συστήματα Αλληλεπίδρασης", "Δίκτυα Υπολογιστών Ι",
                                "Δίκτυα Υπολογιστών ΙΙ", "Μεταφραστές", "Τεχνολογία Λογισμικού",
                                "Μικροεπεξεργαστές",
                                "Αλληλεπίδραση Ανθρώπου Υπολογιστή", "Μηχανική Μάθηση", "Ανάκτηση Πληροφορίας", "Ανάπτυξη Λογισμικού ΙΙ", "Αρχιτεκτονική Υπολογιστών ΙΙ", "Ασύρματα Δίκτυα",
            "Ασφάλεια Υπολογιστικών και Επικοινωνιακών Συστημάτων", "Βελτιστοποίηση", "Δοκιμή και Αξιοπιστία Ηλεκτρονικών Συστημάτων",
            "Εξελικτικός Υπολογισμός", "Εξόρυξη Δεδομένων", "Θεωρία Γραφημάτων", "Θεωρία Πληροφορίας και Κωδίκων", "Ιατρική Πληροφορική",
            "Κυκλώματα VLSI", "Μεταφραστές ΙΙ", "Παράλληλα Συστήματα και Προγραμματισμός",
            "Πολυμέσα", "Προηγμένη Σχεδίαση Αλγορίθμων και Δομών", "Προσομοίωση και Μοντελοποίηση Υπολογιστικών Συστημάτων", "Προχωρημένα Θέματα Τεχνολογίας και Εφαρμογών Βάσεων Δεδομένων",
            "Ρομποτική", "Υπολογιστική Γεωμετρία", "Υπολογιστική Νοημοσύνη", "Υπολογιστική Πολυπλοκότητα", "Ψηφιακή Επεξεργασία Εικόνας",
              "Διαχείριση Σύνθετων Δεδομένων", "Τεχνολογίες Διαδικτύου",
              "Αλγοριθμικές Τεχνικές για Δεδομένα Ευρείας Κλίμακας", "Ασύρματες Ζεύξεις", "Διδακτική της Πληροφορικής", "Εικονική, Επαυξημένη και Μικτή Πραγματικότητα",
            "Προηγμένες Μέθοδοι 3Δ Γραφικών"}

        typos = {"Apeiro", "Agglika", "Geniki", "gramiki", "python", "unix",
                    "apeiro2", "bak", "diak1", "java",
                    "anaptiksi", "diak2", "domes", "pithanot", "psifiaki",
                    "arxes", "arithmitiki", "ilektroniki", "analisi", "psifiaki2",
                    "theoria", "C", "simata", "upologistika", "arhitek",
                    "leitourgika", "tehniti", "tilep",
                    "vaseis", "grafika", "diktia1",
                    "diktia2", "metafrastes", "texnologia",
                    "mikroepekse",
                    "alilepidrasi", "mhxaniki", "anaktisi", "anaptiksi2", "arhitekt2",
                    "asyrmatadiktia", "asfaleiaupolo", "veltisto", "dokimiaksia", "ekseliktikos",
                    "eksoriksi", "theoriagraf", "theoriakodikon", "iatriki", "vlsi",
                    "metafrastes2", "paralisistimata", "polymesa", "proigmenisxediasi", "prosomoiosi",
                    "proxorimena", "robotiki", "geometria", "yponoimosini", "ypopoliplokotita",
                    "psifeikonas", "sintheta", "tehnodiadiktio", "eureias", "zeukseis",
                    "didaktiki", "eikonikh", "3dgraf"}
        courseDpLink = {"https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21115&authkey=AEcCE9YN0ASutt0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21114&authkey=AO-cal_wG1_p6-M", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21144&authkey=AMzCznIe2rwj-38", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21122&authkey=AEodzyGh7SygXis", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21136&authkey=AJXEZ3he4qwX0zo", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21118&authkey=AB0b2MjmwkzcAtk",
                                 "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21145&authkey=AE9HDhg-1Jqmft0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21145&authkey=AE9HDhg-1Jqmft0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21135&authkey=AJbgEKHKMW3Gdqo", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21121&authkey=AFzJmuFSeR_hTVs",
                                 "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21119&authkey=AO08EW1LuGPQrRA", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21141&authkey=AN-TyFxJhIzESRw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21129&authkey=AIhH8c2Y2iqL4uw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21134&authkey=AEKxRYcZLKfMl1M", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21133&authkey=AHdV5-w7iNSWbE0",
                                 "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21120&authkey=AFjOQ6qpJ4mIItk", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21143&authkey=AHMGkvltVTNhMJw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21139&authkey=ADs8F8j_YzIkA-I", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21132&authkey=AC_wNXqXYgILj14", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21123&authkey=AB_j7NjLpfQR_-Y",
                                 "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21130&authkey=AIS4yQ5lGtqtGkQ", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21124&authkey=AFMPq1g5S27wmAQ", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21146&authkey=AC4ze3VY0xLWPJM", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21147&authkey=ACdn4fmWsCKMZzU", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21137&authkey=AG7Ltg4br8krDh0",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21127&authkey=AHh2AWSp9keKdwY", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21131&authkey=ACnCCxDjLSJdvYg", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21142&authkey=AKjJ8UzlnaBZ2JE",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21128&authkey=AKHJwKZ1oL1Ox7o", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21140&authkey=AP47mn68hvAI3Ag", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21138&authkey=AF8HAWs7rAQLNIg",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21117&authkey=AIh6m-PyMq5wje0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21125&authkey=AF4vxNPTDCKUECk", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21116&authkey=AFwkVA7IKFWRsLI",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21117&authkey=AIh6m-PyMq5wje0",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21170&authkey=AKhWyDlEK8-L7ek", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21168&authkey=AOQQNi55fBN2AZQ", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21155&authkey=AEkLRtfQWRqhxkQ", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21154&authkey=AJgvU7aBQaL8ems", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21148&authkey=AMUKE-jjwvwQ30I",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21161&authkey=AA96g9xnVBKrr5Y", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21159&authkey=APGCXPGynNRpu5k", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21166&authkey=AOidqbYpecJvqpw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21152&authkey=ADLsw-j7VDZVTm4", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21157&authkey=AB70Cl91syFGMDM",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21165&authkey=AG8KUhRIVVecVR0", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21169&authkey=AOeXtDDVlCBVwzs", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21151&authkey=AE9NBKP2Nlp_Yxk", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21167&authkey=AHKyr-K7ksmDJ2Q", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21178&authkey=AOgquofc5FjCjZM",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21153&authkey=ANmlj-kdf5xJjGE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21162&authkey=AIPE257g5DgDdcY", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21173&authkey=AAne4P84X1js9Po", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21177&authkey=ALBrytyLjzFkWGE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21160&authkey=AO3Swpoe5UaBH6k",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21163&authkey=AByWgleVhu9tvfs", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21172&authkey=AFTe4shF_Amv4Qg", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21150&authkey=AOPTANdrygr83YI", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21164&authkey=AIHFGpPJ3F3ILMc", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21156&authkey=ADaOQWlsBhojn54",
                                "https://onedrive.live.com/downlaod?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21179&authkey=AOrO-7RlcyQmLPM", "https://onedrive.live.com/downlaod?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21174&authkey=AAarjuEUkuxo9QY", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21158&authkey=ALxBDEuoAauIDfw", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21149&authkey=ALHq-gUOyS0PnYo", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21176&authkey=AC8ApbwY41Fp0L0",
                                "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21171&authkey=AM-5hc6Kwf5pzlE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21171&authkey=AM-5hc6Kwf5pzlE", "https://onedrive.live.com/download?cid=BBDE528EBE1ABCBB&resid=BBDE528EBE1ABCBB%21175&authkey=AMBEjThe-AnCYos"}

        courseID = {"MYY102", "ΜΥΥ101", "ΜΥΥ103", "ΜΥΥ104", "ΜΥΥ105", "ΜΥΥ106",
                    "MYY202", "ΜΥΥ203", "ΜΥΥ204", "ΜΥΥ205",
                    "ΜΥΥ301", "ΜΥΥ302", "ΜΥΥ303", "ΜΥΥ304", "ΜΥΥ305",
                    "ΜΥΥ401", "ΜΥΥ403", "ΜΥΥ404", "ΜΥΥ405", "ΜΥΥ406",
                    "ΜΥΥ501", "ΜΥΥ502", "ΜΥΥ503", "ΜΥΥ504", "ΜΥΥ505",
                    "ΜΥΥ601", "ΜΥΥ602", "ΜΥΥ603",
                    "ΜΥΥ701", "ΜΥΥ702", "ΜΥΥ703",
                    "ΜΥΥ801", "ΜΥΥ802", "ΜΥΥ803",
                    "MYY901",
                    "ΜΥΕ001", "ΜΥΕ002", "ΜΥΕ003", "ΜΥΕ004", "ΜΥΕ005",
                    "ΜΥΕ006", "ΜΥΕ007", "ΜΥΕ008", "ΜΥΕ010", "ΜΥΕ011",
                    "ΜΥΕ012", "ΜΥΕ014", "ΜΥΕ015", "ΜΥΕ016", "MYE018",
                    "ΜΥΕ020", "ΜΥΕ023", "ΜΥΕ025", "ΜΥΕ028", "ΜΥΕ029",
                    "ΜΥΕ030", "ΜΥΕ031", "ΜΥΕ034", "ΜΥΕ035", "ΜΥΕ036",
                    "ΜΥΕ037", "ΜΥΕ041", "ΜΥΕ042", "ΜΥΕ047", "ΜΥΕ048",
                    "ΜΥΕ050", "ΜΥΕ051", "ΜΥΕ052"}


        courseEksamino = {"1o", "1o", "1o", "1ο", "1ο", "1o",
                           "2ο", "2ο", "2o", "2ο",
                           "3ο", "3o", "3ο", "3ο", "3ο",
                           "4ο", "4ο", "4ο", "4ο", "4ο",
                           "5ο", "5ο", "5ο", "5ο", "5ο",
                           "6o", "6o", "6o",
                           "7ο", "7ο", "7ο",
                           "8ο", "8ο", "8ο",
                           "9o",
                           "5+", "5+", "5+", "5+", "5+",
                           "5+", "5+", "5+", "5+", "5+",
                           "5+", "5+", "5+", "5+", "5+",
                           "5+", "5+", "5+", "5+", "5+",
                           "5+", "5+", "5+", "5+", "5+",
                           "5+", "5+", "5+", "5+", "5+",
                           "5+", "5+", "5+"}

        courseGrade = {"0", "0", "5", "9.5", "5", "6",
                        "5", "6", "5", "7",
                        "6", "0", "5", "5", "5",
                        "5", "0", "0", "0", "5",
                        "0", "6", "0", "0", "5",
                        "0", "0", "0",
                        "0", "0", "0",
                        "0", "0", "0",
                        "9",
                        "0", "0", "0", "0", "0",
                        "0", "0", "0", "0", "0",
                        "0", "0", "0", "0", "0",
                        "0", "0", "0", "0", "0",
                        "0", "0", "0", "0", "0",
                        "0", "0", "0", "0", "0",
                        "0", "0", "0"}

        courseLab = {"ΟΧΙ", "ΟΧΙ", "ΟΧΙ", "ΟΧΙ", "NAI", "ΝΑΙ",
                    "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ",
                    "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ",
                    "ΟΧΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ",
                    "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΟΧΙ", "ΝΑΙ",
                    "ΝΑΙ", "ΝΑΙ", "ΝΑΙ",
                    "ΝΑΙ", "ΝΑΙ", "ΝΑΙ",
                    "ΝΑΙ", "ΝΑΙ", "ΝΑΙ",
                    "NAI",
                    "ΟΧΙ", "ΟΧΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ",
                    "ΝΑΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ",
                    "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ", "ΝΑΙ",
                    "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΟΧΙ",
                    "ΝΑΙ", "ΝΑΙ", "ΝΑΙ", "ΟΧΙ", "ΝΑΙ",
                    "ΟΧΙ", "ΟΧΙ", "ΝΑΙ", "ΟΧΙ", "ΟΧΙ",
                    "ΝΑΙ", "ΟΧΙ", "ΝΑΙ"}


        courseDiscord = {"https://discord.com/channels/695303849443065947/695362927250898947", "https://discord.com/channels/695303849443065947/760901695919095866", "https://discord.com/channels/695303849443065947/695381692038512670", "https://discord.com/channels/695303849443065947/695382590588190752", "https://discord.com/channels/695303849443065947/695382119328776202", "https://discord.com/channels/695303849443065947/695382402037448775",
                        "https://discord.com/channels/695303849443065947/695385470292721675", "https://discord.com/channels/695303849443065947/695385596276768808", "https://discord.com/channels/695303849443065947/695385783644848229", "https://discord.com/channels/695303849443065947/695385857938554901",
                        "https://discord.com/channels/695303849443065947/695386250449780785", "https://discord.com/channels/695303849443065947/695386294619996281", "https://discord.com/channels/695303849443065947/695386342367952978", "https://discord.com/channels/695303849443065947/695386398903107685", "https://discord.com/channels/695303849443065947/695386455408640031",
                        "https://discord.com/channels/695303849443065947/695386600930017312", "https://discord.com/channels/695303849443065947/695386697021784114", "https://discord.com/channels/695303849443065947/695386762511515668", "https://discord.com/channels/695303849443065947/695386864101621791", "https://discord.com/channels/695303849443065947/695386964186365982",
                        "https://discord.com/channels/695303849443065947/695387115332173897", "https://discord.com/channels/695303849443065947/695387172114792469", "https://discord.com/channels/695303849443065947/695387244814401557", "https://discord.com/channels/695303849443065947/695387339576443004", "https://discord.com/channels/695303849443065947/695387420106948638",
                        "https://discord.com/channels/695303849443065947/695387546330333184", "https://discord.com/channels/695303849443065947/695387649015414885", "https://discord.com/channels/695303849443065947/695387749355618375",
                        "https://discord.com/channels/695303849443065947/695387847502463006", "https://discord.com/channels/695303849443065947/695387897099976744", "https://discord.com/channels/695303849443065947/695387944302805033",
                        "https://discord.com/channels/695303849443065947/695388060661186600", "https://discord.com/channels/695303849443065947/695388129900757033", "https://discord.com/channels/695303849443065947/695388195176710224",
                        "https://discord.com/channels/695303849443065947/695388060661186600",
                        "https://discord.com/channels/695303849443065947/695388605044097024", "https://discord.com/channels/695303849443065947/695388701848764426", "https://discord.com/channels/695303849443065947/695388768894451713", "https://discord.com/channels/695303849443065947/695388843431690320", "https://discord.com/channels/695303849443065947/695389024004735046",
                        "https://discord.com/channels/695303849443065947/695389110440951838", "https://discord.com/channels/695303849443065947/695389226618847332", "https://discord.com/channels/695303849443065947/695389318604128327", "https://discord.com/channels/695303849443065947/760932190144954388", "https://discord.com/channels/695303849443065947/760933382967918683",
                        "https://discord.com/channels/695303849443065947/695389386094805062", "https://discord.com/channels/695303849443065947/695389480718303293", "https://discord.com/channels/695303849443065947/695389578588061816", "https://discord.com/channels/695303849443065947/760933630176002128", "https://discord.com/channels/695303849443065947/695389624570478712",
                        "https://discord.com/channels/695303849443065947/760934362387578901", "https://discord.com/channels/695303849443065947/695389820935077958", "https://discord.com/channels/695303849443065947/695389913931186236", "https://discord.com/channels/695303849443065947/695394826429923369", "https://discord.com/channels/695303849443065947/940640659281412146",
                        "https://discord.com/channels/695303849443065947/695390128771694643", "https://discord.com/channels/695303849443065947/695390129161896056", "https://discord.com/channels/695303849443065947/695390129174478889", "https://discord.com/channels/695303849443065947/695390129182736425", "https://discord.com/channels/695303849443065947/695390656293765160",
                        "https://discord.com/channels/695303849443065947/760936030362271797", "https://discord.com/channels/695303849443065947/695390924905381899", "https://discord.com/channels/695303849443065947/760936289066287165", "https://discord.com/channels/695303849443065947/695391171945431080", "https://discord.com/channels/695303849443065947/695391258704871485",
                        "https://discord.com/channels/695303849443065947/695391344851550259", "https://discord.com/channels/695303849443065947/760937008146677770", "https://discord.com/channels/695303849443065947/760937121225113600"}


        courseSite = {"https://ecourse.uoi.gr/enrol/index.php?id=1379", "https://ecourse.uoi.gr/enrol/index.php?id=370", "https://ecourse.uoi.gr/enrol/index.php?id=432", "https://ecourse.uoi.gr/enrol/index.php?id=1347", "https://ecourse.uoi.gr/course/view.php?id=489", "https://ecourse.uoi.gr/enrol/index.php?id=276",
                    "https://ecourse.uoi.gr/enrol/index.php?id=1536", "https://ecourse.uoi.gr/enrol/index.php?id=1525", "https://ecourse.uoi.gr/enrol/index.php?id=777", "https://ecourse.uoi.gr/enrol/index.php?id=399",
                    "https://www.cs.uoi.gr/~pvassil/courses/sw_dev/index.html", "https://www.cse.uoi.gr/~kontog/courses/Discrete-Math-2/", "https://ecourse.uoi.gr/enrol/index.php?id=704", "https://ecourse.uoi.gr/enrol/index.php?id=575", "https://ecourse.uoi.gr/enrol/index.php?id=1592",
                    "https://www.cse.uoi.gr/~cnomikos/courses/pl/pl-main.htm", "https://ecourse.uoi.gr/course/view.php?id=1759", "https://ecourse.uoi.gr/course/view.php?id=1517", "https://www.cse.uoi.gr/~stavros/mypage-teaching-BSc-DAA.html", "https://ecourse.uoi.gr/enrol/index.php?id=1534",
                    "https://www.cse.uoi.gr/~palios/automata/", "https://www.cse.uoi.gr/~dimako/teaching/fall20.html", "https://ecourse.uoi.gr/course/view.php?id=870", "https://ecourse.uoi.gr/enrol/index.php?id=1731", "https://ecourse.uoi.gr/course/view.php?id=995",
                    "https://www.cse.uoi.gr/~stergios/teaching/myy601/", "https://www.cse.uoi.gr/~arly/courses/ai/ai.html", "https://ecourse.uoi.gr/course/view.php?id=1038",
                    "https://www.cs.uoi.gr/~pitoura/courses/db/db19/index.html", "https://ecourse.uoi.gr/enrol/index.php?id=13", "https://www.cse.uoi.gr/~epap/MYY703/",
                    "https://users.cse.uoi.gr/~cliaskos/?Courses___MYY801___MYY801_-_EAR_2022", "https://ecourse.uoi.gr/course/view.php?id=543", "https://www.cse.uoi.gr/~zarras/se.htm",
                    "https://ecourse.uoi.gr/enrol/index.php?id=370",
                    "https://ecourse.uoi.gr/enrol/index.php?id=64", "https://ecourse.uoi.gr/course/view.php?id=3270", "https://ecourse.uoi.gr/course/view.php?id=871", "https://www.cs.uoi.gr/~zarras/soft-devII.htm", "https://ecourse.uoi.gr/enrol/index.php?id=1270",
                    "https://www.cs.uoi.gr/~epap/MYE006/", "https://www.cs.uoi.gr/~stergios/teaching/mye007/", "https://ecourse.uoi.gr/course/view.php?id=329", "https://ecourse.uoi.gr/enrol/index.php?id=950", "https://ecourse.uoi.gr/ecourse_info.php?glink=/enrol/index.php&id=1503",
                    "https://www.cs.uoi.gr/~tsap/teaching/cse012/index-gr.html", "https://ecourse.uoi.gr/enrol/index.php?id=1951", "https://ecourse.uoi.gr/enrol/index.php?id=1822", "https://ecourse.uoi.gr/enrol/index.php?id=1600", "https://www.cs.uoi.gr/~tsiatouhas/MYE018-VLSI.htm",
                    "https://ecourse.uoi.gr/enrol/index.php?id=1636", "https://www.cse.uoi.gr/~dimako/teaching/spring21.html", "https://ecourse.uoi.gr/course/view.php?id=890", "https://ecourse.uoi.gr/enrol/index.php?id=1043", "https://ecourse.uoi.gr/enrol/index.php?id=86",
                    "https://www.cs.uoi.gr/~pvassil/courses/db_III/index.html", "https://ecourse.uoi.gr/enrol/index.php?id=1036", "https://www.cse.uoi.gr/~palios/comp_geom/", "https://www.cse.uoi.gr/~arly/courses/nn/nn.html", "https://www.cse.uoi.gr/~cnomikos/courses/cc/cc-main.htm",
                    "https://ecourse.uoi.gr/course/view.php?id=573", "https://ecourse.uoi.gr/course/view.php?id=1040", "https://www.cs.uoi.gr/~stergios/teaching/mye042/", "https://ecourse.uoi.gr/enrol/index.php?id=2114", "https://ecourse.uoi.gr/enrol/index.php?id=1800",
                    "https://ecourse.uoi.gr/enrol/index.php?id=1916", "https://ecourse.uoi.gr/enrol/index.php?id=3218", "https://ecourse.uoi.gr/enrol/index.php?id=3217"}

        courseDidaskon = {"ΒΑΣΙΛΕΙΟΣ ΜΠΕΝΕΚΑΣ", "ΕΥΓΕΝΙΑ ΕΥΜΟΙΡΙΔΟΥ", "ΜΑΡΙΝΑ ΤΣΕΛΕΠΗ", "ΚΩΝΣΤΑΝΤΙΝΟΣ ΠΑΡΣΟΠΟΥΛΟΣ", "Μαμουλής Νικόλαος", "ΜΑΡΙΝΑ ΠΛΗΣΙΤΗ",
                        "ΑΠΟΣΤΟΛΟΣ ΘΩΜΑ", "Τσιατούχας Γεώργιος", "Πολενάκης Ιωσήφ", "Τσαπάρας Παναγιώτης",
                        "Βασιλειάδης Παναγιώτης", "Κοντογιάννης Σπυρίδων", "Γεωργιάδης Λουκάς", "Μπλέκας Κωνσταντίνος", "Καβουσιανός Χρυσοβαλάντης",
                        "Χρήστος Νομικός", "Παρσόπουλος Κωνσταντίνος", "Τσιατούχας Γεώργιος", "Νικολόπουλος Σταύρος", "Καβουσιανός Χρυσοβαλάντης",
                        "Παληός Λεωνίδας", "Δημακόπουλος Βασίλειος", "Νίκου Χριστόφορος", "Βλάχος Κώστας", "Ευθυμίου Αριστείδης",
                        "Αναστασιάδης Στέργιος", "Αριστείδης Λύκας", "Κόντης Λυσίμαχος-Παύλος",
                        "Ευαγγελία Πιτουρά", "Φούντος Ιωάννης", "Παπαπέτρου Ευάγγελος",
                        "Χρήστος Λιάσκος", "Μανής Γεώργιος", "Ζάρρας Απόστολος",
                        "Μανής Γεώργιος",
                        "Φούντος Ιωάννης", "Μπλέκας Κωνσταντίνος", "Πιτουρά Ευαγγελία", "Ζάρρας Απόστολος", "Ευθυμίου Αριστείδης",
                        "Παπαπέτρου Ευάγγελος", "Αναστασιάδης Στέργιος", "Παρσόπουλος Κωνσταντίνος", "Τενέντες Βασίλειος", "Σταμάτης-Άγγελος",
                        "Τσαπάρας Παναγιώτης", "Πολενάκης Ιωσήφ", "Νίκου Χριστόφορος", "ΕΥΑΓΓΕΛΟΣ ΟΙΚΟΝΟΜΟΥ", "Τσιατούχας Γεώργιος",
                        "Μανής Γεώργιος", "Δημακόπουλος Βασίλειος", "Κόντης Λυσίμαχος", "Γεωργιάδης Λουκάς", "Καππές Γεώργιος",
                        "Βασιλειάδης Παναγιώτης", "Βλάχος Κώστας", "Λεωνίδας Παληός", "Αριστείδης Λύκας", "Χρήστος Νομικός",
                        "Νίκου Χριστόφορος", "Μαμουλής Νικόλαος", "Αναστασιάδης Στέργιος", "Κοντογιάννης Σπυρίδων", "ΧΡΗΣΤΟΣ ΛΙΑΣΚΟΣ",
                        "Χρόνη Μαρία", "Βασιλάκης Ανδρέας", "Βασιλάκης Ανδρέας"}

        courseDrive = {"https://drive.google.com/drive/u/2/folders/1WR7_4GoVxVPKgoOpbIs7LyIPE50wA4Q9", "https://drive.google.com/drive/u/2/folders/1Np5v32jr-sDbQ4nXPFXUNK9NHD7SnIk8", "https://drive.google.com/drive/u/2/folders/1zxb8Xtn3Un8Zjp3qK7cG-KY8Cajdcj9V", "https://drive.google.com/drive/u/2/folders/1KpPXPnTst73Y36Sdx_BIDH5RFFgUhBWd", "https://drive.google.com/drive/u/2/folders/1Rm3b9eZ-JOqB55N048rWxy6oXHK9kuMe", "https://drive.google.com/drive/u/2/folders/1KM3_0m2p1Ui1ickdEoX5_Z12uzGV2rIx",
                        "https://drive.google.com/drive/u/2/folders/1QPukz-2ngiPalE3xgArXiAns2n9xraDL", "https://drive.google.com/drive/u/2/folders/109QS93AHICFiFvNnEE49WQ3CV0AHSNwS", "https://drive.google.com/drive/u/2/folders/11QimZXXKieCZlcWQlQk-hI6fe0A5ATZf", "https://drive.google.com/drive/u/2/folders/1JxXtDEtev0A4SNswS5sLt3av71yY8mpV",
                        "https://drive.google.com/drive/u/2/folders/1k3bQiDDccaY5lJzbZt30EVPmyZzmk3_R", "https://drive.google.com/drive/u/2/folders/1_x7lykf6X9XxlmkkA1eO1KXzFVfre6Q2", "https://drive.google.com/drive/u/2/folders/1uSUQiNthltjWss_eGWdjVoAjeGMnw_I2", "https://drive.google.com/drive/u/2/folders/1FXrk7SxLy_0LBLNEvuZZ16WIe-_XVmVP", "https://drive.google.com/drive/u/2/folders/1gwz3b-PEbpmzphCGDYflCP7iERz-hDup",
                        "https://drive.google.com/drive/u/2/folders/15j0pDjjYDdr8uIFqpBqyTiF7lkJsm18M", "https://drive.google.com/drive/u/2/folders/1N9g_xvNF0GMZhfkXxCGBMt9bjvj-eUJM", "https://drive.google.com/drive/u/2/folders/1dLnO58GOLoNZ1FuyxBkMl0fRbTxZ0wqC", "https://drive.google.com/drive/u/2/folders/12vWqUqT9Bsv-uSwQX32qYf3RSlQk5iaD", "https://drive.google.com/drive/u/2/folders/1lcgZbgOM95NWOdGD9znuqoATdmmDsjSC",
                        "https://drive.google.com/drive/u/2/folders/1FFx4C53-fWmgftai3wlL9qalg5mk7-LX", "https://drive.google.com/drive/u/2/folders/1UMPOSjlxXDkBVUhhIjHDpHU-QS1w84DX", "https://drive.google.com/drive/u/2/folders/16zK7j7W4bgzRnNc2b90RoxYQy46ZxCQy", "https://drive.google.com/drive/u/2/folders/15pNEYqkVBSnvQBZyWaQbzw7HfsTHqH9T", "https://drive.google.com/drive/u/2/folders/1JOs9p5XHvwHHb4otRXlwjstkS-NH9Bmw",
                        "https://drive.google.com/drive/u/2/folders/1lmPfNZopO1aHH22qDOAR0rLkKmEqu7m9", "https://drive.google.com/drive/u/2/folders/19MRFo3nZPpNMPtnr4lR1LoC5Hdn3NBNI", "https://drive.google.com/drive/u/2/folders/14MnlspndQYEYv8dQb1_U0JwzJz13drXZ",
                        "https://drive.google.com/drive/u/2/folders/1ffob36s_GmbVQv0k23DUCuOPQlfHO14o", "https://drive.google.com/drive/u/2/folders/1jAKlBT7AHxZinjDD0e4gMk5H-0ab-2Ee", "https://drive.google.com/drive/u/2/folders/1MEaGvrY1FGru9_OFbxyv0gUc_OtQ9fk_",
                        "https://drive.google.com/drive/u/2/folders/1aRy5bPLC7w1pmW6xFRSe_mjZkPXl-t6i", "https://drive.google.com/drive/u/2/folders/1gY1Xg2jzuoyG6KQVGfJWdLIm9RDQ4a0u", "https://drive.google.com/drive/u/2/folders/1ni3rSjEFsr85-RWvrKsI8rTZrLAsbxB_",
                        "https://drive.google.com/drive/u/2/folders/1aRy5bPLC7w1pmW6xFRSe_mjZkPXl-t6i",
                        "https://drive.google.com/drive/u/2/folders/1dNJaRLmFoB8j3kn0ZknYK3H7ld8X3Pm6", "https://drive.google.com/drive/u/2/folders/1xxa-zPEeolpdehqZmnmSw3yUYFwFpZuA", "https://drive.google.com/drive/u/2/folders/1acnpQ6EVRy0VGH8Wz0lfV1lkH2aYnzDD", "https://drive.google.com/drive/u/2/folders/16RYZGfUlzIfvr8l2mm2S-0N9h_21kcX7", "https://drive.google.com/drive/u/2/folders/1F_Y3APG8OoPqHOyMKInUyUCsD7KfN6RJ",
                        "https://drive.google.com/drive/u/2/folders/1Oxd_fP1RLNIPTMgRdieZPDkjoLSYl8-y", "https://drive.google.com/drive/u/2/folders/17KZATJiEwM3BeSZF2d23cqb1f-B2CCnU", "https://drive.google.com/drive/u/2/folders/127NEbZ3xwbvcu7XI3OJl12qak3ph_RbI", "https://drive.google.com/drive/u/2/folders/1Tcxp-jQSKJD3VtAWSOcXkfBn0KpeXqG-", "https://drive.google.com/drive/u/2/folders/1aBLGJyhtdlT23DHrbuywnxkvUsfA3q4J",
                        "https://drive.google.com/drive/u/2/folders/1sEr-2ELpE6SSuu33yRn1d1FVgfaG3IoR", "https://drive.google.com/drive/u/2/folders/1rTm918OdzeOteG_OQX8NjwTMJw_0xopQ", "https://drive.google.com/drive/u/2/folders/1PmbOT_RpHY73hC5xMoWmMbvOBEqXrbJn", "https://drive.google.com/drive/u/2/folders/1OGyF9rDV_WFaUlEkVr8Rd_RRwgsi5lP9", "https://drive.google.com/drive/u/2/folders/1mWmnZyniTqh7G7KraMxVQFqU-TpuvOM7",
                        "https://drive.google.com/drive/u/2/folders/1wXAyxCTKlTPw5nFiDpvbimL4lxJu9MrC", "https://drive.google.com/drive/u/2/folders/1dH3XliHAnMxHRkR5RENvfh4ftUNnhUv3", "https://drive.google.com/drive/u/2/folders/1XqPNXzj4Crq6FTnesyNnVSv-0gAbltUa", "https://drive.google.com/drive/u/2/folders/1dlt-nzBUN_G0Q8WU8h22E8J80dslkUoO", "https://drive.google.com/drive/u/2/folders/1RCKEbGMdyoQn6QNif-E6W_J9oYnCeM1C",
                        "https://drive.google.com/drive/u/2/folders/16CPuspyOQq5QIGsm0H2MRBlffAh4RTlT", "https://drive.google.com/drive/u/2/folders/1GZmF3raPmHekoIHXvA5QWLUsOBbRoQt8", "https://drive.google.com/drive/u/2/folders/1nQ00-pSjbM3wrhneJSuF9dGcVFleplYJ", "https://drive.google.com/drive/u/2/folders/1yMCo4jRUuKgLiGW22nb2cBH6VHNjeuku", "https://drive.google.com/drive/u/2/folders/1fhdlk6w_-fk9v3rrsUo37MwSl6WNNXvY",
                        "https://drive.google.com/drive/u/2/folders/1z3lLYWH3EdHZwiOMHOMRKwNftoqtvOlz", "https://drive.google.com/drive/u/2/folders/1WyVuyxot19HUJfvHGH1GrnFpVnM_lYZX", "https://drive.google.com/drive/u/2/folders/1zC1jT5Ks_bqDHPOUJecBrK1CDN4tMZFX", "https://drive.google.com/drive/u/2/folders/1rOXXMQ-Pe1d7kdZ3gA9P2KTDWCJYarVV", "https://drive.google.com/drive/u/2/folders/1Id0EjhMpYoIkQCV8MqLb-wcAM5RKIgMY",
                        "https://drive.google.com/drive/u/2/folders/1xzCF0DRiAtWu8sU8d_NJIGpIAYYz8ZHy", "https://drive.google.com/drive/u/2/folders/1tobxdWZbHx4Fxssyop9BycJyWFdPdJMU", "https://drive.google.com/drive/u/2/folders/1RfniogVoQZAlwz7uukqZH3PbGyZCBNAA"}



        If Application.OpenForms().OfType(Of courseMain).Any Or Application.OpenForms().OfType(Of Form4).Any Or Application.OpenForms().OfType(Of Form2).Any Then

            'GunaTransition2.HideSync(GunaPanel5)
            Form2.Close()
            courseMain.Close()
            Form4.Close()
            openChildForm(Form4)


            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaTransition2.ShowSync(GunaPanel5)

        Else

            openChildForm(Form4)

        End If
        Label4.Text = DateTime.Now.ToString("dddd/dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub GunaButton28_Click(sender As Object, e As EventArgs)
        If Application.OpenForms().OfType(Of Form2).Any Then
            'GunaTransition2.HideSync(GunaPanel5)
            Form2.Close()

            openChildForm(Form2)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaTransition2.ShowSync(GunaPanel5)
        Else
            openChildForm(Form2)
            ''GunaTransition1.ShowSync(GunaPanel15)
            ' GunaTransition2.ShowSync(GunaPanel5)
        End If
    End Sub

    Private currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()


        childForm.Show()



    End Sub
    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaButton32_Click(sender As Object, e As EventArgs)
        If Application.OpenForms().OfType(Of Form2).Any Then
            'GunaTransition2.HideSync(GunaPanel5)
            Form2.Close()

            openChildForm(Form2)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaTransition2.ShowSync(GunaPanel5)
        Else
            openChildForm(Form2)
            ''GunaTransition1.ShowSync(GunaPanel15)
            ' GunaTransition2.ShowSync(GunaPanel5)
        End If
    End Sub

    Private Sub nav_settings_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs)
        If Application.OpenForms().OfType(Of courseMain).Any Or Application.OpenForms().OfType(Of Form2).Any Then

            'GunaTransition2.HideSync(GunaPanel5)
            Form2.Close()
            courseMain.Close()
            openChildForm(Form2)


            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaTransition2.ShowSync(GunaPanel5)

        Else

            openChildForm(Form2)

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub GunaSeparator1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton27_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub

    Private Sub nav_settings_Click_1(sender As Object, e As EventArgs) Handles nav_settings.Click

        ' If GunaPanel8.Width > 80 Then
        'GunaButton22.Visible = False
        'GunaButton23.Visible = True
        ' GunaPanel8.Visible = False
        'Timer2.Start()
        'End If
        If Application.OpenForms().OfType(Of courseMain).Any Or Application.OpenForms().OfType(Of Form4).Any Or Application.OpenForms().OfType(Of Form2).Any Then

            'GunaTransition2.HideSync(GunaPanel5)
            '   GunaTransition2.HideSync(Panel1)
            Form2.Close()
            courseMain.Close()
            Form4.Close()
            openChildForm(Form4)
            GunaAdvenceTileButton1.Checked = True

            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaTransition2.ShowSync(GunaPanel5)

        Else

            GunaAdvenceTileButton1.Checked = True
            openChildForm(Form4)
            '  GunaTransition2.ShowSync(Panel1)
        End If

    End Sub

    Private Sub GunaButton23_Click_1(sender As Object, e As EventArgs) Handles GunaButton23.Click
        GunaButton23.Visible = False
        GunaButton22.Visible = True
        nav_settings.Visible = True

        GunaAdvenceTileButton1.Visible = False
        GunaAdvenceTileButton2.Visible = False
        GunaAdvenceTileButton3.Visible = False
        GunaAdvenceTileButton4.Visible = False
        GunaAdvenceTileButton5.Visible = False
        GunaAdvenceTileButton6.Visible = False
        GunaAdvenceTileButton7.Visible = False
        GunaAdvenceTileButton8.Visible = False
        GunaAdvenceTileButton9.Visible = False
        GunaAdvenceButton1.Visible = True
        GunaAdvenceButton3.Visible = True
        GunaAdvenceButton4.Visible = True
        GunaAdvenceButton5.Visible = True
        GunaAdvenceButton6.Visible = True
        GunaAdvenceButton7.Visible = True
        GunaButton27.Visible = True
        GunaButton31.Visible = True
        Timer1.Start()
    End Sub

    Private Sub GunaButton22_Click_1(sender As Object, e As EventArgs) Handles GunaButton22.Click
        GunaButton22.Visible = False
        GunaButton23.Visible = True
        nav_settings.Visible = False
        GunaAdvenceButton1.Visible = False
        GunaAdvenceButton3.Visible = False
        GunaAdvenceButton4.Visible = False
        GunaAdvenceButton5.Visible = False
        GunaAdvenceButton6.Visible = False
        GunaAdvenceButton7.Visible = False
        GunaButton27.Visible = False
        GunaButton31.Visible = False
        GunaAdvenceTileButton1.Visible = True
        GunaAdvenceTileButton2.Visible = True
        GunaAdvenceTileButton3.Visible = True
        GunaAdvenceTileButton4.Visible = True
        GunaAdvenceTileButton5.Visible = True
        GunaAdvenceTileButton6.Visible = True
        GunaAdvenceTileButton7.Visible = True
        GunaAdvenceTileButton8.Visible = True
        GunaAdvenceTileButton9.Visible = True
        ' GunaPanel8.Visible = False
        Timer2.Start()
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click

        closeAllForms()

        openChildForm(Form2)
        GunaAdvenceTileButton3.Checked = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If GunaPanel8.Width > 180 Then
            Timer1.Stop()
        End If
        GunaPanel8.Width += 7  'this line will count the width of the form, and as long as it is smaller than 858 it will continue growing

    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        closeAllForms()

        openChildForm(setts)
        GunaAdvenceTileButton7.Checked = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If GunaPanel8.Width < 88 Then
            Timer2.Stop()
        End If
        GunaPanel8.Width -= 7  'this line will count the width of the form, and as long as it is smaller than 858 it will continue growing
    End Sub

    Private Sub GunaButton31_Click(sender As Object, e As EventArgs) Handles GunaButton31.Click
        Dim ask As MsgBoxResult = MsgBox("Θέλετε να πραγματοποιηθέι Αποσύνδεση?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        closeAllForms()

        openChildForm(GridScheduleSample.calendar)
        GunaAdvenceTileButton1.Checked = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel2.Paint

    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        closeAllForms()

        openChildForm(agaphmena)
        GunaAdvenceTileButton4.Checked = True
    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        closeAllForms()

        openChildForm(Form4)
        nav_settings.Checked = True

    End Sub

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        closeAllForms()

        openChildForm(GridScheduleSample.calendar)
        GunaAdvenceButton1.Checked = True

    End Sub
    Function closeAllForms()
        Dim keepOpen As New List(Of String) From {Me.Text}
        For index = Application.OpenForms.Count - 1 To 0 Step -1
            If Not keepOpen.Contains(Application.OpenForms(index).Text) Then
                Application.OpenForms(index).Close()
            End If
        Next
    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub GunaAdvenceTileButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton6.Click
        closeAllForms()

        openChildForm(apps)

        GunaAdvenceButton3.Checked = True
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        closeAllForms()

        openChildForm(apps)
        GunaAdvenceTileButton6.Checked = True
    End Sub

    Private Sub GunaAdvenceTileButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton4.Click
        closeAllForms()

        openChildForm(agaphmena)
        GunaAdvenceButton4.Checked = True
    End Sub

    Private Sub GunaAdvenceTileButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton7.Click
        closeAllForms()

        openChildForm(setts)
        GunaAdvenceButton5.Checked = True
    End Sub

    Private Sub GunaAdvenceTileButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton3.Click
        closeAllForms()

        openChildForm(Form2)
        GunaAdvenceButton6.Checked = True
    End Sub

    Private Sub GunaAdvenceTileButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton8.Click
        closeAllForms()

        openChildForm(links)
        GunaAdvenceButton7.Checked = True
    End Sub

    Private Sub GunaAdvenceButton7_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        closeAllForms()

        openChildForm(links)
        GunaAdvenceTileButton8.Checked = True
    End Sub

    Private Sub GunaAdvenceTileButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton9.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim ask As MsgBoxResult = MessageBoxAdv.Show("Θέλετε να γίνει αποσύνδεση Χρήστη?", "University of Ioannina", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = MsgBoxResult.Yes Then
            loginForm.Show()
            Me.Close()
            'Application.Exit()
        End If
    End Sub

    Private Sub GunaAdvenceTileButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton5.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Έκδοση : Beta 1" + vbNewLine + "Ημερομηνία :2021-2022 " + vbNewLine + "Δημιουργός : Χρήστος Κωνσταντινίδης", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub Alert1(msg As String, type As AlertForm.alertTypeEnum)
        Dim f As AlertForm = New AlertForm
        f.setAlert(msg, type)
    End Sub
    Private Sub GunaPictureBox3_Click(sender As Object, e As EventArgs) Handles GunaPictureBox3.Click
        'MsgBox(courseGrade.Length)
    End Sub

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click

    End Sub

    Private Sub GunaPanel8_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel8.Paint

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If IsInternetConnected() = True Then
            GunaPictureBox3.Visible = True
            GunaPictureBox4.Visible = False
        Else
            GunaPictureBox4.Visible = True
            GunaPictureBox3.Visible = False
        End If
    End Sub

    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GunaPictureBox4_Click(sender As Object, e As EventArgs) Handles GunaPictureBox4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GunaCircleProgressBar7_Click(sender As Object, e As EventArgs) Handles GunaCircleProgressBar7.Click

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaPictureBox1.Click

    End Sub
End Class
