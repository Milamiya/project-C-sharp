VERSION 5.00
Begin VB.Form F_Thongtin 
   BackColor       =   &H0000FFFF&
   Caption         =   "THONG TIN CHI TIET"
   ClientHeight    =   4500
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5970
   LinkTopic       =   "Form1"
   ScaleHeight     =   4500
   ScaleWidth      =   5970
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "&Cancel"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2880
      TabIndex        =   6
      Top             =   3840
      Width           =   1455
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&Ok"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   960
      TabIndex        =   5
      Top             =   3840
      Width           =   1575
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFC0&
      Height          =   3495
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   5655
      Begin VB.OptionButton Option4 
         BackColor       =   &H00FFFFC0&
         Caption         =   "Thông Tin Nhân Viên"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   240
         TabIndex        =   4
         Top             =   2400
         Width           =   2535
      End
      Begin VB.OptionButton Option3 
         BackColor       =   &H00FFFFC0&
         Caption         =   "Thông Tin Nhà Cung Câp"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   240
         TabIndex        =   3
         Top             =   1560
         Width           =   3255
      End
      Begin VB.OptionButton Option2 
         BackColor       =   &H00FFFFC0&
         Caption         =   "Thông tin Hàng Hóa"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   240
         TabIndex        =   2
         Top             =   960
         Width           =   2775
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H00FFFFC0&
         Caption         =   "Thông tin Khách hàng"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   615
         Left            =   240
         TabIndex        =   1
         Top             =   240
         Width           =   5175
      End
   End
End
Attribute VB_Name = "F_Thongtin"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Private Sub command1_Click()
If Option1.Value = True Then
F_DMKH.Show
ElseIf Option2.Value = True Then
F_DMHH.Show
ElseIf Option3.Value = True Then
F_DMNCC.Show
ElseIf Option4.Value = True Then
F_DMNV.Show
 End If
 F_Thongtin.Hide
End Sub

Private Sub Command2_Click()
Unload Me
F_Main.Show
End Sub

Private Sub Form_Load()
 If Option1.Value = True Then
    Option2.Value = False
    Option3.Value = False
    Option4.Value = False
 ElseIf Option2.Value = True Then
    Option1.Value = False
    Option3.Value = False
    Option4.Value = False
 ElseIf Option3.Value = True Then
    Option1.Value = False
    Option2.Value = False
    Option4.Value = False
    ElseIf Option4.Value = True Then
    Option1.Value = False
    Option2.Value = False
    Option3.Value = False
 End If
End Sub

