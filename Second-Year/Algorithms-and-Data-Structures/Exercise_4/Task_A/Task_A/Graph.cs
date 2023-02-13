using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task_A
{
    public class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;
        private int totalEdges;

        // Constructor
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
            totalEdges = 0;
        }

        // Methods
        public bool IsEmptyGraph()
        {
            // Check if the graph contains any nodes
            return nodes.Count == 0;
        }

        public void AddNode(T id)
        {
            // Add a node to the graph/node list
            nodes.AddLast(new GraphNode<T>(id));
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            // Check if node exists in graph
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0) { return true; }
            }
            return false;
        }

        public GraphNode<T> GetNodeByID(T id)
        {
            // Find the node in graph/nodes list (by ID)
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0) { return n; }
            }
            return null;
        }
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            // Check node is adjacent to another
            if (from != null && to != null)
            {
                if (from.GetAdjList().Contains(to.ID)) { return true; }
            }
            return false;
        }

        public void AddEdge(T from, T to)
        {
            // Connect/add a node to another
            GraphNode<T> node1 = GetNodeByID(from);
            GraphNode<T> node2 = GetNodeByID(to);

            if (node1 != null && node2 != null)
            {
                // Check edge is adjecent before adding
                if (!IsAdjacent(node1, node2))
                {
                    node1.AddEdge(node2);
                    totalEdges++;
                }
            }
        }

        public int NumNodesGraph()
        {
            // Return the total number of nodes in the graph
            return nodes.Count();
        }

        public int NumEdgesGraph()
        {
            // Return the total number of edges in the graph
            return totalEdges;
        }

        public string DisplayNodes()
        {
            // Return ID of all nodes in the graph
            string temp = "";
            foreach (GraphNode<T> n in nodes) { temp += n.ID.ToString() + ","; }
            return temp;
        }
        public string DisplayEdges(GraphNode<T> node)
        {
            // Return a string of all edges of the node passed in
            string temp = "";
            foreach (T n in node.GetAdjList()) { temp += n.ToString() + ","; }
            return temp;
        }
    }
}
