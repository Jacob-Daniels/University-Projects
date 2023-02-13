using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    public class Request : IComparable<Request>
    {
        // Attributes
        private int ID;
        private string startTime;
        private string endTime;

        public Request(int ID, string startTime, string endTime)
        {
            this.ID = ID;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        // Getters
        public int GetID() { return this.ID; }
        public string GetStartTime() { return this.startTime; }
        public string GetEndTime() { return this.endTime; }

        public int CompareTo(Request other)
        {
            // Compare by endTime
            return this.endTime.CompareTo(other.endTime);
        }

        public int GreedyCompareTo(Request other)
        {
            // Compare startTime to endTime
            return this.startTime.CompareTo(other.endTime);
        }

        #region ID & Start CompareTo
        public int IDCompareTo(Request other)
        {
            // Compare by ID
            return this.ID.CompareTo(other.ID);
        }
        public int StartCompareTo(Request other)
        {
            // Compare by start time
            return this.startTime.CompareTo(other.startTime);
        }
        #endregion
    }
}
