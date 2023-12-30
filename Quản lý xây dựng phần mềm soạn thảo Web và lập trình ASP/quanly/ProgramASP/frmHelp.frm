VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form frmHelp 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Help"
   ClientHeight    =   5310
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9330
   Icon            =   "frmHelp.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5310
   ScaleWidth      =   9330
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   5160
      TabIndex        =   5
      Top             =   240
      Width           =   1095
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   3960
      TabIndex        =   4
      Top             =   240
      Width           =   1095
   End
   Begin VB.TextBox txtHelp 
      Height          =   345
      Left            =   1080
      TabIndex        =   2
      Text            =   " "
      Top             =   270
      Width           =   2535
   End
   Begin VB.ListBox ListObject 
      Height          =   4545
      ItemData        =   "frmHelp.frx":000C
      Left            =   0
      List            =   "frmHelp.frx":00BE
      TabIndex        =   1
      Top             =   720
      Width           =   2775
   End
   Begin RichTextLib.RichTextBox Help 
      Height          =   4560
      Left            =   2760
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   720
      Width           =   6580
      _ExtentX        =   11615
      _ExtentY        =   8043
      _Version        =   393217
      BackColor       =   -2147483644
      Enabled         =   -1  'True
      ReadOnly        =   -1  'True
      ScrollBars      =   3
      TextRTF         =   $"frmHelp.frx":033A
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "VNI-Times"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Label Label1 
      Caption         =   "Index"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Top             =   240
      Width           =   855
   End
End
Attribute VB_Name = "frmHelp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
    frmHelp.Hide
End Sub

Private Sub cmdOk_Click()
   If Trim(txtHelp.Text) = "" Then
      txtHelp.SetFocus
      Exit Sub
   Else
      ProcudureDau (Trim(txtHelp.Text))
   End If
End Sub
Private Sub Form_Activate()
Dim i As Integer
   If frmDoc.BienHelp <> "" Then
      For i = 0 To ListObject.ListCount
         If UCase(frmDoc.BienHelp) = UCase(ListObject.List(i)) Then
            ListObject.ListIndex = i
            Exit For
         End If
      Next
      txtHelp.Text = frmDoc.BienHelp
      ProcudureDau (frmDoc.BienHelp)
   End If
End Sub
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
On Error Resume Next
   If KeyCode = 27 Then
      frmHelp.WindowState = 1
      frmDoc.SetFocus
   End If
End Sub

Private Sub Form_Load()
   If Trim(Help.Text) = "" Then Help.LoadFile App.path & "\comment.res"
End Sub
Private Sub Help_KeyDown(KeyCode As Integer, Shift As Integer)
   ListObject.SetFocus
End Sub
Private Sub ListObject_Click()
   txtHelp.Text = ListObject.Text
   ProcudureDau (ListObject.Text)
End Sub
Private Sub txtHelp_KeyDown(KeyCode As Integer, Shift As Integer)
   If KeyCode = 13 Then ProcudureDau (txtHelp.Text)
End Sub
Private Sub ProcudureDau(word As String)
Dim TimKiem As Long
   TimKiem = InStr(1, Help.Text, Trim(word), vbTextCompare)
   Help.SetFocus
   Help.SelStart = TimKiem + 500
   If TimKiem <> 0 Then
      Help.SelStart = TimKiem - 1
      Help.SelLength = Len(word)
      Help.SelColor = vbBlue
   Else
      MsgBox "The search item was not Found  <" & word & ">", vbExclamation
      Unload frmHelp
   End If
End Sub

