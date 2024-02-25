namespace NoteBook
{
    partial class NoteBook
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBook));
            this.menuNoteBook = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveChange = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveToComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNotice = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuNoteBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNoteBook
            // 
            this.menuNoteBook.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuNoteBook.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuNoteBook.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNoteBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.ToolStripMenuItemNotice});
            this.menuNoteBook.Location = new System.Drawing.Point(0, 0);
            this.menuNoteBook.Name = "menuNoteBook";
            this.menuNoteBook.Size = new System.Drawing.Size(800, 28);
            this.menuNoteBook.TabIndex = 0;
            this.menuNoteBook.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemSaveChange,
            this.ToolStripMenuItemSaveToComputer,
            this.ToolStripMenuItemOpen,
            this.ToolStripMenuItemPrint,
            this.ToolStripMenuItemExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(278, 26);
            this.ToolStripMenuItemNew.Text = "Создать";
            this.ToolStripMenuItemNew.ToolTipText = "Создать новый файл";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemCreate_Click);
            // 
            // ToolStripMenuItemSaveChange
            // 
            this.ToolStripMenuItemSaveChange.Name = "ToolStripMenuItemSaveChange";
            this.ToolStripMenuItemSaveChange.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSaveChange.Size = new System.Drawing.Size(278, 26);
            this.ToolStripMenuItemSaveChange.Text = "Сохранить";
            this.ToolStripMenuItemSaveChange.Click += new System.EventHandler(this.ToolStripMenuItemSaveChange_Click);
            // 
            // ToolStripMenuItemSaveToComputer
            // 
            this.ToolStripMenuItemSaveToComputer.Name = "ToolStripMenuItemSaveToComputer";
            this.ToolStripMenuItemSaveToComputer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ToolStripMenuItemSaveToComputer.Size = new System.Drawing.Size(278, 26);
            this.ToolStripMenuItemSaveToComputer.Text = "Сохранить как";
            this.ToolStripMenuItemSaveToComputer.ToolTipText = "Сохранить файл на компьютер";
            this.ToolStripMenuItemSaveToComputer.Click += new System.EventHandler(this.ToolStripMenuItemSafe_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(278, 26);
            this.ToolStripMenuItemOpen.Text = "Открыть";
            this.ToolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // ToolStripMenuItemPrint
            // 
            this.ToolStripMenuItemPrint.Name = "ToolStripMenuItemPrint";
            this.ToolStripMenuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ToolStripMenuItemPrint.Size = new System.Drawing.Size(278, 26);
            this.ToolStripMenuItemPrint.Text = "Печать";
            this.ToolStripMenuItemPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolStripMenuItemPrint.Click += new System.EventHandler(this.ToolStripMenuItemPrint_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(278, 26);
            this.ToolStripMenuItemExit.Text = "Выход";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemChangeColor,
            this.ToolStripMenuItemFont});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // ToolStripMenuItemChangeColor
            // 
            this.ToolStripMenuItemChangeColor.Name = "ToolStripMenuItemChangeColor";
            this.ToolStripMenuItemChangeColor.Size = new System.Drawing.Size(178, 26);
            this.ToolStripMenuItemChangeColor.Text = "Изменить цвет";
            this.ToolStripMenuItemChangeColor.Click += new System.EventHandler(this.ToolStripMenuItemChangeColor_Click);
            // 
            // ToolStripMenuItemFont
            // 
            this.ToolStripMenuItemFont.Name = "ToolStripMenuItemFont";
            this.ToolStripMenuItemFont.Size = new System.Drawing.Size(178, 26);
            this.ToolStripMenuItemFont.Text = "Шрифт";
            this.ToolStripMenuItemFont.Click += new System.EventHandler(this.ToolStripMenuItemFont_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPut,
            this.ToolStripMenuItemCut,
            this.ToolStripMenuItemCopy});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // ToolStripMenuItemPut
            // 
            this.ToolStripMenuItemPut.Name = "ToolStripMenuItemPut";
            this.ToolStripMenuItemPut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ToolStripMenuItemPut.Size = new System.Drawing.Size(218, 26);
            this.ToolStripMenuItemPut.Text = "Вставить";
            this.ToolStripMenuItemPut.Click += new System.EventHandler(this.ToolStripMenuItemPaste_Click);
            // 
            // ToolStripMenuItemCut
            // 
            this.ToolStripMenuItemCut.Name = "ToolStripMenuItemCut";
            this.ToolStripMenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ToolStripMenuItemCut.Size = new System.Drawing.Size(218, 26);
            this.ToolStripMenuItemCut.Text = "Вырезать";
            this.ToolStripMenuItemCut.Click += new System.EventHandler(this.ToolStripMenuItemCut_Click);
            // 
            // ToolStripMenuItemCopy
            // 
            this.ToolStripMenuItemCopy.Name = "ToolStripMenuItemCopy";
            this.ToolStripMenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ToolStripMenuItemCopy.Size = new System.Drawing.Size(218, 26);
            this.ToolStripMenuItemCopy.Text = "Копировать";
            this.ToolStripMenuItemCopy.Click += new System.EventHandler(this.ToolStripMenuItemCopy_Click);
            // 
            // ToolStripMenuItemNotice
            // 
            this.ToolStripMenuItemNotice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInfo});
            this.ToolStripMenuItemNotice.Name = "ToolStripMenuItemNotice";
            this.ToolStripMenuItemNotice.Size = new System.Drawing.Size(74, 24);
            this.ToolStripMenuItemNotice.Text = "Справка";
            // 
            // ToolStripMenuItemInfo
            // 
            this.ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            this.ToolStripMenuItemInfo.Size = new System.Drawing.Size(216, 26);
            this.ToolStripMenuItemInfo.Text = "О программе";
            this.ToolStripMenuItemInfo.Click += new System.EventHandler(this.ToolStripMenuItem_Click_ProgramInfo);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 422);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Tag = "";
            this.richTextBox1.Text = "";
            // 
            // NoteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuNoteBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuNoteBook;
            this.Name = "NoteBook";
            this.Text = "Блокнот";
            this.menuNoteBook.ResumeLayout(false);
            this.menuNoteBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuNoteBook;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveToComputer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFont;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPrint;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNotice;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveChange;
    }
}

