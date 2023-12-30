VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmHuyen 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Huyen"
   ClientHeight    =   6495
   ClientLeft      =   3735
   ClientTop       =   1530
   ClientWidth     =   5655
   Icon            =   "Huyen.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6495
   ScaleWidth      =   5655
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
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
      TabIndex        =   8
      Top             =   5400
      Width           =   5415
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
         Left            =   4200
         TabIndex        =   13
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
         Left            =   3240
         TabIndex        =   12
         Top             =   360
         Width           =   855
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
         Left            =   2280
         TabIndex        =   11
         Top             =   360
         Width           =   855
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
         Left            =   1200
         TabIndex        =   10
         Top             =   360
         Width           =   975
      End
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
         Left            =   120
         TabIndex        =   9
         Top             =   360
         Width           =   975
      End
   End
   Begin MSComctlLib.ListView lstHuyen 
      Height          =   2535
      Left            =   120
      TabIndex        =   7
      Top             =   2760
      Width           =   5415
      _ExtentX        =   9551
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
         Text            =   "Maõ Huyeän"
         Object.Width           =   3528
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân Huyeän"
         Object.Width           =   5824
      EndProperty
   End
   Begin VB.Frame fr1 
      Height          =   1455
      Left            =   120
      TabIndex        =   0
      Top             =   1200
      Width           =   5415
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
         Left            =   3240
         TabIndex        =   5
         Top             =   240
         Width           =   2055
      End
      Begin VB.TextBox txtTenHuyen 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   390
         Left            =   1320
         TabIndex        =   4
         Top             =   885
         Width           =   3975
      End
      Begin VB.TextBox txtMaHuyen 
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
         Left            =   1320
         MaxLength       =   6
         TabIndex        =   2
         Top             =   240
         Width           =   855
      End
      Begin VB.Label lblTinh 
         Caption         =   "Thuoäc tænh:"
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
         Left            =   2160
         TabIndex        =   14
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label lblFieldLabel 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Teân Huyeän"
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
         Left            =   120
         TabIndex        =   3
         Top             =   960
         Width           =   1110
      End
      Begin VB.Label lblFieldLabel 
         Alignment       =   1  'Right Justify
         AutoSize        =   -1  'True
         Caption         =   "Maõ Huyeän:"
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
         Left            =   105
         TabIndex        =   1
         Top             =   285
         Width           =   1110
      End
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "HUYEÄN"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   27.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   240
      TabIndex        =   6
      Top             =   120
      Width           =   5295
   End
End
Attribute VB_Name = "frmHuyen"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim CoLuu As String

Private Sub cbTinh_Change()
    cbTinh.Text = ""
End Sub

Private Sub cbTinh_Click()
    disPlayListView
    If CoLuu = "Moi" Then
        txtMaHuyen.Text = Mid(cbTinh.Text, 1, 3)
    End If
End Sub

Private Sub cmdLuu_Click()
    Dim MaHuyen$, TenHuyen$, MaTinh$, SQL$
    Dim Msg As Integer
    Dim KT As Boolean, Te As Long
    MaHuyen = txtMaHuyen.Text
    TenHuyen = txtTenHuyen.Text
    MaTinh = Left(Trim(cbTinh.Text), 3)
    Trim (MaHuyen)
    TenHuyen = SuLiChuoi(TenHuyen)
    SQL = "Select MaHuyen from tblHuyen Where MaHuyen= " & MaHuyen
    If txtMaHuyen.Enabled = True Then
        If Len(MaHuyen) = 6 Then
            If MaTinh = Trim(Left(MaHuyen, 3)) Then
                Te = DE.sp_KiemTraTenHuyen(TenHuyen, MaTinh, KT)
                If KT = False Then
                    If Kt_Text(SQL) = True Then
                        If txtTenHuyen <> "" Then
                            DE.sp_NhapHuyen MaHuyen, TenHuyen, MaTinh
                            disPlayListView
                            SetNull
                        Else
                            MsgBox "Ban phai nhap ten huyen", vbInformation
                        End If
                    Else
                        MsgBox "Huyen nay da co trong du lieu", vbCritical
                    End If
                Else
                    MsgBox "Kiem tra lai du lieu, trong tinh co hai huyen trung ten", vbCritical
                End If
            Else
                MsgBox "Ma huyen khong hop le" & Chr(13) & Chr(10) & _
                                "Ba ky tu dau la ma tinh", vbQuestion
            End If
         Else
            MsgBox "Ma huyen khong hop le", vbInformation
         End If
    Else
         If txtTenHuyen.Enabled = True Then
            If TenHuyen <> "" Then
                Msg = MsgBox("Ban co dong y sua huyen nay khong?", vbYesNo + vbQuestion)
                If Msg = vbYes Then
                    DE.sp_SuaHuyen MaHuyen, TenHuyen
                    disPlayListView
                End If
            End If
         End If
    End If
    txtMaHuyen.Text = MaTinh
    txtTenHuyen.Text = ""
End Sub

Private Sub cmdMoi_Click()
    'cbTinh.Enabled = True
    CoLuu = "Moi"
    SetNull
    txtMaHuyen.Enabled = True
    txtTenHuyen.Enabled = True
    cmdLuu.Enabled = True
End Sub

Private Sub cmdSua_Click()
    cmdLuu.Enabled = True
    txtMaHuyen.Enabled = False
    txtTenHuyen.Enabled = True
    CoLuu = "Sua"
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    'cbTinh.Enabled = False
    CoLuu = ""
    Dim Msg As Integer
    Dim MaHuyen As String
    Dim TenHuyen As String
    MaHuyen = Trim(txtMaHuyen.Text)
    TenHuyen = Trim(txtTenHuyen.Text)
    Msg = MsgBox("Ban co chac chan xoa huyen nay khong?", vbYesNo + vbQuestion)
    If Msg = vbYes Then
        DE.sp_XoaHuyen MaHuyen, TenHuyen
        disPlayListView
    End If
End Sub

Private Sub Form_Load()
    CoLuu = ""
    cmdXoa.Enabled = Flag
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    'cbTinh.Enabled = False
    cmdLuu.Enabled = False
    txtMaHuyen.Enabled = False
    txtTenHuyen.Enabled = False
    OpenConnection
    'disPlayListview
    distPlayCombobox
End Sub

Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim Str As String
    Dim mItem As listItem
    Dim MaTinh As String
    MaTinh = cbTinh.Text
    Trim (MaTinh)
    Str = "Select * From tblHuyen Where tblHuyen.Matinh= " & _
                Left(MaTinh, 3)
    lstHuyen.ListItems.Clear
    Set rs = cn.Execute(Str) 'Thuc Hien Mot Lenh SQL duoc chi ra boi str
    If rs.EOF = False Then
         While Not rs.EOF
             Set mItem = lstHuyen.ListItems.Add(, , Trim(rs!MaHuyen))
             mItem.SubItems(1) = Trim(rs!TenHuyen)
             rs.MoveNext
        Wend
    End If
End Sub

Private Sub lstHuyen_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaHuyen.Text = Item.Text
    txtTenHuyen.Text = Item.SubItems(1)
    txtMaHuyen.Enabled = False
    txtTenHuyen.Enabled = False
End Sub

Private Sub distPlayCombobox()
    Dim rs As ADODB.Recordset
    Dim Str As String
    Dim Item As String
    cbTinh.Clear
    Str = "Select * From tblTinh Order by MaTinh asc"
    Set rs = cn.Execute(Str)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Item = ""
            Item = rs.Fields("MaTinh") & "  " & rs.Fields("TenTinh")
           cbTinh.AddItem Trim(Item)
           rs.MoveNext
        Loop
    End If
End Sub
Private Sub SetNull()
    txtMaHuyen.Text = ""
    txtTenHuyen.Text = ""
End Sub

Private Sub txtMaHuyen_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub
