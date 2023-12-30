VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmDanhSachBenh 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Benh"
   ClientHeight    =   6840
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6180
   Icon            =   "DanhSachBenh.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6840
   ScaleWidth      =   6180
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
      Top             =   5520
      Width           =   5895
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
         Left            =   720
         TabIndex        =   2
         Top             =   360
         Width           =   1455
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
         Left            =   3600
         TabIndex        =   1
         Top             =   360
         Width           =   1455
      End
   End
   Begin MSComctlLib.ListView lstBenh 
      Height          =   5295
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   5895
      _ExtentX        =   10398
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
      NumItems        =   2
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Teân beänh"
         Object.Width           =   6879
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Maõ beänh"
         Object.Width           =   3422
      EndProperty
   End
End
Attribute VB_Name = "frmDanhSachBenh"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim MaBenh$, TenBenh$
Public clBenh As New clTTBenh

Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstBenh.ListItems.Clear
    SQL = "Select * From tblBenh Order by MaBenh"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstBenh.ListItems.Add(, , Trim(rs!MaBenh))
                   mItem.SubItems(1) = Trim(rs!TenBenh)
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub cmdBoQua_Click()
    MaBenh = ""
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
    If Trim(MaBenh) = "" Then
        MaBenh = " "
        TenBenh = " "
        clBenh.ThongTTVao MaBenh, TenBenh
    Else
        clBenh.ThongTTVao MaBenh, TenBenh
    End If
End Sub

Private Sub lstBenh_ItemClick(ByVal Item As MSComctlLib.listItem)
    cmdChon.Enabled = True
    MaBenh = Item.Text
    TenBenh = Item.SubItems(1)
End Sub
