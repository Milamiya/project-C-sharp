using System;
using System.Drawing;
namespace CoCaNgua.DuLieu
{
	/// <summary>
	/// Summary description for DuLieuQuanCo.
	/// </summary>
	public class DuLieuQuanCo
	{
		
		#region Required variables
		private Point vtTrongChuong;	
		private int vtTrenBC;
		private int vtRQ;
		private int vtVD;
		private int Mau;
		public int Bac;
		private int State;
		public int Count;
		#endregion
		#region Properties
		public int TrangThaiQuanCo
		{
			get{ return State;}
			set{ State=value;}
		}
		public int SanSang
		{
			get{return 0;}
		}
		public int DangDi
		{
			get{return 1;}
		}
		public int VeDich
		{
			get{return 2;}
		}
		public int MauCo
		{
			get{ return Mau;}
			set{ Mau=value;}
		}
		
		public int ViTriTrenBanCo
		{
			get{ return vtTrenBC;}
			set{ vtTrenBC=value;}
		}
		public Point ViTriTrongChuong
		{
			get{ return vtTrongChuong;}
			set{ vtTrongChuong=value;}
		}
		public int ViTriRaQuan
		{
			get{ return vtRQ;}
			set{ vtRQ=value;}
		}
		public int ViTriVeDich
		{
			get{ return vtVD;}
			set{ vtVD=value;}
		}
		
		#endregion
		#region Contractors
		public DuLieuQuanCo()
		{
			TrangThaiQuanCo=SanSang;
			this.ViTriTrenBanCo=-1;
			Count=0;
			Bac=0;
		}
		/*public DuLieuQuanCo(DuLieu.DuLieuQuanCo dlqc)
		{
			
			TrangThaiQuanCo=dlqc.SanSang;
			ViTriRaQuan=dlqc.ViTriRaQuan;
			ViTriTrongChuong=dlqc.ViTriTrongChuong;
			ViTriVeDich=dlqc.ViTriVeDich;
			ViTriTrenBanCo=dlqc.ViTriTrenBanCo;
			MauCo=dlqc.MauCo;
			Bac=dlqc.Bac;
		}*/
		
		/*public DuLieuQuanCo(Point vtChuong,int vtRQ,int vtVD,int vtBC,int b,int m,int tt)
		{
			ViTriTrongChuong=vtChuong;
			ViTriRaQuan=vtRQ;
			ViTriVeDich=vtVD;
			ViTriTrenBanCo=vtBC;
			MauCo=m;
			Bac=b;
			TrangThaiQuanCo=tt;
		}*/
		#endregion
	}
}
