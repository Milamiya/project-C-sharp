VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmLink 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "HyperLink - Bookmark"
   ClientHeight    =   1800
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5325
   Icon            =   "frmLink.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1800
   ScaleWidth      =   5325
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame fraBook 
      Caption         =   "Bookmark Information"
      Height          =   1815
      Left            =   0
      TabIndex        =   17
      ToolTipText     =   "Enter a name"
      Top             =   0
      Visible         =   0   'False
      Width           =   5295
      Begin VB.CommandButton cmdCan 
         Caption         =   "Cancel"
         Height          =   375
         Left            =   2760
         TabIndex        =   9
         Top             =   1320
         Width           =   1095
      End
      Begin VB.CommandButton cmdOkBo 
         Caption         =   "OK"
         Height          =   375
         Left            =   1560
         TabIndex        =   8
         Top             =   1320
         Width           =   1095
      End
      Begin VB.TextBox txtBoo 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   240
         TabIndex        =   3
         Text            =   " "
         Top             =   600
         Width           =   4935
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         Caption         =   "&Name :"
         Height          =   195
         Left            =   240
         TabIndex        =   18
         Top             =   360
         Width           =   510
      End
   End
   Begin VB.Frame fraHy 
      Caption         =   "HyperLink information"
      Height          =   1815
      Left            =   0
      TabIndex        =   10
      Top             =   0
      Visible         =   0   'False
      Width           =   5295
      Begin MSComDlg.CommonDialog dlgCommonDialog 
         Left            =   240
         Top             =   1080
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin VB.CommandButton cmdOkS 
         Caption         =   "&Browse..."
         Default         =   -1  'True
         Height          =   375
         Left            =   4080
         TabIndex        =   16
         Top             =   240
         Width           =   1095
      End
      Begin VB.CommandButton cmdcancel 
         Cancel          =   -1  'True
         Caption         =   "Cancel"
         Height          =   375
         Left            =   2760
         TabIndex        =   15
         Top             =   1320
         Width           =   1095
      End
      Begin VB.CommandButton cmdOk 
         Caption         =   "OK"
         Height          =   375
         Left            =   1560
         TabIndex        =   14
         Top             =   1320
         Width           =   1095
      End
      Begin VB.TextBox txtURL 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   960
         TabIndex        =   13
         Text            =   "http://"
         Top             =   720
         Width           =   4215
      End
      Begin VB.ComboBox comURL 
         Height          =   315
         Left            =   960
         TabIndex        =   2
         Text            =   "http://"
         Top             =   300
         Width           =   1215
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   "&URL"
         Height          =   195
         Left            =   360
         TabIndex        =   12
         Top             =   720
         Width           =   330
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "&Type"
         Height          =   195
         Left            =   360
         TabIndex        =   11
         Top             =   360
         Width           =   360
      End
   End
   Begin VB.Frame fraInclude 
      Caption         =   "Include..."
      Height          =   1815
      Left            =   0
      TabIndex        =   19
      ToolTipText     =   "Enter a name"
      Top             =   0
      Visible         =   0   'False
      Width           =   5295
      Begin VB.CommandButton cmdBrowser 
         Caption         =   "&Browse..."
         Height          =   375
         Left            =   2880
         TabIndex        =   5
         Top             =   720
         Width           =   2295
      End
      Begin VB.OptionButton optVitrtual 
         Caption         =   "&Virtual"
         Height          =   255
         Left            =   1440
         TabIndex        =   4
         Top             =   840
         Width           =   1095
      End
      Begin VB.OptionButton optFile 
         Caption         =   "&File"
         Height          =   255
         Left            =   240
         TabIndex        =   0
         Top             =   840
         Value           =   -1  'True
         Width           =   1095
      End
      Begin VB.TextBox txtPath 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   840
         TabIndex        =   1
         Text            =   " "
         Top             =   240
         Width           =   4335
      End
      Begin VB.CommandButton cmdInclude 
         Caption         =   "OK"
         Height          =   375
         Left            =   1560
         TabIndex        =   6
         Top             =   1320
         Width           =   1095
      End
      Begin VB.CommandButton CmdCanIn 
         Caption         =   "Cancel"
         Height          =   375
         Left            =   2760
         TabIndex        =   7
         Top             =   1320
         Width           =   1095
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         Caption         =   "&Path..."
         Height          =   195
         Left            =   240
         TabIndex        =   20
         Top             =   360
         Width           =   465
      End
   End
End
Attribute VB_Name = "frmLink"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim sFile As String

Private Sub cmdBrowser_Click()
Dim path As String
    With dlgCommonDialog
        .DialogTitle = "Include..."
        .CancelError = False
        .Filter = "All Files (*.*)|*.*"
        .ShowSave
        If Len(.FileName) = 0 Then Exit Sub
        path = .FileName
    End With
    txtPath.Text = path
End Sub

Private Sub CmdCan_Click()
   frmLink.Hide
End Sub

Private Sub cmdCancel_Click()
   frmLink.Hide
End Sub

Private Sub CmdCanIn_Click()
    frmLink.Hide
End Sub

Private Sub cmdInclude_Click()
On Error Resume Next
    If Trim(txtPath.Text) = "" Then
       MsgBox "    Path not Found ...   ", vbCritical, "Error"
       txtPath.SetFocus
       Exit Sub
    End If
    If optFile.value = True Then frmDoc.rtfSource.SelText = "<!-- #include " & optFile.Caption & "= """ & txtPath.Text & """-->" Else frmDoc.rtfSource.SelText = "<!-- #include " & optVitrtual.Caption & "= """ & txtPath.Text & """-->"
    frmLink.Hide
End Sub

Private Sub cmdOk_Click()
   If Trim(frmDoc.rtfSource.SelText) <> vbNullString Then frmDoc.rtfSource.SelText = "<A HREF=""" & txtURL.Text & """>" & frmDoc.rtfSource.SelText & "</A>" Else frmDoc.rtfSource.SelText = "<A HREF=""" & txtURL.Text & """>" & txtURL.Text & "</A>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
   If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
   frmLink.Hide
End Sub
Private Sub cmdOkBo_Click()
   frmDoc.rtfSource.SelText = "<A NAME=""" & txtBoo.Text & """>" & frmDoc.rtfSource.SelText & " </A>"
   If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
   If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
   frmLink.Hide
End Sub
Private Sub CmdOKS_Click()
   With dlgCommonDialog
        .DialogTitle = "HyperLink"
        .CancelError = False
        .Filter = "All Files (*.*)|*.*"
        .ShowOpen
        If Len(.FileName) = 0 Then Exit Sub
        sFile = .FileName
    End With
    comURL_Click
End Sub
Private Sub comURL_Click()
   If Trim(comURL.Text) <> "(orther)" Then txtURL.Text = Trim(comURL.Text) & "//" & sFile Else txtURL.Text = "" & sFile
End Sub
Private Sub Form_Activate()
   Select Case bienLink
        Case 1: fraHy.Visible = True: fraInclude.Visible = False: fraBook.Visible = False: frmLink.Caption = "HyperLink"
            With comURL
               .AddItem "http:"
               .AddItem "ftp:"
               .AddItem "gopher:"
               .AddItem "https:"
               .AddItem "mailto:"
               .AddItem "news:"
               .AddItem "telnet:"
               .AddItem "wais:"
               .AddItem "file:"
               .AddItem "(orther)"
            End With
        Case 2: fraBook.Visible = True: fraHy.Visible = False: fraInclude.Visible = False: frmLink.Caption = "Bookmark"
            txtBoo.SetFocus
        Case Else:
            frmLink.Caption = "Include...."
            fraInclude.Visible = True
            fraHy.Visible = False
            fraBook.Visible = False
            txtPath.SetFocus
   End Select
End Sub


