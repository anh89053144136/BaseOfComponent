using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseOfComponent;

using BaseOfComponent.domain.Implementation;

namespace BaseOfComponentWinform
{
    public partial class Form1 : Form
    {
        private ElementREPO repo=new ElementREPO();

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 10; i++)
            {

                    int[] vs = new int[11];
                    treeView1.Nodes.Add(text: "Главный узел " + (i).ToString()).Nodes.Add("Дочерний узел " + (i + 1).ToString());
                vs[i] = i;             
            }
                      
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = e.Node;
            }
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void AddParent_Click(object sender, EventArgs e)
        {
            AddWin addWin = new AddWin();
            if (addWin.ShowDialog(this) == DialogResult.OK)
            {
                Element newElement = new Element
                {
                    Count = addWin.Count,
                    Name = addWin.NameE
                };
                repo.AddElement(newElement);
                treeView1.Nodes.Add(newElement.Id.ToString(), newElement.Name);

                Relation relation = new Relation();

            }
        }
    }
}
