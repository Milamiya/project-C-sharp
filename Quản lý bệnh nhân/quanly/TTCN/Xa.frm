VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmXa 
   Caption         =   "Xa"
   ClientHeight    =   6240
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   8160
   Icon            =   "Xa.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   6240
   ScaleWidth      =   8160
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame3 
      Height          =   1335
      Left            =   120
      TabIndex        =   13
      Top             =   1080
      Width           =   5055
      Begin VB.TextBox txtTenXa 
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
         TabIndex        =   17
         Top             =   840
         Width           =   3375
      End
      Begin VB.TextBox txtMaXa 
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
         MaxLength       =   9
         TabIndex        =   16
         Top             =   360
         Width           =   1215
      End
      Begin VB.Label lblFieldLabel 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Maõ xaõ:"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   0
         Left            =   300
         TabIndex        =   15
         Top             =   285
         Width           =   690
      End
      Begin VB.Label lblFieldLabel 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Teân xaõ:"
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Index           =   2
         Left            =   240
         TabIndex        =   14
         Top             =   810
         Width           =   750
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Tröïc thuoäc"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3975
      Left            =   5280
      TabIndex        =   8
      Top             =   1080
      Width           =   2775
      Begin VB.ComboBox cbHuyen 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   120
         TabIndex        =   10
         Top             =   2640
         Width           =   2535
      End
      Begin VB.ComboBox cbTinh 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   420
         Left            =   120
         TabIndex        =   9
         Top             =   960
         Width           =   2535
      End
      Begin VB.Label Label3 
         Caption         =   "Huyeän :"
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
         Left            =   240
         TabIndex        =   12
         Top             =   2040
         Width           =   1935
      End
      Begin VB.Label Label2 
         Caption         =   "Tænh :"
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
         TabIndex        =   11
         Top             =   360
         Width           =   1935
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Chöùc naêng"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   120
      TabIndex        =   0
      Top             =   5160
      Width           =   7935
      Begin VB.CommandButton cmdMoi 
         Caption         =   "Môùi"
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
         Left            =   360
         TabIndex        =   5
         Top             =   360
         Width           =   1095
      End
      Begin VB.CommandButton cmdSua 
         Caption         =   "Söûa"
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
         Left            =   1920
         TabIndex        =   4
         Top             =   360
         Width           =   1095
      End
      Begin VB.CommandButton cmdXoa 
         Caption         =   "Xoaù"
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
         Left            =   3480
         TabIndex        =   3
         Top             =   360
         Width           =   975
      End
      Begin VB.CommandButton cmdLuu 
         Caption         =   "Löu"
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
         Left            =   5040
         TabIndex        =   2
         Top             =   360
         Width           =   975
      End
      Begin VB.CommandButton cmdThoat 
         Caption         =   "Thoaùt"
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
         Left            =   6480
         TabIndex        =   1
         Top             =   360
         Width           =   1095
      End
   End
   Begin MSComctlLib.ListView lstXa 
      Height          =   2535
      Left            =   120
      TabIndex        =   6
      Top             =   2520
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   4471
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
         Text            =   "Maõ xaõ"
         Object.Width           =   3351
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân xaõ"
         Object.Width           =   5824
      EndProperty
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "XAÕ"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   27.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   240
      TabIndex        =   7
      Top             =   120
      Width           =   7815
   End
End
Attribute VB_Name = "frmXa"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cbhuyen_Change()
    cbHuyen.Text = ""
End Sub

Private Sub cbhuyen_Click()
    disPlayListView
End Sub

Private Sub cbTinh_Change()
    cbTinh.Text = ""
End Sub

Private Sub cbTinh_Click()
    disPlayCbHuyen
End Sub

Private Sub cmdLuu_Click()
    Dim MaXa As String
    Dim MaHuyen As String
    Dim TenXa As String
    Dim SQL As String
    Dim Msg As Integer
    TenXa = SuLiChuoi(Trim(txtTenXa.Text))
    MaHuyen = Left(Trim(cbHuyen.Text), 6)
    MaXa = Trim(txtMaXa.Text)
    SQL = "Select MaXa From tblXa Where tblXa.MaXa=" & MaXa
    If txtMaXa.Enabled = True Then
        If MaXa <> "" Then
            If Len(MaXa) = 9 Then
                If Left(MaXa, 6) = MaHuyen Then
                    If Kt_Text(SQL) = True Then
                        DE.sp_NhapXa MaXa, TenXa, MaHuyen
                        disPlayListView
                        SetNull
                     Else
                        MsgBox "Ma xa nay da co trong co so du lieu", vbCritical
                    End If
                Else
                    MsgBox "Ma xa khong hop le " & Chr(13) & Chr(10) & _
                                    "Ma xa phai co sau ky tu dau la ma huyen", vbCritical
                    txtMaXa.Text = ""
                End If
            Else
                MsgBox "Ma xa khong hop le chieu dai phai bang 9", vbInformation
            End If
        Else
                MsgBox "Ban chua nhap ten xa", vbInformation
        End If
     Else
        If txtTenXa.Enabled = True Then
            If TenXa <> "" Then
                Msg = MsgBox("Ban co chac sua lai ten xa nay khong", vbQuestion + vbYesNo)
                If Msg = vbYes Then
                    DE.sp_SuaXa MaXa, TenXa
                    disPlayListView
                End If
            Else
                MsgBox "Ban chua nhap ten xa", vbInformation
            End If
        End If
    End If
End Sub

Private Sub cmdMoi_Click()
    txtMaXa.Enabled = True
    txtTenXa.Enabled = True
    cmdLuu.Enabled = True
    SetNull
End Sub

Private Sub cmdSua_Click()
    cmdLuu.Enabled = True
    txtTenXa.Enabled = True
    'txtTenXa.Text = ""
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub SetNull()
    txtMaXa.Text = ""
    txtTenXa.Text = ""
End Sub

Private Sub cmdXoa_Click()
    Dim Msg As Integer
    Dim MaXa As String
    Dim TenXa As String
    MaXa = Trim(txtMaXa.Text)
    TenXa = Trim(txtTenXa.Text)
    Msg = MsgBox("Ban co chac chan xoa xa nay khong ?", vbYesNo + vbQuestion)
    If Msg = vbYes Then
        DE.sp_XoaXa MaXa, TenXa
        disPlayListView
    End If
End Sub

Private Sub Form_Load()
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    '----------------------------------------
    txtMaXa.Enabled = False
    txtTenXa.Enabled = False
    cmdLuu.Enabled = False
    DisPlaycbTinh
End Sub

Private Sub DisPlaycbTinh()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    SQL = "Select * from tblTinh"
    cbTinh.Clear
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            cbTinh.AddItem Trim(rs.Fields("Matinh")) & _
                            "   " & Trim(rs.Fields("TenTinh"))
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub disPlayCbHuyen()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim MaTinh As String
    cbHuyen.Clear
    MaTinh = Left(Trim(cbTinh.Text), 3)  'Lay ma tinh tronh combobox
    SQL = "Select * from tblHuyen Where tblHuyen.Matinh= " & MaTinh
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            cbHuyen.AddItem Trim(rs.Fields("MaHuyen")) & _
                            "   " & Trim(rs.Fields("TenHuyen"))
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim MaHuyen As String
    Dim mItem As listItem
    lstXa.ListItems.Clear
    MaHuyen = Left(Trim(cbHuyen.Text), 6)
    SQL = "Select * From tblXa Where tblXa.MaHuyen= " & _
                  MaHuyen & "Order by MaXa"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstXa.ListItems.Add(, , rs!MaXa)
                   mItem.SubItems(1) = rs!TenXa
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub lstXa_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaXa.Text = Trim(Item.Text)
    txtTenXa.Text = Trim(Item.SubItems(1))
    txtMaXa.Enabled = False
End Sub

Private Sub txtMaXa_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub
