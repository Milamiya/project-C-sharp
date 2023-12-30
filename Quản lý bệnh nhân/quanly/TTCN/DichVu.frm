VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmDichVu 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Dich vu"
   ClientHeight    =   6915
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6135
   Icon            =   "DichVu.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6915
   ScaleWidth      =   6135
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
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
      TabIndex        =   6
      Top             =   1200
      Width           =   5895
      Begin VB.TextBox txtTenDichVu 
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
         TabIndex        =   14
         Top             =   1560
         Width           =   3375
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
         TabIndex        =   13
         Top             =   960
         Width           =   2295
      End
      Begin VB.TextBox txtMaDichVu 
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
         MaxLength       =   3
         TabIndex        =   12
         Top             =   360
         Width           =   855
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Maõ dòch vuï"
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
         Left            =   240
         TabIndex        =   9
         Top             =   480
         Width           =   1335
      End
      Begin VB.Label lblFieldLabel 
         AutoSize        =   -1  'True
         Caption         =   "Teân dòch vuï"
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
         Index           =   1
         Left            =   240
         TabIndex        =   8
         Top             =   1440
         Width           =   1410
      End
      Begin VB.Label Label2 
         Caption         =   "Ñôn giaù dòch vuï"
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
         TabIndex        =   7
         Top             =   960
         Width           =   1575
      End
   End
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
      TabIndex        =   0
      Top             =   5760
      Width           =   5895
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
         TabIndex        =   5
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
         Left            =   4800
         TabIndex        =   4
         Top             =   360
         Width           =   975
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
         TabIndex        =   3
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
         TabIndex        =   2
         Top             =   360
         Width           =   1095
      End
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
         TabIndex        =   1
         ToolTipText     =   "Them du lieu"
         Top             =   360
         Width           =   1095
      End
   End
   Begin MSComctlLib.ListView lstDichVu 
      Height          =   2175
      Left            =   120
      TabIndex        =   10
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
         Text            =   "Maõ dòch vuï"
         Object.Width           =   3159
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Teân dòch vuï"
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
      Caption         =   "DÒCH VUÏ"
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
      TabIndex        =   11
      Top             =   120
      Width           =   5895
   End
End
Attribute VB_Name = "frmDichVu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdLuu_Click()
    Dim Madichvu$, TenDichVu$
    Dim SQL$, Msg%
    Dim DonGia As Currency
    Madichvu$ = Trim(txtMaDichVu)
    TenDichVu$ = Trim(txtTenDichVu)
    DonGia = Str(Trim(txtDonGia))
    SQL$ = "Select MaDichVu From tblDichVu Where MaDichVu=" _
                    & Madichvu$
    If txtMaDichVu.Enabled = True Then
        If Madichvu$ <> "" Then
            If Len(Madichvu$) = 3 Then
                If TenDichVu$ <> "" Then
                    If Kt_Text(SQL) = True Then
                        DE.sp_nhapdichvu Madichvu$, TenDichVu$, DonGia
                        disPlayListView
                        SetNull
                    Else 'Else kt_text
                        MsgBox "Dich vu nay da co trong co so du lieu", vbCritical
                    End If 'end if kt_text
                 Else
                    MsgBox "Ban chua nhap ten dich vu", vbInformation
                End If
            Else 'len(MaNoi)
                MsgBox "Ma dich vu khong hop le", vbInformation
            End If 'End if MoNoi
        Else
            MsgBox "Ban chua nhap ma dichvu", vbInformation
        End If
    Else
        If txtTenDichVu.Enabled = True Then
            If TenDichVu$ <> "" Then
                Msg = MsgBox("Ban co chac chan sua dich vu nay khong    ", vbYesNo + vbQuestion)
                If Msg = vbYes Then
                    DE.sp_SuaDichVu Madichvu$, TenDichVu$, DonGia
                    disPlayListView
                End If
            Else 'else kiem tra ten co gia tri khong
                MsgBox "Ban chua nhap ten dich vu", vbInformation
            End If 'kiem tra ten co rong khong
        Else 'else cua sua
        End If 'end if cua sua
    End If
End Sub

Private Sub cmdMoi_Click()
    cmdLuu.Enabled = True
    txtMaDichVu.Enabled = True
    txtTenDichVu.Enabled = True
    txtDonGia.Enabled = True
    SetNull
End Sub

Private Sub cmdSua_Click()
    txtMaDichVu.Enabled = False
    txtTenDichVu.Enabled = True
    txtDonGia.Enabled = True
    cmdLuu.Enabled = True
End Sub

Private Sub cmdThoat_Click()
    Unload Me
End Sub
Private Sub disPlayListView()
    Dim rs As ADODB.Recordset
    Dim SQL As String
    Dim mItem As listItem
    lstDichVu.ListItems.Clear
    SQL = "Select * From tblDichVu Order by MaDichVu"
    Set rs = cn.Execute(SQL)
    If rs.EOF = False Then
        Do While rs.EOF = False
            Set mItem = lstDichVu.ListItems.Add(, , rs!Madichvu)
                   mItem.SubItems(1) = rs!TenDichVu
                   mItem.SubItems(2) = rs!DonGiaDV
            rs.MoveNext
        Loop
    End If
End Sub

Private Sub cmdXoa_Click()
    Dim Madichvu$, Msg%
    Madichvu$ = txtMaDichVu.Text
    Msg = MsgBox("ban co chac chan xoa dich vu nay khong nay khong", vbQuestion + vbYesNo)
    If Msg = vbYes Then
        DE.sp_Xoadichvu Madichvu$
        disPlayListView
        SetNull
    End If
End Sub

Private Sub Form_Load()
    txtMaDichVu.Enabled = False
    txtTenDichVu.Enabled = False
    cmdLuu.Enabled = False
    txtDonGia.Enabled = False
    '----------------------------
    cmdMoi.Enabled = Flag
    cmdSua.Enabled = Flag
    cmdXoa.Enabled = Flag
    disPlayListView
End Sub

Private Sub lstDichVu_ItemClick(ByVal Item As MSComctlLib.listItem)
    txtMaDichVu.Enabled = False
    txtMaDichVu.Text = Item.Text
    txtTenDichVu.Text = Item.SubItems(1)
    txtDonGia.Text = Item.SubItems(2)
End Sub

Private Sub txtDonGia_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, True
End Sub

Private Sub txtMaDichVu_KeyPress(KeyAscii As Integer)
    KiemTraText KeyAscii, False
End Sub

Private Sub SetNull()
    txtMaDichVu.Text = ""
    txtTenDichVu.Text = ""
    txtDonGia.Text = ""
End Sub
