VERSION 5.00
Object = "{EAB22AC0-30C1-11CF-A7EB-0000C05BAE0B}#1.1#0"; "SHDOCVW.DLL"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "TABCTL32.OCX"
Begin VB.Form frmDoc 
   BackColor       =   &H80000004&
   ClientHeight    =   6075
   ClientLeft      =   120
   ClientTop       =   585
   ClientWidth     =   7695
   ForeColor       =   &H00C00000&
   Icon            =   "frmDocument.frx":0000
   LinkTopic       =   "Form1"
   MDIChild        =   -1  'True
   Moveable        =   0   'False
   ScaleHeight     =   405
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   513
   Visible         =   0   'False
   Begin RichTextLib.RichTextBox ToolTip 
      Height          =   375
      Left            =   3720
      TabIndex        =   5
      TabStop         =   0   'False
      Top             =   720
      Visible         =   0   'False
      Width           =   2415
      _ExtentX        =   4260
      _ExtentY        =   661
      _Version        =   393217
      BackColor       =   -2147483624
      Enabled         =   -1  'True
      TextRTF         =   $"frmDocument.frx":014A
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.ListBox ListObject 
      BackColor       =   &H80000018&
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   345
      ItemData        =   "frmDocument.frx":0263
      Left            =   0
      List            =   "frmDocument.frx":0265
      Sorted          =   -1  'True
      TabIndex        =   4
      TabStop         =   0   'False
      ToolTipText     =   "Double  Click ?"
      Top             =   960
      Visible         =   0   'False
      Width           =   3975
   End
   Begin VB.CommandButton cmdListObject 
      BackColor       =   &H00C0E0FF&
      Caption         =   " "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      Style           =   1  'Graphical
      TabIndex        =   3
      TabStop         =   0   'False
      Top             =   720
      Visible         =   0   'False
      Width           =   3990
   End
   Begin TabDlg.SSTab SSTab 
      Height          =   4695
      Left            =   600
      TabIndex        =   1
      TabStop         =   0   'False
      Top             =   1080
      Width           =   6135
      _ExtentX        =   10821
      _ExtentY        =   8281
      _Version        =   393216
      TabOrientation  =   1
      Tabs            =   2
      TabsPerRow      =   2
      TabHeight       =   529
      ForeColor       =   16711680
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      TabCaption(0)   =   "    &Editor    "
      TabPicture(0)   =   "frmDocument.frx":0267
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "rtfSource"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "dlgCommonDialog"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).ControlCount=   2
      TabCaption(1)   =   "    Bro&wser    "
      TabPicture(1)   =   "frmDocument.frx":0283
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "WebBrowser"
      Tab(1).ControlCount=   1
      Begin MSComDlg.CommonDialog dlgCommonDialog 
         Left            =   2280
         Top             =   3120
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin SHDocVwCtl.WebBrowser WebBrowser 
         Height          =   30
         Left            =   -69240
         TabIndex        =   2
         TabStop         =   0   'False
         Top             =   4320
         Width           =   255
         ExtentX         =   450
         ExtentY         =   53
         ViewMode        =   0
         Offline         =   0
         Silent          =   0
         RegisterAsBrowser=   0
         RegisterAsDropTarget=   1
         AutoArrange     =   0   'False
         NoClientEdge    =   0   'False
         AlignLeft       =   0   'False
         ViewID          =   "{0057D0E0-3573-11CF-AE69-08002B2E1262}"
         Location        =   ""
      End
      Begin RichTextLib.RichTextBox rtfSource 
         Height          =   855
         Left            =   480
         TabIndex        =   0
         Top             =   3120
         Width           =   3255
         _ExtentX        =   5741
         _ExtentY        =   1508
         _Version        =   393217
         BackColor       =   16777215
         Enabled         =   -1  'True
         HideSelection   =   0   'False
         ScrollBars      =   3
         RightMargin     =   24000
         TextRTF         =   $"frmDocument.frx":029F
         BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
            Name            =   "Times New Roman"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
      End
   End
End
Attribute VB_Name = "frmDoc"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim Vtri As POINTAPI
Public Flag As Boolean
Dim OfObject() As String
Dim ChuoiObject() As String
Dim Position_Current  As Long
Public TrueFalse As Boolean
Public BienHelp As String
'=============================
Dim begin_String As Long
Dim end_String As Long
Dim Ftab As Byte, Space_Tab As Byte
'=============================
Dim p1 As Integer
Dim GetSym As String
Dim Nhan_Enter As Boolean
Dim Str_Command  As String      ' Chuoi Cau lenh vua soan thao
Dim Remember_Pos As Integer
Dim pTab As Long
Dim Remember_Sub() As String
Dim SubChar As String
Dim Lenh_Sub As String
Dim Lenh_Function As String
Private Sub Form_Resize()
On Error Resume Next
   If frmDoc.WindowState = vbMinimized Then Exit Sub
   '==================================
   If frmDoc.WindowState = vbNormal Then frmFile.Move 0, 0, frmDoc.Left, frmProperties.Top
   ' Dinh kich thuot SStab va RtfSource va WebBrowser
   If frmDoc.ScaleMode = 3 Then frmDoc.ScaleMode = 1
   SSTab.Move 0, 0, frmDoc.Width - 20, frmDoc.Height - 370
   rtfSource.Move 0, 0, SSTab.Width - 20, SSTab.Height - 370
   If Flag = True Then WebBrowser.Move 0, 0, SSTab.Width - 20, SSTab.Height - 370
   frmDoc.ScaleMode = 3
End Sub

' Dinh toa do cua con tro tai Cot thu ?
Function toadoCot() As Integer
Dim i As Integer
   toadoCot = -1
    For i = 0 To rtfSource.SelStart   'SelStart = vi tri htai cua con tro trong TextBox
        toadoCot = toadoCot + 1
        If Right(Left(rtfSource.Text, i), 1) = Chr$(13) Then toadoCot = -1
    Next i
End Function
' Dinh toa do cua con tro tai Hang thu ?
Function toadoHang() As Integer
Dim i As Integer
    toadoHang = 0
    For i = 0 To rtfSource.SelStart ' Sap Xep cat khoang trang trong chuoi
        If Right(Left(rtfSource.Text, i), 1) = Chr$(13) Then toadoHang = toadoHang + 1
    Next i
End Function
Private Sub ListObject_DblClick()
    If TrueFalse = True Then
        rtfSource.SelStart = InStrRev(rtfSource.Text, ".", rtfSource.SelStart)
        rtfSource.SelLength = Len(stringObject(rtfSource.SelStart))
        rtfSource.SelText = CutString(ListObject.Text)
        ListObject.Clear
        ListObject.Visible = False
        cmdListObject.Visible = False
        TrueFalse = False
    End If
End Sub

Private Sub ListObject_KeyDown(KeyCode As Integer, Shift As Integer)
    Select Case KeyCode
        Case 27
            ListObject.Clear
            ListObject.Visible = False
            cmdListObject.Visible = False
            TrueFalse = False
        Case 32, 13
            If TrueFalse = True Then
                If frmProperties.TestClick = True Then
                    rtfSource.SelStart = frmProperties.GlobalVitri
                    frmProperties.TestClick = False
                Else
                    rtfSource.SelStart = Position_Current
                End If
                rtfSource.SelLength = Len(stringObject(rtfSource.SelStart))
                rtfSource.SelText = CutString(ListObject.Text)
                ' Xoa tat ca cac Item trong ListObject va bien mat
                ListObject.Clear
                ListObject.Visible = False
                cmdListObject.Visible = False
                TrueFalse = False
            End If
    End Select
End Sub

Private Sub rtfSource_Change()
On Error Resume Next
   If Left(frmDoc.Caption, 7) = "NewPage" Then
      If IsNumeric(Mid(frmDoc.Caption, 9, 2)) = True Then ServerText(Mid(frmDoc.Caption, 9, 2)) = rtfSource.Text Else ServerText(Mid(frmDoc.Caption, 9, 1)) = rtfSource.Text
   Else
      ServerText(Public_Node - 2) = rtfSource.Text
   End If
End Sub
Private Sub rtfSource_Click()
    If ListObject.Visible = True And cmdListObject.Visible = True Then
        cmdListObject.Visible = False
        ListObject.Visible = False
    End If
End Sub
Private Sub rtfSource_GotFocus()
   fMainForm.comfont.Text = rtfSource.Font.Name
   fMainForm.comSize.Text = rtfSource.Font.Size
End Sub

Private Sub rtfSource_KeyDown(KeyCode As Integer, Shift As Integer)
Dim chuoi_String As String
Dim gan_Vitri As Long
On Error Resume Next
   Ftab = 0: Space_Tab = 0
   If frmOption.chkCol.value = 1 Then fMainForm.sbStatusBar.Panels(4).Text = "Ln : " & toadoCot & "      " & "Col : " & toadoHang Else fMainForm.sbStatusBar.Panels(4).Text = "No message" ' Ghi ra toa do col va Ln
   Select Case KeyCode
      Case vbKeyF5
        SendKeys "%{w}"
      Case vbKeyF4
        SendKeys "%{e}"
      Case 38, 40
         ToolTip.Visible = False
         If ListObject.Visible = True Then ListObject.SetFocus
         If frmOption.chkSyntax.value = 1 Then
            If KiemTraASP = True Then
               Str_Command = String_String(vbTab)
               Str_Command = Trim(Right(Str_Command, Len(Str_Command) - 1))
               Nhan_Enter = True
               Stop_Command = False
               BlockProgram
            End If
         End If
      Case 27
         If ListObject.Visible = True Or ToolTip.Visible = True Then
            cmdListObject.Visible = False
            ListObject.Visible = False
            ToolTip.Visible = False
         End If
      Case 13
         ' Neu co danh dau Kiem Syntax va trong <% command %>
         chuoi_String = String_String(vbLf)
         Call Tab_Space(chuoi_String)
         ToolTip.Visible = False
         If frmOption.chkSyntax.value = 1 Then
            If KiemTraASP = True Then
               Str_Command = Read_Command
               Nhan_Enter = True
               Stop_Command = False
               BlockProgram
            End If
         End If
        If ListObject.Visible = True Then
            If frmProperties.TestClick = True Then
                rtfSource.SelStart = frmProperties.GlobalVitri
                frmProperties.TestClick = False
            Else
                rtfSource.SelStart = Position_Current
            End If
            rtfSource.SelLength = Len(stringObject(rtfSource.SelStart))
            rtfSource.SelText = CutString(ListObject.Text)
            ' Xoa tat ca cac Item trong ListObject va bien mat
            ListObject.Clear
            ListObject.Visible = False
            cmdListObject.Visible = False
            TrueFalse = False
         Else
            rtfSource.SelText = " "
         End If
      Case 32, 187, 35, 37, 39, 36 ' phim Space, Enter,dau =,up,down,End,Left,Right,Home
         If frmOption.chkHTML.value = 1 Then Call Change_Color(HTML, frmOption.cmdHTML.BackColor)
         If frmOption.chkKey.value = 1 Then Call Change_Color(Command, frmOption.cmdKey.BackColor)
         If frmOption.chkAttri.value = 1 Then Call Change_Color(ValueHTML, frmOption.cmdAttri.BackColor)
         If TrueFalse = True And ListObject.Visible = True Then
            gan_Vitri = rtfSource.SelStart
            rtfSource.SelStart = InStrRev(rtfSource.Text, ".", gan_Vitri)
            rtfSource.SelLength = Len(stringObject(gan_Vitri))
            rtfSource.SelText = CutString(ListObject.Text)
            ' Xoa tat ca cac Item trong ListObject va bien mat
            ListObject.Clear
            ListObject.Visible = False
            cmdListObject.Visible = False
            TrueFalse = False
        End If
      Case 122
         If frmDoc.WindowState = 0 Then frmDoc.WindowState = 2 Else frmDoc.WindowState = 0
      Case 112       ' Nhan phim F1 dua Help
         If frmHelp.WindowState = 1 Then frmHelp.WindowState = 0
         BienHelp = Trim(XacDinhWord)
         frmHelp.Show
   End Select
   If KeyCode < 30 Or KeyCode > 122 Then
      If tempUndo < 20 Then
         tempUndo = tempUndo + 1
         Limit = tempUndo
         ReDim Preserve Undo(tempUndo)
         Undo(tempUndo) = rtfSource.Text
      Else
         Dim i As Byte
         For i = 1 To 19
            Undo(i) = Undo(i + 1)
         Next
         Undo(tempUndo) = rtfSource.Text
      End If
   End If
End Sub
Public Function String_String(kytu As String) As String
   begin_String = InStrRev(rtfSource.Text, kytu, rtfSource.SelStart)
   end_String = InStr(rtfSource.SelStart, rtfSource.Text, vbCr)
   If begin_String <> 0 And end_String <> 0 Then
      String_String = Mid(rtfSource.Text, begin_String, end_String - begin_String)
   ElseIf begin_String <> 0 And end_String = 0 Then
      String_String = Mid(rtfSource.Text, begin_String, Len(rtfSource.Text) - begin_String + 1)
   ElseIf begin_String = 0 And end_String <> 0 Then
       String_String = Left(rtfSource.Text, end_String)
   End If
End Function
Public Sub Tab_Space(chuoi_String As String)
Dim i As Integer
Dim kytu As String
For i = 1 To Len(chuoi_String)
   kytu = Mid(chuoi_String, i, 1)
      If Asc(kytu) = 9 Then Ftab = Ftab + 1
      If Asc(kytu) = 32 Then Space_Tab = Space_Tab + 1
      If Asc(kytu) > 47 Then Exit For
Next
End Sub
Public Sub Change_Color(word() As String, FontColor As String) ' Thu tuc xay ra khi co dau " " cach
Dim chuoi As String, ChuoiWord As String, bien As String
Dim Possition As Long
Dim i As Integer, temp As Long
   Possition = frmDoc.rtfSource.SelStart
   temp = Possition
   For i = temp To 1 Step -1
      chuoi = Mid(frmDoc.rtfSource.Text, i, 1)
      If (Asc(chuoi) < 97 Or Asc(chuoi) > 122) And (Asc(chuoi) < 47 Or Asc(chuoi) > 90) Then Exit For Else ChuoiWord = chuoi & ChuoiWord
   Next
   For i = LBound(word) To UBound(word)
      bien = word(i)
      If LCase(ChuoiWord) = LCase(Trim(bien)) Then  'khong phan biet Hoa - thuong
         With frmDoc.rtfSource
            .SelStart = temp - Len(ChuoiWord)  ' set selection start and
            .SelLength = Len(ChuoiWord)
            .SelColor = FontColor
            .SelLength = 0
            .SelStart = Possition
            .SelColor = vbBlack
         End With
      End If
   Next
End Sub
Private Sub rtfSource_KeyUp(KeyCode As Integer, Shift As Integer)
Dim i As Long, Object As String
Dim char As String
Dim Command_Data() As String
Dim Y As Byte
On Error Resume Next
    Select Case Val(KeyCode)
        Case 13
            For Y = 1 To Ftab
               rtfSource.SelText = Chr(9)
            Next
            For Y = 1 To Space_Tab
               rtfSource.SelText = Chr(32)
            Next
        Case 190   ' Dau .
            If frmOption.chkmember.value = 1 Then
               Position_Current = rtfSource.SelStart
               TrueFalse = True
               If KiemTraASP = True Then
                  Object = UCase(stringObject(rtfSource.SelStart - 1))
                   If Object = UCase("Application") Or Object = UCase("Server") Or Object = UCase("ObjectContext") Or Object = UCase("request") Or Object = UCase("response") Or Object = UCase("session") Or Object = UCase("ADODB") Or Object = UCase("IISSample") Or Object = UCase("MSWC") Or Object = UCase("CDONTS") Or Object = UCase("Scripting") Then InFoObject (Object)
                   SystemObject
                   For i = LBound(OfObject) To UBound(OfObject)
                       If OfObject(i) = Trim(stringObject(rtfSource.SelStart - 1)) Then InFoObject (ChuoiObject(i))
                   Next
               End If
               For i = 1 To ListObject.ListCount
                   ListObject.Height = i * 25
                   If ListObject.Height > 150 Then ListObject.Height = 150
               Next
               CanhLe_List
            End If
        Case 65 To 90   ' dau chon
            If TrueFalse = True Then ChonMucLuc
        Case 32   ' Dau Space
            If (KiemTraASP = True And frmOption.chkinfo.value = 1) Or (KiemTraScript = True And frmOption.chkinfo.value = 1) Then HienThiHelp
        Case 57     ' Nhan dau "(" roi thuc hien thu tuc
            If Shift = 1 And frmOption.chkinfo.value = 1 Then
               If KiemTraASP = True Then HienThiHelp
               Str_Command = SuperTrim(Read_Command)          ' Lay dong vua moi go
               SubChar = vbNullString
               For i = 1 To Len(Str_Command)
                   char = Mid(LTrim(Str_Command), i, 1)
                   If char = "(" Then Exit For Else SubChar = SubChar & char        ' Lay ten Sub
               Next
               Check_Sub
               Check_Function
               ' Hien thi thong tin ve Sub va Function len ToolTip
               If LBound(Remember_Sub) = vbNullString Then
                  For i = LBound(Remember_Sub) To UBound(Remember_Sub) ' Kiem tra xem da co Sub na`y chua ?
                      If UCase(Left(Remember_Sub(i), 3)) = "SUB" Then
                          If Trim(UCase(Mid(Remember_Sub(i), 4, InStr(1, Remember_Sub(i), "(") - 4))) = Trim(UCase(SubChar)) Then
                              ToolTip.Visible = True
                              ToolTip.Text = Right(Remember_Sub(i), Len(Remember_Sub(i)) - 4)
                              frmDoc.ScaleMode = 3
                              Call GetCaretPos(Vtri)
                              ToolTip.Move Vtri.X + 2, Vtri.Y - 20
                              frmDoc.ScaleMode = 1
                              ToolTip.Width = Tinh_Do_Dai_Tu(ToolTip.Text) - 100
                              CanhLe_Help
                              Erase Remember_Sub
                              Exit Sub
                          End If
                      ElseIf UCase(Left(Remember_Sub(i), 8)) = "FUNCTION" Then
                          If Trim(UCase(Mid(Remember_Sub(i), 9, InStr(1, Remember_Sub(i), "(") - 9))) = Trim(UCase(SubChar)) Then
                              ToolTip.Visible = True
                              ToolTip.Text = Right(Remember_Sub(i), Len(Remember_Sub(i)) - 9)
                              frmDoc.ScaleMode = 3
                              Call GetCaretPos(Vtri)
                              ToolTip.Move Vtri.X + 2, Vtri.Y - 20
                              frmDoc.ScaleMode = 1
                              ToolTip.Width = Tinh_Do_Dai_Tu(ToolTip.Text) - 100
                              CanhLe_Help
                              Erase Remember_Sub
                              Exit Sub
                          End If
                      End If
                  Next
               End If
            End If
         Case 48           ' Dau )
            If Shift = 1 Then If ToolTip.Visible = True Then ToolTip.Visible = False ' An ToolTip
    End Select
      If ToolTip.Visible = True Then '    Tien hanh hien thi Color tren Tooltip
         With ToolTip
            .SelStart = 0
            .SelLength = Len(.Text)
            .SelBold = False
         End With
         Str_Command = SuperTrim(Read_Command)          ' Lay dong vua moi go
         Command_Data = Split(Str_Command, ",")
         Bold_ToolTip (UBound(Command_Data))   ' Thu tuc hien thi
      End If
End Sub
Public Function stringObject(Vi_Tri As Long) As String
Dim ky_Tu As String
    Do While True
        ky_Tu = Mid(rtfSource.Text, Vi_Tri, 1)
        Vi_Tri = Vi_Tri - 1
        If Asc(ky_Tu) < 65 Then Exit Function
        stringObject = ky_Tu & stringObject
    Loop
End Function
Public Sub ChonMucLuc()
Dim a As String
Dim i As Long
    For i = 0 To ListObject.ListCount
        a = Left(ListObject.List(i), Len(stringObject(rtfSource.SelStart)))
        If UCase(a) = UCase(stringObject(rtfSource.SelStart)) Then ListObject.ListIndex = i
    Next
End Sub
Public Function CutString(a As String) As String
Dim i As Integer, s As String
Dim CutChuoi As String
    For i = 1 To Len(a)
        s = Mid$(a, i, 1)
        CutChuoi = CutChuoi & s
        If s = Chr(32) Then Exit For
    Next
     CutString = Trim(CutChuoi)
End Function
Private Sub rtfSource_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
' Dung de dua ra ToolTip va cac thuoc tinh
   If Button = 2 Then ' nhan phim chuot phai
      PopupMenu fMainForm.MnuTat
   End If
End Sub
' Chuyen Doi qua lai giua rtfSource va WebBrowser
Private Sub SSTab_Click(PreviousTab As Integer)
   frmDoc.ScaleMode = 1
   Select Case PreviousTab
      Case 1
         Flag = False
         '===============================
         fMainForm.mnuHTML.Visible = True
         fMainForm.tbToolBar.Buttons.Item(40).Enabled = True
         fMainForm.tbToolBar.Buttons.Item(36).Enabled = True
         fMainForm.comFind.Enabled = True
         fMainForm.comfont.Enabled = True
         fMainForm.comSize.Enabled = True
         fMainForm.mnuProcudure.Enabled = True
         fMainForm.mnuBold.Enabled = True
         fMainForm.mnuItalic.Enabled = True
         fMainForm.mnuUnderline.Enabled = True
         fMainForm.mnusuper.Enabled = True
         fMainForm.mnuSub.Enabled = True
         fMainForm.mnuSubs.Enabled = True
         fMainForm.mnuEditDelete.Enabled = True
         fMainForm.mnuEditPaste.Enabled = True
         fMainForm.mnuEditCopy.Enabled = True
         fMainForm.mnuEditCut.Enabled = True
         frmProperties.Enabled = True
         '===============================
         frmDoc.SetFocus
         fMainForm.sbStatusBar.Panels(1).Text = " Editor web "
      Case 0
         Flag = True
         '================================
         fMainForm.mnuHTML.Visible = False
         fMainForm.tbToolBar.Buttons.Item(40).Enabled = False
         fMainForm.tbToolBar.Buttons.Item(36).Enabled = False
         fMainForm.comFind.Enabled = False
         fMainForm.comfont.Enabled = False
         fMainForm.comSize.Enabled = False
         fMainForm.mnuProcudure.Enabled = False
         fMainForm.mnuBold.Enabled = False
         fMainForm.mnuItalic.Enabled = False
         fMainForm.mnuUnderline.Enabled = False
         fMainForm.mnusuper.Enabled = False
         fMainForm.mnuSub.Enabled = False
         fMainForm.mnuSubs.Enabled = False
         fMainForm.mnuEditDelete.Enabled = False
         fMainForm.mnuEditPaste.Enabled = False
         fMainForm.mnuEditCopy.Enabled = False
         fMainForm.mnuEditCut.Enabled = False
         frmProperties.Enabled = False
         '================================
         WebBrowser.Move 50, 50, SSTab.Width - 20, SSTab.Height - 370
         If Left(frmDoc.Caption, 7) = "NewPage" Then
            If Right(frmDoc.Caption, 3) <> "asp" Then
               rtfSource.SaveFile App.path & "\htmlAsp\" & frmDoc.Caption, rtfText  ' Save File vao dia cung
               'WebBrowser.Refresh
               WebBrowser.Navigate App.path & "\htmlAsp\" & frmDoc.Caption
            Else
               Dim sFile As String
               With dlgCommonDialog
                  .DialogTitle = "Save"
                  .Filter = "Web File(*.asp)|*.asp"
                  .ShowSave
                  .CancelError = False
                  If Len(.FileName) = 0 Then Exit Sub
                  sFile = .FileName
                  .FileName = ""
                  frmDoc.rtfSource.SaveFile sFile, rtfText
                  frmDoc.Caption = sFile
                  If Public_Node = 0 Then Public_Node = 3
                  frmFile.TreeView1.Nodes(Public_Node).Text = sFile
                '  WebBrowser.Refresh
                  WebBrowser.Navigate Server_Path & "/" & Mid(frmDoc.Caption, InStrRev(frmDoc.Caption, "\") + 1, Len(frmDoc.Caption))
               End With
            End If
         Else
            If Right(frmDoc.Caption, 3) <> "asp" Then
               Dim path As String
               path = App.path & "\htmlAsp\" & "NewPage_" & Public_Node - 2 & Right(frmDoc.Caption, Len(frmDoc.Caption) - InStrRev(frmDoc.Caption, ".") + 1)
               rtfSource.SaveFile path, rtfText   ' Save File vao dia cung
               'WebBrowser.Refresh
               WebBrowser.Navigate path
            Else
               'WebBrowser.Refresh
               WebBrowser.Navigate Server_Path & "/" & Mid(frmDoc.Caption, InStrRev(frmDoc.Caption, "\") + 1, Len(frmDoc.Caption))
            End If
         End If
   End Select
End Sub
Public Sub InFoObject(Object As String)
Dim InFoVar As Byte
Dim DoDaiOject As Integer, i As Byte
Dim DoDaiPer As Integer
Dim chuoiTemp As String
Dim ThuocTinh As String
Dim Filenum As Integer
Dim path As String, MangString() As String, bien As String
Dim T As Byte
    For T = LBound(Line_Object) To UBound(Line_Object)
        MangString = Split(Line_Object(T), ",")
        If UCase(Object) = UCase(MangString(0)) Then
            For i = 1 To UBound(MangString)
               InFoVar = Left(MangString(i), 1)
               cmdListObject.Visible = True
               ListObject.Visible = True
               Select Case Val(InFoVar)
                   Case 1: ThuocTinh = "Property"
                   Case 2: ThuocTinh = "Collection"
                   Case 3: ThuocTinh = "Method"
                   Case 4: ThuocTinh = "Even"
                   Case 5: ThuocTinh = "Component"
               End Select
                chuoiTemp = Right((MangString(i)), Len(MangString(i)) - 1)
                DoDaiOject = Tinh_Do_Dai_Tu(chuoiTemp)
                DoDaiPer = Tinh_Do_Dai_Tu(ThuocTinh)
                cmdListObject.Caption = Object
                If UCase(cmdListObject.Caption) = UCase("sessionCDONTS") Then cmdListObject.Caption = "Session"
                ListObject.AddItem chuoiTemp & Space((3640 - DoDaiOject - DoDaiPer) / 60) & ThuocTinh
            Next
            frmDoc.ScaleMode = 3            ' Chuyen sang che do ScaleMode =3
            Call GetCaretPos(Vtri)
            cmdListObject.Move Vtri.X - 2, Vtri.Y + 20
            ListObject.Move Vtri.X, Vtri.Y + cmdListObject.Height + 20
            ListObject.ListIndex = 0
            Exit For
        End If
    Next
End Sub
Public Function Tinh_Do_Dai_Tu(ChuoiWord As String) As Integer
Dim i As Integer, word As String
    For i = 1 To Len(ChuoiWord)
        word = Mid(ChuoiWord, i, 1)
        Tinh_Do_Dai_Tu = Tinh_Do_Dai_Tu + frmFile.TextWidth(word)
    Next
End Function

Public Sub SystemObject()
Dim ArrayWord() As String, i As Long, j As Integer
Dim a() As String
Dim b() As String
    ArrayWord = Split(rtfSource.Text, Chr(32))
    For i = LBound(ArrayWord) To UBound(ArrayWord)
        If LCase(Trim(ArrayWord(i))) = LCase("Set") Or LCase(Right(ArrayWord(i), 3)) = LCase("Set") Then
            ReDim Preserve OfObject(j)
            ReDim Preserve ChuoiObject(j)
            OfObject(j) = ArrayWord(i + 1)
            a = Split(ArrayWord(i + 3), """", , vbTextCompare)
            b = Split(a(1), ".", , vbTextCompare)
            ChuoiObject(j) = b(1)
            If UCase(ChuoiObject(j)) = "SESSION" Then ChuoiObject(j) = "sessionCDONTS"
            j = j + 1
        End If
    Next
End Sub

Public Function XacDinhWord() As String
Dim ViTri As Long, j As Long
Dim kytu As String, i As Long
   ViTri = rtfSource.SelStart
      For i = ViTri To 1 Step -1
         kytu = Mid(rtfSource.Text, i, 1)
         If Asc(kytu) < 65 Then Exit For
      Next
      For j = i + 1 To Len(rtfSource.Text)
         kytu = Mid(rtfSource.Text, j, 1)
         If Asc(kytu) < 65 Then Exit For
         XacDinhWord = XacDinhWord & kytu
      Next
End Function

Public Sub CanhLe_List()
    If ListObject.Top + ListObject.Height > frmDoc.ScaleHeight And ListObject.Left + ListObject.Width > frmDoc.ScaleWidth Then
        Call GetCaretPos(Vtri)
        cmdListObject.Move frmDoc.ScaleWidth - cmdListObject.Width, Vtri.Y - ListObject.Height - cmdListObject.Height + 5
        ListObject.Move frmDoc.ScaleWidth - ListObject.Width, Vtri.Y - ListObject.Height + 5
    End If
    If ListObject.Left + ListObject.Width > frmDoc.ScaleWidth Then
        cmdListObject.Left = frmDoc.ScaleWidth - cmdListObject.Width
        ListObject.Left = frmDoc.ScaleWidth - ListObject.Width
    End If
    If ListObject.Top + ListObject.Height > frmDoc.ScaleHeight Then
        Call GetCaretPos(Vtri)
        cmdListObject.Move Vtri.X - 6, Vtri.Y - ListObject.Height - cmdListObject.Height + 5
        ListObject.Move Vtri.X - 4, Vtri.Y - ListObject.Height + 5
    End If
End Sub

Private Sub HienThiHelp()
Dim path As String, bien As String, tachChuoi() As String
Dim Filenum As Integer, i As Long, ky_Tu As String, Vi_Tri_Nho As Long
Dim Object As String
    Filenum = FreeFile
    path = App.path & "\HelpObject.res"
    ' Xoa bo nhung dau Space
    For i = rtfSource.SelStart To 1 Step -1
        ky_Tu = Mid(rtfSource.Text, i, 1)
        If Asc(ky_Tu) < 65 Then
        Else
            Vi_Tri_Nho = i
            Exit For
            End If
     Next
     Object = stringObject(Vi_Tri_Nho)
     Open path For Input As #Filenum
     Do Until EOF(Filenum)
        Line Input #Filenum, bien
        tachChuoi = Split(bien, ":", , vbTextCompare)
        If UCase(Object) = UCase(tachChuoi(0)) Then
            ToolTip.Text = tachChuoi(1)
            If Trim(ToolTip.Text) <> vbNullString Then ToolTip.Visible = True
            frmDoc.ScaleMode = 3
            Call GetCaretPos(Vtri)
            ToolTip.Move Vtri.X + 2, Vtri.Y - 20
            frmDoc.ScaleMode = 1
            ToolTip.Width = Tinh_Do_Dai_Tu(tachChuoi(1))
            CanhLe_Help
            Exit Sub
        End If
    Loop
End Sub
Private Sub CanhLe_Help()
   If ToolTip.Left + ToolTip.Width > frmDoc.ScaleWidth Then ToolTip.Left = frmDoc.ScaleWidth - ToolTip.Width - 100
   If ToolTip.Top < 0 Then ToolTip.Top = ToolTip.Height
End Sub
Public Sub Bold_ToolTip(Number As Byte)
Dim ToolTip_Data() As String
Dim temp As Long
Dim Search  As Long, i As Byte
    ToolTip_Data = Split(ToolTip.Text, ",")
    If Number = 0 Then
        temp = InStr(1, ToolTip.Text, "(")
        If temp <> 0 Then
            ToolTip.SelStart = temp
            ToolTip.SelLength = Len(ToolTip_Data(Number)) - InStr(1, ToolTip.Text, "(")
        Else
            ToolTip.SelStart = 0
            ToolTip.SelLength = InStr(1, ToolTip.Text, "(") - 1
        End If
    Else
        Search = InStr(1, ToolTip.Text, ",")
        Do While Search <> 0
            i = i + 1
            If i = Number Then
                ToolTip.SelStart = Search
                ToolTip.SelLength = Len(ToolTip_Data(Number))
                Exit Do
            End If
            Search = InStr(Search + Len(ToolTip_Data(i)), ToolTip.Text, ",")
        Loop
    End If
    ToolTip.SelBold = True              ' To dam Parament tuong ung
    ToolTip.SelStart = Search
    ToolTip.Width = Tinh_Do_Dai_Tu(Trim(ToolTip.Text))
End Sub
Public Sub Check_Sub()      'Kiem tra va tim kiem tat ca cac Sub tren van ban hien thoi
Dim i As Integer
Dim Index_Asp As Long
Dim Search_Sub As Long
Dim char_Sub  As String
    Index_Asp = InStr(1, rtfSource.Text, "<%")     ' Phai nam trong 2 dau <%
    Search_Sub = InStr(Index_Asp, rtfSource.Text, "SUB", vbTextCompare)
    Do While Search_Sub <> 0
        Lenh_Sub = ""
        char_Sub = Mid(rtfSource.Text, Search_Sub, 1)
        Do While char_Sub <> ""
            If char_Sub <> vbCr Then            ' Gap ki tu xuong dong
                Lenh_Sub = Lenh_Sub & char_Sub
                Search_Sub = Search_Sub + 1
                char_Sub = Mid(rtfSource.Text, Search_Sub, 1)
            Else
                Str_Command = Lenh_Sub
                Nhan_Enter = True                   ' Khoi tao lai de tim GetSym
                CheckSub_Remember           ' Bien dich cac Sub xem co hop le ko ?
                Exit Do
            End If
        Loop
        Search_Sub = InStr(Search_Sub, rtfSource.Text, "SUB", vbTextCompare)
    Loop
End Sub
Public Sub Check_Function()
Dim i As Integer
Dim Index_Asp As Long
Dim Search_Function As Long
Dim char_Function As String
    Index_Asp = InStr(1, rtfSource.Text, "<%")     ' Phai nam trong 2 dau <%
    Search_Function = InStr(Index_Asp, rtfSource.Text, "FUNCTION", vbTextCompare)
    Do While Search_Function <> 0
        Lenh_Function = ""
        char_Function = Mid(rtfSource.Text, Search_Function, 1)
        Do While char_Function <> ""
            If char_Function <> vbCr Then            ' Gap ki tu xuong dong
                Lenh_Function = Lenh_Function & char_Function
                Search_Function = Search_Function + 1
                char_Function = Mid(rtfSource.Text, Search_Function, 1)
            Else
                Str_Command = Lenh_Function
                Nhan_Enter = True                   ' Khoi tao lai de tim GetSym
                CheckSub_Remember           ' Bien dich cac Sub xem co hop le ko ?
                Exit Do
            End If
        Loop
        Search_Function = InStr(Search_Function, rtfSource.Text, "FUNCTION", vbTextCompare)
    Loop
End Sub
Public Sub CheckSub_Remember()          ' Bien dich cac Sub xem co hop le ko ?
Dim i As Byte                           ' Neu co thi` nho vao Array
Dim ToKen_Remember As String
Static Parament As Byte
    If UCase(Trim(Str_Command)) <> "SUB" Or UCase(Trim(Str_Command)) <> "FUNCTION" Then  ' Kiem tra xem co phai la` chuoi rong ko ?
        GetSym = ToKen_GetSym
        ToKen_Remember = GetSym
        If UCase(GetSym) = "SUB" Or UCase(GetSym) = "FUNCTION" Then
            GetSym = ToKen_GetSym
            If KiemTra_Ident(GetSym) = True Then
                GetSym = ToKen_GetSym
                If GetSym = "(" Then
                    List_Parameter
                    If GetSym = ")" Then
                        GetSym = ToKen_GetSym
                        If GetSym = "" Then
                            ReDim Preserve Remember_Sub(Parament)   ' Nho vao Array ma ko bo cai cu
                            If UCase(ToKen_Remember) = "SUB" Then Remember_Sub(Parament) = Lenh_Sub Else Remember_Sub(Parament) = Lenh_Function
                            Parament = Parament + 1
                        Else
                            TypeDeclarations                        ' Kiem tra kieu khai bao
                            ReDim Preserve Remember_Sub(Parament)   ' Nho vao Array ma ko bo cai cu
                            Remember_Sub(Parament) = Lenh_Function
                            Parament = Parament + 1
                        End If
                    End If
                End If
            End If
        End If
    End If
End Sub

Public Sub BlockProgram()
Dim Forget_GetSym As String
    GetSym = Trim(ToKen_GetSym)
    Forget_GetSym = UCase(GetSym)
    Select Case UCase(GetSym)
        Case Is = "IF", "ELSEIF"
            Call IfDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "FOR"
            GetSym = ToKen_GetSym
            If UCase(GetSym) = "EACH" Then Call ForEarchDeclaration Else Call ForDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "WHILE"
            Call Do_Loop_While_Declaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "CASE"
            Call CaseDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "DO"
            GetSym = ToKen_GetSym
            If UCase(GetSym) = "WHILE" Or UCase(GetSym) = "UNTIL" Then Call Do_Loop_While_Declaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "LOOP"
            GetSym = ToKen_GetSym
            If UCase(GetSym) = "WHILE" Or UCase(GetSym) = "UNTIL" Then Call Do_Loop_While_Declaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "SELECT"
            Call SeclectDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "CONST"
            Call ConstDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "DIM"
            Call DimDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "REDIM"
            Call ReDimDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "CALL"
            Call CallDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "SET"
            Call SetDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "SUB"
            Call SubDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "FUNCTION"
            Call FunctionDeclaration
            If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand (Forget_GetSym)
        Case Is = "PUBLIC"
            GetSym = ToKen_GetSym
            If UCase(GetSym) = "SUB" Then
                Call SubDeclaration
                If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand ("PUBLIC SUB")
            ElseIf UCase(GetSym) = "FUNCTION" Then
                Call FunctionDeclaration
                If Stop_Command = False And frmOption.chkComplete.value = 1 Then CompleteCommand ("PUBLIC FUNCTION")
            End If
    End Select
End Sub
Public Sub ConstDeclaration()
    GetSym = ToKen_GetSym
    If KiemTra_Ident(GetSym) = True Then
        GetSym = ToKen_GetSym
        If GetSym = "=" Then
            GetSym = ToKen_GetSym
                If IsNumeric(GetSym) = True Then
                    GetSym = ToKen_GetSym
                    If GetSym = "," Then  ' Neu khai bao tiep const thi dung dau ","
                        ConstDeclaration
                    ElseIf GetSym = "" Then
                         Exit Sub
                    Else: ErrorProgram (4)
                    End If
                Else
                    ErrorProgram (15)
                End If
        Else
            ErrorProgram (3)
        End If
    Else
        ErrorProgram (2)
    End If
End Sub
Public Sub DimDeclaration()
    GetSym = ToKen_GetSym
    If KiemTra_Ident(GetSym) = False Then
        ErrorProgram (2)
    Else
        GetSym = ToKen_GetSym
            If GetSym = "(" Then
                GetSym = ToKen_GetSym
                    If GetSym = ")" Then
                    Else
                        ErrorProgram (6)
                    End If
            End If
        TypeDeclarations
        If GetSym = "," Then   ' Neu khai bao tiep const thi dung dau ","
            DimDeclaration
        ElseIf GetSym <> "" Then
            ErrorProgram (4)
        End If
    End If
End Sub
Public Sub ReDimDeclaration()
    GetSym = ToKen_GetSym
    If KiemTra_Ident(GetSym) = False Then
        ErrorProgram (2)
    Else
        GetSym = ToKen_GetSym
        If GetSym = "(" Then
            GetSym = ToKen_GetSym
            Expression
            Do While GetSym = ","      ' Neu khai bao tiep const thi dung dau ","
                GetSym = ToKen_GetSym
                Expression
            Loop
            If GetSym <> ")" Then ErrorProgram (14)
                GetSym = ToKen_GetSym
            If GetSym <> "" Then ErrorProgram (4)
        Else
            ErrorProgram (16)
        End If
    End If
End Sub
Public Sub TypeDeclarations()
Dim Token_Data() As String, i As Byte
    GetSym = ToKen_GetSym
    If UCase(GetSym) = "AS" Then
        GetSym = ToKen_GetSym
        Token_Data = Split(TypeData, ",", , vbTextCompare)
        For i = LBound(Token_Data) To UBound(Token_Data)
            If Token_Data(i) = UCase(GetSym) Then Exit For
        Next
        If i = 9 Then ErrorProgram (13) ' SOLUONG
        GetSym = ToKen_GetSym
    End If
End Sub
Public Sub List_Parameter()
GetSym = ToKen_GetSym
    If GetSym = ")" Then Exit Sub
    If KiemTra_Ident(GetSym) = False Then
        ErrorProgram (2)
    Else
        TypeDeclarations
        If GetSym = "," Then List_Parameter   ' Neu khai bao tiep thi dung dau ","
    End If
End Sub
Public Sub SubDeclaration()
    GetSym = ToKen_GetSym
    If KiemTra_Ident(GetSym) = False Then
        ErrorProgram (2)
    Else
        GetSym = ToKen_GetSym
        If GetSym = "(" Then
            List_Parameter
            If GetSym <> ")" Then ErrorProgram (14)
                GetSym = ToKen_GetSym
                If GetSym <> "" Then ErrorProgram (4)
        ElseIf GetSym = "" Then
            rtfSource.SelText = "()"
            Str_Command = Str_Command & "()"
        Else
            ErrorProgram (2)
        End If
    End If
End Sub
Public Sub FunctionDeclaration()
    GetSym = ToKen_GetSym
    If KiemTra_Ident(GetSym) = False Then
        ErrorProgram (2)
    Else
        GetSym = ToKen_GetSym
        If GetSym = "(" Then
            List_Parameter
            If GetSym = ")" Then
                TypeDeclarations
                If GetSym <> "" Then ErrorProgram (4)
            Else: ErrorProgram (14)
            End If
        Else
            rtfSource.SelText = "()"
            Str_Command = Str_Command & "()"
        End If
    End If
End Sub
Public Function ToKen_GetSym() As String
Dim ToKen_Symbol() As String  ' Mang chua Chuoi ToKen
Dim State As Byte               ' Trang thai
Dim char As String              ' Doc 1 ky tu hien thoi tai p1
Dim Next_Char As String         ' Doc truoc a ky tu
Static p1 As Integer            ' vi tri p1 can doc
Dim i As Integer
If Nhan_Enter = True Then p1 = 0
ToKen_Symbol = Split(Symbol, ",", , vbTextCompare)
Do While True
Nhay:
    Select Case State
        Case 0
            p1 = p1 + 1
            char = Mid(Str_Command, p1, 1)
            Next_Char = Mid(Str_Command, p1 + 1, 1)
            If char <> "" Then Nhan_Enter = False
            ToKen_GetSym = ToKen_GetSym & char
            ToKen_GetSym = Trim(ToKen_GetSym)
            For i = LBound(ToKen_Symbol) To UBound(ToKen_Symbol)
                If Next_Char = ToKen_Symbol(i) Or Next_Char = "," Then
                    If ToKen_GetSym <> "<" And ToKen_GetSym <> ">" Then Exit Do
                End If
            Next
            If char = " " Or char = "" Then
                If ToKen_GetSym = " " Or ToKen_GetSym = "" Then GoTo Nhay Else Exit Do
            End If
            Select Case char
                Case "<": State = 1
                Case "=": ToKen_GetSym = "="
                            Exit Do
                Case ">": State = 2
                Case "+": ToKen_GetSym = "+"
                            Exit Do
                Case "-": ToKen_GetSym = "-"
                            Exit Do
                Case "*": ToKen_GetSym = "*"
                            Exit Do
                Case "/": ToKen_GetSym = "/"
                            Exit Do
                Case ")": ToKen_GetSym = ")"
                            Exit Do
                Case "(": ToKen_GetSym = "("
                            Exit Do
                Case ",": ToKen_GetSym = ","
                            Exit Do
                Case "^": ToKen_GetSym = "^"
                            Exit Do
                Case "\": ToKen_GetSym = "\"
                            Exit Do
                Case "&": ToKen_GetSym = "&"
                            Exit Do
            End Select
        Case 1
            p1 = p1 + 1
            char = Mid(Str_Command, p1, 1)
            If char = "=" Then
                ToKen_GetSym = "<="
                Exit Do
                ElseIf char = ">" Then
                    ToKen_GetSym = "<>"
                    Exit Do
                Else
                     char = "<"
                     p1 = p1 - 1
                     Exit Do
            End If
        Case 2
            p1 = p1 + 1
            char = Mid(Str_Command, p1, 1)
            If char = "=" Then
                ToKen_GetSym = ">="
                Exit Do
            Else
                ToKen_GetSym = ">"
                p1 = p1 - 1
                Exit Do
            End If
    End Select
Loop
End Function
Public Function Read_Command() As String
Dim word As String, char As String
Dim i As Long
pTab = 0                                ' khoi tao lai so Tab
    For i = Val(rtfSource.SelStart) To 1 Step -1
        char = Mid(rtfSource.Text, i, 1)
        If char = vbLf Then Exit For ' Neu gap ki tu dau do`ng ben trai
        word = char & word           ' Ghep word
    Next
    Remember_Pos = Len(word)
    For i = 1 To Len(word)
        char = Mid(word, i, 1)
        If char = vbTab Then pTab = pTab + 1 Else Exit For
    Next
    Read_Command = SuperTrim(word)
End Function
Public Sub Expression()
    If GetSym = "+" Or GetSym = "-" Then
        GetSym = ToKen_GetSym
        Term
    Else
        Term
    End If
    Do While GetSym = "+" Or GetSym = "-"
        GetSym = ToKen_GetSym
        Term
    Loop
End Sub
Public Sub Term()
    Factor
    Do While GetSym = "*" Or GetSym = "/" Or GetSym = "^" Or UCase(GetSym) = "MOD" Or GetSym = "\" Or GetSym = "&"
        GetSym = ToKen_GetSym
        Factor
    Loop
End Sub
Public Sub Factor()
    If KiemTra_Ident(GetSym) = True Then
        GetSym = ToKen_GetSym
    ElseIf IsNumeric(GetSym) = True Then
        GetSym = ToKen_GetSym
    ElseIf GetSym = "(" Then
        GetSym = ToKen_GetSym
        Expression
            If GetSym = ")" Then
                GetSym = ToKen_GetSym
            Else
                ErrorProgram (6)
            End If
    Else
        ErrorProgram (5)
    End If
End Sub
Public Sub Condition()
Const Logic = "AND,OR,XOR,EQV,IMP"
Dim Logic_String() As String
Dim i As Byte
Logic_String = Split(Logic, ",", , vbTextCompare)
GetSym = ToKen_GetSym
    If UCase(GetSym) = "NOT" Then
        GetSym = ToKen_GetSym
        Expression
        For i = LBound(Logic_String) To UBound(Logic_String) ' Toan tu quan he
            If UCase(GetSym) = Logic_String(i) Then Condition
        Next
    Else
        Expression
        For i = LBound(Logic_String) To UBound(Logic_String) ' Toan tu quan he
            If UCase(GetSym) = Logic_String(i) Then Condition
        Next
    End If
    If GetSym = ">" Or GetSym = "<" Or GetSym = "=" Or GetSym = "<>" Or GetSym = ">=" Or GetSym = "<=" Then
        GetSym = ToKen_GetSym
        Expression
        For i = LBound(Logic_String) To UBound(Logic_String) ' Toan tu quan he
            If UCase(GetSym) = Logic_String(i) Then Condition
        Next
    End If
End Sub
Public Sub IfDeclaration()
    Condition
        If UCase(GetSym) = "THEN" Then
            GetSym = ToKen_GetSym
            If GetSym = "" Then Exit Sub Else Statement
                If UCase(GetSym) = "ELSE" Then
                    GetSym = ToKen_GetSym
                    Statement
                ElseIf GetSym <> "" Then ErrorProgram (4)
                End If
        Else
            ErrorProgram (7)
        End If
End Sub
Public Sub Statement()
    If KiemTra_Ident(GetSym) = True Then
        GetSym = ToKen_GetSym
        If GetSym = "=" Then
            GetSym = ToKen_GetSym
            Expression
        End If
    End If
End Sub
Public Sub SeclectDeclaration()
    GetSym = ToKen_GetSym
    If UCase(GetSym) = "CASE" Then
        Condition
        If GetSym <> "" Then ErrorProgram (4)
    Else
        ErrorProgram (8)
    End If
End Sub
Public Sub CaseDeclaration()
    Condition
    If GetSym <> "" Then ErrorProgram (4)
End Sub
Public Sub CallDeclaration()
    GetSym = ToKen_GetSym
    If KiemTra_Ident(GetSym) = False Then ErrorProgram (2)
    GetSym = ToKen_GetSym
        If GetSym <> "" Then ErrorProgram (4)
End Sub
Public Sub ForDeclaration()
    If KiemTra_Ident(GetSym) = True Then
        GetSym = ToKen_GetSym
        If GetSym = "=" Then
            GetSym = ToKen_GetSym
            Expression
                If UCase(GetSym) = "TO" Then
                    Condition
                    If UCase(GetSym) = "STEP" Then
                        GetSym = ToKen_GetSym
                        Expression
                            If GetSym <> "" Then ErrorProgram (4)
                    ElseIf GetSym <> "" Then
                        ErrorProgram (4)
                    End If
                Else
                    ErrorProgram (11)
                End If
        Else
            ErrorProgram (10)
        End If
    Else
        ErrorProgram (9)
    End If
End Sub

Public Sub ForEarchDeclaration()
    GetSym = ToKen_GetSym
    If KiemTra_Ident(GetSym) = True Then
        GetSym = ToKen_GetSym
        If UCase(GetSym) = "IN" Then
            GetSym = ToKen_GetSym
            If KiemTra_Ident(GetSym) = False Then ErrorProgram (9)
            GetSym = ToKen_GetSym
                If GetSym <> "" Then ErrorProgram (4)
        Else
            ErrorProgram (12)
        End If
    Else
        ErrorProgram (9)
    End If
End Sub

Public Sub Do_Loop_While_Declaration()
    Condition
    If GetSym <> "" Then ErrorProgram (4)
End Sub
Public Sub SetDeclaration()
    GetSym = ToKen_GetSym
    If KiemTra_Ident(GetSym) = True Then
        GetSym = ToKen_GetSym
        If GetSym = "=" Then
        Else
            ErrorProgram (3)
        End If
    Else
        ErrorProgram (9)
    End If
End Sub

Public Sub CompleteCommand(Command As String)
Dim ToKenWord() As String
Dim Forget_Position As Long
Dim i As Byte
    rtfSource.SelText = vbCrLf               ' Che`n them 1 do`ng tro^'ng
    ToKenWord = Split(word, ",", , vbTextCompare)
    Call Change_Command_Asp(ToKenWord())
    Forget_Position = rtfSource.SelStart    ' Nho lai vi tri con nhay hien thoi
            For i = 1 To pTab
                rtfSource.SelText = vbTab   ' Thiet lap (nho) So Tab de canh le^`
            Next
    Select Case Command
        Case "FOR", "FOR EACH": rtfSource.SelText = "Next"
        Case "IF": rtfSource.SelText = "End If"
        Case "WHILE": rtfSource.SelText = "Wend"
        Case "DO": rtfSource.SelText = "Loop"
        Case "SELECT": rtfSource.SelText = "End Select"
        Case "PUBLIC SUB": rtfSource.SelText = "End Sub"
        Case "PUBLIC FUNCTION": rtfSource.SelText = "End Function"
        Case "SUB":  rtfSource.SelText = "End Sub"
        Case "FUNCTION": rtfSource.SelText = "End Function"
    End Select
    rtfSource.SelStart = Forget_Position     ' Thiet lap lai vi tri con nhay truoc do
        For i = 1 To pTab               ' So Tab tren do`ng trong
            rtfSource.SelText = vbTab
        Next
    SendKeys "{LEFT}"
End Sub

Public Sub Change_Command_Asp(ToKenWord() As String)
Dim Where As Long, z As Long, Begin As Long
Dim i As Integer
    Call Limit_Space
    z = rtfSource.SelStart
    Begin = z - Len(Str_Command) - 1
        For i = LBound(ToKenWord) To UBound(ToKenWord)
            Where = InStr(Begin, Left(rtfSource.Text, z), ToKenWord(i), vbTextCompare)   ' Find string in rtfSource.
            If Where <> 0 Then
                rtfSource.SelStart = Where - 1   ' set selection start and
                rtfSource.SelLength = Len(ToKenWord(i))  ' set selection length.
                rtfSource.SelText = Left(ToKenWord(i), 1) & LCase(Right(ToKenWord(i), Len(ToKenWord(i)) - 1))
            End If
        Next
    rtfSource.SelStart = z
End Sub
Public Sub Limit_Space()
Dim w As Long, z As Long, Begin As Long
z = rtfSource.SelStart
Begin = z - Remember_Pos - 1
w = InStr(Begin, Left(rtfSource.Text, z), Chr(32) & Chr(32), vbTextCompare)    ' Find string in rtfSource.
    Do Until w = 0
        rtfSource.SelStart = w - 1   ' set selection start and
        rtfSource.SelLength = 2 ' set selection length.
        rtfSource.SelText = Chr(32)
        w = InStr(Begin, Left(rtfSource.Text, z), Chr(32) & Chr(32), vbTextCompare)    ' Find string in text.
    Loop
    rtfSource.SelStart = z
End Sub

