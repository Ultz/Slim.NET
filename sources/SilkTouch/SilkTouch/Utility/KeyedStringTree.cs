// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.SilkTouch.Utility
{
    /// <summary>
    /// Easily combinable and searchable tree structure
    /// </summary>
    public class KeyedStringTree
    {
        ReaderWriterLockSlim _concurrencyLock = new();

        /// <summary>
        /// ctor for <see cref="KeyedStringTree"/>
        /// </summary>
        /// <param name="rootKey"></param>
        /// <param name="rootValue"></param>
        public KeyedStringTree(string rootKey, string rootValue)
        {
            RootNode = new(rootKey, rootValue);
        }

        Node RootNode;

        /// <summary>
        /// Finds a node with a given value
        /// </summary>
        /// <param name="key">key to search for</param>
        /// <param name="node">found node or null</param>
        /// <returns>Whether node was present in the tree</returns>
        public bool FindNode(string key, [NotNullWhen(true)] out Node? node)
        {
            _concurrencyLock.EnterReadLock();
            bool ret = _FindNode(key, out node);
            _concurrencyLock.ExitReadLock();
            return ret;
        }

        private bool _FindNode(string key, [NotNullWhen(true)] out Node? node)
        {
            node = null;
            if (RootNode is null)
            {
                return false;
            }

            Queue<Node> nodesToCheck = new();

            if (RootNode.Key == key)
            {
                node = RootNode;
                return true;
            }

            nodesToCheck.Enqueue(RootNode);

            while (nodesToCheck.TryDequeue(out Node? check))
            {
                foreach (KeyValuePair<string, Node> child in check.Children)
                {
                    if (child.Value.Key == key)
                    {
                        node = child.Value;
                        return true;
                    }

                    nodesToCheck.Enqueue(child.Value);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to add another Tree into this one by combining the root with a matching node
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Whether combination was successful</returns>
        public bool TryConsume(KeyedStringTree other)
        {
            _concurrencyLock.EnterWriteLock();
            if (!_FindNode(other.RootNode.Key, out Node? node))
            {
                _concurrencyLock.ExitWriteLock();
                return false;
            }

            CombineNodes(node, other.RootNode);
            _concurrencyLock.ExitWriteLock();
            return true;
        }

        /// <summary>
        /// Attempts to add a new node to some parent node
        /// </summary>
        /// <param name="parentKey">key of the parent node</param>
        /// <param name="newNodeKey">key of the new child node</param>
        /// <param name="newNodeValue">value of the new child node</param>
        /// <returns>if the parent node was found in the tree</returns>
        public bool TryAddNode(string parentKey, string newNodeKey, string newNodeValue)
        {
            _concurrencyLock.EnterWriteLock();
            if (!_FindNode(parentKey, out Node? node))
            {
                _concurrencyLock.ExitWriteLock();
                return false;
            }

            if (!node.Children.ContainsKey(newNodeKey))
            {
                node.Children.Add(newNodeKey, new(newNodeKey, newNodeValue, node));
            }
            _concurrencyLock.ExitWriteLock();
            return true;
        }

        private void CombineNodes(Node baseNode, Node additiveNode)
        {
            foreach (KeyValuePair<string, Node> child in additiveNode.Children)
            {
                if (baseNode.Children.TryGetValue(child.Key, out Node? baseChild))
                {
                    CombineNodes(baseChild, child.Value);
                }
                else
                {
                    baseNode.Children.Add(child.Key, child.Value);
                }
            }
        }

        /// <summary>
        /// Node from a <see cref="KeyedStringTree" />
        /// </summary>
        public class Node
        {
            internal Node(string key, string value, Node? parent = null)
            {
                Key = key;
                Value = value;
                Parent = parent;
            }

            /// <summary>
            /// Key at this node
            /// </summary>
            public string Key;

            /// <summary>
            /// Value at this node
            /// </summary>
            public string Value;

            /// <summary>
            /// All children for this node
            /// </summary>
            public Dictionary<string, Node> Children = new();

            /// <summary>
            /// this node's parent or null if root node
            /// </summary>
            public Node? Parent;
        }
    }
}
