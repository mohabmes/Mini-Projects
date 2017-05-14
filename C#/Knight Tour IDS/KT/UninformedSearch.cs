using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    class UninformedSearch
    {
        List<int> solution;
        public bool DLS(int GoalState, int limit)
        {
            Stack<Node> Fringe = new Stack<Node>();

            //1. Add initial node to fringe
            Node root = new Node(5, 0, null);
            Fringe.Push(root);

            //2. Repeat until fringe.count==0
            while (Fringe.Count != 0)
            {
                //2.1 Extract current node from fringe
                Node currentNode = Fringe.Pop();
                // Console.WriteLine("Node  {0}\tvisited", currentNode.State);

                if (currentNode.State <= 0 || currentNode.State >= 65)
                    continue;

                //2.2. check if current node is goal
                if (currentNode.Depth == GoalState)
                {
                    //Console.WriteLine("Final Node: " + currentNode.State);

                    //Get Solution
                    List<int> solution = GetSolution(currentNode);

                    //stop
                    return true;
                }

                //2.3 check if depth of current node == limit
                if (currentNode.Depth == limit)
                    continue;

                //2.4 add its child to fringe
                //Get child
                Node[] child = currentNode.GetChild();

                //Add child to fringe
                for (int i = 0; i < child.Length; i++)
                {
                    if (FindDupNode(currentNode, child[i]) && child[i].State > 0 && child[i].State < 65)
                    {
                        Fringe.Push(child[i]);
                    }
                }
            }

            return false;
        }

        public void IDS(int GoalState, int init_limit, int inc_limit)
        {
            int limit = init_limit;
            while (!DLS(GoalState, limit))
            {
                limit += inc_limit;
            }
        }

        private List<int> GetSolution(Node currentNode)
        {
            solution = new List<int>();

            while (true)
            {
                if (currentNode == null)
                    break;
                solution.Insert(0, currentNode.State);
                currentNode = currentNode.Parent;
            }
            return solution;
        }
        private bool FindDupNode(Node currentNode, Node c)
        {
            List<int> list = GetSolution(currentNode);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == c.State) return false;
            }
            return true;
        }
        public List<int> GetFinalSolution()
        {
            return solution;
        }
    }
}
