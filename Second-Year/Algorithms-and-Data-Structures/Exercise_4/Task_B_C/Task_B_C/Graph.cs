using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_B_C
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
            // Return true if graph has no nodes
            return nodes.Count == 0;
        }

        public void AddNode(T id)
        {
            // Add a node to the nodes list
            nodes.AddLast(new GraphNode<T>(id));
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            // Check if node exists in the graph
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
        public bool IsAdjacentByNode(GraphNode<T> from, GraphNode<T> to)
        {
            // Check node is adjacent to another
            if (from != null && to != null)
            {
                if (from.GetAdjList().Contains(to.ID)) { return true; }
            }
            return false;
        }
        public bool IsAdjacentByID(T from, T to)
        {
            // Check node is adjacent to another by ID
            GraphNode<T> node1 = GetNodeByID(from);
            GraphNode<T> node2 = GetNodeByID(to);
            if (node1 != null && node2 != null)
            {
                if (node1.GetAdjList().Contains(node2.ID)) { return true; }
            }
            return false;
        }

        public void AddEdge(T from, T to)
        {
            // Connect/add a node to anothers list
            GraphNode<T> node1 = GetNodeByID(from);
            GraphNode<T> node2 = GetNodeByID(to);

            if (node1 != null && node2 != null)
            {
                if (!IsAdjacentByNode(node1, node2))
                {
                    node1.AddEdge(node2);
                    totalEdges++;
                }
            }
        }

        public int NumNodesGraph()
        {
            // Return the total number of nodes in the graph
            return nodes.Count;
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

        public void RemoveNodeByID(T removeID)
        {
            // Remove an item from the list
            GraphNode<T> removeNode = GetNodeByID(removeID);
            if (removeNode != null)
            {
                // Remove airport connections of node being removed
                foreach (GraphNode<T> n in nodes)
                {
                    if (IsAdjacentByNode(n, removeNode))
                    {
                        n.GetAdjList().Remove(removeID);
                        totalEdges--;
                    }
                }
                // Remove node from list
                totalEdges -= removeNode.GetAdjList().Count;
                nodes.Remove(removeNode);
            }
        }

        public void DisplayIndirectEdges(GraphNode<T> node, ref string path, string currPath)
        {
            // Loop first node and pass each direct node into the displayIndirectedges function
            List<GraphNode<T>> checkedNodes = new List<GraphNode<T>>();
            currPath += node.ID.ToString();
            // Loop direct nodes
            foreach (T n in node.GetAdjList())
            {
                // Reset visited nodes list for each direct path
                checkedNodes.Clear();
                checkedNodes.Add(node);
                // Prevent circular graph from being looped more than once
                if (checkedNodes.Contains(GetNodeByID(n))) { continue; }
                // Call displayIndirectEdges and pass current direct node
                displayIndirectEdges(checkedNodes, GetNodeByID(n), ref path, currPath);
            }
        }
        private void displayIndirectEdges(List<GraphNode<T>> checkedNodes, GraphNode<T> node, ref string path, string currPath)
        {
            // Recursive function to get all indirect nodes of given node
            currPath += "->" + node.ID.ToString();
            checkedNodes.Add(node);
            foreach (T n in node.GetAdjList())
            {
                // Prevent circular graph from being looped more than once
                if (checkedNodes.Contains(GetNodeByID(n))) { continue; }
                displayIndirectEdges(checkedNodes, GetNodeByID(n), ref path, currPath);
            }


            // (on way back up of recursion) Check whether path should be returned
            if (!checkedNodes[0].GetAdjList().Contains(node.ID))
            {
                if (node.GetAdjList().Count == 0)
                {
                    // End of recusive loop, add path
                    path += currPath + ",";
                }
                else
                {
                    // If last node in path has connections that have already appeared in path, then add/return current path
                    bool addPath = true;
                    foreach (T checkNode in node.GetAdjList())
                    {
                        if (!currPath.Contains(checkNode.ToString()))
                        {
                            addPath = false; break;
                        }
                    }
                    if (addPath) { path += currPath + ","; }
                }
            }

        }
    }
}
