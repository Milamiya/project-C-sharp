Phan mem quan ly diem trung hoc pho thong
-----------------------------------------
1. Thong tin dang nhap
	Quyen BGH:
		User: admin
		Pass: hoangtung
	Quyen giao vien:
		User: hongnhung
		Pass: hongnhung
	Quyen giao vu:
		User: trungtoan
		Pass: toantrung

2. Cau hinh tap tin Connection.xml
	Thong so co ban:
		costatus = true : quyen Windows
		costatus = false: quyen SQL Server
		servname: ten server
		username: ten dang nhap he thong
		password: mat khau dang nhap he thong
		database: ten co so du lieu
	
	Vi du:
		<config>
		  <costatus>true</costatus>
		  <servname>HOANGTUNG</servname>
		  <username />
		  <password />
		  <database>QLHocSinhTHPT</database>
		</config>
		
		hoac:
		
		<config>
		  <costatus>true</costatus>
		  <servname>HOANGTUNG</servname>
		  <username>sa</username>
		  <password>sa</password>
		  <database>QLHocSinhTHPT</database>
		</config>

3. Thong tin tac gia:
	Nguyen Hoang Tung
	DH6TH2
	Khoa KTCNMT - Dai hoc An Giang.
	Email: hoangtung@inbox.com
-----------------------------------------