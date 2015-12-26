using System.Collections;
using System.Collections.Generic;

namespace Patterns.Structural.Composite
{
    internal class TreeNode : TreeNodeComposite, IEnumerable<TreeNodeComposite>
    {
        private readonly List<TreeNodeComposite> _treeNodes = new List<TreeNodeComposite>();

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<TreeNodeComposite> GetEnumerator()
        {
            return ((IEnumerable<TreeNodeComposite>)_treeNodes).GetEnumerator();
        }

        public void Add(TreeNodeComposite node)
        {
            _treeNodes.Add(node);
        }

        public void Remove(TreeNodeComposite node)
        {
            _treeNodes.Remove(node);
        }


        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public TreeNode(int id, string caption)
            : base(id, caption)
        {
            
        }
    }
}