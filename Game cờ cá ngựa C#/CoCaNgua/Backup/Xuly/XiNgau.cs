using System;
using System.Windows.Forms;

namespace CoCaNgua.XuLy
{
	/// <summary>
	/// Summary description for XiNgau.
	/// </summary>
	#region class XiNgau
	public class XiNgau
	{
		#region variable
		public int gt1,gt2;
		public int SoXN;
		#endregion
		#region Contractors
		public XiNgau()
		{
		
		}
		

		#endregion
		#region Function
		public void DoXingau(TheHien.TheHienXiNgau XN)
		{	
			SoXN=XN.SoXiNgauTheHien;
			Random rd=new Random(unchecked ((int)DateTime.Now.Millisecond));
			if(SoXN==1)
			{
				gt1=RandomGiatriXN(rd);
				XN.LoadImageXiNgau1(Application.StartupPath+"/HinhXiNgau/"+gt1+".jpg");
			}
			else
			{
				gt1=RandomGiatriXN(rd);
				XN.LoadImageXiNgau1(Application.StartupPath+"/HinhXiNgau/"+gt1+".jpg");
				gt2=RandomGiatriXN(rd);
				XN.LoadImageXiNgau2(Application.StartupPath+"/HinhXiNgau/"+gt2+".jpg");
			}
		}
		public int RandomGiatriXN(Random rd)
		{
			return (rd.Next(1,7));
		}
		#endregion
	}
	#endregion
}
