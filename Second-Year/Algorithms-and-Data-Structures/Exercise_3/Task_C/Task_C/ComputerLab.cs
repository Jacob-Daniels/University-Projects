using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    public class ComputerLab
    {
        // Attributes
        private List<Request> requests;

        // Constructor
        public ComputerLab() { requests = new List<Request>(); }

        // Setter & getter
        public void AddRequest(Request newRequest) { requests.Add(newRequest); }
        public List<Request> GetRequests() { return requests; }

        // Methods
        public bool ContainsRequest(int checkID)
        {
            // Check whether list contains ID
            foreach (Request req in requests)
            {
                if (req.GetID() == checkID)
                {
                    return true;
                }
            }
            return false;
        }

        public int GreedySort()
        {
            // Sort requests into temporary list, according to their finishing times
            List<Request> tempList  = new List<Request>();
            int p = 0;
            while (p < requests.Count) { tempList.Add(requests[p]); p++; }
            QuickSort(ref tempList, 0, tempList.Count - 1);

            int maxPossibleRequests = 1;
            Request currentRequest = tempList[0];
            // Check possible requests
            int i = 1;
            while (i < tempList.Count)
            {
                // Compare current start time to previous end time
                if (tempList[i].GreedyCompareTo(currentRequest) == 1)
                {
                    currentRequest = tempList[i];
                    maxPossibleRequests++;
                }
                i++;
            }
            return maxPossibleRequests;
        }

        public void QuickSort(ref List<Request> sortList, int leftIndex, int rightIndex)
        {
            // Arrange the requests by end time using QuickSort Algorithm
            int i = leftIndex;
            int j = rightIndex;
            Request pivot = sortList[leftIndex];

            // Skip position if i is less than pivot
            while (sortList[i].CompareTo(pivot) == -1) { i++; }
            // Skip position if j is greater than pivot
            while (sortList[j].CompareTo(pivot) == 1) { j--; }

            // Swap values
            if (i <= j)
            {
                Request temp = sortList[i];
                sortList[i] = sortList[j];
                sortList[j] = temp;
                i++;
                j--;
            }

            // Recurse through until elements are sorted
            if (leftIndex < j) { QuickSort(ref sortList, leftIndex, j); }
            if (i < rightIndex) { QuickSort(ref sortList, i, rightIndex); }
        }

        #region Sort Methods (for buttons on forms gui)
        public void SortbyID(int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            Request pivot = requests[leftIndex];

            while (requests[i].IDCompareTo(pivot) == -1) { i++; }
            while (requests[j].IDCompareTo(pivot) == 1) { j--; }

            if (i <= j)
            {
                Request temp = requests[i];
                requests[i] = requests[j];
                requests[j] = temp;
                i++;
                j--;
            }

            if (leftIndex < j) { SortbyID(leftIndex, j); }
            if (i < rightIndex) { SortbyID(i, rightIndex); }
        }
        public void SortbyStartTime(int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            Request pivot = requests[leftIndex];

            while (requests[i].StartCompareTo(pivot) == -1) { i++; }
            while (requests[j].StartCompareTo(pivot) == 1) { j--; }

            if (i <= j)
            {
                Request temp = requests[i];
                requests[i] = requests[j];
                requests[j] = temp;
                i++;
                j--;
            }

            if (leftIndex < j) { SortbyStartTime(leftIndex, j); }
            if (i < rightIndex) { SortbyStartTime(i, rightIndex); }
        }

        public void SortbyEndtime(int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            Request pivot = requests[leftIndex];

            while (requests[i].CompareTo(pivot) == -1) { i++; }
            while (requests[j].CompareTo(pivot) == 1) { j--; }

            if (i <= j)
            {
                Request temp = requests[i];
                requests[i] = requests[j];
                requests[j] = temp;
                i++;
                j--;
            }

            if (leftIndex < j) { SortbyEndtime(leftIndex, j); }
            if (i < rightIndex) { SortbyEndtime(i, rightIndex); }
        }
        #endregion
    }
}
