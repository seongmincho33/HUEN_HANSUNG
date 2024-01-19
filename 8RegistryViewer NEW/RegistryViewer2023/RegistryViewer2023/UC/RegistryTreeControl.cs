using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistryViewer2023.UC
{
    public partial class RegistryTreeControl : UserControl
    {
        public event Action<RegistryKey> NodeClicked;

        public RegistryTreeControl()
        {
            InitializeComponent();
            treeViewRegistry.BeforeExpand += TreeViewRegistry_BeforeExpand;
            treeViewRegistry.AfterSelect += TreeViewRegistry_AfterSelect;
            PopulateRegistryTreeView();
            btnSearch.Click += BtnSearch_Click;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchPath = txtKey.Text;

            FindNodeByPath(treeViewRegistry.Nodes, searchPath);

        }

        // Recursive method to find a node by path
        private void FindNodeByPath(TreeNodeCollection nodes, string path)
        {
            string prefix1 = "computer";
            string prefix2 = "컴퓨터";

            if (path.StartsWith(prefix1, StringComparison.OrdinalIgnoreCase))
            {
                // Remove the "computer" prefix (case-insensitive) and the rest of the string
                path = path.Substring(prefix1.Length);
            }
            else if (path.StartsWith(prefix2, StringComparison.OrdinalIgnoreCase))
            {
                // Remove the "컴퓨터" prefix (case-insensitive) and the rest of the string
                path = path.Substring(prefix2.Length);
            }

            path = path.TrimStart('\\');

            List<string> splitedPathList = path.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (TreeNode node in nodes)
            {
                var firstString = splitedPathList[0];

                switch (firstString)
                {
                    case "HKEY_CLASSES_ROOT":
                        firstString = "ClassesRoot";
                        break;
                    case "HKEY_CURRENT_USER":
                        firstString = "CurrentUser";
                        break;
                    case "HKEY_LOCAL_MACHINE":
                        firstString = "LocalMachine";
                        break;
                    case "HKEY_USERS":
                        firstString = "Users";
                        break;
                    case "HKEY_CURRENT_CONFIG":
                        firstString = "CurrentConfig";
                        break;
                }

                if (node.Text == firstString)
                {
                    PopulateTreeNode(node);

                    node.Expand();

                    int index = path.IndexOf("\\");

                    if (index >= 0)
                    {
                        // Remove the first part of the string up to and including the first "\\"
                        path = path.Remove(0, index + 1);
                    }
                    FindNodeByPath(node.Nodes, path);

                    if (splitedPathList.Count == 1)
                    {
                        this.treeViewRegistry.SelectedNode = node;
                    }
                }
            }
        }


        private void PopulateRegistryTreeView()
        {
            // Add the top-level nodes for the registry hives
            foreach (RegistryHive hive in Enum.GetValues(typeof(RegistryHive)))
            {
                TreeNode hiveNode = new TreeNode(hive.ToString());
                treeViewRegistry.Nodes.Add(hiveNode);
            }

            foreach (TreeNode node in this.treeViewRegistry.Nodes)
            {
                // Ensure that the selected node is a top-level node (hive) and not a subkey
                if (node != null && node.Parent == null)
                {
                    // Get the subkeys for the selected node
                    using (RegistryKey selectedKey = GetRegistryKeyFromNode(node))
                    {
                        if (selectedKey != null)
                        {
                            node.Nodes.Clear(); // Clear any temporary "Loading..." nodes
                            PopulateSubkeys(selectedKey, node);
                        }
                    }
                }
            }
        }

        private void TreeViewRegistry_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Ensure that the selected node is a top-level node (hive) and not a subkey
            if (selectedNode != null && selectedNode.Parent == null)
            {
                // Get the subkeys for the selected node
                using (RegistryKey selectedKey = GetRegistryKeyFromNode(selectedNode))
                {
                    if (selectedKey != null)
                    {
                        selectedNode.Nodes.Clear(); // Clear any temporary "Loading..." nodes
                        PopulateSubkeys(selectedKey, selectedNode);
                    }
                }
            }
            else if (selectedNode != null && selectedNode.Parent != null)
            {
                // Get the subkeys for the selected node
                using (RegistryKey selectedKey = GetRegistryKeyFromNode(selectedNode))
                {
                    if (selectedKey != null)
                    {
                        // Trigger the custom event to send data to another user control
                        NodeClicked?.Invoke(selectedKey);
                    }
                }
            }
        }

        private void TreeViewRegistry_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            PopulateTreeNode(e.Node);
        }

        private void PopulateTreeNode(TreeNode node)
        {
            // Check if this node has already been populated
            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "Loading...")
            {
                node.Nodes.Clear(); // Remove the "Loading..." node

                // Get the subkeys for the expanded node
                using (RegistryKey parentKey = GetRegistryKeyFromNode(node))
                {
                    if (parentKey != null)
                    {
                        PopulateSubkeys(parentKey, node);
                    }
                }
            }
        }

        private RegistryKey GetRegistryKeyFromNode(TreeNode node)
        {
            // For top-level nodes (hives), return the root key directly
            if (node.Parent == null)
            {
                return RegistryKey.OpenBaseKey(GetRegistryHiveFromNode(node), RegistryView.Default);
            }

            //string path = node.FullPath.Substring(node.FullPath.IndexOf("\\") + 1); // Remove the root node name
            string path = "";
            string fullPath = node.FullPath;
            int lastBackslashIndex = fullPath.LastIndexOf("\\");
            if (lastBackslashIndex >= 0)
            {
                // Now, lastPart contains the last part of the FullPath
                path = fullPath.Substring(lastBackslashIndex + 1);
            }
            RegistryKey parentKey = GetRegistryKeyFromNode(node.Parent);
            return parentKey.OpenSubKey(path);
        }

        private RegistryHive GetRegistryHiveFromNode(TreeNode node)
        {
            // For top-level nodes (hives), map the string representation to the actual hive
            if (node.Parent == null)
            {
                string hiveName = node.Text;
                if (Enum.TryParse(hiveName, out RegistryHive hive))
                {
                    return hive;
                }
            }
            return RegistryHive.CurrentUser; // Default to CurrentUser if not found (you can change this to a different default if needed)
        }

        private void PopulateSubkeys(RegistryKey parentKey, TreeNode parentNode)
        {
            foreach (string subkeyName in parentKey.GetSubKeyNames())
            {
                TreeNode subkeyNode = new TreeNode(subkeyName);
                subkeyNode.Nodes.Add("Loading..."); // Add a temporary "Loading..." node

                parentNode.Nodes.Add(subkeyNode);
            }
        }
    }
}
