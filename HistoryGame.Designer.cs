﻿namespace GameNT106
{
    partial class HistoryGame
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
            dataGridView1 = new DataGridView();
            Opponent = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Opponent, Result });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1040, 576);
            dataGridView1.TabIndex = 0;
            // 
            // Opponent
            // 
            Opponent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Opponent.HeaderText = "Opponent";
            Opponent.MinimumWidth = 8;
            Opponent.Name = "Opponent";
            // 
            // Result
            // 
            Result.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Result.HeaderText = "Result";
            Result.MinimumWidth = 8;
            Result.Name = "Result";
            // 
            // HistoryGame
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "HistoryGame";
            Text = "HistoryGame";
            Load += HistoryGame_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Opponent;
        private DataGridViewTextBoxColumn Result;
    }
}