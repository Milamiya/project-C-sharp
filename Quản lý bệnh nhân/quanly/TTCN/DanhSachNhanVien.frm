VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmDanhSachNhanVien 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Danh sach nhan vien"
   ClientHeight    =   6150
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   9765
   Icon            =   "DanhSachNhanVien.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6150
   ScaleWidth      =   9765
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      Caption         =   " Choïn "
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   120
      TabIndex        =   0
      Top             =   4920
      Width           =   9495
      Begin VB.CommandButton cmdChon 
         Caption         =   "Choïn"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   1680
         TabIndex        =   2
         Top             =   360
         Width           =   2175
      End
      Begin VB.CommandButton cmdBoQua 
         Caption         =   "Boû Qua"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   12
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   5400
         TabIndex        =   1
         Top             =   360
         Width           =   2415
      End
   End
   Begin MSComctlLib.ListView lstNhanVien 
      Height          =   4695
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   9495
      _ExtentX        =   16748
      _ExtentY        =   8281
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      GridLines       =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   4
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Hoï teân nhaân vieân"
         Object.Width           =   7408
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Ngaøy sinh"
         Object.Width           =   3246
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Gioùi tinh"
         Object.Width           =   2717
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Maõ Nhaân vieân"
         Object.Width           =   3211
      EndProperty
   End
End
Attribute VB_Name = "frmDanhSachNhanVien"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaNhanVien$, HoTenNhanVien$
Public clNhanVien As New clNhanVien

Private Sub disPlayListView()
    Dim mItem As listItem
    Dim rs As New ADODB.Recordset
    Dim Str$
    lstNhanVien.ListItems.Clear
    Str = "select * from tblNhanVien order by MaNhanVien asc"
    Set rs = cn.Execute(Str) 'Thuc Hien Mot Lenh SQL duoc chi ra boi str
    If rs.EOF = False Then
         Do While Not rs.EOF
               Set mItem = lstNhanVien.ListItems.Add(, , rs!HoTenNhanVien)
               mItem.SubItems(1) = rs!NgaySinhNhanVien
               mItem.SubItems(2) = tfGT(rs!GioiTinhNhanVien)
               mItem.SubItems(3) = rs!MaNhanVien
               rs.MoveNext
        Loop 'Wend
    End If
End Sub

Private Sub cmdBoQua_Click()
    MaNhanVien = ""
    Unload Me
End Sub

Private Sub cmdChon_Click()
    Unload Me
End Sub

Private Sub Form_Load()
    cmdChon.Enabled = False
    disPlayListView
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If MaNhanVien = "" Then
        MaNhanVien = " "
        HoTenNhanVien = " "
        clNhanVien.SetNull
    Else
        clNhanVien.LayTTNhanVien MaNhanVien, HoTenNhanVien
    End If
End Sub

Private Sub lstNhanVien_ItemClick(ByVal Item As MSComctlLib.listItem)
    cmdChon.Enabled = True
    MaNhanVien = Item.SubItems(3)
    HoTenNhanVien = Item.Text
End Sub
