using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compressions
{
    class char_freq
    {
        private int left_node_index;
        private int right_node_index;
        private int parent_node_index;
        private char iden;
        private int count;
        public char ID {
            get {
                return iden;
            }
            set {
                iden = value;
            }
        }
        public int Count {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public int RightNodeIndex
        {
            get
            {
                return right_node_index;
            }
            set
            {
                right_node_index = value;
            }
        }
        public int LeftNodeIndex
        {
            get
            {
                return left_node_index;
            }
            set
            {
                left_node_index = value;
            }
        }
        public int ParentNodeIndex
        {
            get
            {
                return parent_node_index;
            }
            set
            {
                parent_node_index = value;
            }
        }
        public char_freq()
        {
        }
        public char_freq(char c)
        {
            iden = c;
            count = 1;
        }
        public char_freq(char c, int n)
        {
            iden = c;
            this.count = n;
        }
        public char_freq(char_freq leftnode, char_freq rightnode, List<char_freq> frequency_list)
        {
            this.left_node_index = frequency_list.FindIndex(f => f == leftnode);
            this.right_node_index = frequency_list.FindIndex(f => f == rightnode);
            frequency_list[left_node_index].parent_node_index = frequency_list.FindIndex(f => f == this);
            frequency_list[right_node_index].parent_node_index = frequency_list.FindIndex(f => f == this);
            this.count = leftnode.Count + rightnode.Count;
        }
    }
}
