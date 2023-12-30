VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmDanhSachNoiDieuTri 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Danh sach noi dieu tri"
   ClientHeight    =   6660
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7590
   Icon            =   "frmDanhSachNoiDieuTri.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6660
   ScaleWidth      =   7590
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
      Top             =   5400
      Width           =   7335
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
         Left            =   4560
         TabIndex        =   2
         Top             =   360
         Width           =   1455
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
         Left            =   1080
         TabIndex        =   1
         Top             =   360
         Width           =   1455
      End
   End
   Begin MSComctlLib.ListView lstNoiDieuTri 
      Height          =   5295
      Left            =   120
      TabIndex        =   3
      Top             =   0
      Width           =   7335
      _ExtentX        =   12938
      _ExtentY        =   9340
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
         Text            =   "Ten noi dieu tri"
         Object.Width           =   6879
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Ma noi dieu tri"
         Object.Width           =   3422
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Don gia"
         Object.Width           =   2540
      EndProperty
   End
End
Attribute VB_Name = "frmDanhSachNoiDieuTri"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaNoiDieuTri$, TenNoiDieuTri$
Dim DonGia As Currency
Public clNoiDieuTri As New clNoiDieuTri

Private Sub cmdBoQua_Click()
    MaNoiDieuTri = ""
    Unload Me
End Sub
Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstNoiDieuTri.ListItems.Clear
    SQL = "Select * From tblNoiDieuTri Order by MaNoiDieuTri"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstNoiDieuTri.ListItems.Add(, , Trim(rs!TenNoiDieuTri))
                   mItem.SubItems(1) = rs!MaNoiDieuTri
                   mItem.SubItems(2) = rs!DonGia
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub cmdChon_Click()
    Unload Me
End Sub

Private Sub Form_Load()
    disPlayListView
    cmdChon.Enabled = False
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If MaNoiDieuTri = "" Then
        clNoiDieuTri.SetNull
    Else
        clNoiDieuTri.LayTTNoiDT MaNoiDieuTri, TenNoiDieuTri
    End If
End Sub

Private Sub lstNoiDieuTri_ItemClick(ByVal Item As MSComctlLib.listItem)
    cmdChon.Enabled = True
    MaNoiDieuTri = Item.SubItems(1)
    TenNoiDieuTri = Item.Text
End Sub
