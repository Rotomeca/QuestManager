using QuestManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Steps = System.Collections.Generic.List<QuestManager.Models.Step>;

namespace QuestManager.Managers
{
    public class StepManager
    {
        private bool _loaded = false;
        private TreeView _tree;
        private StepVisualiser _visualiser;
        private Steps _steps => Manager.Instance.QuestManager.Visualiser.CurrentQuest.Steps;
        public StepVisualiser Visualiser => _visualiser;
        public StepManager(TreeView tree, StepVisualiser.Initialiser initisaliser)
        {
            _tree = tree;
            _visualiser = new StepVisualiser(initisaliser);

            _GenerateTree();

            if (_steps.Count  < 1 ) {
                Add();
            }

            _visualiser.ChangeStep(_steps.Last());

            if (!_loaded)
            {
                _tree.NodeMouseClick += (object sender, TreeNodeMouseClickEventArgs e) => {
                    int nindex = _tree.Nodes.IndexOf(e.Node);

                    _visualiser.ChangeStep(_steps[nindex]);
                };
                _loaded = true;
            }
        }

        public int Count => _steps.Count;

        public StepManager Add(Step step)
        {
            _steps.Add(step);
            _tree.Nodes.Add(new TreeNode(_NodeName(step)));

            _visualiser.ChangeStep(step);

            return this;
        }

        public StepManager Add()
        {
            return Add(new Step());
        }

        public StepManager RemoveCurrent()
        {
            int index = _steps.IndexOf(_visualiser.CurrentStep);
            return Remove(index);
        }

        public StepManager Remove(int index)
        {
            if (_steps.Count > 1)
            {
                _steps.RemoveAt(index);
                _tree.Nodes.Clear();
                _GenerateTree();
            }
            return this;
        }

        private void _GenerateTree()
        {
            foreach (var step in _steps)
            {
                _tree.Nodes.Add(_NodeName(step));
            }
        }

        private string _NodeName(Step step)
        {
            return step.ToString();
        }

        public StepManager UpdateName()
        {
            int currentIndex = _steps.IndexOf(_visualiser.CurrentStep);
            _tree.Nodes[currentIndex].Text = _steps[currentIndex].ToString();

            return this;
        }
    }
}
