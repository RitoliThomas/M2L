namespace MaisonDesLigues
{
    partial class FrmPrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipale));
            this.TabInscription = new System.Windows.Forms.TabPage();
            this.GrpBenevole = new System.Windows.Forms.GroupBox();
            this.BtnEnregistreBenevole = new System.Windows.Forms.Button();
            this.PanelDispoBenevole = new System.Windows.Forms.Panel();
            this.TxtLicenceBenevole = new System.Windows.Forms.MaskedTextBox();
            this.lblDdn = new System.Windows.Forms.Label();
            this.lblNumLicence = new System.Windows.Forms.Label();
            this.TxtDateNaissance = new System.Windows.Forms.MaskedTextBox();
            this.CmdQuitter = new System.Windows.Forms.Button();
            this.GrpTypeParticipant = new System.Windows.Forms.GroupBox();
            this.RadLicencie = new System.Windows.Forms.RadioButton();
            this.RadBenevole = new System.Windows.Forms.RadioButton();
            this.RadIntervenant = new System.Windows.Forms.RadioButton();
            this.GrpIdentite = new System.Windows.Forms.GroupBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtCp = new System.Windows.Forms.MaskedTextBox();
            this.TxtVille = new System.Windows.Forms.TextBox();
            this.TxtAdr2 = new System.Windows.Forms.TextBox();
            this.TxtAdr1 = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.PicAffiche = new System.Windows.Forms.PictureBox();
            this.GrpIntervenant = new System.Windows.Forms.GroupBox();
            this.BtnEnregistrerIntervenant = new System.Windows.Forms.Button();
            this.GrpNuiteIntervenant = new System.Windows.Forms.GroupBox();
            this.PanNuiteIntervenant = new System.Windows.Forms.Panel();
            this.RdbNuiteIntervenantNon = new System.Windows.Forms.RadioButton();
            this.RdbNuiteIntervenantOui = new System.Windows.Forms.RadioButton();
            this.PanFonctionIntervenant = new System.Windows.Forms.Panel();
            this.CmbAtelierIntervenant = new System.Windows.Forms.ComboBox();
            this.lblAtelierInscription = new System.Windows.Forms.Label();
            this.TabPrincipal = new System.Windows.Forms.TabControl();
            this.tabAjoutModif = new System.Windows.Forms.TabPage();
            this.lblElementAjouter = new System.Windows.Forms.Label();
            this.grpTheme = new System.Windows.Forms.GroupBox();
            this.lblThemeAtelier = new System.Windows.Forms.Label();
            this.cmbThemeAtelier = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerTheme = new System.Windows.Forms.Button();
            this.txttheme = new System.Windows.Forms.TextBox();
            this.lblThemeNom = new System.Windows.Forms.Label();
            this.grpAtelier = new System.Windows.Forms.GroupBox();
            this.numAtelierNbPlace = new System.Windows.Forms.NumericUpDown();
            this.btnEnregistrerAtelier = new System.Windows.Forms.Button();
            this.lblPlaceMaxAtelier = new System.Windows.Forms.Label();
            this.lblNomAtelier = new System.Windows.Forms.Label();
            this.txtAtelierNom = new System.Windows.Forms.TextBox();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.grpVacation = new System.Windows.Forms.GroupBox();
            this.cmbVacationTheme = new System.Windows.Forms.ComboBox();
            this.lblVacationTheme = new System.Windows.Forms.Label();
            this.lblVacationAtelier = new System.Windows.Forms.Label();
            this.cmbVacationAtelier = new System.Windows.Forms.ComboBox();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.btnEnregistrerVacation = new System.Windows.Forms.Button();
            this.lblDateFinVacation = new System.Windows.Forms.Label();
            this.lblDateDebutVacation = new System.Windows.Forms.Label();
            this.TabInscription.SuspendLayout();
            this.GrpBenevole.SuspendLayout();
            this.GrpTypeParticipant.SuspendLayout();
            this.GrpIdentite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAffiche)).BeginInit();
            this.GrpIntervenant.SuspendLayout();
            this.GrpNuiteIntervenant.SuspendLayout();
            this.TabPrincipal.SuspendLayout();
            this.tabAjoutModif.SuspendLayout();
            this.grpTheme.SuspendLayout();
            this.grpAtelier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAtelierNbPlace)).BeginInit();
            this.grpVacation.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabInscription
            // 
            this.TabInscription.Controls.Add(this.GrpBenevole);
            this.TabInscription.Controls.Add(this.CmdQuitter);
            this.TabInscription.Controls.Add(this.GrpTypeParticipant);
            this.TabInscription.Controls.Add(this.GrpIdentite);
            this.TabInscription.Controls.Add(this.PicAffiche);
            this.TabInscription.Controls.Add(this.GrpIntervenant);
            this.TabInscription.Location = new System.Drawing.Point(4, 22);
            this.TabInscription.Name = "TabInscription";
            this.TabInscription.Padding = new System.Windows.Forms.Padding(3);
            this.TabInscription.Size = new System.Drawing.Size(1137, 579);
            this.TabInscription.TabIndex = 0;
            this.TabInscription.Text = "Inscription";
            this.TabInscription.UseVisualStyleBackColor = true;
            // 
            // GrpBenevole
            // 
            this.GrpBenevole.Controls.Add(this.BtnEnregistreBenevole);
            this.GrpBenevole.Controls.Add(this.PanelDispoBenevole);
            this.GrpBenevole.Controls.Add(this.TxtLicenceBenevole);
            this.GrpBenevole.Controls.Add(this.lblDdn);
            this.GrpBenevole.Controls.Add(this.lblNumLicence);
            this.GrpBenevole.Controls.Add(this.TxtDateNaissance);
            this.GrpBenevole.Location = new System.Drawing.Point(654, 19);
            this.GrpBenevole.Name = "GrpBenevole";
            this.GrpBenevole.Size = new System.Drawing.Size(473, 174);
            this.GrpBenevole.TabIndex = 23;
            this.GrpBenevole.TabStop = false;
            this.GrpBenevole.Text = "Disponibilités Bénévole";
            this.GrpBenevole.Visible = false;
            // 
            // BtnEnregistreBenevole
            // 
            this.BtnEnregistreBenevole.Enabled = false;
            this.BtnEnregistreBenevole.Location = new System.Drawing.Point(321, 143);
            this.BtnEnregistreBenevole.Name = "BtnEnregistreBenevole";
            this.BtnEnregistreBenevole.Size = new System.Drawing.Size(133, 25);
            this.BtnEnregistreBenevole.TabIndex = 1;
            this.BtnEnregistreBenevole.Text = "Enregistrer";
            this.BtnEnregistreBenevole.UseVisualStyleBackColor = true;
            this.BtnEnregistreBenevole.Click += new System.EventHandler(this.BtnEnregistreBenevole_Click);
            // 
            // PanelDispoBenevole
            // 
            this.PanelDispoBenevole.Location = new System.Drawing.Point(28, 84);
            this.PanelDispoBenevole.Name = "PanelDispoBenevole";
            this.PanelDispoBenevole.Size = new System.Drawing.Size(251, 84);
            this.PanelDispoBenevole.TabIndex = 21;
            // 
            // TxtLicenceBenevole
            // 
            this.TxtLicenceBenevole.Location = new System.Drawing.Point(136, 58);
            this.TxtLicenceBenevole.Mask = "000000000000";
            this.TxtLicenceBenevole.Name = "TxtLicenceBenevole";
            this.TxtLicenceBenevole.Size = new System.Drawing.Size(147, 20);
            this.TxtLicenceBenevole.TabIndex = 19;
            this.TxtLicenceBenevole.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChkDateBenevole_CheckedChanged);
            // 
            // lblDdn
            // 
            this.lblDdn.AutoSize = true;
            this.lblDdn.Location = new System.Drawing.Point(25, 35);
            this.lblDdn.Name = "lblDdn";
            this.lblDdn.Size = new System.Drawing.Size(105, 13);
            this.lblDdn.TabIndex = 18;
            this.lblDdn.Text = "Date de naissance : ";
            // 
            // lblNumLicence
            // 
            this.lblNumLicence.AutoSize = true;
            this.lblNumLicence.Location = new System.Drawing.Point(25, 65);
            this.lblNumLicence.Name = "lblNumLicence";
            this.lblNumLicence.Size = new System.Drawing.Size(105, 13);
            this.lblNumLicence.TabIndex = 17;
            this.lblNumLicence.Text = "Numéro de licence : ";
            // 
            // TxtDateNaissance
            // 
            this.TxtDateNaissance.Location = new System.Drawing.Point(136, 32);
            this.TxtDateNaissance.Mask = "00/00/0000";
            this.TxtDateNaissance.Name = "TxtDateNaissance";
            this.TxtDateNaissance.Size = new System.Drawing.Size(147, 20);
            this.TxtDateNaissance.TabIndex = 2;
            this.TxtDateNaissance.Text = "15081985";
            this.TxtDateNaissance.ValidatingType = typeof(System.DateTime);
            this.TxtDateNaissance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChkDateBenevole_CheckedChanged);
            // 
            // CmdQuitter
            // 
            this.CmdQuitter.Location = new System.Drawing.Point(493, 180);
            this.CmdQuitter.Name = "CmdQuitter";
            this.CmdQuitter.Size = new System.Drawing.Size(144, 36);
            this.CmdQuitter.TabIndex = 22;
            this.CmdQuitter.Text = "Quitter";
            this.CmdQuitter.UseVisualStyleBackColor = true;
            this.CmdQuitter.Click += new System.EventHandler(this.CmdQuitter_Click);
            // 
            // GrpTypeParticipant
            // 
            this.GrpTypeParticipant.Controls.Add(this.RadLicencie);
            this.GrpTypeParticipant.Controls.Add(this.RadBenevole);
            this.GrpTypeParticipant.Controls.Add(this.RadIntervenant);
            this.GrpTypeParticipant.Location = new System.Drawing.Point(23, 6);
            this.GrpTypeParticipant.Name = "GrpTypeParticipant";
            this.GrpTypeParticipant.Size = new System.Drawing.Size(453, 58);
            this.GrpTypeParticipant.TabIndex = 21;
            this.GrpTypeParticipant.TabStop = false;
            this.GrpTypeParticipant.Text = "Tupe Participant";
            // 
            // RadLicencie
            // 
            this.RadLicencie.AutoSize = true;
            this.RadLicencie.Location = new System.Drawing.Point(195, 19);
            this.RadLicencie.Name = "RadLicencie";
            this.RadLicencie.Size = new System.Drawing.Size(65, 17);
            this.RadLicencie.TabIndex = 20;
            this.RadLicencie.TabStop = true;
            this.RadLicencie.Text = "Licencié";
            this.RadLicencie.UseVisualStyleBackColor = true;
            this.RadLicencie.CheckedChanged += new System.EventHandler(this.RadTypeParticipant_Changed);
            // 
            // RadBenevole
            // 
            this.RadBenevole.AutoSize = true;
            this.RadBenevole.Location = new System.Drawing.Point(351, 19);
            this.RadBenevole.Name = "RadBenevole";
            this.RadBenevole.Size = new System.Drawing.Size(70, 17);
            this.RadBenevole.TabIndex = 19;
            this.RadBenevole.TabStop = true;
            this.RadBenevole.Text = "Bénévole";
            this.RadBenevole.UseVisualStyleBackColor = true;
            this.RadBenevole.CheckedChanged += new System.EventHandler(this.RadTypeParticipant_Changed);
            // 
            // RadIntervenant
            // 
            this.RadIntervenant.AutoSize = true;
            this.RadIntervenant.Location = new System.Drawing.Point(44, 19);
            this.RadIntervenant.Name = "RadIntervenant";
            this.RadIntervenant.Size = new System.Drawing.Size(79, 17);
            this.RadIntervenant.TabIndex = 18;
            this.RadIntervenant.TabStop = true;
            this.RadIntervenant.Text = "Intervenant";
            this.RadIntervenant.UseVisualStyleBackColor = true;
            this.RadIntervenant.CheckedChanged += new System.EventHandler(this.RadTypeParticipant_Changed);
            // 
            // GrpIdentite
            // 
            this.GrpIdentite.Controls.Add(this.TxtMail);
            this.GrpIdentite.Controls.Add(this.lblMail);
            this.GrpIdentite.Controls.Add(this.lblTel);
            this.GrpIdentite.Controls.Add(this.txtTel);
            this.GrpIdentite.Controls.Add(this.TxtCp);
            this.GrpIdentite.Controls.Add(this.TxtVille);
            this.GrpIdentite.Controls.Add(this.TxtAdr2);
            this.GrpIdentite.Controls.Add(this.TxtAdr1);
            this.GrpIdentite.Controls.Add(this.TxtPrenom);
            this.GrpIdentite.Controls.Add(this.TxtNom);
            this.GrpIdentite.Controls.Add(this.lblVille);
            this.GrpIdentite.Controls.Add(this.lblCodePostal);
            this.GrpIdentite.Controls.Add(this.lblAdresse);
            this.GrpIdentite.Controls.Add(this.lblPrenom);
            this.GrpIdentite.Controls.Add(this.lblNom);
            this.GrpIdentite.Location = new System.Drawing.Point(23, 70);
            this.GrpIdentite.Name = "GrpIdentite";
            this.GrpIdentite.Size = new System.Drawing.Size(453, 188);
            this.GrpIdentite.TabIndex = 17;
            this.GrpIdentite.TabStop = false;
            this.GrpIdentite.Text = "Identité";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(232, 148);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(189, 20);
            this.TxtMail.TabIndex = 16;
            this.TxtMail.Text = "patrick.dumoulin@toto.fr";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(188, 151);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(35, 155);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "Tél :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(77, 148);
            this.txtTel.Mask = "00 00 00 00 00 00";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 13;
            // 
            // TxtCp
            // 
            this.TxtCp.Location = new System.Drawing.Point(87, 107);
            this.TxtCp.Mask = "00000";
            this.TxtCp.Name = "TxtCp";
            this.TxtCp.Size = new System.Drawing.Size(90, 20);
            this.TxtCp.TabIndex = 12;
            this.TxtCp.Text = "75001";
            // 
            // TxtVille
            // 
            this.TxtVille.Location = new System.Drawing.Point(232, 104);
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(189, 20);
            this.TxtVille.TabIndex = 11;
            this.TxtVille.Text = "Paris";
            // 
            // TxtAdr2
            // 
            this.TxtAdr2.Location = new System.Drawing.Point(81, 76);
            this.TxtAdr2.Name = "TxtAdr2";
            this.TxtAdr2.Size = new System.Drawing.Size(340, 20);
            this.TxtAdr2.TabIndex = 9;
            // 
            // TxtAdr1
            // 
            this.TxtAdr1.Location = new System.Drawing.Point(81, 50);
            this.TxtAdr1.Name = "TxtAdr1";
            this.TxtAdr1.Size = new System.Drawing.Size(340, 20);
            this.TxtAdr1.TabIndex = 8;
            this.TxtAdr1.Text = "Avenue du PLSQL";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(279, 25);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(142, 20);
            this.TxtPrenom.TabIndex = 7;
            this.TxtPrenom.Text = "Patrick";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(81, 25);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(142, 20);
            this.TxtNom.TabIndex = 6;
            this.TxtNom.Text = "Dumoulin";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(191, 110);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 13);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville : ";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(35, 107);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(30, 13);
            this.lblCodePostal.TabIndex = 3;
            this.lblCodePostal.Text = "CP : ";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(20, 53);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(229, 28);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(27, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // PicAffiche
            // 
            this.PicAffiche.Image = global::MaisonDesLigues.Properties.Resources.affiche;
            this.PicAffiche.Location = new System.Drawing.Point(493, 6);
            this.PicAffiche.Name = "PicAffiche";
            this.PicAffiche.Size = new System.Drawing.Size(108, 164);
            this.PicAffiche.TabIndex = 5;
            this.PicAffiche.TabStop = false;
            // 
            // GrpIntervenant
            // 
            this.GrpIntervenant.Controls.Add(this.BtnEnregistrerIntervenant);
            this.GrpIntervenant.Controls.Add(this.GrpNuiteIntervenant);
            this.GrpIntervenant.Controls.Add(this.PanFonctionIntervenant);
            this.GrpIntervenant.Controls.Add(this.CmbAtelierIntervenant);
            this.GrpIntervenant.Controls.Add(this.lblAtelierInscription);
            this.GrpIntervenant.Location = new System.Drawing.Point(23, 264);
            this.GrpIntervenant.Name = "GrpIntervenant";
            this.GrpIntervenant.Size = new System.Drawing.Size(515, 286);
            this.GrpIntervenant.TabIndex = 25;
            this.GrpIntervenant.TabStop = false;
            this.GrpIntervenant.Text = "Complément Inscription Intervenant";
            this.GrpIntervenant.Visible = false;
            // 
            // BtnEnregistrerIntervenant
            // 
            this.BtnEnregistrerIntervenant.Enabled = false;
            this.BtnEnregistrerIntervenant.Location = new System.Drawing.Point(340, 251);
            this.BtnEnregistrerIntervenant.Name = "BtnEnregistrerIntervenant";
            this.BtnEnregistrerIntervenant.Size = new System.Drawing.Size(133, 25);
            this.BtnEnregistrerIntervenant.TabIndex = 30;
            this.BtnEnregistrerIntervenant.Text = "Enregistrer";
            this.BtnEnregistrerIntervenant.UseVisualStyleBackColor = true;
            this.BtnEnregistrerIntervenant.Click += new System.EventHandler(this.BtnEnregistrerIntervenant_Click);
            // 
            // GrpNuiteIntervenant
            // 
            this.GrpNuiteIntervenant.Controls.Add(this.PanNuiteIntervenant);
            this.GrpNuiteIntervenant.Controls.Add(this.RdbNuiteIntervenantNon);
            this.GrpNuiteIntervenant.Controls.Add(this.RdbNuiteIntervenantOui);
            this.GrpNuiteIntervenant.Location = new System.Drawing.Point(21, 104);
            this.GrpNuiteIntervenant.Name = "GrpNuiteIntervenant";
            this.GrpNuiteIntervenant.Size = new System.Drawing.Size(497, 151);
            this.GrpNuiteIntervenant.TabIndex = 29;
            this.GrpNuiteIntervenant.TabStop = false;
            this.GrpNuiteIntervenant.Text = "Nuités";
            // 
            // PanNuiteIntervenant
            // 
            this.PanNuiteIntervenant.Location = new System.Drawing.Point(3, 43);
            this.PanNuiteIntervenant.Name = "PanNuiteIntervenant";
            this.PanNuiteIntervenant.Size = new System.Drawing.Size(494, 102);
            this.PanNuiteIntervenant.TabIndex = 24;
            this.PanNuiteIntervenant.Visible = false;
            // 
            // RdbNuiteIntervenantNon
            // 
            this.RdbNuiteIntervenantNon.AutoSize = true;
            this.RdbNuiteIntervenantNon.Checked = true;
            this.RdbNuiteIntervenantNon.Location = new System.Drawing.Point(92, 15);
            this.RdbNuiteIntervenantNon.Name = "RdbNuiteIntervenantNon";
            this.RdbNuiteIntervenantNon.Size = new System.Drawing.Size(45, 17);
            this.RdbNuiteIntervenantNon.TabIndex = 23;
            this.RdbNuiteIntervenantNon.TabStop = true;
            this.RdbNuiteIntervenantNon.Text = "Non";
            this.RdbNuiteIntervenantNon.UseVisualStyleBackColor = true;
            this.RdbNuiteIntervenantNon.CheckedChanged += new System.EventHandler(this.RdbNuiteIntervenant_CheckedChanged);
            // 
            // RdbNuiteIntervenantOui
            // 
            this.RdbNuiteIntervenantOui.AutoSize = true;
            this.RdbNuiteIntervenantOui.Location = new System.Drawing.Point(23, 16);
            this.RdbNuiteIntervenantOui.Name = "RdbNuiteIntervenantOui";
            this.RdbNuiteIntervenantOui.Size = new System.Drawing.Size(41, 17);
            this.RdbNuiteIntervenantOui.TabIndex = 22;
            this.RdbNuiteIntervenantOui.Text = "Oui";
            this.RdbNuiteIntervenantOui.UseVisualStyleBackColor = true;
            this.RdbNuiteIntervenantOui.CheckedChanged += new System.EventHandler(this.RdbNuiteIntervenant_CheckedChanged);
            // 
            // PanFonctionIntervenant
            // 
            this.PanFonctionIntervenant.Location = new System.Drawing.Point(305, 4);
            this.PanFonctionIntervenant.Name = "PanFonctionIntervenant";
            this.PanFonctionIntervenant.Size = new System.Drawing.Size(168, 41);
            this.PanFonctionIntervenant.TabIndex = 28;
            // 
            // CmbAtelierIntervenant
            // 
            this.CmbAtelierIntervenant.FormattingEnabled = true;
            this.CmbAtelierIntervenant.Location = new System.Drawing.Point(81, 36);
            this.CmbAtelierIntervenant.Name = "CmbAtelierIntervenant";
            this.CmbAtelierIntervenant.Size = new System.Drawing.Size(218, 21);
            this.CmbAtelierIntervenant.TabIndex = 26;
            this.CmbAtelierIntervenant.TextChanged += new System.EventHandler(this.CmbAtelierIntervenant_TextChanged);
            // 
            // lblAtelierInscription
            // 
            this.lblAtelierInscription.AutoSize = true;
            this.lblAtelierInscription.Location = new System.Drawing.Point(18, 32);
            this.lblAtelierInscription.Name = "lblAtelierInscription";
            this.lblAtelierInscription.Size = new System.Drawing.Size(45, 13);
            this.lblAtelierInscription.TabIndex = 23;
            this.lblAtelierInscription.Text = "Atelier : ";
            // 
            // TabPrincipal
            // 
            this.TabPrincipal.Controls.Add(this.TabInscription);
            this.TabPrincipal.Controls.Add(this.tabAjoutModif);
            this.TabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TabPrincipal.Name = "TabPrincipal";
            this.TabPrincipal.SelectedIndex = 0;
            this.TabPrincipal.Size = new System.Drawing.Size(1145, 605);
            this.TabPrincipal.TabIndex = 0;
            // 
            // tabAjoutModif
            // 
            this.tabAjoutModif.Controls.Add(this.lblElementAjouter);
            this.tabAjoutModif.Controls.Add(this.grpTheme);
            this.tabAjoutModif.Controls.Add(this.grpAtelier);
            this.tabAjoutModif.Controls.Add(this.cmbElement);
            this.tabAjoutModif.Controls.Add(this.grpVacation);
            this.tabAjoutModif.Location = new System.Drawing.Point(4, 22);
            this.tabAjoutModif.Name = "tabAjoutModif";
            this.tabAjoutModif.Size = new System.Drawing.Size(956, 579);
            this.tabAjoutModif.TabIndex = 1;
            this.tabAjoutModif.Text = "Ajouts/modifications";
            this.tabAjoutModif.UseVisualStyleBackColor = true;
            // 
            // lblElementAjouter
            // 
            this.lblElementAjouter.AutoSize = true;
            this.lblElementAjouter.Location = new System.Drawing.Point(235, 37);
            this.lblElementAjouter.Name = "lblElementAjouter";
            this.lblElementAjouter.Size = new System.Drawing.Size(143, 13);
            this.lblElementAjouter.TabIndex = 5;
            this.lblElementAjouter.Text = "Choisir un élément à ajouter :";
            // 
            // grpTheme
            // 
            this.grpTheme.Controls.Add(this.lblThemeAtelier);
            this.grpTheme.Controls.Add(this.cmbThemeAtelier);
            this.grpTheme.Controls.Add(this.btnEnregistrerTheme);
            this.grpTheme.Controls.Add(this.txttheme);
            this.grpTheme.Controls.Add(this.lblThemeNom);
            this.grpTheme.Location = new System.Drawing.Point(138, 122);
            this.grpTheme.Name = "grpTheme";
            this.grpTheme.Size = new System.Drawing.Size(599, 151);
            this.grpTheme.TabIndex = 3;
            this.grpTheme.TabStop = false;
            this.grpTheme.Text = "Ajouter un theme";
            this.grpTheme.Visible = false;
            // 
            // lblThemeAtelier
            // 
            this.lblThemeAtelier.AutoSize = true;
            this.lblThemeAtelier.Location = new System.Drawing.Point(320, 55);
            this.lblThemeAtelier.Name = "lblThemeAtelier";
            this.lblThemeAtelier.Size = new System.Drawing.Size(42, 13);
            this.lblThemeAtelier.TabIndex = 5;
            this.lblThemeAtelier.Text = "Atelier :";
            // 
            // cmbThemeAtelier
            // 
            this.cmbThemeAtelier.FormattingEnabled = true;
            this.cmbThemeAtelier.Location = new System.Drawing.Point(383, 52);
            this.cmbThemeAtelier.Name = "cmbThemeAtelier";
            this.cmbThemeAtelier.Size = new System.Drawing.Size(167, 21);
            this.cmbThemeAtelier.TabIndex = 4;
            // 
            // btnEnregistrerTheme
            // 
            this.btnEnregistrerTheme.Location = new System.Drawing.Point(220, 106);
            this.btnEnregistrerTheme.Name = "btnEnregistrerTheme";
            this.btnEnregistrerTheme.Size = new System.Drawing.Size(91, 27);
            this.btnEnregistrerTheme.TabIndex = 3;
            this.btnEnregistrerTheme.Text = "Ajouter";
            this.btnEnregistrerTheme.UseVisualStyleBackColor = true;
            this.btnEnregistrerTheme.Click += new System.EventHandler(this.btnEnregistrerTheme_Click);
            // 
            // txttheme
            // 
            this.txttheme.Location = new System.Drawing.Point(82, 55);
            this.txttheme.Name = "txttheme";
            this.txttheme.Size = new System.Drawing.Size(193, 20);
            this.txttheme.TabIndex = 1;
            // 
            // lblThemeNom
            // 
            this.lblThemeNom.AutoSize = true;
            this.lblThemeNom.Location = new System.Drawing.Point(41, 55);
            this.lblThemeNom.Name = "lblThemeNom";
            this.lblThemeNom.Size = new System.Drawing.Size(35, 13);
            this.lblThemeNom.TabIndex = 2;
            this.lblThemeNom.Text = "Nom :";
            // 
            // grpAtelier
            // 
            this.grpAtelier.Controls.Add(this.numAtelierNbPlace);
            this.grpAtelier.Controls.Add(this.btnEnregistrerAtelier);
            this.grpAtelier.Controls.Add(this.lblPlaceMaxAtelier);
            this.grpAtelier.Controls.Add(this.lblNomAtelier);
            this.grpAtelier.Controls.Add(this.txtAtelierNom);
            this.grpAtelier.Location = new System.Drawing.Point(138, 120);
            this.grpAtelier.Name = "grpAtelier";
            this.grpAtelier.Size = new System.Drawing.Size(556, 151);
            this.grpAtelier.TabIndex = 4;
            this.grpAtelier.TabStop = false;
            this.grpAtelier.Text = "Ajouter un atelier";
            this.grpAtelier.Visible = false;
            // 
            // numAtelierNbPlace
            // 
            this.numAtelierNbPlace.Location = new System.Drawing.Point(225, 69);
            this.numAtelierNbPlace.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numAtelierNbPlace.Name = "numAtelierNbPlace";
            this.numAtelierNbPlace.Size = new System.Drawing.Size(57, 20);
            this.numAtelierNbPlace.TabIndex = 6;
            // 
            // btnEnregistrerAtelier
            // 
            this.btnEnregistrerAtelier.Location = new System.Drawing.Point(225, 109);
            this.btnEnregistrerAtelier.Name = "btnEnregistrerAtelier";
            this.btnEnregistrerAtelier.Size = new System.Drawing.Size(96, 27);
            this.btnEnregistrerAtelier.TabIndex = 4;
            this.btnEnregistrerAtelier.Text = "Ajouter";
            this.btnEnregistrerAtelier.UseVisualStyleBackColor = true;
            this.btnEnregistrerAtelier.Click += new System.EventHandler(this.btnEnregistrerAtelier_Click);
            // 
            // lblPlaceMaxAtelier
            // 
            this.lblPlaceMaxAtelier.AutoSize = true;
            this.lblPlaceMaxAtelier.Location = new System.Drawing.Point(140, 76);
            this.lblPlaceMaxAtelier.Name = "lblPlaceMaxAtelier";
            this.lblPlaceMaxAtelier.Size = new System.Drawing.Size(67, 13);
            this.lblPlaceMaxAtelier.TabIndex = 3;
            this.lblPlaceMaxAtelier.Text = "Places max :";
            // 
            // lblNomAtelier
            // 
            this.lblNomAtelier.AutoSize = true;
            this.lblNomAtelier.Location = new System.Drawing.Point(172, 41);
            this.lblNomAtelier.Name = "lblNomAtelier";
            this.lblNomAtelier.Size = new System.Drawing.Size(35, 13);
            this.lblNomAtelier.TabIndex = 2;
            this.lblNomAtelier.Text = "Nom :";
            // 
            // txtAtelierNom
            // 
            this.txtAtelierNom.Location = new System.Drawing.Point(225, 38);
            this.txtAtelierNom.Name = "txtAtelierNom";
            this.txtAtelierNom.Size = new System.Drawing.Size(183, 20);
            this.txtAtelierNom.TabIndex = 0;
            // 
            // cmbElement
            // 
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Items.AddRange(new object[] {
            "Atelier",
            "Theme",
            "Vacation"});
            this.cmbElement.Location = new System.Drawing.Point(388, 34);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(121, 21);
            this.cmbElement.TabIndex = 0;
            this.cmbElement.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpVacation
            // 
            this.grpVacation.Controls.Add(this.cmbVacationTheme);
            this.grpVacation.Controls.Add(this.lblVacationTheme);
            this.grpVacation.Controls.Add(this.lblVacationAtelier);
            this.grpVacation.Controls.Add(this.cmbVacationAtelier);
            this.grpVacation.Controls.Add(this.dateFin);
            this.grpVacation.Controls.Add(this.dateDebut);
            this.grpVacation.Controls.Add(this.btnEnregistrerVacation);
            this.grpVacation.Controls.Add(this.lblDateFinVacation);
            this.grpVacation.Controls.Add(this.lblDateDebutVacation);
            this.grpVacation.Location = new System.Drawing.Point(138, 122);
            this.grpVacation.Name = "grpVacation";
            this.grpVacation.Size = new System.Drawing.Size(599, 180);
            this.grpVacation.TabIndex = 4;
            this.grpVacation.TabStop = false;
            this.grpVacation.Text = "Ajouter une vacation";
            this.grpVacation.Visible = false;
            // 
            // cmbVacationTheme
            // 
            this.cmbVacationTheme.FormattingEnabled = true;
            this.cmbVacationTheme.Location = new System.Drawing.Point(425, 104);
            this.cmbVacationTheme.Name = "cmbVacationTheme";
            this.cmbVacationTheme.Size = new System.Drawing.Size(121, 21);
            this.cmbVacationTheme.TabIndex = 11;
            // 
            // lblVacationTheme
            // 
            this.lblVacationTheme.AutoSize = true;
            this.lblVacationTheme.Location = new System.Drawing.Point(462, 88);
            this.lblVacationTheme.Name = "lblVacationTheme";
            this.lblVacationTheme.Size = new System.Drawing.Size(46, 13);
            this.lblVacationTheme.TabIndex = 10;
            this.lblVacationTheme.Text = "Theme :";
            // 
            // lblVacationAtelier
            // 
            this.lblVacationAtelier.AutoSize = true;
            this.lblVacationAtelier.Location = new System.Drawing.Point(462, 29);
            this.lblVacationAtelier.Name = "lblVacationAtelier";
            this.lblVacationAtelier.Size = new System.Drawing.Size(42, 13);
            this.lblVacationAtelier.TabIndex = 8;
            this.lblVacationAtelier.Text = "Atelier :";
            // 
            // cmbVacationAtelier
            // 
            this.cmbVacationAtelier.FormattingEnabled = true;
            this.cmbVacationAtelier.Location = new System.Drawing.Point(425, 45);
            this.cmbVacationAtelier.Name = "cmbVacationAtelier";
            this.cmbVacationAtelier.Size = new System.Drawing.Size(121, 21);
            this.cmbVacationAtelier.TabIndex = 7;
            this.cmbVacationAtelier.SelectedIndexChanged += new System.EventHandler(this.cmbVacationAtelier_SelectedIndexChanged);
            // 
            // dateFin
            // 
            this.dateFin.CustomFormat = "ddd  dd/MM/yyyy  hh:mm";
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(159, 82);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(165, 20);
            this.dateFin.TabIndex = 6;
            // 
            // dateDebut
            // 
            this.dateDebut.CustomFormat = "ddd  dd/MM/yyyy  hh:mm";
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(159, 42);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(165, 20);
            this.dateDebut.TabIndex = 5;
            this.dateDebut.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnEnregistrerVacation
            // 
            this.btnEnregistrerVacation.Location = new System.Drawing.Point(250, 132);
            this.btnEnregistrerVacation.Name = "btnEnregistrerVacation";
            this.btnEnregistrerVacation.Size = new System.Drawing.Size(96, 27);
            this.btnEnregistrerVacation.TabIndex = 4;
            this.btnEnregistrerVacation.Text = "Ajouter";
            this.btnEnregistrerVacation.UseVisualStyleBackColor = true;
            // 
            // lblDateFinVacation
            // 
            this.lblDateFinVacation.AutoSize = true;
            this.lblDateFinVacation.Location = new System.Drawing.Point(72, 89);
            this.lblDateFinVacation.Name = "lblDateFinVacation";
            this.lblDateFinVacation.Size = new System.Drawing.Size(65, 13);
            this.lblDateFinVacation.TabIndex = 1;
            this.lblDateFinVacation.Text = "Date de fin :";
            // 
            // lblDateDebutVacation
            // 
            this.lblDateDebutVacation.AutoSize = true;
            this.lblDateDebutVacation.Location = new System.Drawing.Point(72, 46);
            this.lblDateDebutVacation.Name = "lblDateDebutVacation";
            this.lblDateDebutVacation.Size = new System.Drawing.Size(81, 13);
            this.lblDateDebutVacation.TabIndex = 0;
            this.lblDateDebutVacation.Text = "Date de début :";
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 605);
            this.Controls.Add(this.TabPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipale";
            this.Load += new System.EventHandler(this.FrmPrincipale_Load);
            this.TabInscription.ResumeLayout(false);
            this.GrpBenevole.ResumeLayout(false);
            this.GrpBenevole.PerformLayout();
            this.GrpTypeParticipant.ResumeLayout(false);
            this.GrpTypeParticipant.PerformLayout();
            this.GrpIdentite.ResumeLayout(false);
            this.GrpIdentite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAffiche)).EndInit();
            this.GrpIntervenant.ResumeLayout(false);
            this.GrpIntervenant.PerformLayout();
            this.GrpNuiteIntervenant.ResumeLayout(false);
            this.GrpNuiteIntervenant.PerformLayout();
            this.TabPrincipal.ResumeLayout(false);
            this.tabAjoutModif.ResumeLayout(false);
            this.tabAjoutModif.PerformLayout();
            this.grpTheme.ResumeLayout(false);
            this.grpTheme.PerformLayout();
            this.grpAtelier.ResumeLayout(false);
            this.grpAtelier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAtelierNbPlace)).EndInit();
            this.grpVacation.ResumeLayout(false);
            this.grpVacation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabInscription;
        private System.Windows.Forms.GroupBox GrpBenevole;
        private System.Windows.Forms.Button BtnEnregistreBenevole;
        private System.Windows.Forms.Panel PanelDispoBenevole;
        private System.Windows.Forms.MaskedTextBox TxtLicenceBenevole;
        private System.Windows.Forms.Label lblDdn;
        private System.Windows.Forms.Label lblNumLicence;
        private System.Windows.Forms.MaskedTextBox TxtDateNaissance;
        private System.Windows.Forms.Button CmdQuitter;
        private System.Windows.Forms.GroupBox GrpTypeParticipant;
        private System.Windows.Forms.RadioButton RadLicencie;
        private System.Windows.Forms.RadioButton RadBenevole;
        private System.Windows.Forms.RadioButton RadIntervenant;
        private System.Windows.Forms.GroupBox GrpIdentite;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox TxtCp;
        private System.Windows.Forms.TextBox TxtVille;
        private System.Windows.Forms.TextBox TxtAdr2;
        private System.Windows.Forms.TextBox TxtAdr1;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox PicAffiche;
        private System.Windows.Forms.GroupBox GrpIntervenant;
        private System.Windows.Forms.Button BtnEnregistrerIntervenant;
        private System.Windows.Forms.GroupBox GrpNuiteIntervenant;
        private System.Windows.Forms.Panel PanNuiteIntervenant;
        private System.Windows.Forms.RadioButton RdbNuiteIntervenantNon;
        private System.Windows.Forms.RadioButton RdbNuiteIntervenantOui;
        private System.Windows.Forms.Panel PanFonctionIntervenant;
        private System.Windows.Forms.ComboBox CmbAtelierIntervenant;
        private System.Windows.Forms.Label lblAtelierInscription;
        private System.Windows.Forms.TabControl TabPrincipal;
        private System.Windows.Forms.TabPage tabAjoutModif;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.GroupBox grpTheme;
        private System.Windows.Forms.TextBox txttheme;
        private System.Windows.Forms.Label lblThemeNom;
        private System.Windows.Forms.GroupBox grpAtelier;
        private System.Windows.Forms.Button btnEnregistrerAtelier;
        private System.Windows.Forms.Label lblPlaceMaxAtelier;
        private System.Windows.Forms.Label lblNomAtelier;
        private System.Windows.Forms.TextBox txtAtelierNom;
        private System.Windows.Forms.Button btnEnregistrerTheme;
        private System.Windows.Forms.GroupBox grpVacation;
        private System.Windows.Forms.Label lblDateFinVacation;
        private System.Windows.Forms.Label lblDateDebutVacation;
        private System.Windows.Forms.Button btnEnregistrerVacation;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.ComboBox cmbVacationTheme;
        private System.Windows.Forms.Label lblVacationTheme;
        private System.Windows.Forms.Label lblVacationAtelier;
        private System.Windows.Forms.ComboBox cmbVacationAtelier;
        private System.Windows.Forms.Label lblThemeAtelier;
        private System.Windows.Forms.ComboBox cmbThemeAtelier;
        private System.Windows.Forms.Label lblElementAjouter;
        private System.Windows.Forms.NumericUpDown numAtelierNbPlace;


    }
}