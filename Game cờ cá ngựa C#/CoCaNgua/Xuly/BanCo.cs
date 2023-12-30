using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
namespace CoCaNgua.XuLy
{
	
	public class BanCo
	{
		#region Variables
		public DuLieu.DuLieuBanCo DLBC;
		#endregion
		#region Property
		public DuLieu.DuLieuBanCo ThongTinBanCo
		{
			get{return DLBC;}
			set{DLBC=value;}
		}
		#endregion
		#region Contractors
		public BanCo()
		{
			DLBC=new CoCaNgua.DuLieu.DuLieuBanCo();
		}
		public BanCo(DuLieu.DuLieuBanCo DL)
		{
			DLBC=DL;
		}
		#endregion
		#region Function
				
		// huy ban co
		public void HuyBC( System.Windows.Forms.Panel panel)
		{
			int n= panel.Controls.Count;
			for(int i=n-1;i>=0;i--)
			{
				panel.Controls.RemoveAt(i);
			}
		}
		//tao cac quan tren bc
		public void TaoViTriQuan(Point vtCB,int i,DuLieu.DuLieuUser User,System.Windows.Forms.Panel panel)
		{
			Point p;
			int X=-24,Y=-24;
			if(i==1){Y=-Y;}
			if(i==2){X=-X;Y=-Y;}
			if(i==3){X=-X;}
			for(int j=0;j<User.SoQuanCo;j++)
			{
				if(j==0||j==2||j==4)
					p=new Point(vtCB.X+(j/2*X),vtCB.Y);
				else
					p=new Point(vtCB.X+((j-1)/2*X),vtCB.Y+Y);
				XuLy.QuanCo qc=(XuLy.QuanCo)User.arrQC[j];
				qc.QCDL.ViTriTrongChuong=p;
				qc.QCDL.ViTriTrenBanCo=-1;
				qc.QCDL.ViTriRaQuan=i*14;
				if(qc.QCDL.ViTriRaQuan==0)qc.QCDL.ViTriVeDich=55;
				else qc.QCDL.ViTriVeDich=qc.QCDL.ViTriRaQuan-1;
				qc.QCDL.MauCo=i+1;
				qc.QCTH.picQC.Location=new Point(qc.QCDL.ViTriTrongChuong.X,qc.QCDL.ViTriTrongChuong.Y);
				qc.QCTH.HienThi(i+1);
				panel.Controls.Add(qc.QCTH.picQC);
			}				
		}
		//sap bc
		public void SapBanCo( System.Windows.Forms.Panel panel,DuLieu.DuLieuTuyChon tc)
		{
			HuyBC(panel);
			CapNhatDuLieuBanco(tc);
			int n=DLBC.SoNguoichoi;
			for(int i=0;i<n;i++)
				TaoViTriQuan((Point)DLBC.arrVTChuong[i],i,(DuLieu.DuLieuUser)DLBC.arrUsers[i],panel);
		}
		//khoi tao lai du lieu
		public void CapNhatDuLieuBanco(DuLieu.DuLieuTuyChon tc)
		{
			DLBC.HinhBanCo=tc.HinhBanCo;
			DLBC.SoNguoichoi=tc.SoNguoiChoi;
		}
		
	
		public void XuLyBanCo()
		{
			int UserHienTai=this.DLBC.UserHienTai;
			DuLieu.DuLieuUser UserInfo=(DuLieu.DuLieuUser)this.DLBC.arrUsers[UserHienTai-1];
			for(int i=0;i<UserInfo.SoQuanCo;i++)
			{
				XuLy.QuanCo qc=(XuLy.QuanCo)UserInfo.arrQC[i];
				qc.QCTH.dlbc=this.DLBC;
				qc.QCTH.dlqc=qc.QCDL;
				qc.QCTH.User=UserInfo;
				qc.QCTH.TrangThaiClick=true;
				
			}
				
		}
		
		
		//Lay vitri tren ban co
		public Point LayVT(int vtTrenBC)
		{
			Point pTemp=new Point(224,220);
			//if(vtTrenBC==1) return pTemp;
			int dx=0,dy=0,d=29;
			if(vtTrenBC==55){dy=7*d;}
			if(vtTrenBC==13){dx=7*d;}
			if(vtTrenBC==27){dy=-7*d;}
			if(vtTrenBC==41){dx=-7*d;}
			
			if(vtTrenBC>=28&&vtTrenBC<=33)
			{	dx=-d;dy=-d*(35-vtTrenBC);	}
						
			if(vtTrenBC>=48&&vtTrenBC<=54)
			{	dx=-d;dy=d*(vtTrenBC-47);	}

			if(vtTrenBC>=0&&vtTrenBC<=5)
			{	dx=d;dy=d*(7-vtTrenBC);		}

			if(vtTrenBC>=21&&vtTrenBC<=26)
			{	dx=d;dy=-d*(vtTrenBC-19);	}

			if(vtTrenBC>=6&&vtTrenBC<=12)
			{	dy=d;dx=d*(vtTrenBC-5);		}

			if(vtTrenBC>=42&&vtTrenBC<=47)
			{	dy=d;dx=-d*(49-vtTrenBC);	}

			if(vtTrenBC>=34&&vtTrenBC<=40)
			{	dy=-d;dx=-d*(vtTrenBC-33);	}

			if(vtTrenBC>=14&&vtTrenBC<=20)
			{	dy=-d;dx=d*(21-vtTrenBC);	}
						
			pTemp.X+=dx;
			pTemp.Y+=dy;
			return pTemp;
		}
		
		#endregion
	}
}
