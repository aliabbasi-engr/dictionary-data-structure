using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        Tree tree = new Tree();

        public Form2()
        {
            try
            {
                InitializeComponent();
                if (OpenFileForm.Language == Language.DE)
                    ChangeLanguageToDE();
                var maxSize = 30;
                foreach (var temp in Helper.GetDataFromFile(OpenFileForm.SourceFile))
                {
                    tree.InsertKeyNode(temp.Value, temp.Key);
                    nodesListBox.Items.Add(temp.Value.ToString().PadRight(maxSize - temp.Value.ToString().Length - temp.Key.Length, ' ') + temp.Key);
                }
                if (OpenFileForm.FileLoaded)
                {
                    FillOrdersLabels();
                    FillTreeDataLables();
                    FillInOrderMembers();
                }
            }
            catch
            {
                MessageBox.Show("Input file is not valid! It may cause problems.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void FillOrdersLabels()
        {
            preOrders.Text = string.Join(" ", tree.GetPreOrder(tree.Root));
            var inOrderList = new List<int>();
            foreach (CellNode node in tree.GetNodesInInOrder(tree.Root))
                inOrderList.Add(node.IntValue);
            inOrders.Text = string.Join(" ", inOrderList);
            postOrders.Text = string.Join(" ", tree.GetPostOrder(tree.Root));
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                var maxSize = 30;
                nodesListBox.Items.Add((Helper.GetIntValue(double.Parse(valueTextBox.Text)) + Helper.GetDoubleValue(double.Parse(valueTextBox.Text))).ToString().PadRight(maxSize - (Helper.GetIntValue(double.Parse(valueTextBox.Text)) + Helper.GetDoubleValue(double.Parse(valueTextBox.Text))).ToString().Length - keyTextBox.Text.Length, ' ') + keyTextBox.Text);
                tree.InsertKeyNode(double.Parse(valueTextBox.Text), keyTextBox.Text);
                FillOrdersLabels();
                FillTreeDataLables();
                FillInOrderMembers();
                Helper.AddDataToFile(double.Parse(valueTextBox.Text), keyTextBox.Text, OpenFileForm.SourceFile);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message , "Invalid input" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            valueTextBox.Clear();
            keyTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedLine = nodesListBox.GetItemText(nodesListBox.SelectedItem);
                string value = selectedLine.Substring(0, selectedLine.IndexOf(' ')).Trim();
                string key = selectedLine.Substring(selectedLine.IndexOf(' '), selectedLine.Length - value.Length).Trim();
                tree.DeleteKeyNodeByValue(double.Parse(value));
                Helper.RemoveDataFromFile(value, key , OpenFileForm.SourceFile);
                nodesListBox.Items.Remove(nodesListBox.SelectedItem);
                FillOrdersLabels();
                FillTreeDataLables();
                FillInOrderMembers();
            }
            catch
            {
                MessageBox.Show("Select an item from the list!" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void finderTextBox_Enter(object sender, EventArgs e)
        {
            finderTextBox.Clear();
        }

        private void finderButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = finderTextBox.Text;
                if (findByKeyRadioButton.Checked)
                {
                    CellNode node = tree.FindKeyNodeByKey(finderTextBox.Text);
                    finderLabel.Text = (node.IntValue + node.DoubleValue).ToString();
                }
                else if (findByValueRadioButton.Checked)
                {
                    finderLabel.Text = tree.FindKeyNodeByValue(double.Parse(finderTextBox.Text)).Key;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findByKeyRadioButton_Click(object sender, EventArgs e)
        {
            finderTextBox.Text = "Type here";
        }

        private void findByValueRadioButton_Click(object sender, EventArgs e)
        {
            finderTextBox.Text = "Type here";
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            certainIntegerWordsListBox.Items.Clear();
            try
            {
                int maxSize = 25;
                foreach (CellNode node in tree.FindKeysWithCertainIntegerValue(int.Parse(certainIntegerWordsTextBox.Text)))
                    certainIntegerWordsListBox.Items.Add(node.DoubleValue.ToString().PadRight(maxSize - node.DoubleValue.ToString().Length - node.Key.Length, ' ') + node.Key);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillInOrderMembers()
        {
            inOrderListBox.Items.Clear();
            int maxSize = 25;
            double value;
            foreach (var treeNode in tree.GetNodesInInOrder(tree.Root))
            {
                foreach (var keyNode in tree.FindKeysWithCertainIntegerValue(treeNode.IntValue))
                {
                    value = keyNode.IntValue + keyNode.DoubleValue;
                    inOrderListBox.Items.Add(value.ToString().PadRight(maxSize - value.ToString().Length - keyNode.Key.Length, ' ') + keyNode.Key);
                }

            }
        }

        private void FillTreeDataLables()
        {
            try
            {
                rootValueLable.Text = tree.Root.IntValue.ToString();
                heightLabel.Text = tree.Height.ToString();
                nodesCountLable.Text = tree.GetNodesInInOrder(tree.Root).Count.ToString();
                mostLoadedTreeNodeLable.Text = tree.MostLoadedNode.IntValue.ToString();
            }
            catch
            { }
        }

        private void ChangeLanguageToDE()
        {
            ordersGroupBox.Text = "Binäre Suchbaumaufträge";
            preOrderLabel.Text = "Vorbestellung:";
            inOrderLable.Text = "Inordnung:";
            postOrderLable.Text = "Nachbestellung:";
            InsertGroupBox.Text = "Einfügen";
            valueLabel.Text = "Wert:";
            wordLabel.Text = "Wort:";
            insertButton.Text = "Einfügen";
            finderGroupBox.Text = "Finder";
            findByKeyRadioButton.Text = "Nach Wort suchen";
            findByValueRadioButton.Text = "Nach Wert suchen";
            finderTextBox.Text = "Tippe hier";
            finderButton.Text = "Find";
            keyValueLable.Text = "Wort/Wert:";
            certainIntegerWordsGroupBox.Text = "bestimmte ganzzahlige Wörter anzeigen";
            intValueLable.Text = "Ganzezahl wert:";
            viewButton.Text = "Aussicht";
            inOrderGroupBox.Text = "Inordnung mitglieder";
            generalDataGroupBox.Text = "Allgemeine binäre Suchbaumdaten";
            rootValueLable1.Text = "Root wert:";
            heightLable1.Text = "Höhe:";
            nodesCountLable1.Text = "Knoten zählen:";
            mostLoadedTreeNodeLable1.Text = "Am meisten geladener Baumknoten:";
            selectedItemGroupBox.Text = "Informationen zum ausgewählten Artikel";
            parentLabel1.Text = "Elternteil:";
            leftChildLabel1.Text = "Linkes Kind:";
            rightChildLable1.Text = "Richtiges Kind:";
            membersLable1.Text = "Mitglieder zählen:";
            removeButton.Text = "Löschen";
            saveButton.Text = "Speichern Als";
            treeViewerGroupBox.Text = "Baumbetrachter";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string savePath = "";
            if (OpenFileForm.Language == Language.EN)
            {
                saveFileDialog1.Title = "Save File As";
                saveFileDialog1.Filter = "Text Files (*.txt)| *.txt";
            }
            else if (OpenFileForm.Language == Language.EN)
            {

                saveFileDialog1.Title = "Datei speichern als";
                saveFileDialog1.Filter = "Textdateien (*.txt)| *.txt";
            }
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                savePath = saveFileDialog1.FileName;
                File.Copy(OpenFileForm.SourceFile, savePath, true);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            treeViewerGroupBox.BackgroundImage = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\tree.jpg");
            nodesPictureBox.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icon.png");
            selectedItemPictureBox.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icon.png");
            insertPictureBox.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icon.png");
            finderPictureBox.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icon.png");
            certainIntegerPictureBox.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icon.png");
            inOrderMembersictureBox.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icon.png");
            treeViewerPictureBox.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\icon.png");
        }

        private void nodesListBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (nodesListBox.SelectedIndex >= 0 || nodesListBox.GetItemRectangle(nodesListBox.SelectedIndex).Contains(e.Location))
                {
                    string selectedLine = nodesListBox.GetItemText(nodesListBox.SelectedItem);
                    string value = selectedLine.Substring(0, selectedLine.IndexOf(' ')).Trim();
                    CellNode node = tree.FindTreeNodeByValue(double.Parse(value));
                    if (node.Parent != null)
                    {
                        parentLable.Text = node.Parent.IntValue.ToString();
                        parentViewerLable.Text = node.Parent.IntValue.ToString();
                    }
                    else
                    {
                        parentLable.Text = "null";
                        parentViewerLable.Text = "";
                    }
                    if (node.LeftChild != null)
                    {
                        leftChildLable.Text = node.LeftChild.IntValue.ToString();
                        leftChildViewerLable.Text = node.LeftChild.IntValue.ToString();
                    }
                    else
                    {
                        leftChildLable.Text = "null";
                        leftChildViewerLable.Text = "";
                    }
                    if (node.RightChild != null)
                    {
                        rightChildLable.Text = node.RightChild.IntValue.ToString();
                        rightChildViewerLable.Text = node.RightChild.IntValue.ToString();
                    }
                    else
                    {
                        rightChildLable.Text = "null";
                        rightChildViewerLable.Text = "";
                    }
                    currentViewerLable.Text = Helper.GetIntValue(double.Parse(value)).ToString(); 
                    membersLable.Text = node.Count.ToString();
                }
            }
            catch
            { }
        }

        private void nodesPictureBox_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            if (OpenFileForm.Language == Language.EN)
                toolTip.SetToolTip(this.nodesPictureBox, "This list shows input sequence.");
            else
                toolTip.SetToolTip(this.nodesPictureBox, "Diese Liste zeigt die Eingabesequenz.");
        }

        private void insertPictureBox_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            if (OpenFileForm.Language == Language.EN)
                toolTip.SetToolTip(this.insertPictureBox, "Enter word and its key to add it to dictionary.");
            else
                toolTip.SetToolTip(this.insertPictureBox, "Geben Sie das Wort und seinen Schlüssel ein, um es dem Wörterbuch hinzuzufügen.");
        }

        private void finderPictureBox_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            if (OpenFileForm.Language == Language.EN)
                toolTip.SetToolTip(this.finderPictureBox, "Type Word/Value to get its Value/Word.");
            else
                toolTip.SetToolTip(this.finderPictureBox, "Geben Sie Wort/Wert ein, um dessen Wert/Wort zu erhalten.");
        }

        private void certainIntegerPictureBox_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            if (OpenFileForm.Language == Language.EN)
                toolTip.SetToolTip(this.certainIntegerPictureBox, "Find all words with a certain integer number.");
            else
                toolTip.SetToolTip(this.certainIntegerPictureBox, "Finde alle Wörter mit einer bestimmten ganzen Zahl.");
        }

        private void selectedItemPictureBox_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            if (OpenFileForm.Language == Language.EN)
                toolTip.SetToolTip(this.selectedItemPictureBox, "Select one of words above to see more info about its tree's node.");
            else
                toolTip.SetToolTip(this.selectedItemPictureBox, "Wählen Sie eines der obigen Wörter, um weitere Informationen über den Knoten des Baums anzuzeigen.");
        }

        private void inOrderMembersictureBox_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            if (OpenFileForm.Language == Language.EN)
                toolTip.SetToolTip(this.inOrderMembersictureBox, "You can find all words in inorder in the following list.");
            else
                toolTip.SetToolTip(this.inOrderMembersictureBox, "Sie können alle Wörter in unorder in der folgenden Liste finden.");
        }

        private void treeViewerPictureBox_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            if (OpenFileForm.Language == Language.EN)
                toolTip.SetToolTip(this.treeViewerPictureBox, "First select a word from the left list, then you can cross the tree by clicking on the nodes.");
            else
                toolTip.SetToolTip(this.treeViewerPictureBox, "Wählen Sie zunächst ein Wort aus der linken Liste aus, und Sie können den Baum durch Klicken auf die Knoten durchqueren.");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\audio.wav");
            simpleSound.Play();
            goodByePictureBox.Visible = true;
            goodByePictureBox.Image = Image.FromFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\image.png");
            MessageBox.Show("Thanks a lot!  :D", ":)",MessageBoxButtons.OK); 
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int maxSize = 50;
            string lineSeperator = "";
            string text = "";
            foreach (var dic in Helper.GetDataFromFile(OpenFileForm.SourceFile))
                //text += dic.Value + "-" + dic.Key + "\n";
                text += dic.Value.ToString().PadRight(maxSize - dic.Value.ToString().Length - dic.Key.Length, ' ') + dic.Key + "\n" + lineSeperator.PadRight(maxSize, '-') + "\n";
            e.Graphics.DrawString(text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 150, 125);
        }

        private void FillTreeViewer(CellNode node)
        {
            try
            {
                    if (node.Parent != null)
                        parentViewerLable.Text = node.Parent.IntValue.ToString();
                    else
                        parentViewerLable.Text = "";
                    if (node.LeftChild != null)
                        leftChildViewerLable.Text = node.LeftChild.IntValue.ToString();
                    else
                        leftChildViewerLable.Text = "";
                    if (node.RightChild != null)
                        rightChildViewerLable.Text = node.RightChild.IntValue.ToString();
                    else
                        rightChildViewerLable.Text = "";
                    currentViewerLable.Text = node.IntValue.ToString();
            }
            catch
            { }
        }

        private void parentViewerLable_Click(object sender, EventArgs e)
        {
            if (parentViewerLable.Text != "null")
            {
                FillTreeViewer(tree.FindTreeNodeByValue(double.Parse(parentViewerLable.Text)));
            }
        }

        private void leftChildViewerLable_Click(object sender, EventArgs e)
        {
            if (leftChildViewerLable.Text != "null")
            {
                FillTreeViewer(tree.FindTreeNodeByValue(double.Parse(leftChildViewerLable.Text)));
            }
        }

        private void rightChildViewerLable_Click(object sender, EventArgs e)
        {
            if (rightChildViewerLable.Text != "null")
            {
                FillTreeViewer(tree.FindTreeNodeByValue(double.Parse(rightChildViewerLable.Text)));
            }
        }
    }
}
