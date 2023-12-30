VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.MDIForm frmMain 
   BackColor       =   &H8000000C&
   Caption         =   "Editor Web"
   ClientHeight    =   5535
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   8880
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin MSComDlg.CommonDialog dlgCommonDialog 
      Left            =   4440
      Top             =   2280
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComctlLib.Toolbar tbToolBar 
      Align           =   1  'Align Top
      Height          =   420
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   8880
      _ExtentX        =   15663
      _ExtentY        =   741
      ButtonWidth     =   609
      ButtonHeight    =   582
      Appearance      =   1
      ImageList       =   "imlToolbarIcons"
      _Version        =   393216
      BeginProperty Buttons {66833FE8-8583-11D1-B16A-00C0F0283628} 
         NumButtons      =   40
         BeginProperty Button1 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button2 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "New"
            Object.ToolTipText     =   "New"
            ImageKey        =   "New"
         EndProperty
         BeginProperty Button3 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Open"
            Object.ToolTipText     =   "Open"
            ImageKey        =   "Open"
         EndProperty
         BeginProperty Button4 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Save"
            Object.ToolTipText     =   "Save"
            ImageKey        =   "Save"
         EndProperty
         BeginProperty Button5 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button6 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Print"
            Object.ToolTipText     =   "Print"
            ImageKey        =   "Print"
         EndProperty
         BeginProperty Button7 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button8 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Cut"
            Object.ToolTipText     =   "Cut"
            ImageKey        =   "Cut"
         EndProperty
         BeginProperty Button9 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Copy"
            Object.ToolTipText     =   "Copy"
            ImageKey        =   "Copy"
         EndProperty
         BeginProperty Button10 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Paste"
            Object.ToolTipText     =   "Paste"
            ImageKey        =   "Paste"
         EndProperty
         BeginProperty Button11 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button12 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Undo"
            Object.ToolTipText     =   "Undo"
            ImageKey        =   "Undo"
         EndProperty
         BeginProperty Button13 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Redo"
            Object.ToolTipText     =   "Redo"
            ImageKey        =   "Redo"
         EndProperty
         BeginProperty Button14 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button15 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Find"
            Object.ToolTipText     =   "Find"
            ImageKey        =   "Find"
         EndProperty
         BeginProperty Button16 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button17 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   4
         EndProperty
         BeginProperty Button18 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button19 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button20 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button21 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button22 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button23 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button24 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button25 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button26 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button27 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button28 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button29 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
            BeginProperty ButtonMenus {66833FEC-8583-11D1-B16A-00C0F0283628} 
               NumButtonMenus  =   21
               BeginProperty ButtonMenu1 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu2 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu3 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu4 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu5 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu6 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu7 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu8 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu9 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu10 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu11 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu12 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu13 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu14 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu15 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu16 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu17 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu18 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu19 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu20 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
               BeginProperty ButtonMenu21 {66833FEE-8583-11D1-B16A-00C0F0283628} 
               EndProperty
            EndProperty
         EndProperty
         BeginProperty Button30 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button31 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button32 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button33 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button34 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button35 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   4
            Object.Width           =   2
         EndProperty
         BeginProperty Button36 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Browser"
            Object.ToolTipText     =   "Browser"
            ImageKey        =   "Forward"
         EndProperty
         BeginProperty Button37 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Help"
            Object.ToolTipText     =   "Help"
            ImageKey        =   "Help"
         EndProperty
         BeginProperty Button38 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Style           =   3
         EndProperty
         BeginProperty Button39 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Properties"
            Object.ToolTipText     =   "Properties"
            ImageKey        =   "Properties"
         EndProperty
         BeginProperty Button40 {66833FEA-8583-11D1-B16A-00C0F0283628} 
            Key             =   "Option"
            Object.ToolTipText     =   "Option"
            ImageKey        =   "Option"
         EndProperty
      EndProperty
      Begin VB.CommandButton cmdFind 
         Caption         =   "Find >>"
         Height          =   330
         Left            =   5640
         TabIndex        =   5
         Top             =   35
         Width           =   700
      End
      Begin VB.ComboBox comSize 
         Height          =   315
         Left            =   10155
         TabIndex        =   3
         Text            =   "11"
         Top             =   35
         Width           =   660
      End
      Begin VB.ComboBox comfont 
         Height          =   315
         Left            =   8055
         TabIndex        =   2
         Text            =   " Times New Roman"
         Top             =   35
         Width           =   2055
      End
      Begin VB.ComboBox comfind 
         Height          =   315
         Left            =   4080
         TabIndex        =   1
         Text            =   " "
         ToolTipText     =   "Find"
         Top             =   35
         Width           =   1500
      End
   End
   Begin MSComctlLib.ImageList imlToolbarIcons 
      Left            =   1740
      Top             =   1350
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   16
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":030A
            Key             =   "New"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":041C
            Key             =   "Open"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":052E
            Key             =   "Save"
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0640
            Key             =   "Print"
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0752
            Key             =   "Cut"
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0864
            Key             =   "Copy"
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0976
            Key             =   "Paste"
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0A88
            Key             =   "Undo"
         EndProperty
         BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0B9A
            Key             =   "Redo"
         EndProperty
         BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0CAC
            Key             =   "Forward"
         EndProperty
         BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0DBE
            Key             =   "Find"
         EndProperty
         BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0ED0
            Key             =   "Help"
         EndProperty
         BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":0FE2
            Key             =   "Properties"
         EndProperty
         BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":10F4
            Key             =   "Freeform"
         EndProperty
         BeginProperty ListImage15 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":1206
            Key             =   "Option"
         EndProperty
         BeginProperty ListImage16 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmMain.frx":165A
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.StatusBar sbStatusBar 
      Align           =   2  'Align Bottom
      Height          =   270
      Left            =   0
      TabIndex        =   4
      Top             =   5265
      Width           =   8880
      _ExtentX        =   15663
      _ExtentY        =   476
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   4
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   1
            Object.Width           =   7452
            MinWidth        =   5997
            Text            =   "Status"
            TextSave        =   "Status"
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   1
            Enabled         =   0   'False
            Text            =   "CapsLock"
            TextSave        =   "CAPS"
         EndProperty
         BeginProperty Panel3 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Style           =   3
            Enabled         =   0   'False
            Text            =   "Insert"
            TextSave        =   "INS"
         EndProperty
         BeginProperty Panel4 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   2
         EndProperty
      EndProperty
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Menu MnuFile 
      Caption         =   "  &File"
      Begin VB.Menu mnuFileNew 
         Caption         =   "&New"
         Shortcut        =   ^N
      End
      Begin VB.Menu mnuFileOpen 
         Caption         =   "&Open..."
         Shortcut        =   ^O
      End
      Begin VB.Menu mnuFileBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileSave 
         Caption         =   "&Save"
         Shortcut        =   ^S
      End
      Begin VB.Menu mnuFileSaveAs 
         Caption         =   "Save &As..."
      End
      Begin VB.Menu mnutti 
         Caption         =   "-"
      End
      Begin VB.Menu mnuPrint 
         Caption         =   "&Print"
         Shortcut        =   ^{F4}
      End
      Begin VB.Menu mnuFileBar3 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFileMRU 
         Caption         =   ""
         Index           =   1
         Visible         =   0   'False
      End
      Begin VB.Menu mnuFileMRU 
         Caption         =   ""
         Index           =   3
         Visible         =   0   'False
      End
      Begin VB.Menu mnuFileBar4 
         Caption         =   "-"
         Visible         =   0   'False
      End
      Begin VB.Menu mnuFileExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuEdit 
      Caption         =   "&Edit"
      Begin VB.Menu mnuEditUndo 
         Caption         =   "&Undo"
         Shortcut        =   ^Z
      End
      Begin VB.Menu mnuRedo 
         Caption         =   "Redo"
      End
      Begin VB.Menu mnuEditBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuEditDelete 
         Caption         =   "&Delete                           "
         Shortcut        =   {DEL}
      End
      Begin VB.Menu mnuEditCut 
         Caption         =   "Cu&t"
         Shortcut        =   +{DEL}
      End
      Begin VB.Menu mnuEditCopy 
         Caption         =   "&Copy"
         Shortcut        =   +{INSERT}
      End
      Begin VB.Menu mnuEditPaste 
         Caption         =   "&Paste"
         Shortcut        =   ^{INSERT}
      End
      Begin VB.Menu mnuAll 
         Caption         =   "Select &All"
         Shortcut        =   ^A
      End
      Begin VB.Menu mnuBp 
         Caption         =   "-"
      End
      Begin VB.Menu MnuFind 
         Caption         =   "&Find"
         Shortcut        =   {F3}
      End
      Begin VB.Menu mnuReplace 
         Caption         =   "&Replace"
      End
   End
   Begin VB.Menu mnuView 
      Caption         =   "&View"
      Begin VB.Menu mnuViewToolbar 
         Caption         =   "&Toolbar"
         Checked         =   -1  'True
      End
      Begin VB.Menu mnuViewStatusBar 
         Caption         =   "Status &Bar"
         Checked         =   -1  'True
      End
      Begin VB.Menu mnuww 
         Caption         =   "-"
      End
      Begin VB.Menu mnuProject 
         Caption         =   "Project and Properties             "
      End
      Begin VB.Menu mnuViewBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFull 
         Caption         =   "FullScreen"
      End
   End
   Begin VB.Menu mnuHTML 
      Caption         =   "HTM&L"
      Begin VB.Menu mnuDiv 
         Caption         =   "&Div..."
      End
      Begin VB.Menu mnuform 
         Caption         =   "&Form"
      End
      Begin VB.Menu mnuhead 
         Caption         =   "&Head"
         Begin VB.Menu mnuh 
            Caption         =   "H&1"
            Index           =   1
         End
         Begin VB.Menu mnuh 
            Caption         =   "H&2"
            Index           =   2
         End
         Begin VB.Menu mnuh 
            Caption         =   "H&3"
            Index           =   3
         End
         Begin VB.Menu mnuh 
            Caption         =   "H&4"
            Index           =   4
         End
         Begin VB.Menu mnuh 
            Caption         =   "H&5"
            Index           =   5
         End
         Begin VB.Menu mnuh 
            Caption         =   "H&6"
            Index           =   6
         End
      End
      Begin VB.Menu mnuSpan 
         Caption         =   "S&pan"
      End
      Begin VB.Menu mnuImage 
         Caption         =   "&Image..."
      End
      Begin VB.Menu mnuMarquee 
         Caption         =   "Mar&quee"
      End
      Begin VB.Menu mnuTable 
         Caption         =   "&Table"
      End
      Begin VB.Menu mnuHyperlink 
         Caption         =   "HyperLin&k                    "
         Shortcut        =   ^K
      End
      Begin VB.Menu mnuBook 
         Caption         =   "Boorma&rk"
         Shortcut        =   ^R
      End
      Begin VB.Menu mnuthoi 
         Caption         =   "-"
         Index           =   2
      End
      Begin VB.Menu mnuBreak 
         Caption         =   "&Break..."
      End
      Begin VB.Menu mnuHorizoltal 
         Caption         =   "&Horizoltal..."
      End
      Begin VB.Menu mnucomment 
         Caption         =   "Co&mment"
      End
      Begin VB.Menu mnuB 
         Caption         =   "-"
      End
      Begin VB.Menu mnuScript 
         Caption         =   "&Script Block"
         Begin VB.Menu mnuClient 
            Caption         =   "&Client"
         End
         Begin VB.Menu mnuServer 
            Caption         =   "&Server"
         End
      End
   End
   Begin VB.Menu mnuTool 
      Caption         =   "&Tools"
      Begin VB.Menu mnuProcudure 
         Caption         =   "Add Procedure ...                "
      End
      Begin VB.Menu mnuQ 
         Caption         =   "-"
      End
      Begin VB.Menu mnuOption 
         Caption         =   "&Option"
      End
   End
   Begin VB.Menu mnuWindow 
      Caption         =   "&Window"
      WindowList      =   -1  'True
      Begin VB.Menu mnuAdressURL 
         Caption         =   "View &Links on WWW...                      "
      End
      Begin VB.Menu mnijjj 
         Caption         =   "-"
      End
      Begin VB.Menu mnuBold 
         Caption         =   "&Bold"
      End
      Begin VB.Menu mnuItalic 
         Caption         =   "&Italic"
      End
      Begin VB.Menu mnuUnderline 
         Caption         =   "&Underline"
      End
      Begin VB.Menu mnuWindowBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnusuper 
         Caption         =   "Supe&rscript"
      End
      Begin VB.Menu mnuSub 
         Caption         =   "Su&bscript"
      End
      Begin VB.Menu mnuuu 
         Caption         =   "-"
      End
      Begin VB.Menu mnuSubs 
         Caption         =   "&Substitute"
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "&Help"
      Begin VB.Menu mnuHelpContents 
         Caption         =   "&Contents                         "
      End
      Begin VB.Menu mnuHelpBar0 
         Caption         =   "-"
      End
      Begin VB.Menu mnuHelpAbout 
         Caption         =   "&About ..."
      End
   End
   Begin VB.Menu MnuTat 
      Caption         =   "MenuTat"
      Visible         =   0   'False
      Begin VB.Menu mnuUn 
         Caption         =   "Undo             "
      End
      Begin VB.Menu mnuiii 
         Caption         =   "-"
      End
      Begin VB.Menu Mnucut 
         Caption         =   "Cu&t                                 "
      End
      Begin VB.Menu mnuCopy 
         Caption         =   "&Copy"
      End
      Begin VB.Menu mnuPaste 
         Caption         =   "&Paste"
      End
      Begin VB.Menu mnudel 
         Caption         =   "De&lete"
      End
      Begin VB.Menu mnutroi 
         Caption         =   "-"
      End
      Begin VB.Menu mnuSeAll 
         Caption         =   "Select &All"
      End
      Begin VB.Menu mnuooo 
         Caption         =   "-"
      End
      Begin VB.Menu mnuFi 
         Caption         =   "&Find"
      End
      Begin VB.Menu mnuyyy 
         Caption         =   "-"
      End
      Begin VB.Menu mnuSRi 
         Caption         =   "Script &Block"
         Begin VB.Menu mnuEli 
            Caption         =   "Clien&t"
         End
         Begin VB.Menu mnuSer 
            Caption         =   "Ser&ver"
         End
      End
      Begin VB.Menu mnuii 
         Caption         =   "-"
      End
      Begin VB.Menu mnuClose 
         Caption         =   "Cl&ose"
         Shortcut        =   +^{F4}
      End
   End
   Begin VB.Menu MnuFileA 
      Caption         =   "F&ileA"
      Visible         =   0   'False
      Begin VB.Menu MnuAdd 
         Caption         =   "&Add File"
      End
      Begin VB.Menu mnuOpenFile 
         Caption         =   "O&pen File"
      End
      Begin VB.Menu mnuSaveS 
         Caption         =   "&Save"
      End
      Begin VB.Menu mnuSave 
         Caption         =   "SaveAs &File"
      End
      Begin VB.Menu mnuttt 
         Caption         =   "-"
      End
      Begin VB.Menu mnuRemove 
         Caption         =   "&Remove Form Project..."
      End
      Begin VB.Menu mnui 
         Caption         =   "-"
      End
      Begin VB.Menu mnuBrowser 
         Caption         =   "Browser With..."
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public BlackColor As Boolean
Public Flag As Boolean
Public RowCol As Boolean
Public VarHelp As Boolean
Private Sub LoadNewDoc()
   On Error Resume Next
    frmDoc.Show 1
    frmDoc.Left = 2700
    frmDoc.Enabled = True
    frmFile.Show 1
    frmProperties.Show 1
    frmFile.Move 0, 0, frmDoc.Left, fMainForm.Height - frmProperties.Height  ' .Left = 0: frmFile.Top = 0: frmFile.Height = 2200: frmFile.Width = 2700:
    frmOpen.Show 1
End Sub

Private Sub cmdFind_Click()
Static Find  As Long
Find = InStr(Find + 1, frmDoc.rtfSource.Text, Trim(comFind.Text), vbTextCompare)
   If Find <> 0 Then
      frmDoc.rtfSource.SelStart = Find - 1  ' set selection start and
      frmDoc.rtfSource.SelLength = Len(Trim(comFind.Text))
   Else
      MsgBox "The specified region has been searched .", vbInformation
   End If
End Sub

Private Sub comfind_KeyDown(KeyCode As Integer, Shift As Integer)
   If KeyCode = 13 Then
      cmdFind_Click
   End If
End Sub

Private Sub comFont_GotFocus()
Dim i As Integer, Font As String
If Trim(comfont.Text) <> vbNullString Then
   Font = comfont.Text
   comfont.Clear
   comfont.Text = Font
   For i = 0 To Screen.FontCount - 1
       comfont.AddItem Screen.Fonts(i)
   Next
End If
End Sub
Private Sub comFont_Click()
   If Trim(comfont.Text) <> vbNullString Then frmDoc.rtfSource.Font = comfont.Text
End Sub
Private Sub comSize_Click()
   If Trim(comSize.Text) <> vbNullString Then frmDoc.rtfSource.Font.Size = comSize.Text
End Sub
  
Private Sub comSize_GotFocus()
Dim i As Byte, Size As Byte
If Trim(comSize.Text) <> vbNullString Then
   Size = Val(comSize.Text)
   comSize.Clear
   comSize.Text = Size
   For i = 7 To 25
       comSize.AddItem i
   Next
End If
End Sub
Private Sub MDIForm_Load()
On Error Resume Next
   LoadNewDoc
   MkDir App.path & "\htmlAsp\"
End Sub

Private Sub MDIForm_QueryUnload(Cancel As Integer, UnloadMode As Integer)
   frmSave.Show 1
   If ExitForm = True Then Cancel = True Else Cancel = False
End Sub

Private Sub mnuAdressURL_Click()
   frmAddress.Show 1
End Sub

Private Sub mnuAll_Click()
   frmDoc.rtfSource.SelStart = 0
   frmDoc.rtfSource.SelLength = Len(Trim(frmDoc.rtfSource.Text))
   frmDoc.rtfSource.SetFocus
End Sub
Private Sub mnuBold_Click()
   frmDoc.rtfSource.SelText = "<STRONG> " & frmDoc.rtfSource.SelText & " </STRONG>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
End Sub

Private Sub mnuBrowser_Click()
   If frmDoc.SSTab.Tab = 0 And frmDoc.SSTab.TabEnabled(0) = True Then frmDoc.SSTab.Tab = 1
End Sub

Private Sub mnuDiv_Click()
   Div_Sub = True
   frmDiv_Sub.Show 1
End Sub

Private Sub mnuEditUndo_Click()
   If tempUndo > 0 Then
      frmDoc.rtfSource.Text = Undo(tempUndo)
      tempUndo = tempUndo - 1
   Else
      MsgBox "Can't Undo", vbInformation + vbOKOnly
   End If
End Sub

Public Sub mnuFileSave_Click()
Dim sFile As String
   If Left(frmDoc.Caption, 7) = "NewPage" Then
      With dlgCommonDialog
         .DialogTitle = "Save"
         .Filter = "Common Web File(*.htm;*.html;*.asp)|*.htm;*.html;*.asp|Global Server File(*.asa)|*.asa|Text(*.txt;*.css)|*.txt;*.css"
         .ShowSave
         .CancelError = False
         If Len(.FileName) = 0 Then Exit Sub
         sFile = .FileName
         .FileName = ""
         frmDoc.rtfSource.SaveFile sFile, rtfText
         frmDoc.Caption = sFile
         frmFile.TreeView1.Nodes(Public_Node).Text = sFile
      End With
   Else
      frmDoc.rtfSource.SaveFile Trim(frmDoc.Caption), rtfText
   End If
End Sub

Private Sub mnuFileSaveAs_Click()
Dim sFile As String
   With dlgCommonDialog
      .DialogTitle = "Save"
      .Filter = "Common Web File(*.htm;*.html;*.asp)|*.htm;*.html;*.asp|Global Server File(*.asa)|*.asaText(*.txt;*.css)|*.txt;*.css|Text(*.txt;*.css)|*.txt;*.css"
      .ShowSave
      .CancelError = False
      If Len(.FileName) = 0 Then Exit Sub
      sFile = .FileName
      .FileName = ""
      frmDoc.rtfSource.SaveFile sFile, rtfText
      frmDoc.Caption = sFile
      frmFile.TreeView1.Nodes(Public_Node).Text = sFile
   End With
End Sub

Private Sub MnuFind_Click()
   frmFind.Caption = "Find"
   frmFind.comReplace.Visible = False
   frmFind.Show
End Sub

Private Sub mnuOption_Click()
   frmOption.Show 1
End Sub

Private Sub mnuPrint_Click()
On Error Resume Next
   With dlgCommonDialog
      .Action = 5
      .CancelError = False
      .Filter = "Common Web File(*.htm;*.html;*.asp)|*.htm;*.html;*.asp|Global Server File(*.asa)|*.asaText(*.txt;*.css)|*.txt;*.css|Text(*.txt;*.css)|*.txt;*.css"
      .ShowPrinter
      If Len(.FileName) = 0 Then Exit Sub
   End With
End Sub

Private Sub mnuCopy_Click()
   mnuEditCopy_Click
End Sub

Private Sub Mnucut_Click()
   mnuEditCut_Click
End Sub

Private Sub mnudel_Click()
   mnuEditDelete_Click
End Sub

Private Sub mnuEli_Click()
   mnuClient_Click
End Sub

Private Sub mnuFi_Click()
   MnuFind_Click
End Sub
Private Sub mnuh_Click(index As Integer)
   frmDoc.rtfSource.SelText = "<H" & index & " >" & frmDoc.rtfSource.SelText & "</H" & index & " >"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
   frmDoc.rtfSource.SetFocus
End Sub
Private Sub mnuHyperlink_Click()
   bienLink = 1
   frmLink.Show 1
End Sub
Private Sub mnuBook_Click()
   bienLink = 2
   frmLink.Show 1
End Sub

Private Sub mnuImage_Click()
   frmPicture.Show 1
End Sub

Private Sub mnuItalic_Click()
   frmDoc.rtfSource.SelText = "<EM> " & frmDoc.rtfSource.SelText & " </EM>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
End Sub

Private Sub mnuMarquee_Click()
   Mar_Table = True
   frmMar_Table.Show 1
End Sub

Private Sub mnuOpenFile_Click()
   LoadNewDoc
End Sub

Private Sub mnuProcudure_Click()
   frmProcedure.Show 1
End Sub

Private Sub mnuProject_Click()
   If frmDoc.WindowState = 0 Then frmDoc.WindowState = 2 Else frmDoc.WindowState = 0
End Sub

Private Sub mnuRedo_Click()
   If tempUndo < Limit Then
      frmDoc.rtfSource.Text = Undo(tempUndo + 1)
      tempUndo = tempUndo + 1
   Else
      MsgBox "Can't Redo", vbInformation + vbOKOnly
   End If
End Sub

Private Sub mnuReplace_Click()
   frmFind.Caption = "Replace"
   frmFind.comReplace.Visible = True
   frmFind.Show
End Sub

Private Sub MnuSave_Click()
   mnuFileSave_Click
End Sub

Private Sub mnuSeAll_Click()
   mnuAll_Click
End Sub

Private Sub mnuSer_Click()
   mnuServer_Click
End Sub


Private Sub mnuSubs_Click()
   Div_Sub = False
   frmDiv_Sub.Show 1
End Sub

Private Sub mnuTable_Click()
   Mar_Table = False
   frmMar_Table.Show 1
End Sub

Private Sub mnuSpan_Click()
   frmDoc.rtfSource.SelText = "<SPAN> " & frmDoc.rtfSource.SelText & " </SPAN>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
End Sub

Private Sub mnuSub_Click()
   frmDoc.rtfSource.SelText = "<SUB>" & frmDoc.rtfSource.SelText & "</SUB>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
End Sub

Private Sub mnusuper_Click()
   frmDoc.rtfSource.SelText = "<SUP>" & frmDoc.rtfSource.SelText & "</SUP>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
End Sub

Private Sub mnuUn_Click()
   mnuEditUndo_Click
End Sub

Private Sub mnuUnderline_Click()
   frmDoc.rtfSource.SelText = "<U> " & frmDoc.rtfSource.SelText & " </U>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
End Sub
Private Sub mnuFileOpen_Click()
   Dim sFile As String
   frmDoc.Enabled = True
   With dlgCommonDialog
      .DialogTitle = "Open"
      .Filter = "Common Web File(*.htm;*.html;*.asp)|*.htm;*.html;*.asp|Global Server File(*.asa)|*.asa|Text(*.txt;*.css)|*.txt;*.css"
      .ShowOpen
      .CancelError = False
      If Len(.FileName) = 0 Then Exit Sub
      sFile = .FileName
      .FileName = ""
      lDocumentCount = lDocumentCount + 1
      ReDim Preserve ServerText(lDocumentCount)
      Public_Node = lDocumentCount + 2
      frmFile.TreeView1.Nodes.ADD "C2", tvwChild, "C" & (lDocumentCount + 2), sFile, Select_Picture(sFile)
      frmDoc.Caption = sFile
      frmDoc.rtfSource.LoadFile sFile
   End With
End Sub
Public Function Select_Picture(sFile As String) As Byte
   Select Case UCase(Right(sFile, 4))
      Case ".TXT"
         Select_Picture = 1
         frmDoc.SSTab.TabEnabled(0) = False
         frmDoc.SSTab.TabEnabled(1) = False
      Case ".HTM"
         Select_Picture = 2
         frmDoc.SSTab.TabEnabled(0) = True
         frmDoc.SSTab.TabEnabled(1) = True
      Case ".ASP"
         Select_Picture = 4
         frmDoc.SSTab.TabEnabled(0) = True
         frmDoc.SSTab.TabEnabled(1) = True
      Case ".CSS"
         Select_Picture = 5
         frmDoc.SSTab.TabEnabled(0) = False
         frmDoc.SSTab.TabEnabled(1) = False
      Case "HTML"
         Select_Picture = 3
         frmDoc.SSTab.TabEnabled(0) = True
         frmDoc.SSTab.TabEnabled(1) = True
      Case Else
         Select_Picture = 8
   End Select
End Function
Private Sub tbToolBar_ButtonClick(ByVal Button As MSComctlLib.Button)
    On Error Resume Next
    Select Case Button.Key
      Case "New"
         LoadNewDoc
      Case "Open"
         mnuFileOpen_Click
      Case "Save"
         mnuFileSave_Click
      Case "Print"
         mnuPrint_Click
      Case "Cut"
         mnuEditCut_Click
      Case "Copy"
         mnuEditCopy_Click
      Case "Paste"
         mnuEditPaste_Click
      Case "Undo"
         If tempUndo > 0 Then
            frmDoc.rtfSource.Text = Undo(tempUndo)
            tempUndo = tempUndo - 1
         Else
            MsgBox "Can't Undo", vbInformation + vbOKOnly
         End If
      Case "Redo"
         If tempUndo < Limit Then
            frmDoc.rtfSource.Text = Undo(tempUndo + 1)
            tempUndo = tempUndo + 1
         Else
            MsgBox "Can't Redo", vbInformation + vbOKOnly
         End If
      Case "Browser"
         If frmDoc.SSTab.Tab = 0 And frmDoc.SSTab.TabEnabled(0) = True Then frmDoc.SSTab.Tab = 1
      Case "Find"
         frmFind.Caption = "Find"
         frmFind.comReplace.Visible = False
         frmFind.Show
      Case "Help"
         frmHelp.Show
      Case "Properties"
          mnuProperties_Click
      Case "Option"
          frmOption.Show 1
   End Select
End Sub

Private Sub MDIForm_Unload(Cancel As Integer)
On Error Resume Next
   Unload frmFind
   Unload frmAddress
   Unload frmTextBox ' Giai phong khoi bo nho
   Unload frmComment
   Unload frmInfo
   Unload frmButton
   Unload frmChec_Rad
   Unload frmDiv_Sub
   Unload frmLink
   Unload frmPicture
   Unload frmOpen
   Unload frmOption
   Unload frmSave
   Unload frmProcedure
   Unload frmMar_Table
   Unload frmSelect
   Unload frmSplash
   Unload frmHelp
   
End Sub

Private Sub mnuClient_Click()
   frmDoc.rtfSource.SelText = "<SCRIPT LANGUAGE=javascript>" & vbCrLf & "<!--" & vbCrLf & vbCrLf & "//-->" & vbCrLf & "</SCRIPT>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
   If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.chkAttri.BackColor)
End Sub
Private Sub mnuServer_Click()
   frmDoc.rtfSource.SelText = "<SCRIPT LANGUAGE=vbscript RUNAT=Server>" & vbCrLf & vbCrLf & "</SCRIPT>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
   If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.chkAttri.BackColor)
End Sub

Private Sub mnuEditCut_Click()
   Clipboard.Clear
   Clipboard.SetText frmDoc.rtfSource.SelText
   frmDoc.rtfSource.SelText = ""
End Sub

Private Sub mnuEditCopy_Click()
   Clipboard.Clear
   Clipboard.SetText frmDoc.rtfSource.SelText
End Sub

Private Sub mnuEditPaste_Click()
   frmDoc.rtfSource.SelText = Clipboard.GetText()
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
   If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.chkAttri.BackColor)
   If frmOption.chkKey.value = 1 Then Call Change_ToKen(Command, frmOption.chkKey.BackColor)
End Sub
Private Sub mnuEditDelete_Click()
   frmDoc.rtfSource.SelText = "" ' Xoa text dang chon
End Sub

Private Sub mnuform_Click()
   frmDoc.rtfSource.SelText = "<FORM action=""" & """ method = POST id = form name = form >" & vbCrLf & vbCrLf & frmDoc.rtfSource.SelText & "</FORM>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor)
   If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor)
   frmDoc.rtfSource.SetFocus
End Sub
Private Sub mnucomment_Click()
   GlobeTool = 17
   frmComment.Show 1
End Sub

Private Sub mnuFull_Click()
   If frmDoc.WindowState = 0 Then frmDoc.WindowState = 2 Else frmDoc.WindowState = 0
End Sub

Private Sub mnuHorizoltal_Click()
   GlobeTool = 12
   frmComment.Show 1
End Sub
Private Sub mnuBreak_Click()
   GlobeTool = 13
   frmComment.Show 1
End Sub

Private Sub mnuPaste_Click()
   mnuEditPaste_Click
End Sub

'=============================================================================
Private Sub mnuHelpAbout_Click()
   frmInfo.Show 1
End Sub

Private Sub mnuHelpContents_Click()
    frmHelp.Show
End Sub
Private Sub mnuViewStatusBar_Click()
On Error Resume Next
    mnuViewStatusBar.Checked = Not mnuViewStatusBar.Checked
    sbStatusBar.Visible = mnuViewStatusBar.Checked
    If mnuViewStatusBar.Visible = False Then
        frmDoc.Height = fMainForm.ScaleHeight
        frmProperties.Height = fMainForm.ScaleHeight - frmFile.Height
    Else
        frmDoc.Height = fMainForm.ScaleHeight
        frmProperties.Height = fMainForm.ScaleHeight - frmFile.Height
    End If
End Sub

Private Sub mnuViewToolbar_Click()
On Error Resume Next
    mnuViewToolbar.Checked = Not mnuViewToolbar.Checked
    tbToolBar.Visible = mnuViewToolbar.Checked
    If tbToolBar.Visible = False Then
        frmDoc.Height = fMainForm.ScaleHeight
        frmProperties.Height = fMainForm.ScaleHeight - frmFile.Height
    Else
      If mnuViewStatusBar.Visible = True Then
        frmDoc.Height = fMainForm.ScaleHeight
        frmProperties.Height = fMainForm.ScaleHeight - frmFile.Height
      Else
        frmDoc.Height = fMainForm.ScaleHeight
        frmProperties.Height = fMainForm.ScaleHeight - frmFile.Height
      End If
    End If
End Sub

Private Sub mnuFileExit_Click()
   Unload Me
End Sub
Private Sub mnuFileNew_Click()
   LoadNewDoc
End Sub

Private Sub mnuProperties_Click()
   If frmDoc.WindowState = 0 Then frmDoc.WindowState = 2 Else frmDoc.WindowState = 0
End Sub





