using Microsoft.Win32;
using QuestManager.Models;
using QuestManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QuestManager
{
    public partial class Form1 : Form
    {
        private string ViewBag;
        private string _filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control current;
            foreach (var control in mainContainers.Panel1.Controls)
            {
                current = control as Control;
                current.Enabled = false;
            }

            foreach (var control in mainContainers.Panel2.Controls)
            {
                current = control as Control;
                current.Enabled = false;
            }

            using (var key = Registry.CurrentUser.OpenSubKey("Software\\Rotomea\\QuestManager"))
            {
                if (key != null)
                {
                    string path = (key.GetValue("path") ?? string.Empty) as string;

                    if (path != null && File.Exists(path))
                    {
                        _load(path);
                    }
                    else key.DeleteValue("path");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void chargerUnFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indexManagers.Nodes.Clear();
            Manager.Instance.New(new Managers.QuestManager(indexManagers, new QuestVisualiser(name, desc, giver, location, isMain, steps, rewards)));
            ActiveAll();
            Icon = Resources.BlinkStickOn;
            sauvegarderSousToolStripMenuItem1.Enabled = true;
            //sauvegarderToolStripMenuItem1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ActiveAll()
        {
            Control current;
            foreach (var control in mainContainers.Panel1.Controls)
            {
                current = control as Control;
                current.Enabled = true;
            }

            foreach (var control in mainContainers.Panel2.Controls)
            {
                current = control as Control;
                current.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaxModifier dialog = new MaxModifier(Manager.Instance.QuestManager.Count, Cursor.Position);
            dialog.FormClosed += (object dialogSender, FormClosedEventArgs ev) =>
            {
                int max = ((MaxModifier)dialogSender).MaximumValue;

                if (max < 1) max = 1;

                if (max != Manager.Instance.QuestManager.Count)
                {
                    if (max > Manager.Instance.QuestManager.Count)
                    {
                        for (int i = Manager.Instance.QuestManager.Count; i < max; ++i)
                        {
                            Manager.Instance.QuestManager.Add();
                        }
                    }
                    else
                    {
                        for (int len = max, i = Manager.Instance.QuestManager.Count; i > len; --i)
                        {
                            Manager.Instance.QuestManager.Remove();
                        }
                    }
                }

                ((MaxModifier)dialogSender).Dispose();
            };
            dialog.ShowDialog();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (Manager.Instance.QuestManager != null) Manager.Instance.QuestManager.UpdateCurrentQuestName((sender as TextBox).Text);
        }

        private void desc_TextChanged(object sender, EventArgs e)
        {
            Manager.Instance.QuestManager.UpdateCurrentQuestDescription((sender as RichTextBox).Text);
        }

        private void isMain_CheckedChanged(object sender, EventArgs e)
        {
            if (Manager.Instance.QuestManager != null) Manager.Instance.QuestManager.UpdateCurrentQuestIsMainQuest((sender as CheckBox).Checked);
        }

        private void giver_TextChanged(object sender, EventArgs e)
        {
            Manager.Instance.QuestManager.UpdateCurrentQuestGiver((sender as TextBox).Text);
        }

        private void location_TextChanged(object sender, EventArgs e)
        {
            Manager.Instance.QuestManager.UpdateCurrentQuestLocation((sender as TextBox).Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void zezToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nouveauToolStripMenuItem_Click(sender, e);
        }

        private void sauvegarderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_filePath != null && _filePath != string.Empty)
            {
                ViewBag = AppManager.GetSave(); //Newtonsoft.Json.JsonConvert.SerializeObject(Manager.Instance.QuestManager.Quests);
                _saveFile(_filePath);
            }
        }

        private void sauvegarderSousToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewBag = AppManager.GetSave();//Newtonsoft.Json.JsonConvert.SerializeObject(Manager.Instance.QuestManager.Quests);
            saveFileDialog1.FileName = "questsData";
            saveFileDialog1.Filter = "Json Files (*.json)|*.json";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.ShowDialog(this);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog saveFileDialog = sender as SaveFileDialog;

            _saveFile(saveFileDialog.FileName);
        }

        private void _saveFile(string fileName)
        {
            File.WriteAllText(fileName, String.Empty);
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.Write(ViewBag);
            }

            ViewBag = null;

            SetFilePath(fileName);

            if (!sauvegarderToolStripMenuItem1.Enabled) sauvegarderToolStripMenuItem1.Enabled = true;
        } 

        public void SetFilePath(string filePath)
        {
            _filePath = filePath;
            Text = $"Base de donnée : {_filePath}";
            var key = Registry.CurrentUser.CreateSubKey("Software\\Rotomea\\QuestManager", true);
            key.SetValue("path", filePath);
            key.Close();
        }

        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "questsData";
            openFileDialog1.Filter = "Json Files (*.json)|*.json";
            openFileDialog1.ShowDialog();
        }

        private void _load(string path)
        {
            string readingText = File.ReadAllText(path);

            if (null == Manager.Instance.QuestManager) nouveauToolStripMenuItem1_Click(this, new EventArgs());

            //Manager.Instance.Load(readingText);

            try
            {
                AppManager.Load(readingText);
            }
            catch (Exception)
            {
                Manager.Instance.Load(readingText);
            }

            SetFilePath(path);
            _updateSettingStepModeStep();

            Icon = Resources.BlinkStickOn;
            if (!sauvegarderToolStripMenuItem1.Enabled) sauvegarderToolStripMenuItem1.Enabled = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog saveFileDialog = sender as OpenFileDialog;

            _load(saveFileDialog.FileName);
        }

        private void steps_Click(object sender, EventArgs e)
        {
            StepForm dialog = new StepForm();
            dialog.FormClosed += (object dialogSender, FormClosedEventArgs ev) =>
            {
                Manager.Instance.QuestManager.TreeUpdated();

                ((StepForm)dialogSender).Dispose();
            };
            dialog.ShowDialog();
        }

        private void steps_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void steps_MouseClick(object sender, MouseEventArgs e)
        {
            steps_Click(sender, e);
        }

        private void steps_MouseDown(object sender, MouseEventArgs e)
        {
            steps_Click(sender, e);
        }

        private void modeDesÉtapesSUPERLONGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _updateSettingStepMode();
        }

        private void _updateSettingStepMode()
        {
            Settings.Instance.NameInsteadOfDesc = !Settings.Instance.NameInsteadOfDesc;
            _updateSettingStepModeStep();
        }

        private void _updateSettingStepModeStep()
        {
            stepModeSetting.Text = $"Mode des étapes : {(Settings.Instance.NameInsteadOfDesc ? "Nom" : "Description")}";
            Manager.Instance.QuestManager.TreeUpdated();
        }
    }
}
