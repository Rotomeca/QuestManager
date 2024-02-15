using QuestManager.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace QuestManager.Managers
{
    public class QuestManager
    {
        private static bool _loaded = false;

        private QuestVisualiser _visualiser;
        private List<RotomecaQuest> _quests;
        private TreeView _tree;

        public QuestVisualiser Visualiser => _visualiser;
        public List<RotomecaQuest> Quests => _quests;

        public QuestManager(QuestVisualiser visualiser) {
            _quests = new List<RotomecaQuest>();
            _tree = new TreeView();
            _visualiser = visualiser;
            _InitManager();
        }

        public QuestManager(TreeView tree, QuestVisualiser visualiser)
        {
            _quests = new List<RotomecaQuest>();
            _tree = tree;
            _visualiser = visualiser;
            _InitManager();
        }

        public QuestManager(TreeView tree, IEnumerable<RotomecaQuest> quests, QuestVisualiser visualiser)
        {
            _quests = new List<RotomecaQuest>(quests);
            _tree = tree;
            _visualiser = visualiser;
            _InitManager();
        }

        private void _InitManager()
        {
            if (!_loaded)
            {
                _tree.NodeMouseClick += (object sender, TreeNodeMouseClickEventArgs e) => {
                    NodeClicked(sender, e);
                };
                _loaded = true;
            }

            if (_quests.Count == 0) {
                Add();
            }

            _tree.SelectedNode = _tree.Nodes[0];
            _tree.SelectedNode.BackColor = Color.Blue;
            _tree.SelectedNode.ForeColor = Color.White;
            _visualiser.ChangeQuest(_quests[_quests.Count - 1]);
        }

        public RotomecaQuest this[int index] { get => ((IList<RotomecaQuest>)_quests)[index]; }

        public int Count => _quests.Count;

        public QuestManager Add()
        {
            return Add(new RotomecaQuest(_quests.Count) { Name = $"Quête non-définie {_quests.Count + 1}" });
        }

        public QuestManager Add(RotomecaQuest quest)
        {
            _quests.Add(quest);
            _tree.Nodes.Add(new TreeNode($"{_quests.Count} : {_quests[_quests.Count - 1].Name}"));

            return this;
        }

        public QuestManager Remove()
        {
            _quests.RemoveAt(_quests.Count - 1);
            _tree.Nodes.RemoveAt(_tree.Nodes.Count - 1);
            return this;
        }

        public QuestManager Load(string jsonFile)
        {
            var loaded = Newtonsoft.Json.JsonConvert.DeserializeObject<RotomecaQuest[]>(jsonFile);

            _quests = new List<RotomecaQuest>(loaded);
            _tree.Nodes.Clear();

            if (_quests.Count < 1) Add();
            else foreach (var quest in loaded) _tree.Nodes.Add(new TreeNode($"{quest.Id + 1} : {quest.Name}"));

            Visualiser.ChangeQuest(_quests[0]);

            SelectNode(_tree.Nodes[0]);

            return this;
        }

        public void UpdateCurrentQuestName(string newName)
        {
            Visualiser.CurrentQuest.Name = newName;
            _tree.Nodes[Visualiser.CurrentQuest.Id].Text = $"{Visualiser.CurrentQuest.Id + 1} : {newName}";
        }

        public void UpdateCurrentQuestDescription(string desc)
        {
            Visualiser.CurrentQuest.Description = desc;
        }

        public void UpdateCurrentQuestGiver(string giver)
        {
            Visualiser.CurrentQuest.Giver = giver;
        }

        public void UpdateCurrentQuestIsMainQuest(bool isMainQuest)
        {
            Visualiser.CurrentQuest.QuestType = isMainQuest ? Enums.Quests.QuestType.Main : Enums.Quests.QuestType.Side;
        }

        public void UpdateCurrentQuestLocation(string location)
        {
            Visualiser.CurrentQuest.Location = location;
        }

        public void TreeUpdated()
        {
            Visualiser.Update();
        }

        private void NodeClicked(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectNode(e.Node);
        }

        public void SelectNode(TreeNode node)
        {
            _tree.Nodes[Visualiser?.CurrentQuest?.Id ?? 0].BackColor = Color.White;
            _tree.Nodes[Visualiser?.CurrentQuest?.Id ?? 0].ForeColor = Color.Black;
            int nodeIndex = _tree.Nodes.IndexOf(node);
            _visualiser.ChangeQuest(_quests[nodeIndex]);
            _tree.Nodes[nodeIndex].BackColor = Color.Blue;
            _tree.Nodes[nodeIndex].ForeColor = Color.White;
        }

    }
}
