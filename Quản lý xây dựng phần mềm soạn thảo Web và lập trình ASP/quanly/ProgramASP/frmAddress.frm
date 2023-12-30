VERSION 5.00
Begin VB.Form frmAddress 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "View Links On WWW..."
   ClientHeight    =   1290
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5610
   Icon            =   "frmAddress.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1290
   ScaleWidth      =   5610
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdCancel 
      Cancel          =   -1  'True
      Caption         =   "&Cancel"
      Height          =   375
      Left            =   4440
      TabIndex        =   2
      Top             =   600
      Width           =   1095
   End
   Begin VB.CommandButton cmdAddress 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   4440
      TabIndex        =   1
      Top             =   120
      Width           =   1095
   End
   Begin VB.TextBox txtAddress 
      Height          =   405
      Left            =   120
      TabIndex        =   0
      Text            =   " "
      Top             =   480
      Width           =   4215
   End
   Begin VB.Label Label6 
      Caption         =   "Example : http://localhost/Virtual Directory/"
      ForeColor       =   &H80000008&
      Height          =   255
      Left            =   360
      TabIndex        =   4
      Top             =   960
      Width           =   3615
   End
   Begin VB.Label Label1 
      Caption         =   "A&ddress :"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   855
   End
End
Attribute VB_Name = "frmAddress"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdAddress_Click()
   If Trim(txtAddress.Text) = vbNullString Then
      MsgBox "The address syntax is not valid. Please specify a valid URL.", vbOKOnly + vbInformation
   Else
      Server_Path = txtAddress.Text
      frmAddress.Hide
   End If
End Sub

Private Sub cmdCancel_Click()
   frmAddress.Hide
End Sub

Private Sub Form_Activate()
   txtAddress.Text = Server_Path
End Sub

