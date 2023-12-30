VERSION 5.00
Begin VB.Form frmFind 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Find"
   ClientHeight    =   2025
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6135
   Icon            =   "frmFind.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2025
   ScaleWidth      =   6135
   ShowInTaskbar   =   0   'False
   Begin VB.CommandButton cmdAllRe 
      Caption         =   "Replace A&ll"
      Height          =   375
      Left            =   4920
      TabIndex        =   11
      Top             =   1080
      Width           =   1095
   End
   Begin VB.CheckBox chkMatch 
      Caption         =   "Ma&tch Case"
      Height          =   255
      Left            =   3600
      TabIndex        =   10
      Top             =   1320
      Width           =   1215
   End
   Begin VB.CommandButton cmdReplace 
      Caption         =   "R&eplace"
      Height          =   375
      Left            =   4920
      TabIndex        =   9
      Top             =   600
      Width           =   1095
   End
   Begin VB.Frame Frame1 
      Caption         =   "&Direction"
      Height          =   615
      Left            =   240
      TabIndex        =   6
      Top             =   1080
      Width           =   3255
      Begin VB.OptionButton optAll 
         Caption         =   "&All"
         Height          =   255
         Left            =   240
         TabIndex        =   12
         Top             =   240
         Value           =   -1  'True
         Width           =   735
      End
      Begin VB.OptionButton optUp 
         Caption         =   "&Up"
         Height          =   195
         Left            =   2400
         TabIndex        =   8
         Top             =   240
         Width           =   735
      End
      Begin VB.OptionButton optDown 
         Caption         =   "Dow&n"
         Height          =   255
         Left            =   1200
         TabIndex        =   7
         Top             =   240
         Width           =   735
      End
   End
   Begin VB.CommandButton cmdCancelFind 
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   4920
      TabIndex        =   5
      Top             =   1560
      Width           =   1095
   End
   Begin VB.CommandButton cmdFind 
      Caption         =   "Find &Next"
      Height          =   375
      Left            =   4920
      TabIndex        =   4
      Top             =   120
      Width           =   1095
   End
   Begin VB.ComboBox comReplace 
      Height          =   315
      Left            =   1440
      TabIndex        =   3
      Text            =   " "
      Top             =   600
      Visible         =   0   'False
      Width           =   3135
   End
   Begin VB.ComboBox comFind 
      Height          =   315
      Left            =   1440
      TabIndex        =   1
      Text            =   " "
      Top             =   160
      Width           =   3135
   End
   Begin VB.Label Label2 
      Caption         =   "Replace &With :"
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   675
      Width           =   975
   End
   Begin VB.Label Label1 
      Caption         =   "&Find What :"
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   240
      Width           =   975
   End
End
Attribute VB_Name = "frmFind"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdAllRe_Click()
On Error Resume Next
Static Find As Long
   If Trim(comFind.Text) = vbNullString Then
      comFind.SetFocus
      Exit Sub
   End If
   frmDoc.rtfSource.Visible = False
   frmDoc.rtfSource.MousePointer = rtfHourglass
   If comReplace.Visible = False Then
      comReplace.Visible = True
   Else
      If chkMatch.value = False Then
         If optAll.value = True Then
            Find = InStr(Find + 1, frmDoc.rtfSource.Text, Trim(comFind.Text), vbTextCompare)
            Do While Find <> 0
               ReplaceAll (Find)
               Find = InStr(Find + Len(comReplace.Text), Trim(frmDoc.rtfSource.Text), Trim(comFind.Text), vbTextCompare)  ' tim kiem
            Loop
         ElseIf optDown.value = True Then
            Find = InStr(frmDoc.rtfSource.SelStart, frmDoc.rtfSource.Text, Trim(comFind.Text), vbTextCompare)
            Do While Find <> 0
               ReplaceAll (Find)
               Find = InStr(Find + Len(comReplace.Text), Trim(frmDoc.rtfSource.Text), Trim(comFind.Text), vbTextCompare)  ' tim kiem
            Loop
         Else
            Find = InStrRev(frmDoc.rtfSource.Text, Trim(comFind.Text), frmDoc.rtfSource.SelStart, vbTextCompare)
            Do While Find <> 0
               ReplaceAll (Find)
               Find = InStr(Find + Len(comReplace.Text), Trim(frmDoc.rtfSource.Text), Trim(comFind.Text), vbTextCompare)  ' tim kiem
            Loop
         End If
      Else
         If optAll.value = True Then
            Find = InStr(Find + 1, frmDoc.rtfSource.Text, Trim(comFind.Text), vbBinaryCompare)
            Do While Find <> 0
               ReplaceAll (Find)
               Find = InStr(Find + Len(comReplace.Text), Trim(frmDoc.rtfSource.Text), Trim(comFind.Text), vbBinaryCompare)   ' tim kiem
            Loop
         ElseIf optDown.value = True Then
            Find = InStr(frmDoc.rtfSource.SelStart, frmDoc.rtfSource.Text, Trim(comFind.Text), vbBinaryCompare)
            Do While Find <> 0
               ReplaceAll (Find)
               Find = InStr(Find + Len(comReplace.Text), Trim(frmDoc.rtfSource.Text), Trim(comFind.Text), vbBinaryCompare)   ' tim kiem
            Loop
         Else
            Find = InStrRev(frmDoc.rtfSource.Text, Trim(comFind.Text), frmDoc.rtfSource.SelStart, vbBinaryCompare)
            Do While Find <> 0
               ReplaceAll (Find)
               Find = InStr(Find + Len(comReplace.Text), Trim(frmDoc.rtfSource.Text), Trim(comFind.Text), vbBinaryCompare)   ' tim kiem
            Loop
         End If
      End If
   End If
   frmDoc.rtfSource.Visible = True
   frmDoc.rtfSource.MousePointer = rtfArrow
End Sub
Public Sub ReplaceAll(Find As Long)
      If Find <> 0 Then ' Neu khong tim thay tu thi Thoa khoi thu tuc
         frmDoc.rtfSource.SelStart = Find - 1  ' set selection start and
         frmDoc.rtfSource.SelLength = Len(Trim(comFind.Text))
         frmDoc.rtfSource.Text = Replace(frmDoc.rtfSource.Text, frmDoc.rtfSource.SelText, Trim(comReplace.Text), , 1)
      Else
         MsgBox "The specified region has been searched .", vbInformation
      End If
   
End Sub
Private Sub cmdCancelFind_Click()
   frmFind.Hide
End Sub

Private Sub cmdFind_Click()
On Error Resume Next
Static Find As Long
   If Trim(comFind.Text) = vbNullString Then
      comFind.SetFocus
      Exit Sub
   End If
   If chkMatch.value = False Then
      If optAll.value = True Then
         Find = InStr(Find + 1, frmDoc.rtfSource.Text, Trim(comFind.Text), vbTextCompare)
         FindNext (Find)
      ElseIf optDown.value = True Then
         Find = InStr(Find + frmDoc.rtfSource.SelStart, frmDoc.rtfSource.Text, Trim(comFind.Text), vbTextCompare)
         FindNext (Find)
      Else
         Find = InStrRev(frmDoc.rtfSource.Text, Trim(comFind.Text), frmDoc.rtfSource.SelStart, vbTextCompare)
         FindNext (Find)
      End If
   Else
      If optAll.value = True Then
         Find = InStr(Find + 1, frmDoc.rtfSource.Text, Trim(comFind.Text), vbBinaryCompare)
         FindNext (Find)
      ElseIf optDown.value = True Then
         Find = InStr(frmDoc.rtfSource.SelStart, frmDoc.rtfSource.Text, Trim(comFind.Text), vbBinaryCompare)
         FindNext (Find)
      Else
         Find = InStrRev(frmDoc.rtfSource.Text, Trim(comFind.Text), frmDoc.rtfSource.SelStart, vbBinaryCompare)
         FindNext (Find)
      End If
   End If
End Sub
Public Sub FindNext(Find As Long)
   If Find <> 0 Then
      frmDoc.rtfSource.SelStart = Find - 1  ' set selection start and
      frmDoc.rtfSource.SelLength = Len(Trim(comFind.Text))
   Else
      MsgBox "The specified region has been searched .", vbInformation
   End If
End Sub
Private Sub cmdReplace_Click()
   If Trim(comFind.Text) = vbNullString Then
      comFind.SetFocus
      Exit Sub
   End If
   If comReplace.Visible = False Then comReplace.Visible = True Else frmDoc.rtfSource.Text = Replace(frmDoc.rtfSource.Text, frmDoc.rtfSource.SelText, Trim(comReplace.Text), , 1)
End Sub
Private Sub comFind_LostFocus()
   If Trim(comFind.Text) <> vbNullString Then comFind.AddItem comFind.Text
End Sub
Private Sub comReplace_LostFocus()
   If Trim(comReplace.Text) <> vbNullString Then comReplace.AddItem comReplace.Text
End Sub
