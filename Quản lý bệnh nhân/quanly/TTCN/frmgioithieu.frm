VERSION 5.00
Begin VB.Form frmgioithieu 
   BackColor       =   &H00C0E0FF&
   Caption         =   "Gioi Thieu"
   ClientHeight    =   4830
   ClientLeft      =   60
   ClientTop       =   420
   ClientWidth     =   6540
   BeginProperty Font 
      Name            =   "VNI-Times"
      Size            =   14.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "frmgioithieu.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   4830
   ScaleWidth      =   6540
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command1 
      Caption         =   "Thoaùt"
      Height          =   495
      Left            =   120
      TabIndex        =   1
      Top             =   4320
      Width           =   975
   End
   Begin VB.Label Label1 
      BackColor       =   &H00C0E0FF&
      Caption         =   $"frmgioithieu.frx":0442
      Height          =   4215
      Left            =   2520
      TabIndex        =   0
      Top             =   600
      Width           =   3975
   End
   Begin VB.Image Image1 
      Height          =   3285
      Left            =   240
      Picture         =   "frmgioithieu.frx":05C4
      Top             =   240
      Width           =   2100
   End
End
Attribute VB_Name = "frmgioithieu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Unload Me
End Sub
