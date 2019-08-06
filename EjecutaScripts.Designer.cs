namespace EjecutaScripts
{
    partial class EjecutaScripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjecutaScripts));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Server = new System.Windows.Forms.TextBox();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_DB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Success = new System.Windows.Forms.Label();
            this.lbl_Fail = new System.Windows.Forms.Label();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.lv_Scripts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(26, 39);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(143, 20);
            this.tb_Server.TabIndex = 1;
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(324, 39);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(143, 20);
            this.tb_User.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(473, 39);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(143, 20);
            this.tb_Password.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // tb_DB
            // 
            this.tb_DB.Location = new System.Drawing.Point(175, 39);
            this.tb_DB.Name = "tb_DB";
            this.tb_DB.Size = new System.Drawing.Size(143, 20);
            this.tb_DB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Base de datos";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(516, 469);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 30);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Limpiar lista";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Success
            // 
            this.lbl_Success.AutoSize = true;
            this.lbl_Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Success.ForeColor = System.Drawing.Color.Green;
            this.lbl_Success.Location = new System.Drawing.Point(23, 424);
            this.lbl_Success.Name = "lbl_Success";
            this.lbl_Success.Size = new System.Drawing.Size(129, 13);
            this.lbl_Success.TabIndex = 9;
            this.lbl_Success.Text = "Se ejecutó correctamente";
            // 
            // lbl_Fail
            // 
            this.lbl_Fail.AutoSize = true;
            this.lbl_Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fail.ForeColor = System.Drawing.Color.Red;
            this.lbl_Fail.Location = new System.Drawing.Point(23, 451);
            this.lbl_Fail.Name = "lbl_Fail";
            this.lbl_Fail.Size = new System.Drawing.Size(89, 13);
            this.lbl_Fail.TabIndex = 10;
            this.lbl_Fail.Text = "Falló la ejecución";
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(516, 424);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(100, 30);
            this.btn_Ejecutar.TabIndex = 11;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // lv_Scripts
            // 
            this.lv_Scripts.AllowDrop = true;
            this.lv_Scripts.Location = new System.Drawing.Point(26, 80);
            this.lv_Scripts.Name = "lv_Scripts";
            this.lv_Scripts.Size = new System.Drawing.Size(590, 324);
            this.lv_Scripts.TabIndex = 8;
            this.lv_Scripts.UseCompatibleStateImageBehavior = false;
            this.lv_Scripts.View = System.Windows.Forms.View.List;
            this.lv_Scripts.DragDrop += new System.Windows.Forms.DragEventHandler(this.lv_Scripts_DragDrop);
            this.lv_Scripts.DragEnter += new System.Windows.Forms.DragEventHandler(this.lv_Scripts_DragEnter);
            // 
            // EjecutaScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(646, 527);
            this.Controls.Add(this.lv_Scripts);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.lbl_Fail);
            this.Controls.Add(this.lbl_Success);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.tb_DB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Server);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EjecutaScripts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EjecutaScripts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Server;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_DB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Success;
        private System.Windows.Forms.Label lbl_Fail;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.ListView lv_Scripts;
    }
}

