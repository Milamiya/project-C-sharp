VERSION 5.00
Begin VB.Form frmChec_Rad 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "CheckBox - Radio"
   ClientHeight    =   2670
   ClientLeft      =   3915
   ClientTop       =   3090
   ClientWidth     =   4680
   Icon            =   "frmChec_Rad.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2670
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox ChecRad 
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
      Left            =   1605
      TabIndex        =   0
      Text            =   " "
      Top             =   120
      Width           =   2895
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
      Left            =   1605
      TabIndex        =   1
      Text            =   " "
      Top             =   570
      Width           =   2895
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
      Left            =   2280
      MaxLength       =   3
      TabIndex        =   4
      Text            =   " "
      ToolTipText     =   "Enter string or value ?"
      Top             =   1680
      Width           =   855
   End
   Begin VB.OptionButton optSec 
      Caption         =   "S&elected"
      Height          =   375
      Left            =   1920
      TabIndex        =   2
      ToolTipText     =   "Selected ?"
      Top             =   1080
      Width           =   975
   End
   Begin VB.OptionButton optNotSec 
      Caption         =   "N&ot selected"
      Height          =   375
      Left            =   3330
      TabIndex        =   3
      ToolTipText     =   "Not Selected ?"
      Top             =   1080
      Value           =   -1  'True
      Width           =   1215
   End
   Begin VB.CommandButton cmdOk 
      Caption         =   "Ok"
      Height          =   375
      Left            =   990
      TabIndex        =   5
      Top             =   2160
      Width           =   1215
   End
   Begin VB.CommandButton cmdcancel 
      Cancel          =   -1  'True
      Caption         =   "Cancel"
      Height          =   375
      Left            =   2400
      TabIndex        =   6
      Top             =   2160
      Width           =   1215
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Group Name :"
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
      Top             =   195
      Width           =   1335
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Value :"
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
      Left            =   480
      TabIndex        =   9
      Top             =   600
      Width           =   645
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
      Left            =   840
      TabIndex        =   8
      Top             =   1680
      Width           =   1095
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      Caption         =   "Initinal State :"
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
      Left            =   390
      TabIndex        =   7
      Top             =   1125
      Width           =   1245
   End
End
Attribute VB_Name = "frmChec_Rad"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Sub cmdCancel_Click()
   frmChec_Rad.Hide
End Sub
Private Sub cmdCancelURL_Click()
    frmChec_Rad.Hide
End Sub
Private Sub cmdOk_Click()
   If Trim(ChecRad.Text) = "" Then
      MsgBox "    Invalid property Name ...   ", vbCritical, "Error"
      ChecRad.SetFocus
      Exit Sub
   End If
   If Trim(value.Text) = "" Then
      If GlobeTool = 5 Then
         MsgBox "    Invalid property Value ...   ", vbCritical, "Error"
      Else
         MsgBox "    Invalid property Value ...   ", vbCritical, "Error"
      End If
      value.SetFocus
      Exit Sub
   End If
   If GlobeTool = 5 Then
      If optSec.value = True Then
         frmDoc.rtfSource.SelText = "<input type= " & """checkBox""" & " name=""" & Trim(ChecRad.Text) & """ value=""" & Trim(value.Text) & """ checked" & " TabIndex = """ & Trim(txtTab.Text) & """ > "
         frmChec_Rad.Hide
         If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
         If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
      Else
         frmDoc.rtfSource.SelText = "<input type= " & """checkBox""" & " name=""" & Trim(ChecRad.Text) & """ value=""" & Trim(value.Text) & """ tabindex=""" & Trim(txtTab.Text) & """>"
         frmChec_Rad.Hide
         If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
         If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
      End If
   Else
      If optSec.value = True Then
         frmDoc.rtfSource.SelText = "<input type= " & """radio""" & " name=""" & Trim(ChecRad.Text) & """ value=""" & Trim(value.Text) & """ checked" & " tabindex=""" & Trim(txtTab.Text) & """>"
         frmChec_Rad.Hide
         If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
         If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
      Else
         frmDoc.rtfSource.SelText = "<input type= " & """radio""" & " name=""" & Trim(ChecRad.Text) & """ value=""" & Trim(value.Text) & """ tabindex=""" & Trim(txtTab.Text) & """>"
         frmChec_Rad.Hide
         If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
         If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
      End If
   End If
End Sub
Private Sub Form_Activate()
   If GlobeTool = 5 Then
      frmChec_Rad.Caption = "CheckBox"
      ChecRad.ToolTipText = "Enter name of CheckBox"
      value.ToolTipText = "Enter value of cña CheckBox"
   ElseIf GlobeTool = 6 Then
      frmChec_Rad.Caption = "Radio"
      ChecRad.ToolTipText = "Enter name of Radio"
      value.ToolTipText = "Enter value of Radio"
   End If
   ChecRad.SetFocus
End Sub

