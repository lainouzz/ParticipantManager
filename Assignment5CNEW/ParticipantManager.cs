using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5CNEW
{
    internal class ParticipantManager
    {
        private List<Participant> participants;

        public ParticipantManager()
        {
            participants = new List<Participant>();
        }

        #region LIST METHODS

        public Participant GetParticipantAt(int index)
        {
            if (CheckIndex(index))
                return participants[index];

            return null;
        }

        public int Count
        {
            get { return participants.Count; }
        }

        public bool AddParticipant(string firstName, string lastName, Address adressInput)
        {
            Participant Participant = new Participant(firstName, lastName, adressInput);
            participants.Add(Participant);
            return true;
        }
        public bool AddParticipant(Participant ParticipantInp)
        {
            if (ParticipantInp == null)
                return false;

            participants.Add(ParticipantInp);
            return true;
        }

        public bool ChangeParticipant(Participant ParticipantInp, int index)
        {
            bool ok = true;
            if ((ParticipantInp != null) && CheckIndex(index))
                participants[index] = ParticipantInp;
            else
                ok = false;
            return ok;
        }

        private bool CheckIndex(int index)
        {
            return (index >= 0) && (index < participants.Count);
        }

        public bool DeleteParticipant(int index)
        {
            if (CheckIndex(index))
                participants.RemoveAt(index);
            else
                return false;
            return true;
        }

        public string[] GetParticipantInfo()
        {
            string[] stringInfo = new string[participants.Count];

            int i = 0;
            foreach (Participant ParticipantObject in participants)
            {
                stringInfo[i++] = ParticipantObject.ToString();
            }
            return stringInfo;
        }
        #endregion

    }
}
