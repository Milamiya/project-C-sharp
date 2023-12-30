using System;

namespace CoCaNgua.XuLy
{
	/// <summary>
	/// Summary description for QuanCo.
	/// </summary>
	public class QuanCo
	{
		public TheHien.TheHienQuanCo QCTH;
		public DuLieu.DuLieuQuanCo QCDL;
		
		public QuanCo()
		{
			QCTH=new CoCaNgua.TheHien.TheHienQuanCo();
			QCDL=new CoCaNgua.DuLieu.DuLieuQuanCo();
			
		}
		public void XuLyQuanCo(int MauHH)
		{
		}
	}
}
