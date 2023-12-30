VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmThuoc 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Thuoc"
   ClientHeight    =   6825
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6180
   Icon            =   "Thuoc.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6825
   ScaleWidth      =   6180
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame2 
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
      TabIndex        =   7
      Top             =   5760
      Width           =   5895
      Begin VB.CommandButton cmdMoi 
         Caption         =   "Môùi"
         CausesValidation=   0   'False
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
         TabIndex        =   12
         ToolTipText     =   "Them du lieu"
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
         Left            =   1320
         TabIndex        =   11
         Top             =   360
         Width           =   1095
      End
      Begin VB.CommandButton cmdXoa 
         Caption         =   "Xoùa"
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
         Left            =   2520
         TabIndex        =   10
         Top             =   360
         Width           =   1095
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
         Left            =   4800
         TabIndex        =   9
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
         Left            =   3720
         TabIndex        =   8
         Top             =   360
         Width           =   975
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Nhaäp thoâng tin"
      BeginProperty Font 
         Name            =   "VNI-Times"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2175
      Left            =   120
      TabIndex        =   0
      Top             =   1200
      Width           =   5895
      Begin VB.TextBox txtMaThuoc 
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
         Left            =   2040
         MaxLength       =   8
         TabIndex        =   3
         Top             =   360
         Width           =   1095
      End
      Begin VB.TextBox txtDonGia 
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
         Left            =   2040
         TabIndex        =   2
         Top             =   960
         Width           =   2295
      End
      Begin VB.TextBox txtTenThuoc 
         BeginProperty Font 
            Name            =   "VNI-Times"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   405
         Left            =   2040
         TabIndex        =   1
         Top             =   1560
         Width           =   3375
      End
      Begin VB.Label Label2 
         Caption         =   "Ñôn giaù thuoác"
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
         TabIndex        =   6
         Top             =   960
         Width           =   1575
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Teân thuoác"
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
         Index           =   1
         Left            =   240
         TabIndex        =   5
         Top             =   1560
         Width           =   1230
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Maõ thuoác"
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
         Index           =   0
         Left            =   240
         TabIndex        =   4
         Top             =   480
         Width           =   1530
      End
   End
   Begin MSComctlLib.ListView lstThuoc 
      Height          =   2175
      Left            =   120
      TabIndex        =   13
      Top             =   3480
      Width           =   5895
      _ExtentX        =   10398
      _ExtentY        =   3836
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
         Object.Width           =   3159
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân thuoác"
         Object.Width           =   5292
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Ñôn giaù"
         Object.Width           =   1834
      EndProperty
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "THUOÁC"
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
      Left            =   120
      TabIndex        =   14
      Top             =   120
      Width           =   5895
   End
End
Attribute VB_Name = "frmThuoc"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

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

Private Sub cmdLuu_Click()
    Dim MaThuoc$, TenThuoc$
    Dim SQL$, Msg%
    Dim DonGia As Currency
    MaThuoc$ = Trim(txtMaThuoc) 'Cat bo khong trang
    TenThuoc$ = Trim(txtTenThuoc) 'du truoc va sau chuoi
    If Trim(txtDonGia.Text) <> "" Then
        DonGia = Str(Trim(txtDonGia))
     Else
        DonGia = 0
    End If
    SQL$ = "Select MaThuoc From tblThuoc Where MaThuoc=" _
                    & MaThuoc$
    If txtMaThuoc.Enabled = True Then
        If MaThuoc$ <> "" Then
            If Len(MaThuoc$) = 8 Then
                If TenThuoc$ <> "" Then
                    If Kt_Text(SQL) = True Then
                        DE.sp_nhapThuoc MaThuoc$, TenThuoc$, DonGia
                        disPlayListView
                        SetNull
                    Else 'Else kt_text
                        MsgBox "Thuoc nay da co trong co so du lieu", vbCritical
                    End If 'end if kt_text
                 Else
                    MsgBox "Ban chua nhap ten thuoc", vbInformation
                End If
            Else 'len(MaNoi)
                MsgBox "Ma thuoc khong hop le", vbInformation
            End If 'End if MoNoi
        Else
            MsgBox "Ban chua nhap ma thuoc", vbInformation
        End If
    Else
        If txtTenThuoc.Enabled = True Then
            If TenThuoc$ <> "" Then
                Msg = MsgBox("Ban co chac chan sua Thuoc nay khong    ", vbYesNo + vbQuestion)
                If Msg = vbYes Then
                    DE.sp_SuaThuoc MaThuoc$, TenThuoc$, DonGia
                    disPlayListView
                End If
            Else 'else kiem tra ten co gia tri khong
                MsgBox "Ban chua nhap ten thuoc", vbInformation
            End If 'kiem tra ten co rong khong
        Else 'else cua sua
        End If 'end if cua sua
    End If
End Sub

Private Sub cmdMoi_Click()
    cmdLuu.Enabled = True
    txtMaThuoc.Enabled = True
    txtTenThuoc.Enabled = True
    txtDonGia.Enabled = True
    SetNull
End Sub

Private Sub cmdSua_Click()
    txtMaThuoc.Enabled = False
    txtTenThuoc.Enabled = True
    txtDonGia.Enabled = True
    cmdLuu.Enabled = True
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub

Private Sub cmdXoa_Click()
    Dim MaThuoc$, Msg%
    MaThuoc$ = txtMaThuoc.Text
    Msg = MsgBox("ban co chac chan xoa thuoc nay khong nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_XoaThuoc MaThuoc$
        disPlayListView
        SetNull
    End If
End Sub

Private Sub Form_Load()
    txtMaThuoc.Enabled = False
    txtTenThuoc.Enabled = False
    cmdLuu.Enabled = False
    txtDonGia.Enabled = False
    '----------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    disPlayListView
End Sub

Private Sub lstThuoc_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaThuoc.Enabled = False
    txtMaThuoc.Text = Item.Text
    txtTenThuoc.Text = Item.SubItems(1)
    txtDonGia.Text = Item.SubItems(2)
End Sub
Private Sub SetNull()
    txtMaThuoc.Text = ""
    txtTenThuoc.Text = ""
    txtDonGia.Text = ""
End Sub

Private Sub txtDonGia_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, True
End Sub

Private Sub txtMaThuoc_KeyPress(KeyAscii As Integer)
     KiemTraText KeyAscii, False
End Sub
