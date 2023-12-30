VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmFile 
   BorderStyle     =   5  'Sizable ToolWindow
   Caption         =   "File"
   ClientHeight    =   3015
   ClientLeft      =   60
   ClientTop       =   300
   ClientWidth     =   3255
   ControlBox      =   0   'False
   BeginProperty Font 
      Name            =   "Times New Roman"
      Size            =   12
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MDIChild        =   -1  'True
   MinButton       =   0   'False
   ScaleHeight     =   3015
   ScaleWidth      =   3255
   ShowInTaskbar   =   0   'False
   Begin MSComctlLib.TreeView TreeView1 
      Height          =   2175
      Left            =   720
      TabIndex        =   0
      Top             =   0
      Width           =   1935
      _ExtentX        =   3413
      _ExtentY        =   3836
      _Version        =   393217
      Style           =   7
      ImageList       =   "ImageList1"
      Appearance      =   1
      MousePointer    =   99
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   0
      Top             =   0
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   8
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmFile.frx":0000
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmFile.frx":0354
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmFile.frx":06A8
            Key             =   ""
         EndProperty
         BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmFile.frx":09FC
            Key             =   ""
         EndProperty
         BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmFile.frx":0D50
            Key             =   ""
         EndProperty
         BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmFile.frx":10A4
            Key             =   ""
         EndProperty
         BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmFile.frx":1200
            Key             =   ""
         EndProperty
         BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "frmFile.frx":135C
            Key             =   ""
         EndProperty
      EndProperty
   End
End
Attribute VB_Name = "frmFile"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Public nod As Integer
Public nodX As Node   ' Tao cay Node.
Private Sub Form_Resize()
On Error Resume Next
   With frmFile
      If .Height > 6150 Then .Height = 6150
      If .Width < 2700 Then .Width = 2700
   End With
   frmProperties.Move 0, frmFile.Height, frmFile.Width, fMainForm.ScaleHeight - frmFile.Height
   frmDoc.Move frmFile.Width, 0, fMainForm.ScaleWidth - frmFile.Width, fMainForm.ScaleHeight
   TreeView1.Move frmFile.Left, frmFile.Top, frmFile.Width - 100, frmFile.Height - 320
End Sub
Private Sub Form_Load()
   TitleFile
End Sub
Private Sub TreeView1_Click()
    If frmDoc.ListObject.Visible = True And frmDoc.cmdListObject.Visible = True Then
        frmDoc.cmdListObject.Visible = False
        frmDoc.ListObject.Visible = False
    End If
End Sub

Private Sub TreeView1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
   If Button = 2 Then
      PopupMenu fMainForm.MnuFileA
   End If
End Sub
Public Sub TitleFile()
   Set nodX = frmFile.TreeView1.Nodes.Add(, , "r", "< Your project >", 6)
   nodX.EnsureVisible    ' Dua ra tat ca cac Node.
   Set nodX = frmFile.TreeView1.Nodes.Add("r", tvwChild, "C2", "Project", 7)
   nodX.EnsureVisible   ' Dua ra tat ca cac Node.
   
End Sub

Private Sub TreeView1_NodeClick(ByVal Node As MSComctlLib.Node)
Static a As Byte
   If Node.index = a Then
      frmDoc.SetFocus
   End If
   If Node.Selected = True Then a = Node.index
   '============================================
   If Node.index >= 3 Then
      Public_Node = Node.index
      If frmDoc.SSTab.Tab = 1 Then frmDoc.SSTab.Tab = 0
      If Left(Node.Text, 7) = "NewPage" Then
         frmDoc.Caption = Node.Text
         frmDoc.rtfSource.Text = ServerText(Node.index - 2)
      Else
         frmDoc.Caption = Node.Text
         frmDoc.rtfSource.Text = ServerText(Node.index - 2)
      End If
      If Right(frmDoc.Caption, 3) = "txt" Or Right(frmDoc.Caption, 3) = "css" Then
         frmDoc.SSTab.TabEnabled(0) = False
         frmDoc.SSTab.TabEnabled(1) = False
         frmOption.chkHTML.Enabled = False
         frmOption.chkAttri.Enabled = False
         frmOption.chkKey.Enabled = False
      Else
         frmDoc.SSTab.TabEnabled(0) = True
         frmDoc.SSTab.TabEnabled(1) = True
         frmOption.chkHTML.Enabled = True
         frmOption.chkAttri.Enabled = True
         frmOption.chkKey.Enabled = True
         If frmOption.chkHTML.value = 1 Then Call Change_ToKen(HTML, frmOption.cmdHTML.BackColor) Else Call Change_ToKen(HTML, vbBlack)
         If frmOption.chkKey.value = 1 Then Call Change_Command(Command, frmOption.cmdKey.BackColor) Else Call Change_Command(Command, vbBlack)
         If frmOption.chkAttri.value = 1 Then Call Change_ToKen(ValueHTML, frmOption.cmdAttri.BackColor) Else Call Change_ToKen(ValueHTML, vbBlack)
      End If
      
   End If
End Sub

