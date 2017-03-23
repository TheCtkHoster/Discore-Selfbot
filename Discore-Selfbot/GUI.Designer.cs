﻿namespace Discore_Selfbot
{
    partial class GUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("self form");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("self test");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("self info");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("self bot");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("self uptime");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("self ping");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("self ping (IP)");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("self guild");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("self user (User ID)");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("self user @Mention");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("self find (User ID)");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("self clean (Ammount)");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("self cleanembed");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Info", new System.Windows.Forms.TreeNode[] {
            treeNode82,
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("self neko");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("self lenny");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("self lewd (Text)");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("self embed (Text)");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("self tembed (Title) (Text)");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Fun", new System.Windows.Forms.TreeNode[] {
            treeNode95,
            treeNode96,
            treeNode97,
            treeNode98,
            treeNode99});
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("self tags");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("self tag (Tag)");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("self addtag (Tag) (Message ID)");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("self addtag (Tag) (Text)");
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("self deltag (Tag)");
            System.Windows.Forms.TreeNode treeNode106 = new System.Windows.Forms.TreeNode("Tags", new System.Windows.Forms.TreeNode[] {
            treeNode101,
            treeNode102,
            treeNode103,
            treeNode104,
            treeNode105});
            System.Windows.Forms.TreeNode treeNode107 = new System.Windows.Forms.TreeNode("self an add (Nickname)");
            System.Windows.Forms.TreeNode treeNode108 = new System.Windows.Forms.TreeNode("self an bind");
            System.Windows.Forms.TreeNode treeNode109 = new System.Windows.Forms.TreeNode("self an del (Nickname)");
            System.Windows.Forms.TreeNode treeNode110 = new System.Windows.Forms.TreeNode("self an list");
            System.Windows.Forms.TreeNode treeNode111 = new System.Windows.Forms.TreeNode("Auto Nickname", new System.Windows.Forms.TreeNode[] {
            treeNode107,
            treeNode108,
            treeNode109,
            treeNode110});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            System.Windows.Forms.TreeNode treeNode112 = new System.Windows.Forms.TreeNode("PixelBot");
            System.Windows.Forms.TreeNode treeNode113 = new System.Windows.Forms.TreeNode("Minotaur");
            System.Windows.Forms.TreeNode treeNode114 = new System.Windows.Forms.TreeNode("My Bots", new System.Windows.Forms.TreeNode[] {
            treeNode112,
            treeNode113});
            System.Windows.Forms.TreeNode treeNode115 = new System.Windows.Forms.TreeNode("Discord Cards");
            System.Windows.Forms.TreeNode treeNode116 = new System.Windows.Forms.TreeNode("Casino Bot");
            System.Windows.Forms.TreeNode treeNode117 = new System.Windows.Forms.TreeNode("Discord RPG");
            System.Windows.Forms.TreeNode treeNode118 = new System.Windows.Forms.TreeNode("Fun Bots", new System.Windows.Forms.TreeNode[] {
            treeNode115,
            treeNode116,
            treeNode117});
            System.Windows.Forms.TreeNode treeNode119 = new System.Windows.Forms.TreeNode("Sekobot");
            System.Windows.Forms.TreeNode treeNode120 = new System.Windows.Forms.TreeNode("Other Bots", new System.Windows.Forms.TreeNode[] {
            treeNode119});
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.BtnTopMin = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonBreadCrumbItem1 = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem();
            this.ChannelList = new System.Windows.Forms.ComboBox();
            this.NavGuild = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.NavEmbedPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextEmbedColor = new System.Windows.Forms.TextBox();
            this.BtnSendActive = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnSendSelected = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EmbedFooter = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.EmbedText = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BtnEmbedColor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EmbedTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BorderEmbed = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavGuildInfoPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextGuildInfo = new System.Windows.Forms.RichTextBox();
            this.NavRolesPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextGuildRoles = new System.Windows.Forms.RichTextBox();
            this.NavPageEmoji = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextGuildEmojis = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BorderMain = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavInfo = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.NavMain = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.NavMoreInfo = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.NavInfoPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BtnOpenSelfbotFolder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LinkDownload = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.TextInfo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.HyperlinkGithub = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkWebsite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkGuild = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.InfoBorder = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavCommandsPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextCommandInfo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ViewCommandsList = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.NavChangelogPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextChangelog = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.NavInfoThemes = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.BtnThemeSparkle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnThemeDark = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnThemeDefault = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BorderTheme = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavInfoSettings = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.HelpFavoriteColor = new System.Windows.Forms.TextBox();
            this.HelpAutoForm = new System.Windows.Forms.TextBox();
            this.HelpCommandMessage = new System.Windows.Forms.TextBox();
            this.HelpAutoNickname = new System.Windows.Forms.TextBox();
            this.TitleAutoNickname = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.TitleFavoriteColor = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.TitleAutoForm = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.TitleCommandMessage = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.BtnAN5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAN10 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAN1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnFavColor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAFNo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnAFYes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCMDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCMEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BorderSettings = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavInfoBots = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.TextBotInfo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.HyperlinkBotInvite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.HyperlinkBotWebsite = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.ViewBotsList = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.BorderBots = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.NavCustomPage = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.CustomEdit = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.CustomDelete = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.CustomAddCustomAdd = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.CustomCommandsList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.OpenFavoriteColor = new System.Windows.Forms.ColorDialog();
            this.StatusActive = new System.Windows.Forms.StatusStrip();
            this.ATitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGName = new System.Windows.Forms.ToolStripStatusLabel();
            this.AGID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACName = new System.Windows.Forms.ToolStripStatusLabel();
            this.ACID = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTipManager = new System.Windows.Forms.ToolTip(this.components);
            this.ThemeManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.BtnOnTop = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.ChannelLogs = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.TextFavColor = new System.Windows.Forms.TextBox();
            this.TextAutoNickname = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TextAutoForm = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TextCommandMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.GuildList = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.NavGuild)).BeginInit();
            this.NavGuild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavEmbedPage)).BeginInit();
            this.NavEmbedPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavGuildInfoPage)).BeginInit();
            this.NavGuildInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavRolesPage)).BeginInit();
            this.NavRolesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavPageEmoji)).BeginInit();
            this.NavPageEmoji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfo)).BeginInit();
            this.NavInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavMain)).BeginInit();
            this.NavMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavMoreInfo)).BeginInit();
            this.NavMoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoPage)).BeginInit();
            this.NavInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavCommandsPage)).BeginInit();
            this.NavCommandsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavChangelogPage)).BeginInit();
            this.NavChangelogPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoThemes)).BeginInit();
            this.NavInfoThemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoSettings)).BeginInit();
            this.NavInfoSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoBots)).BeginInit();
            this.NavInfoBots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavCustomPage)).BeginInit();
            this.NavCustomPage.SuspendLayout();
            this.StatusActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTopMin
            // 
            this.BtnTopMin.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PendantMin;
            this.BtnTopMin.UniqueName = "9F7590E624C945CF989332B94D5B1AAB";
            // 
            // kryptonBreadCrumbItem1
            // 
            this.kryptonBreadCrumbItem1.ShortText = "ListItem";
            // 
            // ChannelList
            // 
            this.ChannelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChannelList.Enabled = false;
            this.ChannelList.FormattingEnabled = true;
            this.ChannelList.Location = new System.Drawing.Point(12, 38);
            this.ChannelList.Name = "ChannelList";
            this.ChannelList.Size = new System.Drawing.Size(220, 21);
            this.ChannelList.TabIndex = 24;
            this.ChannelList.SelectedIndexChanged += new System.EventHandler(this.ChannelList_SelectedIndexChanged);
            // 
            // NavGuild
            // 
            this.NavGuild.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.NavGuild.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.NavGuild.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.NavGuild.Location = new System.Drawing.Point(12, 258);
            this.NavGuild.Name = "NavGuild";
            this.NavGuild.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.NavEmbedPage,
            this.NavGuildInfoPage,
            this.NavRolesPage,
            this.NavPageEmoji});
            this.NavGuild.SelectedIndex = 0;
            this.NavGuild.Size = new System.Drawing.Size(220, 176);
            this.NavGuild.TabIndex = 25;
            this.NavGuild.Text = "kryptonNavigator1";
            // 
            // NavEmbedPage
            // 
            this.NavEmbedPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavEmbedPage.Controls.Add(this.TextEmbedColor);
            this.NavEmbedPage.Controls.Add(this.BtnSendActive);
            this.NavEmbedPage.Controls.Add(this.BtnSendSelected);
            this.NavEmbedPage.Controls.Add(this.EmbedFooter);
            this.NavEmbedPage.Controls.Add(this.EmbedText);
            this.NavEmbedPage.Controls.Add(this.BtnEmbedColor);
            this.NavEmbedPage.Controls.Add(this.EmbedTitle);
            this.NavEmbedPage.Controls.Add(this.BorderEmbed);
            this.NavEmbedPage.Flags = 65534;
            this.NavEmbedPage.LastVisibleSet = true;
            this.NavEmbedPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavEmbedPage.Name = "NavEmbedPage";
            this.NavEmbedPage.Size = new System.Drawing.Size(218, 149);
            this.NavEmbedPage.Text = "Embed";
            this.NavEmbedPage.ToolTipTitle = "Page ToolTip";
            this.NavEmbedPage.UniqueName = "D0784325A0CE45D21CA18507410A4550";
            // 
            // TextEmbedColor
            // 
            this.TextEmbedColor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextEmbedColor.Location = new System.Drawing.Point(165, 3);
            this.TextEmbedColor.Name = "TextEmbedColor";
            this.TextEmbedColor.ReadOnly = true;
            this.TextEmbedColor.Size = new System.Drawing.Size(50, 20);
            this.TextEmbedColor.TabIndex = 15;
            this.TextEmbedColor.Visible = false;
            // 
            // BtnSendActive
            // 
            this.BtnSendActive.Enabled = false;
            this.BtnSendActive.Location = new System.Drawing.Point(118, 90);
            this.BtnSendActive.Name = "BtnSendActive";
            this.BtnSendActive.Size = new System.Drawing.Size(97, 56);
            this.BtnSendActive.TabIndex = 14;
            this.BtnSendActive.Values.Text = "Active";
            this.BtnSendActive.Click += new System.EventHandler(this.BtnSendActive_Click);
            // 
            // BtnSendSelected
            // 
            this.BtnSendSelected.Enabled = false;
            this.BtnSendSelected.Location = new System.Drawing.Point(3, 90);
            this.BtnSendSelected.Name = "BtnSendSelected";
            this.BtnSendSelected.Size = new System.Drawing.Size(97, 56);
            this.BtnSendSelected.TabIndex = 13;
            this.BtnSendSelected.Values.Text = "Selected";
            this.BtnSendSelected.Click += new System.EventHandler(this.BtnSendSelected_Click);
            // 
            // EmbedFooter
            // 
            this.EmbedFooter.Location = new System.Drawing.Point(3, 61);
            this.EmbedFooter.Name = "EmbedFooter";
            this.EmbedFooter.Size = new System.Drawing.Size(156, 23);
            this.EmbedFooter.TabIndex = 12;
            this.EmbedFooter.Text = "Footer";
            // 
            // EmbedText
            // 
            this.EmbedText.Location = new System.Drawing.Point(3, 32);
            this.EmbedText.Name = "EmbedText";
            this.EmbedText.Size = new System.Drawing.Size(156, 23);
            this.EmbedText.TabIndex = 11;
            this.EmbedText.Text = "Text";
            // 
            // BtnEmbedColor
            // 
            this.BtnEmbedColor.Location = new System.Drawing.Point(165, 32);
            this.BtnEmbedColor.Name = "BtnEmbedColor";
            this.BtnEmbedColor.Size = new System.Drawing.Size(50, 52);
            this.BtnEmbedColor.TabIndex = 10;
            this.BtnEmbedColor.Values.Text = "Color";
            this.BtnEmbedColor.Click += new System.EventHandler(this.BtnEmbedColor_Click);
            // 
            // EmbedTitle
            // 
            this.EmbedTitle.Location = new System.Drawing.Point(3, 3);
            this.EmbedTitle.Name = "EmbedTitle";
            this.EmbedTitle.Size = new System.Drawing.Size(156, 23);
            this.EmbedTitle.TabIndex = 9;
            this.EmbedTitle.Text = "Title";
            // 
            // BorderEmbed
            // 
            this.BorderEmbed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderEmbed.Location = new System.Drawing.Point(0, 0);
            this.BorderEmbed.Name = "BorderEmbed";
            this.BorderEmbed.Size = new System.Drawing.Size(218, 149);
            this.BorderEmbed.Text = "kryptonBorderEdge7";
            // 
            // NavGuildInfoPage
            // 
            this.NavGuildInfoPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavGuildInfoPage.Controls.Add(this.TextGuildInfo);
            this.NavGuildInfoPage.Flags = 65534;
            this.NavGuildInfoPage.LastVisibleSet = true;
            this.NavGuildInfoPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavGuildInfoPage.Name = "NavGuildInfoPage";
            this.NavGuildInfoPage.Size = new System.Drawing.Size(218, 149);
            this.NavGuildInfoPage.Text = "Guild Info";
            this.NavGuildInfoPage.ToolTipTitle = "Page ToolTip";
            this.NavGuildInfoPage.UniqueName = "15405AE8C3F64B0DFA9BB3419545B5E6";
            // 
            // TextGuildInfo
            // 
            this.TextGuildInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextGuildInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextGuildInfo.Location = new System.Drawing.Point(0, 0);
            this.TextGuildInfo.Name = "TextGuildInfo";
            this.TextGuildInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextGuildInfo.Size = new System.Drawing.Size(218, 149);
            this.TextGuildInfo.TabIndex = 1;
            this.TextGuildInfo.Text = "";
            // 
            // NavRolesPage
            // 
            this.NavRolesPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavRolesPage.Controls.Add(this.TextGuildRoles);
            this.NavRolesPage.Flags = 65534;
            this.NavRolesPage.LastVisibleSet = true;
            this.NavRolesPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavRolesPage.Name = "NavRolesPage";
            this.NavRolesPage.Size = new System.Drawing.Size(218, 149);
            this.NavRolesPage.Text = "Roles";
            this.NavRolesPage.ToolTipTitle = "Page ToolTip";
            this.NavRolesPage.UniqueName = "21AAC88369604DAAF087F3A82510D49D";
            // 
            // TextGuildRoles
            // 
            this.TextGuildRoles.BackColor = System.Drawing.Color.Black;
            this.TextGuildRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextGuildRoles.ForeColor = System.Drawing.Color.White;
            this.TextGuildRoles.Location = new System.Drawing.Point(0, 0);
            this.TextGuildRoles.Name = "TextGuildRoles";
            this.TextGuildRoles.Size = new System.Drawing.Size(218, 149);
            this.TextGuildRoles.TabIndex = 2;
            this.TextGuildRoles.Text = "";
            // 
            // NavPageEmoji
            // 
            this.NavPageEmoji.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavPageEmoji.Controls.Add(this.TextGuildEmojis);
            this.NavPageEmoji.Flags = 65534;
            this.NavPageEmoji.LastVisibleSet = true;
            this.NavPageEmoji.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavPageEmoji.Name = "NavPageEmoji";
            this.NavPageEmoji.Size = new System.Drawing.Size(218, 149);
            this.NavPageEmoji.Text = "Emojis";
            this.NavPageEmoji.ToolTipTitle = "Page ToolTip";
            this.NavPageEmoji.UniqueName = "14F93E3889E740C4CA8379603DCB6820";
            // 
            // TextGuildEmojis
            // 
            this.TextGuildEmojis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextGuildEmojis.Location = new System.Drawing.Point(0, 0);
            this.TextGuildEmojis.Multiline = true;
            this.TextGuildEmojis.Name = "TextGuildEmojis";
            this.TextGuildEmojis.ReadOnly = true;
            this.TextGuildEmojis.Size = new System.Drawing.Size(218, 149);
            this.TextGuildEmojis.TabIndex = 1;
            // 
            // BorderMain
            // 
            this.BorderMain.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.FormMain;
            this.BorderMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderMain.Location = new System.Drawing.Point(0, 0);
            this.BorderMain.Name = "BorderMain";
            this.BorderMain.Size = new System.Drawing.Size(484, 461);
            this.BorderMain.Text = "kryptonBorderEdge1";
            // 
            // NavInfo
            // 
            this.NavInfo.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.NavInfo.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.NavInfo.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.NavInfo.Location = new System.Drawing.Point(239, 38);
            this.NavInfo.Name = "NavInfo";
            this.NavInfo.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.NavMain,
            this.NavInfoThemes,
            this.NavInfoSettings,
            this.NavInfoBots,
            this.NavCustomPage});
            this.NavInfo.SelectedIndex = 0;
            this.NavInfo.Size = new System.Drawing.Size(234, 396);
            this.NavInfo.TabIndex = 28;
            this.NavInfo.Text = "kryptonNavigator1";
            // 
            // NavMain
            // 
            this.NavMain.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavMain.Controls.Add(this.NavMoreInfo);
            this.NavMain.Flags = 65534;
            this.NavMain.LastVisibleSet = true;
            this.NavMain.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavMain.Name = "NavMain";
            this.NavMain.Size = new System.Drawing.Size(232, 369);
            this.NavMain.Text = "Main";
            this.NavMain.ToolTipTitle = "Page ToolTip";
            this.NavMain.UniqueName = "478032B78A96411C7996B476B5C7B4F2";
            // 
            // NavMoreInfo
            // 
            this.NavMoreInfo.Bar.ItemAlignment = ComponentFactory.Krypton.Toolkit.RelativePositionAlign.Center;
            this.NavMoreInfo.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.NavMoreInfo.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.NavMoreInfo.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.NavMoreInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavMoreInfo.Location = new System.Drawing.Point(0, 0);
            this.NavMoreInfo.Name = "NavMoreInfo";
            this.NavMoreInfo.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.BarRibbonTabGroup;
            this.NavMoreInfo.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.NavInfoPage,
            this.NavCommandsPage,
            this.NavChangelogPage});
            this.NavMoreInfo.SelectedIndex = 0;
            this.NavMoreInfo.Size = new System.Drawing.Size(232, 369);
            this.NavMoreInfo.TabIndex = 8;
            this.NavMoreInfo.Text = "kryptonNavigator1";
            // 
            // NavInfoPage
            // 
            this.NavInfoPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoPage.Controls.Add(this.kryptonTextBox1);
            this.NavInfoPage.Controls.Add(this.BtnOpenSelfbotFolder);
            this.NavInfoPage.Controls.Add(this.LinkDownload);
            this.NavInfoPage.Controls.Add(this.TextInfo);
            this.NavInfoPage.Controls.Add(this.HyperlinkGithub);
            this.NavInfoPage.Controls.Add(this.HyperlinkWebsite);
            this.NavInfoPage.Controls.Add(this.HyperlinkGuild);
            this.NavInfoPage.Controls.Add(this.InfoBorder);
            this.NavInfoPage.Flags = 65534;
            this.NavInfoPage.LastVisibleSet = true;
            this.NavInfoPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoPage.Name = "NavInfoPage";
            this.NavInfoPage.Size = new System.Drawing.Size(230, 340);
            this.NavInfoPage.Text = "Info";
            this.NavInfoPage.ToolTipTitle = "Page ToolTip";
            this.NavInfoPage.UniqueName = "1635D269C129459CCC8871C0CAB66A63";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(6, 206);
            this.kryptonTextBox1.Multiline = true;
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.ReadOnly = true;
            this.kryptonTextBox1.Size = new System.Drawing.Size(219, 131);
            this.kryptonTextBox1.TabIndex = 21;
            this.kryptonTextBox1.Text = "Coming Soon\r\n- Custom Commands\r\n- Channel Logs\r\n- Counter for messages sent/recie" +
    "ved\r\n- self commands to edit tag thumbnail/image";
            // 
            // BtnOpenSelfbotFolder
            // 
            this.BtnOpenSelfbotFolder.Location = new System.Drawing.Point(6, 160);
            this.BtnOpenSelfbotFolder.Name = "BtnOpenSelfbotFolder";
            this.BtnOpenSelfbotFolder.Size = new System.Drawing.Size(219, 40);
            this.BtnOpenSelfbotFolder.TabIndex = 20;
            this.BtnOpenSelfbotFolder.Values.Text = "Open Selfbot Folder";
            this.BtnOpenSelfbotFolder.Click += new System.EventHandler(this.BtnOpenSelfbotFolder_Click);
            // 
            // LinkDownload
            // 
            this.LinkDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkDownload.Location = new System.Drawing.Point(23, 135);
            this.LinkDownload.Name = "LinkDownload";
            this.LinkDownload.Size = new System.Drawing.Size(158, 20);
            this.LinkDownload.TabIndex = 19;
            this.LinkDownload.Values.Text = "Download/Update Website";
            this.LinkDownload.LinkClicked += new System.EventHandler(this.LinkDownload_LinkClicked);
            // 
            // TextInfo
            // 
            this.TextInfo.Location = new System.Drawing.Point(6, 31);
            this.TextInfo.Multiline = true;
            this.TextInfo.Name = "TextInfo";
            this.TextInfo.ReadOnly = true;
            this.TextInfo.Size = new System.Drawing.Size(219, 98);
            this.TextInfo.TabIndex = 18;
            this.TextInfo.Text = "Created by | xXBuilderBXx#9113\r\nMade in | Visual Studio\r\nLanguage | C#\r\nLibrary |" +
    " Discord.Net\r\n\r\nThis selfbot auto updates on startup";
            // 
            // HyperlinkGithub
            // 
            this.HyperlinkGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HyperlinkGithub.Location = new System.Drawing.Point(6, 5);
            this.HyperlinkGithub.Name = "HyperlinkGithub";
            this.HyperlinkGithub.Size = new System.Drawing.Size(47, 20);
            this.HyperlinkGithub.TabIndex = 15;
            this.HyperlinkGithub.Values.Text = "Github";
            this.HyperlinkGithub.LinkClicked += new System.EventHandler(this.HyperlinkGithub_LinkClicked);
            // 
            // HyperlinkWebsite
            // 
            this.HyperlinkWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HyperlinkWebsite.Location = new System.Drawing.Point(88, 5);
            this.HyperlinkWebsite.Name = "HyperlinkWebsite";
            this.HyperlinkWebsite.Size = new System.Drawing.Size(55, 20);
            this.HyperlinkWebsite.TabIndex = 16;
            this.HyperlinkWebsite.Values.Text = "Website";
            this.HyperlinkWebsite.LinkClicked += new System.EventHandler(this.HyperlinkWebsite_LinkClicked);
            // 
            // HyperlinkGuild
            // 
            this.HyperlinkGuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HyperlinkGuild.Location = new System.Drawing.Point(167, 5);
            this.HyperlinkGuild.Name = "HyperlinkGuild";
            this.HyperlinkGuild.Size = new System.Drawing.Size(60, 20);
            this.HyperlinkGuild.TabIndex = 17;
            this.HyperlinkGuild.Values.Text = "My Guild";
            this.HyperlinkGuild.LinkClicked += new System.EventHandler(this.HyperlinkGuild_LinkClicked);
            // 
            // InfoBorder
            // 
            this.InfoBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBorder.Location = new System.Drawing.Point(0, 0);
            this.InfoBorder.Name = "InfoBorder";
            this.InfoBorder.Size = new System.Drawing.Size(230, 340);
            // 
            // NavCommandsPage
            // 
            this.NavCommandsPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavCommandsPage.Controls.Add(this.TextCommandInfo);
            this.NavCommandsPage.Controls.Add(this.ViewCommandsList);
            this.NavCommandsPage.Flags = 65534;
            this.NavCommandsPage.LastVisibleSet = true;
            this.NavCommandsPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavCommandsPage.Name = "NavCommandsPage";
            this.NavCommandsPage.Size = new System.Drawing.Size(230, 340);
            this.NavCommandsPage.Text = "Commands";
            this.NavCommandsPage.ToolTipTitle = "Page ToolTip";
            this.NavCommandsPage.UniqueName = "E1FF2C7914C34B417AA8BFF17BFB6E40";
            // 
            // TextCommandInfo
            // 
            this.TextCommandInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextCommandInfo.Location = new System.Drawing.Point(0, 0);
            this.TextCommandInfo.Multiline = true;
            this.TextCommandInfo.Name = "TextCommandInfo";
            this.TextCommandInfo.ReadOnly = true;
            this.TextCommandInfo.Size = new System.Drawing.Size(230, 30);
            this.TextCommandInfo.TabIndex = 4;
            this.TextCommandInfo.Text = "Select a command";
            // 
            // ViewCommandsList
            // 
            this.ViewCommandsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewCommandsList.HotTracking = true;
            this.ViewCommandsList.Location = new System.Drawing.Point(0, 31);
            this.ViewCommandsList.Name = "ViewCommandsList";
            treeNode81.Name = "self form";
            treeNode81.Text = "self form";
            treeNode81.ToolTipText = "Open the GUI form";
            treeNode82.Name = "self test";
            treeNode82.Text = "self test";
            treeNode82.ToolTipText = "Test if selfbot is working";
            treeNode83.Name = "self info";
            treeNode83.Text = "self info";
            treeNode83.ToolTipText = "Get info about yourself";
            treeNode84.Name = "self bot";
            treeNode84.Text = "self bot";
            treeNode84.ToolTipText = "Get info about the bot origins";
            treeNode85.Name = "self uptime";
            treeNode85.Text = "self uptime";
            treeNode85.ToolTipText = "Get the uptime of the bot";
            treeNode86.Name = "self ping";
            treeNode86.Text = "self ping";
            treeNode86.ToolTipText = "Ping the network and discord";
            treeNode87.Name = "self ping (IP)";
            treeNode87.Text = "self ping (IP)";
            treeNode87.ToolTipText = "Ping another IP address";
            treeNode88.Name = "self guild";
            treeNode88.Text = "self guild";
            treeNode88.ToolTipText = "Get info about the guild";
            treeNode89.Name = "self user (User ID)";
            treeNode89.Text = "self user (User ID)";
            treeNode89.ToolTipText = "Get info about a user";
            treeNode90.Name = "self user @Mention";
            treeNode90.Text = "self user @Mention";
            treeNode90.ToolTipText = "Get info about a user";
            treeNode91.Name = "self find (User ID)";
            treeNode91.Text = "self find (User ID)";
            treeNode91.ToolTipText = "Usefull in finding DM advertisers";
            treeNode92.Name = "self clean (Ammount)";
            treeNode92.Text = "self clean (Ammount)";
            treeNode92.ToolTipText = "Cleanup an ammount of messages made by you MAX 30";
            treeNode93.Name = "self cleanembed";
            treeNode93.Text = "self cleanembed";
            treeNode93.ToolTipText = "Cleanup all your embeds";
            treeNode94.Name = "Info";
            treeNode94.Text = "Info";
            treeNode95.Name = "self neko";
            treeNode95.Text = "self neko";
            treeNode95.ToolTipText = "Post a random neko image in embed form";
            treeNode96.Name = "self lenny";
            treeNode96.Text = "self lenny";
            treeNode96.ToolTipText = "Lenny face";
            treeNode97.Name = "self lewd (Text)";
            treeNode97.Text = "self lewd (Text)";
            treeNode97.ToolTipText = "You are lewd";
            treeNode98.Name = "self embed (Text)";
            treeNode98.Text = "self embed (Text)";
            treeNode98.ToolTipText = "Turn text into an embed";
            treeNode99.Name = "self tembed (Title) (Text)";
            treeNode99.Text = "self tembed (Title) (Text)";
            treeNode99.ToolTipText = "Send an embed with a title and text";
            treeNode100.Name = "Fun";
            treeNode100.Text = "Fun";
            treeNode101.Name = "self tags";
            treeNode101.Text = "self tags";
            treeNode101.ToolTipText = "Get a list of tags";
            treeNode102.Name = "self tag (Tag)";
            treeNode102.Text = "self tag (Tag)";
            treeNode102.ToolTipText = "Get the created tag";
            treeNode103.Name = "self addtag (Tag) (Message ID)";
            treeNode103.Text = "self addtag (Tag) (Message ID)";
            treeNode103.ToolTipText = "Add another users message as a tag";
            treeNode104.Name = "self addtag (Tag) (Text)";
            treeNode104.Text = "self addtag (Tag) (Text)";
            treeNode104.ToolTipText = "Add text to a tag";
            treeNode105.Name = "self deltag (Tag)";
            treeNode105.Text = "self deltag (Tag)";
            treeNode105.ToolTipText = "Broken right now";
            treeNode106.Name = "Tags";
            treeNode106.Text = "Tags";
            treeNode107.Name = "self an add (Nickname)";
            treeNode107.Text = "self an add (Nickname)";
            treeNode107.ToolTipText = "Add a per guild nickname";
            treeNode108.Name = "self an bind";
            treeNode108.Text = "self an bind";
            treeNode108.ToolTipText = "Add the guild to the autonickname";
            treeNode109.Name = "self an del (Nickname)";
            treeNode109.Text = "self an del (Nickname)";
            treeNode109.ToolTipText = "Delete a per guild nickname";
            treeNode110.Name = "self an list";
            treeNode110.Text = "self an list";
            treeNode110.ToolTipText = "List all per guild nicknames";
            treeNode111.Name = "Auto Nickname";
            treeNode111.Text = "Auto Nickname";
            this.ViewCommandsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode94,
            treeNode100,
            treeNode106,
            treeNode111});
            this.ViewCommandsList.Size = new System.Drawing.Size(230, 309);
            this.ViewCommandsList.TabIndex = 3;
            this.ViewCommandsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ViewCommandsList_AfterSelect);
            // 
            // NavChangelogPage
            // 
            this.NavChangelogPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavChangelogPage.Controls.Add(this.TextChangelog);
            this.NavChangelogPage.Flags = 65534;
            this.NavChangelogPage.LastVisibleSet = true;
            this.NavChangelogPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavChangelogPage.Name = "NavChangelogPage";
            this.NavChangelogPage.Size = new System.Drawing.Size(230, 340);
            this.NavChangelogPage.Text = "Changelog";
            this.NavChangelogPage.ToolTipTitle = "Page ToolTip";
            this.NavChangelogPage.UniqueName = "3A74029FC7CF4436139DF09E44727F94";
            // 
            // TextChangelog
            // 
            this.TextChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextChangelog.Location = new System.Drawing.Point(0, 0);
            this.TextChangelog.Multiline = true;
            this.TextChangelog.Name = "TextChangelog";
            this.TextChangelog.ReadOnly = true;
            this.TextChangelog.Size = new System.Drawing.Size(230, 340);
            this.TextChangelog.TabIndex = 1;
            this.TextChangelog.Text = resources.GetString("TextChangelog.Text");
            // 
            // NavInfoThemes
            // 
            this.NavInfoThemes.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoThemes.Controls.Add(this.BtnThemeSparkle);
            this.NavInfoThemes.Controls.Add(this.BtnThemeDark);
            this.NavInfoThemes.Controls.Add(this.BtnThemeDefault);
            this.NavInfoThemes.Controls.Add(this.BorderTheme);
            this.NavInfoThemes.Flags = 65534;
            this.NavInfoThemes.LastVisibleSet = true;
            this.NavInfoThemes.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoThemes.Name = "NavInfoThemes";
            this.NavInfoThemes.Size = new System.Drawing.Size(232, 369);
            this.NavInfoThemes.Text = "Theme";
            this.NavInfoThemes.ToolTipTitle = "Page ToolTip";
            this.NavInfoThemes.UniqueName = "D9CF7C7E665A4C5EF0A5F9ED2C3255A3";
            // 
            // BtnThemeSparkle
            // 
            this.BtnThemeSparkle.Location = new System.Drawing.Point(7, 119);
            this.BtnThemeSparkle.Name = "BtnThemeSparkle";
            this.BtnThemeSparkle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.BtnThemeSparkle.Size = new System.Drawing.Size(214, 50);
            this.BtnThemeSparkle.TabIndex = 6;
            this.BtnThemeSparkle.Values.Text = "Dark Sparkle";
            this.BtnThemeSparkle.Click += new System.EventHandler(this.BtnThemeSparkle_Click);
            // 
            // BtnThemeDark
            // 
            this.BtnThemeDark.Location = new System.Drawing.Point(7, 63);
            this.BtnThemeDark.Name = "BtnThemeDark";
            this.BtnThemeDark.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.BtnThemeDark.Size = new System.Drawing.Size(214, 50);
            this.BtnThemeDark.TabIndex = 5;
            this.BtnThemeDark.Values.Text = "Dark Theme";
            this.BtnThemeDark.Click += new System.EventHandler(this.BtnThemeDark_Click);
            // 
            // BtnThemeDefault
            // 
            this.BtnThemeDefault.Location = new System.Drawing.Point(7, 7);
            this.BtnThemeDefault.Name = "BtnThemeDefault";
            this.BtnThemeDefault.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.BtnThemeDefault.Size = new System.Drawing.Size(214, 50);
            this.BtnThemeDefault.TabIndex = 4;
            this.BtnThemeDefault.Values.Text = "Default Theme";
            this.BtnThemeDefault.Click += new System.EventHandler(this.BtnThemeDefault_Click);
            // 
            // BorderTheme
            // 
            this.BorderTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderTheme.Location = new System.Drawing.Point(0, 0);
            this.BorderTheme.Name = "BorderTheme";
            this.BorderTheme.Size = new System.Drawing.Size(232, 369);
            // 
            // NavInfoSettings
            // 
            this.NavInfoSettings.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoSettings.Controls.Add(this.HelpFavoriteColor);
            this.NavInfoSettings.Controls.Add(this.HelpAutoForm);
            this.NavInfoSettings.Controls.Add(this.HelpCommandMessage);
            this.NavInfoSettings.Controls.Add(this.HelpAutoNickname);
            this.NavInfoSettings.Controls.Add(this.TitleAutoNickname);
            this.NavInfoSettings.Controls.Add(this.TitleFavoriteColor);
            this.NavInfoSettings.Controls.Add(this.TitleAutoForm);
            this.NavInfoSettings.Controls.Add(this.TitleCommandMessage);
            this.NavInfoSettings.Controls.Add(this.TextFavColor);
            this.NavInfoSettings.Controls.Add(this.BtnAN5);
            this.NavInfoSettings.Controls.Add(this.BtnAN10);
            this.NavInfoSettings.Controls.Add(this.BtnAN1);
            this.NavInfoSettings.Controls.Add(this.TextAutoNickname);
            this.NavInfoSettings.Controls.Add(this.BtnFavColor);
            this.NavInfoSettings.Controls.Add(this.BtnAFNo);
            this.NavInfoSettings.Controls.Add(this.TextAutoForm);
            this.NavInfoSettings.Controls.Add(this.BtnAFYes);
            this.NavInfoSettings.Controls.Add(this.BtnCMDelete);
            this.NavInfoSettings.Controls.Add(this.TextCommandMessage);
            this.NavInfoSettings.Controls.Add(this.BtnCMEdit);
            this.NavInfoSettings.Controls.Add(this.BorderSettings);
            this.NavInfoSettings.Flags = 65534;
            this.NavInfoSettings.LastVisibleSet = true;
            this.NavInfoSettings.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoSettings.Name = "NavInfoSettings";
            this.NavInfoSettings.Size = new System.Drawing.Size(232, 369);
            this.NavInfoSettings.Text = "Settings";
            this.NavInfoSettings.ToolTipTitle = "Page ToolTip";
            this.NavInfoSettings.UniqueName = "49ED9FB7DC7E4E4A978BC06114B986B4";
            // 
            // HelpFavoriteColor
            // 
            this.HelpFavoriteColor.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpFavoriteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpFavoriteColor.Location = new System.Drawing.Point(-1, 151);
            this.HelpFavoriteColor.Name = "HelpFavoriteColor";
            this.HelpFavoriteColor.ReadOnly = true;
            this.HelpFavoriteColor.Size = new System.Drawing.Size(20, 22);
            this.HelpFavoriteColor.TabIndex = 150;
            this.HelpFavoriteColor.Text = "?";
            this.HelpFavoriteColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipManager.SetToolTip(this.HelpFavoriteColor, "Choose your favorite color for embeds");
            // 
            // HelpAutoForm
            // 
            this.HelpAutoForm.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpAutoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpAutoForm.Location = new System.Drawing.Point(-1, 77);
            this.HelpAutoForm.Name = "HelpAutoForm";
            this.HelpAutoForm.ReadOnly = true;
            this.HelpAutoForm.Size = new System.Drawing.Size(20, 22);
            this.HelpAutoForm.TabIndex = 149;
            this.HelpAutoForm.Text = "?";
            this.HelpAutoForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipManager.SetToolTip(this.HelpAutoForm, "Open the GUI when you start the selfbot");
            // 
            // HelpCommandMessage
            // 
            this.HelpCommandMessage.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpCommandMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpCommandMessage.Location = new System.Drawing.Point(-1, 3);
            this.HelpCommandMessage.Name = "HelpCommandMessage";
            this.HelpCommandMessage.ReadOnly = true;
            this.HelpCommandMessage.Size = new System.Drawing.Size(20, 22);
            this.HelpCommandMessage.TabIndex = 148;
            this.HelpCommandMessage.Text = "?";
            this.HelpCommandMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolTipManager.SetToolTip(this.HelpCommandMessage, "Edit or delete the message of the selfbot command");
            // 
            // HelpAutoNickname
            // 
            this.HelpAutoNickname.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpAutoNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpAutoNickname.Location = new System.Drawing.Point(-1, 225);
            this.HelpAutoNickname.Name = "HelpAutoNickname";
            this.HelpAutoNickname.ReadOnly = true;
            this.HelpAutoNickname.Size = new System.Drawing.Size(20, 22);
            this.HelpAutoNickname.TabIndex = 147;
            this.HelpAutoNickname.Text = "?";
            this.HelpAutoNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleAutoNickname
            // 
            this.TitleAutoNickname.AllowButtonSpecToolTips = true;
            this.TitleAutoNickname.AutoSize = false;
            this.TitleAutoNickname.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.TitleAutoNickname.Location = new System.Drawing.Point(25, 225);
            this.TitleAutoNickname.Name = "TitleAutoNickname";
            this.TitleAutoNickname.Size = new System.Drawing.Size(209, 22);
            this.TitleAutoNickname.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleAutoNickname.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.TitleAutoNickname.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.TitleAutoNickname.TabIndex = 140;
            this.TitleAutoNickname.Values.Description = "";
            this.TitleAutoNickname.Values.Heading = "Auto Nickname Timer";
            this.TitleAutoNickname.Values.Image = null;
            // 
            // TitleFavoriteColor
            // 
            this.TitleFavoriteColor.AutoSize = false;
            this.TitleFavoriteColor.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.TitleFavoriteColor.Location = new System.Drawing.Point(25, 151);
            this.TitleFavoriteColor.Name = "TitleFavoriteColor";
            this.TitleFavoriteColor.Size = new System.Drawing.Size(209, 22);
            this.TitleFavoriteColor.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleFavoriteColor.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.TitleFavoriteColor.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.TitleFavoriteColor.TabIndex = 141;
            this.TitleFavoriteColor.Values.Description = "";
            this.TitleFavoriteColor.Values.Heading = "Favorite Color";
            this.TitleFavoriteColor.Values.Image = null;
            // 
            // TitleAutoForm
            // 
            this.TitleAutoForm.AutoSize = false;
            this.TitleAutoForm.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.TitleAutoForm.Location = new System.Drawing.Point(25, 77);
            this.TitleAutoForm.Name = "TitleAutoForm";
            this.TitleAutoForm.Size = new System.Drawing.Size(208, 22);
            this.TitleAutoForm.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleAutoForm.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.TitleAutoForm.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.TitleAutoForm.TabIndex = 139;
            this.TitleAutoForm.Values.Description = "";
            this.TitleAutoForm.Values.Heading = "Open Form On Startup";
            this.TitleAutoForm.Values.Image = null;
            // 
            // TitleCommandMessage
            // 
            this.TitleCommandMessage.AutoSize = false;
            this.TitleCommandMessage.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary;
            this.TitleCommandMessage.Location = new System.Drawing.Point(25, 3);
            this.TitleCommandMessage.Name = "TitleCommandMessage";
            this.TitleCommandMessage.Size = new System.Drawing.Size(209, 22);
            this.TitleCommandMessage.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCommandMessage.StateNormal.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.TitleCommandMessage.StateNormal.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.TitleCommandMessage.TabIndex = 142;
            this.TitleCommandMessage.Values.Description = "";
            this.TitleCommandMessage.Values.Heading = "Command Message";
            this.TitleCommandMessage.Values.Image = null;
            // 
            // BtnAN5
            // 
            this.BtnAN5.Location = new System.Drawing.Point(79, 253);
            this.BtnAN5.Name = "BtnAN5";
            this.BtnAN5.Size = new System.Drawing.Size(50, 40);
            this.BtnAN5.TabIndex = 137;
            this.BtnAN5.Values.Text = "5 Min";
            this.BtnAN5.Click += new System.EventHandler(this.BtnAN5_Click);
            // 
            // BtnAN10
            // 
            this.BtnAN10.Location = new System.Drawing.Point(153, 253);
            this.BtnAN10.Name = "BtnAN10";
            this.BtnAN10.Size = new System.Drawing.Size(50, 40);
            this.BtnAN10.TabIndex = 136;
            this.BtnAN10.Values.Text = "10 Min\r\n";
            this.BtnAN10.Click += new System.EventHandler(this.BtnAN10_Click);
            // 
            // BtnAN1
            // 
            this.BtnAN1.Location = new System.Drawing.Point(5, 253);
            this.BtnAN1.Name = "BtnAN1";
            this.BtnAN1.Size = new System.Drawing.Size(50, 40);
            this.BtnAN1.TabIndex = 135;
            this.BtnAN1.Values.Text = "1 Min";
            this.BtnAN1.Click += new System.EventHandler(this.BtnAN1_Click);
            // 
            // BtnFavColor
            // 
            this.BtnFavColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BtnFavColor.Location = new System.Drawing.Point(104, 179);
            this.BtnFavColor.Name = "BtnFavColor";
            this.BtnFavColor.Size = new System.Drawing.Size(70, 40);
            this.BtnFavColor.TabIndex = 133;
            this.BtnFavColor.Values.Text = "Color";
            this.BtnFavColor.Click += new System.EventHandler(this.BtnFavColor_Click);
            // 
            // BtnAFNo
            // 
            this.BtnAFNo.Location = new System.Drawing.Point(104, 105);
            this.BtnAFNo.Name = "BtnAFNo";
            this.BtnAFNo.Size = new System.Drawing.Size(70, 40);
            this.BtnAFNo.TabIndex = 132;
            this.BtnAFNo.Values.Text = "No";
            this.BtnAFNo.Click += new System.EventHandler(this.BtnAFNo_Click);
            // 
            // BtnAFYes
            // 
            this.BtnAFYes.Location = new System.Drawing.Point(5, 105);
            this.BtnAFYes.Name = "BtnAFYes";
            this.BtnAFYes.Size = new System.Drawing.Size(70, 40);
            this.BtnAFYes.TabIndex = 130;
            this.BtnAFYes.Values.Text = "Yes";
            this.BtnAFYes.Click += new System.EventHandler(this.BtnAFYes_Click);
            // 
            // BtnCMDelete
            // 
            this.BtnCMDelete.Location = new System.Drawing.Point(104, 29);
            this.BtnCMDelete.Name = "BtnCMDelete";
            this.BtnCMDelete.Size = new System.Drawing.Size(70, 40);
            this.BtnCMDelete.TabIndex = 129;
            this.BtnCMDelete.Values.Text = "Delete";
            this.BtnCMDelete.Click += new System.EventHandler(this.BtnCMDelete_Click);
            // 
            // BtnCMEdit
            // 
            this.BtnCMEdit.Location = new System.Drawing.Point(4, 31);
            this.BtnCMEdit.Name = "BtnCMEdit";
            this.BtnCMEdit.Size = new System.Drawing.Size(70, 40);
            this.BtnCMEdit.TabIndex = 127;
            this.BtnCMEdit.Values.Text = "Edit";
            this.BtnCMEdit.Click += new System.EventHandler(this.BtnCMEdit_Click);
            // 
            // BorderSettings
            // 
            this.BorderSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderSettings.Location = new System.Drawing.Point(0, 0);
            this.BorderSettings.Name = "BorderSettings";
            this.BorderSettings.Size = new System.Drawing.Size(232, 369);
            this.BorderSettings.Text = "kryptonBorderEdge3";
            // 
            // NavInfoBots
            // 
            this.NavInfoBots.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavInfoBots.Controls.Add(this.TextBotInfo);
            this.NavInfoBots.Controls.Add(this.HyperlinkBotInvite);
            this.NavInfoBots.Controls.Add(this.HyperlinkBotWebsite);
            this.NavInfoBots.Controls.Add(this.ViewBotsList);
            this.NavInfoBots.Controls.Add(this.BorderBots);
            this.NavInfoBots.Flags = 65534;
            this.NavInfoBots.LastVisibleSet = true;
            this.NavInfoBots.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavInfoBots.Name = "NavInfoBots";
            this.NavInfoBots.Size = new System.Drawing.Size(232, 369);
            this.NavInfoBots.Text = "Bots";
            this.NavInfoBots.ToolTipTitle = "Page ToolTip";
            this.NavInfoBots.UniqueName = "BB6C782F33E64B9FB49FF924F7F68668";
            // 
            // TextBotInfo
            // 
            this.TextBotInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBotInfo.Location = new System.Drawing.Point(0, 290);
            this.TextBotInfo.Multiline = true;
            this.TextBotInfo.Name = "TextBotInfo";
            this.TextBotInfo.ReadOnly = true;
            this.TextBotInfo.Size = new System.Drawing.Size(232, 79);
            this.TextBotInfo.TabIndex = 12;
            this.TextBotInfo.Text = "Select a bot above";
            // 
            // HyperlinkBotInvite
            // 
            this.HyperlinkBotInvite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HyperlinkBotInvite.Location = new System.Drawing.Point(160, 264);
            this.HyperlinkBotInvite.Name = "HyperlinkBotInvite";
            this.HyperlinkBotInvite.Size = new System.Drawing.Size(66, 20);
            this.HyperlinkBotInvite.TabIndex = 11;
            this.HyperlinkBotInvite.Values.Text = "Invite Link";
            this.HyperlinkBotInvite.Visible = false;
            this.HyperlinkBotInvite.LinkClicked += new System.EventHandler(this.HyperlinkBotInvite_LinkClicked);
            // 
            // HyperlinkBotWebsite
            // 
            this.HyperlinkBotWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HyperlinkBotWebsite.Location = new System.Drawing.Point(7, 264);
            this.HyperlinkBotWebsite.Name = "HyperlinkBotWebsite";
            this.HyperlinkBotWebsite.Size = new System.Drawing.Size(55, 20);
            this.HyperlinkBotWebsite.TabIndex = 10;
            this.HyperlinkBotWebsite.Values.Text = "Website";
            this.HyperlinkBotWebsite.Visible = false;
            this.HyperlinkBotWebsite.LinkClicked += new System.EventHandler(this.HyperlinkBotWebsite_LinkClicked);
            // 
            // ViewBotsList
            // 
            this.ViewBotsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewBotsList.Location = new System.Drawing.Point(0, 0);
            this.ViewBotsList.Name = "ViewBotsList";
            treeNode112.Name = "PixelBot";
            treeNode112.Text = "PixelBot";
            treeNode113.Name = "Minotaur";
            treeNode113.Text = "Minotaur";
            treeNode114.Name = "My Bots";
            treeNode114.Text = "My Bots";
            treeNode115.Name = "Discord Cards";
            treeNode115.Text = "Discord Cards";
            treeNode116.Name = "Casino Bot";
            treeNode116.Text = "Casino Bot";
            treeNode117.Name = "Discord RPG";
            treeNode117.Text = "Discord RPG";
            treeNode118.Name = "Fun Bots";
            treeNode118.Text = "Fun Bots";
            treeNode119.Name = "Sekoboto";
            treeNode119.Text = "Sekobot";
            treeNode120.Name = "Other Bots";
            treeNode120.Text = "Other Bots";
            this.ViewBotsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode114,
            treeNode118,
            treeNode120});
            this.ViewBotsList.Size = new System.Drawing.Size(232, 258);
            this.ViewBotsList.TabIndex = 9;
            this.ViewBotsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ViewBotsList_AfterSelect);
            // 
            // BorderBots
            // 
            this.BorderBots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderBots.Location = new System.Drawing.Point(0, 0);
            this.BorderBots.Name = "BorderBots";
            this.BorderBots.Size = new System.Drawing.Size(232, 369);
            this.BorderBots.Text = "kryptonBorderEdge2";
            // 
            // NavCustomPage
            // 
            this.NavCustomPage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.NavCustomPage.Controls.Add(this.CustomEdit);
            this.NavCustomPage.Controls.Add(this.CustomDelete);
            this.NavCustomPage.Controls.Add(this.CustomAddCustomAdd);
            this.NavCustomPage.Controls.Add(this.CustomCommandsList);
            this.NavCustomPage.Controls.Add(this.kryptonBorderEdge1);
            this.NavCustomPage.Flags = 65534;
            this.NavCustomPage.LastVisibleSet = true;
            this.NavCustomPage.MinimumSize = new System.Drawing.Size(50, 50);
            this.NavCustomPage.Name = "NavCustomPage";
            this.NavCustomPage.Size = new System.Drawing.Size(232, 369);
            this.NavCustomPage.Text = "Custom";
            this.NavCustomPage.ToolTipTitle = "Page ToolTip";
            this.NavCustomPage.UniqueName = "73E3D7DECE594F89C78B9DB7BB8B0A07";
            // 
            // CustomEdit
            // 
            this.CustomEdit.Location = new System.Drawing.Point(98, 3);
            this.CustomEdit.Name = "CustomEdit";
            this.CustomEdit.Size = new System.Drawing.Size(31, 20);
            this.CustomEdit.TabIndex = 6;
            this.CustomEdit.Values.Text = "Edit";
            this.CustomEdit.Visible = false;
            // 
            // CustomDelete
            // 
            this.CustomDelete.Location = new System.Drawing.Point(183, 3);
            this.CustomDelete.Name = "CustomDelete";
            this.CustomDelete.Size = new System.Drawing.Size(46, 20);
            this.CustomDelete.TabIndex = 5;
            this.CustomDelete.Values.Text = "Delete";
            this.CustomDelete.LinkClicked += new System.EventHandler(this.CustomDelete_LinkClicked);
            // 
            // CustomAddCustomAdd
            // 
            this.CustomAddCustomAdd.Location = new System.Drawing.Point(2, 3);
            this.CustomAddCustomAdd.Name = "CustomAddCustomAdd";
            this.CustomAddCustomAdd.Size = new System.Drawing.Size(33, 20);
            this.CustomAddCustomAdd.TabIndex = 4;
            this.CustomAddCustomAdd.Values.Text = "Add";
            this.CustomAddCustomAdd.LinkClicked += new System.EventHandler(this.CustomAddCustomAdd_LinkClicked);
            // 
            // CustomCommandsList
            // 
            this.CustomCommandsList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomCommandsList.Location = new System.Drawing.Point(0, 29);
            this.CustomCommandsList.Name = "CustomCommandsList";
            this.CustomCommandsList.Size = new System.Drawing.Size(232, 340);
            this.CustomCommandsList.TabIndex = 0;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(232, 369);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge3";
            // 
            // StatusActive
            // 
            this.StatusActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StatusActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatusActive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ATitle,
            this.AGTitle,
            this.AGName,
            this.AGID,
            this.ACTitle,
            this.ACName,
            this.ACID});
            this.StatusActive.Location = new System.Drawing.Point(0, 439);
            this.StatusActive.Name = "StatusActive";
            this.StatusActive.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusActive.Size = new System.Drawing.Size(484, 22);
            this.StatusActive.SizingGrip = false;
            this.StatusActive.TabIndex = 30;
            this.StatusActive.Text = "Active";
            // 
            // ATitle
            // 
            this.ATitle.ForeColor = System.Drawing.Color.Green;
            this.ATitle.Name = "ATitle";
            this.ATitle.Size = new System.Drawing.Size(40, 17);
            this.ATitle.Text = "Active";
            // 
            // AGTitle
            // 
            this.AGTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AGTitle.Name = "AGTitle";
            this.AGTitle.Size = new System.Drawing.Size(19, 17);
            this.AGTitle.Text = "G:";
            // 
            // AGName
            // 
            this.AGName.Name = "AGName";
            this.AGName.Size = new System.Drawing.Size(35, 17);
            this.AGName.Text = "Guild";
            // 
            // AGID
            // 
            this.AGID.Name = "AGID";
            this.AGID.Size = new System.Drawing.Size(33, 17);
            this.AGID.Text = "(420)";
            // 
            // ACTitle
            // 
            this.ACTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ACTitle.Name = "ACTitle";
            this.ACTitle.Size = new System.Drawing.Size(17, 17);
            this.ACTitle.Text = "C:";
            // 
            // ACName
            // 
            this.ACName.Name = "ACName";
            this.ACName.Size = new System.Drawing.Size(51, 17);
            this.ACName.Text = "Channel";
            // 
            // ACID
            // 
            this.ACID.Name = "ACID";
            this.ACID.Size = new System.Drawing.Size(27, 17);
            this.ACID.Text = "(69)";
            // 
            // BtnOnTop
            // 
            this.BtnOnTop.Checked = ComponentFactory.Krypton.Toolkit.ButtonCheckState.Unchecked;
            this.BtnOnTop.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.PinVertical;
            this.BtnOnTop.UniqueName = "555AF5C49B6D42E7BB90D774F9B167FD";
            // 
            // ChannelLogs
            // 
            this.ChannelLogs.Location = new System.Drawing.Point(12, 64);
            this.ChannelLogs.Name = "ChannelLogs";
            this.ChannelLogs.Size = new System.Drawing.Size(220, 188);
            this.ChannelLogs.TabIndex = 32;
            // 
            // TextFavColor
            // 
            this.TextFavColor.BackColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.TextFavColor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextFavColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextFavColor.Location = new System.Drawing.Point(180, 193);
            this.TextFavColor.Name = "TextFavColor";
            this.TextFavColor.ReadOnly = true;
            this.TextFavColor.Size = new System.Drawing.Size(50, 20);
            this.TextFavColor.TabIndex = 138;
            // 
            // TextAutoNickname
            // 
            this.TextAutoNickname.AutoSize = false;
            this.TextAutoNickname.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "ANTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextAutoNickname.Location = new System.Drawing.Point(209, 253);
            this.TextAutoNickname.Name = "TextAutoNickname";
            this.TextAutoNickname.Size = new System.Drawing.Size(20, 40);
            this.TextAutoNickname.TabIndex = 134;
            this.TextAutoNickname.Text = global::Discore_Selfbot.Properties.Settings.Default.ANTimer;
            this.TextAutoNickname.Values.Text = "1";
            // 
            // TextAutoForm
            // 
            this.TextAutoForm.AutoSize = false;
            this.TextAutoForm.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "AutoForm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextAutoForm.Location = new System.Drawing.Point(180, 105);
            this.TextAutoForm.Name = "TextAutoForm";
            this.TextAutoForm.Size = new System.Drawing.Size(49, 40);
            this.TextAutoForm.TabIndex = 131;
            this.TextAutoForm.Text = global::Discore_Selfbot.Properties.Settings.Default.AutoForm;
            this.TextAutoForm.Values.Text = "Yes";
            // 
            // TextCommandMessage
            // 
            this.TextCommandMessage.AutoSize = false;
            this.TextCommandMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Discore_Selfbot.Properties.Settings.Default, "SendAction", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextCommandMessage.Location = new System.Drawing.Point(180, 31);
            this.TextCommandMessage.Name = "TextCommandMessage";
            this.TextCommandMessage.Size = new System.Drawing.Size(50, 40);
            this.TextCommandMessage.TabIndex = 128;
            this.TextCommandMessage.Text = global::Discore_Selfbot.Properties.Settings.Default.SendAction;
            this.TextCommandMessage.Values.Text = "Edit";
            // 
            // GuildList
            // 
            this.GuildList.BackColor = global::Discore_Selfbot.Properties.Settings.Default.FavoriteColor;
            this.GuildList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuildList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Discore_Selfbot.Properties.Settings.Default, "FavoriteColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GuildList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GuildList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GuildList.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.GuildList.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.GuildList.Location = new System.Drawing.Point(0, 0);
            this.GuildList.Name = "GuildList";
            this.GuildList.Padding = new System.Windows.Forms.Padding(0);
            this.GuildList.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.GuildList.Size = new System.Drawing.Size(484, 25);
            this.GuildList.Stretch = true;
            this.GuildList.TabIndex = 18;
            this.GuildList.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.GuildList_ItemClicked);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BtnOnTop,
            this.BtnTopMin});
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ChannelLogs);
            this.Controls.Add(this.StatusActive);
            this.Controls.Add(this.NavInfo);
            this.Controls.Add(this.NavGuild);
            this.Controls.Add(this.ChannelList);
            this.Controls.Add(this.GuildList);
            this.Controls.Add(this.BorderMain);
            this.CustomCaptionArea = new System.Drawing.Rectangle(63, 0, 396, 25);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "GUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GUI";
            this.TextExtra = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NavGuild)).EndInit();
            this.NavGuild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavEmbedPage)).EndInit();
            this.NavEmbedPage.ResumeLayout(false);
            this.NavEmbedPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavGuildInfoPage)).EndInit();
            this.NavGuildInfoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavRolesPage)).EndInit();
            this.NavRolesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavPageEmoji)).EndInit();
            this.NavPageEmoji.ResumeLayout(false);
            this.NavPageEmoji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfo)).EndInit();
            this.NavInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavMain)).EndInit();
            this.NavMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavMoreInfo)).EndInit();
            this.NavMoreInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoPage)).EndInit();
            this.NavInfoPage.ResumeLayout(false);
            this.NavInfoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavCommandsPage)).EndInit();
            this.NavCommandsPage.ResumeLayout(false);
            this.NavCommandsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavChangelogPage)).EndInit();
            this.NavChangelogPage.ResumeLayout(false);
            this.NavChangelogPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoThemes)).EndInit();
            this.NavInfoThemes.ResumeLayout(false);
            this.NavInfoThemes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoSettings)).EndInit();
            this.NavInfoSettings.ResumeLayout(false);
            this.NavInfoSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavInfoBots)).EndInit();
            this.NavInfoBots.ResumeLayout(false);
            this.NavInfoBots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavCustomPage)).EndInit();
            this.NavCustomPage.ResumeLayout(false);
            this.NavCustomPage.PerformLayout();
            this.StatusActive.ResumeLayout(false);
            this.StatusActive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BtnTopMin;
        private ComponentFactory.Krypton.Toolkit.KryptonBreadCrumbItem kryptonBreadCrumbItem1;
        public System.Windows.Forms.ToolStrip GuildList;
        public System.Windows.Forms.ComboBox ChannelList;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator NavGuild;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavEmbedPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavGuildInfoPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavRolesPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavPageEmoji;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BorderMain;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator NavInfo;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavMain;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavInfoThemes;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavInfoSettings;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavInfoBots;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavCustomPage;
        private System.Windows.Forms.TextBox TextEmbedColor;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnSendActive;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnSendSelected;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedFooter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedText;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnEmbedColor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmbedTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BorderEmbed;
        private System.Windows.Forms.RichTextBox TextGuildInfo;
        private System.Windows.Forms.RichTextBox TextGuildRoles;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextGuildEmojis;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator NavMoreInfo;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavInfoPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavCommandsPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage NavChangelogPage;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonButton BtnOpenSelfbotFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel LinkDownload;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkGithub;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkWebsite;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkGuild;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge InfoBorder;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextCommandInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView ViewCommandsList;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextChangelog;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnThemeSparkle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnThemeDark;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnThemeDefault;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BorderTheme;
        private System.Windows.Forms.TextBox HelpFavoriteColor;
        private System.Windows.Forms.TextBox HelpAutoForm;
        private System.Windows.Forms.TextBox HelpCommandMessage;
        private System.Windows.Forms.TextBox HelpAutoNickname;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader TitleAutoNickname;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader TitleFavoriteColor;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader TitleAutoForm;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader TitleCommandMessage;
        private System.Windows.Forms.TextBox TextFavColor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAN5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAN10;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAN1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel TextAutoNickname;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnFavColor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAFNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel TextAutoForm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnAFYes;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCMDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel TextCommandMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCMEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BorderSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBotInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkBotInvite;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel HyperlinkBotWebsite;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView ViewBotsList;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BorderBots;
        private System.Windows.Forms.ColorDialog OpenFavoriteColor;
        private System.Windows.Forms.StatusStrip StatusActive;
        private System.Windows.Forms.ToolStripStatusLabel ATitle;
        private System.Windows.Forms.ToolStripStatusLabel AGTitle;
        public System.Windows.Forms.ToolStripStatusLabel AGName;
        public System.Windows.Forms.ToolStripStatusLabel AGID;
        private System.Windows.Forms.ToolStripStatusLabel ACTitle;
        public System.Windows.Forms.ToolStripStatusLabel ACName;
        public System.Windows.Forms.ToolStripStatusLabel ACID;
        private System.Windows.Forms.ToolTip ToolTipManager;
        private ComponentFactory.Krypton.Toolkit.KryptonManager ThemeManager;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel CustomEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel CustomDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel CustomAddCustomAdd;
        public ComponentFactory.Krypton.Toolkit.KryptonListBox CustomCommandsList;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BtnOnTop;
        public ComponentFactory.Krypton.Toolkit.KryptonListBox ChannelLogs;
    }
}