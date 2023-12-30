using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CoCaNgua.DuLieu
{
	#region class Du lieu User
	public class DuLieuUser
	{
		#region Required variables
		private String Username;
		private int mauQC;
		private int soQC;
		public int SoQuanVeDich;
		public ArrayList arrQC=new ArrayList();
		public Point []arrVtDich=new Point[6];
		#endregion
		#region Properties
		public String UserName
		{
			get{ return Username;}
			set{ Username=value;}
		}
		public int MauQuanCo
		{
			get{ return mauQC;}
			set{ mauQC=value;}
		}
		public int SoQuanCo
		{
			get{ return soQC;}
			set{ soQC=value;}
		}
		
		#endregion
		#region Contractor
		
		
		public DuLieuUser()
		{
			SoQuanCo=4;
			SoQuanVeDich=0;
			for(int i=0;i<SoQuanCo;i++)
			{
				XuLy.QuanCo tam=new CoCaNgua.XuLy.QuanCo();
				arrQC.Add(tam);
			}
		}
		public DuLieuUser(int SoQCo)
		{
			SoQuanCo=SoQCo;
			SoQuanVeDich=0;
			for(int i=0;i<SoQuanCo;i++)
			{
				XuLy.QuanCo tam=new CoCaNgua.XuLy.QuanCo();
				arrQC.Add(tam);
			}
		}
		
		
		#endregion
	}
	#endregion
}
