using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
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

        // Setter / Getter for variables
        public T ID
        {
            set { id = value; }
            get { return id; }
        }
        public LinkedList<T> GetAdjList() { return adjList; }

        // Methods
        public void AddEdge(GraphNode<T> node)
        {
            adjList.AddLast(node.ID);
        }
    }
}
