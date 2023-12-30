VERSION 5.00
Begin VB.Form frmComment 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Comment - Horizontal - Break"
   ClientHeight    =   1965
   ClientLeft      =   3450
   ClientTop       =   3090
   ClientWidth     =   6255
   Icon            =   "frmComment.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1965
   ScaleWidth      =   6255
   ShowInTaskbar   =   0   'False
   Begin VB.Frame fraDocBr 
      Caption         =   "Break..."
      Height          =   1935
      Left            =   0
      TabIndex        =   19
      Top             =   0
      Visible         =   0   'False
      Width           =   6255
      Begin VB.OptionButton optClearB 
         Caption         =   "Clear &Both Margins"
         Height          =   495
         Left            =   3840
         TabIndex        =   25
         ToolTipText     =   "Left and Right"
         Top             =   840
         Width           =   1695
      End
      Begin VB.CommandButton cmdCancelBreak 
         Caption         =   "Cancel"
         Height          =   375
         Left            =   3120
         TabIndex        =   24
         Top             =   1440
         Width           =   1095
      End
      Begin VB.CommandButton cmdOKBreak 
         Caption         =   "OK"
         Height          =   375
         Left            =   1920
         TabIndex        =   23
         Top             =   1440
         Width           =   1095
      End
      Begin VB.OptionButton optNormal 
         Caption         =   "&Normal Line Break"
         Height          =   495
         Left            =   600
         TabIndex        =   22
         ToolTipText     =   "Normal"
         Top             =   360
         Value           =   -1  'True
         Width           =   1695
      End
      Begin VB.OptionButton OptClearR 
         Caption         =   "&Clear Right Margin"
         Height          =   495
         Left            =   3840
         TabIndex        =   21
         ToolTipText     =   "Right ?"
         Top             =   360
         Width           =   1695
      End
      Begin VB.OptionButton optClearL 
         Caption         =   "Clear &Left Margin"
         Height          =   495
         Left            =   600
         TabIndex        =   20
         ToolTipText     =   "Left ?"
         Top             =   840
         Width           =   1575
      End
   End
   Begin VB.Frame fraNgangHr 
      Caption         =   "Horizoltal..."
      Height          =   1935
      Left            =   0
      TabIndex        =   4
      Top             =   0
      Visible         =   0   'False
      Width           =   6255
      Begin VB.ComboBox comHei 
         Height          =   315
         Left            =   1080
         TabIndex        =   18
         Text            =   " "
         ToolTipText     =   "Enter value about (pixel)"
         Top             =   840
         Width           =   975
      End
      Begin VB.ComboBox comwid 
         Height          =   315
         Left            =   1080
         TabIndex        =   17
         Text            =   " "
         ToolTipText     =   "Enter value about (1-100)"
         Top             =   435
         Width           =   975
      End
      Begin VB.CheckBox cheSoLine 
         Caption         =   "Solid Line ( no shading)"
         Height          =   375
         Left            =   4080
         TabIndex        =   14
         ToolTipText     =   "3D ?"
         Top             =   240
         Width           =   2055
      End
      Begin VB.OptionButton optRight 
         Caption         =   "Right"
         Height          =   375
         Left            =   3000
         TabIndex        =   13
         ToolTipText     =   "Right ?"
         Top             =   1440
         Width           =   855
      End
      Begin VB.OptionButton optLeft 
         Caption         =   "Left"
         Height          =   375
         Left            =   480
         TabIndex        =   11
         ToolTipText     =   "Left ?"
         Top             =   1440
         Width           =   735
      End
      Begin VB.CommandButton cmdOKHr 
         Caption         =   "OK"
         Default         =   -1  'True
         Height          =   375
         Left            =   4560
         TabIndex        =   6
         Top             =   600
         Width           =   1095
      End
      Begin VB.CommandButton cmdCancelHr 
         Cancel          =   -1  'True
         Caption         =   "Cancel"
         Height          =   375
         Left            =   4560
         TabIndex        =   5
         Top             =   1080
         Width           =   1095
      End
      Begin VB.OptionButton optCenter 
         Caption         =   "Center"
         Height          =   375
         Left            =   1680
         TabIndex        =   12
         ToolTipText     =   "Center ?"
         Top             =   1440
         Value           =   -1  'True
         Width           =   1095
      End
      Begin VB.Label Label5 
         AutoSize        =   -1  'True
         Caption         =   "Alignment"
         Height          =   195
         Left            =   120
         TabIndex        =   15
         Top             =   1200
         Width           =   690
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00FFFFFF&
         X1              =   1080
         X2              =   3960
         Y1              =   1320
         Y2              =   1320
      End
      Begin VB.Line Line3 
         X1              =   3960
         X2              =   3960
         Y1              =   360
         Y2              =   1800
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         Caption         =   "Size "
         Height          =   195
         Left            =   120
         TabIndex        =   16
         Top             =   240
         Width           =   345
      End
      Begin VB.Line Line2 
         BorderColor     =   &H00FFFFFF&
         X1              =   600
         X2              =   3960
         Y1              =   360
         Y2              =   360
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         Caption         =   "Pixel"
         Height          =   195
         Left            =   2160
         TabIndex        =   10
         Top             =   840
         Width           =   330
      End
      Begin VB.Label Label3 
         AutoSize        =   -1  'True
         Caption         =   "Percent of Windows"
         Height          =   195
         Left            =   2160
         TabIndex        =   9
         Top             =   480
         Width           =   1440
      End
      Begin VB.Label Label2 
         AutoSize        =   -1  'True
         Caption         =   "Height"
         Height          =   195
         Left            =   360
         TabIndex        =   8
         Top             =   840
         Width           =   465
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         Caption         =   "Width"
         Height          =   195
         Left            =   360
         TabIndex        =   7
         Top             =   480
         Width           =   420
      End
   End
   Begin VB.Frame fracommnet 
      Caption         =   "Comment..."
      Height          =   1935
      Left            =   0
      TabIndex        =   3
      Top             =   0
      Visible         =   0   'False
      Width           =   6255
      Begin VB.CommandButton cmdCancel 
         Caption         =   "Cancel"
         Height          =   375
         Left            =   3240
         TabIndex        =   2
         Top             =   1440
         Width           =   975
      End
      Begin VB.CommandButton cmdOk 
         Caption         =   "OK"
         Height          =   375
         Left            =   1800
         TabIndex        =   1
         Top             =   1440
         Width           =   1095
      End
      Begin VB.TextBox txtcomment 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   12
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   975
         Left            =   120
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   0
         ToolTipText     =   "Web "
         Top             =   360
         Width           =   6015
      End
   End
End
Attribute VB_Name = "frmComment"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdCancel_Click()
   frmComment.Hide
End Sub
Private Sub cmdCancelBreak_Click()
   frmComment.Hide
End Sub
Private Sub cmdCancelHr_Click()
   frmComment.Hide
End Sub
Private Sub cmdOk_Click()
   If Trim(txtcomment.Text) = "" Then  ' Goi InsertLabel dua vao chuoi tren
      frmDoc.rtfSource.SelText = "<!--webbot bot= " & """PurpleText""" & " PREVIEW --> "
      frmComment.Hide
   Else
      frmDoc.rtfSource.SelText = "<!--webbot bot= " & """PurpleText""" & " PREVIEW=""" & txtcomment.Text & """--> "
      frmComment.Hide
   End If
frmDoc.rtfSource.SetFocus
End Sub

Private Sub cmdOKBreak_Click()
Dim chuoi As String
   If optClearB.value = True Then
      chuoi = "all"
   ElseIf optClearL.value = True Then
      chuoi = "left"
   ElseIf OptClearR.value = True Then
      chuoi = "right"
   End If
   If optNormal.value = True Then
      frmDoc.rtfSource.SelText = "<br>"
      frmComment.Hide
   Else
      frmDoc.rtfSource.SelText = "<br clear=""" & chuoi & """ >"
      frmComment.Hide
   End If
If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
frmDoc.rtfSource.SetFocus
End Sub
Private Sub cmdOkHelp_Click()
   fMainForm.VarHelp = False
   frmComment.Hide
End Sub

Private Sub cmdOKHr_Click()
Dim chuoi As String
   If optLeft.value = True Then
      chuoi = optLeft.Caption
   ElseIf optCenter.value = True Then
      chuoi = optCenter.Caption
   Else: chuoi = optright.Caption
   End If
   If Val(comwid.Text) = 100 And Val(comHei.Text) = 2 And optCenter.value = True Then
      frmDoc.rtfSource.SelText = "<hr>"
      frmComment.Hide
   Else
      If cheSoLine.value = 1 Then
         frmDoc.rtfSource.SelText = "<hr align =""" & chuoi & """ width=""" & comwid.Text & """ noshade" & " size=""" & comHei.Text & """>"
         frmComment.Hide
      Else
         frmDoc.rtfSource.SelText = "<hr align =""" & chuoi & """ width=""" & comwid.Text & """ size=""" & comHei.Text & """>"
         frmComment.Hide
      End If
   End If
If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
frmDoc.rtfSource.SetFocus
End Sub

Private Sub Form_Activate()
Dim i As Integer
    Select Case GlobeTool
      Case 17
         frmComment.Caption = "Comment"
         fracommnet.Visible = True
         fraDocBr.Visible = False
         fraNgangHr.Visible = False
      Case 12
         frmComment.Caption = "Horizontal"
         fraNgangHr.Visible = True
         fracommnet.Visible = False
         fraDocBr.Visible = False
         For i = 1 To 100
            comwid.AddItem i
            comHei.AddItem i
         Next
         comwid.Text = 100
         comHei.Text = 2
      Case 13
         frmComment.Caption = "Break"
         fraNgangHr.Visible = False
         fracommnet.Visible = False
         fraDocBr.Visible = True
   End Select
End Sub

