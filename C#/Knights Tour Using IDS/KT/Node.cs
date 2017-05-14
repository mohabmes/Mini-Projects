using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{

    class Node
    {
        public int State { get; set; }

        public Node Parent { get; set; }

        public int Depth { get; set; }

        public Node(int state, int Depth, Node parent)
        {
            this.State = state;
            this.Parent = parent;
            if (parent == null)
                this.Depth = 0;
            else
                this.Depth = parent.Depth + 1;
        }


        public Node[] GetChild()
        {
            Node[] child = new Node[8];

            child[0] = new Node(UpRight(this.State), this.Depth + 1, this);
            child[1] = new Node(UpLeft(this.State), this.Depth + 1, this);
            child[2] = new Node(DownLeft(this.State), this.Depth + 1, this);
            child[3] = new Node(DownRight(this.State), this.Depth + 1, this);
            child[4] = new Node(RightDown(this.State), this.Depth + 1, this);
            child[5] = new Node(RightUp(this.State), this.Depth + 1, this);
            child[6] = new Node(LeftUp(this.State), this.Depth + 1, this);
            child[7] = new Node(LeftDown(this.State), this.Depth + 1, this);

            return child;
        }



        int getRow(int pos)
        {
            int row = (int)Math.Ceiling(pos / 8.0);
            if (row > 8 | row <= 0) return -1;
            return row;
        }
        int getCol(int pos)
        {
            int col = pos;
            while (col > 8)
            {
                col -= 8;
            }
            if (col > 8 | col <= 0) return -1;
            return col;
        }
        int UpRight(int pos)
        {
            int newpos;
            int col = getCol(pos) + 1;
            int row = getRow(pos) - 3;
            if (col > 8 || row < 0) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int UpLeft(int pos)
        {
            int newpos;
            int col = getCol(pos) - 1;
            int row = getRow(pos) - 3;
            if (col <= 0 || row <= 0) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int DownLeft(int pos)
        {
            int newpos;
            int col = getCol(pos) - 1;
            int row = getRow(pos) + 1;

            if (!((col > 0 && col <= 8) && (row > 0 && row <= 8))) return -1;

            newpos = (row * 8) + col;

            return newpos;
        }
        int DownRight(int pos)
        {
            int newpos;
            int col = getCol(pos) + 1;
            int row = getRow(pos) + 1;
            if (!((col > 0 && col <= 8) && (row > 0 && row <= 8))) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int RightDown(int pos)
        {
            int newpos;
            int col = getCol(pos) + 2;
            int row = getRow(pos);
            if (col > 8 || row >= 8) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int RightUp(int pos)
        {
            int newpos;
            int col = getCol(pos) + 2;
            int row = getRow(pos) - 2;
            if (col > 8 || row >= 8) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int LeftUp(int pos)
        {
            int newpos;
            int col = getCol(pos) - 2;
            int row = getRow(pos) - 2;
            if (col <= 0 || row < 0) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
        int LeftDown(int pos)
        {
            int newpos;
            int col = getCol(pos) - 2;
            int row = getRow(pos);
            if (col <= 0 || row >= 8) return -1;
            newpos = (row * 8) + col;
            return newpos;
        }
    }
}
