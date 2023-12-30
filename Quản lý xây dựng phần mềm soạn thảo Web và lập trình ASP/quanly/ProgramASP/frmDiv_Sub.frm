VERSION 5.00
Begin VB.Form frmDiv_Sub 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Substitute"
   ClientHeight    =   1485
   ClientLeft      =   3045
   ClientTop       =   1935
   ClientWidth     =   3270
   Icon            =   "frmDiv_Sub.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1485
   ScaleWidth      =   3270
   ShowInTaskbar   =   0   'False
   Begin VB.Frame frasub 
      Caption         =   " "
      Height          =   1575
      Left            =   0
      TabIndex        =   6
      Top             =   -120
      Width           =   3255
      Begin VB.TextBox txttext 
         Height          =   375
         Left            =   120
         TabIndex        =   1
         Text            =   " "
         ToolTipText     =   "What String ?"
         Top             =   600
         Width           =   3015
      End
      Begin VB.CommandButton cmdSub 
         Caption         =   "&OK"
         Default         =   -1  'True
         Height          =   375
         Left            =   360
         TabIndex        =   8
         Top             =   1080
         Width           =   1215
      End
      Begin VB.CommandButton cmdCanSub 
         Cancel          =   -1  'True
         Caption         =   "&Cancel"
         Height          =   375
         Left            =   1800
         TabIndex        =   7
         Top             =   1080
         Width           =   1215
      End
      Begin VB.Label Label4 
         BackColor       =   &H80000004&
         Caption         =   "&Substitute with:"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   240
         Width           =   1215
      End
   End
   Begin VB.Frame fraDiv 
      Caption         =   " "
      Height          =   1575
      Left            =   0
      TabIndex        =   0
      Top             =   -120
      Width           =   3255
      Begin VB.CommandButton cmdCancelDiv 
         Caption         =   "&Cancel"
         Height          =   375
         Left            =   1800
         TabIndex        =   5
         Top             =   1080
         Width           =   1215
      End
      Begin VB.OptionButton optAbs 
         BackColor       =   &H80000004&
         Caption         =   "&Absolute"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   375
         Left            =   360
         TabIndex        =   4
         Top             =   480
         Value           =   -1  'True
         Width           =   1335
      End
      Begin VB.OptionButton optIn 
         BackColor       =   &H80000004&
         Caption         =   "I&n-line"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   375
         Left            =   360
         TabIndex        =   3
         Top             =   1080
         Width           =   1095
      End
      Begin VB.CommandButton cmdOKDiv 
         Caption         =   "&OK"
         Height          =   375
         Left            =   1800
         TabIndex        =   2
         Top             =   480
         Width           =   1215
      End
   End
End
Attribute VB_Name = "frmDiv_Sub"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancelDiv_Click()
   frmDiv_Sub.Hide
End Sub

Private Sub cmdCanSub_Click()
   frmDiv_Sub.Hide
End Sub

Private Sub cmdOKDiv_Click()
If optAbs.value = True Then frmDoc.rtfSource.SelText = " <DIV STYLE=""" & "position:absolute; width:30px; height:30px" & """> </DIV>" Else frmDoc.rtfSource.SelText = " <DIV> &nbsp; </DIV>"
If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
frmDiv_Sub.Hide
End Sub

Private Sub cmdSub_Click()
Dim ViTri As Long
   ViTri = frmDoc.rtfSource.SelStart
   frmDoc.rtfSource.SelText = "<!--webbot bot=""" & "Substitution" & """ S-Variable=""" & txttext.Text & """ -->"
   frmDoc.rtfSource.SelStart = ViTri
   frmDoc.rtfSource.SelLength = Len("<!--webbot bot=""" & "Substitution" & """ S-Variable=""" & txttext.Text & """ -->")
   frmDoc.rtfSource.SelItalic = True
   frmDoc.rtfSource.SelStart = ViTri + Len("<!--webbot bot=""" & "Substitution" & """ S-Variable=""" & txttext.Text & """ -->")
   txttext.Text = ""
   frmDiv_Sub.Hide
End Sub

Private Sub Form_Activate()
   If Div_Sub = True Then
      frmDiv_Sub.Caption = "Insert Div"
      fraDiv.Visible = True
      frasub.Visible = False
   Else
      frmDiv_Sub.Caption = "Substitute With"
      fraDiv.Visible = False
      frasub.Visible = True
   End If
End Sub

