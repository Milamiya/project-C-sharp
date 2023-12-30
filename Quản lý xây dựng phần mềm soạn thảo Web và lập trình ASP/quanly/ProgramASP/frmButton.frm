VERSION 5.00
Begin VB.Form frmButton 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Submit - Reset - Button"
   ClientHeight    =   2805
   ClientLeft      =   3915
   ClientTop       =   3090
   ClientWidth     =   5505
   Icon            =   "frmButton.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2805
   ScaleWidth      =   5505
   ShowInTaskbar   =   0   'False
   Begin VB.OptionButton optReset 
      Caption         =   "&Reset"
      Height          =   375
      Left            =   4080
      TabIndex        =   4
      ToolTipText     =   " Reset ?"
      Top             =   1200
      Width           =   1095
   End
   Begin VB.TextBox txtButton 
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1725
      TabIndex        =   0
      ToolTipText     =   "Enter name of  button"
      Top             =   120
      Width           =   3615
   End
   Begin VB.TextBox value 
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1725
      TabIndex        =   1
      Text            =   " "
      ToolTipText     =   "Enter name ( label ) of button"
      Top             =   690
      Width           =   3615
   End
   Begin VB.TextBox txtTab 
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1800
      MaxLength       =   3
      TabIndex        =   5
      Text            =   " "
      ToolTipText     =   "Enter value about (1-500)"
      Top             =   1680
      Width           =   855
   End
   Begin VB.OptionButton optnormal 
      Caption         =   "&Normal"
      Height          =   375
      Left            =   1845
      TabIndex        =   2
      ToolTipText     =   "Button ?"
      Top             =   1200
      Value           =   -1  'True
      Width           =   855
   End
   Begin VB.OptionButton optSubmit 
      Caption         =   "&Submit"
      Height          =   375
      Left            =   2925
      TabIndex        =   3
      ToolTipText     =   " Submit ?"
      Top             =   1200
      Width           =   975
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "Ok"
      Default         =   -1  'True
      Height          =   375
      Left            =   1440
      TabIndex        =   6
      Top             =   2280
      Width           =   1215
   End
   Begin VB.CommandButton cmdcancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3045
      TabIndex        =   7
      Top             =   2280
      Width           =   1215
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Name :"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   720
      TabIndex        =   11
      Top             =   150
      Width           =   675
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Value / Label :"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   240
      TabIndex        =   10
      Top             =   720
      Width           =   1335
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Tab Order :"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   450
      TabIndex        =   9
      Top             =   1770
      Width           =   1095
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Password Field ?"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   45
      TabIndex        =   8
      Top             =   1245
      Width           =   1605
   End
End
Attribute VB_Name = "frmButton"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
   Unload frmButton
End Sub
Private Sub cmdOk_Click()
   If Trim(txtButton.Text) = "" Then   ' Gap loi khi truong Name la NULL
      MsgBox "    Invalid property Name ...   ", vbCritical, "Error"
      txtButton.SetFocus
      Exit Sub
   End If
   If optNormal.value = True Then
      frmDoc.rtfSource.SelText = "<input type= " & """button" & """ name=""" & Trim(txtButton.Text) & """ value=""" & Trim(value.Text) & """ tabindex=""" & Trim(txtTab.Text) & """>"
   ElseIf optSubmit.value = True Then
      frmDoc.rtfSource.SelText = "<input type= " & """submit" & """ name=""" & Trim(txtButton.Text) & """ value=""" & Trim(value.Text) & """ tabindex=""" & Trim(txtTab.Text) & """>"
   Else:
      frmDoc.rtfSource.SelText = "<input type= " & """reset" & """ name=""" & Trim(txtButton.Text) & """ value=""" & Trim(value.Text) & """ tabindex=""" & Trim(txtTab.Text) & """>"
   End If
      frmButton.Hide
      If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
      If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
End Sub

Private Sub Form_Load()
   If GlobeTool = 11 Then
      frmButton.Caption = "Button"
      optNormal.value = True
   ElseIf GlobeTool = 9 Then
      frmButton.Caption = "Submit"
      optSubmit.value = True
   Else: optReset.value = True: frmButton.Caption = "Reset"
   End If
End Sub
