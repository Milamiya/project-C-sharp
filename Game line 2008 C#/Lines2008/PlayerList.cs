/**********************************/
/*                                */
/* Author: BUI VAN NGHIA          */
/* Email: katatunix@yahoo.com     */
/*                 [May, 2008]    */
/*                                */
/**********************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Lines2008
{
	[Serializable()]
	class PlayerList
	{
		public Player[] list;

		public PlayerList(Player[] list)
		{
			this.list = list;
		}
	}
}
