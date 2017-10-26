namespace Presentation
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_delete_category = new System.Windows.Forms.Button();
            this.btn_delete_podcast = new System.Windows.Forms.Button();
            this.btn_delete_episode = new System.Windows.Forms.Button();
            this.btn_play_podcast = new System.Windows.Forms.Button();
            this.btn_add_podcast = new System.Windows.Forms.Button();
            this.txtBox_new_pod = new System.Windows.Forms.TextBox();
            this.txtBox_edit_category = new System.Windows.Forms.TextBox();
            this.txtBox_new_category = new System.Windows.Forms.TextBox();
            this.txtBox_url = new System.Windows.Forms.TextBox();
            this.lb_category = new System.Windows.Forms.ListBox();
            this.lb_podcast = new System.Windows.Forms.ListBox();
            this.lbl_categories = new System.Windows.Forms.Label();
            this.lbl_podcast = new System.Windows.Forms.Label();
            this.lbl_episodes = new System.Windows.Forms.Label();
            this.lbl_pod_description = new System.Windows.Forms.Label();
            this.lbl_edit_category = new System.Windows.Forms.Label();
            this.lbl_new_category = new System.Windows.Forms.Label();
            this.lbl_url = new System.Windows.Forms.Label();
            this.lbl_update_interval = new System.Windows.Forms.Label();
            this.lbl_select_category = new System.Windows.Forms.Label();
            this.lbl_podcast_name = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_edit_category = new System.Windows.Forms.Button();
            this.btn_add_category = new System.Windows.Forms.Button();
            this.clb_episodes = new System.Windows.Forms.CheckedListBox();
            this.btn_edit_pod_location = new System.Windows.Forms.Button();
            this.btn_edit_podcast_url = new System.Windows.Forms.Button();
            this.btn_edit_podcast_name = new System.Windows.Forms.Button();
            this.cb_interval = new System.Windows.Forms.ComboBox();
            this.richtb_description = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete_category
            // 
            this.btn_delete_category.Location = new System.Drawing.Point(32, 292);
            this.btn_delete_category.Name = "btn_delete_category";
            this.btn_delete_category.Size = new System.Drawing.Size(85, 42);
            this.btn_delete_category.TabIndex = 10;
            this.btn_delete_category.Text = "Delete category";
            this.btn_delete_category.UseVisualStyleBackColor = true;
            this.btn_delete_category.Click += new System.EventHandler(this.btn_delete_category_Click);
            // 
            // btn_delete_podcast
            // 
            this.btn_delete_podcast.Location = new System.Drawing.Point(221, 293);
            this.btn_delete_podcast.Name = "btn_delete_podcast";
            this.btn_delete_podcast.Size = new System.Drawing.Size(85, 42);
            this.btn_delete_podcast.TabIndex = 17;
            this.btn_delete_podcast.Text = "Delete podcast";
            this.btn_delete_podcast.UseVisualStyleBackColor = true;
            this.btn_delete_podcast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_delete_podcast_MouseClick);
            // 
            // btn_delete_episode
            // 
            this.btn_delete_episode.Location = new System.Drawing.Point(456, 208);
            this.btn_delete_episode.Name = "btn_delete_episode";
            this.btn_delete_episode.Size = new System.Drawing.Size(85, 42);
            this.btn_delete_episode.TabIndex = 7;
            this.btn_delete_episode.Text = "Delete episode";
            this.btn_delete_episode.UseVisualStyleBackColor = true;
            // 
            // btn_play_podcast
            // 
            this.btn_play_podcast.Location = new System.Drawing.Point(579, 292);
            this.btn_play_podcast.Name = "btn_play_podcast";
            this.btn_play_podcast.Size = new System.Drawing.Size(85, 42);
            this.btn_play_podcast.TabIndex = 12;
            this.btn_play_podcast.Text = "Play podcast";
            this.btn_play_podcast.UseVisualStyleBackColor = true;
            this.btn_play_podcast.Click += new System.EventHandler(this.btn_play_podcast_Click);
            // 
            // btn_add_podcast
            // 
            this.btn_add_podcast.Location = new System.Drawing.Point(564, 15);
            this.btn_add_podcast.Name = "btn_add_podcast";
            this.btn_add_podcast.Size = new System.Drawing.Size(80, 38);
            this.btn_add_podcast.TabIndex = 15;
            this.btn_add_podcast.Text = "Add podcast";
            this.btn_add_podcast.UseVisualStyleBackColor = true;
            this.btn_add_podcast.Click += new System.EventHandler(this.btn_add_podcast_Click);
            // 
            // txtBox_new_pod
            // 
            this.txtBox_new_pod.Location = new System.Drawing.Point(32, 31);
            this.txtBox_new_pod.Name = "txtBox_new_pod";
            this.txtBox_new_pod.Size = new System.Drawing.Size(165, 20);
            this.txtBox_new_pod.TabIndex = 0;
            // 
            // txtBox_edit_category
            // 
            this.txtBox_edit_category.Location = new System.Drawing.Point(206, 74);
            this.txtBox_edit_category.Name = "txtBox_edit_category";
            this.txtBox_edit_category.Size = new System.Drawing.Size(165, 20);
            this.txtBox_edit_category.TabIndex = 3;
            // 
            // txtBox_new_category
            // 
            this.txtBox_new_category.Location = new System.Drawing.Point(206, 31);
            this.txtBox_new_category.Name = "txtBox_new_category";
            this.txtBox_new_category.Size = new System.Drawing.Size(165, 20);
            this.txtBox_new_category.TabIndex = 2;
            // 
            // txtBox_url
            // 
            this.txtBox_url.Location = new System.Drawing.Point(32, 74);
            this.txtBox_url.Name = "txtBox_url";
            this.txtBox_url.Size = new System.Drawing.Size(165, 20);
            this.txtBox_url.TabIndex = 1;
            // 
            // lb_category
            // 
            this.lb_category.FormattingEnabled = true;
            this.lb_category.Location = new System.Drawing.Point(32, 140);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(151, 147);
            this.lb_category.TabIndex = 11;
            this.lb_category.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_category_MouseClick);
            // 
            // lb_podcast
            // 
            this.lb_podcast.FormattingEnabled = true;
            this.lb_podcast.Location = new System.Drawing.Point(221, 140);
            this.lb_podcast.Name = "lb_podcast";
            this.lb_podcast.Size = new System.Drawing.Size(151, 147);
            this.lb_podcast.TabIndex = 13;
            this.lb_podcast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_podcast_MouseClick);
            // 
            // lbl_categories
            // 
            this.lbl_categories.AutoSize = true;
            this.lbl_categories.Location = new System.Drawing.Point(29, 123);
            this.lbl_categories.Name = "lbl_categories";
            this.lbl_categories.Size = new System.Drawing.Size(57, 13);
            this.lbl_categories.TabIndex = 14;
            this.lbl_categories.Text = "Categories";
            // 
            // lbl_podcast
            // 
            this.lbl_podcast.AutoSize = true;
            this.lbl_podcast.Location = new System.Drawing.Point(218, 125);
            this.lbl_podcast.Name = "lbl_podcast";
            this.lbl_podcast.Size = new System.Drawing.Size(51, 13);
            this.lbl_podcast.TabIndex = 15;
            this.lbl_podcast.Text = "Podcasts";
            // 
            // lbl_episodes
            // 
            this.lbl_episodes.AutoSize = true;
            this.lbl_episodes.Location = new System.Drawing.Point(402, 123);
            this.lbl_episodes.Name = "lbl_episodes";
            this.lbl_episodes.Size = new System.Drawing.Size(50, 13);
            this.lbl_episodes.TabIndex = 16;
            this.lbl_episodes.Text = "Episodes";
            // 
            // lbl_pod_description
            // 
            this.lbl_pod_description.AutoSize = true;
            this.lbl_pod_description.Location = new System.Drawing.Point(577, 125);
            this.lbl_pod_description.Name = "lbl_pod_description";
            this.lbl_pod_description.Size = new System.Drawing.Size(99, 13);
            this.lbl_pod_description.TabIndex = 17;
            this.lbl_pod_description.Text = "Episode description";
            // 
            // lbl_edit_category
            // 
            this.lbl_edit_category.AutoSize = true;
            this.lbl_edit_category.Location = new System.Drawing.Point(203, 58);
            this.lbl_edit_category.Name = "lbl_edit_category";
            this.lbl_edit_category.Size = new System.Drawing.Size(98, 13);
            this.lbl_edit_category.TabIndex = 19;
            this.lbl_edit_category.Text = "Edit category name";
            // 
            // lbl_new_category
            // 
            this.lbl_new_category.AutoSize = true;
            this.lbl_new_category.Location = new System.Drawing.Point(203, 15);
            this.lbl_new_category.Name = "lbl_new_category";
            this.lbl_new_category.Size = new System.Drawing.Size(73, 13);
            this.lbl_new_category.TabIndex = 20;
            this.lbl_new_category.Text = "New category";
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(29, 58);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(29, 13);
            this.lbl_url.TabIndex = 21;
            this.lbl_url.Text = "URL";
            // 
            // lbl_update_interval
            // 
            this.lbl_update_interval.AutoSize = true;
            this.lbl_update_interval.Location = new System.Drawing.Point(377, 58);
            this.lbl_update_interval.Name = "lbl_update_interval";
            this.lbl_update_interval.Size = new System.Drawing.Size(60, 13);
            this.lbl_update_interval.TabIndex = 22;
            this.lbl_update_interval.Text = "Set interval";
            // 
            // lbl_select_category
            // 
            this.lbl_select_category.AutoSize = true;
            this.lbl_select_category.Location = new System.Drawing.Point(377, 15);
            this.lbl_select_category.Name = "lbl_select_category";
            this.lbl_select_category.Size = new System.Drawing.Size(81, 13);
            this.lbl_select_category.TabIndex = 23;
            this.lbl_select_category.Text = "Select category";
            // 
            // lbl_podcast_name
            // 
            this.lbl_podcast_name.AutoSize = true;
            this.lbl_podcast_name.Location = new System.Drawing.Point(29, 15);
            this.lbl_podcast_name.Name = "lbl_podcast_name";
            this.lbl_podcast_name.Size = new System.Drawing.Size(130, 13);
            this.lbl_podcast_name.TabIndex = 24;
            this.lbl_podcast_name.Text = "Podcast name to add/edit";
            this.lbl_podcast_name.Click += new System.EventHandler(this.lbl_podcast_name_Click);
            // 
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(380, 30);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(165, 21);
            this.cb_category.TabIndex = 25;
            // 
            // btn_edit_category
            // 
            this.btn_edit_category.Location = new System.Drawing.Point(649, 53);
            this.btn_edit_category.Name = "btn_edit_category";
            this.btn_edit_category.Size = new System.Drawing.Size(80, 38);
            this.btn_edit_category.TabIndex = 26;
            this.btn_edit_category.Text = "Edit category";
            this.btn_edit_category.UseVisualStyleBackColor = true;
            this.btn_edit_category.Click += new System.EventHandler(this.btn_edit_category_Click);
            // 
            // btn_add_category
            // 
            this.btn_add_category.Location = new System.Drawing.Point(565, 53);
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.Size = new System.Drawing.Size(79, 38);
            this.btn_add_category.TabIndex = 27;
            this.btn_add_category.Text = "Add category";
            this.btn_add_category.UseVisualStyleBackColor = true;
            this.btn_add_category.Click += new System.EventHandler(this.btn_add_category_Click);
            // 
            // clb_episodes
            // 
            this.clb_episodes.FormattingEnabled = true;
            this.clb_episodes.Location = new System.Drawing.Point(405, 140);
            this.clb_episodes.Margin = new System.Windows.Forms.Padding(2);
            this.clb_episodes.Name = "clb_episodes";
            this.clb_episodes.Size = new System.Drawing.Size(151, 139);
            this.clb_episodes.TabIndex = 28;
            this.clb_episodes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clb_episodes_MouseClick_1);
            // 
            // btn_edit_pod_location
            // 
            this.btn_edit_pod_location.Location = new System.Drawing.Point(735, 15);
            this.btn_edit_pod_location.Name = "btn_edit_pod_location";
            this.btn_edit_pod_location.Size = new System.Drawing.Size(80, 38);
            this.btn_edit_pod_location.TabIndex = 29;
            this.btn_edit_pod_location.Text = "Edit podcast category";
            this.btn_edit_pod_location.UseVisualStyleBackColor = true;
            this.btn_edit_pod_location.Click += new System.EventHandler(this.btn_edit_pod_location_Click);
            // 
            // btn_edit_podcast_url
            // 
            this.btn_edit_podcast_url.Location = new System.Drawing.Point(735, 53);
            this.btn_edit_podcast_url.Name = "btn_edit_podcast_url";
            this.btn_edit_podcast_url.Size = new System.Drawing.Size(80, 38);
            this.btn_edit_podcast_url.TabIndex = 30;
            this.btn_edit_podcast_url.Text = "Edit podcast URL";
            this.btn_edit_podcast_url.UseVisualStyleBackColor = true;
            // 
            // btn_edit_podcast_name
            // 
            this.btn_edit_podcast_name.Location = new System.Drawing.Point(649, 15);
            this.btn_edit_podcast_name.Name = "btn_edit_podcast_name";
            this.btn_edit_podcast_name.Size = new System.Drawing.Size(80, 38);
            this.btn_edit_podcast_name.TabIndex = 31;
            this.btn_edit_podcast_name.Text = "Edit podcast name";
            this.btn_edit_podcast_name.UseVisualStyleBackColor = true;
            this.btn_edit_podcast_name.Click += new System.EventHandler(this.btn_edit_podcast_name_Click);
            // 
            // cb_interval
            // 
            this.cb_interval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_interval.FormattingEnabled = true;
            this.cb_interval.Location = new System.Drawing.Point(380, 74);
            this.cb_interval.Name = "cb_interval";
            this.cb_interval.Size = new System.Drawing.Size(165, 21);
            this.cb_interval.TabIndex = 32;
            // 
            // richtb_description
            // 
            this.richtb_description.Location = new System.Drawing.Point(579, 140);
            this.richtb_description.Margin = new System.Windows.Forms.Padding(2);
            this.richtb_description.Name = "richtb_description";
            this.richtb_description.ReadOnly = true;
            this.richtb_description.Size = new System.Drawing.Size(237, 140);
            this.richtb_description.TabIndex = 33;
            this.richtb_description.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(194, 367);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(501, 48);
            this.axWindowsMediaPlayer1.TabIndex = 34;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 427);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.richtb_description);
            this.Controls.Add(this.cb_interval);
            this.Controls.Add(this.btn_edit_podcast_name);
            this.Controls.Add(this.btn_edit_podcast_url);
            this.Controls.Add(this.btn_edit_pod_location);
            this.Controls.Add(this.clb_episodes);
            this.Controls.Add(this.btn_add_category);
            this.Controls.Add(this.btn_edit_category);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.lbl_podcast_name);
            this.Controls.Add(this.lbl_select_category);
            this.Controls.Add(this.lbl_update_interval);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_new_category);
            this.Controls.Add(this.lbl_edit_category);
            this.Controls.Add(this.lbl_pod_description);
            this.Controls.Add(this.lbl_episodes);
            this.Controls.Add(this.lbl_podcast);
            this.Controls.Add(this.lbl_categories);
            this.Controls.Add(this.lb_podcast);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.txtBox_url);
            this.Controls.Add(this.txtBox_new_category);
            this.Controls.Add(this.txtBox_edit_category);
            this.Controls.Add(this.txtBox_new_pod);
            this.Controls.Add(this.btn_add_podcast);
            this.Controls.Add(this.btn_play_podcast);
            this.Controls.Add(this.btn_delete_episode);
            this.Controls.Add(this.btn_delete_podcast);
            this.Controls.Add(this.btn_delete_category);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_category;
        private System.Windows.Forms.Button btn_delete_podcast;
        private System.Windows.Forms.Button btn_delete_episode;
        private System.Windows.Forms.Button btn_play_podcast;
        private System.Windows.Forms.Button btn_add_podcast;
        private System.Windows.Forms.TextBox txtBox_new_pod;
        private System.Windows.Forms.TextBox txtBox_edit_category;
        private System.Windows.Forms.TextBox txtBox_new_category;
        private System.Windows.Forms.TextBox txtBox_url;
        private System.Windows.Forms.ListBox lb_category;
        private System.Windows.Forms.ListBox lb_podcast;
        private System.Windows.Forms.Label lbl_categories;
        private System.Windows.Forms.Label lbl_podcast;
        private System.Windows.Forms.Label lbl_episodes;
        private System.Windows.Forms.Label lbl_pod_description;
        private System.Windows.Forms.Label lbl_edit_category;
        private System.Windows.Forms.Label lbl_new_category;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label lbl_update_interval;
        private System.Windows.Forms.Label lbl_select_category;
        private System.Windows.Forms.Label lbl_podcast_name;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_edit_category;
        private System.Windows.Forms.Button btn_add_category;
        private System.Windows.Forms.CheckedListBox clb_episodes;
        private System.Windows.Forms.Button btn_edit_pod_location;
        private System.Windows.Forms.Button btn_edit_podcast_url;
        private System.Windows.Forms.Button btn_edit_podcast_name;
        private System.Windows.Forms.ComboBox cb_interval;
        private System.Windows.Forms.RichTextBox richtb_description;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

