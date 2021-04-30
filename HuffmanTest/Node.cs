using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuffmanTest
{
    public class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }//این فرکانس گفتم ولی همون تکرار هستش
        public Node Right { get; set; }
        public Node Left { get; set; }

        public List<bool> Node_Run(char symbol, List<bool> data)
        {
            // Leaf
            if (Right == null && Left == null)
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);

                    left = Left.Node_Run(symbol, leftPath);
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Node_Run(symbol, rightPath);
                }

                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }

    }
}