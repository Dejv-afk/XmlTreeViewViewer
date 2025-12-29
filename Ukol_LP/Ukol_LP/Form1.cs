using System.Text;
using System.Windows.Forms.Design;
using System.Linq;
using System.Xml.Linq;

namespace Ukol_LP
{
    public partial class Form1 : Form
    {

        public Form1()  //konstruktor Formuláře Form1
        {
            InitializeComponent();

            // min. velikost okna aplikace
            this.MinimumSize = new Size(1000, 550);

            // nastavení SplitContaineru
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = false;
            splitContainer1.Panel1MinSize = 300;
            splitContainer1.Panel2MinSize = 550;

            //ToolStrip render style
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(24, 24);

            // Registrace všech starších Windows kódování
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
        }

        private XDocument currentDoc; //globální proměnná pro operaci s načteným dokumentem, důležitá hlavně pro uložení změn do nového souboru

        //proměnné pro statistiku souboru
        int maxDepth;
        int maxChildren;
        int minAttributes;
        int maxAttributes;

        // proměnná pro sledování změny souboru
        private bool fileChange = false;

        private string currentFilePath = null;

        // Proměnná pro zachování poměru kontejnerů při zvětšování okna aplikace
        private double splitRatio = 0.5;
        private void UpdateWindowTitle()
        {
            if (currentFilePath == null)
            {
                this.Text = "Form1";
            }
            else
            {
                string file = Path.GetFileName(currentFilePath);
                this.Text = $"Form1 {(fileChange ? "*" : "")}";
            }
        }

        private bool SaveCurrentDocument()
        {
            if (currentDoc == null)
            {
                MessageBox.Show("Nejdřív otevřete soubor.");
                return false;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                sfd.Title = "Ulož XML soubor";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    currentDoc.Save(sfd.FileName);
                    MessageBox.Show("Soubor byl uložen.");

                    fileChange = false;
                    currentFilePath = sfd.FileName;
                    UpdateWindowTitle();
                    return true;   // uloženo
                }
            }

            return false;          // uživatel dal Cancel
        }

        private void ResetUI()
        {
            // Reset stavu souboru
            currentDoc = null;
            currentFilePath = null;
            fileChange = false;
            UpdateWindowTitle();

            // Vymazání TreeView
            treeView1.Nodes.Clear();

            //vymazání reference na dokument
            currentDoc = null;

            // Vymazání labelů
            labelText.Text = "Text: ";
            labelAtributy.Text = "Atributy: ";
            labelZanoreni.Text = "Zanoření: ";
            labelPoradi.Text = "Pořadí mezi sourozenci: ";

            // Vymazání labelů se statistikami
            labelFileName.Text = "Název souboru: ";
            labelMaxDepth.Text = " ";
            labelMaxChildren.Text = " ";
            labelMinAttr.Text = " ";
            labelMaxAttr.Text = " ";

            labelMaxDepth.Text = "Hloubka nejzanořenějšího elementu: ";
            labelMaxChildren.Text = "Max. přímí potomci: ";
            labelMinAttr.Text = "Min. počet atributů, které nějaký element obsahuje: ";
            labelMaxAttr.Text = "Max. počet atributů, které nějaký element obsahuje: ";
        }

        private bool AskToSaveIfNeeded()
        {
            if (!fileChange)
                return true;

            var result = MessageBox.Show(
                "Soubor obsahuje neuložené změny.\nChcete je uložit?",
                "Uložit změny?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool saved = SaveCurrentDocument();
                return saved;      // pokud se neuložilo → false → zruší akci
            }
            else if (result == DialogResult.No)
            {
                return true;       // pokračovat bez uložení
            }

            return false;          // Cancel
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!AskToSaveIfNeeded())
            {
                e.Cancel = true;
                return;
            }

            base.OnFormClosing(e);
        }

        //----------------------
        // toolstrip tlačítka
        //----------------------

        //tlačítko otevřít

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!AskToSaveIfNeeded())
                return; // uživatel dal Cancel

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML soubory (*.xml)|*.xml|Všechny soubory (*.*)|*.*";
            openFileDialog.Title = "Vyberte XML soubor";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ResetUI();

                string filePath = openFileDialog.FileName;
                loadFile(filePath);
            }


        }

        //tlačítko uložit

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveCurrentDocument();
        }

        //tlačítko zavřít

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!AskToSaveIfNeeded())
                return;

            ResetUI();

        }

        // metoda pro analýzu XML souboru
        private void AnalyzeElement(XElement element, int depth)
        {
            // hloubka
            if (depth > maxDepth) maxDepth = depth;

            // počet potomků
            int childCount = element.Elements().Count();
            if (childCount > maxChildren) maxChildren = childCount;

            // počet atributů
            int attrCount = element.Attributes().Count();
            if (attrCount < minAttributes) minAttributes = attrCount;
            if (attrCount > maxAttributes) maxAttributes = attrCount;

            // rekurze na děti
            foreach (var child in element.Elements())
            {
                AnalyzeElement(child, depth + 1);
            }
        }

        private void ShowNodeInfo(TreeNode node)
        {
            if (node == null)
                return;

            XElement element = node.Tag as XElement;

            if (element == null)
            {
                labelText.Text = "Text: ";
                labelAtributy.Text = "Atributy: ";
                labelZanoreni.Text = "Zanoření: ";
                labelPoradi.Text = "Pořadí mezi sourozenci: ";
                return;
            }

            // Text elementu
            if (!element.HasElements && !string.IsNullOrWhiteSpace(element.Value))
                labelText.Text = "Text: " + element.Value;
            else
                labelText.Text = "Text: ";

            // Atributy
            if (element.HasAttributes)
                labelAtributy.Text =
                    "Atributy: " +
                    string.Join("; ", element.Attributes().Select(a => $"{a.Name}={a.Value}"));
            else
                labelAtributy.Text = "Atributy: ";

            // Hloubka elementu (TreeNode.Level začíná od 0 → přičítáme 1)
            labelZanoreni.Text = "Zanoření: " + (node.Level + 1);

            // Pořadí mezi sourozenci 
            int index = node.Index + 1;
            int total =
                node.Parent != null
                    ? node.Parent.Nodes.Count
                    : treeView1.Nodes.Count;

            labelPoradi.Text = $"Pořadí mezi sourozenci: {index} / {total}";
        }

        // Metoda pro zobrazení informací o uzlu po kliknutí myši

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            // Zjisti, kam přesně uživatel klikl
            TreeViewHitTestInfo info = treeView1.HitTest(e.X, e.Y);

            // Kliknutí na + nebo –
            if (info.Location == TreeViewHitTestLocations.PlusMinus)
                return;  // ignoruj → nevypisuj info

            // ošetření vypsání informací pouze po kliknutí přímo na text uzlu
            if (info.Location != TreeViewHitTestLocations.Label)
                return;

            // Skutečné kliknutí na text uzlu → zobraz informace
            XElement element = e.Node.Tag as XElement;
            if (element != null)
            {
                ShowNodeInfo(e.Node);   // metoda, která vypíše informace do labelů
            }
        }



        //----------------------
        // TreeView metody
        //----------------------

        //metoda pro načtení souboru

        private void loadFile(string filePath)
        {
            currentFilePath = filePath;

            // reset změnových příznaků pro nově otevřený soubor
            fileChange = false;
            UpdateWindowTitle();

            // příkazy pro zpracování výjimek (chybových stavů souboru)

            try
            {
                currentDoc = XDocument.Load(filePath);
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show("Soubor se nepodařilo načíst. Zdá se, že je poškozený nebo neplatný XML.\n\n" +
                                "Detail chyby:\n" + ex.Message,
                                "Chyba při načítání XML",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Došlo k chybě při čtení souboru:\n" + ex.Message,
                                "Chyba souboru",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neočekávaná chyba při načítání souboru:\n" + ex.Message,
                                "Chyba",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            //treeView1.Nodes.Clear();



            TreeNode rootNode = new TreeNode(currentDoc.Root.Name.LocalName);
            rootNode.Tag = currentDoc.Root; // tag u kořenového uzlu
            treeView1.Nodes.Add(rootNode);
            addElements(currentDoc.Root, rootNode);
            treeView1.ExpandAll();

            treeView1.SelectedNode = rootNode;
            ShowNodeInfo(rootNode);

            // --- výpočet statistik ---
            maxDepth = 0;
            maxChildren = 0;
            minAttributes = int.MaxValue;
            maxAttributes = 0;

            AnalyzeElement(currentDoc.Root, 1);

            // výpis do labelů se statistikami
            labelFileName.Text = "Název souboru: " + Path.GetFileName(filePath);
            labelMaxDepth.Text = "Hloubka nejzanořenějšího elementu: " + maxDepth;
            labelMaxChildren.Text = "Max. přímí potomci: " + maxChildren;
            labelMinAttr.Text = "Min. počet atributů, které nějaký element obsahuje: " + minAttributes;
            labelMaxAttr.Text = "Min. počet atributů, které nějaký element obsahuje: " + maxAttributes;


            treeView1.SelectedNode = null;
        }

        //metoda pro přidání elementů

        private void addElements(XElement element, TreeNode parentNode)
        {
            foreach (var child in element.Elements())
            {
                // Uzel obsahuje jen název, bez hodnoty
                string nodeText = child.Name.LocalName;

                TreeNode childNode = new TreeNode(nodeText);
                childNode.Tag = child;

                // ikonky
                if (child.HasElements)
                {
                    childNode.ImageIndex = 0;
                    childNode.SelectedImageIndex = 0;
                }
                else
                {
                    childNode.ImageIndex = 1;
                    childNode.SelectedImageIndex = 1;
                }

                parentNode.Nodes.Add(childNode);

                // rekurze pro děti
                addElements(child, childNode);
            }
        }

        // validátor jména XML souboru

        private bool IsValidXmlName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            try
            {
                System.Xml.XmlConvert.VerifyName(name);
                return true;
            }
            catch
            {
                return false;
            }
        }


        // metoda pro editaci uzlů po jednom kliknutí myši

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null)
                return; // uživatel stiskl ESC → žádná změna

            string newName = e.Label.Trim();

            // Validace názvu
            if (!IsValidXmlName(newName))
            {
                MessageBox.Show(
                    "Zadaný název není platný XML element název.\n" +
                    "Ujistěte se, že začíná písmenem nebo podtržítkem a neobsahuje mezery nebo speciální znaky.",
                    "Neplatný název",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                e.CancelEdit = true;      // zruší přejmenování v TreeView
                return;
            }

            // Pokud je vše OK, aktualizujeme i v XDocument
            XElement element = e.Node.Tag as XElement;

            if (element != null)
            {
                try
                {
                    element.Name = newName;   // přepíše jméno elementu v XML dokumentu                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Nepodařilo se změnit název v XML dokumentu:\n" + ex.Message,
                        "Chyba",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    e.CancelEdit = true;
                    return;
                }
            }

            fileChange = true;
            UpdateWindowTitle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelMaxAttr_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitRatio = (double)splitContainer1.Panel1.Width / splitContainer1.Width;
        }

        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = (int)(splitContainer1.Width * splitRatio);
        }

        private void labelFileName_Click(object sender, EventArgs e)
        {

        }
    }
}
