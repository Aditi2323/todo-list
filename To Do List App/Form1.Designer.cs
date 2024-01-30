namespace To_Do_List_App
{
    partial class ToDoList
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.new_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.toDoListView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1075, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(7, 124);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(1060, 26);
            this.titleTextBox.TabIndex = 1;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(7, 190);
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(1060, 26);
            this.descriptionTextbox.TabIndex = 2;
            // 
            // new_button
            // 
            this.new_button.Location = new System.Drawing.Point(7, 222);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(243, 44);
            this.new_button.TabIndex = 3;
            this.new_button.Text = "New";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(256, 222);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(267, 44);
            this.edit_button.TabIndex = 4;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(529, 222);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(274, 44);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(799, 222);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(268, 44);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // toDoListView
            // 
            this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toDoListView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoListView.Location = new System.Drawing.Point(7, 272);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.RowTemplate.Height = 28;
            this.toDoListView.Size = new System.Drawing.Size(1060, 252);
            this.toDoListView.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1049, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1049, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1079, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDoListView);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ToDoList";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridView toDoListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

