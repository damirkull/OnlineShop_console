namespace WinFormOnlineShop_2026
{
    partial class UserCart
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
            listBoxUserCart = new ListBox();
            buttonQuit = new Button();
            labelPrice = new Label();
            SuspendLayout();
            // 
            // listBoxUserCart
            // 
            listBoxUserCart.FormattingEnabled = true;
            listBoxUserCart.ItemHeight = 15;
            listBoxUserCart.Location = new Point(14, 11);
            listBoxUserCart.Name = "listBoxUserCart";
            listBoxUserCart.Size = new Size(221, 574);
            listBoxUserCart.TabIndex = 0;
            listBoxUserCart.SelectedIndexChanged += listBoxUserCart_SelectedIndexChanged;
            // 
            // buttonQuit
            // 
            buttonQuit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonQuit.Location = new Point(241, 485);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(154, 100);
            buttonQuit.TabIndex = 1;
            buttonQuit.Text = "Выход";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPrice.Location = new Point(241, 424);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(56, 21);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Цена: ";
            // 
            // UserCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 600);
            Controls.Add(labelPrice);
            Controls.Add(buttonQuit);
            Controls.Add(listBoxUserCart);
            Name = "UserCart";
            Text = "UserCart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxUserCart;
        private Button buttonQuit;
        private Label labelPrice;
    }
}