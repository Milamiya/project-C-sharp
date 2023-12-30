using System;
using System.Collections.Generic;
using System.Text;
using AxAgentObjects;
using System.Collections;

namespace LichCongTac.Modules
{
    class AgentController
    {
        //Agent variable.
        private AgentObjects.IAgentCtlCharacterEx agentChar;

        //Name of the initialized character.
        private string characterName;

        //Balloon constants
        private const short BalloonOn = 1;
        private const short SizeToText = 2;
        private const short AutoHide = 4;
        private const short AutoPace = 8;

        public AgentController(AxAgentObjects.AxAgent agentHost,string character)
        {
            agentHost.Characters.Load(character, null);
            agentChar = agentHost.Characters[character];

            characterName = character;

            //You could put your own options in this menu, if desired.
            agentChar.AutoPopupMenu = false;

            //Set balloon style.
            agentChar.Balloon.Style = agentChar.Balloon.Style | BalloonOn;
            agentChar.Balloon.Style = agentChar.Balloon.Style | SizeToText;
            agentChar.Balloon.Style = agentChar.Balloon.Style | AutoHide;
        }

        public void Dispose()
        {
            if (agentChar.Visible)
            {
                agentChar.StopAll(null);
                agentChar.Hide(null);
            }
        }

        public void Show()
        {
            agentChar.Show(null);
        }

        public void Hide()
        {
            agentChar.Hide(null);
        }
        public void StopAll()
        {
            agentChar.StopAll(null);
        }
        public void Speak(string text)
        {
            try
            {
                agentChar.StopAll(null);
                agentChar.Speak(text, "");
            }
            catch 
            { }
        }
        public void Think(string text)
        {
            agentChar.StopAll(null);
            agentChar.Think(text);
        }
        public void Animate(string animation)
        {
            agentChar.StopAll(null);
            agentChar.Play(animation);
        }
        public void MoveTo(short x, short y)
        {
            agentChar.MoveTo(x, y, null);
        }
        public void GestureAt(short x, short y)
        {
            agentChar.GestureAt(x, y);
        }
        public Array GetAnimations()
        {
            ArrayList list = new ArrayList();
            foreach (string animation in agentChar.AnimationNames)
            {
                list.Add(animation);
            }
            return list.ToArray(typeof(string));
        }
        //Test if the agent is visible.
        //If the agent is not visible it will be shown.
        private bool IsAgentVisible()
        {
            if (agentChar.Visible)
            {
                return true;
            }
            else
            {
                agentChar.Show(null);
                return false;
            }
        }
    }
}
