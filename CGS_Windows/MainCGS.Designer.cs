namespace CGS_Windows
{
    partial class MainCGS
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
            this.FileTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnViewCurator = new System.Windows.Forms.Button();
            this.btnSaveCurator = new System.Windows.Forms.Button();
            this.btnAddCurator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveArtist = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArtistId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastNameArtist = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirstNameArtist = new System.Windows.Forms.TextBox();
            this.btnViewArtist = new System.Windows.Forms.Button();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnInStore = new System.Windows.Forms.RadioButton();
            this.rbtnOnDisplay = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtArtPieceCuratorId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtArtPieceArtistId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtArtPieceValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtArtPieceYear = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArtPieceTittle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtArtPieceId = new System.Windows.Forms.TextBox();
            this.btnListPieces = new System.Windows.Forms.Button();
            this.btnSellArtPiece = new System.Windows.Forms.Button();
            this.btnAddArtPiece = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSavePieces = new System.Windows.Forms.Button();
            this.FileTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileTab
            // 
            this.FileTab.Controls.Add(this.tabPage1);
            this.FileTab.Controls.Add(this.tabPage2);
            this.FileTab.Controls.Add(this.tabPage3);
            this.FileTab.Location = new System.Drawing.Point(16, 72);
            this.FileTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileTab.Name = "FileTab";
            this.FileTab.SelectedIndex = 0;
            this.FileTab.Size = new System.Drawing.Size(515, 320);
            this.FileTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.btnViewCurator);
            this.tabPage1.Controls.Add(this.btnSaveCurator);
            this.tabPage1.Controls.Add(this.btnAddCurator);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(507, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Curators";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(92, 79);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(239, 22);
            this.txtId.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(92, 50);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(239, 22);
            this.txtLastName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(92, 26);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(239, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // btnViewCurator
            // 
            this.btnViewCurator.Location = new System.Drawing.Point(398, 251);
            this.btnViewCurator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewCurator.Name = "btnViewCurator";
            this.btnViewCurator.Size = new System.Drawing.Size(103, 37);
            this.btnViewCurator.TabIndex = 3;
            this.btnViewCurator.Text = "View Curator";
            this.btnViewCurator.UseVisualStyleBackColor = true;
            this.btnViewCurator.Click += new System.EventHandler(this.btnViewCurator_Click);
            // 
            // btnSaveCurator
            // 
            this.btnSaveCurator.Location = new System.Drawing.Point(398, 208);
            this.btnSaveCurator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveCurator.Name = "btnSaveCurator";
            this.btnSaveCurator.Size = new System.Drawing.Size(103, 37);
            this.btnSaveCurator.TabIndex = 2;
            this.btnSaveCurator.Text = "Save Curator";
            this.btnSaveCurator.UseVisualStyleBackColor = true;
            this.btnSaveCurator.Click += new System.EventHandler(this.btnSaveCurator_Click);
            // 
            // btnAddCurator
            // 
            this.btnAddCurator.Location = new System.Drawing.Point(398, 165);
            this.btnAddCurator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCurator.Name = "btnAddCurator";
            this.btnAddCurator.Size = new System.Drawing.Size(103, 37);
            this.btnAddCurator.TabIndex = 1;
            this.btnAddCurator.Text = "Add Curator";
            this.btnAddCurator.UseVisualStyleBackColor = true;
            this.btnAddCurator.Click += new System.EventHandler(this.btnAddCurator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curator information:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage2.Controls.Add(this.btnSaveArtist);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtArtistId);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtLastNameArtist);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtFirstNameArtist);
            this.tabPage2.Controls.Add(this.btnViewArtist);
            this.tabPage2.Controls.Add(this.btnAddArtist);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(507, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artist";
            // 
            // btnSaveArtist
            // 
            this.btnSaveArtist.Location = new System.Drawing.Point(398, 209);
            this.btnSaveArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveArtist.Name = "btnSaveArtist";
            this.btnSaveArtist.Size = new System.Drawing.Size(103, 37);
            this.btnSaveArtist.TabIndex = 16;
            this.btnSaveArtist.Text = "Save Artist";
            this.btnSaveArtist.UseVisualStyleBackColor = true;
            this.btnSaveArtist.Click += new System.EventHandler(this.btnSaveArtist_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID:";
            // 
            // txtArtistId
            // 
            this.txtArtistId.Location = new System.Drawing.Point(92, 79);
            this.txtArtistId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtistId.Name = "txtArtistId";
            this.txtArtistId.Size = new System.Drawing.Size(239, 22);
            this.txtArtistId.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Last Name:";
            // 
            // txtLastNameArtist
            // 
            this.txtLastNameArtist.Location = new System.Drawing.Point(92, 50);
            this.txtLastNameArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastNameArtist.Name = "txtLastNameArtist";
            this.txtLastNameArtist.Size = new System.Drawing.Size(239, 22);
            this.txtLastNameArtist.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "First Name:";
            // 
            // txtFirstNameArtist
            // 
            this.txtFirstNameArtist.Location = new System.Drawing.Point(92, 26);
            this.txtFirstNameArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstNameArtist.Name = "txtFirstNameArtist";
            this.txtFirstNameArtist.Size = new System.Drawing.Size(239, 22);
            this.txtFirstNameArtist.TabIndex = 10;
            // 
            // btnViewArtist
            // 
            this.btnViewArtist.Location = new System.Drawing.Point(398, 250);
            this.btnViewArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewArtist.Name = "btnViewArtist";
            this.btnViewArtist.Size = new System.Drawing.Size(103, 37);
            this.btnViewArtist.TabIndex = 6;
            this.btnViewArtist.Text = "View Artist";
            this.btnViewArtist.UseVisualStyleBackColor = true;
            this.btnViewArtist.Click += new System.EventHandler(this.btnViewArtist_Click);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(398, 168);
            this.btnAddArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(103, 37);
            this.btnAddArtist.TabIndex = 5;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist information:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage3.Controls.Add(this.btnSavePieces);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtArtPieceCuratorId);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.txtArtPieceArtistId);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtArtPieceValue);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtArtPieceYear);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtArtPieceTittle);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtArtPieceId);
            this.tabPage3.Controls.Add(this.btnListPieces);
            this.tabPage3.Controls.Add(this.btnSellArtPiece);
            this.tabPage3.Controls.Add(this.btnAddArtPiece);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(507, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ArtPieces";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnInStore);
            this.groupBox1.Controls.Add(this.rbtnOnDisplay);
            this.groupBox1.Location = new System.Drawing.Point(385, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 82);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rbtnInStore
            // 
            this.rbtnInStore.AutoSize = true;
            this.rbtnInStore.Location = new System.Drawing.Point(7, 47);
            this.rbtnInStore.Name = "rbtnInStore";
            this.rbtnInStore.Size = new System.Drawing.Size(73, 20);
            this.rbtnInStore.TabIndex = 1;
            this.rbtnInStore.Text = "In Store";
            this.rbtnInStore.UseVisualStyleBackColor = true;
            // 
            // rbtnOnDisplay
            // 
            this.rbtnOnDisplay.AutoSize = true;
            this.rbtnOnDisplay.Checked = true;
            this.rbtnOnDisplay.Location = new System.Drawing.Point(7, 21);
            this.rbtnOnDisplay.Name = "rbtnOnDisplay";
            this.rbtnOnDisplay.Size = new System.Drawing.Size(94, 20);
            this.rbtnOnDisplay.TabIndex = 0;
            this.rbtnOnDisplay.TabStop = true;
            this.rbtnOnDisplay.Text = "On Display";
            this.rbtnOnDisplay.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Curator ID:";
            // 
            // txtArtPieceCuratorId
            // 
            this.txtArtPieceCuratorId.Location = new System.Drawing.Point(93, 160);
            this.txtArtPieceCuratorId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtPieceCuratorId.Name = "txtArtPieceCuratorId";
            this.txtArtPieceCuratorId.Size = new System.Drawing.Size(239, 22);
            this.txtArtPieceCuratorId.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "Artist ID:";
            // 
            // txtArtPieceArtistId
            // 
            this.txtArtPieceArtistId.Location = new System.Drawing.Point(93, 132);
            this.txtArtPieceArtistId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtPieceArtistId.Name = "txtArtPieceArtistId";
            this.txtArtPieceArtistId.Size = new System.Drawing.Size(239, 22);
            this.txtArtPieceArtistId.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "Value:";
            // 
            // txtArtPieceValue
            // 
            this.txtArtPieceValue.Location = new System.Drawing.Point(93, 107);
            this.txtArtPieceValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtPieceValue.Name = "txtArtPieceValue";
            this.txtArtPieceValue.Size = new System.Drawing.Size(239, 22);
            this.txtArtPieceValue.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Year:";
            // 
            // txtArtPieceYear
            // 
            this.txtArtPieceYear.Location = new System.Drawing.Point(93, 79);
            this.txtArtPieceYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtPieceYear.Name = "txtArtPieceYear";
            this.txtArtPieceYear.Size = new System.Drawing.Size(239, 22);
            this.txtArtPieceYear.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tittle:";
            // 
            // txtArtPieceTittle
            // 
            this.txtArtPieceTittle.Location = new System.Drawing.Point(93, 50);
            this.txtArtPieceTittle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtPieceTittle.Name = "txtArtPieceTittle";
            this.txtArtPieceTittle.Size = new System.Drawing.Size(239, 22);
            this.txtArtPieceTittle.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "ID:";
            // 
            // txtArtPieceId
            // 
            this.txtArtPieceId.Location = new System.Drawing.Point(93, 26);
            this.txtArtPieceId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtPieceId.Name = "txtArtPieceId";
            this.txtArtPieceId.Size = new System.Drawing.Size(239, 22);
            this.txtArtPieceId.TabIndex = 16;
            // 
            // btnListPieces
            // 
            this.btnListPieces.Location = new System.Drawing.Point(397, 250);
            this.btnListPieces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListPieces.Name = "btnListPieces";
            this.btnListPieces.Size = new System.Drawing.Size(103, 37);
            this.btnListPieces.TabIndex = 6;
            this.btnListPieces.Text = "List Pieces";
            this.btnListPieces.UseVisualStyleBackColor = true;
            this.btnListPieces.Click += new System.EventHandler(this.btnListPieces_Click);
            // 
            // btnSellArtPiece
            // 
            this.btnSellArtPiece.Location = new System.Drawing.Point(397, 169);
            this.btnSellArtPiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSellArtPiece.Name = "btnSellArtPiece";
            this.btnSellArtPiece.Size = new System.Drawing.Size(103, 37);
            this.btnSellArtPiece.TabIndex = 5;
            this.btnSellArtPiece.Text = "Sell Art Piece";
            this.btnSellArtPiece.UseVisualStyleBackColor = true;
            // 
            // btnAddArtPiece
            // 
            this.btnAddArtPiece.Location = new System.Drawing.Point(397, 128);
            this.btnAddArtPiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddArtPiece.Name = "btnAddArtPiece";
            this.btnAddArtPiece.Size = new System.Drawing.Size(103, 37);
            this.btnAddArtPiece.TabIndex = 4;
            this.btnAddArtPiece.Text = "Add Art Piece";
            this.btnAddArtPiece.UseVisualStyleBackColor = true;
            this.btnAddArtPiece.Click += new System.EventHandler(this.btnAddArtPiece_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Art piece information:";
            // 
            // rtxtBox1
            // 
            this.rtxtBox1.Location = new System.Drawing.Point(16, 396);
            this.rtxtBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtBox1.Name = "rtxtBox1";
            this.rtxtBox1.Size = new System.Drawing.Size(515, 75);
            this.rtxtBox1.TabIndex = 1;
            this.rtxtBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(545, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(431, 31);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSavePieces
            // 
            this.btnSavePieces.Location = new System.Drawing.Point(397, 209);
            this.btnSavePieces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePieces.Name = "btnSavePieces";
            this.btnSavePieces.Size = new System.Drawing.Size(103, 37);
            this.btnSavePieces.TabIndex = 29;
            this.btnSavePieces.Text = "Save Pieces";
            this.btnSavePieces.UseVisualStyleBackColor = true;
            this.btnSavePieces.Click += new System.EventHandler(this.btnSavePieces_Click);
            // 
            // MainCGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(545, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtxtBox1);
            this.Controls.Add(this.FileTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainCGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main CGS Gallery";
            this.FileTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl FileTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtxtBox1;
        private System.Windows.Forms.Button btnViewCurator;
        private System.Windows.Forms.Button btnSaveCurator;
        private System.Windows.Forms.Button btnAddCurator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListPieces;
        private System.Windows.Forms.Button btnSellArtPiece;
        private System.Windows.Forms.Button btnAddArtPiece;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtArtistId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLastNameArtist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirstNameArtist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtArtPieceCuratorId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtArtPieceArtistId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtArtPieceValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtArtPieceYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArtPieceTittle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtArtPieceId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnInStore;
        private System.Windows.Forms.RadioButton rbtnOnDisplay;
        private System.Windows.Forms.Button btnSaveArtist;
        private System.Windows.Forms.Button btnSavePieces;
    }
}