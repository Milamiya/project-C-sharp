VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmDanhSachBenhNhan 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Danh sach benh nhan"
   ClientHeight    =   6210
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   11070
   Icon            =   "DanhSachBenhNhan.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6210
   ScaleWidth      =   11070
   ShowInTaskbar   =   0   'False
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
      TabIndex        =   1
      Top             =   4920
      Width           =   10815
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
         Left            =   6840
         TabIndex        =   3
         Top             =   360
         Width           =   2415
      End
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
         Left            =   1440
         TabIndex        =   2
         Top             =   360
         Width           =   2175
      End
   End
   Begin MSComctlLib.ListView lstBenhNhan 
      Height          =   4815
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   10815
      _ExtentX        =   19076
      _ExtentY        =   8493
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
      NumItems        =   8
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Hoï teân beänh nhaân"
         Object.Width           =   4410
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Ngaøy sinh"
         Object.Width           =   2364
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Gioùi tinh"
         Object.Width           =   1835
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "Soá nhaø"
         Object.Width           =   2187
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "Xaõ"
         Object.Width           =   2716
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "Huyeän"
         Object.Width           =   2716
      EndProperty
      BeginProperty ColumnHeader(7) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   6
         Text            =   "Tænh"
         Object.Width           =   2716
      EndProperty
      BeginProperty ColumnHeader(8) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   7
         Text            =   "MaBenhNhan"
         Object.Width           =   0
      EndProperty
   End
End
Attribute VB_Name = "frmDanhSachBenhNhan"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaBenhNhan$, TenBenhNhan$, NgaySinh$
Dim GT As Boolean
Public clThongTinBenhNhan As New clBenhNhan

Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstBenhNhan.ListItems.Clear
    SQL = "Select *  From vwThongTinBenhNhan"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenhNhan.ListItems.Add(, , Trim(rs!HoBenhNhan) & " " & Trim(rs!TenBenhNhan))
                   mItem.SubItems(1) = Trim(rs!NgaySinhBenhNhan)
                   mItem.SubItems(2) = tfGT(rs!GioiTinhBenhNhan)
                   mItem.SubItems(3) = Trim(rs!SoNhaBenhNhan)
                   mItem.SubItems(4) = Trim(rs!TenXa)
                   mItem.SubItems(5) = Trim(rs!TenHuyen)
                   mItem.SubItems(6) = Trim(rs!TenTinh)
                   mItem.SubItems(7) = Trim(rs!MaBenhNhan)
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub cmdBoQua_Click()
        MaBenhNhan = " "
        TenBenhNhan = " "
        NgaySinh = "__/__/____"
        GT = False
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
    If Trim(MaBenhNhan) = "" Then
        MaBenhNhan = " "
        TenBenhNhan = " "
        NgaySinh = "__/__/____"
        GT = False
        clThongTinBenhNhan.LayThongTinTuDanhSachBenhNhan MaBenhNhan, _
                TenBenhNhan, NgaySinh, GT
    Else
        clThongTinBenhNhan.LayThongTinTuDanhSachBenhNhan MaBenhNhan, _
                TenBenhNhan, NgaySinh, GT
    End If
End Sub

Private Sub lstBenhNhan_ItemClick(ByVal Item As MSComctlLib.listItem)
    cmdChon.Enabled = True
    MaBenhNhan = Trim(Item.SubItems(7))
    TenBenhNhan = Trim(Item.Text)
    NgaySinh = Trim(Item.SubItems(1))
    GT = strGT(Item.SubItems(2))
End Sub
