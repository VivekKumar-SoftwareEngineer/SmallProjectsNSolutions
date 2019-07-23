using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleSolver
{
    internal class Trie
    {
        TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode node = root;

            foreach(var c in word)
            {
                if(node.map.ContainsKey(c) == false)
                {
                    node.map[c] = new TrieNode();
                }

                node = node.map[c];
            }

            node.isWord = true;
        }

        public bool Search(string word)
        {
            TrieNode node = root;

            foreach(var c in word)
            {
                if (node.map.ContainsKey(c) == false)
                    return false;

                node = node.map[c];
            }

            return node.isWord;
        }
    }

    internal class TrieNode
    {
        internal Dictionary<char, TrieNode> map;
        internal bool isWord;

        public TrieNode()
        {
            map = new Dictionary<char, TrieNode>();
        }
    }
}
