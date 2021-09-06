namespace WindowsFormsApplication3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nodesListBox = new System.Windows.Forms.ListBox();
            this.preOrderLabel = new System.Windows.Forms.Label();
            this.inOrderLable = new System.Windows.Forms.Label();
            this.postOrderLable = new System.Windows.Forms.Label();
            this.preOrders = new System.Windows.Forms.Label();
            this.inOrders = new System.Windows.Forms.Label();
            this.postOrders = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.finderGroupBox = new System.Windows.Forms.GroupBox();
            this.finderPictureBox = new System.Windows.Forms.PictureBox();
            this.keyValueLable = new System.Windows.Forms.Label();
            this.finderLabel = new System.Windows.Forms.Label();
            this.finderTextBox = new System.Windows.Forms.TextBox();
            this.findByValueRadioButton = new System.Windows.Forms.RadioButton();
            this.findByKeyRadioButton = new System.Windows.Forms.RadioButton();
            this.finderButton = new System.Windows.Forms.Button();
            this.InsertGroupBox = new System.Windows.Forms.GroupBox();
            this.insertPictureBox = new System.Windows.Forms.PictureBox();
            this.wordLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.ordersGroupBox = new System.Windows.Forms.GroupBox();
            this.certainIntegerWordsListBox = new System.Windows.Forms.ListBox();
            this.certainIntegerWordsGroupBox = new System.Windows.Forms.GroupBox();
            this.certainIntegerPictureBox = new System.Windows.Forms.PictureBox();
            this.certainIntegerWordsTextBox = new System.Windows.Forms.TextBox();
            this.intValueLable = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.generalDataGroupBox = new System.Windows.Forms.GroupBox();
            this.mostLoadedTreeNodeLable = new System.Windows.Forms.Label();
            this.mostLoadedTreeNodeLable1 = new System.Windows.Forms.Label();
            this.nodesCountLable = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.rootValueLable = new System.Windows.Forms.Label();
            this.nodesCountLable1 = new System.Windows.Forms.Label();
            this.heightLable1 = new System.Windows.Forms.Label();
            this.rootValueLable1 = new System.Windows.Forms.Label();
            this.selectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedItemPictureBox = new System.Windows.Forms.PictureBox();
            this.membersLable = new System.Windows.Forms.Label();
            this.membersLable1 = new System.Windows.Forms.Label();
            this.rightChildLable = new System.Windows.Forms.Label();
            this.leftChildLable = new System.Windows.Forms.Label();
            this.parentLable = new System.Windows.Forms.Label();
            this.rightChildLable1 = new System.Windows.Forms.Label();
            this.leftChildLabel1 = new System.Windows.Forms.Label();
            this.parentLabel1 = new System.Windows.Forms.Label();
            this.inOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.inOrderMembersictureBox = new System.Windows.Forms.PictureBox();
            this.inOrderListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.nodesPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.goodByePictureBox = new System.Windows.Forms.PictureBox();
            this.printButton = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.treeViewerGroupBox = new System.Windows.Forms.GroupBox();
            this.treeViewerPictureBox = new System.Windows.Forms.PictureBox();
            this.parentViewerLable = new System.Windows.Forms.Label();
            this.rightChildViewerLable = new System.Windows.Forms.Label();
            this.leftChildViewerLable = new System.Windows.Forms.Label();
            this.currentViewerLable = new System.Windows.Forms.Label();
            this.finderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finderPictureBox)).BeginInit();
            this.InsertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertPictureBox)).BeginInit();
            this.ordersGroupBox.SuspendLayout();
            this.certainIntegerWordsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certainIntegerPictureBox)).BeginInit();
            this.generalDataGroupBox.SuspendLayout();
            this.selectedItemGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemPictureBox)).BeginInit();
            this.inOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inOrderMembersictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodByePictureBox)).BeginInit();
            this.treeViewerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nodesListBox
            // 
            this.nodesListBox.FormattingEnabled = true;
            this.nodesListBox.ItemHeight = 16;
            this.nodesListBox.Location = new System.Drawing.Point(15, 15);
            this.nodesListBox.Name = "nodesListBox";
            this.nodesListBox.Size = new System.Drawing.Size(242, 276);
            this.nodesListBox.TabIndex = 30;
            this.nodesListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nodesListBox_MouseClick);
            // 
            // preOrderLabel
            // 
            this.preOrderLabel.AutoSize = true;
            this.preOrderLabel.Location = new System.Drawing.Point(17, 28);
            this.preOrderLabel.Name = "preOrderLabel";
            this.preOrderLabel.Size = new System.Drawing.Size(68, 17);
            this.preOrderLabel.TabIndex = 28;
            this.preOrderLabel.Text = "Preorder:";
            // 
            // inOrderLable
            // 
            this.inOrderLable.AutoSize = true;
            this.inOrderLable.Location = new System.Drawing.Point(17, 54);
            this.inOrderLable.Name = "inOrderLable";
            this.inOrderLable.Size = new System.Drawing.Size(57, 17);
            this.inOrderLable.TabIndex = 27;
            this.inOrderLable.Text = "Inorder:";
            // 
            // postOrderLable
            // 
            this.postOrderLable.AutoSize = true;
            this.postOrderLable.Location = new System.Drawing.Point(17, 81);
            this.postOrderLable.Name = "postOrderLable";
            this.postOrderLable.Size = new System.Drawing.Size(74, 17);
            this.postOrderLable.TabIndex = 26;
            this.postOrderLable.Text = "Postorder:";
            // 
            // preOrders
            // 
            this.preOrders.AutoSize = true;
            this.preOrders.Location = new System.Drawing.Point(120, 28);
            this.preOrders.Name = "preOrders";
            this.preOrders.Size = new System.Drawing.Size(0, 17);
            this.preOrders.TabIndex = 4;
            // 
            // inOrders
            // 
            this.inOrders.AutoSize = true;
            this.inOrders.Location = new System.Drawing.Point(120, 54);
            this.inOrders.Name = "inOrders";
            this.inOrders.Size = new System.Drawing.Size(0, 17);
            this.inOrders.TabIndex = 5;
            // 
            // postOrders
            // 
            this.postOrders.AutoSize = true;
            this.postOrders.Location = new System.Drawing.Point(120, 81);
            this.postOrders.Name = "postOrders";
            this.postOrders.Size = new System.Drawing.Size(0, 17);
            this.postOrders.TabIndex = 6;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(81, 33);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 22);
            this.valueTextBox.TabIndex = 0;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(67, 103);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(81, 61);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(100, 22);
            this.keyTextBox.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(85, 152);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // finderGroupBox
            // 
            this.finderGroupBox.Controls.Add(this.finderPictureBox);
            this.finderGroupBox.Controls.Add(this.keyValueLable);
            this.finderGroupBox.Controls.Add(this.finderLabel);
            this.finderGroupBox.Controls.Add(this.finderTextBox);
            this.finderGroupBox.Controls.Add(this.findByValueRadioButton);
            this.finderGroupBox.Controls.Add(this.findByKeyRadioButton);
            this.finderGroupBox.Controls.Add(this.finderButton);
            this.finderGroupBox.Location = new System.Drawing.Point(791, 140);
            this.finderGroupBox.Name = "finderGroupBox";
            this.finderGroupBox.Size = new System.Drawing.Size(230, 172);
            this.finderGroupBox.TabIndex = 24;
            this.finderGroupBox.TabStop = false;
            this.finderGroupBox.Text = "Finder";
            // 
            // finderPictureBox
            // 
            this.finderPictureBox.Location = new System.Drawing.Point(205, 12);
            this.finderPictureBox.Name = "finderPictureBox";
            this.finderPictureBox.Size = new System.Drawing.Size(20, 20);
            this.finderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finderPictureBox.TabIndex = 37;
            this.finderPictureBox.TabStop = false;
            this.finderPictureBox.MouseHover += new System.EventHandler(this.finderPictureBox_MouseHover);
            // 
            // keyValueLable
            // 
            this.keyValueLable.AutoSize = true;
            this.keyValueLable.Location = new System.Drawing.Point(19, 136);
            this.keyValueLable.Name = "keyValueLable";
            this.keyValueLable.Size = new System.Drawing.Size(86, 17);
            this.keyValueLable.TabIndex = 23;
            this.keyValueLable.Text = "Word/Value:";
            // 
            // finderLabel
            // 
            this.finderLabel.AutoSize = true;
            this.finderLabel.Location = new System.Drawing.Point(120, 136);
            this.finderLabel.Name = "finderLabel";
            this.finderLabel.Size = new System.Drawing.Size(0, 17);
            this.finderLabel.TabIndex = 4;
            // 
            // finderTextBox
            // 
            this.finderTextBox.Location = new System.Drawing.Point(20, 98);
            this.finderTextBox.Name = "finderTextBox";
            this.finderTextBox.Size = new System.Drawing.Size(100, 22);
            this.finderTextBox.TabIndex = 5;
            this.finderTextBox.Text = "Type here";
            this.finderTextBox.Enter += new System.EventHandler(this.finderTextBox_Enter);
            // 
            // findByValueRadioButton
            // 
            this.findByValueRadioButton.AutoSize = true;
            this.findByValueRadioButton.Location = new System.Drawing.Point(19, 58);
            this.findByValueRadioButton.Name = "findByValueRadioButton";
            this.findByValueRadioButton.Size = new System.Drawing.Size(113, 21);
            this.findByValueRadioButton.TabIndex = 4;
            this.findByValueRadioButton.Text = "Find by value";
            this.findByValueRadioButton.UseVisualStyleBackColor = true;
            this.findByValueRadioButton.Click += new System.EventHandler(this.findByValueRadioButton_Click);
            // 
            // findByKeyRadioButton
            // 
            this.findByKeyRadioButton.AutoSize = true;
            this.findByKeyRadioButton.Checked = true;
            this.findByKeyRadioButton.Location = new System.Drawing.Point(19, 31);
            this.findByKeyRadioButton.Name = "findByKeyRadioButton";
            this.findByKeyRadioButton.Size = new System.Drawing.Size(109, 21);
            this.findByKeyRadioButton.TabIndex = 3;
            this.findByKeyRadioButton.TabStop = true;
            this.findByKeyRadioButton.Text = "Find by word";
            this.findByKeyRadioButton.UseVisualStyleBackColor = true;
            this.findByKeyRadioButton.Click += new System.EventHandler(this.findByKeyRadioButton_Click);
            // 
            // finderButton
            // 
            this.finderButton.Location = new System.Drawing.Point(138, 97);
            this.finderButton.Name = "finderButton";
            this.finderButton.Size = new System.Drawing.Size(75, 23);
            this.finderButton.TabIndex = 6;
            this.finderButton.Text = "Find";
            this.finderButton.UseVisualStyleBackColor = true;
            this.finderButton.Click += new System.EventHandler(this.finderButton_Click);
            // 
            // InsertGroupBox
            // 
            this.InsertGroupBox.Controls.Add(this.insertPictureBox);
            this.InsertGroupBox.Controls.Add(this.wordLabel);
            this.InsertGroupBox.Controls.Add(this.valueLabel);
            this.InsertGroupBox.Controls.Add(this.valueTextBox);
            this.InsertGroupBox.Controls.Add(this.keyTextBox);
            this.InsertGroupBox.Controls.Add(this.insertButton);
            this.InsertGroupBox.Location = new System.Drawing.Point(563, 140);
            this.InsertGroupBox.Name = "InsertGroupBox";
            this.InsertGroupBox.Size = new System.Drawing.Size(205, 172);
            this.InsertGroupBox.TabIndex = 25;
            this.InsertGroupBox.TabStop = false;
            this.InsertGroupBox.Text = "Insert";
            // 
            // insertPictureBox
            // 
            this.insertPictureBox.Location = new System.Drawing.Point(180, 12);
            this.insertPictureBox.Name = "insertPictureBox";
            this.insertPictureBox.Size = new System.Drawing.Size(20, 20);
            this.insertPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.insertPictureBox.TabIndex = 38;
            this.insertPictureBox.TabStop = false;
            this.insertPictureBox.MouseHover += new System.EventHandler(this.insertPictureBox_MouseHover);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(16, 64);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(46, 17);
            this.wordLabel.TabIndex = 11;
            this.wordLabel.Text = "Word:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(15, 33);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(48, 17);
            this.valueLabel.TabIndex = 10;
            this.valueLabel.Text = "Value:";
            // 
            // ordersGroupBox
            // 
            this.ordersGroupBox.Controls.Add(this.preOrderLabel);
            this.ordersGroupBox.Controls.Add(this.inOrderLable);
            this.ordersGroupBox.Controls.Add(this.postOrderLable);
            this.ordersGroupBox.Controls.Add(this.preOrders);
            this.ordersGroupBox.Controls.Add(this.postOrders);
            this.ordersGroupBox.Controls.Add(this.inOrders);
            this.ordersGroupBox.Location = new System.Drawing.Point(563, 15);
            this.ordersGroupBox.Name = "ordersGroupBox";
            this.ordersGroupBox.Size = new System.Drawing.Size(686, 112);
            this.ordersGroupBox.TabIndex = 29;
            this.ordersGroupBox.TabStop = false;
            this.ordersGroupBox.Text = "BST Orders";
            // 
            // certainIntegerWordsListBox
            // 
            this.certainIntegerWordsListBox.FormattingEnabled = true;
            this.certainIntegerWordsListBox.ItemHeight = 16;
            this.certainIntegerWordsListBox.Location = new System.Drawing.Point(17, 37);
            this.certainIntegerWordsListBox.Name = "certainIntegerWordsListBox";
            this.certainIntegerWordsListBox.Size = new System.Drawing.Size(168, 244);
            this.certainIntegerWordsListBox.TabIndex = 21;
            // 
            // certainIntegerWordsGroupBox
            // 
            this.certainIntegerWordsGroupBox.Controls.Add(this.certainIntegerPictureBox);
            this.certainIntegerWordsGroupBox.Controls.Add(this.certainIntegerWordsTextBox);
            this.certainIntegerWordsGroupBox.Controls.Add(this.intValueLable);
            this.certainIntegerWordsGroupBox.Controls.Add(this.viewButton);
            this.certainIntegerWordsGroupBox.Controls.Add(this.certainIntegerWordsListBox);
            this.certainIntegerWordsGroupBox.Location = new System.Drawing.Point(1043, 140);
            this.certainIntegerWordsGroupBox.Name = "certainIntegerWordsGroupBox";
            this.certainIntegerWordsGroupBox.Size = new System.Drawing.Size(206, 356);
            this.certainIntegerWordsGroupBox.TabIndex = 22;
            this.certainIntegerWordsGroupBox.TabStop = false;
            this.certainIntegerWordsGroupBox.Text = "View Certain Integer Words";
            // 
            // certainIntegerPictureBox
            // 
            this.certainIntegerPictureBox.Location = new System.Drawing.Point(181, 12);
            this.certainIntegerPictureBox.Name = "certainIntegerPictureBox";
            this.certainIntegerPictureBox.Size = new System.Drawing.Size(20, 20);
            this.certainIntegerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.certainIntegerPictureBox.TabIndex = 36;
            this.certainIntegerPictureBox.TabStop = false;
            this.certainIntegerPictureBox.MouseHover += new System.EventHandler(this.certainIntegerPictureBox_MouseHover);
            // 
            // certainIntegerWordsTextBox
            // 
            this.certainIntegerWordsTextBox.Location = new System.Drawing.Point(128, 293);
            this.certainIntegerWordsTextBox.Name = "certainIntegerWordsTextBox";
            this.certainIntegerWordsTextBox.Size = new System.Drawing.Size(57, 22);
            this.certainIntegerWordsTextBox.TabIndex = 7;
            // 
            // intValueLable
            // 
            this.intValueLable.AutoSize = true;
            this.intValueLable.Location = new System.Drawing.Point(14, 293);
            this.intValueLable.Name = "intValueLable";
            this.intValueLable.Size = new System.Drawing.Size(96, 17);
            this.intValueLable.TabIndex = 22;
            this.intValueLable.Text = "Integer Value:";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(62, 324);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 8;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // generalDataGroupBox
            // 
            this.generalDataGroupBox.Controls.Add(this.mostLoadedTreeNodeLable);
            this.generalDataGroupBox.Controls.Add(this.mostLoadedTreeNodeLable1);
            this.generalDataGroupBox.Controls.Add(this.nodesCountLable);
            this.generalDataGroupBox.Controls.Add(this.heightLabel);
            this.generalDataGroupBox.Controls.Add(this.rootValueLable);
            this.generalDataGroupBox.Controls.Add(this.nodesCountLable1);
            this.generalDataGroupBox.Controls.Add(this.heightLable1);
            this.generalDataGroupBox.Controls.Add(this.rootValueLable1);
            this.generalDataGroupBox.Location = new System.Drawing.Point(563, 318);
            this.generalDataGroupBox.Name = "generalDataGroupBox";
            this.generalDataGroupBox.Size = new System.Drawing.Size(458, 148);
            this.generalDataGroupBox.TabIndex = 18;
            this.generalDataGroupBox.TabStop = false;
            this.generalDataGroupBox.Text = "General BST\'s Data";
            // 
            // mostLoadedTreeNodeLable
            // 
            this.mostLoadedTreeNodeLable.AutoSize = true;
            this.mostLoadedTreeNodeLable.Location = new System.Drawing.Point(259, 115);
            this.mostLoadedTreeNodeLable.Name = "mostLoadedTreeNodeLable";
            this.mostLoadedTreeNodeLable.Size = new System.Drawing.Size(0, 17);
            this.mostLoadedTreeNodeLable.TabIndex = 26;
            // 
            // mostLoadedTreeNodeLable1
            // 
            this.mostLoadedTreeNodeLable1.AutoSize = true;
            this.mostLoadedTreeNodeLable1.Location = new System.Drawing.Point(18, 115);
            this.mostLoadedTreeNodeLable1.Name = "mostLoadedTreeNodeLable1";
            this.mostLoadedTreeNodeLable1.Size = new System.Drawing.Size(166, 17);
            this.mostLoadedTreeNodeLable1.TabIndex = 14;
            this.mostLoadedTreeNodeLable1.Text = "Most Loaded Tree Node:";
            // 
            // nodesCountLable
            // 
            this.nodesCountLable.AutoSize = true;
            this.nodesCountLable.Location = new System.Drawing.Point(259, 86);
            this.nodesCountLable.Name = "nodesCountLable";
            this.nodesCountLable.Size = new System.Drawing.Size(0, 17);
            this.nodesCountLable.TabIndex = 23;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(259, 57);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(0, 17);
            this.heightLabel.TabIndex = 22;
            // 
            // rootValueLable
            // 
            this.rootValueLable.AutoSize = true;
            this.rootValueLable.Location = new System.Drawing.Point(259, 29);
            this.rootValueLable.Name = "rootValueLable";
            this.rootValueLable.Size = new System.Drawing.Size(0, 17);
            this.rootValueLable.TabIndex = 21;
            // 
            // nodesCountLable1
            // 
            this.nodesCountLable1.AutoSize = true;
            this.nodesCountLable1.Location = new System.Drawing.Point(17, 86);
            this.nodesCountLable1.Name = "nodesCountLable1";
            this.nodesCountLable1.Size = new System.Drawing.Size(94, 17);
            this.nodesCountLable1.TabIndex = 15;
            this.nodesCountLable1.Text = "Nodes Count:";
            // 
            // heightLable1
            // 
            this.heightLable1.AutoSize = true;
            this.heightLable1.Location = new System.Drawing.Point(17, 57);
            this.heightLable1.Name = "heightLable1";
            this.heightLable1.Size = new System.Drawing.Size(53, 17);
            this.heightLable1.TabIndex = 16;
            this.heightLable1.Text = "Height:";
            // 
            // rootValueLable1
            // 
            this.rootValueLable1.AutoSize = true;
            this.rootValueLable1.Location = new System.Drawing.Point(17, 29);
            this.rootValueLable1.Name = "rootValueLable1";
            this.rootValueLable1.Size = new System.Drawing.Size(82, 17);
            this.rootValueLable1.TabIndex = 17;
            this.rootValueLable1.Text = "Root Value:";
            // 
            // selectedItemGroupBox
            // 
            this.selectedItemGroupBox.Controls.Add(this.selectedItemPictureBox);
            this.selectedItemGroupBox.Controls.Add(this.membersLable);
            this.selectedItemGroupBox.Controls.Add(this.membersLable1);
            this.selectedItemGroupBox.Controls.Add(this.rightChildLable);
            this.selectedItemGroupBox.Controls.Add(this.leftChildLable);
            this.selectedItemGroupBox.Controls.Add(this.parentLable);
            this.selectedItemGroupBox.Controls.Add(this.rightChildLable1);
            this.selectedItemGroupBox.Controls.Add(this.removeButton);
            this.selectedItemGroupBox.Controls.Add(this.leftChildLabel1);
            this.selectedItemGroupBox.Controls.Add(this.parentLabel1);
            this.selectedItemGroupBox.Location = new System.Drawing.Point(15, 303);
            this.selectedItemGroupBox.Name = "selectedItemGroupBox";
            this.selectedItemGroupBox.Size = new System.Drawing.Size(242, 193);
            this.selectedItemGroupBox.TabIndex = 31;
            this.selectedItemGroupBox.TabStop = false;
            this.selectedItemGroupBox.Text = "Selected Item\'s Info";
            // 
            // selectedItemPictureBox
            // 
            this.selectedItemPictureBox.Location = new System.Drawing.Point(217, 12);
            this.selectedItemPictureBox.Name = "selectedItemPictureBox";
            this.selectedItemPictureBox.Size = new System.Drawing.Size(20, 20);
            this.selectedItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectedItemPictureBox.TabIndex = 37;
            this.selectedItemPictureBox.TabStop = false;
            this.selectedItemPictureBox.MouseHover += new System.EventHandler(this.selectedItemPictureBox_MouseHover);
            // 
            // membersLable
            // 
            this.membersLable.AutoSize = true;
            this.membersLable.Location = new System.Drawing.Point(179, 111);
            this.membersLable.Name = "membersLable";
            this.membersLable.Size = new System.Drawing.Size(0, 17);
            this.membersLable.TabIndex = 7;
            // 
            // membersLable1
            // 
            this.membersLable1.AutoSize = true;
            this.membersLable1.Location = new System.Drawing.Point(20, 111);
            this.membersLable1.Name = "membersLable1";
            this.membersLable1.Size = new System.Drawing.Size(109, 17);
            this.membersLable1.TabIndex = 35;
            this.membersLable1.Text = "Members count:";
            // 
            // rightChildLable
            // 
            this.rightChildLable.AutoSize = true;
            this.rightChildLable.Location = new System.Drawing.Point(179, 85);
            this.rightChildLable.Name = "rightChildLable";
            this.rightChildLable.Size = new System.Drawing.Size(0, 17);
            this.rightChildLable.TabIndex = 5;
            // 
            // leftChildLable
            // 
            this.leftChildLable.AutoSize = true;
            this.leftChildLable.Location = new System.Drawing.Point(179, 59);
            this.leftChildLable.Name = "leftChildLable";
            this.leftChildLable.Size = new System.Drawing.Size(0, 17);
            this.leftChildLable.TabIndex = 4;
            // 
            // parentLable
            // 
            this.parentLable.AutoSize = true;
            this.parentLable.Location = new System.Drawing.Point(179, 34);
            this.parentLable.Name = "parentLable";
            this.parentLable.Size = new System.Drawing.Size(0, 17);
            this.parentLable.TabIndex = 3;
            // 
            // rightChildLable1
            // 
            this.rightChildLable1.AutoSize = true;
            this.rightChildLable1.Location = new System.Drawing.Point(20, 85);
            this.rightChildLable1.Name = "rightChildLable1";
            this.rightChildLable1.Size = new System.Drawing.Size(80, 17);
            this.rightChildLable1.TabIndex = 34;
            this.rightChildLable1.Text = "Right Child:";
            // 
            // leftChildLabel1
            // 
            this.leftChildLabel1.AutoSize = true;
            this.leftChildLabel1.Location = new System.Drawing.Point(20, 59);
            this.leftChildLabel1.Name = "leftChildLabel1";
            this.leftChildLabel1.Size = new System.Drawing.Size(71, 17);
            this.leftChildLabel1.TabIndex = 33;
            this.leftChildLabel1.Text = "Left Child:";
            // 
            // parentLabel1
            // 
            this.parentLabel1.AutoSize = true;
            this.parentLabel1.Location = new System.Drawing.Point(20, 34);
            this.parentLabel1.Name = "parentLabel1";
            this.parentLabel1.Size = new System.Drawing.Size(54, 17);
            this.parentLabel1.TabIndex = 32;
            this.parentLabel1.Text = "Parent:";
            // 
            // inOrderGroupBox
            // 
            this.inOrderGroupBox.Controls.Add(this.inOrderMembersictureBox);
            this.inOrderGroupBox.Controls.Add(this.inOrderListBox);
            this.inOrderGroupBox.Location = new System.Drawing.Point(1270, 15);
            this.inOrderGroupBox.Name = "inOrderGroupBox";
            this.inOrderGroupBox.Size = new System.Drawing.Size(200, 481);
            this.inOrderGroupBox.TabIndex = 20;
            this.inOrderGroupBox.TabStop = false;
            this.inOrderGroupBox.Text = "Inorder Members";
            // 
            // inOrderMembersictureBox
            // 
            this.inOrderMembersictureBox.Location = new System.Drawing.Point(175, 12);
            this.inOrderMembersictureBox.Name = "inOrderMembersictureBox";
            this.inOrderMembersictureBox.Size = new System.Drawing.Size(20, 20);
            this.inOrderMembersictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inOrderMembersictureBox.TabIndex = 36;
            this.inOrderMembersictureBox.TabStop = false;
            this.inOrderMembersictureBox.MouseHover += new System.EventHandler(this.inOrderMembersictureBox_MouseHover);
            // 
            // inOrderListBox
            // 
            this.inOrderListBox.FormattingEnabled = true;
            this.inOrderListBox.ItemHeight = 16;
            this.inOrderListBox.Location = new System.Drawing.Point(17, 33);
            this.inOrderListBox.Name = "inOrderListBox";
            this.inOrderListBox.Size = new System.Drawing.Size(165, 436);
            this.inOrderListBox.TabIndex = 19;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(562, 473);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(142, 23);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save As";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nodesPictureBox
            // 
            this.nodesPictureBox.BackColor = System.Drawing.Color.White;
            this.nodesPictureBox.Location = new System.Drawing.Point(232, 20);
            this.nodesPictureBox.Name = "nodesPictureBox";
            this.nodesPictureBox.Size = new System.Drawing.Size(20, 20);
            this.nodesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nodesPictureBox.TabIndex = 34;
            this.nodesPictureBox.TabStop = false;
            this.nodesPictureBox.MouseHover += new System.EventHandler(this.nodesPictureBox_MouseHover);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(881, 473);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(142, 23);
            this.closeButton.TabIndex = 35;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // goodByePictureBox
            // 
            this.goodByePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.goodByePictureBox.Location = new System.Drawing.Point(578, 99);
            this.goodByePictureBox.Name = "goodByePictureBox";
            this.goodByePictureBox.Size = new System.Drawing.Size(299, 280);
            this.goodByePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goodByePictureBox.TabIndex = 36;
            this.goodByePictureBox.TabStop = false;
            this.goodByePictureBox.Visible = false;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(722, 473);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(142, 23);
            this.printButton.TabIndex = 37;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // treeViewerGroupBox
            // 
            this.treeViewerGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treeViewerGroupBox.Controls.Add(this.treeViewerPictureBox);
            this.treeViewerGroupBox.Controls.Add(this.parentViewerLable);
            this.treeViewerGroupBox.Controls.Add(this.rightChildViewerLable);
            this.treeViewerGroupBox.Controls.Add(this.leftChildViewerLable);
            this.treeViewerGroupBox.Controls.Add(this.currentViewerLable);
            this.treeViewerGroupBox.Location = new System.Drawing.Point(272, 15);
            this.treeViewerGroupBox.Name = "treeViewerGroupBox";
            this.treeViewerGroupBox.Size = new System.Drawing.Size(276, 276);
            this.treeViewerGroupBox.TabIndex = 38;
            this.treeViewerGroupBox.TabStop = false;
            this.treeViewerGroupBox.Text = "Tree Viewer";
            // 
            // treeViewerPictureBox
            // 
            this.treeViewerPictureBox.BackColor = System.Drawing.Color.White;
            this.treeViewerPictureBox.Location = new System.Drawing.Point(251, 12);
            this.treeViewerPictureBox.Name = "treeViewerPictureBox";
            this.treeViewerPictureBox.Size = new System.Drawing.Size(20, 20);
            this.treeViewerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treeViewerPictureBox.TabIndex = 39;
            this.treeViewerPictureBox.TabStop = false;
            this.treeViewerPictureBox.MouseHover += new System.EventHandler(this.treeViewerPictureBox_MouseHover);
            // 
            // parentViewerLable
            // 
            this.parentViewerLable.AutoSize = true;
            this.parentViewerLable.BackColor = System.Drawing.Color.White;
            this.parentViewerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentViewerLable.Location = new System.Drawing.Point(123, 27);
            this.parentViewerLable.Name = "parentViewerLable";
            this.parentViewerLable.Size = new System.Drawing.Size(0, 18);
            this.parentViewerLable.TabIndex = 3;
            this.parentViewerLable.Click += new System.EventHandler(this.parentViewerLable_Click);
            // 
            // rightChildViewerLable
            // 
            this.rightChildViewerLable.AutoSize = true;
            this.rightChildViewerLable.BackColor = System.Drawing.Color.White;
            this.rightChildViewerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightChildViewerLable.Location = new System.Drawing.Point(212, 212);
            this.rightChildViewerLable.Name = "rightChildViewerLable";
            this.rightChildViewerLable.Size = new System.Drawing.Size(0, 18);
            this.rightChildViewerLable.TabIndex = 2;
            this.rightChildViewerLable.Click += new System.EventHandler(this.rightChildViewerLable_Click);
            // 
            // leftChildViewerLable
            // 
            this.leftChildViewerLable.AutoSize = true;
            this.leftChildViewerLable.BackColor = System.Drawing.Color.White;
            this.leftChildViewerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftChildViewerLable.Location = new System.Drawing.Point(34, 212);
            this.leftChildViewerLable.Name = "leftChildViewerLable";
            this.leftChildViewerLable.Size = new System.Drawing.Size(0, 18);
            this.leftChildViewerLable.TabIndex = 1;
            this.leftChildViewerLable.Click += new System.EventHandler(this.leftChildViewerLable_Click);
            // 
            // currentViewerLable
            // 
            this.currentViewerLable.AutoSize = true;
            this.currentViewerLable.BackColor = System.Drawing.Color.White;
            this.currentViewerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentViewerLable.Location = new System.Drawing.Point(122, 127);
            this.currentViewerLable.Name = "currentViewerLable";
            this.currentViewerLable.Size = new System.Drawing.Size(0, 18);
            this.currentViewerLable.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 507);
            this.Controls.Add(this.treeViewerGroupBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nodesPictureBox);
            this.Controls.Add(this.goodByePictureBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inOrderGroupBox);
            this.Controls.Add(this.selectedItemGroupBox);
            this.Controls.Add(this.generalDataGroupBox);
            this.Controls.Add(this.certainIntegerWordsGroupBox);
            this.Controls.Add(this.ordersGroupBox);
            this.Controls.Add(this.InsertGroupBox);
            this.Controls.Add(this.finderGroupBox);
            this.Controls.Add(this.nodesListBox);
            this.Name = "Form2";
            this.Text = "Project Dictionery";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.finderGroupBox.ResumeLayout(false);
            this.finderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finderPictureBox)).EndInit();
            this.InsertGroupBox.ResumeLayout(false);
            this.InsertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insertPictureBox)).EndInit();
            this.ordersGroupBox.ResumeLayout(false);
            this.ordersGroupBox.PerformLayout();
            this.certainIntegerWordsGroupBox.ResumeLayout(false);
            this.certainIntegerWordsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certainIntegerPictureBox)).EndInit();
            this.generalDataGroupBox.ResumeLayout(false);
            this.generalDataGroupBox.PerformLayout();
            this.selectedItemGroupBox.ResumeLayout(false);
            this.selectedItemGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemPictureBox)).EndInit();
            this.inOrderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inOrderMembersictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodByePictureBox)).EndInit();
            this.treeViewerGroupBox.ResumeLayout(false);
            this.treeViewerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox nodesListBox;
        private System.Windows.Forms.Label preOrderLabel;
        private System.Windows.Forms.Label inOrderLable;
        private System.Windows.Forms.Label postOrderLable;
        private System.Windows.Forms.Label preOrders;
        private System.Windows.Forms.Label inOrders;
        private System.Windows.Forms.Label postOrders;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox finderGroupBox;
        private System.Windows.Forms.Label finderLabel;
        private System.Windows.Forms.TextBox finderTextBox;
        private System.Windows.Forms.RadioButton findByValueRadioButton;
        private System.Windows.Forms.RadioButton findByKeyRadioButton;
        private System.Windows.Forms.Button finderButton;
        private System.Windows.Forms.GroupBox InsertGroupBox;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.GroupBox ordersGroupBox;
        private System.Windows.Forms.Label keyValueLable;
        private System.Windows.Forms.ListBox certainIntegerWordsListBox;
        private System.Windows.Forms.GroupBox certainIntegerWordsGroupBox;
        private System.Windows.Forms.TextBox certainIntegerWordsTextBox;
        private System.Windows.Forms.Label intValueLable;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.GroupBox generalDataGroupBox;
        private System.Windows.Forms.GroupBox selectedItemGroupBox;
        private System.Windows.Forms.Label membersLable;
        private System.Windows.Forms.Label membersLable1;
        private System.Windows.Forms.Label rightChildLable;
        private System.Windows.Forms.Label leftChildLable;
        private System.Windows.Forms.Label parentLable;
        private System.Windows.Forms.Label rightChildLable1;
        private System.Windows.Forms.Label leftChildLabel1;
        private System.Windows.Forms.Label parentLabel1;
        private System.Windows.Forms.GroupBox inOrderGroupBox;
        private System.Windows.Forms.ListBox inOrderListBox;
        private System.Windows.Forms.Label nodesCountLable1;
        private System.Windows.Forms.Label heightLable1;
        private System.Windows.Forms.Label rootValueLable1;
        private System.Windows.Forms.Label nodesCountLable;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label rootValueLable;
        private System.Windows.Forms.Label mostLoadedTreeNodeLable1;
        private System.Windows.Forms.Label mostLoadedTreeNodeLable;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox finderPictureBox;
        private System.Windows.Forms.PictureBox insertPictureBox;
        private System.Windows.Forms.PictureBox certainIntegerPictureBox;
        private System.Windows.Forms.PictureBox selectedItemPictureBox;
        private System.Windows.Forms.PictureBox inOrderMembersictureBox;
        private System.Windows.Forms.PictureBox nodesPictureBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox goodByePictureBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox treeViewerGroupBox;
        private System.Windows.Forms.Label parentViewerLable;
        private System.Windows.Forms.Label rightChildViewerLable;
        private System.Windows.Forms.Label leftChildViewerLable;
        private System.Windows.Forms.Label currentViewerLable;
        private System.Windows.Forms.PictureBox treeViewerPictureBox;
    }
}