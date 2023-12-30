VERSION 5.00
Begin VB.Form F_TIMKIEM 
   BackColor       =   &H0000FFFF&
   Caption         =   "TIM KIEM THONG TIN "
   ClientHeight    =   4560
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5835
   LinkTopic       =   "Form1"
   ScaleHeight     =   4560
   ScaleWidth      =   5835
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
      Height          =   615
      Left            =   3000
      TabIndex        =   5
      Top             =   3720
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
      Height          =   615
      Left            =   720
      TabIndex        =   4
      Top             =   3720
      Width           =   1575
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00FFFFC0&
      Height          =   3255
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   5535
      Begin VB.OptionButton Option4 
         BackColor       =   &H00FFFFC0&
         Caption         =   "Tìm Kiêm Nhà Cung Câp"
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
         Left            =   120
         TabIndex        =   6
         Top             =   2520
         Width           =   3015
      End
      Begin VB.OptionButton Option3 
         BackColor       =   &H00FFFFC0&
         Caption         =   "&Tìm Kiêm Nhân Viên"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   3
         Top             =   1800
         Width           =   2535
      End
      Begin VB.OptionButton Option2 
         BackColor       =   &H00FFFFC0&
         Caption         =   "&Tìm Kiêm Khách Hàng"
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
         Left            =   120
         TabIndex        =   2
         Top             =   1080
         Width           =   3015
      End
      Begin VB.OptionButton Option1 
         BackColor       =   &H00FFFFC0&
         Caption         =   "&Tìm kiêm hàng hóa"
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
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   2775
      End
   End
End
Attribute VB_Name = "F_TIMKIEM"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub command1_Click()
If Option1.Value = True Then
F_TKHH.Show
ElseIf Option2.Value = True Then
F_TKKH.Show
ElseIf Option3.Value = True Then
F_TKNV.Show
ElseIf Option4.Value = True Then
F_TKNCC.Show
 End If
 F_TIMKIEM.Hide
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
