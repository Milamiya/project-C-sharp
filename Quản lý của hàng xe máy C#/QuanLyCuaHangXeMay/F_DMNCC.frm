VERSION 5.00
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form F_DMNCC 
   BackColor       =   &H00C0FFC0&
   Caption         =   "THONG TIN NHA CUNG CAP"
   ClientHeight    =   6435
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   9345
   LinkTopic       =   "Form1"
   ScaleHeight     =   6435
   ScaleWidth      =   9345
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox Text4 
      Height          =   495
      Left            =   2280
      TabIndex        =   16
      Top             =   840
      Width           =   2175
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00C0C0FF&
      Height          =   1095
      Left            =   120
      TabIndex        =   8
      Top             =   5160
      Width           =   9135
      Begin VB.CommandButton Command6 
         Caption         =   "&Exit"
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
         Left            =   7560
         TabIndex        =   14
         Top             =   240
         Width           =   1455
      End
      Begin VB.CommandButton Command5 
         Caption         =   "&In"
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
         Left            =   6000
         TabIndex        =   13
         Top             =   240
         Width           =   1335
      End
      Begin VB.CommandButton Command4 
         Caption         =   "&Luu"
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
         Left            =   4560
         TabIndex        =   12
         Top             =   240
         Width           =   1335
      End
      Begin VB.CommandButton Command3 
         Caption         =   "&Sua"
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
         TabIndex        =   11
         Top             =   240
         Width           =   1335
      End
      Begin VB.CommandButton Command2 
         Caption         =   "&Xóa"
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
         Left            =   1560
         TabIndex        =   10
         Top             =   240
         Width           =   1335
      End
      Begin VB.CommandButton Command1 
         Caption         =   "&Thêm"
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
         TabIndex        =   9
         Top             =   240
         Width           =   1215
      End
   End
   Begin VB.TextBox Text3 
      Height          =   615
      Left            =   6600
      TabIndex        =   7
      Top             =   1680
      Width           =   2295
   End
   Begin VB.TextBox Text2 
      Height          =   615
      Left            =   6600
      TabIndex        =   6
      Top             =   840
      Width           =   2295
   End
   Begin VB.TextBox Text1 
      Height          =   495
      Left            =   2280
      TabIndex        =   3
      Top             =   1680
      Width           =   2175
   End
   Begin MSFlexGridLib.MSFlexGrid MSNCC 
      Height          =   2655
      Left            =   120
      TabIndex        =   0
      Top             =   2400
      Width           =   9135
      _ExtentX        =   16113
      _ExtentY        =   4683
      _Version        =   393216
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "THÔNG TIN NHÀ CUNG CÂP"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   495
      Left            =   1800
      TabIndex        =   15
      Top             =   120
      Width           =   5655
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Diên Thoai"
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
      Left            =   4680
      TabIndex        =   5
      Top             =   1800
      Width           =   1935
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Dia Chi "
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
      Left            =   5040
      TabIndex        =   4
      Top             =   960
      Width           =   1455
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Tên Nhà Cung Câp"
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
      Left            =   0
      TabIndex        =   2
      Top             =   1800
      Width           =   2175
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00C0FFC0&
      Caption         =   "Mã Nhà Cung C?p"
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
      TabIndex        =   1
      Top             =   960
      Width           =   1935
   End
End
Attribute VB_Name = "F_DMNCC"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Option Explicit
Private flag As String



Private Sub command1_Click()
un_lock_text
setnull
End Sub
Private Sub setnull()
Text4.Text = ""
Text1.Text = ""
Text2.Text = ""
Text3.Text = ""
End Sub
Private Sub khoitaoluoi()
' khoi tao luoi gam 5 cot,20 dong
MSNCC.Cols = 5
MSNCC.Rows = 20
MSNCC.Font.Size = 10
MSNCC.Row = 0
'cot dau tien hien thi so thu tu
MSNCC.Col = 0
MSNCC.ColWidth(0) = 600
MSNCC.CellAlignment = 3
MSNCC.ColAlignment(0) = 3
MSNCC.Text = " STT"
'cot thu 2 hien thi ma NCC
MSNCC.Col = 1
MSNCC.ColWidth(1) = 1200
MSNCC.CellAlignment = 3
MSNCC.ColAlignment(1) = 3
MSNCC.Text = " Mã NCC "
'cot thu3 hien thi tên NCC
MSNCC.Col = 2
MSNCC.ColWidth(2) = 2500
MSNCC.CellAlignment = 3
MSNCC.ColAlignment(2) = 3
MSNCC.Text = " Tên NCC"
'cot thu 4 hien thi Dia chi NCC
MSNCC.Col = 3
MSNCC.ColWidth(3) = 2500
MSNCC.CellAlignment = 3
MSNCC.ColAlignment(3) = 3
MSNCC.Text = " Dia chi NCC"
' cot thu 5 hien thi Dien thoai NCC
MSNCC.Col = 4
MSNCC.ColWidth(4) = 1500
MSNCC.CellAlignment = 3
MSNCC.ColAlignment(4) = 3
MSNCC.Text = " Dien Thoai NCC"
'danh so thu tu tren luoi
Dim stt
MSNCC.Col = 0
For stt = 1 To MSNCC.Rows - 1
MSNCC.Row = stt
MSNCC.Text = stt
Next stt
End Sub
Private Sub display()
Dim rs As New ADODB.Recordset
Dim str, i
str = " select* From NhaCungCap"
rs.Open str, cn
If rs.EOF = False Then
i = 1
    While Not rs.EOF
    If MSNCC.Rows <= i Then
    MSNCC.Rows = MSNCC.Rows + 1
    MSNCC.TextMatrix(i, 0) = i
    End If
    MSNCC.TextMatrix(i, 1) = rs!mancc
    MSNCC.TextMatrix(i, 2) = rs!tenncc
    MSNCC.TextMatrix(i, 3) = rs!DCNCC
    MSNCC.TextMatrix(i, 4) = rs!DTNCC
   i = i + 1
   rs.MoveNext
   Wend
 End If
 rs.Close
 MSNCC.Refresh
End Sub

Private Sub Command2_Click()
Dim str, tmp, s
s = Trim(Text1.Text)
tmp = MsgBox("ban co muon xoa khong?" & "" & s, vbYesNo, "thông báo")
If tmp = vbYes Then
str = "delete*from NhaCungCap where MaNCC='" & Trim(Text4) & "'"
cn.Execute (str)
End If
If MSNCC.Rows > 1 And MSNCC.Rows <> 1 Then
MSNCC.RemoveItem (MSNCC.Row)
End If
Call khoitaoluoi
Call display
End Sub

Private Sub Command3_Click()
flag = "update"
suadulieu
'text1.SetFocus
End Sub
Private Sub suadulieu()
un_lock_text
Text4.Enabled = False
Text1.SetFocus
End Sub
Private Sub Command4_Click()
If flag <> "update" Then
flag = "save"
End If
luudulieu
lock_text
End Sub
Private Sub luudulieu()
Dim rs As New ADODB.Recordset
Dim str
If Trim(Text4) = "" Or Trim(Text1) = "" Then
MsgBox " Phai nhap du lieu day du truoc khi luu", vbOKOnly + vbExclamation, " Thông Báo"
lock_text
Exit Sub
End If
str = "select*from NhaCungCap where MaNCC='" & Trim(Text4) & "'"
rs.Open str, cn
If rs.EOF = True Then
str = " insert into NhaCungCap values('" & Trim(Text4) & "','" & Trim(Text1) & "','" & Trim(Text2) & "','" & Trim(Text3) & "')"
cn.Execute (str) ' them môt record moi vao bang NhaCungCap
MsgBox "Da Luu Thanh Cong", vbOKOnly + vbExclamation, "Thông Báo"
Else
If flag = "save" Then
MsgBox " ma nha cung cap da ton tai,vui long kiem tra lai", vbOKOnly + vbExclamation, "thông báo"
Me.MousePointer = 0
Exit Sub
End If
str = "update NhaCungCap set TenNCC='" & Trim(Text1) & "',DCNCC='" & Trim(Text2) & "',DTNCC='" & Trim(Text3) & "'where MaNCC='" & Trim(Text4) & "'"
cn.Execute (str)
End If
display
End Sub

Private Sub msncc_dblclick()
lock_text
MSNCC.Col = 1
Text4.Text = MSNCC.Text
MSNCC.Col = 2
Text1.Text = MSNCC.Text
MSNCC.Col = 3
Text2.Text = MSNCC.Text
MSNCC.Col = 4
Text3.Text = MSNCC.Text
End Sub


Private Sub Form_Load()
ConnectDataBase
lock_text
Command4.Enabled = False
khoitaoluoi
display
End Sub
Private Sub lock_text()
Text4.Enabled = False
Text1.Enabled = False
Text2.Enabled = False
Text3.Enabled = False
Command4.Enabled = False
Command1.Enabled = True
Command2.Enabled = True
Command3.Enabled = True
End Sub
Private Sub un_lock_text()
Text4.Enabled = True
Text1.Enabled = True
Text2.Enabled = True
Text3.Enabled = True
Command4.Enabled = True
Command1.Enabled = False
Command2.Enabled = False
Command3.Enabled = False
End Sub
Private Sub Command6_Click()
Unload Me
F_Main.Show
End Sub


