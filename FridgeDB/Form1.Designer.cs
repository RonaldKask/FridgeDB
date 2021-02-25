namespace FridgeDB
{
    partial class Form1
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
            this.Food = new System.Windows.Forms.Label();
            this.listFood = new System.Windows.Forms.ListBox();
            this.FoodName = new System.Windows.Forms.Label();
            this.listFoodNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.Location = new System.Drawing.Point(103, 81);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(31, 13);
            this.Food.TabIndex = 0;
            this.Food.Text = "Food";
            // 
            // listFood
            // 
            this.listFood.FormattingEnabled = true;
            this.listFood.Location = new System.Drawing.Point(106, 197);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(178, 173);
            this.listFood.TabIndex = 1;
            this.listFood.SelectedIndexChanged += new System.EventHandler(this.listFood_SelectedIndexChanged);
            // 
            // FoodName
            // 
            this.FoodName.AutoSize = true;
            this.FoodName.Location = new System.Drawing.Point(433, 81);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(59, 13);
            this.FoodName.TabIndex = 2;
            this.FoodName.Text = "FoodName";
            // 
            // listFoodNames
            // 
            this.listFoodNames.FormattingEnabled = true;
            this.listFoodNames.Location = new System.Drawing.Point(436, 197);
            this.listFoodNames.Name = "listFoodNames";
            this.listFoodNames.Size = new System.Drawing.Size(166, 173);
            this.listFoodNames.TabIndex = 3;
            this.listFoodNames.SelectedIndexChanged += new System.EventHandler(this.listFoodNames_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listFoodNames);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.listFood);
            this.Controls.Add(this.Food);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Food;
        private System.Windows.Forms.ListBox listFood;
        private System.Windows.Forms.Label FoodName;
        private System.Windows.Forms.ListBox listFoodNames;
    }
}

