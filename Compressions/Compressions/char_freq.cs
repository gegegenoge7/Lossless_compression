using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compressions
{
    class char_freq
    {
        private char_freq left_node;//this shouldn't work
        private char_freq right_node;//shouldn't work
        private char_freq parent_node;//this shouldn't work
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
        public char_freq RightNode
        {
            get
            {
                return right_node;
            }
            set
            {
                right_node = value;
            }
        }
        public char_freq LeftNode
        {
            get
            {
                return left_node;
            }
            set
            {
                left_node = value;
            }
        }
        public char_freq ParentNode
        {
            get
            {
                return parent_node;
            }
            set
            {
                parent_node = value;
            }
        }
        public char_freq()
        {
            left_node = null;
            right_node = null;
        }
        public char_freq(char c)
        {
            left_node = null;
            right_node = null;
            iden = c;
            count = 1;
        }
        public char_freq(char c, int n)
        {
            left_node = null;
            right_node = null;
            iden = c;
            this.count = n;
        }
        public char_freq(char_freq leftnode, char_freq rightnode)
        {
            this.left_node = new char_freq(leftnode.ID, leftnode.Count);
            this.right_node = new char_freq(rightnode.ID, rightnode.Count);
            this.left_node.parent_node = this;
            this.right_node.parent_node = this;
            this.count = leftnode.Count + rightnode.Count;
        }
    }
}
