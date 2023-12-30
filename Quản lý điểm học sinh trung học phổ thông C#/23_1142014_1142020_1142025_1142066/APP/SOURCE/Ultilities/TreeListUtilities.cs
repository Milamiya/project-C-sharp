using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;

namespace Util
{
    public class TreeListUtil
    {
        /// <summary>
        /// Chọn tất cả các nodes con khi node cha được chọn
        /// </summary>
        /// <param name="node">Node cha</param>
        /// <param name="check">Trạng thái đang/không được check</param>
        public static void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }

        /// <summary>
        /// Chọn node cha của nó khi 1 trong các node con của nó được check
        /// </summary>
        /// <param name="node">Node con</param>
        /// <param name="check">Trạng thái đang/không được check</param>
        public static void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }
    }
}