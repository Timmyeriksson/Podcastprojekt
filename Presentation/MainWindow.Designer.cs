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
            this.btn_delete_category = new System.Windows.Forms.Button();
            this.btn_delete_podcast = new System.Windows.Forms.Button();
            this.btn_delete_episode = new System.Windows.Forms.Button();
            this.btn_play_podcast = new System.Windows.Forms.Button();
            this.btn_add_podcast = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBox_new_category = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lb_category = new System.Windows.Forms.ListBox();
            this.lb_episode = new System.Windows.Forms.ListBox();
            this.lb_podcast = new System.Windows.Forms.ListBox();
            this.lbl_categories = new System.Windows.Forms.Label();
            this.lbl_podcast = new System.Windows.Forms.Label();
            this.lbl_episodes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.ListBox();
            this.lbl_edit_category = new System.Windows.Forms.Label();
            this.lbl_new_category = new System.Windows.Forms.Label();
            this.lbl_url = new System.Windows.Forms.Label();
            this.lbl_update_interval = new System.Windows.Forms.Label();
            this.lbl_select_category = new System.Windows.Forms.Label();
            this.lbl_podcast_name = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_edit_category = new System.Windows.Forms.Button();
            this.btn_add_category = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_delete_category
            // 
            this.btn_delete_category.Location = new System.Drawing.Point(56, 207);
            this.btn_delete_category.Name = "btn_delete_category";
            this.btn_delete_category.Size = new System.Drawing.Size(85, 42);
            this.btn_delete_category.TabIndex = 0;
            this.btn_delete_category.Text = "Delete category";
            this.btn_delete_category.UseVisualStyleBackColor = true;
            this.btn_delete_category.Click += new System.EventHandler(this.btn_delete_category_Click);
            // 
            // btn_delete_podcast
            // 
            this.btn_delete_podcast.Location = new System.Drawing.Point(251, 207);
            this.btn_delete_podcast.Name = "btn_delete_podcast";
            this.btn_delete_podcast.Size = new System.Drawing.Size(85, 42);
            this.btn_delete_podcast.TabIndex = 1;
            this.btn_delete_podcast.Text = "Delete podcast";
            this.btn_delete_podcast.UseVisualStyleBackColor = true;
            // 
            // btn_delete_episode
            // 
            this.btn_delete_episode.Location = new System.Drawing.Point(456, 207);
            this.btn_delete_episode.Name = "btn_delete_episode";
            this.btn_delete_episode.Size = new System.Drawing.Size(85, 42);
            this.btn_delete_episode.TabIndex = 2;
            this.btn_delete_episode.Text = "Delete episode";
            this.btn_delete_episode.UseVisualStyleBackColor = true;
            // 
            // btn_play_podcast
            // 
            this.btn_play_podcast.Location = new System.Drawing.Point(397, 350);
            this.btn_play_podcast.Name = "btn_play_podcast";
            this.btn_play_podcast.Size = new System.Drawing.Size(115, 72);
            this.btn_play_podcast.TabIndex = 3;
            this.btn_play_podcast.Text = "Play podcast";
            this.btn_play_podcast.UseVisualStyleBackColor = true;
            // 
            // btn_add_podcast
            // 
            this.btn_add_podcast.Location = new System.Drawing.Point(775, 338);
            this.btn_add_podcast.Name = "btn_add_podcast";
            this.btn_add_podcast.Size = new System.Drawing.Size(121, 38);
            this.btn_add_podcast.TabIndex = 4;
            this.btn_add_podcast.Text = "Add podcast";
            this.btn_add_podcast.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(775, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(775, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 6;
            // 
            // txtBox_new_category
            // 
            this.txtBox_new_category.Location = new System.Drawing.Point(775, 144);
            this.txtBox_new_category.Name = "txtBox_new_category";
            this.txtBox_new_category.Size = new System.Drawing.Size(121, 20);
            this.txtBox_new_category.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(775, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(775, 292);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 10;
            // 
            // lb_category
            // 
            this.lb_category.FormattingEnabled = true;
            this.lb_category.Location = new System.Drawing.Point(56, 43);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(171, 147);
            this.lb_category.TabIndex = 11;
            // 
            // lb_episode
            // 
            this.lb_episode.FormattingEnabled = true;
            this.lb_episode.Location = new System.Drawing.Point(456, 46);
            this.lb_episode.Name = "lb_episode";
            this.lb_episode.Size = new System.Drawing.Size(198, 147);
            this.lb_episode.TabIndex = 12;
            // 
            // lb_podcast
            // 
            this.lb_podcast.FormattingEnabled = true;
            this.lb_podcast.Location = new System.Drawing.Point(251, 46);
            this.lb_podcast.Name = "lb_podcast";
            this.lb_podcast.Size = new System.Drawing.Size(180, 147);
            this.lb_podcast.TabIndex = 13;
            // 
            // lbl_categories
            // 
            this.lbl_categories.AutoSize = true;
            this.lbl_categories.Location = new System.Drawing.Point(53, 27);
            this.lbl_categories.Name = "lbl_categories";
            this.lbl_categories.Size = new System.Drawing.Size(57, 13);
            this.lbl_categories.TabIndex = 14;
            this.lbl_categories.Text = "Categories";
            // 
            // lbl_podcast
            // 
            this.lbl_podcast.AutoSize = true;
            this.lbl_podcast.Location = new System.Drawing.Point(248, 27);
            this.lbl_podcast.Name = "lbl_podcast";
            this.lbl_podcast.Size = new System.Drawing.Size(51, 13);
            this.lbl_podcast.TabIndex = 15;
            this.lbl_podcast.Text = "Podcasts";
            // 
            // lbl_episodes
            // 
            this.lbl_episodes.AutoSize = true;
            this.lbl_episodes.Location = new System.Drawing.Point(453, 30);
            this.lbl_episodes.Name = "lbl_episodes";
            this.lbl_episodes.Size = new System.Drawing.Size(50, 13);
            this.lbl_episodes.TabIndex = 16;
            this.lbl_episodes.Text = "Episodes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Podcast description";
            // 
            // lb_description
            // 
            this.lb_description.FormattingEnabled = true;
            this.lb_description.Location = new System.Drawing.Point(56, 292);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(276, 147);
            this.lb_description.TabIndex = 18;
            // 
            // lbl_edit_category
            // 
            this.lbl_edit_category.AutoSize = true;
            this.lbl_edit_category.Location = new System.Drawing.Point(772, 177);
            this.lbl_edit_category.Name = "lbl_edit_category";
            this.lbl_edit_category.Size = new System.Drawing.Size(98, 13);
            this.lbl_edit_category.TabIndex = 19;
            this.lbl_edit_category.Text = "Edit category name";
            // 
            // lbl_new_category
            // 
            this.lbl_new_category.AutoSize = true;
            this.lbl_new_category.Location = new System.Drawing.Point(774, 128);
            this.lbl_new_category.Name = "lbl_new_category";
            this.lbl_new_category.Size = new System.Drawing.Size(73, 13);
            this.lbl_new_category.TabIndex = 20;
            this.lbl_new_category.Text = "New category";
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(772, 79);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(29, 13);
            this.lbl_url.TabIndex = 21;
            this.lbl_url.Text = "URL";
            // 
            // lbl_update_interval
            // 
            this.lbl_update_interval.AutoSize = true;
            this.lbl_update_interval.Location = new System.Drawing.Point(776, 276);
            this.lbl_update_interval.Name = "lbl_update_interval";
            this.lbl_update_interval.Size = new System.Drawing.Size(79, 13);
            this.lbl_update_interval.TabIndex = 22;
            this.lbl_update_interval.Text = "Update interval";
            // 
            // lbl_select_category
            // 
            this.lbl_select_category.AutoSize = true;
            this.lbl_select_category.Location = new System.Drawing.Point(774, 222);
            this.lbl_select_category.Name = "lbl_select_category";
            this.lbl_select_category.Size = new System.Drawing.Size(81, 13);
            this.lbl_select_category.TabIndex = 23;
            this.lbl_select_category.Text = "Select category";
            // 
            // lbl_podcast_name
            // 
            this.lbl_podcast_name.AutoSize = true;
            this.lbl_podcast_name.Location = new System.Drawing.Point(772, 27);
            this.lbl_podcast_name.Name = "lbl_podcast_name";
            this.lbl_podcast_name.Size = new System.Drawing.Size(75, 13);
            this.lbl_podcast_name.TabIndex = 24;
            this.lbl_podcast_name.Text = "Podcast name";
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(775, 238);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(121, 21);
            this.cb_category.TabIndex = 25;
            // 
            // btn_edit_category
            // 
            this.btn_edit_category.Location = new System.Drawing.Point(775, 428);
            this.btn_edit_category.Name = "btn_edit_category";
            this.btn_edit_category.Size = new System.Drawing.Size(121, 38);
            this.btn_edit_category.TabIndex = 26;
            this.btn_edit_category.Text = "Edit category";
            this.btn_edit_category.UseVisualStyleBackColor = true;
            // 
            // btn_add_category
            // 
            this.btn_add_category.Location = new System.Drawing.Point(775, 384);
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.Size = new System.Drawing.Size(121, 38);
            this.btn_add_category.TabIndex = 27;
            this.btn_add_category.Text = "Add category";
            this.btn_add_category.UseVisualStyleBackColor = true;
            this.btn_add_category.Click += new System.EventHandler(this.btn_add_category_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 486);
            this.Controls.Add(this.btn_add_category);
            this.Controls.Add(this.btn_edit_category);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.lbl_podcast_name);
            this.Controls.Add(this.lbl_select_category);
            this.Controls.Add(this.lbl_update_interval);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_new_category);
            this.Controls.Add(this.lbl_edit_category);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_episodes);
            this.Controls.Add(this.lbl_podcast);
            this.Controls.Add(this.lbl_categories);
            this.Controls.Add(this.lb_podcast);
            this.Controls.Add(this.lb_episode);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtBox_new_category);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_add_podcast);
            this.Controls.Add(this.btn_play_podcast);
            this.Controls.Add(this.btn_delete_episode);
            this.Controls.Add(this.btn_delete_podcast);
            this.Controls.Add(this.btn_delete_category);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete_category;
        private System.Windows.Forms.Button btn_delete_podcast;
        private System.Windows.Forms.Button btn_delete_episode;
        private System.Windows.Forms.Button btn_play_podcast;
        private System.Windows.Forms.Button btn_add_podcast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtBox_new_category;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox lb_category;
        private System.Windows.Forms.ListBox lb_episode;
        private System.Windows.Forms.ListBox lb_podcast;
        private System.Windows.Forms.Label lbl_categories;
        private System.Windows.Forms.Label lbl_podcast;
        private System.Windows.Forms.Label lbl_episodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_description;
        private System.Windows.Forms.Label lbl_edit_category;
        private System.Windows.Forms.Label lbl_new_category;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label lbl_update_interval;
        private System.Windows.Forms.Label lbl_select_category;
        private System.Windows.Forms.Label lbl_podcast_name;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_edit_category;
        private System.Windows.Forms.Button btn_add_category;
    }
}

