using System;

namespace CoCaNgua.DuLieu
{
	/// <summary>
	/// Summary description for TuyChon.
	/// </summary>
	public class DuLieuTuyChon
	{
		#region variables
		private int SoNC;
		public String []PlayerNames= new string[4];
		private String strFileBC;
		private int []gtRQ=new int[2];
		private int []gtVD=new int[2];
		private int SoXiNgau;
		public int []SoNguaQuan= new int[4];
		private int NguoiUT;
		#endregion
		#region properties
		public int gtRaQuan1
		{
			get{ return gtRQ[0];}
			set{ gtRQ[0]=value;}
		}
		public int gtRaQuan2
		{
			get{ return gtRQ[1];}
			set{ gtRQ[1]=value;}
		}
		public int gtVeDich1
		{
			get{ return gtVD[0];}
			set{ gtVD[0]=value;}
		}
		public int gtVeDich2
		{
			get{ return gtVD[1];}
			set{ gtVD[1]=value;}
		}
		public int NguoiUuTien
		{
			get{ return NguoiUT;}
			set{ NguoiUT=value;}
		}
		public int SoNguoiChoi
		{
			get{ return SoNC;}
			set{ SoNC=value;}
		}
		public string HinhBanCo
		{
			get{ return strFileBC;}
			set{strFileBC=value;}
		}
		public int SoHotXiNgau
		{
			get{ return SoXiNgau;}
			set{ SoXiNgau=value;}
		}
		#endregion
		public DuLieuTuyChon()
		{
			SoNguoiChoi=4;
			NguoiUuTien=1;
			HinhBanCo=System.Windows.Forms.Application.StartupPath+"\\HinhBanCo\\banco1.bmp";
			gtRaQuan1=gtVeDich1=1;
			gtRaQuan2=gtVeDich2=6;
			SoHotXiNgau=1;
			for(int i=0;i<SoNguoiChoi;i++)
			{
					SoNguaQuan[i]=4;
					PlayerNames[i]="User"+i;
			}

		}
		
		
	}
}
