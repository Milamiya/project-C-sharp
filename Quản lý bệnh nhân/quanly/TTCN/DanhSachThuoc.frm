VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmDanhSachThuoc 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Danh sach thuoc"
   ClientHeight    =   7830
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7335
   Icon            =   "DanhSachThuoc.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7830
   ScaleWidth      =   7335
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame2 
      Caption         =   "Caùch duøng"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1215
      Left            =   240
      TabIndex        =   4
      Top             =   120
      Width           =   6855
      Begin VB.TextBox txtLieuDung 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   4320
         TabIndex        =   8
         Top             =   480
         Width           =   2175
      End
      Begin VB.TextBox txtSoLuong 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1080
         TabIndex        =   7
         Top             =   480
         Width           =   1935
      End
      Begin VB.Label Label2 
         Caption         =   "Lieøu duøng"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   3240
         TabIndex        =   6
         Top             =   480
         Width           =   1455
      End
      Begin VB.Label Label1 
         Caption         =   "Soá löôïng"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   5
         Top             =   480
         Width           =   1335
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Choïn thuoác"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   120
      TabIndex        =   1
      Top             =   6840
      Width           =   7095
      Begin VB.CommandButton cmdBoQua 
         Caption         =   "Boû qua"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   3960
         TabIndex        =   3
         Top             =   360
         Width           =   2175
      End
      Begin VB.CommandButton cmdChon 
         Caption         =   "Choïn"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   960
         TabIndex        =   2
         Top             =   360
         Width           =   2055
      End
   End
   Begin MSComctlLib.ListView lstThuoc 
      Height          =   5415
      Left            =   120
      TabIndex        =   0
      Top             =   1440
      Width           =   7095
      _ExtentX        =   12515
      _ExtentY        =   9551
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
      NumItems        =   3
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Maõ thuoác"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân thuoác"
         Object.Width           =   6703
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Ñôn giaù"
         Object.Width           =   3070
      EndProperty
   End
End
Attribute VB_Name = "frmDanhSachThuoc"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaThuoc$, TenThuoc$, DonGia As Currency
Dim SoLuong%, LieuDung$
Public clThuoc As New clBenhNhan

Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstThuoc.ListItems.Clear
    SQL = "Select * From tblThuoc Order by MaThuoc"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstThuoc.ListItems.Add(, , rs!MaThuoc)
                   mItem.SubItems(1) = rs!TenThuoc
                   mItem.SubItems(2) = rs!DonGia
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub cmdBoQua_Click()
    MaThuoc = ""
    Unload Me
End Sub

Private Sub cmdChon_Click()
    If Trim(txtSoLuong.Text) = "" Then
        SoLuong = 1
    Else
        SoLuong = Str(Trim(txtSoLuong.Text))
    End If
    LieuDung = Trim(txtLieuDung)
    If LieuDung = "" Then LieuDung = "1v/ngay"
    Unload Me
End Sub

Private Sub Form_Load()
    disPlayListView
    cmdChon.Enabled = False
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If Trim(MaThuoc = "") Then
        MaThuoc = " "
        TenThuoc = " "
        DonGia = 0
        SoLuong = 0
        LieuDung = "0"
        clThuoc.TTThuocVao MaThuoc, TenThuoc, DonGia, SoLuong, LieuDung
    Else
        clThuoc.TTThuocVao MaThuoc, TenThuoc, DonGia, SoLuong, LieuDung
    End If
End Sub

Private Sub lstThuoc_ItemClick(ByVal Item As MSComctlLib.listItem)
    cmdChon.Enabled = True
    MaThuoc = Trim(Item.Text)
    TenThuoc = Trim(Item.SubItems(1))
    DonGia = Str(Trim(Item.SubItems(2)))
End Sub
