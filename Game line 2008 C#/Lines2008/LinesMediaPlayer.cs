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
using System.Media;

namespace Lines2008
{
	class LinesMediaPlayer
	{
		public static SoundPlayer moveSound = new SoundPlayer("move.wav");
		public static SoundPlayer destroySound = new SoundPlayer("destroy.wav");
		public static SoundPlayer cantmoveSound = new SoundPlayer("cantmove.wav");
	}
}
