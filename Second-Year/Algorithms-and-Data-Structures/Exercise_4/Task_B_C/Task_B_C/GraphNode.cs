using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B_C
{
    public class GraphNode<T>
    {
        private T id;
        private LinkedList<T> adjList;

        // Constructor
        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }

        // Setters / Getters
        public T ID
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public LinkedList<T> GetAdjList() { return adjList; }

        // Methods
        public void AddEdge(GraphNode<T> node)
        {
            adjList.AddLast(node.ID);
        }
    }
}
